#include <iostream>
#include <vector>
#include <cmath>
#pragma warning(disable: 4267)

using namespace std;

vector<vector<int>> Q = { {0, 0, 0, 0, 1},
                         {0, 0, 1, 0, 0},
                         {0, 0, 0, 0, 0},
                         {0, 0, 1, 1, 0},
                         {0, 0, 1, 0, 0} };

vector<vector<int>> P = { {0, 0, 1, 1, 0},
                         {0, 1, 0, 0, 0},
                         {0, 0, 0, 0, 0},
                         {0, 0, 0, 1, 1},
                         {0, 0, 0, 0, 0} };

vector<vector<int>> R = { {0, 0, 1, 0, 0},
                         {1, 0, 1, 0, 0},
                         {0, 0, 1, 0, 1},
                         {0, 0, 1, 0, 0},
                         {1, 1, 0, 0, 0} };


bool isReflexive(vector<vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        if (matrix[i][i] != 1) {
            return false;
        }
    }
    return true;
}
bool isIrreflexive(vector<vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        if (matrix[i][i] != 0) {
            return false;
        }
    }
    return true;
}
bool isSymmetric(vector<vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        for (int j = i + 1; j < matrix[i].size(); j++) {
            if (matrix[i][j] != matrix[j][i]) {
                return false;
            }
        }
    }
    return true;
}
bool isAsymmetric(vector<vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        for (int j = i + 1; j < matrix[i].size(); j++) {
            if (matrix[i][j] == 1 && matrix[j][i] == 1) {
                return false;
            }
        }
    }
    return true;
}
bool isAntisymmetric(vector<vector<int>> matrix) {
    for (int i = 0; i < matrix.size(); i++) {
        for (int j = i + 1; j < matrix[i].size(); j++) {
            if (matrix[i][j] == 1 && matrix[j][i] == 1 && i != j) {
                return false;
            }
        }
    }
    return true;
}
bool isTransitive(vector<vector<int>> matrix) {
    int n = matrix.size();
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            if (matrix[i][j] == 1) {
                for (int k = 0; k < n; k++) {
                    if (matrix[j][k] == 1 && matrix[i][k] != 1) {
                        return false;
                    }
                }
            }
        }
    }
    return true;
}
bool isAcyclic(vector<vector<int>> matrix) {
    int n = matrix.size();
    for (int i = 0; i < n; i++) {
        if (matrix[i][i] == 1) {
            return false;
        }
    }
    return true;
}
bool isLinear(vector<vector<int>> matrix) {
    int n = matrix.size();
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            if (matrix[i][j] == 1 && matrix[j][i] == 1 && i != j) {
                return false;
            }
        }
    }
    return true;
}


// RELATIVITY TYPE CHECK
bool isTolerance(const std::vector<std::vector<int>>& matrix) {
    return isReflexive(matrix) && isSymmetric(matrix);
}
bool isEquivalence(const std::vector<std::vector<int>>& matrix) {
    return isReflexive(matrix) && isSymmetric(matrix) && isTransitive(matrix);
}
bool isQuasiOrder(const std::vector<std::vector<int>>& matrix) {
    return isReflexive(matrix) && isTransitive(matrix);
}
bool isOrder(const std::vector<std::vector<int>>& matrix) {
    return isReflexive(matrix) && isAntisymmetric(matrix) && isTransitive(matrix);
}
bool isStrictOrder(const std::vector<std::vector<int>>& matrix) {
    return isIrreflexive(matrix) && isAntisymmetric(matrix) && isTransitive(matrix);
}


// FACTORIZATION
bool is_prime(int n) {
    if (n < 2) {
        return false;
    }
    for (int i = 2; i <= sqrt(n); i++) {
        if (n % i == 0) {
            return false;
        }
    }
    return true;
}

// function to find all the prime factors of a number
vector<int> prime_factors(int n) {
    vector<int> factors;
    int p = 2;
    while (n > 1) {
        if (n % p == 0) {
            factors.push_back(p);
            n /= p;
        }
        else {
            p++;
            while (!is_prime(p)) {
                p++;
            }
        }
    }
    return factors;
}

