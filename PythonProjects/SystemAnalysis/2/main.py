from itertools import product

def f12(x1, x2):
    return (-6 * x1**2 + 10 * x1 + 6) * (-2 * x2**2 + 5 * x2 + 8)

def f21(x1, x2):
    return (4 * x2**2 - 9 * x2 + 11) * (-3 * x1**2 + 15)

def calculate_table_values(func, x_range):
    return [[func(x1, x2) for x2 in x_range] for x1 in x_range]

def find_minimums(table_values):
    return [min(row) for row in table_values]

def find_x_stars(table_values, x_range):
    return [(x_range[i], x_range[j]) for i, j in product(range(len(x_range)), repeat=2)
            if table_values[i][j] >= 0]

x1_range = [0, 0.5, 1, 1.5, 2]
x2_range = [-1, -0.5, 0, 0.5, 1]

f12_values = calculate_table_values(f12, x1_range)
f21_values = calculate_table_values(f21, x2_range)

f12_mins = find_minimums(f12_values)
f21_mins = find_minimums(f21_values)

f12_star, f21_star = max(f12_mins), max(f21_mins)

f12_minus_star = [[value - f12_star for value in row] for row in f12_values]
f21_minus_star = [[value - f21_star for value in row] for row in f21_values]

intersection_table = [[max(f12_minus_star[i][j], f21_minus_star[i][j]) for j in range(len(x2_range))] for i in range(len(x1_range))]

x_stars = find_x_stars(intersection_table, x1_range)

print("X1 range:", x1_range)
print("X2 range:", x2_range)
print("F12 values:")
print('\n'.join(map(str, f12_values)))
print("F21 values:")
print('\n'.join(map(str, f21_values)))
print("F12 mins:", f12_mins)
print("F21 mins:", f21_mins)
print("F12 star:", f12_star)
print("F21 star:", f21_star)
print("F12 minus star:")
print('\n'.join(map(str, f12_minus_star)))
print("F21 minus star:")
print('\n'.join(map(str, f21_minus_star)))
print("Intersection table:")
print('\n'.join(map(str, intersection_table)))
print("X stars:")
print('\n'.join(map(str, x_stars)))
