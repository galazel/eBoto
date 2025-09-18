using School_Election_System.Controllers;
using School_Election_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;

namespace School_Election_System.Repositories
{
    internal class VoterRepository
    {
        private string connectionString = "";
        public void Save(VoterModel voter)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Voters VALUES(@FirstName,@LastName,@Email,@Contact,@Address,@Password)", connection);
                cmd.Parameters.AddWithValue("@FirstName",voter.FirstName);
                cmd.Parameters.AddWithValue("@LastName", voter.LastName);
                cmd.Parameters.AddWithValue("@Email", voter.Email);
                cmd.Parameters.AddWithValue("@Contact", voter.ContactNumber);
                cmd.Parameters.AddWithValue("@Password", voter.Password);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered");
            }

        }
        private int GetId(VoterModel voter)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT VotersID FROM VOTERS WHERE Email = @Email AND FirstName = @FirstName AND LastName = @LastName", connection);
                cmd.Parameters.AddWithValue("@Email", voter.Email);
                cmd.Parameters.AddWithValue("@FirstName", voter.FirstName);
                cmd.Parameters.AddWithValue("@LastName", voter.LastName);
                
                using(e)

                MessageBox.Show("Successfully Registered");
            }
        }
    }
}
