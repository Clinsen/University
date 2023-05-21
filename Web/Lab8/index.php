<!DOCTYPE html>
<html>
<head>
    <title>Варіант №6</title>
    <style>
        table {
            border-collapse: collapse;
        }

        th, td {
            border: 1px solid black;
            padding: 8px;
            text-align: left;
        }
    </style>
</head>
<body>
    <?php
    function calculateResult($x, $y, $z)
    {
        $result = (pow(($y - tan(pow(abs($z), 2))), 0.42) + abs(sqrt(pow(sin($z), 2) + $x))) / (1 + (pow($x, 2) * abs(3 + exp($y - 1))));
        return $result;
    }

    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        $name = $_POST['name'];
        $surname = $_POST['surname'];
        $group = $_POST['group'];
        $variant = $_POST['variant'];

        $x = 1.23 * $variant;
        $y = 4.6 * $variant;
        $z = 36.6 * $variant;

        $result = calculateResult($x, $y, $z);
    ?>

    <h2>Результат обчислення:</h2>
    <table>
        <tr>
            <th>Параметр</th>
            <th>Значення</th>
        </tr>
        <tr>
            <td>Ім'я</td>
            <td><?php echo $name; ?></td>
        </tr>
        <tr>
            <td>Прізвище</td>
            <td><?php echo $surname; ?></td>
        </tr>
        <tr>
            <td>Група</td>
            <td><?php echo $group; ?></td>
        </tr>
        <tr>
            <td>Варіант</td>
            <td><?php echo $variant; ?></td>
        </tr>
        <tr>
            <td>X1</td>
            <td><?php echo $x; ?></td>
        </tr>
        <tr>
            <td>Y1</td>
            <td><?php echo $y; ?></td>
        </tr>
        <tr>
            <td>Z1</td>
            <td><?php echo $z; ?></td>
        </tr>
        <tr>
            <td>Результат</td>
            <td><?php echo $result; ?></td>
        </tr>
    </table>

    <?php
    } else {
    ?>
    <form action="" method="POST">
        <label for="name">Ім'я:</label>
        <input type="text" id="name" name="name" required><br>

        <label for="surname">Прізвище:</label>
        <input type="text" id="surname" name="surname" required><br>

        <label for="group">Група:</label>
        <input type="text" id="group" name="group" required><br>

        <label for="variant">Варіант:</label>
        <input type="text" id="variant" name="variant" required><br>

        <input type="submit" value="Обчислити">
    </form>
    <?php
    }
    ?>
</body>
</html>
