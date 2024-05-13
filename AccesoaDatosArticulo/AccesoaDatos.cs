using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient; //using para base de datos.

namespace AccesoaDatosArticulo
{
    public class AccesoaDatos
    {



        public SqlConnection Conexion;
        public SqlCommand Comando;
        public SqlDataReader Lector;
        //atributos/variables necesarios para manipular la base de datos

        public SqlDataReader lector

        {
            get { return Lector; }
        }
        //esta propiedad sirve para leer solamente los datos.

        public AccesoaDatos()
        {
            Conexion = new SqlConnection(ConfigurationManager.AppSettings["CadenaConexion"]);
            //para tener la conexion centralizada.

            //Conexion = new SqlConnection ("server = DESKTOP-497OCOR\\SQLEXPRESS01; DataBase=CATALOGO; integrated security = true ");
            Comando = new SqlCommand();


        }
        //creamos el constructor para que cuando nace mi objeto se conecte a mi base de datos 
        // directamente.

        public void setearconsulta(string consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text; //el commandtype te lo pasa a texto.
            Comando.CommandText = consulta;
        }
        //de esta manera seteo la consulta que hice en pokemondatos.

        public void setearconsultaconsp(string sp)
        {
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandText = sp;
        }

        public void ejecutarlectura()
        {
            Comando.Connection = Conexion;

            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            //esta es la funcion que ejecuta la lectura.
        }

        public void Ejecutaraccion()
        {
            Comando.Connection = Conexion;

            try
            {
                Conexion.Open();

                Comando.ExecuteNonQuery();



            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public int EjecutaraccionScarlar() //obtiene un entero.
        {
            Comando.Connection = Conexion;

            try
            {
                Conexion.Open();

                return int.Parse(Comando.ExecuteScalar().ToString()); //le digo que es un entero.



            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void Setearparametro(string nombre, object valor)
        //se crea la funcion para setear los valore que se agregaron con @.
        //por parametro que reciba el nombre y el valor.
        {
            Comando.Parameters.AddWithValue(nombre, valor);
            //te deja agregarle el nombre con el valor.
        }

        public void cerrarconexion()
        {
            if (lector != null)
            {
                lector.Close();
            }

            Conexion.Close();
        }
        //cierro el lector y la conexion.



    }
}
