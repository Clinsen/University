#include <iostream>
#include <vector>

std::vector<std::vector<int>> transitive_closure(std::vector<std::vector<int>> matrix) {
    int n = matrix.size();

    std::vector<std::vector<int>> result = matrix;

    for (int k = 0; k < n; k++) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (result[i][k] == 1 && result[k][j] == 1) {
                    result[i][j] = 1;
                }
            }
        }
    }

    return result;
}

int main() {
    // Var.6
    std::vector<std::vector<int>> P = { {0, 0, 1, 0, 0}, {0, 0, 1, 0, 0}, {1, 0, 0, 1, 0}, {0, 0, 1, 0, 0}, {1, 0, 0, 0, 0} };

    std::cout << "P:" << std::endl;
    for (std::vector<int> row : P) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    // Compute the transitive closure of the matrix P
    std::vector<std::vector<int>> transitive_R = transitive_closure(P);

    std::cout << "\nTransitive closure of P:" << std::endl;
    for (std::vector<int> row : transitive_R) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    return 0;
}