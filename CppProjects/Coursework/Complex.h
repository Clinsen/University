#pragma once
#include "Real.h"

class Complex final : public Real
{
private:
	double imaginary;

public:
	// Конструктор ініціалізації який приймає всі потрібні поля, конструктор по замовчуванню, конструктор копіювання, деструктор:
	Complex(double real, double ival);
	Complex();
	Complex(const Complex &source);
	virtual ~Complex();

	// Методи для отримання доступу до полів об'єкта та їх зміни:
	double get_imaginary() const;
	void set_imaginary(double ival);
	double get_complex() const;

	// Функція для обчислення норми комплексного числа:
	virtual double calculate_norm() const override;
};