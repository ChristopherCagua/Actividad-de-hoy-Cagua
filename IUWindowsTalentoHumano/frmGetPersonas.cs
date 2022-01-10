using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsTalentoHumano
{
    public partial class frmGetPersonas : Form
    {
        public frmGetPersonas()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.dgPersonas.DataSource = BibliotecaDatos.Persona.getDatos();

        }
    }
}
