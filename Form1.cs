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

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CadenaConexion = "";
        string datos = "";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        Queue<string> Separar = new Queue<string>();
        MySqlDataReader reader = null;
        List<TextBox> TextBoxes = new List<TextBox>();
        List<Label> Labels = new List<Label>();
        Font Fuente = new Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        //Iniciar sesion --------------------------------------------------------------------------------------
        private void cmdConectar_Click(object sender, EventArgs e)
        {
            CadenaConexion = "server=" + comServer.SelectedItem + ";port=" + comPuert.SelectedItem + ";userid=" + txtUsuario.Text + ";password=" + txtContra.Text + ";";
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);
            datos = "";
            comBD.Items.Clear();

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexion);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                    Separar.Enqueue(datos);
                    datos = "";
                }

                foreach (string BD in Separar)
                {
                    comBD.Items.Add(BD);
                }

                Separar.Clear();

                //Cambiar
                CambiarBotones();
                MessageBox.Show("Se ha iniciado sesion normalmente.", "Inicio completado");

                conexion.Close();
            }
            catch (MySqlException E)
            {
                MessageBox.Show("No se pudo iniciar sesion. Verifique los datos ingresados.", "Inicio de sesion fallido");
            }

        }

        //Metodo al iniciar sesion
        void CambiarBotones()
        {
            comServer.Enabled = !comServer.Enabled;
            comPuert.Enabled = !comPuert.Enabled;
            txtContra.Enabled = !txtContra.Enabled;
            txtUsuario.Enabled = !txtUsuario.Enabled;
            cmdIniciarS.Enabled = !cmdIniciarS.Enabled;

            cmdCerrarS.Enabled = !cmdCerrarS.Enabled;
            cmdConectar.Enabled = !cmdConectar.Enabled;
            comBD.Enabled = !comBD.Enabled;

            cmdInsertar.Enabled = !cmdInsertar.Enabled;
            cmdBuscar.Enabled = !cmdBuscar.Enabled;
            cmdEditar.Enabled = !cmdEditar.Enabled;
            cmdEliminar.Enabled = !cmdEliminar.Enabled;
            txtBuscar.Enabled = !txtBuscar.Enabled;
            cmdEliminarBD.Enabled = !cmdEliminarBD.Enabled;
            cmdNewBD.Enabled = !cmdNewBD.Enabled;
 
        }

        //Reiniciar
        void Reiniciar()
        {
            cmdTabla1.Text = "";
            cmdTabla2.Text = "";
            cmdTabla3.Text = "";
            cmdTabla4.Text = "";
            cmdTabla5.Text = "";
            cmdTabla6.Text = "";
            cmdTabla7.Text = "";
            cmdTabla8.Text = "";
            cmdTabla9.Text = "";
            cmdTabla10.Text = "";
            cmdTabla11.Text = "";
            cmdTabla12.Text = "";
            cmdTabla13.Text = "";
            cmdTabla14.Text = "";
            cmdTabla15.Text = "";
            cmdTabla16.Text = "";
        }

        //Tablas de base datos --------------------------------------------------------------------------------------------------------------
   

        private void cmdTabla2_Click(object sender, EventArgs e)
        {
            if (cmdTabla2.Text != "")
            {
                EscogerTabla(cmdTabla2.Text);
                FormularioPanel(cmdTabla2.Text);
            }
        }

        private void cmdTabla3_Click(object sender, EventArgs e)
        {
            if (cmdTabla3.Text != "")
            {
                EscogerTabla(cmdTabla3.Text);
                FormularioPanel(cmdTabla3.Text);
            }
        }

        private void cmdTabla4_Click(object sender, EventArgs e)
        {
            if (cmdTabla4.Text != "")
            {
                EscogerTabla(cmdTabla4.Text);
                FormularioPanel(cmdTabla4.Text);
            }
        }

        private void cmdTabla5_Click(object sender, EventArgs e)
        {
            if (cmdTabla5.Text != "")
            {
                EscogerTabla(cmdTabla5.Text);
                FormularioPanel(cmdTabla5.Text);
            }
        }

        private void cmdTabla6_Click(object sender, EventArgs e)
        {
            if (cmdTabla6.Text != "")
            {
                EscogerTabla(cmdTabla6.Text);
                FormularioPanel(cmdTabla6.Text);
            }
        }

        private void cmdTabla7_Click(object sender, EventArgs e)
        {
            if (cmdTabla7.Text != "")
            {
                EscogerTabla(cmdTabla7.Text);
                FormularioPanel(cmdTabla7.Text);
            }
        }

        private void cmdTabla8_Click(object sender, EventArgs e)
        {
            if (cmdTabla8.Text != "")
            {
                EscogerTabla(cmdTabla8.Text);
                FormularioPanel(cmdTabla8.Text);
            }
        }

        private void cmdTabla9_Click(object sender, EventArgs e)
        {
            if (cmdTabla9.Text != "")
            {
                EscogerTabla(cmdTabla9.Text);
                FormularioPanel(cmdTabla9.Text);
            }
        }

        private void cmdTabla10_Click(object sender, EventArgs e)
        {
            if (cmdTabla10.Text != "")
            {
                EscogerTabla(cmdTabla10.Text);
                FormularioPanel(cmdTabla10.Text);
            }
        }

        private void cmdTabla11_Click(object sender, EventArgs e)
        {
            if (cmdTabla11.Text != "")
            {
                EscogerTabla(cmdTabla11.Text);
                FormularioPanel(cmdTabla11.Text);
            }
        }

        private void cmdTabla12_Click(object sender, EventArgs e)
        {
            if (cmdTabla12.Text != "")
            {
                EscogerTabla(cmdTabla12.Text);
                FormularioPanel(cmdTabla12.Text);
            }
        }

        private void cmdTabla13_Click(object sender, EventArgs e)
        {
            if (cmdTabla13.Text != "")
            {
                EscogerTabla(cmdTabla13.Text);
                FormularioPanel(cmdTabla13.Text);
            }
        }

        private void cmdTabla14_Click(object sender, EventArgs e)
        {
            if (cmdTabla14.Text != "")
            {
                EscogerTabla(cmdTabla14.Text);
                FormularioPanel(cmdTabla14.Text);
            }
        }

        private void cmdTabla15_Click(object sender, EventArgs e)
        {
            if (cmdTabla15.Text != "")
            {
                EscogerTabla(cmdTabla15.Text);
                FormularioPanel(cmdTabla15.Text);
            }
        }

        private void cmdTabla16_Click(object sender, EventArgs e)
        {
            if (cmdTabla16.Text != "")
            {
                EscogerTabla(cmdTabla16.Text);
                FormularioPanel(cmdTabla16.Text);
            }
        }


        //Eliminar Tabla------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void cmdTabla1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla1.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla1.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla1.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla1.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                        TerminarTransaccion();
                    }
                }
            }  
        }

        private void cmdTabla2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla2.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla2.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla2.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla2.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                        MessageBox("Se creo repositorio exitosamente")
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla3.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla3.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla3.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla3.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla4.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla4.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla4.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla4.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla5.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla5.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla5.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla5.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla6.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla6.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla6.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla6.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla7.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla7.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla7.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla7.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla8.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla8.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla8.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla8.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla9.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla9.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla9.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla9.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla10.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla10.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla10.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla10.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla11_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla11.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla11.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla11.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla11.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla12.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla12.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla12.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla12.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla13.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla13.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla13.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla13.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla14_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla14.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla14.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla14.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla14.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla15_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla15.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla15.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla15.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla15.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }

        private void cmdTabla16_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && cmdTabla16.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar la tabla " + cmdTabla16.Text + " de la base de datos?", "Eliminar Tabla", buttons);

                MySqlConnection conexion = new MySqlConnection(CadenaConexion);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + cmdTabla16.Text, conexion);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Se elimino la tabla de la base de datos exitosamente.", "Tabla eliminada");
                        cmdTabla16.Text = "";
                        conexion.Close();
                        TerminarTransaccion();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se pudo eliminar la tabla de la base de datos.", "Fallo la eliminacion");
                    }
                }
            }
        }
        //Eliminar Tabla------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        void EscogerTabla(string Tabla)
        {
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);
            Info.Text = Tabla;
            datos = "";
            Campos.Items.Clear();
            Registros.Items.Clear();

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("DESCRIBE " + Tabla + ";", conexion);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                    Campos.Items.Add(datos.ToUpper());
                    datos = "";
                }

                conexion.Close();
            }
            catch (MySqlException E)
            {
                MessageBox.Show(E.ToString());
            }
        }


        //Conectar base de datos
        private void cmdBases_Click(object sender, EventArgs e)
        {
            //Vaciar todos los elementos
            LimpiarTodo();

            CadenaConexion = "server=" + comServer.SelectedItem + ";port=" + comPuert.SelectedItem + ";userid=" + txtUsuario.Text + ";password=" + txtContra.Text + ";database=" + comBD.SelectedItem + ";";
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("SHOW TABLES", conexion);


                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                    Separar.Enqueue(datos);
                    datos = "";
                    cmdTabla1.Text = datos.ToUpper();
                }

                if (Separar.Count > 0)
                {
                    cmdTabla1.Text = Separar.Dequeue().ToUpper();

                    if (Separar.Count > 0)
                    {
                        cmdTabla2.Text = Separar.Dequeue().ToUpper();

                        if (Separar.Count > 0)
                        {
                            cmdTabla3.Text = Separar.Dequeue().ToUpper();

                            if (Separar.Count > 0)
                            {
                                cmdTabla4.Text = Separar.Dequeue().ToUpper();

                                if (Separar.Count > 0)
                                {
                                    cmdTabla5.Text = Separar.Dequeue().ToUpper();

                                    if (Separar.Count > 0)
                                    {
                                        cmdTabla6.Text = Separar.Dequeue().ToUpper();

                                        if (Separar.Count > 0)
                                        {
                                            cmdTabla7.Text = Separar.Dequeue().ToUpper();

                                            if (Separar.Count > 0)
                                            {
                                                cmdTabla8.Text = Separar.Dequeue().ToUpper();

                                                if (Separar.Count > 0)
                                                {
                                                    cmdTabla9.Text = Separar.Dequeue().ToUpper();

                                                    if (Separar.Count > 0)
                                                    {
                                                        cmdTabla10.Text = Separar.Dequeue().ToUpper();

                                                        if (Separar.Count > 0)
                                                        {
                                                            cmdTabla11.Text = Separar.Dequeue().ToUpper();

                                                            if (Separar.Count > 0)
                                                            {
                                                                cmdTabla12.Text = Separar.Dequeue().ToUpper();

                                                                if (Separar.Count > 0)
                                                                {
                                                                    cmdTabla13.Text = Separar.Dequeue().ToUpper();

                                                                    if (Separar.Count > 0)
                                                                    {
                                                                        cmdTabla14.Text = Separar.Dequeue().ToUpper();

                                                                        if (Separar.Count > 0)
                                                                        {
                                                                            cmdTabla15.Text = Separar.Dequeue().ToUpper();

                                                                            if (Separar.Count > 0)
                                                                            {
                                                                                cmdTabla16.Text = Separar.Dequeue().ToUpper();

                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Coneccion exitosa. No han ocurrido errores.", "Coneccion finalizada");
                conexion.Close();
            }
            catch (MySqlException E)
            {
                MessageBox.Show("No se pudo conectar. Verifique los datos ingresados.", "Coneccion fallida");
            }
        }

        //Eliminar Base datos
        private void cmdEliminarBD_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("DROP DATABASE IF EXISTS " + comBD.SelectedItem.ToString(), conexion);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Se elimino la base de datos exitosamente.", "Base de datos eliminada");
                conexion.Close();
                comBD.Items.Remove(comBD.SelectedItem.ToString());
                comBD.SelectedIndex = -1;
                TerminarTransaccion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se pudo eliminar la base de datos.", "Fallo la eliminacion");
            }
        }


        //Crear nueva base de datos.
        private void cmdNewBD_Click(object sender, EventArgs e)
        {
            String nombreBD = txtNewBD.Text;
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("CREATE DATABASE " + nombreBD, conexion);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Se creo la base de datos exitosamente.", "Base de datos eliminada");
                conexion.Close();
                comBD.Items.Add(nombreBD);
                TerminarTransaccion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se pudo crear la base de datos.", "Fallo la creacion");
            }

            txtNewBD.Text = "";
        }

        //Comandos SQL -----------------------------------------------------------------------------------------------------
        private void cmdGo_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);
            datos = "";
            Registros.Items.Clear();
            try
            {
                conexion.Open();
                //MySqlCommand cmd = new MySqlCommand(SQL.Text, conexion);
                ////reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                    Registros.Items.Add(datos.ToUpper());
                    datos = "";
                }

                conexion.Close();
            }
            catch (MySqlException E)
            {
                MessageBox.Show(E.ToString());
            }

            ////MessageBox.Show("Se ha ejecutado \"" + SQL.Text + "\" con exito.", "Consulta finalizada");
        }

        //Seleccionar -------------------------------------------------------------------------------------------------------
        private void Campos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);
            datos = "";
            Registros.Items.Clear();

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("Select " + Campos.SelectedItem + " from " + Info.Text, conexion);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                    Registros.Items.Add(datos.ToUpper());
                    datos = "";
                }

                conexion.Close();

            }
            catch (MySqlException E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void FormularioPanel(String Tabla)
        {
            //int can = Labels.Count;
            //for (int z = 0; z < (can * 2); z++) {
            //    Formulario.Controls.RemoveAt(z);
            //}

            Formulario.Controls.Clear();
            Labels.Clear();
            TextBoxes.Clear();

            String C = "server=" + comServer.SelectedItem + ";port=" + comPuert.SelectedItem + ";userid=" + txtUsuario.Text + ";password=" + txtContra.Text + ";database=" + comBD.SelectedItem + ";";

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = C;
            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("describe " + Tabla, conexion);
            MySqlDataReader leer = null;

            leer = cmd.ExecuteReader();

            int i = 0;
            while (leer.Read())
            {

                Labels.Add(new Label());
                Labels[i].ForeColor = Color.White;
                Labels[i].Font = Fuente;
                Labels[i].Text = (leer.GetString(0)).ToUpper();
                i++;
            }


            for (int x = 0; x < Labels.Count; x++)
            {
                TextBoxes.Add(new TextBox());
                TextBoxes[x].Width = 560;
                TextBoxes[x].Font = Fuente;
                TextBoxes[x].Location = new Point(120, 28 + (x * 60));
                Labels[x].Location = new Point(15, 30 + (x * 60));
                Formulario.Controls.Add(TextBoxes[x]);
                Formulario.Controls.Add(Labels[x]);
            }

            conexion.Close();
        }

        private void Formulario_Paint(object sender, PaintEventArgs e)
        {

        }

        //Cerrar sesion
        private void cmdCerrarS_Click(object sender, EventArgs e)
        {
            CambiarBotones();
            txtUsuario.Text = "";
            txtContra.Text = "";
            LimpiarTodo();
        }

        //Limpiar toda la pantalla
        void LimpiarTodo()
        {
            datos = "";
            Info.Text = "Tabla";
            Campos.Items.Clear();
            Registros.Items.Clear();
            Reiniciar();
            Formulario.Controls.Clear();
            Separar.Clear();
            txtResultados.Text = "";
        }

        //Insertar un campo
        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            CadenaConexion = "server=" + comServer.SelectedItem + ";port=" + comPuert.SelectedItem + ";userid=" + txtUsuario.Text + ";password=" + txtContra.Text + ";database=" + comBD.SelectedItem;
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);   

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("insert into " + Info.Text + " values (" + GenerarConsulta() + ")", conexion);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Se insertó el registro con exito.", "Registro insertado");
                conexion.Close();
                TerminarTransaccion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se pudo insertar el registro.", "Fallo en la inserccion");
            }   
        }

        //Generar consulta
        string GenerarConsulta()
        {         
            string consulta = "'" + TextBoxes[0].Text + "'";
            for (int c = 1; c < TextBoxes.Count; c++)
            {
                consulta = consulta + "," + "'" + TextBoxes[c].Text + "'";
            }
            return consulta;
        }

        //Sugerencias
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                CadenaConexion = "server=" + comServer.SelectedItem + ";port=" + comPuert.SelectedItem + ";userid=" + txtUsuario.Text + ";password=" + txtContra.Text + ";database=" + comBD.SelectedItem;
                MySqlConnection conexion = new MySqlConnection(CadenaConexion);
                datos = "";
                txtResultados.Text = "";

                try
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand("select " + Labels.First().Text + " from " + Info.Text + " where " + Labels.First().Text + " like '%" + txtBuscar.Text + "%'", conexion);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        datos += reader.GetString(0) + "\n";
                        txtResultados.Text = txtResultados.Text + datos;
                        datos = "";
                    }

                    conexion.Close();
                }
                catch (MySqlException E)
                {
                    MessageBox.Show(E.ToString());
                }
            }

            else
                txtResultados.Text = "";
        }

        //Buscar
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < Labels.Count; c++)
            {
                Buscar(c);
            }
        }

        void Buscar(int c)
        {
            CadenaConexion = "server=" + comServer.SelectedItem + ";port=" + comPuert.SelectedItem + ";userid=" + txtUsuario.Text + ";password=" + txtContra.Text + ";database=" + comBD.SelectedItem;
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("select " + Labels[c].Text + " from " + Info.Text + " where " + Labels[0].Text + " = '" + txtBuscar.Text + "'", conexion);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                    TextBoxes[c].Text = datos;
                    datos = "";
                }

                conexion.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("El elemento buscado no coincide con ningun registro.", "Busqueda fallida");
                TerminarTransaccion();
            }
        }

        //Eliminar
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            CadenaConexion = "server=" + comServer.SelectedItem + ";port=" + comPuert.SelectedItem + ";userid=" + txtUsuario.Text + ";password=" + txtContra.Text + ";database=" + comBD.SelectedItem;
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("delete from " + Info.Text + " where " + Labels[0].Text + " = " + "'" +txtBuscar.Text + "'", conexion);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Se elimino el registro con exito.", "Registro eliminado");
                conexion.Close();
                TerminarTransaccion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("El registro que trata de eleiminar no existe.", "Registro no existente");
            }
        }

        //Editar
        private void cmdEditar_Click(object sender, EventArgs e)
        {
            CadenaConexion = "server=" + comServer.SelectedItem + ";port=" + comPuert.SelectedItem + ";userid=" + txtUsuario.Text + ";password=" + txtContra.Text + ";database=" + comBD.SelectedItem;
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("update " + Info.Text + " set "  + GenerarConsulta2() + " where " + Labels[0].Text + " = '" + txtBuscar.Text + "'", conexion);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Se edito el registro exitosamente", "Registro modificado");
                conexion.Close();
                TerminarTransaccion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("El registro que trata de eliminar no existe.", "Registro no existente");
            }
        }

        //Generar consulta2
        string GenerarConsulta2()
        {
            string consulta =  Labels[0].Text + " = " + "'" + TextBoxes[0].Text + "'";
            for (int c = 1; c < TextBoxes.Count; c++)
            {
                consulta = consulta + "," + Labels[c].Text + " = " + "'" + TextBoxes[c].Text + "'";           
            }
            return consulta;
        }

        //Despues de transaccion
        void TerminarTransaccion()
        {
            for(int c = TextBoxes.Count -1; c >= 0; c--)
            {
                TextBoxes[c].Text = "";
            }

            txtBuscar.Text = "";
            txtResultados.Text = "";
        }
    }
}
