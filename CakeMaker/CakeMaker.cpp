#include <iostream>
#include <string.h>
#include <Windows.h>
#include "CakeMaker.h"
CakeMaker::CakeMaker()
{}

Cake CakeMaker::takeCommand(RecipeCake recipe)
{
	string name = recipe.getName();
	int time = recipe.getTime();
	Cake alt = Cake(name);
	cout << "\nPrajitura se pregateste, asteptati 5 secunde!\n";
	for (int i = 5; i >= 1; i--)
	{
		Sleep(1000);
		cout << "Au ramas " << i << " secunde\n";
	}
	cout << "\nPrajitura este gata!\n\n";
	Sleep(100);
	return alt;
}

