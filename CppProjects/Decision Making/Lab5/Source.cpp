#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include "windows.h"

using namespace std;

// Структура для зберігання оцінок альтернатив
struct Alternative {
    int id; // ідентифікатор альтернативи
    vector<int> q; // вектор оцінок альтернативи за кожним критерієм
};

// Функція для порівняння альтернатив за допомогою методу Парето
bool pareto_compare(const Alternative& a1, const Alternative& a2) {
    // Перевіряємо, чи кожна оцінка першої альтернативи не гірша від відповідної оцінки другої альтернативи
    bool flag = true;
    for (size_t i = 0; i < a1.q.size(); ++i) {
        if (a1.q[i] > a2.q[i]) {
            flag = false;
            break;
        }
    }
    return flag;
}

// Функція для порівняння альтернатив за допомогою методу Слейтера
bool slater_compare(const Alternative& a1, const Alternative& a2) {
    // Знаходимо максимальну різницю між відповідними оцінками двох альтернатив
    int max_diff = 0;
    for (size_t i = 0; i < a1.q.size(); ++i) {
        int diff = abs(a1.q[i] - a2.q[i]);
        if (diff > max_diff) {
            max_diff = diff;
        }
    }
    // Перевіряємо, чи перша альтернатива не гірша від другої за кожним критерієм на значення, яке не більше за максимальну різницю
    bool flag = true;
    for (size_t i = 0; i < a1.q.size(); ++i) {
        if (a1.q[i] + max_diff < a2.q[i]) {
            flag = false;
            break;
        }
    }
    return flag;
}

// Функція для порівняння альтернатив за допомогою методу найкращого результату
bool best_result_compare(const Alternative& a1, const Alternative& a2) {
    // Знаходимо мінімальну оцінку для кожної альтернативи
    int min_q1 = *min_element(a1.q.begin(), a1.q.end());
    int min_q2 = *min_element(a2.q.begin(), a2.q.end());
    // Порівнюємо мінімальні оцінки альтернатив
    return min_q1 > min_q2;
}

// Функція порівняння для методу ґарантованого результату
bool guaranteed_result_compare(const Alternative& a1, const Alternative& a2) {
    // Знаходимо максимальну оцінку для кожної альтернативи
    int max_q1 = *max_element(a1.q.begin(), a1.q.end());
    int max_q2 = *max_element(a2.q.begin(), a2.q.end());
    // Порівнюємо максимальні оцінки альтернатив
    return max_q1 < max_q2;
}

// Функція порівняння для методу Гурвіца
bool hurwicz_compare(const Alternative& a1, const Alternative& a2) {
    double alpha = 0.5; // Параметр методу
    // Знаходимо мінімальну та максимальну оцінки для кожної альтернативи
    int min_q1 = *min_element(a1.q.begin(), a1.q.end());
    int max_q1 = *max_element(a1.q.begin(), a1.q.end());
    int min_q2 = *min_element(a2.q.begin(), a2.q.end());
    int max_q2 = *max_element(a2.q.begin(), a2.q.end());

    // Порівнюємо за методом Парето
    bool a1_worse_than_a2_in_pareto = true;
    for (int i = 0; i < a1.q.size(); i++) {
        if (a1.q[i] > a2.q[i]) {
            a1_worse_than_a2_in_pareto = false;
            break;
        }
    }
    if (a1_worse_than_a2_in_pareto) {
        return false;
    }
    bool a2_worse_than_a1_in_pareto = true;
    for (int i = 0; i < a2.q.size(); i++) {
        if (a2.q[i] > a1.q[i]) {
            a2_worse_than_a1_in_pareto = false;
            break;
        }
    }
    if (a2_worse_than_a1_in_pareto) {
        return true;
    }

    // Порівнюємо за методом Слейтера
    bool a1_better_or_equal_than_a2_in_slater = true;
    for (int i = 0; i < a1.q.size(); i++) {
        if (a1.q[i] < a2.q[i]) {
            a1_better_or_equal_than_a2_in_slater = false;
            break;
        }
    }
    if (a1_better_or_equal_than_a2_in_slater) {
        return true;
    }
    bool a2_better_than_a1_in_slater = true;
    for (int i = 0; i < a2.q.size(); i++) {
        if (a2.q[i] < a1.q[i]) {
            a2_better_than_a1_in_slater = false;
            break;
        }
    }
    if (a2_better_than_a1_in_slater) {
        return false;
    }

    // Порівнюємо за методом найкращого результату
    if (min_q1 > min_q2) {
        return false;
    }
    if (min_q2 > min_q1) {
        return true;
    }

    // Порівнюємо за методом ґарантованого результату
    if (max_q1 < max_q2) {
        return false;
    }
    if (max_q2 < max_q1) {
        return true;
    }

    // Порівнюємо за методом Гурвіца
    double lambda = 0.5;
    double a1_score_in_gurvits = lambda * min_q1 + (1 - lambda) * max_q1;
    double a2_score_in_gurvits = lambda * min_q2 + (1 - lambda) * max_q2;
    if (a1_score_in_gurvits < a2_score_in_gurvits) {
        return false;
    }
    if (a2_score_in_gurvits < a1_score_in_gurvits) {
        return true;
    }

    // Порівнюємо лексикоґрафічно
    for (int i = 0; i < a1.q.size(); i++) {
        if (a1.q[i] < a2.q[i]) {
            return true;
        }
        if (a1.q[i] > a2.q[i]) {
            return false;
        }
    }

    // Повертаємо false якщо обидві альтернативи мають однаковий результат за всіма методами
    return false;
}

int main() {
    SetConsoleCP(1251); // встановлення кодування Windows-1251 в  потік введення
    SetConsoleOutputCP(1251); // встановлення кодування Windows-1251 в  потік виведення

    Alternative a1 = { 1, {2, 4, 6} };
    Alternative a2 = { 2, {4, 5, 6} };
    Alternative a3 = { 3, {1, 3, 5} };

    cout << boolalpha;

    cout << "Порівняння альтернатив за допомогою методу Парето:\n";
    cout << pareto_compare(a1, a2) << "\n";
    cout << pareto_compare(a2, a1) << "\n";
    cout << pareto_compare(a1, a3) << "\n\n";

    cout << "Порівняння альтернатив за допомогою методу Слейтера:\n";
    cout << slater_compare(a1, a2) << "\n";
    cout << slater_compare(a2, a1) << "\n";
    cout << slater_compare(a1, a3) << "\n\n";

    cout << "Порівняння альтернатив за допомогою методу найкращого результату:\n";
    cout << best_result_compare(a1, a2) << "\n";
    cout << best_result_compare(a2, a1) << "\n";
    cout << best_result_compare(a1, a3) << "\n\n";

    cout << "Порівняння альтернатив за допомогою методу гарантованого результату:\n";
    cout << guaranteed_result_compare(a1, a2) << "\n";
    cout << guaranteed_result_compare(a2, a1) << "\n";
    cout << guaranteed_result_compare(a1, a3) << "\n\n";

    cout << "Порівняння альтернатив за допомогою методу Гурвіца\n";
    cout << hurwicz_compare(a1, a2) << "\n";
    cout << hurwicz_compare(a2, a1) << "\n";
    cout << hurwicz_compare(a1, a3) << "\n";

    return 0;
}

