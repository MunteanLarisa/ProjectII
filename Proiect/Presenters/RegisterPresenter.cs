﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;
using Proiect.Views;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect.Presenters
{
    class RegisterPresenter
    {
        IRegister registerView;

        public RegisterPresenter(IRegister view)
        {
            registerView = view;
        }
        public void SignUpButton()
        {

            if (registerView.ConfPassword != string.Empty || registerView.Password != string.Empty || registerView.Username != string.Empty)
            {
                if (registerView.Password == registerView.ConfPassword)
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
                    cn.Open();

                    SqlCommand cmd = new SqlCommand("select * from Login where username='" + registerView.Username + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Login values (@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", registerView.Username);
                        cmd.Parameters.AddWithValue("password", registerView.Password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
