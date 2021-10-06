using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.SupportingClasses;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Reflection;

namespace HospitalManagement.SupportingClasses
{
    class Handler
    {
        public static DataTable GetUserInfo(string _userID,string _pass)
        {
            DataTable dt = new DataTable();
            String procName = "GetUserInfo";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@userID", _userID);
            sqlParam.AddWithValue("@pass", _pass);
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, sqlParam, DataFactory.DbConnection);
            return dt;

        }
        public static DataTable GetPatientsList(string _userID)
        {
            DataTable dt = new DataTable();
            String procName = "PatientInfo_SelectAll";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@userID", _userID);
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, sqlParam, DataFactory.DbConnection);
            return dt;

        }

        //GetPaymentType
        public static DataTable GetPaymentType()
        {
            DataTable dt = new DataTable();
            String procName = "GetPaymentType";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, DataFactory.DbConnection);
            return dt;
        }

        public static DataTable PatientPayment_SelectAll()
        {
            DataTable dt = new DataTable();
            String procName = "PatientPayment_SelectAll";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, DataFactory.DbConnection);
            return dt;
        }

        public static int PatientPayment_Insert(int _PatientID,int _PaymentTypeID,string _Comment,int _Amount,string _PaymentStatus)
        {
            int result = 0;
            DataTable dt = new DataTable();
            String procName = "PatientPayment_Insert";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", _PatientID);
            sqlParam.AddWithValue("@PaymentTypeID", _PaymentTypeID);
            sqlParam.AddWithValue("@Comment", _Comment);
            sqlParam.AddWithValue("@Amount", _Amount);
            sqlParam.AddWithValue("@PaymentStatus", _PaymentStatus);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;

        }
        public static int EmployeeInfo_Insert(string LastName,string FirstName,string userName,string userID,string Emp_password,string Email,
          DateTime CreatedDate,string designationID,string departmentID)
        {
            int result = 0;
            String procName = "Employee_Insert";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            //sqlParam.AddWithValue("@EmpID", EmpID);
            sqlParam.AddWithValue("@LastName", LastName);
            sqlParam.AddWithValue("@FirstName", FirstName);
            sqlParam.AddWithValue("@userName", userName);
            sqlParam.AddWithValue("@userID", userID);
            sqlParam.AddWithValue("@Emp_password", Emp_password);
            sqlParam.AddWithValue("@Email", Email);
            sqlParam.AddWithValue("@CreatedDate", CreatedDate);
            sqlParam.AddWithValue("@designationID", designationID);
            sqlParam.AddWithValue("@departmentID", departmentID);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;
        }

        public static int PatientPayment_Update(int _PatientID, int _PaymentTypeID, string _Comment, int _Amount, string _PaymentStatus)
        {
            int result = 0;
            DataTable dt = new DataTable();
            String procName = "PatientPayment_Update";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", _PatientID);
            sqlParam.AddWithValue("@PaymentTypeID", _PaymentTypeID);           
            sqlParam.AddWithValue("@PaymentStatus", _PaymentStatus);
            sqlParam.AddWithValue("@Comment", _Comment);
            sqlParam.AddWithValue("@Amount", _Amount);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;
        }

        public static DataTable GetDoctorsList(string _userID)
        {
            DataTable dt = new DataTable();
            String procName = "DoctorInfo_SelectAll";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@userID", _userID);
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, sqlParam, DataFactory.DbConnection);
            return dt;

        }



        public static int PateintInfo_Insert(int _Patientid, string _LastName, string _MiddleName,string _FirstName,string _FullName,
            string _Email,int _PhoneNo,DateTime _CreatedDate,int _Age,string _BloodGroup,string _StreetAddress,string _City, string _State,string _Country,string _ImagePath)
        {
            int result = 0;
            String procName = "PateintInfo_Insert";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();             
            sqlParam.AddWithValue("@PatientID", _Patientid);
            sqlParam.AddWithValue("@LastName", _LastName);
            sqlParam.AddWithValue("@MiddleName", _MiddleName);
            sqlParam.AddWithValue("@FirstName", _FirstName);
            sqlParam.AddWithValue("@FullName", _FullName);
            sqlParam.AddWithValue("@Email", _Email);
            sqlParam.AddWithValue("@PhoneNo", _PhoneNo);
            sqlParam.AddWithValue("@CreatedDate", _CreatedDate);
            sqlParam.AddWithValue("@Age", _Age);
            sqlParam.AddWithValue("@BloodGroup", _BloodGroup);
            sqlParam.AddWithValue("@StreetAddress", _StreetAddress);
            sqlParam.AddWithValue("@City", _City);
            sqlParam.AddWithValue("@State_Province", _State);
            sqlParam.AddWithValue("@Country", _Country);
            sqlParam.AddWithValue("@ImagePath", _ImagePath);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;


        }

        public static int PatientAppointment(int _Patientid, int _EmpID, DateTime _AppointmentDate, string _Comment, int _StatusID)
        {
            int result = 0;
            String procName = "PatientAppointment";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", _Patientid);
            sqlParam.AddWithValue("@EmpID", _EmpID);  
            sqlParam.AddWithValue("@AppointmentDate", _AppointmentDate);
            sqlParam.AddWithValue("@Comment", _Comment);
            sqlParam.AddWithValue("@StatusID", _StatusID);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;
        }

        public static DataTable PatientQueue_SelectAll()
        {

            DataTable dt = new DataTable();
            String procName = "PatientQueue_SelectAll";
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, DataFactory.DbConnection);
            return dt;

        }

        public static DataTable LabQueue_SelectAll()
        {

            DataTable dt = new DataTable();
            String procName = "PatientLabQueue_SelectAll";
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, DataFactory.DbConnection);
            return dt;

        }

        public static DataTable GetPatientStatus() {
            DataTable dt = new DataTable();
            String procName = "GetPatientStatus";
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, DataFactory.DbConnection);
            return dt;
        }

        public static DataSet GetPatientsRecord(int PatientID)
        {
            DataSet ds = new DataSet();
            String procName = "PatientRecord_byPatientID";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", PatientID);
           // ds = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, sqlParam, DataFactory.DbConnection);
            ds = DataFactory.ExecuteDataset(CommandType.StoredProcedure, procName, sqlParam, DataFactory.DbConnection);
            return ds;
        }

        public static DataTable GetPateintbyPatientName(string PatientName)
        {
            DataTable dt = new DataTable();
            String procName = "SelectPatient_ByPatientName";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientName", PatientName);
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, sqlParam, DataFactory.DbConnection);
            return dt;
        }

        public static DataTable GetPateintbyPatientID(int PatientID)
        {
            DataTable dt = new DataTable();
            String procName = "SelectPatient_ByPatientID";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", PatientID);
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, sqlParam, DataFactory.DbConnection);
            return dt;
        }

        public static DataTable GetLabTestList()
        {
            DataTable dt = new DataTable();
            String procName = "GetLabTestList";
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, DataFactory.DbConnection);
            return dt;
        }
        public static DataTable Department_Select()
        {
            DataTable dt = new DataTable();
            String procName = "Department_Select";
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, DataFactory.DbConnection);
            return dt;
        }
        public static DataTable Designations_Select()
        {
            DataTable dt = new DataTable();
            String procName = "Designations_Select";
            dt = DataFactory.ExecuteDataTable(CommandType.StoredProcedure, procName, DataFactory.DbConnection);
            return dt;
        }

        public static int PatientLabTest_Assign(int _Patientid, int _EmpID, int _TestID, string _Comment, int _StatusID)
        {
            int result = 0;
            String procName = "PatientLabTest_Assign";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", _Patientid);
            sqlParam.AddWithValue("@EmpID", _EmpID);
            sqlParam.AddWithValue("@TestID", _TestID);
            sqlParam.AddWithValue("@Comment", _Comment);
            sqlParam.AddWithValue("@StatusID", _StatusID);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;
        }

        public static int PatientProcedureAssign(int _Patientid, int _EmpID, string _ProcedureName,DateTime _AppointmentDate, string _Comment, int _StatusID)
        {
            int result = 0;
            String procName = "PatientProcedure_Assign";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", _Patientid);
            sqlParam.AddWithValue("@EmpID", _EmpID);
            sqlParam.AddWithValue("@ProcedureName", _ProcedureName);
            sqlParam.AddWithValue("@AppointmentDate", _AppointmentDate);
            sqlParam.AddWithValue("@Comment", _Comment);
            sqlParam.AddWithValue("@StatusID", _StatusID);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;
        }

        public static int PatientSurgicalHistory_Update(int _Patientid, int _EmpID, string _ProcedureName, string _StatusName)
        {
            int result = 0;
            String procName = "PatientSurgicalHistory_Update";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", _Patientid);
            sqlParam.AddWithValue("@EmpID", _EmpID);
            sqlParam.AddWithValue("@ProcedureName", _ProcedureName);
            sqlParam.AddWithValue("@StatusName", _StatusName);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;
        }

    public static int PatientLabTestStatus_Update(int _Patientid, int _EmpID, int _TestID, string _StatusName)
        {
            int result = 0;
            String procName = "PatientLabTestStatus_Update";
            SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
            sqlParam.AddWithValue("@PatientID", _Patientid);
            sqlParam.AddWithValue("@EmpID", _EmpID);
            sqlParam.AddWithValue("@TestID", _TestID);
            sqlParam.AddWithValue("@StatusName", _StatusName);
            object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
            if (obj != null)
            {
                result = Convert.ToInt32(obj);
            }
            return result;
        }

    public static int PatientAppointmentStatus_Update(int _Patientid, int _AppointmentID, string _StatusName)
    {
        int result = 0;
        String procName = "PatientAppointmentStatus_Update";
        SqlParameterCollection sqlParam = DataFactory.GetParameterCollectionConstructor();
        sqlParam.AddWithValue("@PatientID", _Patientid);
        sqlParam.AddWithValue("@AppointmentID", _AppointmentID);
        sqlParam.AddWithValue("@StatusName", _StatusName);
        object obj = DataFactory.ExecuteNonQueryCmd(DataFactory.DbConnection, procName, CommandType.StoredProcedure, sqlParam);
        if (obj != null)
        {
            result = Convert.ToInt32(obj);
        }
        return result;
    }
    }
}
