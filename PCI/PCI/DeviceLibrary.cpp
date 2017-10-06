#include "Header.h"
#define MAX_SIZE_OF_STRING 150
DeviceLibrary::DeviceLibrary()
{
}

DeviceLibrary::~DeviceLibrary()
{
}

void DeviceLibrary::GetDescription(vector<_PCI_DEVTABLE> *devices)
{
	char *temp = (char *)malloc(MAX_SIZE_OF_STRING * sizeof(char));
	file.open(FILE_PATH, ios_base::in);
	if (!file.is_open())
	{
		cout << "\nCan't open file " << FILE_PATH << " !" << endl;
		return;
	}
	int i = 0;
	while (!file.eof())
	{
		if (file.eof()) break;
		file.getline(temp, MAX_SIZE_OF_STRING);

		if (temp[0] == '#' || temp[0] == '\n') continue;
		if (temp[0] != '\t')
		{
			IdenticVendor(string(temp), devices);
		}
		else if (temp[0] == '\t' && temp[1] != '\t') {
			IdenticDevice(string(temp), devices);
		}
		if (i == 29477) break;
		i++;
	}
	file.close();
	return;
}

void DeviceLibrary::IdenticVendor(string str, vector<_PCI_DEVTABLE> *devices)
{
	if (str.empty()) return;
	bool flag = false;
	for (int i = 0; i < 4; ++i)
	{

		if (str[i] >= 'a' && str[i] <= 'z')
		{
			str[i] -= 32;
		}
	}

	for (int k = 0; k < devices->size(); ++k)
	{
		if (str.substr(0, 4) == (*devices)[k].VendorId.substr(2, 4)) {
			(*devices)[k].description = str.substr(4);
		}
	}

	return;
}

void DeviceLibrary::IdenticDevice(string str, vector<_PCI_DEVTABLE> *devices)
{
	if (str.empty()) return;
	bool flag = false;

	for (int i = 1; i < 5; ++i)
	{
		if (str[i] >= 'a' && str[i] <= 'z')
		{
			str[i] -= 32;
		}
	}

	for (int k = 0; k < devices->size(); k++)
	{

		if (str.substr(1, 4) == (*devices)[k].DeviceId.substr(2, 4))
		{
			(*devices)[k].name = str.substr(5);
		}
	}
	return;
}