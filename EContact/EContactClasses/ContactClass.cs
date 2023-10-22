using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EContact.EContactClasses
{
     class ContactClass
    {
        //Getter and Setter method

        public int ContactID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? GenderID { get; set; }
        public string? ContactNumber     { get; set; }
        public string? Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting data from database

        public DataTable Select()
        {
            //DataBase Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Write sql query
                string sql = "select * from tbl_contact";
                //creating cmd  using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating  Sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data in Database
        public bool Insert(ContactClass c)
        {
            bool isSuccess = false;
            //connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to insert data
                string sql = "INSERT INTO tbl_contact(FirstName,LastName,ContactNumber,Address,Gender) VALUES (@FirstName,@LastName,@ContactNumber,@Address,@Gender)";
                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameter to add
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNumber", c.ContactNumber);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                    //if query run successfully then the value of row will be greater than zero else its value will be 0
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch (Exception e)
            {
               
            }
            finally
            {
                conn.Close();
            }   

             return  isSuccess;
        }
        public bool Update(ContactClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to update
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNumber=@ContactNumber, Address=@Address, Gender=@Gender WHERE ContactId=@ContactId";
                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameter to add  value

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNumber", c.ContactNumber);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //open database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery(); 
                //if the query run successfully then the value of rows will be greater than zero else its value will be zero
                if (rows >0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //Method to delete the data
        public bool Delete(ContactClass c)
        {
            // create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //upadte sql query data in our database
                string sql = "delete from tbl_contact where ContactId = @ContactId";
               //creating Sql Command  
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add value
                cmd.Parameters.AddWithValue("@ContactId", c.ContactID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows >0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally { 
                conn.Close(); 
            }
            return isSuccess;
                
        }
    }
}
