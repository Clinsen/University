import java.util.HashMap;

public class ImageMap {
    private HashMap<String, String> imageMap;

    public ImageMap() {
        imageMap = new HashMap<String, String>();
    }

    public void addImage(String author, String book) {
        Image newImage = new Image(author, book);
        imageMap.put(newImage.getAuthor(), newImage.getBook());
    }

    public void removeImage(String author) {
        imageMap.remove(author);
    }

    public String searchImage(String author) {
        return imageMap.get(author);
    }
}