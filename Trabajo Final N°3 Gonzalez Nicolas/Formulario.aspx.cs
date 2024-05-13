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
    public partial class Formulario : System.Web.UI.Page
    {

        public bool Eliminacion { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            Eliminacion  = false; 
            TxtId.Enabled = false;
                  //que no se vea.
            try 
            {
                
               if(!IsPostBack) 
               {
                AccesoDatoElemento Elemento = new AccesoDatoElemento();
                
                List<Elemento> Lista = Elemento.ListarCategoria();

                DdlCategoria.DataSource = Lista;
                DdlCategoria.DataValueField = "Id";
                DdlCategoria.DataTextField = "Descripcion";
                DdlCategoria.DataBind();
               }

               if (!IsPostBack) 
               {
                AccesoDatoElemento Elemento = new AccesoDatoElemento();

                List<Elemento> Lista = Elemento.ListarMarca();

                DdlMarca.DataSource = Lista;
                DdlMarca.DataValueField = "Id";
                DdlMarca.DataTextField = "Descripcion";
                DdlMarca.DataBind();
               }

                //configuracion si estamos modificando

                string id = Request.QueryString["Id"] != null ? Request.QueryString["Id"].ToString() : "";

                if( id != "" && !IsPostBack) 
                {
                    AccesoDatosLector Datos = new AccesoDatosLector();

                    Articulo seleccionado = (Datos.Listar(id))[0];
                    //dame el primer elemento de la lista.
                    // ya sabemos que es una lista y me lo guarde en la variable seleccionado.

                    TxtId.Text = id;
                    TxtNombre.Text = seleccionado.Nombre;
                    TxtCodigo.Text = seleccionado.Codigo;
                    TxtDescripción.Text = seleccionado.Descripcion;
                    TxtImagen.Text = seleccionado.Imagen;
                    TxtPrecio.Text = seleccionado.Precio.ToString();
                    DdlMarca.SelectedValue = seleccionado.Marca.Id.ToString();
                    DdlCategoria.SelectedValue = seleccionado.Categoria.Id.ToString();

                    TxtImagen_TextChanged(sender, e);
                    //para que me cargue la imagen se llama al evento.


                }

            }
            catch (Exception ex) 
            {

                Session.Add("Error", ex);
                Response.Redirect("Error.aspx");
            }
            
        }

        protected void TxtImagen_TextChanged(object sender, EventArgs e)
        {
            ImagenArticulo.ImageUrl = TxtImagen.Text;
        }


        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            try 
            {
                Articulo Nuevo = new Articulo();
                AccesoDatosLector Datos = new AccesoDatosLector();


                Nuevo.Nombre = TxtNombre.Text;
                Nuevo.Codigo = TxtCodigo.Text;
                Nuevo.Precio = decimal.Parse(TxtPrecio.Text);
                Nuevo.Descripcion = TxtDescripción.Text;
                Nuevo.Imagen = TxtImagen.Text;

                Nuevo.Marca = new Elemento();

                Nuevo.Marca.Id = int.Parse(DdlMarca.SelectedValue);

                Nuevo.Categoria = new Elemento();

                Nuevo.Categoria.Id = int.Parse(DdlCategoria.SelectedValue);

                if(Request.QueryString["Id"] != null) 
                {
                    Nuevo.Id = int.Parse(TxtId.Text); //le paso el id que lo tengo cargado
                    //me lo carga la base de datos.
                    Datos.Modificar(Nuevo);
                }
                else
                    Datos.Agregar(Nuevo);
                
                
                
                Response.Redirect("ListaArticulo.aspx", false);

            }
            catch (Exception ex) 
            {

                Session.Add("Error", ex);
      

            }

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminacion = true;
        }

        protected void ConfirmaEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                if(CkEliminacion.Checked) 
                {
                   AccesoDatosLector Dato = new AccesoDatosLector();

                   Dato.Eliminar(int.Parse(TxtId.Text));
                   Response.Redirect("ListaArticulo.aspx");

                }
               

            }
            catch (Exception ex) 
            {

                Session.Add("Error",ex);
            }
        }
    }
}