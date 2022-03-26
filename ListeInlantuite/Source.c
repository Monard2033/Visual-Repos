#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>
#include<conio.h>
#include<stdlib.h>
typedef struct student
{
	char* nume;
	float grupa;
	struct student* urm;
}nod;
nod* adauga(nod* prim, char* nume, float grupa)
{
	nod* q, * p;
	printf("Numele:");
	scanf("%s", nume);
	if (!validare(nume))
	{
		printf("NU este valid");
		printf("Numele:");
		scanf("%s", nume);
	}
	printf("\nGrupa:");
	scanf("%f", &grupa);
	p = (nod*)malloc(sizeof(nod));
	p->nume = (char*)malloc(strlen(nume) + 1);
	strcpy(p->nume, nume);
	p->grupa = grupa;
	p->urm = NULL;
	if (p == NULL || p->nume == NULL)
	{
		printf("eroare la alocare!");
		exit(0);
	}
	if (prim == NULL)
	{
		p->urm = prim;
		return p;
	}
	else 
	{
		q = prim;
		while (q->urm != NULL)
		if(strcmp(q->nume, p->nume) != 0)
			q = q->urm;
		p->urm = q->urm;
		q->urm = p;
		return prim;
	}
}
void afisare(nod* prim)
{
	nod* q = prim;
	while (q != NULL) 
	{
		printf("Student:%s Grupa:%.1f\n", q->nume, q->grupa);
		q = q->urm;
	}
	printf("\n");
}
int validare(char n[20])
{
	if (n[0] > 'Z' && n[0] < 'A')
		return 0;
	for (int i = 1; i <= strlen(n); i++)
		if (n[i] > 'z' && n[i] > 'a')
			return 0;
	return 1;
}
nod* cautare(nod* prim,char* nume) 
{
	nod* q;
	q = prim;
	printf("Introduceti numele studentului cautat:");
	scanf("%s", nume);
	while (q != NULL)
	{
		if(strcmp(q->nume, nume) == 0)
		{
			printf("Studentul gasit:%s Grupa:%.1f\n", q->nume, q->grupa);
		}
		q = q->urm;
	}
	return q;
}
int main() 
{
	int opt;
	nod* prim, * p;
	char nume[10];
	float grupa=0;
	prim = NULL;
	do
	{
		printf("1. Introducerea unui student");
		printf("\n2. Afisarea alfabetica a studentilor introdusi");
		printf("\n3. Cautarea unui student");
		printf("\n4. Iesire\n");
		printf("Alegerea D-stra ->");
		scanf("%d", &opt);
		fflush(stdin);
		switch (opt)
		{
		case 1:
			system("cls");
			prim = adauga(prim,&nume, grupa);
			system("pause");
			system("cls");
			break;
		case 2:
			system("cls");
			afisare(prim);
			system("pause");
			system("cls");
			break;
		case 3: 
			system("cls");
			prim=cautare(prim,&nume);
			system("pause");
			system("cls");
			break;
		case 4:exit(1);
		default:printf("\n1..4!");
		}
	} while (opt != 4);
	return 0;
}