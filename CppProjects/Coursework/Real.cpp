#include "Real.h"

// ³�������� ������� ��� ���������� ����� ������� �����:
double Real::calculate_norm() const
{
	return abs(real);
}

// ����������� ����������� ���� ������ �� ������ ����, ����������� �� ������������, ����������� ���������, ����������:
Real::Real(double val) : real{ val }
{
}
Real::Real() : Real{ 0.0 } // �����������
{
}
Real::Real(const Real &source) : real{ source.real }
{
}
Real::~Real()
{
}

// ������ ��� ��������� ������� �� ���� ��'���� �� �� ����:
double Real::get_real() const
{
	return real;
}
void Real::set_real(double val)
{
	real = val;
}

// ���������� ���������:
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