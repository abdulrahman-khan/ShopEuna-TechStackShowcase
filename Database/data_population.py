import pandas as pd
from sqlalchemy import create_engine
import pyodbc

def get_db_connection():
    """
    Establishes a connection to the SQL Server database.
    Returns a SQLAlchemy engine object.
    """
    # Connection string for SQL Server
    connection_string = (
        "mssql+pyodbc://localhost\\SQLEXPRESS/ShopEuna?"
        "driver=ODBC+Driver+17+for+SQL+Server"
    )
    
    try:
        engine = create_engine(connection_string)
        with engine.connect() as conn:
            print("Successfully connected to the database!")
        return engine
    except Exception as e:
        print(f"Error connecting to the database: {str(e)}")
        return None

if __name__ == "__main__":
    engine = get_db_connection()

