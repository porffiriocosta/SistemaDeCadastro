using Ninject;
using Sistema.Cadastro.Aplication.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Cadastro.Views
{
    public partial class Cadastro : Form
    {
        private IUsuarioApplication _usuarioApplication { get; set; }

        [Inject()]
        public Cadastro(IUsuarioApplication usuarioApplication)
        {
            InitializeComponent();

            _usuarioApplication = usuarioApplication;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var result = _usuarioApplication.Consultar();
        }
    }
}
