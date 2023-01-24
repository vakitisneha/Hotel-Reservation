using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace samplewebapi.Models
{
    public class DistributorsProjectModel
    {
        public string productName { get; set; }
        public string ProductId { get; set; }
        public string image { get; set; }
        public Nullable<decimal> price { get; set; }
        public string Description { get; set; }
        //public string prodId { get; set; }
        //public string prodName { get; set; }
        //public string prodimage { get; set; }
        //public string prodDescription { get; set; }
        //public Nullable<decimal> prodprice { get; set; }
        //public Nullable<int> quantity { get; set; }
        //public Nullable<int> total { get; set; }

        public string FullName { get; set; }
        public long MobileNumber { get; set; }
        public Nullable<long> PinCode { get; set; }
        public string FlatNO { get; set; }
        public string BuildingName { get; set; }
        public string Street { get; set; }
        public string Village { get; set; }
        public string City { get; set; }
        public string states { get; set; }

        public string Name { get; set; }
        public long AccountNO { get; set; }
        public Nullable<long> CVV { get; set; }
        //public Nullable<int> Quantity { get; set; }
        //public Nullable<int> Total { get; set; }

    }
    public class ProfileModel
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }
        public string ContactNO { get; set; }
        public string Address { get; set; }
        public Nullable<int> PANNo { get; set; }
        public Nullable<int> BankIFCSCode { get; set; }
        public int BankAccountNo { get; set; }
    }
        public class RegistrationModel
        {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }
        public string ContactNO { get; set; }
        public string Address { get; set; }
        public Nullable<int> PANNo { get; set; }
        public Nullable<int> BankIFCSCode { get; set; }
        public int BankAccountNo { get; set; }
    }
    
}