#pragma once
#include <iostream>
#include "RecipeCake.h"
#include "CakeMaker.h"
#include "CarouselOfCakes.h"
#include <list>
using namespace std;
class CommandTaker
{
public:
	CommandTaker();
	CommandTaker(RecipeCake recipe);
	Cake takeCommand(RecipeCake recipe);
	Cake* takeCommand(RecipeCake recipe, int nrC);
	Cake takeCommand(string noc);
	void getCakesFromCarousel();
	bool checkCarouselOfCakes();
	bool refillCarousel();
 
private:
	RecipeCake carouselRecipe;
	CakeMaker cakeMaker;
	CarouselOfCakes carousel;
};
