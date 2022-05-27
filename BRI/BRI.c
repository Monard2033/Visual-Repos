#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
/*O bară are lungimea L (1<=L<=1000). Se consideră N (1<=N<=10) repere de lungimi diferite.
Să se genereze toate posibilităţile de a tăia bara după reperele existente, fără să rămână rest la
tăiere, fiecare reper fiind folosit cel puţin o dată. Se citesc dintr-un fişier text, de pe primul rând,
lungimea barei – L şi numărul de repere – n, iar de pe următorul rând, reperele. Numerele de pe un
rând sunt separate prin spaţiu
*/

unsigned valid(unsigned short* rep, unsigned short** st, unsigned short n, unsigned short varf) 
{
	unsigned short i, j, ok;
	for (i = 1; i <= n; i++) {
		ok = 1;
		for (j = 1; j <= varf; j++)
			if (rep + i == *(st + j)) {
				ok = 0;
				break;
			}
		if (ok) return 0;

	}
	return 1;
}

int main() 
{
	unsigned short L, n, suma, i, varf, * stiva[1001];
	unsigned short repere[11];
	FILE* f;
	f = fopen("bri.in", "rt");
	fscanf(f, "%hu%hu", &L, &n);
	for (i = 1; i <= n; i++)
		fscanf(f, "%hu", &repere[i]);
	fclose(f);
	do 
	{  
		suma = 0; 
		for (i = 1; i <= n; i++)
			if (repere[i] > repere[i + 1])
				suma = 1, repere[i] ^= repere[i + 1], repere[i + 1] ^= repere[i], repere[i] ^= repere[i + 1];
	} while (suma);
	suma = repere[1];// initializari
	varf = 1;
	stiva[0] = repere + varf; // sa nu am eroare cand varf = 0
	stiva[varf] = repere + varf;
	f = fopen("bri.out", "wt");
	while (varf) 
	{ // se opreste cand stiva este goala
		if (suma < L) // daca suma este mai mica adaugam adresa varfului la varf urmator si adunam la suma
			stiva[varf + 1] = stiva[varf], suma += *stiva[varf++];
		else 
		{
			if (suma == L && valid(repere, stiva, n, varf)) 
			{ 
				for (i = 1; i <= varf; i++)
					fprintf(f, "%hu ", *stiva[i]);
				fprintf(f, "\n");
			}
			suma -= *stiva[varf--]; // scadem din suma actual varf dupa care scadem varful
			suma -= *stiva[varf]; //scadem din suma noul varf
			stiva[varf]++; //noului varf i se atrebuie adresa urmatorul element din repere
			suma += *stiva[varf]; // se adauga valoarea elementului din repere
		}
	}
	fclose(f);
	return 0;
}