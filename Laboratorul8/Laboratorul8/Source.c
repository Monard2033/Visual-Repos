#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#define meniu(A) scanf("%d",&A);
int pret;
typedef struct masini
{
	char marca[50]; int pret;
}M;
int citire(M* st, int* nr)
{
	int pret = 0;
	(*nr)++;
	printf("Introduceti marca masinii: ");
	scanf("%s", st[*nr].marca);
	for (int i = 0; i < strlen(st[*nr].marca); i++)
	{
		pret += st[*nr].marca[i];
	}
	st[*nr].pret = pret;
	printf("Pretul:%d\n", st[*nr].pret);
	printf("NR=%d\n", *nr);
}
void afisare(M* st, int nr)
{
	for (int i = 1; i <= nr; i++)
	{
		printf("Marca Masinii de Spalat:%s  Pretul:%d\n", st[i].marca, st[i].pret);
	}
}
void fisier(M* st,int *nr, int p)
{
	FILE* f;
	f = fopen("masini_de_spalat.txt", "wt");
	if (f != NULL)
	{
		if (st->pret <= p)
			fprintf(f, "Marca:%s Pret:%d \n", st[*nr].marca, st[*nr].pret);
		printf("Content to file written successfully !\n");
	}
	fclose(f);
}
int main()
{ 
	FILE* f;
	int p = 1200, nr = 0;
	M st[100];
	int A;
	do
	{
		printf("************************************************************************\n");
		printf("*-------------------------------MENIU----------------------------------*\n");
		printf("*                  CE PROGRAM DORITI SA INCERCATI ?                    *\n");
		printf("*    1 - Citirea masinii                                               *\n");
		printf("*    2-  Afisarea                                                      *\n");
		printf("*    3 - Fisier                                                        *\n");
		printf("************************************************************************\n");
		printf("\n");
		printf("                    Alegerea Dumneavoastra-> ");
		meniu(A);
		{
			switch (A)
			{
			case 1:
				system("cls");
				citire(&st[0], &nr);
				system("pause");
				system("cls"); break;
			case 2:
			    system("cls");
			    afisare(&st[0], nr);
			    system("pause");
			    system("cls"); break;
			case 3:
			{system("cls");
			fisier(&st,&nr, p);
			system("pause");
			break;
			default: system("cls"); printf("Ati ales optiunea gresita \n"); system("pause"); system("cls");
			case 'x':
			{system("cls"); break; }
			}
			}
		}
	} while (A != 0);
}
