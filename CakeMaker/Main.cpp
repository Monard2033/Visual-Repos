#include <iostream>
#include "CommandPanel.h"
using namespace std;
int main()
{
	CommandPanel CP = CommandPanel();
	string p;
	int opt, n;
	do
	{M:
		cout << "1.Afisarea tuturor produselor pentru cumparare\n";
		cout << "2.Selectare produs dorit nespecificand cantitatea\n";
		cout << "3.Selectare produs dorit + cantitatea dorita\n";
		cout << "4.Afisare produse disponibile la moment!\n";
		cout << "5.Iesire\n";
		cout << "Select option: ";
		cin >> opt;
		switch (opt)
		{
		case 1:
			system("cls");
			CP.showProducts();
			cout << "\n\n";
			system("pause");
			system("cls");
			break;
		case 2:
			system("cls");
			cout << "Ce prajitura doriti sa comandati ?-> ";
			cin >> p;
			CP.selectProduct(p);
			cout << "\n\n";
			system("pause");
			system("cls");
			break;
		case 3:
			system("cls");
			cout << "Ce prajitura doriti sa comandati ? -> ";
			cin >> p;
			cout << "\nCate bucati doriti sa comandati ? -> ";
			cin >> n;
			cout << "\n";
			CP.selectProduct(p, n);
			cout << "\n\n";
			system("pause");
			system("cls");
			break;
		case 4:
			system("cls");
			CP.showProductInCarousel();
			cout << "La moment nu sunt produse disponibile , insa daca alegeti un produs din meniul nostru, el va fi gata in doar 5 secunde! \n\n"; 
			system("pause");
			system("cls");
			break;
		case 5:
			exit(0);
		default: cout << "\nAti ales optiunea gresita!\n";
			system("pause");
			system("cls");
			goto M;
		}
	} while (opt != 5);
	
}