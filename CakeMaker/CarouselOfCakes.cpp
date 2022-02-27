#include <iostream>
#include <string.h>
#include "CarouselOfCakes.h"
#include "Cake.h"

CarouselOfCakes::CarouselOfCakes()
{
	for (int i = 0; i < maxCapacity; i++) 
	{
		storage[i] = nullptr;
	}
}

bool CarouselOfCakes::addCake(Cake n)
{
	for (int b = 0; b < maxCapacity; b++) 
	{
		if (storage[b] != nullptr)
		{

		}
		else
		{
			storage[b] = new Cake(n.getName());
			return 1;
		}
	}
	return 0;
}

Cake CarouselOfCakes::getCake(string cn)
{
	for (int i = 0; i < maxCapacity; i++)
	{
		if (storage[i] != nullptr)
		{
			if ((*storage[i]).getName().compare(cn) != 1)
			{
				Cake tkc = *storage[i];
				delete storage[i];
				storage[i] = nullptr;
				return tkc;
			}
		}
	}
	return Cake("");
}

int CarouselOfCakes::getCurentCapacity()
{
	unsigned int size = 0;
	for (int h = 0; h < maxCapacity; h++) 
	{
		if (storage[h] != nullptr) 
		{
			size++;
		}
	}
	return size;
}

void CarouselOfCakes::getCakesFromCarousel()
{
	unsigned int i = 0;
	for (i = 0; i < getCurentCapacity(); i++)
		cout << storage[i]->getName() << " ";
	cout << '\n';
}