// function to print the prime factorization of a number
void print_factorization(int n) {
    vector<int> factors = prime_factors(n);
    cout << n << " = ";
    for (int i = 0; i < factors.size(); i++) {
        cout << factors[i];
        if (i < factors.size() - 1) {
            cout << " x ";
        }
    }
    cout << endl;
}


int main()
{
    // TASK 1
    std::cout << std::boolalpha;
    std::cout << "Matrix Q:\n";
    std::cout << "Reflective: " << isReflexive(Q) << std::endl;
    std::cout << "Antireflective: " << isIrreflexive(Q) << std::endl;
    std::cout << "Symmetric: " << isSymmetric(Q) << std::endl;
    std::cout << "Asymmetric: " << isAsymmetric(Q) << std::endl;
    std::cout << "Antisymmetric: " << isAntisymmetric(Q) << std::endl;
    std::cout << "Transitive: " << isTransitive(Q) << std::endl;
    std::cout << "Acyclic: " << isAcyclic(Q) << std::endl;
    std::cout << "Linear: " << isLinear(Q) << std::endl;

    std::cout << "\nMatrix P:\n";
    std::cout << "Reflective: " << isReflexive(P) << std::endl;
    std::cout << "Antireflective: " << isIrreflexive(P) << std::endl;
    std::cout << "Symmetric: " << isSymmetric(P) << std::endl;
    std::cout << "Asymmetric: " << isAsymmetric(P) << std::endl;
    std::cout << "Antisymmetric: " << isAntisymmetric(P) << std::endl;
    std::cout << "Transitive: " << isTransitive(P) << std::endl;
    std::cout << "Acyclic: " << isAcyclic(P) << std::endl;
    std::cout << "Linear: " << isLinear(P) << std::endl;

    std::cout << "\nMatrix R:\n";
    std::cout << "Reflective: " << isReflexive(R) << std::endl;
    std::cout << "Antireflective: " << isIrreflexive(R) << std::endl;
    std::cout << "Symmetric: " << isSymmetric(R) << std::endl;
    std::cout << "Asymmetric: " << isAsymmetric(R) << std::endl;
    std::cout << "Antisymmetric: " << isAntisymmetric(R) << std::endl;
    std::cout << "Transitive: " << isTransitive(R) << std::endl;
    std::cout << "Acyclic: " << isAcyclic(R) << std::endl;
    std::cout << "Linear: " << isLinear(R) << std::endl;

    // TASK 2
    bool result = isTolerance(Q);
    std::cout << "\nQ is a tolerance relation: " << result << std::endl;
    result = isEquivalence(Q);
    std::cout << "Q is an equivalence relation: " << result << std::endl;
    result = isQuasiOrder(Q);
    std::cout << "Q is a quasi-order relation: " << result << std::endl;
    result = isOrder(Q);
    std::cout << "Q is an order relation: " << result << std::endl;
    result = isStrictOrder(Q);
    std::cout << "Q is a strict order relation: " << result << std::endl;

    result = isTolerance(P);
    std::cout << "\nP is a tolerance relation: " << result << std::endl;
    result = isEquivalence(P);
    std::cout << "P is an equivalence relation: " << result << std::endl;
    result = isQuasiOrder(P);
    std::cout << "P is a quasi-order relation: " << result << std::endl;
    result = isOrder(P);
    std::cout << "P is an order relation: " << result << std::endl;
    result = isStrictOrder(P);
    std::cout << "P is a strict order relation: " << result << std::endl;

    result = isTolerance(R);
    std::cout << "\nR is a tolerance relation: " << result << std::endl;
    result = isEquivalence(R);
    std::cout << "R is an equivalence relation: " << result << std::endl;
    result = isQuasiOrder(R);
    std::cout << "R is a quasi-order relation: " << result << std::endl;
    result = isOrder(R);
    std::cout << "R is an order relation: " << result << std::endl;
    result = isStrictOrder(R);
    std::cout << "R is a strict order relation: " << result << std::endl;


    // TASK 3
    int n;
    cout << "\n\nEnter a number to factorize: ";
    cin >> n;
    print_factorization(n);

    return 0;
}