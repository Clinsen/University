A1 = [200, 170, 174, 189]
A2 = [175, 193, 167, 188]
A3 = [190, 190, 192, 193]
A4 = [188, 200, 202, 197]

B1 = [200, 175, 190, 188]
B2 = [175, 193, 190, 200]
B3 = [174, 167, 192, 202]
B4 = [189, 188, 191, 197]

# Обчислення вибіркової дисперсії
def calculate_sample_variance(data):
    mean = sum(data) / len(data)
    variance = sum((x - mean) ** 2 for x in data) / len(data)
    return variance

# Обчислення середніх значень фактора A для кожного рівня фактора B
mean_A_B1 = sum(B1) / len(B1)
mean_A_B2 = sum(B2) / len(B2)
mean_A_B3 = sum(B3) / len(B3)
mean_A_B4 = sum(B4) / len(B4)

# Обчислення вибіркової дисперсії середніх значень фактора A
variance_A = calculate_sample_variance([mean_A_B1, mean_A_B2, mean_A_B3, mean_A_B4])

print("Вибіркова дисперсія, обумовлена впливом фактору B на фактор A:", variance_A)