#pragma once
#pragma warning(disable: 4552)
#include <iostream>
#include <math.h>

class Real
{
protected:
	double real;

public:
	// ³�������� ������� ��� ���������� ����� ������� �����
	virtual double calculate_norm() const;

	// ����������� �����������, ����������� �� ������������, ����������� ���������, ����������:
	Real(double val);
	Real();
	Real(const Real &source);
	virtual ~Real();

	// ������ ��� ��������� ������� �� ���� ��'���� �� �� ����:
	double get_real() const;
	void set_real(double val);

	// ���������� ���������:
	Real &operator + (const Real &rhs);
	Real &operator - (const Real &rhs);
	Real &operator * (const Real &rhs);
	Real &operator / (const Real &rhs);
	friend std::ostream &operator<<(std::ostream &os, const Real &obj);
	friend std::istream &operator>>(std::istream &is, Real &obj);
	bool operator < (const Real &rhs);
	bool operator > (const Real &rhs);
};