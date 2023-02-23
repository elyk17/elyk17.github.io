using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace BookOfShadows
{
    public partial class reset_password : Form
    {
        public reset_password()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BOS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //SqlConnection con = new SqlConnection(constr);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("UPDATE _admin SET password = @value" );
            //cmd.Parameters.AddWithValue("@value", resetTextBox.Text);
            //cmd.ExecuteNonQuery();

            using (SqlConnection connection = new SqlConnection(constr))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE _admin SET password = @password";
       
                command.Parameters.AddWithValue("@password", resetTextBox.Text);
                connection.Open();

                command.ExecuteNonQuery();
                MessageBox.Show("Password Updated");

                connection.Close();
                this.Close();
            }
        }

        private void reset_password_Load(object sender, EventArgs e)
        {

        }
    }
}
