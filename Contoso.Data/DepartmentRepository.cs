using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Contoso.Model;

namespace Contoso.Data
{
    public class DepartmentRepository : IRepository<Department>
    {
        public void CreateNew(Department obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Insert_Dept";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@DName", obj.Name);
            cmd.Parameters.AddWithValue("@DBudget", obj.Budget);
            cmd.Parameters.AddWithValue("@DStartDate", obj.StartDate);
            cmd.Parameters.AddWithValue("@DInstructorId", obj.InstructorId);
            cmd.Parameters.AddWithValue("@DRowversion", obj.RowVersion);
            cmd.Parameters.AddWithValue("@DCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@DCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@DUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@DUpdatedBy", obj.UpdatedBy);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public void DeleteById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Delete_Dept";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@DId", id);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public List<Department> GetAll()
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetAll_Dept";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataReader rdr = cmd.ExecuteReader();
            List<Department> lstDepartment = new List<Department>();
            while (rdr.Read())
            {
                Department d = new Department();
                d.Id = Convert.ToInt32(rdr["id"]);
                d.Name = rdr["Name"].ToString();
                d.Budget = rdr["Budget"].ToString();
                d.StartDate = Convert.ToDateTime(rdr["StartDate"]);
                d.InstructorId= Convert.ToInt32(rdr["InstructorId"]);
                d.RowVersion = rdr["RowVersion"].ToString();
                //d.CreatedDate = Convert.ToDateTime(rdr["CREATEDDATE"]);
                //d.CreatedBy = rdr["CREATEDBY"].ToString();
                //d.UpdatedDate = Convert.ToDateTime(rdr["UPDATEDATE"]);
                //d.UpdatedBy = rdr["UPDATEDBY"].ToString();
                lstDepartment.Add(d);
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();

            return lstDepartment;
        }

        public Department GetById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            Department d = new Department();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetById_Dept";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Deptid", id);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

            
            d.Id = Convert.ToInt32(rdr["id"]);
            d.Name = rdr["Name"].ToString();
            d.Budget = rdr["Budget"].ToString();
            d.StartDate = Convert.ToDateTime(rdr["StartDate"]);
            d.InstructorId = Convert.ToInt32(rdr["InstructorId"]);
            d.RowVersion = rdr["RowVersion"].ToString();
            //d.CreatedDate = Convert.ToDateTime(rdr["CREATEDDATE"]);
            //d.CreatedBy = rdr["CREATEDBY"].ToString();
            //d.UpdatedDate = Convert.ToDateTime(rdr["UPDATEDATE"]);
            //d.UpdatedBy = rdr["UPDATEDBY"].ToString();
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();

            return d;
        }

        public void Update(Department obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Update_Dept";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@Did", obj.Id);
            cmd.Parameters.AddWithValue("@DName", obj.Name);
            cmd.Parameters.AddWithValue("@DBudget", obj.Budget);
            cmd.Parameters.AddWithValue("@DStartDate", obj.StartDate);
            cmd.Parameters.AddWithValue("@DInstructorId", obj.InstructorId);
            cmd.Parameters.AddWithValue("@DRowversion", obj.RowVersion);
            cmd.Parameters.AddWithValue("@DCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@DCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@DUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@DUpdatedBy", obj.UpdatedBy);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }
    }
}
