#pragma once
#pragma warning(disable: 4552)
#include <iostream>
#include <math.h>

class Real
{
protected:
	double real;

public:
	// Віртуальна функція для обчислення норми дійсного числа
	virtual double calculate_norm() const;

	// Конструктор ініціалізації, конструктор по замовчуванню, конструктор копіювання, деструктор:
	Real(double val);
	Real();
	Real(const Real &source);
	virtual ~Real();

	// Методи для отримання доступу до полів об'єкта та їх зміни:
	double get_real() const;
	void set_real(double val);

	// Перегрузка операторів:
	Real &operator + (const Real &rhs);
	Real &operator - (const Real &rhs);
	Real &operator * (const Real &rhs);
	Real &operator / (const Real &rhs);
	friend std::ostream &operator<<(std::ostream &os, const Real &obj);
	friend std::istream &operator>>(std::istream &is, Real &obj);
	bool operator < (const Real &rhs);
	bool operator > (const Real &rhs);
};