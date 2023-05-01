import javax.swing.JFrame;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Toolkit;

public class Main {
    public static void main(String[] args) {
        // Створення об'єкту вікна
        JFrame frame = new JFrame();

        // Встановлення розміру вікна
        frame.setSize(200, 300);

        // Отримання розміру екрану
        Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();

        // Розрахунок координат x та y для вікна
        int x = (int) ((screenSize.getWidth() - frame.getWidth()) / 2);
        int y = 0;

        // Встановлення позиції вікна у верхній центр екрану
        frame.setLocation(x, y);

        // Встановлення заголовку вікна
        frame.setTitle("Верхнє центральне вікно");

        // Встановлення реакції на закриття вікна
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        // Встановлення видимості вікна
        frame.setVisible(true);

        // Встановлення стандартного режиму вікна
        frame.setExtendedState(JFrame.NORMAL);

        // Встановлення вікна на передній план
        frame.setAlwaysOnTop(true);

        // Встановлення кольору фону вікна
        frame.setBackground(Color.RED);

        // Виведення інформації про розмір вікна, його позицію та стан
        System.out.println("Size: " + frame.getSize());
        System.out.println("Location: " + frame.getLocation());
        System.out.println("Стан: " + frame.getExtendedState());
    }
}