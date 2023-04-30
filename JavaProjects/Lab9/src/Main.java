import java.util.Random;

public class Main {
    public static void main(String[] args) {
        int[] arr = new int[6];
        Random random = new Random();

        // Створення 3 потоків вводу
        Thread thread1 = new Thread(() -> {
            for (int i = 0; i < 2; i++) {
                arr[i] = random.nextInt(41) + 10; // Випадкове число в межах 10-50
            }
        });
        Thread thread2 = new Thread(() -> {
            for (int i = 2; i < 4; i++) {
                arr[i] = random.nextInt(41) + 10; // Випадкове число в межах 10-50
            }
        });
        Thread thread3 = new Thread(() -> {
            for (int i = 4; i < 6; i++) {
                arr[i] = random.nextInt(41) + 10; // Випадкове число в межах 10-50
            }
        });

        // Запуск потоків вводу
        thread1.start();
        thread2.start();
        thread3.start();

        try {
            // Очікування завершення потоків вводу
            thread1.join();
            thread2.join();
            thread3.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        // Виведення масиву на екран
        for (int i = 0; i < 6; i++) {
            System.out.print(arr[i] + " ");
        }
    }
}