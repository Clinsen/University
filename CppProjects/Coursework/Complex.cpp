#include "Complex.h"

// Конструктор ініціалізації який приймає всі потрібні поля, конструктор по замовчуванню, конструктор копіювання, деструктор:
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

// Методи для отримання доступу до полів об'єкта та їх зміни:
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

// Функція для обчислення норми комплексного числа:
double Complex::calculate_norm() const
{
	return abs(get_complex());
}