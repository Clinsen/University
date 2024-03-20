namespace _14 {
    public static class BubbleSort {
        public static void Sort(int[] array, int numThreads) {
            int n = array.Length;
            bool swapped;

            do {
                swapped = false;

                Parallel.For(0, n - 1, new ParallelOptions { MaxDegreeOfParallelism = numThreads }, i => {
                    if (array[i] > array[i + 1]) {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                });

            } while (swapped);

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
