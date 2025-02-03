using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaDatos
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private string apellido;
        private string nombre;
        private string edad;
        private string direccion;


        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "")
                txtBox1.BackColor = Color.Red;
            if (txtBox2.Text == "")
                txtBox2.BackColor = Color.Red;
            if (txtBox3.Text == "")
                txtBox3.BackColor = Color.Red;
            if (txtBox4.Text == "")
                txtBox4.BackColor = Color.Red;

            apellido = txtBox1.Text;
            nombre = txtBox2.Text;
            edad = txtBox3.Text;
            direccion = txtBox4.Text;

            lstBox1.Items.Add("El nombre completo es:" + nombre + " " + apellido + ". Su edad es:" + edad + ", y vive en:" + direccion);

        }


        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            apellido = txtBox1.Text;
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
            nombre = txtBox2.Text;
        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {
            edad = txtBox3.Text;
        }

        private void txtBox4_TextChanged(object sender, EventArgs e)
        {
            direccion= txtBox4.Text;
        }
    }
}
