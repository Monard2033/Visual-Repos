#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
void citire(char** A, char** B, int n)
{
	int i = 0, j = 0, ok = 2;
    
	for (i = 0; i <= n; i++)
	{
		A[i] = calloc(n, sizeof(char));
		B[i] = calloc(n, sizeof(char));
    }
	A[0][0] = '*';
	A[n-1][0] = '*';
	B[0][0] = '*';
	B[n-1][0] = '*';
	printf("Introduceti valorile pentru matricea A:\n");
	for ( i = 0; i < n; i++)
		for (j = 1; j < n; j++)
		{
			if ((A[0][0] != 0 && A[n - 1][0] != 0))
			{
				if (i == 1 && j == 1 && ok == 2)
				{
					j--; ok--;
				}
			printf("A[%d][%d]=", i, j);
			scanf(" %c", &A[i][j]);
			}
		}
	printf("Introduceti valorile pentru matricea B:\n");
	for (i = 0; i < n; i++)
		for (j = 1; j < n; j++)
		{
			if ((B[0][0] != 0 && B[n - 1][0] != 0))
			{
				if (i == 1 && j == 1 && ok == 1)
				{
					j--; ok--;
				}
			printf("B[%d][%d]=", i, j);
			scanf(" %c", &B[i][j]);
			}
		}
}
void afisare(char **A, char** B, char* C, int n)
{
	int i;
	for (i = 0; i <= n; i++)
	{
		C[i] = calloc(n, sizeof(char) + 1);
	}
	for (i = 0; i < n; i++)
	{
		C[i] = A[i][i];
		C[i + n] = B[i][n - i - 1];
	}
   printf("Vectorul C este: ");
   for (i = 0; i < n + n; i++)
	{
		printf("%c",C[i]);
	}
   printf("\n");
}
int main()
{
	char** A, **B, *C;
	int n = 3, op = 0;
	A = (char**)malloc(n * sizeof(char*));
	B = (char**)malloc(n * sizeof(char*));
	C = (char*)malloc(n * sizeof(char*));
	do
	{
		printf("************************************************************************\n");
		printf("*-------------------------------MENIU----------------------------------*\n");
		printf("*                  CE OPTIUNE DORITI SA INCERCATI ?                    *\n");
		printf("*    1 - Citire Matrici                                                *\n");
		printf("*    2 - Afisare Vector                                                *\n");
		printf("*    3 - Iesire                                                        *\n");
		printf("************************************************************************\n");
		printf("\n");
		printf("                    Alegerea Dumneavoastra-> ");
		scanf("%d", &op);
		{
			switch (op)
			{
			case 1:
				system("cls");
				citire(&A, &B, n);
				system("pause");
				system("cls");
				break;
			case 2:
				system("cls");
				afisare(&A, &B, &C, n);
				system("pause"); 
				system("cls");
				break;
			case 3:
				system("cls");
				free(A);
				free(B);
				free(C);
				exit(0);
			default:
				system("cls");
				printf("Ati ales optiunea gresita \n");
				system("pause");
				system("cls");
			}
		}
	} while (op!= 3);
}