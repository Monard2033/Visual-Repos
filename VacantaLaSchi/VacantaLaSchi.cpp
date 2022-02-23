#include <iostream>
#include <string>
#include <list>
#include <iterator>
using namespace std;
class Lista;
class tabara
{
protected:
	string nume;
	int cantitate, tip;
public:
	tabara(string nume, int cant, int tip)
	{
		this->nume = nume;
		this->cantitate = cant;
		this->tip = tip;
	}
	string getM()
	{
		return nume;
	}
	virtual void afisare()
	{
		cout << "Nume= " << nume << endl;
		cout << "Cantitate= " << cantitate << endl;
		cout << "Tip= " << tip << endl;
	}
	friend void afisare(list<tabara*>);
	friend void cautare(list<tabara*>);
};
class echipament :public tabara
{
protected:
	int greutate;
	string abs_nec;
public:
	echipament(string nume, int cantitate, int tip, string an, int greu) : tabara(nume, cantitate, tip)
	{
		this->greutate = greu;
		this->abs_nec = an;
	}
	void afisare()
	{
		tabara::afisare();
		cout << "Greutate= " << greutate << endl;
		cout << "Absolut Necesar= " << abs_nec << endl;

	}
};
class medicament :public tabara
{
protected:
	string contraindicatii, descriere;
public:
	medicament(string nume, int cantitate, int tip, string contr, string desc) :tabara(nume, cantitate, tip)
	{
		this->contraindicatii = contr;
		this->descriere = desc;
	}
	void afisare()
	{
		tabara::afisare();
		cout << "Contraindicatii= " << contraindicatii << endl;
		cout << "Descriere= " << descriere << endl;
	}
};

list<tabara*>t;
list<tabara*>::iterator it;

void adaugare(list<tabara*>& t, int tip)
{
	string nume, descriere, contraindicatii, abs_nec;
	int greutate, cantitate;
	cout << "Ce luam cu noi la tabara?-> "; cin >> nume;
	cout << "Cate elemente luam?-> "; cin >> cantitate;
	if (tip == 1)
	{
		cout << "Ce greutate are elementul?-> "; cin >> greutate;
		cout << "Absolut Necesar[DA/NU]?-> "; cin >> abs_nec;
			t.push_back(new echipament(nume, cantitate, tip, abs_nec, greutate));
	}
	if (tip == 2)
	{
	    cout << "Ce descriere are elementul?-> "; cin >> descriere;
		cout << "Ce Contraindicatii are?-> "; cin >> contraindicatii;
			t.push_back(new medicament(nume, cantitate, tip, contraindicatii, descriere));
	}
}
void afisare(list<tabara*>t)
{
	cout << "----" << endl;
	for (it = t.begin(); it != t.end(); it++)
	{
		(*it)->afisare();
		cout << "-----\n";
		cout << "-----" << endl;
	}
}
void cautare(list<tabara*> lista)
{
	string med;
	cout << "Introduceti medicamentul cautat: ";
	cin >> med;
	tabara* m;
	for (it = lista.begin(); it != lista.end(); it++)
	{
		tabara* tab = (*it);
		if (tab->tip == 2)
		{
			m = (tabara*)tab;
			if (m->getM() == med)
				(*it)->afisare();
		}
	}
}
int main()
{
	list<tabara*> tabara;
int opt;
do
{
	cout << "1.Adaugare Echipament(TIP=1)"<<endl;
	cout << "2.Adaugare Medicament(TIP=2)"<< endl;
	cout << "3.Afisare" << endl;
	cout << "4.Cautare dupa Medicament" << endl;
	cout << "0.Iesire" << endl;
	cout << "Optiunea D-stra -> ";
	cin >> opt;
	switch (opt)
	{
	case 1:
		system("cls");
		adaugare(tabara, 1);
		system("pause");
		system("cls");
		break;
	case 2:
		system("cls");
		adaugare(tabara,2);
		system("pause");
		system("cls");
		break;
	case 3:
		system("cls");
		afisare(tabara);
		system("pause");
		system("cls");
		break;
	case 4:
		system("cls");
		cautare(tabara);
		system("pause");
		system("cls");
		break;
	case 0: exit(0);
	}
} while (opt != 0);
return 0;
}
