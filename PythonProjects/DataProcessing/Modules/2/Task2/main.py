import numpy as np
import matplotlib.pyplot as plt
import control as ctrl

def W(p, k, T2, T1):
    return k / (T2 * p**2 + T1 * p + 1)

k = 2.2
T1 = 3
T2 = 2

numerator = [k]
denominator = [T2, T1, 1]
sys_plant = ctrl.TransferFunction(numerator, denominator)

# Часовий вектор
time_vector = np.linspace(0, 10, 1000)

# Симуляція системи без регулятора
time, response_open_loop = ctrl.step_response(sys_plant, time_vector)

# PID-регулятор
neural_controller = ctrl.TransferFunction([1, 1], [1, 0.1, 0.01])

# Симуляція системи з регулятором
sys_closed_loop = ctrl.feedback(neural_controller * sys_plant)
time, response_closed_loop = ctrl.step_response(sys_closed_loop, time_vector)

# Результати
plt.figure(figsize=(10, 6))
plt.plot(time, response_open_loop, label='Без регулятора (відкритий контур)')
plt.plot(time, response_closed_loop, label='З регулятором (закритий контур)')
plt.xlabel('Час')
plt.ylabel('Відгук системи')
plt.title('Симуляція системи керування')
plt.legend()
plt.grid(True)
plt.show()
