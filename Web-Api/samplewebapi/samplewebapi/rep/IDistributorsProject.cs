using samplewebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplewebapi.rep
{
    public interface IDistributorsProject
    {
        List<DistributorsProjectModel> GetallDetails();

        string DeleteDetails(int price);

        string insertdetails(DistributorsProjectModel i);

        List<DistributorsProjectModel> GetaddressDetails();

        string DeleteaddressDetails(int MobileNumber);

        string insertpaymentdetails(DistributorsProjectModel i);

        //IEnumerable<DistributorsProjectModel> Getjoins();
        string insertemp(RegistrationModel pro);

    }

    class projectdetails : IDistributorsProject
    {
        webSalesEntities sx = new webSalesEntities();
        List<DistributorsProjectModel> res = new List<DistributorsProjectModel> { };

        List<DistributorsProjectModel> IDistributorsProject.GetallDetails()
        {
            List<DistributorsProjectModel> res;
            res = sx.Products.Select(sx => new DistributorsProjectModel()
            {

                productName = sx.productName,
                ProductId = sx.ProductId,
                Description = sx.Description,
                image = sx.image,
                price = sx.price,
               // Quantity=sx.Quantity,
               // Total=sx.Total,

            
               
            }).ToList<DistributorsProjectModel>();
            
            return res;
        }

        string IDistributorsProject.DeleteDetails(int price)
        {
            var ret = sx.Products.Where(s => s.price == price).FirstOrDefault();
            if (ret != null)
            {
                sx.Products.Remove(ret);
            }
            sx.SaveChanges();
            return "deleted";
        }
        string IDistributorsProject.insertdetails(DistributorsProjectModel i)
        {
            var res = sx.addresses.Where(s => s.MobileNumber == i.MobileNumber).FirstOrDefault();
            if (res == null)
            {
                sx.addresses.Add(new address
                {
                   FullName = i.FullName,
                   MobileNumber = i.MobileNumber,
                    PinCode = i.PinCode,
                    FlatNO = i.FlatNO,
                    BuildingName=i.BuildingName,
                    Street=i.Street,
                    Village=i.Village,
                    City=i.City,
                    states=i.states,
                });
                sx.SaveChanges();
                sx.Dispose();
            }
            else
            {
                res.FullName = i.FullName;
                res.MobileNumber = i.MobileNumber;
                res.PinCode = i.PinCode;
                res.FlatNO = i.FlatNO;
                res.BuildingName = i.BuildingName;
                res.Street = i.Street;
                res.Village = i.Village;
                res.City = i.City;
                res.states = i.states;

            }

            sx.SaveChanges();
            sx.Dispose();
            return "inserted";
        
        }

        List<DistributorsProjectModel> IDistributorsProject.GetaddressDetails()
        {
            List<DistributorsProjectModel> res;
            res = sx.addresses.Select(sx => new DistributorsProjectModel()
            {

                FullName = sx.FullName,
                MobileNumber = sx.MobileNumber,
                PinCode = sx.PinCode,
                FlatNO = sx.FlatNO,
                BuildingName = sx.BuildingName,
                Street = sx.Street,
                Village = sx.Village,
                City = sx.City,
                states = sx.states,

            }).ToList<DistributorsProjectModel>();

            return res;
        }

        string IDistributorsProject.DeleteaddressDetails(int MobileNumber)
        {
            var ret = sx.addresses.Where(s => s.MobileNumber == MobileNumber).FirstOrDefault();
            if (ret != null)
            {
                sx.addresses.Remove(ret);
            }
            sx.SaveChanges();
            return "deleted";
        }

        string IDistributorsProject.insertpaymentdetails(DistributorsProjectModel i)
        {
            var res = sx.Payments.Where(s => s.AccountNO == i.AccountNO).FirstOrDefault();
            if (res == null)
            {
                sx.Payments.Add(new Payment
                {
                    Name = i.Name,
                    AccountNO = i.AccountNO,
                    CVV = i.CVV,
                });
                sx.SaveChanges();
                sx.Dispose();
            }
            return "inserted";
        }
        string IDistributorsProject.insertemp(RegistrationModel pro)
        {

            var ssx = sx.Registrations.Where(f => pro.BankAccountNo == f.BankAccountNo).FirstOrDefault();
            if (ssx == null)
            {
                sx.Registrations.Add(new Registration
                {
                    Name=pro.Name,
                    Username=pro.Username,
                    Password=pro.Password,
                    ConfirmPassword =pro.ConfirmPassword,
                    Dob=pro.Dob,
                    ContactNO=pro.ContactNO, 
                    Address=pro.Address, 
                    PANNo=pro.PANNo, 
                    BankIFCSCode=pro.BankIFCSCode,
                    BankAccountNo=pro.BankAccountNo, 
                    
    });
                sx.SaveChanges();
                //   updateemp(pro);
                var rsx = sx.Profiles.Where(s => s.Username == pro.Username).FirstOrDefault();
                if (rsx != null)
                {
                    rsx.Name = rsx.Name;
                    rsx.Username = rsx.Username;
                    rsx.Dob = rsx.Dob;
                    rsx.ContactNO = rsx.ContactNO;
                    rsx.Address = rsx.Address;
                    rsx.PANNo = rsx.PANNo;
                    rsx.BankIFCSCode = rsx.BankIFCSCode;
                    rsx.BankAccountNo = rsx.BankAccountNo; 
                    

                }
                sx.SaveChanges();
            }
            sx.Dispose();
            return "inserted";
        }


    }
}


//public IEnumerable<DistributorsProjectModel> Getjoins()
//{
//    var prolist = (from s in sx.Products
//                   join d in sx.Carts on s.ProductId equals d.prodId
//                   select new DistributorsProjectModel
//                   {
//                       productName = s.productName,
//                       ProductId = s.ProductId,
//                       image = s.image,
//                       price = s.price,
//                       Description = s.Description,

//                       prodId = d.prodId,
//                       prodName = d.prodName,
//                       prodimage = d.prodimage,
//                       prodDescription = d.prodDescription,
//                       prodprice = d.prodprice,
//                       quantity = d.quantity,
//                       total = d.total

//                   }).ToList();

//    sx.SaveChanges();
//    return prolist;
//}
