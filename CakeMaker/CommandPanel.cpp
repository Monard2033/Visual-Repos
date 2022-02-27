#include <iostream>
#include "CommandPanel.h"

CommandPanel::CommandPanel()
{
	RecipeCake c0 = RecipeCake("Tiramisu", 5);
	RecipeCake c1 = RecipeCake("Ciocarlia", 5);
	RecipeCake c2 = RecipeCake("Napoleon", 5);
	RecipeCake c3 = RecipeCake("PrintulNegru", 5);
	menu.push_back(c0);
	menu.push_back(c1);
	menu.push_back(c2);
	menu.push_back(c3);

	if (commandTaker.checkCarouselOfCakes() == 0)
		commandTaker.refillCarousel();
}

void CommandPanel::showProducts()
{
	list<RecipeCake>::iterator rc;
	for (rc = menu.begin(); rc != menu.end(); ++rc)
		cout << rc->getName() << "\n";
}

void CommandPanel::selectProduct(string p)
{
	bool ok = 0;
	list<RecipeCake>::iterator rc;
	for (rc = menu.begin(); rc != menu.end(); rc++)
		if (rc->getName() == p)
			ok = 1;
		if (ok == 0)
			cout << "\nNe pare rau , dar aceasta prajitura nu face parte din meniul nostru!\n";
		else
			commandTaker.takeCommand(p);
}

void CommandPanel::selectProduct(string p, int nrp)
{
	bool ok = 0;
	list<RecipeCake>::iterator rc;
	for (rc = menu.begin(); rc != menu.end(); rc++)
		if (rc->getName() == p)
		{
			ok = 1;
		}

	if (ok == 0)
	{
		cout << "Ne pare rau , dar aceasta prajitura nu face parte din meniul nostru!\n";
	}

	else if (1 <= nrp && nrp <= 20) 
	{

		RecipeCake rc = RecipeCake(p, 5);
		commandTaker.takeCommand(rc, nrp);
	}
	else
	cout << "Ne pare rau, dar aparatul poate produce doar 20 de bucati.\n";
}

void CommandPanel::showProductInCarousel()
{
	commandTaker.getCakesFromCarousel();
}
