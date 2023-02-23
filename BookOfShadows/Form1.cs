
using Microsoft.Data.SqlClient;

namespace BookOfShadows
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        private SqlConnection con;
    
        private void button1_Click(object sender, EventArgs e)
        {
            passwordLabel.Visible = true;
            passwordBox.Visible = true;
            openButton.Visible = false;
            enterButton.Visible = true;

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
           
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }
        private void CreateConnection()
        {
            string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BOS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(ConnStr);
        }
        public void getReader()
        {
            CreateConnection();
            string cmd = "select * from _admin";
            SqlCommand command = new SqlCommand(cmd, con);
            try
            {
                con.Open();
                command.ExecuteScalar();
                if(string.IsNullOrEmpty(Convert.ToString(command.ExecuteScalar())))
                {
                    MessageBox.Show("No Password Found");
                    setpasswordOpen password = new setpasswordOpen();
                    password.ShowDialog();
                }
                
                else if(passwordBox.Text == command.ExecuteScalar().ToString())
                {
                    MessageBox.Show("Password Match");
                    insideBook beginning = new insideBook();
                    beginning.ShowDialog();
                    this.Hide();
                    

                }
                else
                {
                    MessageBox.Show("Password Does Not Match");
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


            //CreateConnection();
            //string cmd = "select * from _admin";
            //SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
            //DataTable dt = new DataTable();

            //try
            //{
            //    con.Open();
            //    sda.Fill(dt);


            //}
            //catch (SqlException se)
            //{
            //    throw;
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
            //finally
            //{
            //    con.Close();
            //}
            //return dt;
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            getReader();
           
        }
    }
}