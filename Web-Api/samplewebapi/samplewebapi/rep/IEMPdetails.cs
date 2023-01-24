using samplewebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Activation;

namespace samplewebapi.rep
{
    public interface IEMPdetails
    {
        List<EmpModel> GetAllEmpDetails();

       EmpModel GetEmpDetail(int rollno);
        //List<EmpModel> GetAllEmpDetails(int id);
        string updateEmpDetail(EmpModel empm);
        string updateEmpDetail();

        string insertEmpDetails(EmpModel empi);
        string deleteEmpdetails(int rollno);
        string bulkinsert(List<EmpModel> empd);
        //string bulkinsert2(EmpModel empd);
        string bulkdel();
    }
    class EmpDetailes : IEMPdetails
    {
        sampleEntities3 sx = new sampleEntities3();
        public List<EmpModel> emplist = new List<EmpModel> { };

     
        List<EmpModel> IEMPdetails.GetAllEmpDetails()
        {

            List<EmpModel> emplist = null;
            emplist = sx.studentTables.Select(s => new EmpModel()
            {
                firstName = s.firstName,
                lastName = s.lastName,
                rollno = s.rollno,
                branch = s.branch,
                marks = s.marks,
            }).ToList<EmpModel>();

            return emplist;
        }
        EmpModel IEMPdetails.GetEmpDetail(int rollno)
        {
            var emplist = sx.studentTables.Where(g=>g.rollno== rollno).Select(s => new EmpModel()
            {
                firstName = s.firstName,
                lastName = s.lastName,
                rollno = s.rollno,
                branch = s.branch,
                marks = s.marks,
            }).ToList<EmpModel>();
            var sa = emplist.Where(g => g.rollno == rollno).FirstOrDefault();
            //sx.SaveChanges();
            return sa;
        }

        // update for all columns
        string IEMPdetails.updateEmpDetail(EmpModel empm)
        {
            var existingStudent = sx.studentTables.Where(s => s.rollno == empm.rollno).FirstOrDefault();
            if (existingStudent != null)
            {
                existingStudent.firstName = empm.firstName;
                existingStudent.lastName = empm.lastName;
                existingStudent.rollno = empm.rollno;
                existingStudent.branch = empm.branch;
                existingStudent.marks = empm.marks;

            }
            sx.SaveChanges();
            return "updated";
           // return "";
        }

       /* string IEMPdetails.updateEmpDetail()
        {
          foreach(var r in sx.studentTables)
            {
               
                r.marks = r.marks+r.marks*10/100;

             
            }
            sx.SaveChanges();
            return "updated";
          //  return "";
        }
       */



        string IEMPdetails.insertEmpDetails(EmpModel empi)
        {
            var ssx = sx.studentTables.Where(s =>empi.rollno ==s .rollno).FirstOrDefault();
            if (ssx == null)
            {
                sx.studentTables.Add(new studentTable
                {
                    firstName = empi.firstName,
                    lastName = empi.lastName,
                    rollno = empi.rollno,
                    branch = empi.branch,
                    marks = empi.marks

                }); 
            }
            sx.SaveChanges();
            return "inserted";
        }

        string IEMPdetails.bulkinsert(List<EmpModel> empb)
        {

            {
                foreach (EmpModel ssx in empb)
                    sx.studentTables.Add(new studentTable
                    {
                        firstName = ssx.firstName,
                        lastName = ssx.lastName,
                        rollno = ssx.rollno,
                        branch = ssx.branch,
                        marks = ssx.marks

                    });

                sx.SaveChanges();
                return "bulkinserted";
            };
        }



       

        string IEMPdetails.bulkdel()
        {

            {
                foreach (var e in sx.studentTables)
                {
                    sx.studentTables.Remove(e);
                   
                }
                sx.SaveChanges();
                return "bulkdeleted";
            }
        }
       

        public EmpModel GetEmpDetail(int id)
        {
            throw new NotImplementedException();
        }
        // return "";

        public string deleteEmpdetails(int rollno)
        {

            var ssx = sx.studentTables.Where(s => s.rollno == rollno).FirstOrDefault();
            if (ssx!= null)
            {
                sx.studentTables.Remove(ssx);

            }
            sx.SaveChanges();
            return "deleted";
                
        }

        public string updateEmpDetail()
        {
            throw new NotImplementedException();
        }

  
    }
}
       
    

























/*using samplewebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Activation;

namespace samplewebapi.rep
{
    public interface IEMPdetails
    {
     
        
        List<EmpModel> GetAllEmpDetails();

        EmpModel GetEmpDetail(int id);
        //List<EmpModel> GetAllEmpDetails(int id);
       
        
    }
    class EmpDetailes : IEMPdetails
    {
        public List<EmpModel> emplist = new List<EmpModel>()
        {
            new EmpModel()
            {
            EmpModelId=1,EmpModelName="sneha",EmpModelAddress="hyt",EmpModelDepartment="cse",phoneno="9398473762",email="sneha@gmail.com",age="22"
            },
             new EmpModel()
             {
            EmpModelId=2,EmpModelName="deepu",EmpModelAddress="hyd",EmpModelDepartment="ece",phoneno="7857923451",email="deepthi12@gmail.com",age="22"
            },
              new EmpModel()
              {
            EmpModelId=3,EmpModelName="keerthi",EmpModelAddress="nagole",EmpModelDepartment="eee",phoneno="9732977642",email="keerthi@gmail.com",age="22"
            },
        };

       

        List<EmpModel> IEMPdetails.GetAllEmpDetails()
        {
            return emplist;
        }



        EmpModel IEMPdetails.GetEmpDetail(int EmpModelId)
        {
            var EmpModel = emplist.FirstOrDefault(e => e.EmpModelId == EmpModelId);
            if (EmpModel == null)
            {
                throw new Exception("not found");
            }
            return EmpModel;
        }

    }
}*/

