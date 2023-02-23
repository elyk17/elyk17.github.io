using System.Data.SqlClient;
using System.Data;

namespace BookOfShadows
{
    public partial class insideBook : Form
    {
        public insideBook()
        {
            InitializeComponent();
            Form1 form = new Form1();
            form.Close();
         
        }

        private void bookpages_Load(object sender, EventArgs e)
        {
            Form1 book = new Form1();
            book.Close(); 
            CreateConnection();

            string cmd = "Select title from [dbo].[page] ORDER BY title ASC";
            SqlCommand command = new SqlCommand(cmd, con);
            try
            {
                con.Open(); 
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    int count = reader.FieldCount;

                    while (reader.Read())
                    {
                        for (int i = 0; i < count; i++)
                        {
                            richTextBox1.AppendText(reader[i].ToString() +'\n');
                        }

                    }
                    reader.Close();
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

        private void title_Click(object sender, EventArgs e)
        {

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            reset_password reset = new reset_password();
            reset.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputTitle.Clear();
            textBody.Clear();

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
            string cmd = "INSERT INTO [dbo].[page] (title, book_page) Values (@header, @insert_page)";
            SqlCommand command = new SqlCommand(cmd, con);
            command.Parameters.AddWithValue("@header", inputTitle.Text);
            command.Parameters.AddWithValue("@insert_page", textBody.Text);
            try
            {
                con.Open();
                int result = command.ExecuteNonQuery();
                if (result < 0)
                    MessageBox.Show("Error inserting data into Database!");
                else
                {
                    MessageBox.Show("Page Saved");
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
            CreateConnection();
            string cmd = "Select * from [dbo].[page] ORDER BY title ASC";
            SqlCommand command = new SqlCommand(cmd, con);
            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string results = reader["title"].ToString();
                    richTextBox1.Text = results;
                }
                con.Close();



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

        private void searchButton_Click(object sender, EventArgs e)
        {
            CreateConnection();
            string cmd = "SELECT * FROM [dbo].[page] WHERE title = @new_title";
            SqlCommand command = new SqlCommand(cmd, con);
            command.Parameters.AddWithValue("@new_title", titleTextBox.Text);
            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string results = reader["title"].ToString();
                    inputTitle.Text = results;
                    string page = reader["book_page"].ToString();
                    textBody.Text = page;
                    if(results == null)
                    {
                        MessageBox.Show("No Page Found");
                    }
                }
                con.Close();



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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
