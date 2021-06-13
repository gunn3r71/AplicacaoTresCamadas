using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmUserRegistration : Form
    {
        public FrmUserRegistration()
        {
            InitializeComponent();
        }

        private void BtnSendForm_Click(object sender, EventArgs e)
        {
            var user = new Usuario(txtName.Text,txtEmail.Text,txtDocumento.Text);
            user.Salvar();
        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }
    }
}
