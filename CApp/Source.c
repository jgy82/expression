#include<stdio.h>

double getCylinderVolume(double r, double h)
{
	double area = 3.1416 * r * r;
	double volume = area * h;
	return volume;
}

int main()
{
	double result = getCylinderVolume(10, 100);
	printf("Volume=%f\n", result);
	return 0;
}