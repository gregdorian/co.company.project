using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using co.company.Business;

namespace InicioLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (AuthenticateUser.IngresoApp(txtUser.Text, txtPass.Text))
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
  
            }
            else
            {
                gbAcceso.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
                MessageBox.Show("Acceso DENEGADO!");
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
