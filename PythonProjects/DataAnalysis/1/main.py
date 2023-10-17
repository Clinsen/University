import requests
from bs4 import BeautifulSoup
import re

url = 'https://www.worldometers.info/gdp/gdp-by-country/'
response = requests.get(url)

soup = BeautifulSoup(response.text, 'html.parser')
country_elements = soup.select('table tr td a')

# A-Za-z: Matches uppercase and lowercase letters
# À-ÖØ-öø-ÿ: Matches various accented characters commonly found in different languages
# \': Matches apostrophes
# + allows apostrophes in the country names
pattern = r'^[A-Za-zÀ-ÖØ-öø-ÿ\s\']+'
filtered_countries = [element.text for element in country_elements if re.match(pattern, element.text)]

# Enumerate the filtered countries starting from 1
countries = [(index + 1, country) for index, country in enumerate(filtered_countries)]

print("GDP by Country ranking:")
for index, country in countries:
    print(f"{index}. {country}")
