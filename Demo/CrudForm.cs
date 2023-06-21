using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo
{
    public partial class CrudForm : Form
    {
        public CrudForm()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 600;
        }

        private void select_All_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand command = new SqlCommand("SELECT id FROM NewDataBase.dbo.temp", connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader;
                        reader = command.ExecuteReader();
                        queryList.Items.Clear();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            queryList.Items.Add(id);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputBox.Text))
            {
                if (int.TryParse(inputBox.Text, out int newId))
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {

                        connection.Open();

                        using (SqlCommand command = new SqlCommand("SELECT * FROM NewDataBase.dbo.temp WHERE id = @id", connection))
                        {

                            command.Parameters.AddWithValue("@id", newId);
                            try
                            {
                                connection.Open();
                                SqlDataReader reader;
                                reader = command.ExecuteReader();
                                queryList.Items.Clear();

                                while (reader.Read())
                                {
                                    int id = reader.GetInt32(0);
                                    queryList.Items.Add(newId);
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Error");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Input a valid integer");
                }
            }
            else
            {
                MessageBox.Show("Input a value");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (queryList.SelectedIndex >= 0)
            {
                int selectedId = (int)queryList.SelectedItem;

                if(int.TryParse(inputBox.Text, out int newId))
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("UPDATE NewDataBase.dbo.temp SET id = @newId WHERE id = @selectedId", connection))
                        {
                            command.Parameters.AddWithValue("@newId", newId);
                            command.Parameters.AddWithValue("@selectedId", selectedId);

                            try
                            {
                                command.ExecuteNonQuery();
                                int selectedIndex = queryList.SelectedIndex;
                                queryList.Items[selectedIndex] = newId;
                                MessageBox.Show("Updated Successfully");
                                inputBox.Text = string.Empty; 
                            }

                            catch
                            {
                                MessageBox.Show("Error");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid integer");
                }
            }
            else
            {
                MessageBox.Show("Select an item");
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputBox.Text))
            {
                if (int.TryParse(inputBox.Text, out int newId))
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {

                        connection.Open();

                        using (SqlCommand command = new SqlCommand("INSERT INTO NewDataBase.dbo.temp (id) VALUES (@id)", connection))
                        {

                            command.Parameters.AddWithValue("@id", newId);

                            try
                            {
                                command.ExecuteNonQuery();
                                queryList.Items.Add(newId);
                                MessageBox.Show("Item inserted successfully");
                                inputBox.Text = string.Empty;

                            }
                            catch
                            {
                                MessageBox.Show("Error");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Input a valid integer");
                }
            }
            else
            {
                MessageBox.Show("Input a value");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (queryList.SelectedIndex >= 0)
            {
                int selectedId = (int)queryList.SelectedItem;

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM NewDataBase.dbo.temp WHERE id = @id", connection))
                    {

                        command.Parameters.AddWithValue("@id", selectedId);

                        try
                        {
                            command.ExecuteNonQuery();
                            queryList.Items.Remove(selectedId);
                            MessageBox.Show("Item deleted");

                        }
                        catch 
                        {
                            MessageBox.Show("Error");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Need to select item");
            }
        }


        private void clear_Click(object sender, EventArgs e)
        {
            queryList.Items.Clear();
        }
    }
}
