using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CrudeMVCWithApi.Models;
using CrudeMVCWithApi.Controllers;

namespace CrudeMVCWithApi.Models
{
    public class DataLayer
    {
        public List<Emp> GetEmp(int id)
        {
            List<Emp> li = new List<Emp>();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("Str").ToString());
            SqlCommand cmd = new SqlCommand();
            try
            {

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@EmpID", id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEmp";
                cmd.Connection = con;
                con.Open();
                SqlDataReader readerob = cmd.ExecuteReader();
                while (readerob.Read())
                {
                    li.Add(new Emp
                    {
                        EmpID = Convert.ToInt32(readerob["EmpID"]),
                        EmpName = readerob["Empname"].ToString(),
                        EmpSal = Convert.ToInt32(readerob["EmpSal"]),
                        Gender = readerob["Gender"].ToString(),
                    }
                        );
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }


            return li;
        }

        public List<Emp> GetAllEmployees(Emp emp)
        {
            List<Emp> li = new List<Emp>();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("Str").ToString());
            SqlCommand cmd = new SqlCommand();
            try
            {

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllEmployees";
                cmd.Connection = con;
                con.Open();
                SqlDataReader readerob = cmd.ExecuteReader();
                while (readerob.Read())
                {
                    li.Add(new Emp
                    {
                        EmpID = Convert.ToInt32(readerob["EmpID"]),
                        EmpName = readerob["Empname"].ToString(),
                        EmpSal = Convert.ToInt32(readerob["EmpSal"]),
                        Gender = readerob["Gender"].ToString(),
                    }
                        );
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }


            return li;
        }

        public void AddEmp(Emp emp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("Str").ToString());
            SqlCommand cmd = new SqlCommand();
            try
            {

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Empname", emp.EmpName);
                cmd.Parameters.AddWithValue("@EmpSal", emp.EmpSal);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddEmp";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        public Emp GetEditEmp(int id)
        {
            Emp emp = new Emp();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("Str").ToString());
            SqlCommand cmd = new SqlCommand();
            try
            {

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@EmpID", id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEmp";
                cmd.Connection = con;
                con.Open();
                SqlDataReader readerob = cmd.ExecuteReader();
                while (readerob.Read())
                {

                    emp.EmpID = Convert.ToInt32(readerob["EmpID"]);
                    emp.EmpName = readerob["Empname"].ToString();
                    emp.EmpSal = Convert.ToInt32(readerob["EmpSal"]);
                    emp.Gender = readerob["Gender"].ToString();

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return emp;
        }

        public void UpdateEmp(Emp emp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("Str").ToString());
            SqlCommand cmd = new SqlCommand();
            try
            {

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@EmpID", emp.EmpID);
                cmd.Parameters.AddWithValue("@Empname", emp.EmpName);
                cmd.Parameters.AddWithValue("@EmpSal", emp.EmpSal);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateEmp";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        public void DelEmp(int id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings.Get("Str").ToString());
            SqlCommand cmd = new SqlCommand();
            try
            {

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@EmpID", id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DelEmp";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

    }
}