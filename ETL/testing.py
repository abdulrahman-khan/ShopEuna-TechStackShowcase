import requests
import json

response = requests.get('https://fakestoreapi.com/users')
data = response.json()

# Write the JSON data to a file
with open('ETL/users.json', 'w') as json_file:
    json.dump(data, json_file, indent=4)

print("Data has been exported to users.json")