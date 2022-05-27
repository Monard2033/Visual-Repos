#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
typedef enum { false, true }bool;

void swap(char* a, char* b)
{
	if (*a == *b)
		return;
	*a ^= *b;
	*b ^= *a;
	*a ^= *b;
}
void rev(char* s, int l, int r)
{
	while (l < r)
		swap(&s[l++], &s[r--]);
}

int bSearch(char* s, int l, int r, int key)
{
	int index = -1;
	while (l <= r)
	{
		int mid = l + (r - l) / 2;
		if (s[mid] <= key)
			r = mid - 1;
		else {
			l = mid + 1;
			if (index == -1 || s[index] >= s[mid])
				index = mid;
		}
	}
	return index;
}

bool nextpermutation(char* s)
{
	int len = strlen(s), i = len - 2;
	while (i >= 0 && s[i] >= s[i + 1])
		--i;
	if (i < 0)
		return false;
	else
	{
		int index = bSearch(s, i + 1, len - 1, s[i]);
		swap(&s[i], &s[index]);
		rev(s, i + 1, len - 1);
		return true;
	}
}

int main()
{
	char sir[1000];
	int  i, n;
	FILE* f, * g;
	f = fopen("ams.in", "rt");
	g = fopen("ams.out", "wt");
	fscanf(f, "%d", &n);
	for (i = 1; i <= n; i++)
	{
		fscanf(f, "%s", sir);
		if (nextpermutation(sir))
			fprintf(g, "%s\n", sir);
		else
			fprintf(g, "-1\n");
	}

	fclose(g);
	fclose(f);
	return 0;
}
