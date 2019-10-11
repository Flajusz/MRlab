#define _USE_MATH_DEFINES
#include <math.h>
#include <cmath>

#include <iostream>
using namespace std;
int main()
{

	double	kat_rad, 
			kat_stop=0;
	
	double tab[10];
	
	 int i = 3;

	 
	
	
		
	 if (i% 2 == 0)

	 {
		 for (int i = 0; i < 10; i++)
		 {
			 kat_rad = kat_stop * M_PI / 180;
			 tab[i] = sin(kat_rad);
			 kat_stop += 10;
		 }
	 }
	 else {
		 for (int i = 0; i < 10; i++)
		 {
			 kat_rad = kat_stop * M_PI / 180;
			 tab[i] = cos(kat_rad);
			 kat_stop += 10;
		 }
	 }

	 
	 ; for (int i = 0; i < 10; i++)
	 {

		 cout << tab[i] << endl;
	 };

}