#include "Complex.h"

// ����������� ����������� ���� ������ �� ������ ����, ����������� �� ������������, ����������� ���������, ����������:
Complex::Complex(double real, double ival) : Real{ real }, imaginary{ ival }
{
}
Complex::Complex() : Real{ 0.0 }, imaginary{ 0.0 }
{
}
Complex::Complex(const Complex &source) : Real(source), imaginary{ source.imaginary }
{
}
Complex::~Complex()
{
}

// ������ ��� ��������� ������� �� ���� ��'���� �� �� ����:
double Complex::get_imaginary() const
{
	return imaginary;
}
void Complex::set_imaginary(double ival)
{
	imaginary = ival;
}
double Complex::get_complex() const
{
	return get_imaginary() + get_real();
}

// ������� ��� ���������� ����� ������������ �����:
double Complex::calculate_norm() const
{
	return abs(get_complex());
}