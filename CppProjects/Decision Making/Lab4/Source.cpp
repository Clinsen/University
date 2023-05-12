#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>
#include "windows.h"

using namespace std;

const int N = 5;

int Q[N][N] = { {1, 0, 0, 0, 0},
               {0, 1, 0, 0, 0},
               {1, 1, 1, 1, 1},
               {0, 0, 0, 1, 0},
               {1, 0, 0, 0, 1} };

int R[N][N] = { {1, 0, 0, 0, 0},
               {0, 1, 0, 0, 0},
               {0, 0, 1, 0, 0},
               {0, 0, 0, 1, 1},
               {0, 1, 1, 0, 1} };

int S[N][N] = { {0, -2, -2, -1, -2},
               {2, 0, 0, 1, 0},
               {2, 0, 0, 1, 0},
               {1, -1, -1, 0, -1},
               {2, 0, 0, 1, 0} };

int T[N][N] = { {0, 2, 1, -1, -1},
               {-2, 0, -1, -3, -3},
               {-1, 1, 0, -2, -2},
               {1, 3, 2, 0, 0},
               {1, 3, 2, 0, 0} };

// Функція для знаходження міри близькості на відношеннях лінійного порядку
double linDist(int A[N][N], int B[N][N]) {
    double dist = 0;
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            dist += pow(A[i][j] - B[i][j], 2);
        }
    }
    return sqrt(dist);
}

// Функція для знаходження міри близькості на метризованих відношеннях
double metDist(int A[N][N], int B[N][N]) {
    double dist = 0;
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            dist += pow(A[i][j] - B[i][j], 2);
        }
    }
    return sqrt(dist) / (2 * N);
}

// Функція для знаходження структурної міри близькості на відношеннях еквівалентності
double eqvDist(int A[N][N], int B[N][N]) {
    vector<int> a_classes, b_classes;
    for (int i = 0; i < N; i++) {
        int a_class = -1, b_class = -1;
        for (int j = 0; j < i; j++) {
            if (A[i][j] == 1) {
                a_class = find(a_classes.begin(), a_classes.end(), j) - a_classes.begin();
            }
            if (B[i][j] == 1) {
                b_class = find(b_classes.begin(), b_classes.end(), j) - b_classes.begin();
            }
        }
        if (a_class == -1) {
            a_classes.push_back(i);
        }
        if (b_class == -1) {
            b_classes.push_back(i);
        }
    }
    sort(a_classes.begin(), a_classes.end());
    sort(b_classes.begin(), b_classes.end());
    if (a_classes.size() != b_classes.size()) {
        return -1;
    }
    double dist = 0;
    for (int i = 0; i < a_classes.size(); i++) {
        if (a_classes[i] != b_classes[i]) {
            dist++;
        }
    }
    return dist / N;
}

int main() {
    SetConsoleCP(1251); // встановлення кодування Windows-1251 в  потік введення
    SetConsoleOutputCP(1251); // встановлення кодування Windows-1251 в  потік виведення

    // Знаходимо міру близькості на відношеннях лінійного порядку
    double lin_dist = linDist(T, R);
    cout << "Міра близькості на відношеннях лінійного порядку: " << lin_dist << endl;

    // Знаходимо міру близькості на метризованих відношеннях
    double met_dist = metDist(S, T);
    cout << "Міра близькості на метризованих відношеннях: " << met_dist << endl;

    // Знаходимо структурну міру близькості на відношеннях еквівалентності
    double eqv_dist = eqvDist(Q, S);
    if (eqv_dist == -1) {
        cout << "Структурна міра близькості не може бути знайдена, тому що кількість класів еквівалентності різна" << endl;
    }
    else {
        cout << "Структурна міра близькості на відношеннях еквівалентності: " << eqv_dist << endl;
    }

    return 0;
}