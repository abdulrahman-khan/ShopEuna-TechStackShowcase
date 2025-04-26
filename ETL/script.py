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



##  -- EXTRACT -- ##

# SQL Database
connection_string = 'mssql+pyodbc://localhost\\SQLEXPRESS/ShopEuna?driver=ODBC+Driver+17+for+SQL+Server'
source_engine = sqlalchemy.create_engine(connection_string) 

# Load tables
customers_df = pd.read_sql('SELECT * FROM Customers', source_engine)
customers_df_size = len(customers_df)
departments_df = pd.read_sql('SELECT * FROM Departments', source_engine)
products_df = pd.read_sql('SELECT * FROM Products', source_engine)
orders_df = pd.read_sql('SELECT * FROM Orders', source_engine)
order_items_df = pd.read_sql('SELECT * FROM OrderItems', source_engine)
payments_df = pd.read_sql('SELECT * FROM Payments', source_engine)


# Extract Customer Dataset
customer_dataset_df = pd.read_csv('ETL/Shop Customer Data.csv')
customer_dataset_df = customer_dataset_df.head(customers_df_size)


# Extract API
url = 'https://dummyjson.com/users'
params = {
    'limit': customers_df_size,
    'skip': 0,
}
response = requests.get(url, params=params)

data = response.json()
df = pd.DataFrame(data['users'])


##  -- TRANSFORM -- ##

# Convert JSON to DataFrame with flattened structure
customerapi_df = pd.json_normalize(
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

# print(customers_df.info())
# print(customer_dataset_df.info())
# print(customerapi_df.info())

customers_df.columns = [col.lower() for col in customers_df.columns]
customer_dataset_df.columns = [col.lower() for col in customer_dataset_df.columns]
customerapi_df.columns = [col.lower() for col in customerapi_df.columns]

database_cols = ["customerid", "firstname", "lastname", "email", "createddate"]
dataset_cols = ["gender", "age", "annual income ($)", "spending score (1-100)", "profession", "work experience", "family size"]
api_cols = ["phone", "bloodgroup", "height", "weight", "eyecolor", "hair_color", "hair_type", "address_address", "address_city", "address_state", "address_statecode", "address_postalcode", "address_coordinates_lat", "address_coordinates_lng", "address_country", "bank_cardexpire", "bank_cardnumber", "bank_cardtype", "bank_currency", "bank_iban"]

customers_df = customers_df[database_cols]
customer_dataset_df = customer_dataset_df[dataset_cols]
customerapi_df = customerapi_df[api_cols]


# print(customers_df.info())
# print(customer_dataset_df.info())
# print(customerapi_df.info())


##  -- LOAD -- ##
customers_data_df = pd.merge(customers_df, customer_dataset_df, left_index=True, right_index=True, how='inner')
customers_data_df = pd.merge(customers_data_df, customerapi_df, left_index=True, right_index=True, how='inner')

# print(customers_data_df.info())


# Create database connection
connection_string = 'mssql+pyodbc://localhost\\SQLEXPRESS/NewEuna2025?driver=ODBC+Driver+17+for+SQL+Server'
target_engine = sqlalchemy.create_engine(connection_string)

# Push tables to target database
tables_to_load = {
    'Customers': customers_data_df,
    'Departments': departments_df,
    'Products': products_df,
    'Orders': orders_df,
    'OrderItems': order_items_df,
    'Payments': payments_df
}

for table_name, df in tables_to_load.items():
    df.to_sql(
        name=table_name,
        con=target_engine,
        if_exists='replace',   # replace the table if it exists
        index=False,          # don't include DataFrame index as a column
        schema='dbo'          # SQL Server schema name
    )
    print(f"Loaded {len(df)} rows to {table_name} table")


