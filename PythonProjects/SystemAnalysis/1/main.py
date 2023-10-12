import math
from enum import Enum


class Operations(Enum):
    MIN = "min"
    MAX = "max"


def f1x_func(x):
    return 0.8 * math.exp(-2 * (x - 3) ** 2)


def f2x_func(x):
    return 10 - 6 * x + x ** 2


def calculate_values(min_x, max_x, step, f1_star, f2_star):
    x_values = []
    f1_divide_values = []
    f2_divide_values = []

    for x in range(int(min_x * 10), int(max_x * 10), int(step * 10)):
        x /= 10
        f1x_value = f1x_func(x)
        f2x_value = f2x_func(x)

        if f1x_value >= f1_star and f2x_value >= f2_star:
            f1_divide_values.append(f1x_value / f1_star)
            f2_divide_values.append(f2x_value / f2_star)
            x_values.append(x)

    return x_values, f1_divide_values, f2_divide_values


def find_and_show_min_or_max(arr1, arr2, operation):
    result_values = []
    for val1, val2 in zip(arr1, arr2):
        if operation == Operations.MIN:
            result_values.append(min(val1, val2))
        elif operation == Operations.MAX:
            result_values.append(max(val1, val2))
    return result_values


def find_global_minmax(values, operation):
    if operation == Operations.MIN:
        return min(values)
    elif operation == Operations.MAX:
        return max(values)


def display_values(x_values, values, name):
    print(name)
    for index, (x, value) in enumerate(zip(x_values, values), start=1):
        print(f"{index}. | x: {x:.2f} --> {value:.2f}")


minX = 1
maxX = 5
step = 0.1
f1_star = 0.2
f2_star = 1

x_values, f1_divide_values, f2_divide_values = calculate_values(minX, maxX, step, f1_star, f2_star)

display_values(x_values, f1_divide_values, "\n======== F1 values ========")
display_values(x_values, f2_divide_values, "\n======== F2 values ========")

minimum_values = find_and_show_min_or_max(f1_divide_values, f2_divide_values, Operations.MIN)
maximum_values = find_and_show_min_or_max(f1_divide_values, f2_divide_values, Operations.MAX)

display_values(x_values, minimum_values, "\n======== Minimum values ========")
display_values(x_values, maximum_values, "\n======== Maximum values ========")

global_min_value = find_global_minmax(minimum_values, Operations.MIN)
global_max_value = find_global_minmax(maximum_values, Operations.MAX)

print("\nGlobal MinMax:", global_min_value)
print("Global MaxMin:", global_max_value)