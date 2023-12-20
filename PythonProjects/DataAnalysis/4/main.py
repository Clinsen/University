from scipy.stats import t, f

# 1. Вхідні дані
x_values = [35, 45, 55, 65]  # Об’єм виконаних робіт
y_values = [5, 8, 16, 6]     # Накладні витрати

# 2. Розрахунок вибіркового кореляційного відношення
n = len(x_values)
mean_x = sum(x_values) / n
mean_y = sum(y_values) / n

xy = [x * y for x, y in zip(x_values, y_values)]
mean_xy = sum(xy) / n

x_squared = [x**2 for x in x_values]
y_squared = [y**2 for y in y_values]

mean_x_squared = sum(x_squared) / n
mean_y_squared = sum(y_squared) / n

correlation = (mean_xy - mean_x * mean_y) / ((mean_x_squared - mean_x**2) * (mean_y_squared - mean_y**2))**0.5

# 3. Перевірка гіпотези про значущість вибраного кореляційного відношення
# Розрахунок ступенів свободи
df = n - 2

# Розрахунок t-статистики
t_statistic = correlation * ((n - 2) / (1 - correlation**2))**0.5

# Критичне значення для alpha = 0.05 та df = n - 2
critical_value = t.ppf(0.975, df)

# Перевірка гіпотези
if abs(t_statistic) > critical_value:
    print("Гіпотеза про значущість кореляції відхиляється")
else:
    print("Гіпотеза про значущість кореляції приймається")

# 4. Формування гіпотези про вибір функції регресії, розрахунок вибіркового коефіцієнта кореляції
b = correlation * (mean_y_squared - mean_y**2)**0.5 / (mean_x_squared - mean_x**2)**0.5

# 5. Побудова вибіркового лінійного рівняння регресії
a = mean_y - b * mean_x

# 6. Перевірка гіпотези про значущість вибіркового коефіцієнта кореляції
# Розрахунок стандартної помилки для b
se_b = ((1 - correlation**2) / (n - 2))**0.5 / ((mean_x_squared - mean_x**2)**0.5)

# Розрахунок t-статистики для b
t_statistic_b = b / se_b

# Критичне значення для alpha = 0.05 та df = n - 2
critical_value_b = t.ppf(0.975, df)

# Перевірка гіпотези
if abs(t_statistic_b) > critical_value_b:
    print("Гіпотеза про значущість коефіцієнта b відхиляється")
else:
    print("Гіпотеза про значущість коефіцієнта b приймається")

# 7. Перевірка гіпотези про лінійність функції регресії
# Розрахунок SST (Total Sum of Squares)
sst = sum((y - mean_y)**2 for y in y_values)

# Розрахунок SSR (Regression Sum of Squares)
ssr = sum((a + b * x - mean_y)**2 for x, y in zip(x_values, y_values))

# Розрахунок SSE (Error Sum of Squares)
sse = sst - ssr

# Розрахунок ступенів свободи
df_r = 1  # для регресії
df_e = n - 2  # для помилок

# Розрахунок F-статистики
f_statistic = (ssr / df_r) / (sse / df_e)

# Критичне значення для alpha = 0.05 та df = (1, n - 2)
critical_value_f = f.ppf(0.95, df_r, df_e)

# Перевірка гіпотези
if f_statistic > critical_value_f:
    print("Гіпотеза про лінійність функції регресії відхиляється")
else:
    print("Гіпотеза про лінійність функції регресії приймається")

# Виведення результатів
print("\n"f"Коефіцієнт кореляції: {correlation}")
print(f"Коефіцієнт регресії b: {b}")
print(f"Коефіцієнт регресії a: {a}")
