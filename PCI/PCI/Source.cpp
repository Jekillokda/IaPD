#pragma comment (lib, "Setupapi.lib")

#include <stdio.h>
#include <windows.h>
#include <setupapi.h>
#include <devguid.h>
#include <regstr.h>
#include <locale.h>
#include <list>
#include <iterator>
#include <iostream>
#include <string>
#include <fstream>
#include <limits>
#include "Header.h"
using namespace std;

void init(HDEVINFO&);
vector<string> getInfo(HDEVINFO, SP_DEVINFO_DATA);
vector<_PCI_DEVTABLE> getDescriptions(vector<string>);
void print(vector<_PCI_DEVTABLE>);

int main(int argc, char *argv[])
{
	setlocale(LC_ALL, "Russian");

	HDEVINFO hDev;
	init(hDev);

	SP_DEVINFO_DATA deviceInfo;
	deviceInfo.cbSize = sizeof(SP_DEVINFO_DATA);
	vector<_PCI_DEVTABLE> devices = getDescriptions(getInfo(hDev, deviceInfo));
	print(devices);
	return 0;
}

void init(HDEVINFO& hDevInfo)
{
	if ((hDevInfo = SetupDiGetClassDevs(NULL,
		REGSTR_KEY_PCIENUM,
		0,
		DIGCF_PRESENT | DIGCF_ALLCLASSES)) == INVALID_HANDLE_VALUE)		//Return only devices that are currently present.
	{
		exit(1);
	}
}

vector<string> getInfo(HDEVINFO _hDev, SP_DEVINFO_DATA _deviceInfo)
{
	vector<string> result;

	for (DWORD i = 0; SetupDiEnumDeviceInfo(_hDev, i, &_deviceInfo); i++)
	{
		LPTSTR buffer = NULL;
		DWORD bufferSize = 0;

		while (!SetupDiGetDeviceRegistryProperty(_hDev,  // retrieves a specified Plug and Play device property
			&_deviceInfo,
			SPDRP_HARDWAREID, //retrieves a REG_MULTI_SZ string that contains the list of hardware IDs for a device. 
			NULL,
			(PBYTE)buffer,
			bufferSize,
			&bufferSize))
		{
			if (GetLastError() == ERROR_INSUFFICIENT_BUFFER) //The data area passed to a system call is too small
			{
				if (buffer) LocalFree(buffer);
				buffer = (LPTSTR)LocalAlloc(LPTR, bufferSize * 2);
			}
			else break;
		}

		result.push_back(string(buffer));

		if (buffer) LocalFree(buffer);
	}

	return result;
}

vector<_PCI_DEVTABLE> getDescriptions(vector<string> _devices)
{
	vector<_PCI_DEVTABLE> result;
	DeviceLibrary *lib = new DeviceLibrary();

	while (_devices.size() != 0)
	{
		string vendor = "0x" + _devices.back().substr(8, 4);
		string device = "0x" + _devices.back().substr(17, 4);
		_devices.pop_back();
		_PCI_DEVTABLE temp;
		temp.VendorId = vendor;
		temp.DeviceId = device;
		result.push_back(temp);
	}
	lib->GetDescription(&result);
	return result;
}
void print(vector<_PCI_DEVTABLE> devices) {
	for (int i = 0; i < devices.size(); i++)
	{
		cout << i + 1;
		cout << ".DeviceID: " << devices[i].DeviceId.c_str() << endl << "   VendorID: " << devices[i].VendorId.c_str()
			<< endl << "   Description: " << devices[i].name.c_str() << endl << "   Producer: " << devices[i].description.c_str() << endl << endl;
	}

	system("pause");
}
