#include <iostream>
#include <vector>

std::vector<std::vector<int>> intersection(std::vector<std::vector<int>> P, std::vector<std::vector<int>> Q) {
    // Returns the intersection of matrices P and Q.
    std::vector<std::vector<int>> result(P.size(), std::vector<int>(P[0].size()));
    for (int i = 0; i < P.size(); i++) {
        for (int j = 0; j < P[0].size(); j++) {
            result[i][j] = P[i][j] & Q[i][j];
        }
    }
    return result;
}

std::vector<std::vector<int>> unionn(std::vector<std::vector<int>> P, std::vector<std::vector<int>> Q) {
    // Returns the union of matrices P and Q.
    std::vector<std::vector<int>> result(P.size(), std::vector<int>(P[0].size()));
    for (int i = 0; i < P.size(); i++) {
        for (int j = 0; j < P[0].size(); j++) {
            result[i][j] = P[i][j] | Q[i][j];
        }
    }
    return result;
}

std::vector<std::vector<int>> difference(std::vector<std::vector<int>> P, std::vector<std::vector<int>> Q) {
    // Returns the difference of matrices P and Q (P - Q).
    std::vector<std::vector<int>> result(P.size(), std::vector<int>(P[0].size()));
    for (int i = 0; i < P.size(); i++) {
        for (int j = 0; j < P[0].size(); j++) {
            result[i][j] = P[i][j] & ~Q[i][j];
        }
    }
    return result;
}

std::vector<std::vector<int>> composition(std::vector<std::vector<int>> P, std::vector<std::vector<int>> Q) {
    // Returns the composition of matrices P and Q.
    std::vector<std::vector<int>> result(P.size(), std::vector<int>(Q[0].size()));
    for (int i = 0; i < P.size(); i++) {
        for (int j = 0; j < Q[0].size(); j++) {
            int sum = 0;
            for (int k = 0; k < P[0].size(); k++) {
                sum += P[i][k] * Q[k][j];
            }
            result[i][j] = (sum > 0) ? 1 : 0;
        }
    }
    return result;
}

int main() 
{
    // Var. 6
    std::vector<std::vector<int>> P = { {0, 0, 1, 0, 0}, {0, 0, 1, 0, 0}, {1, 0, 0, 1, 0}, {0, 0, 1, 1, 0}, {1, 0, 0, 0, 0} };
    std::vector<std::vector<int>> Q = { {0, 1, 0, 0, 0}, {0, 1, 0, 0, 0}, {0, 0, 1, 0, 0}, {0, 1, 0, 0, 1}, {1, 1, 0, 0, 0} };

    std::cout << "P:" << std::endl;
    for (std::vector<int> row : P) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    std::cout << "\n";
    std::cout << "Q:" << std::endl;
    for (std::vector<int> row : Q) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    std::cout << "\n";
    std::cout << "Intersection of P and Q:" << std::endl;
    std::vector<std::vector<int>> intersection_result = intersection(P, Q);
    for (std::vector<int> row : intersection_result) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    std::cout << "\n";
    std::cout << "Union of P and Q:" << std::endl;
    std::vector<std::vector<int>> union_result = unionn(P, Q);
    for (std::vector<int> row : union_result) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    std::cout << "\n";
    std::cout << "Difference of P and Q:" << std::endl;
    std::vector<std::vector<int>> difference_result = difference(P, Q);
    for (std::vector<int> row : difference_result) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    std::cout << "\n";
    std::cout << "Composition of P and Q:" << std::endl;
    std::vector<std::vector<int>> composition_result = composition(P, Q);
    for (std::vector<int> row : composition_result) {
        for (int element : row) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    return 0;
}