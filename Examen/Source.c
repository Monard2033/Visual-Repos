#include <stdio.h>

int main()
{
	int* a;
	a = (int*)calloc(10, sizeof(int));
	printf("%d", sizeof(a));
}
