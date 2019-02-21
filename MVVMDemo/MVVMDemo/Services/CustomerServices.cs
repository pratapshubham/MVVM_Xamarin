using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMDemo.Services
{
    public class CustomerServices
    {
        public CustomerServices()
        {

        }

        public List<Customer> GetCustomers()
        {
            var list = new List<Customer>
            {
                new Customer
                {
                    Firstname = "Shubham",
                     Lastname = "Pratap"
                },

                new Customer
                {
                    Firstname = "Kushal",
                     Lastname = "Pratap"
                },

                new Customer
                {
                    Firstname = "Sangam",
                     Lastname = "Kumar"
                },
                new Customer
                {
                    Firstname = "Shubham",
                     Lastname = "Mittal"
                },
            };
            return list;
        }
    }
}
