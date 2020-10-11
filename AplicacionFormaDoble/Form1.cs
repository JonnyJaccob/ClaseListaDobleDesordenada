using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionForms
{
    public partial class Form1 : Form
    {
        string PathDireccion = @"C:\Users\jacco\source\repos\AplicacionForms\Draw\Perfil.png";
        EmpresaCurtidoraDePieles Empresa;
        ClaseListaDoble<EmpresaCurtidoraDePieles> listaSimple = new ClaseListaDoble<EmpresaCurtidoraDePieles>(true);
        public Form1()
        {
            InitializeComponent();
            rdbHombre.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private new void Click(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarImagen();
            if (strNombreArchivo != null)
                MostrarImagen(strNombreArchivo);
        }
        private string CargarImagen()
        {
            string strNombreArchivo = null;
            // Declaración de variable para seleccionar el archivo
            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            miArchivoFoto.Filter = "Archivos JPEG (*.jpg) | *.jpg";
            miArchivoFoto.InitialDirectory = "Mis documentos";
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                strNombreArchivo = miArchivoFoto.FileName;
                PathDireccion = strNombreArchivo;
                return (strNombreArchivo);
            }
            else return (null);
        }
        private void MostrarImagen(string strNombreArchivo)
        {
            Bitmap miImagen = new Bitmap(strNombreArchivo);
            pcbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagen.Image = (Image)miImagen;
            pcbImagen.Refresh();
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa = new EmpresaCurtidoraDePieles();
                Empresa.Nombre = txtNombre.Text;
                Empresa.ID = int.Parse(txtID.Text);
                Empresa.Sueldo = int.Parse(txtSueldo.Text);
                Empresa.Inicial = char.Parse(txtInicial.Text);
                Empresa.Productos = int.Parse(txtCantidad.Text);
                Empresa.Puesto = cmbPuesto.Text;
                Empresa.Seguro = cbxSeguro.Checked;
                Empresa.Fecha = dtpFecha.Value;
                if (rdbHombre.Checked)
                {
                    Empresa.Genero = "Masculino";
                }
                else
                {
                    Empresa.Genero = "Femenino";
                }
                Empresa.Direccion = PathDireccion;
                //IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Genero,Empresa.Sueldo, Empresa.Inicial,Empresa.Fecha,Empresa.Productos, Empresa.Puesto, Empresa.Seguro );
                listaSimple.AgregarNodo(Empresa);
                AgregarTabla();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Error algun campo esta vacio {ex}");
            }
            catch (NullReferenceException exxx)
            {
                MessageBox.Show($"Error: {exxx}");
            }
            catch (Exception exx)
            {
                MessageBox.Show($"Error: {exx}");
            }
        }
        public void IntroducirTabla(string Name, int id, string genero, double doble, char clar, DateTime fecha, int producto, string puesto, bool seguro, string direccion)
        {
            string s;
            if (seguro)
            {
                s = "Si";
            }
            else
            {
                s = "N";
            }
            Tabla.Rows.Add(Name, id, genero, doble, clar, fecha, producto, puesto, s, direccion);
        }

        private void btnAutoLlenar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Aurelio";
            txtID.Text = "1";
            txtSueldo.Text = "14000";
            txtInicial.Text = "A";
            txtCantidad.Text = "20";
            cmbPuesto.Text = "Supervisor";
            cbxSeguro.Checked = true;
            dtpFecha.Value = DateTime.Now;
        }
        void Llenar()
        {
            DataGridViewRow row = Tabla.CurrentRow;
            EmpresaCurtidoraDePieles Aux = new EmpresaCurtidoraDePieles();
            if (row != null)
            {
                try
                {
                    txtNombre.Text = Aux.Nombre = Tabla.CurrentRow.Cells[0].Value.ToString();
                    Aux.ID = int.Parse($"{Tabla.CurrentRow.Cells[1].Value}");
                    Aux.Genero = $"{Tabla.CurrentRow.Cells[2].Value}";
                    Aux.Sueldo = int.Parse($"{Tabla.CurrentRow.Cells[3].Value}");
                    Aux.Inicial = char.Parse($"{Tabla.CurrentRow.Cells[4].Value}");
                    Aux.Fecha = (DateTime)Tabla.CurrentRow.Cells[5].Value;
                    Aux.Productos = int.Parse($"{Tabla.CurrentRow.Cells[6].Value}");
                    Aux.Puesto = Tabla.CurrentRow.Cells[7].Value.ToString();
                    if (Tabla.CurrentRow.Cells[8].Value.ToString() == "Si")
                    {
                        Aux.Seguro = true;
                    }
                    else
                    {
                        Aux.Seguro = false;
                    }
                    Aux.Direccion = Tabla.CurrentRow.Cells[9].Value.ToString();
                }
                catch (Exception)
                {
                    throw new Exception("Error");
                }
            }
        }
        private void clickData(object sender, EventArgs e)
        {
            if (chbEvento.Checked)
            {
                DataGridViewRow row = Tabla.CurrentRow;
                if (row != null)
                {
                    try
                    {
                        EmpresaCurtidoraDePieles Aux = new EmpresaCurtidoraDePieles();
                        txtNombre.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
                        txtID.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
                        Aux.Genero = $"{Tabla.CurrentRow.Cells[2].Value}";
                        if (Aux.Genero == "Masculino")
                        {
                            rdbHombre.Checked = true;
                        }
                        else
                        {
                            rdbMujer.Checked = true;
                        }
                        txtSueldo.Text = Tabla.CurrentRow.Cells[3].Value.ToString();
                        txtInicial.Text = Tabla.CurrentRow.Cells[4].Value.ToString();
                        dtpFecha.Value = (DateTime)Tabla.CurrentRow.Cells[5].Value;
                        txtCantidad.Text = Tabla.CurrentRow.Cells[6].Value.ToString();
                        cmbPuesto.Text = Tabla.CurrentRow.Cells[7].Value.ToString();
                        if (Tabla.CurrentRow.Cells[8].Value.ToString() == "Si")
                        {
                            Aux.Seguro = true;
                            cbxSeguro.Checked = true;
                        }
                        else
                        {
                            Aux.Seguro = false;
                            cbxSeguro.Checked = false;
                        }
                        MostrarImagen(Tabla.CurrentRow.Cells[9].Value.ToString());
                    }
                    catch (Exception)
                    {
                        throw new Exception("Error");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un renglon de la tabla");
                }
            }
        }
        void AgregarTabla()
        {
            Tabla.Rows.Clear();
            foreach (EmpresaCurtidoraDePieles Empresa in listaSimple)
            {
                IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Genero, Empresa.Sueldo, Empresa.Inicial, Empresa.Fecha, Empresa.Productos, Empresa.Puesto, Empresa.Seguro, Empresa.Direccion);
            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Tabla.CurrentRow;
            if (row != null)
            {
                try
                {
                    EmpresaCurtidoraDePieles Aux = new EmpresaCurtidoraDePieles();
                    txtNombre.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
                    txtID.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
                    Aux.Genero = $"{Tabla.CurrentRow.Cells[2].Value}";
                    if (Aux.Genero == "Masculino")
                    {
                        rdbHombre.Checked = true;
                    }
                    else
                    {
                        rdbMujer.Checked = true;
                    }
                    txtSueldo.Text = Tabla.CurrentRow.Cells[3].Value.ToString();
                    txtInicial.Text = Tabla.CurrentRow.Cells[4].Value.ToString();
                    dtpFecha.Value = (DateTime)Tabla.CurrentRow.Cells[5].Value;
                    txtCantidad.Text = Tabla.CurrentRow.Cells[6].Value.ToString();
                    cmbPuesto.Text = Tabla.CurrentRow.Cells[7].Value.ToString();
                    if (Tabla.CurrentRow.Cells[8].Value.ToString() == "Si")
                    {
                        Aux.Seguro = true;
                        cbxSeguro.Checked = true;
                    }
                    else
                    {
                        Aux.Seguro = false;
                        cbxSeguro.Checked = false;
                    }
                    MostrarImagen(Tabla.CurrentRow.Cells[9].Value.ToString());
                }
                catch (Exception)
                {
                    throw new Exception("Error");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un renglon de la tabla");
            }
        }

        private void btnBasura_Click(object sender, EventArgs e)
        {
            DialogResult comprobar = MessageBox.Show("¿Desea borrar los datos que selecciono?", "Borrar Datos", MessageBoxButtons.YesNoCancel);
            switch (comprobar)
            {
                case DialogResult.Yes:
                    Eliminacion();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
        void Eliminacion()
        {
            DataGridViewRow row = Tabla.CurrentRow;
            EmpresaCurtidoraDePieles Aux = new EmpresaCurtidoraDePieles();
            if (row != null)
            {
                try
                {
                    txtNombre.Text = Aux.Nombre = Tabla.CurrentRow.Cells[0].Value.ToString();
                    Aux.ID = int.Parse($"{Tabla.CurrentRow.Cells[1].Value}");
                    Aux.Genero = $"{Tabla.CurrentRow.Cells[2].Value}";
                    Aux.Sueldo = int.Parse($"{Tabla.CurrentRow.Cells[3].Value}");
                    Aux.Inicial = char.Parse($"{Tabla.CurrentRow.Cells[4].Value}");
                    Aux.Fecha = (DateTime)Tabla.CurrentRow.Cells[5].Value;
                    Aux.Productos = int.Parse($"{Tabla.CurrentRow.Cells[6].Value}");
                    Aux.Puesto = Tabla.CurrentRow.Cells[7].Value.ToString();
                    if (Tabla.CurrentRow.Cells[8].Value.ToString() == "Si")
                    {
                        Aux.Seguro = true;
                    }
                    else
                    {
                        Aux.Seguro = false;
                    }
                    Aux.Direccion = Tabla.CurrentRow.Cells[9].Value.ToString();
                }
                catch (Exception)
                {
                    throw new Exception("Error");
                }
                Aux = listaSimple.EliminarNodo(Aux);
                AgregarTabla();
                MessageBox.Show($"Datos que se borraron:\n{Aux.ToString()}");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            DialogResult comprobar = MessageBox.Show("¿Desea borrar todos los datos?", "Vaciar Tabla", MessageBoxButtons.YesNoCancel);
            switch (comprobar)
            {
                case DialogResult.Yes:
                    listaSimple.VaciarLista();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
            
            AgregarTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSecreto_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Tabla.CurrentRow;
            EmpresaCurtidoraDePieles Aux = new EmpresaCurtidoraDePieles();
            if (row != null)
            {
                try
                {
                    txtNombre.Text = Aux.Nombre = Tabla.CurrentRow.Cells[0].Value.ToString();
                    Aux.ID = int.Parse($"{Tabla.CurrentRow.Cells[1].Value}");
                    Aux.Genero = $"{Tabla.CurrentRow.Cells[2].Value}";
                    Aux.Sueldo = int.Parse($"{Tabla.CurrentRow.Cells[3].Value}");
                    Aux.Inicial = char.Parse($"{Tabla.CurrentRow.Cells[4].Value}");
                    Aux.Fecha = (DateTime)Tabla.CurrentRow.Cells[5].Value;
                    Aux.Productos = int.Parse($"{Tabla.CurrentRow.Cells[6].Value}");
                    Aux.Puesto = Tabla.CurrentRow.Cells[7].Value.ToString();
                    if (Tabla.CurrentRow.Cells[8].Value.ToString() == "Si")
                    {
                        Aux.Seguro = true;
                    }
                    else
                    {
                        Aux.Seguro = false;
                    }
                    Aux.Direccion = Tabla.CurrentRow.Cells[9].Value.ToString();
                }
                catch (Exception)
                {
                    throw new Exception("Error");
                }

                MessageBox.Show($"{listaSimple.ObtenerResultado(Aux)}");
            }
        }
    }
}
