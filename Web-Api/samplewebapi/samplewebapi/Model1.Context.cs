//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace samplewebapi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class sampleEntities3 : DbContext
    {
        public sampleEntities3()
            : base("name=sampleEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<studentTable> studentTables { get; set; }
    
        public virtual int sp_employee(string fname, string lname, Nullable<int> rollno, string branch, Nullable<int> marks, string type)
        {
            var fnameParameter = fname != null ?
                new ObjectParameter("Fname", fname) :
                new ObjectParameter("Fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("lname", lname) :
                new ObjectParameter("lname", typeof(string));
    
            var rollnoParameter = rollno.HasValue ?
                new ObjectParameter("rollno", rollno) :
                new ObjectParameter("rollno", typeof(int));
    
            var branchParameter = branch != null ?
                new ObjectParameter("branch", branch) :
                new ObjectParameter("branch", typeof(string));
    
            var marksParameter = marks.HasValue ?
                new ObjectParameter("marks", marks) :
                new ObjectParameter("marks", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_employee", fnameParameter, lnameParameter, rollnoParameter, branchParameter, marksParameter, typeParameter);
        }
    
        public virtual ObjectResult<studentTable> sp_employeeFunction(string fname, string lname, Nullable<int> rollno, string branch, Nullable<int> marks, string type)
        {
            var fnameParameter = fname != null ?
                new ObjectParameter("Fname", fname) :
                new ObjectParameter("Fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("lname", lname) :
                new ObjectParameter("lname", typeof(string));
    
            var rollnoParameter = rollno.HasValue ?
                new ObjectParameter("rollno", rollno) :
                new ObjectParameter("rollno", typeof(int));
    
            var branchParameter = branch != null ?
                new ObjectParameter("branch", branch) :
                new ObjectParameter("branch", typeof(string));
    
            var marksParameter = marks.HasValue ?
                new ObjectParameter("marks", marks) :
                new ObjectParameter("marks", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<studentTable>("sp_employeeFunction", fnameParameter, lnameParameter, rollnoParameter, branchParameter, marksParameter, typeParameter);
        }
    
        public virtual ObjectResult<studentTable> sp_employeeFunction(string fname, string lname, Nullable<int> rollno, string branch, Nullable<int> marks, string type, MergeOption mergeOption)
        {
            var fnameParameter = fname != null ?
                new ObjectParameter("Fname", fname) :
                new ObjectParameter("Fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("lname", lname) :
                new ObjectParameter("lname", typeof(string));
    
            var rollnoParameter = rollno.HasValue ?
                new ObjectParameter("rollno", rollno) :
                new ObjectParameter("rollno", typeof(int));
    
            var branchParameter = branch != null ?
                new ObjectParameter("branch", branch) :
                new ObjectParameter("branch", typeof(string));
    
            var marksParameter = marks.HasValue ?
                new ObjectParameter("marks", marks) :
                new ObjectParameter("marks", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<studentTable>("sp_employeeFunction", mergeOption, fnameParameter, lnameParameter, rollnoParameter, branchParameter, marksParameter, typeParameter);
        }
    }
}
