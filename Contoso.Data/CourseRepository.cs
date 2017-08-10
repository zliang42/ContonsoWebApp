using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Contoso.Model;

namespace Contoso.Data
{
    public class CourseRepository : IRepository<Courses>
    {
        public void CreateNew(Courses obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Insert_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@CTitle", obj.Title);
            cmd.Parameters.AddWithValue("@CCredits", obj.Credits);
            cmd.Parameters.AddWithValue("@CDepartmentID", obj.DepartmentId);
            cmd.Parameters.AddWithValue("@CCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@CCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@CUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@CUpdatedBy", obj.UpdatedBy);

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
            cmd.CommandText = "SP_Delete_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@CId", id);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public List<Courses> GetAll()
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetAll_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataReader rdr = cmd.ExecuteReader();
            List<Courses> lstCourses = new List<Courses>();
            while (rdr.Read())
            {
                Courses c = new Courses();
                c.Id = Convert.ToInt32(rdr["id"]);
                c.Title = rdr["Title"].ToString();
                c.Credits = Convert.ToInt32(rdr["Credits"]);
                c.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                //c.CreatedDate = Convert.ToDateTime(rdr["CREATEDDATE"]);
                //c.CreatedBy = rdr["CREATEDBY"].ToString();
                //c.UpdatedDate = Convert.ToDateTime(rdr["UPDATEDATE"]);
                //c.UpdatedBy = rdr["UPDATEDBY"].ToString();
                lstCourses.Add(c);
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();

            return lstCourses;
        }

        public Courses GetById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            Courses c = new Courses();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetById_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Cid", id);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                c.Id = Convert.ToInt32(rdr["id"]);
                c.Title = rdr["Title"].ToString();
                c.Credits = Convert.ToInt32(rdr["Credits"]);
                c.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                //c.CreatedDate = Convert.ToDateTime(rdr["CREATEDDATE"]);
                //c.CreatedBy = rdr["CREATEDBY"].ToString();
                //c.UpdatedDate = Convert.ToDateTime(rdr["UPDATEDATE"]);
                //c.UpdatedBy = rdr["UPDATEDBY"].ToString();
            }

            con.Close();

            cmd.Dispose();
            con.Dispose();

            return c;
        }

        public void Update(Courses obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Update_Courses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@CId", obj.Id);
            cmd.Parameters.AddWithValue("@CTitle", obj.Title);
            cmd.Parameters.AddWithValue("@CCredits", obj.Credits);
            cmd.Parameters.AddWithValue("@CDepartmentID", obj.DepartmentId);
            cmd.Parameters.AddWithValue("@CCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@CCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@CUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@CUpdatedBy", obj.UpdatedBy);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }
    }
}
