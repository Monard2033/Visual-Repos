#pragma once
#include <iostream>
#include <string.h>
using namespace std;
class RecipeCake
{
public:
	RecipeCake();
	RecipeCake(string name, int time);
	string getName();
	int getTime();
private:
	string name;
	int time;
};
