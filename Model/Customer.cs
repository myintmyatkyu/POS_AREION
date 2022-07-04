using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public class Customer
    {
        public Customer()
        {
           
        }

        public decimal CurrentCredit { get; set; }

        private string _customerID;
        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _contactPerson;

        public string ContactPerson
        {
            get { return _contactPerson; }
            set { _contactPerson = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _phone1;

        public string Phone1
        {
            get { return _phone1; }
            set { _phone1 = value; }
        }
        private string _phone2;

        public string Phone2
        {
            get { return _phone2; }
            set { _phone2 = value; }
        }
        private string _phone3;

        public string Phone3
        {
            get { return _phone3; }
            set { _phone3 = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _transferPerson;

        public string TransferPerson
        {
            get { return _transferPerson; }
            set { _transferPerson = value; }
        }
        private string _nRCNO;

        public string NRCNO
        {
            get { return _nRCNO; }
            set { _nRCNO = value; }
        }
        private string _bankAccount;

        public string BankAccount
        {
            get { return _bankAccount; }
            set { _bankAccount = value; }
        }

        private string _bank;

        public string Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }


    }

    public interface ICustomer
    {
        void OnCustomerChanged(object key);
    }
}
