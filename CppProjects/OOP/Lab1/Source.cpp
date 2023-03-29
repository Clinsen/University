#include <iostream>
#include <valarray>
#include <math.h>
#include <ctime>

int main()
{
	int randArray[5];

	srand(time(NULL));

	for (int i = 0; i < 5; i++)
		randArray[i] = rand() % 101 - 50;

	std::valarray<int> v(randArray, 5);

	std::cout << "Printing the array: ";
	for (int i = 0; i < 5; i++)
		std::cout << v[i] << " ";

	// Calculate sum
	int sum = v.sum();
	std::cout << "\n\nSum of all the numbers in the valarray: " << sum << "\n";

	// Find min and max
	int min = v.min();
	int max = v.max();
	std::cout << "\nMin and max numbers in the valarray:" << "\nMin: " << min << "\nMax: " << max << "\n";

	// Calculate arithmetic mean
	double mean = v.sum() / static_cast<double>(v.size());
	std::cout << "\nArithmetic mean of numbers in the valarray: " << mean << "\n";
}