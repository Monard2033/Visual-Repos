#include <iostream>
#include <string.h>
#include "RecipeCake.h"

RecipeCake::RecipeCake()
{
	name = "n/a";
	time = 1;
}

RecipeCake::RecipeCake(string n, int t)
{
	this->name = n;
	this->time = t;
}
string RecipeCake::getName()
{
	return this->name;
}
int RecipeCake::getTime()
{
	return this->time;
}
