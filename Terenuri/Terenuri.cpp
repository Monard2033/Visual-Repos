/*Cautarea unui teren extravilan dupa tipul de sol*/
#include <iostream> 
#include <list>
#include <string>
#include <iterator>
#include <algorithm>
using namespace std;
class lista;
class teren
{
private:
	string forma;
	int pret, tip, suprafata;
public:
	teren(){}
	teren(string forma, int pret, int supr, int tip)
	{
		this->pret = pret;
		this->forma = forma;
		this->tip = tip;
		this->suprafata = supr;
	}
	virtual void afisare()
	{
		cout << "Forma= " << forma << endl;
		cout << "Pretul= " << pret << endl;
		cout << "Tip= " << tip << endl;
		cout << "Suprafata= " << suprafata << endl;
	}
	friend void cautare(list<teren*>);
	
};
list<teren*>::iterator it;

class intravilan :public teren
{
private:
	string acces;
	int tip;
public:
	intravilan() {}
	intravilan(string forma, int pret, int supr, string acces, int tip) :teren(forma, pret, supr, tip)
	{
		this->acces = acces;
		this->tip = tip;
	}
	void afisare()
	{
		teren::afisare();
		cout << "Tip acces= " << acces << endl;
	}
};
class extravilan :public teren
{
protected:
	string tips;
	int tip;
public:
	extravilan(){}
	extravilan(string forma, int pret, int supr, string ts, int tip) : teren(forma, pret, supr, tip)
	{
		this->tips = ts;
		this->tip = tip;
	}
	void afisare()
	{
		teren::afisare();
		cout << "Tip Sol= " << tips << endl;
	}
};
void adaugare(list<teren*>& t, int tip)
{
	string forma, acces, tips;
	int pret, supr;
	cout << "Introduceti forma-> ";
	cin >> forma;
	cout << "Introduceti suprafata-> ";
	cin >> supr;
	cout << "Introduceti pretul-> ";
	cin >> pret;
	if (tip == 1)
	{
		cout << "Are acces la strada?[DA/NU]-> ";
		cin >> acces;
		t.push_back(new intravilan(forma, pret, supr, acces, 1));
	}
	if (tip == 2)
	{
		cout << "Tipul Solului-> ";
		cin >> tips;
		t.push_back(new extravilan(forma, pret, supr, tips, 2));
	}
}
void afisare(list<teren*>t)
{
	cout << "-----";
	for (it = t.begin(); it != t.end(); it++)
	{
		(*it)->afisare();
		cout << "-----\n";
		cout << "------" << endl;
	}
}
void cautare(list<teren*>t)
{
	string sol;
	cout << "Introduceti tipul de sol-> ";
	cin >> sol;
	extravilan e;
	for (it = t.begin(); it != t.end(); it++)
	{
	   teren* ter = (*it)
		if (ter->tip==sol)
		  (*it)->afisare();
	}
}
int main()
{
	list<teren*> teren;
	int opt=0;
	do
	{
		cout << "1.Adaugare teren intravilan (tip=1)" << endl;
		cout << "2.Adaugare teren extravilan (tip=2)" << endl;
		cout << "3.Afisare terenuri" << endl;
		cout << "4.Cautare dupa tip de sol" << endl;
		cout << "5.Iesire" << endl;
		cout << "Alegerea D-stra-> ";
		cin >> opt;
		switch (opt)
		{
		case 1:
			system("cls");
			adaugare(teren, 1);
			system("pause");
			system("cls");
			break;
		case 2:
			system("cls");
			adaugare(teren, 2);
			system("pause");
			system("cls");
			break;
		case 3:
			system("cls");
			afisare(teren);
			system("pause");
			system("cls");
			break;
		case 4:
			system("cls");
			cautare(teren);
			system("pause");
			system("cls");
			break;
		case 5:
			exit(0);
			break;
		default:
			break;
		}
	} while (opt != 5);
}
