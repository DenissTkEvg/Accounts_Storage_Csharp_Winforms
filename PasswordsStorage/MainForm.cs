using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PasswordsStorage
{
    public partial class MainForm : Form
    {
        SqlConnection sqlCon;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            string listBoxHeader = "        " + "Аккаунт:" + "                " + "Логин:" + "                    " + "Пароль:";
            SelectListBox.Items.Add(listBoxHeader);
            ResultOfSearchListBox.Items.Add(listBoxHeader);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\evg2017\source\repos\PasswordsStorage\PasswordsStorage\AccountsDB.mdf;Integrated Security=True";
            sqlCon = new SqlConnection(conString);
            await sqlCon.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [AccountsData]", sqlCon);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    SelectListBox.Items.Add(Convert.ToString(sqlReader["Id"]) + "            " + Convert.ToString(sqlReader["Description_of_account"]) + "           " + Convert.ToString(sqlReader["Login_of_account"]) + "         " + Convert.ToString(sqlReader["Pass_of_account"]));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State != ConnectionState.Closed)
                sqlCon.Close();
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlCon != null && sqlCon.State != ConnectionState.Closed)
                sqlCon.Close();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            SelectListBox.Items.Clear();
            string listBoxHeader = "        " + "Аккаунт:" + "                " + "Логин:" + "                    " + "Пароль:";
            SelectListBox.Items.Add(listBoxHeader);

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [AccountsData]", sqlCon);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    SelectListBox.Items.Add(Convert.ToString(sqlReader["Id"]) + "            " + Convert.ToString(sqlReader["Description_of_account"]) + "           " + Convert.ToString(sqlReader["Login_of_account"]) + "         " + Convert.ToString(sqlReader["Pass_of_account"]));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (InsertErrorLabel.Visible)
                InsertErrorLabel.Visible = false;
            if ((String.IsNullOrEmpty(LoginTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text) || String.IsNullOrEmpty(DescriptionOfAccountTextBox.Text)) && ((String.IsNullOrWhiteSpace(LoginTextBox.Text) || String.IsNullOrWhiteSpace(PasswordTextBox.Text) || String.IsNullOrWhiteSpace(DescriptionOfAccountTextBox.Text))))
            {
                InsertErrorLabel.Visible = true;
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO [AccountsData](Description_of_account, Login_of_account, Pass_of_account) VALUES (@Description_of_account, @Login_of_account, @Pass_of_account)", sqlCon);
                command.Parameters.AddWithValue("Description_of_account", DescriptionOfAccountTextBox.Text);
                command.Parameters.AddWithValue("Login_of_account", LoginTextBox.Text);
                command.Parameters.AddWithValue("Pass_of_account", PasswordTextBox.Text);
                await command.ExecuteNonQueryAsync();
                LoginTextBox.Clear();
                PasswordTextBox.Clear();
                DescriptionOfAccountTextBox.Clear();
            }

        }

        private async void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectListBox.Items.Clear();
            string listBoxHeader = "        " + "Аккаунт:" + "                " + "Логин:" + "                    " + "Пароль:";
            SelectListBox.Items.Add(listBoxHeader);

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [AccountsData]", sqlCon);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    SelectListBox.Items.Add(Convert.ToString(sqlReader["Id"]) + "            " + Convert.ToString(sqlReader["Description_of_account"]) + "           " + Convert.ToString(sqlReader["Login_of_account"]) + "         " + Convert.ToString(sqlReader["Pass_of_account"]));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (DeleteOrUpdateIdErrorLabel.Visible)
                    DeleteOrUpdateIdErrorLabel.Visible = false;


                if (String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text))
                {
                    DeleteOrUpdateIdErrorLabel.Visible = true;

                }
                else
                {
                    SqlCommand command = new SqlCommand("DELETE FROM [AccountsData] WHERE [Id]=@Id", sqlCon);
                    command.Parameters.AddWithValue("Id", DeleteOrUpdateIdTextBox.Text);
                    await command.ExecuteNonQueryAsync();
                    DeleteOrUpdateIdTextBox.Clear();
                    DeleteOrUdpateDescriptionOfAccountTextBox.Clear();
                    DeleteOrUpdateLoginTextBox.Clear();
                    DeleteOrUpdatePasswordTextBox.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Идентификатор представляет собой число!");
            }


        }

        private async void UpdateFieldButton_Click(object sender, EventArgs e)
        {
            if (DeleteOrUdpateOneFieldErrorLabel.Visible)
                DeleteOrUdpateOneFieldErrorLabel.Visible = false;
            if (DeleteOrUpdateIdErrorLabel.Visible)
                DeleteOrUpdateIdErrorLabel.Visible = false;
            try
            {
                if ((String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text)))
                {
                    DeleteOrUdpateOneFieldErrorLabel.Visible = true;
                    DeleteOrUpdateIdErrorLabel.Visible = true;


                }
                if (!(String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text)))
                {
                    DeleteOrUdpateOneFieldErrorLabel.Visible = true;

                }
                if ((String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text)) && !((String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text))))
                {

                    DeleteOrUpdateIdErrorLabel.Visible = true;


                }
                if (!(String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)) && ((String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text))))
                {
                    if (String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text))
                    {
                        DeleteOrUpdateIdErrorLabel.Visible = true;
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("UPDATE [AccountsData] SET  [Description_of_account]=@Description_of_account WHERE [Id]=@Id", sqlCon);
                        command.Parameters.AddWithValue("Id", DeleteOrUpdateIdTextBox.Text);
                        command.Parameters.AddWithValue("Description_of_account", DeleteOrUdpateDescriptionOfAccountTextBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DeleteOrUpdateIdTextBox.Clear();
                        DeleteOrUdpateDescriptionOfAccountTextBox.Clear();
                        MessageBox.Show("Изменения сохранены!");
                    }

                }
                else if (!(String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text)) && ((String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text))))
                {
                    if (String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text))
                    {
                        DeleteOrUpdateIdErrorLabel.Visible = true;
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("UPDATE [AccountsData] SET [Login_of_account]=@Login_of_account WHERE [Id]=@Id", sqlCon);
                        command.Parameters.AddWithValue("Id", DeleteOrUpdateIdTextBox.Text);
                        command.Parameters.AddWithValue("Login_of_account", DeleteOrUpdateLoginTextBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DeleteOrUpdateIdTextBox.Clear();
                        DeleteOrUpdateLoginTextBox.Clear();
                        MessageBox.Show("Изменения сохранены!");
                    }

                }
                else if (!(String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text)) && ((String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)) && (String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text))))
                {
                    if (String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text))
                    {
                        DeleteOrUpdateIdErrorLabel.Visible = true;
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("UPDATE [AccountsData] SET [Pass_of_account]=@Pass_of_account WHERE [Id]=@Id", sqlCon);
                        command.Parameters.AddWithValue("Id", DeleteOrUpdateIdTextBox.Text);
                        command.Parameters.AddWithValue("Pass_of_account", DeleteOrUpdatePasswordTextBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DeleteOrUpdateIdTextBox.Clear();
                        DeleteOrUpdatePasswordTextBox.Clear();
                        MessageBox.Show("Изменения сохранены!");
                    }

                }
                else if ((!(String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)) && !((String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text)))) && (String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text)))
                {
                    if (String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text))
                    {
                        DeleteOrUpdateIdErrorLabel.Visible = true;
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("UPDATE [AccountsData] SET  [Description_of_account]=@Description_of_account, [Login_of_account]=@Login_of_account  WHERE [Id]=@Id", sqlCon);
                        command.Parameters.AddWithValue("Id", DeleteOrUpdateIdTextBox.Text);
                        command.Parameters.AddWithValue("Description_of_account", DeleteOrUdpateDescriptionOfAccountTextBox.Text);
                        command.Parameters.AddWithValue("Login_of_account", DeleteOrUpdateLoginTextBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DeleteOrUpdateIdTextBox.Clear();
                        DeleteOrUdpateDescriptionOfAccountTextBox.Clear();
                        DeleteOrUpdateLoginTextBox.Clear();
                        MessageBox.Show("Изменения сохранены!");

                    }
                }
                else if ((!(String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)) && !((String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text)))) && (String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text)))
                {
                    if (String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text))
                    {
                        DeleteOrUpdateIdErrorLabel.Visible = true;
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("UPDATE [AccountsData] SET  [Description_of_account]=@Description_of_account, [Pass_of_account]=@Pass_of_account  WHERE [Id]=@Id", sqlCon);
                        command.Parameters.AddWithValue("Id", DeleteOrUpdateIdTextBox.Text);
                        command.Parameters.AddWithValue("Description_of_account", DeleteOrUdpateDescriptionOfAccountTextBox.Text);
                        command.Parameters.AddWithValue("Pass_of_account", DeleteOrUpdatePasswordTextBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DeleteOrUpdateIdTextBox.Clear();
                        DeleteOrUdpateDescriptionOfAccountTextBox.Clear();
                        DeleteOrUpdatePasswordTextBox.Clear();
                        MessageBox.Show("Изменения сохранены!");

                    }
                }
                else if ((!(String.IsNullOrEmpty(DeleteOrUpdateLoginTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateLoginTextBox.Text)) && !((String.IsNullOrEmpty(DeleteOrUpdatePasswordTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdatePasswordTextBox.Text)))) && (String.IsNullOrEmpty(DeleteOrUdpateDescriptionOfAccountTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUdpateDescriptionOfAccountTextBox.Text)))
                {
                    if (String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text))
                    {
                        DeleteOrUpdateIdErrorLabel.Visible = true;
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("UPDATE [AccountsData] SET   [Login_of_account]=@Login_of_account, [Pass_of_account]=@Pass_of_account  WHERE [Id]=@Id", sqlCon);
                        command.Parameters.AddWithValue("Id", DeleteOrUpdateIdTextBox.Text);
                        command.Parameters.AddWithValue("Login_of_account", DeleteOrUpdateLoginTextBox.Text);
                        command.Parameters.AddWithValue("Pass_of_account", DeleteOrUpdatePasswordTextBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DeleteOrUpdateIdTextBox.Clear();
                        DeleteOrUpdateLoginTextBox.Clear();
                        DeleteOrUpdatePasswordTextBox.Clear();
                        MessageBox.Show("Изменения сохранены!");

                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(DeleteOrUpdateIdTextBox.Text) && String.IsNullOrWhiteSpace(DeleteOrUpdateIdTextBox.Text))
                    {
                        DeleteOrUpdateIdErrorLabel.Visible = true;
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("UPDATE [AccountsData] SET  [Description_of_account]=@Description_of_account, [Login_of_account]=@Login_of_account, [Pass_of_account]=@Pass_of_account WHERE [Id]=@Id", sqlCon);
                        command.Parameters.AddWithValue("Id", DeleteOrUpdateIdTextBox.Text);
                        command.Parameters.AddWithValue("Description_of_account", DeleteOrUdpateDescriptionOfAccountTextBox.Text);
                        command.Parameters.AddWithValue("Login_of_account", DeleteOrUpdateLoginTextBox.Text);
                        command.Parameters.AddWithValue("Pass_of_account", DeleteOrUpdatePasswordTextBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DeleteOrUpdateIdTextBox.Clear();
                        DeleteOrUdpateDescriptionOfAccountTextBox.Clear();
                        DeleteOrUpdateLoginTextBox.Clear();
                        DeleteOrUpdatePasswordTextBox.Clear();
                        MessageBox.Show("Изменения сохранены!");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Идентификатор представляет собой число!");
            }

        }

       
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (EmptyFieldErrorLabel.Visible)
                EmptyFieldErrorLabel.Visible = false;
            try
            {
                if (String.IsNullOrEmpty(SearchIdTextBox.Text) && String.IsNullOrWhiteSpace(SearchIdTextBox.Text) && String.IsNullOrEmpty(SearchDescrOfAccTextBox.Text) && String.IsNullOrWhiteSpace(SearchDescrOfAccTextBox.Text))
                {
                    EmptyFieldErrorLabel.Visible = true;
                }
                else if (!(String.IsNullOrEmpty(SearchIdTextBox.Text) && String.IsNullOrWhiteSpace(SearchIdTextBox.Text)) && (String.IsNullOrEmpty(SearchDescrOfAccTextBox.Text) && String.IsNullOrWhiteSpace(SearchDescrOfAccTextBox.Text)))
                {
                    SqlDataReader sqlReader = null;
                    SqlCommand command = new SqlCommand("SELECT * FROM [AccountsData] WHERE [Id]=@Id", sqlCon);
                    command.Parameters.AddWithValue("Id", SearchIdTextBox.Text);
                    try
                    {
                        sqlReader = await command.ExecuteReaderAsync();
                        while (await sqlReader.ReadAsync())
                        {
                            ResultOfSearchListBox.Items.Add(Convert.ToString(sqlReader["Id"]) + "            " + Convert.ToString(sqlReader["Description_of_account"]) + "           " + Convert.ToString(sqlReader["Login_of_account"]) + "         " + Convert.ToString(sqlReader["Pass_of_account"]));

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (sqlReader != null)
                            sqlReader.Close();
                    }


                }
                else if ((String.IsNullOrEmpty(SearchIdTextBox.Text) && String.IsNullOrWhiteSpace(SearchIdTextBox.Text)) && !(String.IsNullOrEmpty(SearchDescrOfAccTextBox.Text) && String.IsNullOrWhiteSpace(SearchDescrOfAccTextBox.Text)))
                {
                    SqlDataReader sqlReader = null;
                    SqlCommand command = new SqlCommand("SELECT * FROM [AccountsData] WHERE [Description_of_account]=@Description_of_account", sqlCon);
                    command.Parameters.AddWithValue("Description_of_account", SearchDescrOfAccTextBox.Text);
                    try
                    {
                        sqlReader = await command.ExecuteReaderAsync();
                        while (await sqlReader.ReadAsync())
                        {
                            ResultOfSearchListBox.Items.Add(Convert.ToString(sqlReader["Id"]) + "            " + Convert.ToString(sqlReader["Description_of_account"]) + "           " + Convert.ToString(sqlReader["Login_of_account"]) + "         " + Convert.ToString(sqlReader["Pass_of_account"]));

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (sqlReader != null)
                            sqlReader.Close();
                    }


                }
                else
                {
                    SqlDataReader sqlReader = null;
                    SqlCommand command = new SqlCommand("SELECT * FROM [AccountsData] WHERE [Id]=@Id AND [Description_of_account]=@Description_of_account", sqlCon);
                    command.Parameters.AddWithValue("Id", SearchIdTextBox.Text);
                    command.Parameters.AddWithValue("Description_of_account", SearchDescrOfAccTextBox.Text);
                    try
                    {
                        sqlReader = await command.ExecuteReaderAsync();
                        while (await sqlReader.ReadAsync())
                        {
                            ResultOfSearchListBox.Items.Add(Convert.ToString(sqlReader["Id"]) + "            " + Convert.ToString(sqlReader["Description_of_account"]) + "           " + Convert.ToString(sqlReader["Login_of_account"]) + "         " + Convert.ToString(sqlReader["Pass_of_account"]));

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (sqlReader != null)
                            sqlReader.Close();
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Идентификатор представляет собой число!");
            }

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State != ConnectionState.Closed)
                sqlCon.Close();
            this.Close();
        }

      
    }
    
}
