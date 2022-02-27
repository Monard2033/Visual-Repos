#include <iostream>
#include <string.h>
#include "Cake.h"
#include "CakeMaker.h"
Cake::Cake()
{
	name = "name";
}
Cake::Cake(string n)
{
	this->name = n;
}
string Cake::getName()
{
	return this->name;
}
