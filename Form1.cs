using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevaAppBarberia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=racoonbarbershop;User Id=root;Password=Sosa1234#;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE email=@Email AND password=@Password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // Login correcto
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos.");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }
    }
    }
