using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace PryEjercicio1
{
    internal class ConexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;

        string cadena;

        public ConexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =./BDTiendamia.accdb";
        }
        public void CrearEnBD(string nom, int categ, int cant, string desc, int precio)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Objetos(Nombre, Categoria, Cantidad, Descripcion, Precio) VALUES('{nom}', '{categ}', '{cant}', '{desc}', '{precio}') ";

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh, no!" + ex.Message + " :( ");
            }
        }

        public void CargarBD(DataGridView dgv)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;


                comando.CommandText = "SELECT Objetos.Nombre, Objetos.Cantidad, Objetos.Descripcion, Objetos.Precio, Categorias.Categoria " +
"FROM Categorias INNER JOIN Objetos ON Categorias.Id = Objetos.Categoria";

                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgv.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado!" + ex.Message + "Es posible que haya escrito algún valor de forma incorrecta.");
            }

        }

        public List<string> ImprimirCateg(ComboBox Combo)
        {
            List<string> categorias = new List<string>();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Categoria FROM Categorias";

                DataTable tablaJugadores = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaJugadores);

                foreach (DataRow fila in tablaJugadores.Rows)
                {
                    categorias.Add(fila["Categoria"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return categorias;
        }

        public int DevolverId(string cat)
        {
            int id_categoria = 0;
            try
            {

                using (var conexion = new OleDbConnection(cadena))
                {
                    using (var comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = $"SELECT Id FROM Categorias WHERE Categoria = @categoria";
                        comando.Parameters.AddWithValue("@categoria", cat);

                        conexion.Open();

                        var result = comando.ExecuteScalar();
                        if (result != null)
                        {
                            id_categoria = Convert.ToInt32(result);
                        }
                    }
                }
                return id_categoria;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void ModificarTodo(string nombre, int cat, int cant, string desc, int precio)
        {
            try
            {
                using (conexion = new OleDbConnection(cadena))
                {
                    comando = new OleDbCommand();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;

                    comando.CommandText = "UPDATE Objetos SET Categoria = @cat, Cantidad = @cant, Descripcion = @desc, Precio = @prec " +
                                          "WHERE Nombre = @nombre";

                    comando.Parameters.AddWithValue("@cat", cat);
                    comando.Parameters.AddWithValue("@cant", cant);
                    comando.Parameters.AddWithValue("@desc", desc);
                    comando.Parameters.AddWithValue("@prec", precio);
                    comando.Parameters.AddWithValue("@nombre", nombre);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + " Revise el nombre o los datos modificados.");
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        // búsqueda estricta, si o si nom == nombre
        public void ImprimirPorNom(DataGridView dgvGrilla, string nom)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Objetos.Id, Objetos.Nombre, Objetos.Precio, Objetos.Cantidad, Objetos.Descripcion, Categorias.Categoria " +
                $"FROM Categorias INNER JOIN Objetos ON Categorias.Id = Objetos.Categoria WHERE Nombre = '{nom}'";

                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvGrilla.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + "Es probable que el nombre no exista en la base de datos.");
            }
        }

        // busqueda flexible, nom debe contener parte de nombre, pero no tiene que ser exactamente igual a nombre
        public void ImprimirPorNombre(DataGridView dgvGrilla, string nom)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Objetos.Id, Objetos.Nombre, Objetos.Precio, Objetos.Cantidad, Objetos.Descripcion, Categorias.Categoria " +
                $"FROM Categorias INNER JOIN Objetos ON Categorias.Id = Objetos.Categoria WHERE Nombre LIKE '%{nom}%'";

                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvGrilla.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + "Es probable que el nombre no exista en la base de datos.");
            }
        }

        public void ImprimirPorCod(DataGridView dgvGrilla, string cod)
        {
            try
            {
                using (conexion = new OleDbConnection(cadena))
                {
                    comando = new OleDbCommand();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;

                    comando.CommandText = "SELECT Objetos.Id, Objetos.Nombre, Objetos.Precio, Objetos.Cantidad, Objetos.Descripcion, Categorias.Categoria " +
                                          "FROM Categorias INNER JOIN Objetos ON Categorias.Id = Objetos.Categoria WHERE Objetos.Id = @id";

                    comando.Parameters.AddWithValue("@id", cod);
                    DataTable tablaUsuarios = new DataTable();

                    adaptador = new OleDbDataAdapter(comando);
                    conexion.Open();
                    adaptador.Fill(tablaUsuarios);

                    dgvGrilla.DataSource = tablaUsuarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + "Es probable que el código no exista en la base de datos.");
            }
        }

        public void ImprimirPorCat(DataGridView dgvGrilla, string cat)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;


                comando.CommandText = "SELECT Objetos.Nombre, Objetos.Cantidad, Objetos.Descripcion, Objetos.Precio, Categorias.Categoria " +
                "FROM Categorias INNER JOIN Objetos ON Categorias.Id = Objetos.Categoria WHERE Categorias.Categoria = @cat";
                comando.Parameters.AddWithValue("@cat", cat);

                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvGrilla.DataSource = tablaUsuarios;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + " Es probable que la categoría no exista en la base de datos.");
            }
        }


        public void CrearReporte(DataGridView dgv)
        {
            string nombreArchivo = "Reporte_Stock.txt";
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                sb.Append(columna.HeaderText + "\t");
            }
            sb.AppendLine();

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    sb.Append(celda.Value?.ToString() + "\t\t");
                }
                sb.AppendLine();
            }

            System.IO.File.WriteAllText(nombreArchivo, sb.ToString());
        }

        public void EliminarUsuario(string nom)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;


                comando.CommandText = "DELETE FROM Objetos WHERE Nombre = @nom";
                comando.Parameters.AddWithValue("@nom", nom);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + " Es posible que el nombre o apellido no exista en la base de datos.");
            }
        }

        public bool verificarNombre(string Nombre)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    
                    string query = "SELECT COUNT(*) FROM Objetos WHERE Nombre = @nombre";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", Nombre);
                        conexion.Open();

                        int contador = (int)comando.ExecuteScalar();
                        return contador > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario: " + ex.Message);
                return false;
            }
        }
    }
}
