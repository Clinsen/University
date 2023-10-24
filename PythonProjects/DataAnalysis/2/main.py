import numpy as np
import pandas as pd
from scipy import stats

# Дані з таблиці
group1 = [1.55, 0.7, 0.22, 0.38, 1.7, 2.88, 10.73]
group2 = [1.62, 0.52, 0.12, 0.91, 2.79, 4.35]
group3 = [1.69, 0.34, 0.47, 1.45, 3.89, 5.83]
group4 = [1.76, 0.17, 0.81, 1.99]

# Виконуємо дисперсійний аналіз
f_statistic, p_value = stats.f_oneway(group1, group2, group3, group4)

# Заданий рівень значущості
alpha = 0.05

# Виводимо результати
print("Результати дисперсійного аналізу:")
print("F-статистика:", f_statistic)
print("P-значення:", p_value)

# Перевіримо на значущість
if p_value < alpha:
    print("Результат є статистично значущим, відхиляємо нульову гіпотезу")
else:
    print("Результат не є статистично значущим, не можемо відхилити нульову гіпотезу")

# Розрахунок середніх значень для кожної групи
mean_group1 = np.mean(group1)
mean_group2 = np.mean(group2)
mean_group3 = np.mean(group3)
mean_group4 = np.mean(group4)

# Розрахунок стандартного відхилення для кожної групи
std_group1 = np.std(group1, ddof=1)
std_group2 = np.std(group2, ddof=1)
std_group3 = np.std(group3, ddof=1)
std_group4 = np.std(group4, ddof=1)

# Виводимо середні значення та стандартне відхилення для кожної групи
print("\nСереднє значення для групи 1:", mean_group1)
print("Стандартне відхилення для групи 1:", std_group1)

print("\nСереднє значення для групи 2:", mean_group2)
print("Стандартне відхилення для групи 2:", std_group2)

print("\nСереднє значення для групи 3:", mean_group3)
print("Стандартне відхилення для групи 3:", std_group3)

print("\nСереднє значення для групи 3:", mean_group4)
print("Стандартне відхилення для групи 3:", std_group4)


