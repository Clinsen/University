using HtmlAgilityPack;

class Program {
    static async Task Main(string[] args) {
        // URL of the website to scrape
        string websiteUrl = "https://rozetka.com.ua/ua/";
        Dictionary<string, string> itemCollection = new Dictionary<string, string>();

        // Download and parse 3 pages
        Task[] tasks =
        [
            searchForItem(websiteUrl, "Смартфон", itemCollection),
            searchForItem(websiteUrl, "Ноутбук", itemCollection),
            searchForItem(websiteUrl, "Годинник", itemCollection)
        ];

        // Wait for all tasks to complete
        await Task.WhenAll(tasks);

        // Display the items and their prices
        Console.WriteLine("\nItems and their prices:");
        foreach (var item in itemCollection) {
            Console.WriteLine($"Item: {item.Key}, Price: {item.Value}");
        }
    }

    static async Task searchForItem(string websiteUrl, string inputValue, Dictionary<string, string> itemCollection) {
        using (HttpClient client = new HttpClient()) {
            // Prepare the form data
            var formData = new Dictionary<string, string>
            {
                { "search", inputValue }
            };

            // Create the HTTP request
            var request = new HttpRequestMessage(HttpMethod.Post, websiteUrl);
            request.Content = new FormUrlEncodedContent(formData);

            // Send the request
            var response = await client.SendAsync(request);

            // Check if the request was successful
            if (response.IsSuccessStatusCode) {
                // Read the response content
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response content for \"{inputValue}\": {content}");

                // Load HTML document
                var doc = new HtmlDocument();
                doc.LoadHtml(content);

                // Parse the search results
                var searchResults = new List<string>();
                var itemNodes = doc.DocumentNode.SelectNodes("//div[@class='goods-tile__inner']");

                if (itemNodes != null) {
                    foreach (var itemNode in itemNodes) {
                        // Get the title of the item
                        string? title = itemNode.SelectSingleNode("//span[@class='goods_tile__title']")?.InnerText;

                        // Get the price of the item
                        string? price = itemNode.SelectSingleNode("//span[@class='goods_tile__price-value']")?.InnerText;

                        // Add the item and its price to the list
                        if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(price)) {
                            // Remove extra spaces and newlines from title and price
                            title = title.Trim();
                            price = price.Trim();

                            // Add the item to the list
                            searchResults.Add($"Item: {title}, Price: {price}");
                        }
                    }

                    // Output the search results
                    Console.WriteLine($"Search results for \"{inputValue}\":");
                    foreach (var result in searchResults) {
                        Console.WriteLine(result);
                    }
                }
                else {
                    Console.WriteLine("No items found in the search results.");
                }
            }
            else {
                Console.WriteLine($"Failed to search for \"{inputValue}\". Status code: {response.StatusCode}");
            }
        }
    }
}
