using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace NuevaAppBarberia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Supongo que ya tienes el ID del usuario guardado al iniciar sesión
        private int userId = 1; // Por ejemplo, este ID debería ser dinámico según el usuario autenticado

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                // Cadena de conexión a la base de datos
                string connectionString = "Server=localhost;Database=racoonbarbershop;User Id=root;Password=Sosa1234#;";

                
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Consulta SQL para insertar una nueva cita
                    string query = "INSERT INTO appointments (user_id, service, barber, appointment_date, appointment_time) VALUES (@UserId, @Service, @Barber, @Date, @Time)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Parámetros de la consulta SQL
                    cmd.Parameters.AddWithValue("@UserId", userId); // ID del usuario logueado
                    cmd.Parameters.AddWithValue("@Service", cbxService.SelectedItem?.ToString()); // Verifica si el elemento seleccionado no es nulo
                    cmd.Parameters.AddWithValue("@Barber", cbxBarber.SelectedItem?.ToString()); // Verifica si el elemento seleccionado no es nulo
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date); // Solo la fecha
                    cmd.Parameters.AddWithValue("@Time", dtpTime.Value.TimeOfDay); // Solo la hora

                    // Ejecuta la consulta SQL
                    cmd.ExecuteNonQuery();

                    // Mensaje de éxito
                    MessageBox.Show("Cita agendada con éxito.");
                }
                Form form = new Form4();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                // Captura de errores y mensajes al usuario
                MessageBox.Show("Error al agendar la cita: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
