import javax.swing.*;
import java.awt.event.*;

public class Menu implements ActionListener {
    private JMenuBar menuBar;
    private JMenu fileMenu, viewMenu, openSubMenu;
    private JMenuItem openMessageItem, openFaxItem, closeItem;
    private JCheckBoxMenuItem taskAreaItem;

    public Menu() {
        JFrame frame = new JFrame("Лабораторна №13");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(300, 200);

        // Створення рядкового меню
        menuBar = new JMenuBar();

        // Створення меню "Файл" та пунктів "Відкрити" та "Закрити"
        fileMenu = new JMenu("Файл");
        openSubMenu = new JMenu("Відкрити");
        openMessageItem = new JMenuItem("Повідомлення");
        openFaxItem = new JMenuItem("Факс");
        closeItem = new JMenuItem("Закрити");
        openSubMenu.add(openMessageItem);
        openSubMenu.add(openFaxItem);
        fileMenu.add(openSubMenu);
        fileMenu.add(closeItem);

        // Створення меню "Вигляд" та пунктів "Структура" та "Колонтитули"
        viewMenu = new JMenu("Вигляд");
        JMenuItem structureItem = new JMenuItem("Структура");
        JMenuItem headersItem = new JMenuItem("Колонтитули");
        viewMenu.add(structureItem);
        viewMenu.add(headersItem);

        // Створення пункту з прапорцем "Область завдань"
        taskAreaItem = new JCheckBoxMenuItem("Область завдань");
        viewMenu.addSeparator();
        viewMenu.add(taskAreaItem);

        // Додавання меню до рядкового меню
        menuBar.add(fileMenu);
        menuBar.add(viewMenu);

        // Додавання рядкового меню до фрейму
        frame.setJMenuBar(menuBar);

        frame.setVisible(true);
    }

    public static void main(String[] args) {
        new Menu();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        // Обробка подій від пунктів меню
    }
}