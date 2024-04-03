package nltu.task11;

import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.edge.EdgeOptions;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.time.Duration;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;

public class App {
    public static Map<String, String> searchAndRetrieveData(String searchQuery) {
        EdgeOptions options = new EdgeOptions();
        options.addArguments("start-maximized", "--guest");
        EdgeDriver driver = new EdgeDriver(options);

        driver.get("https://rozetka.com.ua/ua/");

        WebDriverWait wait = new WebDriverWait(driver, Duration.ofSeconds(10));

        // Searching and locating elements
        WebElement searchInput =
                wait.until(ExpectedConditions.visibilityOfElementLocated
                        (By.cssSelector(".search-form__input")));

        searchInput.sendKeys(searchQuery);
        driver.findElement(By.cssSelector(".search-form__submit")).click();

        List<WebElement> pageElements =
                wait.until(ExpectedConditions.visibilityOfAllElementsLocatedBy
                        (By.xpath("//div[@class='goods-tile__inner']")));

        // Map for storing title and prices
        Map<String, String> pageMap = new LinkedHashMap<>();

        // Iterate through each and every element
        for (WebElement element : pageElements) {
            WebElement titleElement = element.findElement(By.xpath(".//span[@class='goods-tile__title']"));
            String title = titleElement.getText().trim();

            WebElement priceElement = element.findElement(By.xpath(".//span[@class='goods-tile__price-value']"));
            String price = priceElement.getText().trim();

            pageMap.put(title, price);
        }

        driver.quit();
        return pageMap;
    }

    // Print the results
    public static void printResults(String sessionName, Map<String, String> data) {
        System.out.println("Results for " + sessionName + ":");
        for (Map.Entry<String, String> entry : data.entrySet()) {
            System.out.println("Title: " + entry.getKey() + ", Price: " + entry.getValue());
        }
        System.out.println();
    }

    // Thread for processing smartphones
    public static void executeSessionOne() {
        Map<String, String> sessionOneData = searchAndRetrieveData("Смартфон");
        printResults("Session One", sessionOneData);
    }

    // Thread for processing watches
    public static void executeSessionTwo() {
        Map<String, String> sessionTwoData = searchAndRetrieveData("Годинник");
        printResults("Session Two", sessionTwoData);
    }

    // Thread for processing laptops
    public static void executeSessionThree() {
        Map<String, String> sessionThreeData = searchAndRetrieveData("Ноутбук");
        printResults("Session Three", sessionThreeData);
    }

    public static void main(String[] args) {
        Thread sessionOneThread = new Thread(App::executeSessionOne);
        Thread sessionTwoThread = new Thread(App::executeSessionTwo);
        Thread sessionThreeThread = new Thread(App::executeSessionThree);

        sessionOneThread.start();
        sessionTwoThread.start();
        sessionThreeThread.start();
    }
}
