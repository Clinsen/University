import 'dart:math';

void main() {
  double x = 1.23 * 6;
  double y = 4.6 * 6;
  double z = 36.6 / 6;

  Function a = (double xValue, double yValue, double zValue) {
    return (1 + sqrt(pow(sin(pow((xValue + yValue).abs(), 0.4)), 2))) /
        (2 + pow(pow(cos(atan((pow(xValue, 2) + yValue) / (zValue + 1)) +
            xValue / yValue * exp(3 * xValue + yValue)), 2), 2) +
            pow(sin(pow(yValue, 3)), 2));
  };

  for (int i = 1; i <= 10; i++) {
    double resultB = a(x, y, z);
    double resultA = a(x + i, y, z);
    print('Ітерація $i: Значення a = $resultA; Значення b = $resultB');
  }
}