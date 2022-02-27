#pragma once
#include <iostream>
#include <string.h>
#include "RecipeCake.h"
#include "Cake.h"
using namespace std;
class CakeMaker  
{
public:
	   CakeMaker();
	 Cake takeCommand(RecipeCake recipe);
private:
};
