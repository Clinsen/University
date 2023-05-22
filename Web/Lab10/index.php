<?php
// Отримуємо дані з форми
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $name = $_POST['name'];
    $surname = $_POST['surname'];
    $group = $_POST['group'];
    $variant = $_POST['variant'];
    $email = $_POST['email'];

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

    // Запис даних розрахунку у файл
    $file = fopen('MySurname.txt', 'w');
    fwrite($file, "Ім'я: $name\r\n");
    fwrite($file, "Прізвище: $surname\r\n");
    fwrite($file, "Група: $group\r\n");
    fwrite($file, "Варіант: $variant\r\n");
    fwrite($file, "Email: $email\r\n");
    fwrite($file, "\r\n");
    fwrite($file, "Результати обчислень:\r\n");

    foreach ($expressions as $key => $value) {
        fwrite($file, "$key: $value\r\n");
    }

    fclose($file);

    // Надсилання електронної пошти
    $to = $email;
    $subject = 'Результати обчислень';
    $message = file_get_contents('MySurname.txt');
    $headers = 'From: myemail@gmail.com';

    // Встановлення параметрів SMTP
    ini_set('SMTP', 'files.000webhost.com');
    ini_set('smtp_port', '21');

    // Надсилання електронного листа
    if (mail($to, $subject, $message, $headers)) {
        echo 'Електронний лист надіслано успішно.';
    } else {
        echo 'Помилка під час надсилання електронного листа.';
    }
}

// Виведення вмісту файла на сторінку
function displayFileContents($filename) {
    if (file_exists($filename)) {
        $contents = file_get_contents($filename);
        echo "<pre>$contents</pre>";
    } else {
        echo "Файл не знайдено.";
    }
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

        <label for="email">Email:</label>
        <input type="email" id="email" name="email" required><br>

        <button type="submit">Обчислити</button>
    </form>

    <h2>Результати обчислень</h2>
    <?php
        $filename = 'MySurname.txt';
        displayFileContents($filename);
    ?>
</body>
</html>
