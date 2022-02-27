#pragma once
#include <iostream>
#include <string.h>
#include "Cake.h"
using namespace std;
class CarouselOfCakes
{
public:
	CarouselOfCakes();
	bool addCake(Cake cn);
	Cake getCake(string cn);
	int getCurentCapacity();
	void getCakesFromCarousel();
private:
	Cake* storage[10];
	unsigned int maxCapacity = 10;
	unsigned int lowLimit = 3;

};



