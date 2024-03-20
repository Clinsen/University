namespace _14 {
    public static class ShellSort {
        public static void Sort(int[] array, int numThreads) {
            int n = array.Length;
            int gap = n / 2;

            while (gap > 0) {
                // Розбиття на підмасиви
                for (int i = 0; i < gap; i++) {
                    Parallel.For(i + gap, n, new ParallelOptions { MaxDegreeOfParallelism = numThreads }, j => {
                        int temp = array[j];
                        int k = j;

                        // Сортування підмасивів (вставка для підмасивів)
                        while (k >= gap && array[k - gap] > temp) {
                            array[k] = array[k - gap];
                            k -= gap;
                        }
                        array[k] = temp;
                    });
                }

                gap /= 2;
            }

            PrintArray(array);
        }

            private static void PrintArray(int[] array) {
            foreach (var item in array) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
