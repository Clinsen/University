#include "Real.h"

// Віртуальна функція для обчислення норми дійсного числа:
double Real::calculate_norm() const
{
	return abs(real);
}

// Конструктор ініціалізації який приймає всі потрібні поля, конструктор по замовчуванню, конструктор копіювання, деструктор:
Real::Real(double val) : real{ val }
{
}
Real::Real() : Real{ 0.0 } // делегування
{
}
Real::Real(const Real &source) : real{ source.real }
{
}
Real::~Real()
{
}

// Методи для отримання доступу до полів об'єкта та їх зміни:
double Real::get_real() const
{
	return real;
}
void Real::set_real(double val)
{
	real = val;
}

// Перегрузка операторів:
Real &Real::operator+(const Real &rhs)
{
	this->real + rhs.real;
	return *this;
}
Real &Real::operator-(const Real &rhs)
{
	this->real - rhs.real;
	return *this;
}
Real &Real::operator*(const Real &rhs)
{
	this->real *rhs.real;
	return *this;
}
Real &Real::operator/(const Real &rhs)
{
	this->real / rhs.real;
	return *this;
}
std::ostream &operator<<(std::ostream &os, const Real &obj)
{
	os << obj.real;
	return os;
}
std::istream &operator>>(std::istream &is, Real &rhs)
{
	is >> rhs.real;
	return is;
}
bool Real::operator < (const Real &rhs)
{
	if (real < rhs.real)
	{
		return true;
	}
	else
	{
		return false;
	}
}
bool Real::operator > (const Real &rhs)
{
	if (real > rhs.real)
	{
		return true;
	}
	else
	{
		return false;
	}
}