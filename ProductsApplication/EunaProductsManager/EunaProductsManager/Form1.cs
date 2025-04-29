using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace EunaProductsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        public int currentCustomerID = 3;

        // Binding
        BindingSource ordersBindingSource = new BindingSource();
        CustomerList DAOobject = new CustomerList();
        Customer currentCustomer = new Customer();
        List<Orders> ordersList = new List<Orders>();

        private void Form1_Load(object sender, EventArgs e)
        {
            currentCustomerID = 1;
            reloadVariables();
        }

        private void reloadVariables()
        {
            currentCustomer = DAOobject.getCustomer(currentCustomerID);
            ordersList = DAOobject.getCustomerOrders(currentCustomerID);
            ordersBindingSource.DataSource = ordersList;

            customerid.Text = currentCustomer.customer_id.ToString();
            customername.Text = currentCustomer.first_name + " " + currentCustomer.last_name;
            Lemail.Text = currentCustomer.email.ToString();
            Lphone.Text = currentCustomer.phone.ToString();
            Lage.Text = currentCustomer.age.ToString();
            Lgender.Text = currentCustomer.gender.ToString();


            dataGridView1.DataSource = ordersList;

        }

        Customer getCurrentCustomer()
        {
            return currentCustomer;
        }

        private void next_Click(object sender, EventArgs e)
        {
            currentCustomerID = currentCustomerID + 1;
            reloadVariables();
        }
        private void previous_Click(object sender, EventArgs e)
        {
            currentCustomerID = currentCustomerID - 1;
            reloadVariables();
        }

    }
}
