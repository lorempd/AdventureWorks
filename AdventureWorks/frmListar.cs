using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AdventureWorks
{
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            // Conexión 
            string conn = @"server = (local)\SQLEXPRESS; database = AdventureWorks2014;
                integrated security = true;";

            // Query
            string sql = @"SELECT * FROM HumanResources.Department";


            // Crear la conexión
            SqlConnection connection = new SqlConnection(conn);


            try
            {
                // Establecer conexión
                connection.Open();

                // crear DataAdapter
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                // crear DataSet
                DataSet ds = new DataSet();

                // popular (llenar) el DataSet
                da.Fill(ds, "HumanResources.Department");

                gvDepartamentos.DataSource = ds.Tables["HumanResources.Department"];
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles");

            }
            finally
            {
                //cerrar la conexion
                connection.Close();
            }
        }
    }
}
