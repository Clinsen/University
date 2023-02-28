#pragma once
#include <iostream>
#include <time.h>

class Matrix
{
private:
	double **data;
	size_t rows;
	size_t cols;

public:
	Matrix(int rows, int cols);
	~Matrix();

	double get_element_at(size_t row, size_t col);
	void set_element_at(size_t row, size_t col, double val);

	void fill_matrix();
	void print_matrix();
	double calculate_norm();
};