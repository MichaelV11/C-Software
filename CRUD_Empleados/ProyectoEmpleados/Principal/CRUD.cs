using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Collections.Generic;


namespace ProyectoEmpleados.Principal
{
    public partial class CRUD : Form
    {
        private ClassData clsPrueba = new ClassData();
        public CRUD()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar() 
        {
            dataGridView1.AutoGenerateColumns = false;
            //El dataGridView1 es un control de cuadrícula en el formulario donde se mostrarán los datos.
            //Establecer AutoGenerateColumns en false significa que las columnas de la cuadrícula no se generarán automáticamente basadas en los datos de origen.
            dataGridView1.DataSource = clsPrueba.listar();
            //Esto indica que los datos que se mostrarán en el dataGridView1 provienen del resultado de llamar al método listar().

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            employees 
        }
    }
}
