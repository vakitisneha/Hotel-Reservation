using samplewebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplewebapi.rep
{
    public interface iProject
    {
        string insertemp(projectModel pro);
        //string joins(projectModel pro);
        IEnumerable<projectModel> Getjoins();
       // IEnumerable<projectModel> Getgroupby(projectModel pro);
    }
    class Empdetails : iProject
    {
        sampleEntities7 sx = new sampleEntities7();

        public IEnumerable<object> Pprojects { get; private set; }


        //   List<iProject> GetGroupby();



        string iProject.insertemp(projectModel pro)
        {

            var ssx = sx.EmployeeProjects.Where(f => pro.id == f.id).FirstOrDefault();
            if (ssx == null)
            {
                sx.EmployeeProjects.Add(new EmployeeProject
                {
                    id = pro.id,
                    name = pro.name,
                    Teamleader = pro.Teamleader,
                    DateOfJoining = pro.DateOfJoining,
                });
                sx.SaveChanges();
                //   updateemp(pro);
                var rsx = sx.Pprojects.Where(s => s.TeamLeader == pro.Teamleader).FirstOrDefault();
                if (rsx != null)
                {
                    rsx.Teamsize = rsx.Teamsize + 1;

                }
                sx.SaveChanges();
            }
            sx.Dispose();
            return "inserted";
        }


        public IEnumerable<projectModel> Getjoins()
        {
            var prolist = (from s in sx.EmployeeProjects
                           join d in sx.Pprojects on s.Teamleader equals d.TeamLeader
                           select new projectModel
                           {
                               id = s.id,
                               name = s.name,
                               Teamleader = s.Teamleader,
                               DateOfJoining = s.DateOfJoining,
                               startDate = d.startDate,

                               projectName = d.projectName,
                               Teamsize = (int)d.Teamsize,

                           }).ToList();

            sx.SaveChanges();
            return prolist;
        }
        /*   public IEnumerable<projectModel> Getgroupby(projectModel pro)
           {
               // var groupby= sx.EmployeeProjects.Where(f => pro.id == f.id).FirstOrDefault();
               List<projectModel> pr = null;
               pr = sx.EmployeeProjects.Select(s => new projectModel()
               {
                   id = s.id,
                   name = s.name,
                   Teamleader = s.Teamleader,
                   DateOfJoining = s.DateOfJoining
               })
             }
           return "";*/
    }
}


   /* List<EmpModel> IEMPdetails.GetAllEmpDetails()
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
    }*/
    /*var =
    from student in students
    group student by student.LastName into newGroup
    orderby newGroup.Key
    select newGroup;

foreach (var nameGroup in )
{
    Console.WriteLine($"Key: {nameGroup.Key}");
    foreach (var student in nameGroup)
    {
        Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
    }
}






       /* private void GetEmployee(projectModel pro)

        {
         //   EmployeeOperationDataContext employee = new EmployeeOperationDataContext();
            var salarySum = from emp in EmployeeProject.pro

                            group emp by emp.TeamLeader into empg

                            select new  EmployeeProject
                            {
                                id=empg.id,
                                name=empg.name,
                                Teamleader=empg.TeamLeader,
                                DateOfJoining=empg.DateOfJoining,       
                            };

           // grdEmployee.DataSource = salarySum;

           // grdEmployee.DataBind();
           // }*/



/*
 *  [HttpGet]
    [Queryable(PageSize=150)]
    public IQueryable<BoyName> GetBoyNames(string letter)
    {
        List<BoyName> names = Db.BoyNames.Where(c => c.Name.StartsWith(letter)).OrderBy(x => x.Name).ToList();
        return names.AsQueryable();
    }
  
  
 * var names = Db.BoyNames
              .Where(c => c.Name.StartsWith(letter))
              .OrderBy(x => x.Name);
return names;*/
