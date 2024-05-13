using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominios;
using AccesoaDatosArticulo;

namespace Trabajo_Final_N_3_Gonzalez_Nicolas
{
    public partial class home : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoDatosLector Articulo = new AccesoDatosLector();

            ListaArticulo = Articulo.Listar();

            RepCarrusel.DataSource = ListaArticulo;
            RepCarrusel.DataBind();


        }
    }
}