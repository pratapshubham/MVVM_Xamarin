using MVVMDemo.Model;
using MVVMDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMDemo.ViewModel
{
   public class MainViewModel :ViewModelBase
    {

        public MainViewModel()
        {
            var service = new CustomerServices();

            CustomerList = service.GetCustomers();
        }

        private List<Customer> customerList;
        public List<Customer> CustomerList
        {
            get { return customerList; }
            set { SetProperty(ref customerList, value); }
        }
    }

   
}
