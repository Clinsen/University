public class Main {
    public static void main(String[] args) {
        ImageMap imageMap = new ImageMap();

        // Додавання елементів
        imageMap.addImage("Stephen King", "The Shining");
        imageMap.addImage("J.K. Rowling", "Harry Potter and the Philosopher's Stone");

        // Пошук елементів
        System.out.println(imageMap.searchImage("Stephen King")); // The Shining
        System.out.println(imageMap.searchImage("J.K. Rowling")); // Harry Potter and the Philosopher's Stone

        // Видалення елемента
        imageMap.removeImage("Stephen King");
        System.out.println(imageMap.searchImage("Stephen King")); // Шукаємо елемент, який був видалений
    }
}