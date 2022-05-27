#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
/*Se da un sir de N biti (0 < N < 1 000). Acest sir trebuie sortat crescator folosind doar
interschimbari ale pozitiilor. Sa se afiseze numarul minim de interschimbari necesare, precum si toate
interschimbarile efectuate. Orice solutie minima e acceptata. Complexitate maxima O(N).*/
int main()
{
	int n, i, j, k = 0, aux = 0, ans = 0, t1[10] = { 0 };
	char v[50] = { 0 };
	FILE* f;
	f = fopen("swp.in", "rt");
	fscanf(f, "%d", &n);
	fscanf(f, "%s", v);
	fclose(f);

	for (i = 0; i <= n-1; i++)
	{
		for (j = i+1; j < n; j++)
			if (v[i] > v[j])
			{
				t1[i] = j;
				aux = v[i];
				v[i] = v[j];
				v[j] = aux;
				k++;
				j++;
			}
	}
	if (k > 0)
		ans += (k - 2);

	printf("Vectorul sortat:");
	for (i = 0; i < n; i++)
		printf("%c", v[i]);

	printf("\n\nNumarul minim de Interschimbari:%d\n", ans);
	printf("\nNumarul maxim de Inteschimbari:%d\n", k);

	f = fopen("swp.out", "wt");
	fprintf(f, "%d\n", ans);
	for (i = 0; i < k; i++)
		fprintf(f, "%d ", t1[i]);
	fclose(f);
}