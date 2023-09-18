import 'dart:math';

void main() {
  double x = 1.23 * 6;
  double y = 4.6 * 6;
  double z = 36.6 / 6;

  Function a = (double bValue) {
    double b() {
      return pow(cos(atan((pow(x, 2) + y) / (z + 1)) + x / y * exp(3 * x + y)), 2).toDouble();
    }

    return (1 + sqrt(pow(sin(pow((x + y).abs(), 0.4)), 2))) /
        (2 + pow(bValue, 2) + pow(sin(pow(y, 3)), 2));
  };

  for (int i = 1; i <= 10; i++) {
    double resultB = a(x);
    double resultA = a(resultB);
    print('Ітерація $i: Значення a = $resultA; Значення b = $resultB');
  }
}
