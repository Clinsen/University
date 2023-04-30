public class Main {
    public static void main(String[] args) {
        DynamicArray dynamicArray = new DynamicArray();

        // Додавання елементів
        dynamicArray.addElement("Stephen King", "The Shining");
        dynamicArray.addElement("J.K. Rowling", "Harry Potter and the Philosopher's Stone");

        // Пошук елементів
        System.out.println(dynamicArray.searchElement("Stephen King")); // The Shining
        System.out.println(dynamicArray.searchElement("J.K. Rowling")); // Harry Potter and the Philosopher's Stone

        // Видалення елемента
        dynamicArray.removeElement("Stephen King");
        System.out.println(dynamicArray.searchElement("Stephen King")); // null
    }
}