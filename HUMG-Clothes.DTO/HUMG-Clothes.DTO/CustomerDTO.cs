using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class CustomerDTO
    {
        int _CustomerID;

        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        string _CustomerName;

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        string _CustomerPhone;

        public string CustomerPhone
        {
            get { return _CustomerPhone; }
            set { _CustomerPhone = value; }
        }
        string _CustomerEmail;

        public string CustomerEmail
        {
            get { return _CustomerEmail; }
            set { _CustomerEmail = value; }
        }
        string _CustomerCity;

        public string CustomerCity
        {
            get { return _CustomerCity; }
            set { _CustomerCity = value; }
        }
        string _CustomerAddress;

        public string CustomerAddress
        {
            get { return _CustomerAddress; }
            set { _CustomerAddress = value; }
        }
        string _CustomerTown;

        public string CustomerTown
        {
            get { return _CustomerTown; }
            set { _CustomerTown = value; }
        }

        public CustomerDTO()
        {
            this.CustomerID = 0;
            this.CustomerName = "";
            this.CustomerPhone = "";
            this.CustomerEmail = "";
            this.CustomerCity = "";
            this.CustomerTown = "";
            this.CustomerAddress = "";
        }
        public CustomerDTO(int CustomerID, string CustomerName,string CustomerPhone, string CustomerEmail, string CustomerCity, string CustomerTown, string CustomerAddress) {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.CustomerPhone = CustomerPhone;
            this.CustomerEmail = CustomerEmail;
            this.CustomerCity = CustomerCity;
            this.CustomerTown = CustomerTown;
            this.CustomerAddress = CustomerAddress;
        }
    }
}
   