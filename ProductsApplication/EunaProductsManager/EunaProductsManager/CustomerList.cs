using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// CONTROLLER FILE
// HAS THE DATABASE LIST OBJECTS
namespace EunaProductsManager
{
    internal class CustomerList
    {

        public Customer currentcustomer = new Customer();

        public List<Orders> ordersList = new List<Orders>();

        string connectionString = @"Server=localhost\SQLEXPRESS;Database=NewEuna2025;Trusted_Connection=True;TrustServerCertificate=True;";

        //returns the orders for a given customer
        public List<Orders> getCustomerOrders(int customerid)
        {
            List<Orders> returnList = new List<Orders>();

            string getorders = @"
        SELECT 
            pr.Name AS Product_Name, 
            ord.OrderDate AS Order_Date, 
            oi.Quantity, 
            ord.TotalAmount AS Total_Amount, 
            de.Name AS Department_Name
        FROM OrderItems oi
        INNER JOIN Orders ord ON ord.OrderID = oi.OrderID
        INNER JOIN Products pr ON pr.ProductID = oi.ProductID
        INNER JOIN Departments de ON de.DepartmentID = pr.DepartmentID
        WHERE ord.CustomerID = @customerid
        ORDER BY ord.OrderDate;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(getorders, connection))
                {
                    command.Parameters.AddWithValue("@customerid", customerid); // Safe parameterization

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Orders order = new Orders()
                            {
                                Quantity = reader["Quantity"].ToString(),
                                Order_Date = reader["Order_Date"].ToString(),
                                Total_Amount = reader["Total_Amount"].ToString(),
                                Product_Name = reader["Product_Name"].ToString(),
                                Department_Name = reader["Department_Name"].ToString()
                            };

                            returnList.Add(order);
                        }
                    }
                }
            }

            return returnList;
        }



        public Customer getCustomer(int customerid)
        {
            Customer customer = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getcustomers = "SELECT customerid, firstname, lastname, email, gender, age, phone, address_city, address_state, address_country FROM Customers WHERE customerid = @customerid;";
                using (SqlCommand command = new SqlCommand(getcustomers, connection))
                {
                    command.Parameters.AddWithValue("@customerid", customerid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new Customer
                            {
                                customer_id = (int)Convert.ToInt64(reader["customerid"]),
                                first_name = reader["firstname"].ToString(),
                                last_name = reader["lastname"].ToString(),
                                email = reader["email"].ToString(),
                                gender = reader["gender"].ToString(),
                                age = reader["age"].ToString(),
                                phone = reader["phone"].ToString(),
                                city = reader["address_city"].ToString(),
                                country = reader["address_country"].ToString(),
                                state = reader["address_state"].ToString()
                            };
                        }
                    }
                }
            }
            return customer;
        }

    }
}
