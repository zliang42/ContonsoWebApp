using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Contoso.Model;

namespace Contoso.Data
{
    public class PeopleRepository : IRepository<People>

    {
        public void CreateNew(People obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();
            SqlCommand cmd = new SqlCommand();

                
                cmd.CommandText = "SP_Insert_People";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@PLastName", obj.LastName);
                cmd.Parameters.AddWithValue("@PFirstName", obj.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", obj.MiddleName);
                cmd.Parameters.AddWithValue("@PAge", obj.Age);
                cmd.Parameters.AddWithValue("@PEmail", obj.Email);
                cmd.Parameters.AddWithValue("@PPhone", obj.Phone);
                cmd.Parameters.AddWithValue("@AddressLine1", obj.AddressLine1);
                cmd.Parameters.AddWithValue("@AddressLine2", obj.AddressLine2);
                cmd.Parameters.AddWithValue("@PUnitOrApartmentNumber", obj.UnitOrApartmentNumber);
                cmd.Parameters.AddWithValue("@PCity", obj.City);
                cmd.Parameters.AddWithValue("@PState", obj.State);
                cmd.Parameters.AddWithValue("@PZipcode", obj.ZipCode);
                cmd.Parameters.AddWithValue("@PCreatedDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@PCreatedBy", obj.CreatedBy);
                cmd.Parameters.AddWithValue("@PUpdatedDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@PUpdatedBy", obj.UpdatedBy);
                cmd.Parameters.AddWithValue("@PSalt", obj.Salt);
                cmd.Parameters.AddWithValue("@PIsLocked", obj.IsLocked);
                cmd.Parameters.AddWithValue("@PLastLockedDateTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@PFailedAttempts", obj.FailedAttempts);

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
            cmd.CommandText = "SP_Delete_People";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@PId", id);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public List<People> GetAll()
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetAll_People";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataReader rdr = cmd.ExecuteReader();
            List<People> lstPeople = new List<People>();
            while (rdr.Read())
            {
                People pl = new People();
                pl.Id = Convert.ToInt32(rdr["id"]);
                pl.LastName = rdr["LASTNAME"].ToString();
                pl.FirstName = rdr["FIRSTNAME"].ToString();
                pl.MiddleName = rdr["MIDDLENAME"].ToString();
                pl.Age = Convert.ToInt32(rdr["AGE"]);
                pl.Email = rdr["EMAIL"].ToString();
                pl.Phone = Convert.ToInt32(rdr["PHONE"]);
                pl.AddressLine1 = rdr["ADDRESSLINE1"].ToString();
                pl.AddressLine2 = rdr["ADDRESSLINE2"].ToString();
                pl.UnitOrApartmentNumber = Convert.ToInt32(rdr["UNITORAPARTMENTNUMBER"]);
                pl.City = rdr["CITY"].ToString();
                pl.State = rdr["state"].ToString();
                pl.ZipCode = Convert.ToInt32(rdr["ZIPCODE"]);
                //pl.CreatedDate = Convert.ToDateTime(rdr["CREATEDDATE"]);
                //pl.CreatedBy = rdr["CREATEDBY"].ToString();
                //pl.UpdatedDate = Convert.ToDateTime(rdr["UpdatedDate"]);
                //pl.UpdatedBy = rdr["UPDATEDBY"].ToString();
                //pl.Salt = rdr["SALT"].ToString();
                //pl.IsLocked = Convert.ToBoolean(rdr["ISLOCKED"]);
                //pl.LastLockedDateTime = Convert.ToDateTime(rdr["LASTLOCKEDDATETIME"]);
                //pl.FailedAttempts = Convert.ToInt32(rdr["FAILEDATTEMPTS"]);
                lstPeople.Add(pl);
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();

            return lstPeople;

        }

        public People GetById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            People pl = new People();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_GetById_People";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Pid", id);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                pl.Id = Convert.ToInt32(rdr["id"]);
                pl.LastName = rdr["LASTNAME"].ToString();
                pl.FirstName = rdr["FIRSTNAME"].ToString();
                //pl.MiddleName = rdr["MIDDLENAME"].ToString();
                pl.Age = Convert.ToInt32(rdr["AGE"]);
                pl.Email = rdr["EMAIL"].ToString();
                pl.Phone = Convert.ToInt32(rdr["PHONE"]);
                pl.AddressLine1 = rdr["ADDRESSLINE1"].ToString();
                //pl.AddressLine2 = rdr["ADDRESSLINE2"].ToString();
                //pl.UnitOrApartmentNumber = Convert.ToInt32(rdr["UNITORAPARTMENTNUMBER"]);
                pl.City = rdr["CITY"].ToString();
                pl.State = rdr["state"].ToString();
                pl.ZipCode = Convert.ToInt32(rdr["ZIPCODE"]);
                //pl.CreatedDate = Convert.ToDateTime(rdr["CREATEDDATE"]);
                //pl.CreatedBy = rdr["CREATEDBY"].ToString();
                //pl.UpdatedDate = Convert.ToDateTime(rdr["UPDATEDATE"]);
                //pl.UpdatedBy = rdr["UPDATEDBY"].ToString();
                //pl.Salt = rdr["SALT"].ToString();
                //pl.IsLocked = Convert.ToBoolean(rdr["ISLOCKED"]);
                //pl.LastLockedDateTime = Convert.ToDateTime(rdr["LASTLOCKEDDATETIME"]);
                //pl.FailedAttempts = Convert.ToInt32(rdr["FAILEDATTEMPTS"]);
            }


            con.Close();

            cmd.Dispose();
            con.Dispose();

            return pl;
        }

        public void Update(People obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_Update_People";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@PId", obj.Id);
            cmd.Parameters.AddWithValue("@PLastName", obj.LastName);
            cmd.Parameters.AddWithValue("@PFirstName", obj.FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", obj.MiddleName);
            cmd.Parameters.AddWithValue("@PAge", obj.Age);
            cmd.Parameters.AddWithValue("@PEmail", obj.Email);
            cmd.Parameters.AddWithValue("@PPhone", obj.Phone);
            cmd.Parameters.AddWithValue("@AddressLine1", obj.AddressLine1);
            cmd.Parameters.AddWithValue("@AddressLine2", obj.AddressLine2);
            cmd.Parameters.AddWithValue("@PUnitOrApartmentNumber", obj.UnitOrApartmentNumber);
            cmd.Parameters.AddWithValue("@PCity", obj.City);
            cmd.Parameters.AddWithValue("@PState", obj.State);
            cmd.Parameters.AddWithValue("@PZipcode", obj.ZipCode);
            cmd.Parameters.AddWithValue("@PCreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@PCreatedBy", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@PUpdatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@PUpdatedBy", obj.UpdatedBy);
            cmd.Parameters.AddWithValue("@PSalt", obj.Salt);
            cmd.Parameters.AddWithValue("@PIsLocked", obj.IsLocked);
            cmd.Parameters.AddWithValue("@PLastLockedDateTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@PFailedAttempts", obj.FailedAttempts);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }


    }
}
