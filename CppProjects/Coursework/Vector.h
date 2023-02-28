#pragma once
#include <iostream>
#include <vector>

class Vector
{
private:
	std::vector<double> vec;

public:
	Vector();
	~Vector();

	void display_vector() const;
	void append_vector();

	double calculate_norm() const;
};