#pragma once
#include "Real.h"

class Complex final : public Real
{
private:
	double imaginary;

public:
	// ����������� ����������� ���� ������ �� ������ ����, ����������� �� ������������, ����������� ���������, ����������:
	Complex(double real, double ival);
	Complex();
	Complex(const Complex &source);
	virtual ~Complex();

	// ������ ��� ��������� ������� �� ���� ��'���� �� �� ����:
	double get_imaginary() const;
	void set_imaginary(double ival);
	double get_complex() const;

	// ������� ��� ���������� ����� ������������ �����:
	virtual double calculate_norm() const override;
};