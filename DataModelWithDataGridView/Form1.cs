using DataModelWithDataGridView.Data;
using DataModelWithDataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataModelWithDataGridView
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario data = new Usuario(); 
        public Form1()
        {
            InitializeComponent();
            Iniciar(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar(); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(); 
        }

       private void Iniciar ()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            grilla.DataSource = tabla;
        }

        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel() {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text)
            };
            data.Guardar(modelo); 
            
        }

        private void Consultar ()
        {
            foreach(var item in data.consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;

                tabla.Rows.Add(fila); 
            }
        }

        private void Limpiar ()
        {
            txtNombre.Clear();
            txtEdad.Clear(); 
        }
    }
}
