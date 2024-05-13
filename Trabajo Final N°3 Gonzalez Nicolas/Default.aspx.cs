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
    public partial class _default1 : System.Web.UI.Page
    {
        public List<Articulo> ListaCarrusel { get; set; }
        //creo la prop. para manípular la lista en el front.

        protected void Page_Load(object sender, EventArgs e)
        {
             AccesoDatosLector Negocio = new AccesoDatosLector();


            ListaCarrusel = Negocio.Listar();
            //le asigno ala prop. la lista de la base de datos.
        }
    }
}