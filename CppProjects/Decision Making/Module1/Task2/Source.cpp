#include <iostream>
#include <vector>

// Function to test for reflectivity
bool is_reflexive(std::vector<std::vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        if (matrix[i][i] == 0) {
            return false;
        }
    }
    return true;
}

// Function to test for antireflectivity
bool is_antireflexive(std::vector<std::vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        if (matrix[i][i] == 1) {
            return false;
        }
    }
    return true;
}

// Function to test for symmetry
bool is_symmetric(std::vector<std::vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        for (int j = i + 1; j < matrix.size(); j++) {
            if (matrix[i][j] != matrix[j][i]) {
                return false;
            }
        }
    }
    return true;
}

// Function to test for asymmetry
bool is_asymmetric(std::vector<std::vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        for (int j = i + 1; j < matrix.size(); j++) {
            if (matrix[i][j] == 1 && matrix[j][i] == 1) {
                return false;
            }
        }
    }
    return true;
}

int main() 
{
    // Var.6
    std::vector<std::vector<int>> P = { {0, 0, 1, 0, 0}, {0, 0, 1, 0, 0}, {1, 0, 0, 1, 0}, {0, 0, 1, 1, 0}, {1, 0, 0, 0, 0} };

   std::cout << "P:" << std::endl;
    for (std::vector<int> row : P) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    std::cout << "\n";
    // Test for reflectivity
    if (is_reflexive(P)) {
        std::cout << "P is reflexive." << std::endl;
    }
    else {
        std::cout << "P is not reflexive." << std::endl;
    }

    // Test for antireflectivity
    if (is_antireflexive(P)) {
        std::cout << "P is antireflexive." << std::endl;
    }
    else {
        std::cout << "P is not antireflexive." << std::endl;
    }

    // Test for symmetry
    if (is_symmetric(P)) {
        std::cout << "P is symmetric." << std::endl;
    }
    else {
        std::cout << "P is not symmetric." << std::endl;
    }

    // Test for asymmetry
    if (is_asymmetric(P)) {
        std::cout << "P is asymmetric." << std::endl;
    }
    else {
        std::cout << "P is not asymmetric." << std::endl;
    }

    return 0;
}