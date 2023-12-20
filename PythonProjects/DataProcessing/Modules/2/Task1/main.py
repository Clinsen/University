import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
from sklearn.linear_model import LinearRegression

T_values = np.array([2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016])
Y_values = np.array([9, 6, 3, 8, 15, 5, 7, 6, 13, 9, 4, 10, 15, 7, 6, 8])

# Додаємо 6 за варіантом
Y_values_modified = Y_values + 6

regression_model = LinearRegression().fit(T_values.reshape(-1, 1), Y_values_modified.reshape(-1, 1))
predicted_Y = regression_model.predict(T_values.reshape(-1, 1))

# Результати
print("Коефіцієнт регресії (нахил):", regression_model.coef_[0][0])
print("Перетин (зсув):", regression_model.intercept_[0])

# Графік
plt.scatter(T_values, Y_values_modified, label='Справжні значення Y', color='blue')
plt.plot(T_values, predicted_Y, label='Прогнозовані значення Y', color='red')
plt.xlabel('T (роки)')
plt.ylabel('Y (змінена)')
plt.legend()
plt.show()