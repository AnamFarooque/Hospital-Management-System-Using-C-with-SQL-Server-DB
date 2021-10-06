using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.SupportingClasses
{
    class UserSession
    {
        public static string UserID { get; set; }

        public static int EmpID { get; set; }

        public static string LastName { get; set; }

        public static string FirstName { get; set; }

        public static string UserName { get; set; }

        public static string Email { get; set; }

        public static string UserTitle { get; set; }

        public static int designationID { get; set; }

        public static int departmentID { get; set; }

        public static DateTime TimeIn { get; set; }

      public UserSession(DataTable dt)
       {          
          // DataTable dt = ds.Tables[0];
           UserSession.UserName = dt.Rows[0]["userName"].ToString();
           UserSession.UserID = dt.Rows[0]["userID"].ToString();
           UserSession.EmpID = Convert.ToInt32(dt.Rows[0]["EmpID"]);
           UserSession.Email = dt.Rows[0]["Email"].ToString();
           UserSession.TimeIn = DateTime.Now;
           UserSession.UserTitle = dt.Rows[0]["userName"].ToString();
           UserSession.designationID = Convert.ToInt32(dt.Rows[0]["designationID"]);
           UserSession.departmentID = Convert.ToInt32(dt.Rows[0]["departmentID"]);
       }
    }
}
