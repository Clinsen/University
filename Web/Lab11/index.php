<?php
// Параметри підключення до бази даних
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "NLTUWEB";

// Отримуємо дані з форми
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $name = $_POST['name'];
    $surname = $_POST['surname'];
    $group = $_POST['group'];
    $variant = $_POST['variant'];

    // Обчислення значень
    $xp = 1.23 * $variant;
    $xk = $xp + 10;
    $deltaX = 1;

    // Функція для обчислення виразів
    function calculateExpressions($xp, $xk, $deltaX) {
        $expressions = array(
            "Expression 1" => pow($xp, 2) + sin($xk),
            "Expression 2" => exp($xk) - sqrt($xp),
            "Expression 3" => log($xk + $deltaX)
        );

        return $expressions;
    }

    // Обчислення виразів
    $expressions = calculateExpressions($xp, $xk, $deltaX);

    // Підключення до бази даних
    $conn = new mysqli($servername, $username, $password, $dbname);
    if ($conn->connect_error) {
        die("Помилка підключення до бази даних: " . $conn->connect_error);
    }

    // Вставка обчислених даних в таблицю
    $stmt = $conn->prepare("INSERT INTO calculations (x, y, z, result) VALUES (?, ?, ?, ?)");
    $stmt->bind_param("ddds", $xp, $xk, $deltaX, $expressionsString);

    // Приєднання рядка зі значеннями виразів
    $expressionsString = implode(", ", $expressions);

    if ($stmt->execute()) {
        echo "Дані успішно вставлено в таблицю.";
    } else {
        echo "Помилка вставки даних в таблицю: " . $stmt->error;
    }

    $stmt->close();
    }

// Виведення даних з таблиці на сторінку
function displayTableContents() {
    global $servername, $username, $password, $dbname;

    // Підключення до бази даних
    $conn = new mysqli($servername, $username, $password, $dbname);
    if ($conn->connect_error) {
        die("Помилка підключення до бази даних: " . $conn->connect_error);
    }

    // Вибірка даних з таблиці
    $sql = "SELECT * FROM calculations";
    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        echo "<h2>Вміст таблиці</h2>";
        echo "<table>";
        echo "<tr><th>ID</th><th>X</th><th>Y</th><th>Z</th><th>Result</th></tr>";

        while ($row = $result->fetch_assoc()) {
            echo "<tr>";
            echo "<td>" . $row["id"] . "</td>";
            echo "<td>" . $row["x"] . "</td>";
            echo "<td>" . $row["y"] . "</td>";
            echo "<td>" . $row["z"] . "</td>";
            echo "<td>" . $row["result"] . "</td>";
            echo "</tr>";
        }

        echo "</table>";
    } else {
        echo "Таблиця пуста.";
    }

    $conn->close();
}

?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Обчислення</title>
</head>
<body>
    <h1>Форма обчислень</h1>
    <form method="post" action="">
        <label for="name">Ім'я:</label>
        <input type="text" id="name" name="name" required><br>

        <label for="surname">Прізвище:</label>
        <input type="text" id="surname" name="surname" required><br>

        <label for="group">Група:</label>
        <input type="text" id="group" name="group" required><br>

        <label for="variant">Варіант:</label>
        <input type="text" id="variant" name="variant" required><br>

        <button type="submit">Обчислити</button>
    </form>

    <?php
    // Виведення даних з таблиці на сторінку
    displayTableContents();
    ?>
</body>
</html>
