using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace samplewebapi.Models
{
    public class EmpModel
    {
        internal object studentTables;

        /*

[Range(0,99)]
public int EmpModelId { get; set; }

[StringLength(10),Required]
public string EmpModelName { get; set; }

[StringLength(20), Required]
public  string EmpModelAddress { get; set; }

[StringLength(10), Required] 
public string EmpModelDepartment { get; set; }
[RegularExpression("^[0-99]*$")]
public string phoneno { get; set; }
[RegularExpression("^[a-zA-Z0-9_.+-]+@[email]+[a-zA-Z0-9-.]+$")]
public string email { get; set; }
[Range(0,99)]
public String age { get; set; }
// public int EmpModelId { get; internal set; }
*/

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int rollno { get; set; }
        public string branch { get; set; }
        public Nullable<int> marks { get; set; }

    }
}