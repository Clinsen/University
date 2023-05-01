import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

public class Main {
    public static void main(String[] args) {
        JFrame frame = new JFrame("Лабораторна №11");
        frame.setSize(500, 500);
        frame.setLocationRelativeTo(null); // розміщення вікна по центру
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JPanel panel = new JPanel();
        JLabel label = new JLabel("Кліки мишкою: 0");
        panel.add(label);

        frame.add(panel, BorderLayout.CENTER);
        frame.setVisible(true);

        // Створення адаптера миші
        MouseAdapter adapter = new MouseAdapter() {
            private int clicks = 0; // лічильник кліків

            // Обробник події кліку мишкою
            @Override
            public void mouseClicked(MouseEvent e) {
                clicks++; // збільшення лічильника
                label.setText("Кліки мишкою: " + clicks); // відображення кількості кліків у мітці
            }

            // Обробник події виходу курсору за межі вікна
            @Override
            public void mouseExited(MouseEvent e) {
                Dimension windowSize = frame.getSize(); // отримання розмірів вікна
                int x = e.getXOnScreen(); // отримання координати X курсора на екрані
                int y = e.getYOnScreen(); // отримання координати Y курсора на екрані

                // перевірка, чи вийшов курсор за межі екрана
                if (x < 0 || x > windowSize.width || y < 0 || y > windowSize.height) {
                    JOptionPane.showMessageDialog(frame, "Курсор вийшов за межі вікна!");
                }
            }
        };

        // Додавання адаптера миші до вікна
        frame.addMouseListener(adapter);
    }
}