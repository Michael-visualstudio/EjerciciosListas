using EjerciciosListas.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EjerciciosListas
{
    public partial class Form1 : Form
    {
        private List<Asignatura> lista = new List<Asignatura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(this.txtCodigo.Text.Length==0)
            {
                MessageBox.Show("Debe ingresar el código de la asignatura...");
                this.txtCodigo.Focus();//ubica el cursor en el control
            }
            if (this.txtAsignatura.Text.Length==0)
            {
                MessageBox.Show("Debe ingresar el codigo de la asignatura...");
                this.txtAsignatura.Focus();//ubica el cursor en el control
            }
            //convertir a entero
            if (!(int.TryParse(this.txtCreditos.Text, out int creditos)))
            {
                MessageBox.Show("Creditos no validos...");
                this.txtCreditos.Focus();
            }
            Asignatura materia = new Asignatura();
            materia.codigo = this.txtCodigo.Text;
            materia.asignatura = this.txtAsignatura.Text;
            materia.creditos = creditos;
            materia.carrera = this.cmbCarrera.Text;

            //asignar cada asignatura en la lista de asignaturas
            lista.Add(materia);

            //cargar la lista en el datagridview
            this.gridAsignaturas.DataSource = null;
            this.gridAsignaturas.DataSource = lista;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //filtrar datos por carrera
            this.gridAsignaturas.DataSource = null;
            this.gridAsignaturas.DataSource = lista.Where( data => data.carrera== this.txtCarrera.Text).ToList();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //encontrar maximos y minimos
            this.txtMaxCreditos.Text = lista.Max(data => data.creditos).ToString();
            this.txtMinCreditos.Text = lista.Min(data => data.creditos).ToString();

        }
    }
}
