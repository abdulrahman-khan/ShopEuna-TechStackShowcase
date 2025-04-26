import requests
import json
import pandas as pd

url = 'https://dummyjson.com/users'
params = {
    'limit': 150,
    'skip': 0,
}

response = requests.get(url, params=params)
data = response.json()

# Save to JSON file
with open('ETL/users.json', 'w') as f:
    json.dump(data, f, indent=4)

print("Data saved to users.json")


df = pd.DataFrame(data['users'])

# Convert JSON to DataFrame with flattened structure
df = pd.json_normalize(
    data['users'],
    sep='_',
    meta=[
        'id', 'firstName', 'lastName', 'maidenName', 'age', 'gender',
        'email', 'phone', 'username', 'password', 'birthDate', 'image',
        'bloodGroup', 'height', 'weight', 'eyeColor', 'ip', 'macAddress',
        'university', 'ein', 'ssn', 'userAgent', 'role'
    ],
    record_path=None,
    meta_prefix=None,
    errors='ignore'
)

print(df.head())
print(df.info())
