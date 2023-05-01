import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class ConeVolumeCalculator implements ActionListener {
    private JTextField radius1Field, radius2Field, heightField, volumeField;
    private JButton calculateButton;

    public ConeVolumeCalculator() {
        JFrame frame = new JFrame("Калькулятор об'єму зрізаного конуса");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(400, 250);
        frame.setLayout(new GridLayout(5, 2));

        JLabel radius1Label = new JLabel("Радіус малої основи (r1):");
        radius1Field = new JTextField();
        frame.add(radius1Label);
        frame.add(radius1Field);

        JLabel radius2Label = new JLabel("Радіус великої основи (r2):");
        radius2Field = new JTextField();
        frame.add(radius2Label);
        frame.add(radius2Field);

        JLabel heightLabel = new JLabel("Висота (h):");
        heightField = new JTextField();
        frame.add(heightLabel);
        frame.add(heightField);

        JLabel volumeLabel = new JLabel("Об'єм:");
        volumeField = new JTextField();
        volumeField.setEditable(false);
        frame.add(volumeLabel);
        frame.add(volumeField);

        calculateButton = new JButton("Обчислити");
        calculateButton.addActionListener(this);
        frame.add(calculateButton);

        frame.setVisible(true);

    }

    public static void main(String[] args) {
        new ConeVolumeCalculator();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == calculateButton) {
            try {
                double r1 = Double.parseDouble(radius1Field.getText());
                double r2 = Double.parseDouble(radius2Field.getText());
                double h = Double.parseDouble(heightField.getText());

                double volume = Math.PI / 3.0 * h * (r1 * r1 + r1 * r2 + r2 * r2);

                volumeField.setText(String.format("%.2f", volume));
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(null, "Невірний формат введених даних", "Помилка", JOptionPane.ERROR_MESSAGE);
            }
        }
    }
}