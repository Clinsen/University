#include <iostream>

const int SIZE = 5;

bool compatible(int A[][SIZE], int B[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            if ((A[i][j] == 1 && B[i][j] == 0) || (A[i][j] == 0 && B[i][j] == 1)) {
                return false;
            }
        }
    }
    return true;
}

bool additive(int A[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            if (A[i][j] != A[j][i]) {
                return false;
            }
            if (A[i][j] == 1 && A[j][i] == 1) {
                for (int k = 0; k < SIZE; k++) {
                    if (A[j][k] == 1 && A[k][i] == 1 && A[i][k] != 1) {
                        return false;
                    }
                }
            }
        }
    }
    return true;
}

bool consistent(int A[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        if (A[i][i] != 0) {
            return false;
        }
    }
    return true;
}

bool multiplicative(int A[][SIZE]) {
    if (!consistent(A)) {
        return false;
    }
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            if (A[i][j] == 1) {
                for (int k = 0; k < SIZE; k++) {
                    if (A[j][k] == 1 && A[i][k] != 1) {
                        return false;
                    }
                }
            }
        }
    }
    return true;
}

void union_matrix(int A[][SIZE], int B[][SIZE], int C[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            C[i][j] = A[i][j] | B[i][j];
        }
    }
}

void intersection_matrix(int A[][SIZE], int B[][SIZE], int C[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            C[i][j] = A[i][j] & B[i][j];
        }
    }
}

void difference_matrix(int A[][SIZE], int B[][SIZE], int C[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            C[i][j] = A[i][j] & ~B[i][j];
        }
    }
}

void symmetric_difference_matrix(int A[][SIZE], int B[][SIZE], int C[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            C[i][j] = (A[i][j] && !B[i][j]) || (!A[i][j] && B[i][j]);
        }
    }
}

void composition_matrix(int A[][SIZE], int B[][SIZE], int C[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            C[i][j] = 0;
            for (int k = 0; k < SIZE; k++) {
                C[i][j] = C[i][j] | (A[i][k] & B[k][j]);
            }
        }
    }
}

bool metric_relation(int A[][SIZE]) {
    if (!compatible(A, A)) {
        return false;
    }
    if (!additive(A) && !multiplicative(A)) {
        return false;
    }
    if (additive(A) && multiplicative(A)) {
        return false;
    }
    return true;
}

int main() {
    int Q[SIZE][SIZE] = { {1, 1, 1, 0, 0},
                         {1, 1, 0, 1, 0},
                         {1, 0, 1, 0, 1},
                         {0, 1, 0, 1, 1},
                         {0, 0, 1, 1, 1} };

    int R[SIZE][SIZE] = { {1, 1, 1, 0, 1},
                         {1, 1, 0, 1, 1},
                         {1, 0, 1, 1, 0},
                         {0, 1, 1, 1, 1},
                         {1, 1, 0, 1, 1} };

    std::cout << "Properties of relation Q:\n";
    std::cout << "Compatible: " << (compatible(Q, Q) ? "Yes" : "No") << std::endl;
    std::cout << "Additive: " << (additive(Q) ? "Yes" : "No") << std::endl;
    std::cout << "Multiplicative: " << (multiplicative(Q) ? "Yes" : "No") << std::endl;
    std::cout << "Consistent: " << (consistent(Q) ? "Yes" : "No") << std::endl;

    std::cout << "\nProperties of relation R:\n";
    std::cout << "Compatible: " << (compatible(R, R) ? "Yes" : "No") << std::endl;
    std::cout << "Additive: " << (additive(R) ? "Yes" : "No") << std::endl;
    std::cout << "Multiplicative: " << (multiplicative(R) ? "Yes" : "No") << std::endl;
    std::cout << "Consistent: " << (consistent(R) ? "Yes" : "No") << std::endl;

    int P[SIZE][SIZE];
    intersection_matrix(Q, R, P);
    std::cout << "\nP = Q ∩ R:\n";
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            std::cout << P[i][j] << " ";
        }
        std::cout << std::endl;
    }

    int S[SIZE][SIZE];
    union_matrix(Q, R, S);
    std::cout << "\nS = Q ∪ R:\n";
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            std::cout << S[i][j] << " ";
        }
        std::cout << std::endl;
    }

    int D[SIZE][SIZE];
    difference_matrix(Q, R, D);
    std::cout << "\nD = Q - R:\n";
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            std::cout << D[i][j] << " ";
        }
        std::cout << std::endl;
    }

    int SD[SIZE][SIZE];
    symmetric_difference_matrix(Q, R, SD);
    std::cout << "\nSD = Q Δ R:\n";
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            std::cout << SD[i][j] << " ";
        }
        std::cout << std::endl;
    }

    int C[SIZE][SIZE];
    composition_matrix(Q, R, C);
    std::cout << "\nC = Q • R:\n";
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) {
            std::cout << C[i][j] << " ";
        }
        std::cout << std::endl;
    }

    std::cout << "\nIs Q a metric relation? " << (metric_relation(Q) ? "Yes" : "No") << std::endl;
    std::cout << "Is R a metric relation? " << (metric_relation(R) ? "Yes" : "No") << std::endl;
    std::cout << "Is P a metric relation? " << (metric_relation(P) ? "Yes" : "No") << std::endl;
    std::cout << "Is S a metric relation? " << (metric_relation(S) ? "Yes" : "No") << std::endl;

    return 0;
}