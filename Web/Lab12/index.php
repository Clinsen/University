<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "nltuajax";

// Підключення до бази даних
$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Помилка підключення до бази даних: " . $conn->connect_error);
}

// Запит на отримання даних з таблиці "ajax"
$sql = "SELECT * FROM ajax";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // Створення XML-документу
    $xmlDoc = new DOMDocument('1.0', 'UTF-8');
    $xmlDoc->formatOutput = true;

    // Створення кореневого елементу
    $root = $xmlDoc->createElement("poets");
    $xmlDoc->appendChild($root);

    // Додавання записів з бази даних до XML-файлу
    while ($row = $result->fetch_assoc()) {
        $poet = $xmlDoc->createElement("poet");
        $root->appendChild($poet);

        foreach ($row as $key => $value) {
            $element = $xmlDoc->createElement($key, $value);
            $poet->appendChild($element);
        }
    }

    // Збереження XML-файлу
    $xmlDoc->save("poets.xml");

    echo "XML-файл успішно створено і збережено.";

} else {
    echo "Немає записів у таблиці 'ajax'.";
}

// Закриття підключення до бази даних
$conn->close();
?>

<!DOCTYPE html>
<html>
<head>
    <title>Пошук по базі даних</title>
</head>
<body>
    <form method="POST" action="">
        <label for="search_term">Введіть слово для пошуку:</label>
        <input type="text" name="search_term" id="search_term">
        <input type="submit" value="Пошук">
    </form>

    <?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $searchTerm = $_POST["search_term"];

        // Завантаження XML-файлу
        $xmlDoc = new DOMDocument();
        $xmlDoc->load("poets.xml");

        $xpath = new DOMXPath($xmlDoc);

        // Пошук за введеним терміном
        $query = "//poet[contains(name, '$searchTerm')] | //poet[contains(description, '$searchTerm')]";
        $results = $xpath->query($query);

        if ($results->length > 0) {
            echo "<h2>Результати пошуку:</h2>";
            foreach ($results as $result) {
                echo "<p>";
                foreach ($result->childNodes as $node) {
                    echo $node->nodeName . ": " . $node->nodeValue . "<br>";
                }
                echo "</p>";
            }
        } else {
            echo "Немає результатів для пошукового терміна: '$searchTerm'.";
        }
    }
    ?>
</body>
</html>
