import numpy as np
from scipy.stats import f

# Дані (варіант №6)
data = np.array([
    [200, 170, 174, 189],
    [175, 185, 180, 198],
    [178, 193, 167, 25],
    [190, 170, 174, 189],
    [165, 170, 187, 177]
])

# Кількість рівнів факторів
k = data.shape[1]  # Кількість рівнів фактора B (стовбці)
n = data.shape[0]  # Кількість рівнів фактора A (рядки)

# Загальне середнє значення
grand_mean = np.mean(data)

# Суми квадратів відхилень
ss_between_A = n * np.sum((np.mean(data, axis=1) - grand_mean) ** 2)
ss_between_B = k * np.sum((np.mean(data, axis=0) - grand_mean) ** 2)
ss_within = np.sum((data - np.mean(data)) ** 2)

# Ступені свободи
df_between_A = n - 1
df_between_B = k - 1
df_within = n * k - 1

# Середні квадратичні відхилення
ms_between_A = ss_between_A / df_between_A
ms_between_B = ss_between_B / df_between_B
ms_within = ss_within / df_within

# F-статистика та p-значення
f_statistic_A = ms_between_A / ms_within
f_statistic_B = ms_between_B / ms_within

# Таблиця критичних точок
alpha_values = [0.01, 0.025, 0.05, 0.095, 0.975, 0.99]
critical_points = [16.8, 14.4, 12.6, 1.64, 1.24, 0.872]

# Поріг для перевірки статистичної значущості
alpha_index = alpha_values.index(0.975)
alpha_critical_point = critical_points[alpha_index]

# Вивід результатів
print("F-статистика для фактора A:", f_statistic_A)
print("F-статистика для фактора B:", f_statistic_B, "\n")

# Перевірка статистичної значущості для фактора A
if f_statistic_A > alpha_critical_point:
    print("Фактор A має статистично значущий вплив на результативну ознаку.")
else:
    print("Фактор A не має статистично значущого впливу на результативну ознаку.")

# Перевірка статистичної значущості для фактора B
if f_statistic_B > alpha_critical_point:
    print("Фактор B має статистично значущий вплив на результативну ознаку.")
else:
    print("Фактор B не має статистично значущого впливу на результативну ознаку.")
