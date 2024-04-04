package nltu.task11;

import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
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
    public static void main(String[] args) {
        Thread sessionOneThread = new Thread(() -> executeSession("Смартфон", "Session One"));
        Thread sessionTwoThread = new Thread(() -> executeSession("Годинник", "Session Two"));
        Thread sessionThreeThread = new Thread(() -> executeSession("Ноутбук", "Session Three"));

        sessionOneThread.start();
        sessionTwoThread.start();
        sessionThreeThread.start();
    }

    public static void executeSession(String searchQuery, String sessionName) {
        EdgeOptions options = new EdgeOptions();
        options.addArguments("start-maximized", "--guest");
        WebDriver driver = new EdgeDriver(options);
        WebDriverWait wait = new WebDriverWait(driver, Duration.ofSeconds(15));

        try {
            driver.get("https://allo.ua");

            WebElement searchInput =
                    wait.until(ExpectedConditions.elementToBeClickable
                            (By.cssSelector(".search-form__input")));

            searchInput.sendKeys(searchQuery);
            searchInput.sendKeys(Keys.ENTER);

            List<WebElement> pageElements =
                    wait.until(ExpectedConditions.presenceOfAllElementsLocatedBy
                            (By.cssSelector(".product-card__content")));

            Map<String, String> pageMap = new LinkedHashMap<>();
            for (WebElement element : pageElements) {
                WebElement titleElement = element.findElement(By.cssSelector(".product-card__title"));
                WebElement priceElement = element.findElement(By.cssSelector(".v-pb__cur.v-pb__cur"));

                String title = titleElement.getText().trim();
                String price = priceElement.getText().trim();

                pageMap.put(title, price);
            }

            printResults(sessionName, pageMap);

        } finally {
            driver.manage().deleteAllCookies();
            driver.quit();
        }
    }

    public static void printResults(String sessionName, Map<String, String> data) {
        System.out.println("Results for " + sessionName + ":");
        for (Map.Entry<String, String> entry : data.entrySet()) {
            System.out.println("Title: " + entry.getKey() + ", Price: " + entry.getValue());
        }
        System.out.println();
    }
}