#include <iostream>
#include <list>
#include <cstring>
//#include <windows.h>
#include <crypt.h>
using namespace std;

int x1[6];
char charset[6][10] = { "big", "brown", "or", "small", "gray", "elephant" };
void afisare()
{
	char sir[256] = "the";	
	int i;
	for (i = 0; i <= 5; i++)
	{
		strcat(sir, charset[x1[i]]);
	}
	strcat(sir, "fox");
	cout<<sir<<"\n";
}

int Valid(int k)
{
	int i;
	for (i = 0; i <= k - 1; i++)
	if (x1[k] == x1[i]) return 0;
	return 1;
}



void BackRec1(int k)
{
	int i;
	//if (sw == 0)
	//{
		for (i = 0; i <= 5; i++)
		{
			x1[k] = i;
			if (Valid(k))
			{
				if (k == 5) afisare();
				else BackRec1(k + 1);
			}
			
		}
	//}	
}

main()
{
	BackRec1(0);
}
