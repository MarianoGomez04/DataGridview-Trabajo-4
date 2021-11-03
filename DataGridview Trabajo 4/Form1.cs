using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridview_Trabajo_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = new DataGridViewRow();
            Fila.CreateCells(DgvTabla);
            Fila.Cells[0].Value = txtProducto.Text;
            Fila.Cells[1].Value = txtPrecio.Text;
            Fila.Cells[2].Value = txtCodigo.Text;

            DgvTabla.Rows.Add(Fila);

            //limpiamos las celdas al agregar una//
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Text = "";
        }

        private void buttBorrar_Click(object sender, EventArgs e)
        {
            DgvTabla.Rows.Remove(DgvTabla.CurrentRow);
        }

        private void buttCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
