import numpy as np
from scipy.stats import f_oneway

# Дані з таблиці
data = [
    [1.55, 1.62, 1.69, 1.76],
    [0.70, 0.52, 0.34, 0.17],
    [0.22, 0.12, 0.47, 0.81],
    [0.38, 0.91, 1.45, 1.99],
    [1.70, 2.79, 3.89],
    [2.88, 4.35, 5.83],
    [10.73]
]

# Заводи (групи)
groups = len(data)

# Виконуємо дисперсійний аналіз
f_statistic, p_value = f_oneway(*data)

# Число ступенів свободи k та рівень значущості а
k = 6
alpha_values = [0.01, 0.025, 0.05, 0.095, 0.975, 0.99]
critical_values = [16.8, 14.4, 12.6, 1.64, 1.24, 0.872]

print(f"F-статистика: {f_statistic}")
print(f"P-значення: {p_value}\n")

# Порівняємо F-статистику з критичними значеннями для різних рівнів значущості
for alpha, crit_value in zip(alpha_values, critical_values):
    if f_statistic > crit_value:
        print(f"Рівність середніх не підтверджена (alpha = {alpha}). Є статистично значущі різниці.")
    else:
        print(f"Рівність середніх підтверджена (alpha = {alpha}). Немає статистично значущих різниць.")
