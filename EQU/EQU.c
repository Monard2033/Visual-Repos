#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
/*Se da o ecuatie de forma operatie=numar. Sa se puna paranteze in operatie astfel incat
rezultatul ecuatiei sa fie egal cu numar. Se garanteaza ca fiecare solutie se poate rezolva cu cel mult
un nivel de paranteze si exista mereu solutie. De asemenea, in expresia initiala se garanteaza exista
doar numere, operatori aritmetici si semnul =, fara spatii.*/
int main()
{
	char st1[50] = { 0 }, st2[50] = { 0 };
	int count = 0;
	FILE* f;
	f = fopen("equ.in", "rt");
	fscanf(f, "%s", st1);
	//fscanf(f, "%s", st1); A se decomenta pentru a citi al doilea sir de caractere
     fclose(f);
   for (int i = 0,j=0; i <= strlen(st1); i++,j++)
   {
	   if (st1[i]=='*')
	   {
		   st2[j] = st1[i];
		   st2[j+1] = '(';
		   count++;
		
	   }
	 else if (st1[i]=='=')
	   {
		   st2[j+1] = st1[i];
		   st2[j] = ')';
		   j++;
	   }
	 else
	   {
		   if (count > 0)
		   {
			   j++;
			   count--;
		   }
		   st2[j] = st1[i];
	   }
   }
   printf("Rezultat=%s", st2);
  f= fopen("equ.out", "wt");
fprintf(f, "%s", st2);
fclose(f);
	return 0;
}