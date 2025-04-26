"""
**ETL Tech Stack (Free or Easy to Set Up):**
*   **Core Components:**
    *   **Python** - Main language (tons of libraries).
    *   **SQL Server / PostgreSQL** - For your SQL database.
*   **Data Manipulation:**
    *   **Pandas** - To manipulate and clean data.
    *   **SQLAlchemy** - To connect Python to your SQL database.
*   **Data Acquisition:**
    *   **Requests** - To pull data from a public API.
*   **Workflow Management:**
    *   **Airflow** or **Prefect** - To schedule and automate the ETL workflows (Airflow is heavier; Prefect is lighter and good for projects).
*   **Deployment:**
    *   **Docker** - Optional, for easy deployment if needed.
    
"""



import pandas as pd
import requests
import sqlalchemy
import pyodbc



## EXTRACT 
# sql
connection_string = 'mssql+pyodbc://localhost\\SQLEXPRESS/ShopEuna?driver=ODBC+Driver+17+for+SQL+Server'
source_engine = sqlalchemy.create_engine(connection_string) 

# Load tables
departments_df = pd.read_sql('SELECT * FROM Departments', source_engine)
customers_df = pd.read_sql('SELECT * FROM Customers', source_engine)
products_df = pd.read_sql('SELECT * FROM Products', source_engine)
orders_df = pd.read_sql('SELECT * FROM Orders', source_engine)
order_items_df = pd.read_sql('SELECT * FROM OrderItems', source_engine)
payments_df = pd.read_sql('SELECT * FROM Payments', source_engine)


# Load Customer Dataset
customer_dataset_df = pd.read_csv('ETL/Shop Customer Data.csv')

# Load API
response = requests.get('https://fakestoreapi.com/users')
users_df = pd.DataFrame(response.json())

# Flatten the address columns
users_df['lat'] = users_df['address'].apply(lambda x: x['geolocation']['lat'])
users_df['long'] = users_df['address'].apply(lambda x: x['geolocation']['long'])
users_df['city'] = users_df['address'].apply(lambda x: x['city'])
users_df['street'] = users_df['address'].apply(lambda x: x['street'])
users_df['number'] = users_df['address'].apply(lambda x: x['number'])
users_df['zipcode'] = users_df['address'].apply(lambda x: x['zipcode'])

# Drop the original nested address column
users_df = users_df.drop('address', axis=1)

print(users_df.dtypes)



#  TRANSFORM







