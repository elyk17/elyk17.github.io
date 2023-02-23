using System;
using System.Data;
using System.Data.SqlClient;

namespace BookOfShadows
{
    public partial class setpasswordOpen : Form
    {
        public setpasswordOpen()
        {
            InitializeComponent();
        }

        private SqlConnection con;
        private void CreateConnection()
        {
            string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BOS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(ConnStr);
        }
        public void getReader()
        {
            CreateConnection();
            string cmd = "INSERT INTO [dbo].[_admin] (password) Values (@password)";
            SqlCommand command = new SqlCommand(cmd, con);
            command.Parameters.AddWithValue("@password", ""+passwordTextBox.Text+"");
            try
            {
                con.Open();
                int result = command.ExecuteNonQuery();
                if (result < 0)
                    MessageBox.Show("Error inserting data into Database!");
                else {
                    MessageBox.Show("Password Saved");
                    this.Close();
                }
                    

            }
            catch (SqlException se)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
       
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            getReader();
           
     
        }
    }
}
