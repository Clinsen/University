#include "Matrix.h"

Matrix::Matrix(int rows, int cols)
{
	this->rows = rows;
	this->cols = cols;

	data = new double *[rows];

	for (int i = 0; i < rows; i++)
	{
		data[i] = new double[cols];
	}
}
Matrix::~Matrix()
{
	delete[] data;
}

double Matrix::get_element_at(size_t row, size_t col)
{
	return this->data[row][col];
}
void Matrix::set_element_at(size_t row, size_t col, double val)
{
	this->data[row][col] = val;
}

void Matrix::fill_matrix()
{
	srand((size_t)time(NULL));

	for (size_t i = 0; i < this->rows; i++)
	{
		for (size_t j = 0; j < this->cols; j++)
		{
			this->set_element_at(i, j, -100 + rand() % 200);
		}
	}
	return;
}
void Matrix::print_matrix()
{
	for (size_t i = 0; i < this->rows; i++)
	{
		for (size_t j = 0; j < this->cols; j++)
		{
			std::cout << this->get_element_at(i, j) << " ";
		}
		std::cout << "\n";
	}
}
double Matrix::calculate_norm()
{
	double min_val = 0;
	double max_val = 0;

	for (size_t i = 0; i < rows; i++)
	{
		for (size_t j = 0; j < cols; j++)
		{
			if (min_val < this->data[i][j])
			{
				min_val = this->data[i][j];
			}
			if (max_val > this->data[i][j])
			{
				max_val = this->data[i][j];
			}
		}
	}

	if (abs(min_val) > abs(max_val))
	{
		return abs(min_val);
	}
	else
	{
		return abs(max_val);
	}
}