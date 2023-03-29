#include <iostream>
#include <cmath>
#include <algorithm>
#include <numeric>
#include <ctime>

void fill_array(int array[])
{
    for (int i = 0; i < 10; i++)
    {
       array[i] = rand() % 201 - 100;
    }
}

const void print_array(int array[])
{
    std::cout << "Printing the array: ";
    for (int i = 0; i < 10; i++)
    {
        std::cout << array[i] << " ";
    }
}

void replace_with_zero(int arr[], int n)
{
    int start, end;
    std::cout << "Enter the range of values to replace with 0 (start and end): ";
    std::cin >> start >> end;

    for (int i = 0; i < n; i++) 
    {
        if (arr[i] >= start && arr[i] <= end) // check whether the element is in that range
        { 
            arr[i] = 0;
        }
    }
}

int main()
{
    int arr[10];

    srand(time(NULL));

    fill_array(arr);
    print_array(arr);

    int size = sizeof(arr) / sizeof(int);


    int min_abs = abs(*std::min_element(arr, arr + size, [](int a, int b) {return abs(a) < abs(b); }));
    int max_abs = abs(*std::max_element(arr, arr + size, [](int a, int b) {return abs(a) < abs(b); }));
    auto first_neg = std::find_if(arr, arr + size, [](int a) {return a < 0; });
    int sum_abs = std::accumulate(first_neg == std::end(arr) ? arr : first_neg + 1, arr + size, 0, [](int a, int b) {return a + abs(b); });

    std::cout << "\n\nThe number with the lowest absolute value in the array is: " << min_abs;
    std::cout << "\nThe number with the highest absolute value in the array is: " << max_abs;
    std::cout << "\nThe sum of absolute values that are located after the first negative element in the array: " << sum_abs << "\n";

    replace_with_zero(arr, size);
    std::cout << "\n\n";
    print_array(arr);

    return 0;
}