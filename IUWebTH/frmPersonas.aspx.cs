using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IUWebTH
{
    public partial class frmPersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridViewPersonas.DataSource = BibliotecaDatos.Persona.getDatos();
            this.GridViewPersonas.DataBind();
        }


    }
}