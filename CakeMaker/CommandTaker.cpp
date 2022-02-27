#include <iostream>
#include "ComandTaker.h"
CommandTaker::CommandTaker()
{
}
CommandTaker::CommandTaker(RecipeCake recipe)
{
	carouselRecipe = recipe;
}
Cake CommandTaker::takeCommand(RecipeCake recipe)
{
	Cake ct = carousel.getCake(recipe.getName());
	if (ct.getName() != "")
		return ct;
	else
		ct = cakeMaker.takeCommand(recipe);
	return ct;
}

Cake* CommandTaker::takeCommand(RecipeCake recipe, int nrC)
{
	int i = 0;
	Cake r[20];

	while (nrC) 
	{
		cout << "Pregatim prajitura: " << recipe.getName() << " cu numarul ->" << i + 1 << ".\n";
		cout << "Prajituri ramase -> " << nrC - 1 << "\n";
		r[i] = cakeMaker.takeCommand(recipe);
		nrC--;
		i++;
	}
	return r;
}

Cake CommandTaker::takeCommand(string noc)
{
	RecipeCake rc = RecipeCake(noc, 5);
	Cake a = carousel.getCake(rc.getName());
	if (a.getName() != "")
		return a;
	else
		a = cakeMaker.takeCommand(rc);
	return a;
}

void CommandTaker::getCakesFromCarousel()
{
	carousel.getCakesFromCarousel();
}

bool CommandTaker::checkCarouselOfCakes()
{
	if (carousel.getCurentCapacity()< 3)
	{
		return 0;
	}
	return 1;
}

bool CommandTaker::refillCarousel()
{
	int size = carousel.getCurentCapacity();
	bool check;
	Cake cn = Cake(carouselRecipe.getName());
	while (size < 10) 
	{
		check = carousel.addCake(cn);
		size++;
	}

	return check;
}
