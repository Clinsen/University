import numpy as np
import pandas as pd
from scipy.stats import t
from statsmodels.tsa.stattools import acf
from statsmodels.regression.linear_model import OLS
from statsmodels.tools.tools import add_constant
from statsmodels.stats.diagnostic import acorr_ljungbox

# Задані дані (В-6)
Y_values = np.array([9, 6, 3, 8, 15, 5, 7, 6, 13, 9, 4, 10, 15, 7, 6, 8])
T_values = np.array([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16])

# 1. Середній рівень, середньоквадратичне відхилення, коефіцієнт варіації
mean_Y = np.mean(Y_values)
std_dev_Y = np.std(Y_values)
coef_var_Y = std_dev_Y / mean_Y

print("1. Середній рівень:", mean_Y)
print("   Середньоквадратичне відхилення:", std_dev_Y)
print("   Коефіцієнт варіації:", coef_var_Y)

# 2. Коефіцієнти автокореляції та корелограма
lags = [1, 2, 3, 4, 5]
acf_values = acf(Y_values, nlags=max(lags), fft=False)
print("\n2. Коефіцієнти автокореляції:", acf_values)

# 3. МНК рівняння лінійного тренда
X = add_constant(T_values)
model = OLS(Y_values, X).fit()
trend_coefficients = model.params

# 4. Прогнозовані значення та їх вірогідні проміжки на один і два роки
forecast_steps = [1, 2]
X_forecast = add_constant(np.arange(max(T_values) + 1, max(T_values) + max(forecast_steps) + 1))
forecast_results = model.get_prediction(X_forecast)

forecast_values = forecast_results.predicted_mean
forecast_intervals = forecast_results.conf_int(alpha=0.1)

print("\n3. Прогнозовані значення на один і два роки:", forecast_values)
print("   Вірогідні проміжки на один і два роки:", forecast_intervals)

# 5. Аналіз значущості коефіцієнтів автокореляції
residuals = model.resid
lags = min(10, len(residuals) // 2)  # Виберемо кілька лагів для аналізу
lb_test_statistic, lb_p_value = acorr_ljungbox(residuals, lags=lags)

print("\n4. Ljung-Box тест:")
print("   Тестова статистика:", lb_test_statistic)
print("   P-значення:", lb_p_value)

# Виведемо результат тесту:
alpha = 0.05

# Функція для перевірки, чи можна конвертувати значення в число
def is_float(value):
    try:
        float(value)
        return True
    except ValueError:
        return False

# Конвертуємо значення p-значення у числа
lb_p_value_float = [float(value) if is_float(value) else None for value in lb_p_value]

if any(value is not None and value < alpha for value in lb_p_value_float):
    print("   Є підстави відкинути нульову гіпотезу про відсутність автокореляції в залишках.")
else:
    print("   Немає достатніх підстав відкидати нульову гіпотезу.")

# 6. Вирівнювання часового ряду способом усереднення за трьома і п'ятьма точками
smoothed_Y_3 = pd.Series(Y_values).rolling(window=3, center=True).mean().values
smoothed_Y_5 = pd.Series(Y_values).rolling(window=5, center=True).mean().values

print("\n5. Вирівнювання за трьома точками:", smoothed_Y_3)
print("   Вирівнювання за п'ятьма точками:", smoothed_Y_5)

# 7. Визначення тенденції ряду експонентним вирівнюванням
trend_Y = pd.Series(Y_values).ewm(span=3, adjust=False).mean().values
print("\n6. Тенденція ряду експонентним вирівнюванням:", trend_Y)

print("\n7. Коефіцієнти лінійного тренда:", trend_coefficients)

# 8. Оцінки дисперсії параметрів моделі та їх вірогідні проміжки
param_covariance = model.cov_params()
param_standard_errors = np.sqrt(np.diag(param_covariance))
confidence_interval_multiplier = t.ppf(0.95, df=model.df_resid)

lower_confidence_interval = model.params - confidence_interval_multiplier * param_standard_errors
upper_confidence_interval = model.params + confidence_interval_multiplier * param_standard_errors

print("\n8. Оцінки дисперсії параметрів моделі та їх вірогідні проміжки:")
for i, (param, lower, upper) in enumerate(zip(model.params, lower_confidence_interval, upper_confidence_interval), 1):
    print(f"   Параметр {i}: Оцінка = {param:.4f}, Довірчий інтервал: ({lower:.4f}, {upper:.4f})")

# 9. Оцінка якості лінійної моделі за автокореляцією відхилень від тренда
acf_residuals = acf(model.resid, fft=False)
print("\n9. Aвтокореляція відхилень від тренда:")
print("   Коефіцієнти автокореляції:", acf_residuals)

# Визначення значущості коефіцієнтів автокореляції
alpha_acf = 0.05
significant_acf = any(np.abs(acf_residuals[1:]) > 1.96 / np.sqrt(len(Y_values)))

if significant_acf:
    print("   Є підстави вважати, що є автокореляція відхилень від тренда.")
else:
    print("   Немає достатніх підстав вважати, що є автокореляція відхилень від тренда.")
