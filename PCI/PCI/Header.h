#pragma once
#include <iostream>
#include <fstream>
#include <cstdio>
#include <vector>
#include <string>

#define FILE_PATH "pci.txt"

using namespace std;

typedef struct _PCI_DEVTABLE
{
	string	VendorId;
	string	DeviceId;
	string	name;
	string description;
};

class DeviceLibrary
{
public:
	DeviceLibrary();
	~DeviceLibrary();

	void GetDescription(vector<_PCI_DEVTABLE>*);

private:
	fstream file;

	void IdenticVendor(string, vector<_PCI_DEVTABLE>*);
	void IdenticDevice(string, vector<_PCI_DEVTABLE>*);
};
