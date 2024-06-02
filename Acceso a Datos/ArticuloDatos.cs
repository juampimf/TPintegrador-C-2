using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public class ArticuloDatos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id,Codigo, Nombre, A.Descripcion, ImagenUrl, M.Descripcion Marca,Precio, C.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.id and A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)lector["Id"];
                    aux.Nombre = (string)lector["Nombre"] ;
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Marca = new Marca();
                    aux.Marca.id = (int)lector["Id"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["Id"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion,@IdMarca,@IdCategoria, @ImagenUrl, @Precio)");
                datos.setearParametro("@Codigo",nuevo.CodigoArticulo);
                datos.setearParametro("@Nombre",nuevo.Nombre);
                datos.setearParametro("@Descripcion",nuevo.Descripcion);
                datos.setearParametro("@IdMarca",nuevo.Marca.id);
                datos.setearParametro("@IdCategoria",nuevo.Categoria.Id);
                datos.setearParametro("@ImagenUrl",nuevo.ImagenUrl);
                datos.setearParametro("@Precio",nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConeccion();
            }
        }
    }
}
