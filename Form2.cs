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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=racoonbarbershop;User Id=root;Password=Sosa1234#;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (name, phone, email, password) VALUES (@Name, @Phone, @Email, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro completado con éxito.");

                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
    }

