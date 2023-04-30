import java.util.ArrayList;

public class DynamicArray {
    private ArrayList<ArrayElement> dynamicArray;

    public DynamicArray() {
        dynamicArray = new ArrayList<ArrayElement>();
    }

    public void addElement(String author, String book) {
        ArrayElement newArrayElement = new ArrayElement(author, book);
        dynamicArray.add(newArrayElement);
    }

    public void removeElement(String author) {
        for (ArrayElement arrayElement : dynamicArray) {
            if (arrayElement.getAuthor().equals(author)) {
                dynamicArray.remove(arrayElement);
                break;
            }
        }
    }

    public String searchElement(String author) {
        for (ArrayElement arrayElement : dynamicArray) {
            if (arrayElement.getAuthor().equals(author)) {
                return arrayElement.getBook();
            }
        }
        return null;
    }
}