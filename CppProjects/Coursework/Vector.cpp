#include "Vector.h"

Vector::Vector()
{
}
Vector::~Vector()
{
}

void Vector::display_vector() const
{
	std::cout << "Displaying the vector: ";
	for (size_t i = 0; i < vec.size(); i++)
	{
		std::cout << vec[i] << " ";
	}
	std::cout << "\n";
}
void Vector::append_vector()
{
	double append_value = 0;
	size_t amount_of_values = 0;

	std::cout << "How many values? ";
	std::cin >> amount_of_values;

	for (size_t i = 0; i < amount_of_values; i++)
	{
		std::cout << "Input value to append: ";
		std::cin >> append_value;
		vec.emplace_back(append_value);
	}
	std::cout << "\n";
}
double Vector::calculate_norm() const
{
	double sum = 0;
	for (size_t i = 0; i < vec.size(); i++)
	{
		sum += vec[i];
	}
	return sqrt(sum);
}