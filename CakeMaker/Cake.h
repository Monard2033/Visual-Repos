#pragma once
#include <iostream>
#include <string.h>
using namespace std;
class Cake
{
public:
	Cake();
	Cake(string n);
	string getName();
private:
	string name;
};
