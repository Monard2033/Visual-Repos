#pragma once
#include "RecipeCake.h"
#include "ComandTaker.h"
#include "RecipeCake.h"
#include <list>
using namespace std;
class CommandPanel
{
public:
	CommandPanel();
	void showProducts();
	void selectProduct(string p);
	void selectProduct(string p, int nrp);
	void showProductInCarousel();
private:
	list<RecipeCake> menu;
	CommandTaker commandTaker;

};

