#include "Real.h"
#include "Complex.h"
#include "Vector.h"
#include "Matrix.h"

int main()
{
    std::cout << "=================== Real ===================\n\n";
    Real real1;
    std::cout << "Input value of your object: ";
    std::cin >> real1;
    std::cout << "Value of your object: " << real1 << "\n";
    std::cout << "Calculating norm of your object: " << real1.calculate_norm() << "\n\n";

    std::cout << "=================== Complex ===================\n\n";
    Complex complex1(5, 3);
    std::cout << "Imaginary value of your complex object: " << complex1.get_imaginary() <<"\n";
    std::cout << "Real value of your complex object: " << complex1.get_real () << "\n";
    std::cout << "Calculating norm of your complex object: " << complex1.calculate_norm() << "\n\n";

    std::cout << "=================== Vector ===================\n\n";
    Vector vector1;
    vector1.append_vector();
    vector1.display_vector();
    std::cout << "Calculating norm of the vector: " << vector1.calculate_norm() << "\n\n";

    std::cout << "=================== Matrix ===================\n\n";
    Matrix matrix1(10, 10);
    matrix1.fill_matrix();
    matrix1.print_matrix();
    std::cout << "\nCalculating norm of the matrix: " << matrix1.calculate_norm() << "\n\n";

    std::cout << "=================== Vector of Complex Numbers, Dynamic Binding Demonstration ===================\n\n";
    Real real2(-1.22);
    Complex complex2(1.4, 5);
    Complex complex3(2.2, -3.7);

    std::vector<Real*>numbers;

    numbers.emplace_back(&real2);
    numbers.emplace_back(&complex2);
    numbers.emplace_back(&complex3);

    Real temp = 0;
    for (Real* numberPtr : numbers)
    {
        std::cout << numberPtr->calculate_norm() << "\n";
        if (temp < numberPtr->calculate_norm())
        {
            temp = numberPtr->calculate_norm();
        }
    }
    std::cout << "\nLargest absolute value: " << temp << "\n\n";

    return 0;
}