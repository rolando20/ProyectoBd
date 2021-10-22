using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroRbD.Controller;

namespace TeatroRbD.View
{
    public partial class Usuario : Form

    {
        public static string idUsuario;
        public static string nombre;
        public static string Rol;

        public static string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string Nombre { get => nombre; set => nombre = value; }

        public static string CodigoUsuario { get => codigoUsuario; set => codigoUsuario = value; }

        private static string codigoUsuario;
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dato;
            dato = CUsuario.Validar_acceso(this.txtUsuario.Text, this.txtContraseña.Text);
            if (dato == null)
            {
                MessageBox.Show("No hay Conexión al Servidor", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
             if (dato.Rows.Count > 0)
            {

                if (dato.Rows[0][0].ToString() == "Acceso Exitoso")
                {

                    
                    //  Rol = "Administrador";

                    MessageBox.Show("Bienvenido al Sistema", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 fc = new Form1();
                    fc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado al Sistema de Reservaciones", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsuario.Text = string.Empty;
                    this.txtContraseña.Text = string.Empty;
                    this.txtUsuario.Focus();
                }
            }


        }
    }
}
