using Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccesoaDatosArticulo
{
    public class AccesoDatoElemento
    {
        public  List<Elemento> ListarCategoria()
        {
            List<Elemento> lista = new List<Elemento>();
            AccesoaDatos datos = new AccesoaDatos();
            try
            {
                datos.setearconsulta("select Id,Descripcion from CATEGORIAS");
                datos.ejecutarlectura();

                while (datos.lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarconexion();
            }

            
        }
        
        
        public List<Elemento> ListarMarca()
        {

            List<Elemento> lista = new List<Elemento>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {
                datos.setearconsulta("select Id,Descripcion from MARCAS");
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];

                    lista.Add(aux);

                    
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
            
        
        }

    }
}
