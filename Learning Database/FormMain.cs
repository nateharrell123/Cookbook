using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; // also needed 
using System.Data.SqlClient; // needed for SQL
using System.Net.NetworkInformation;

namespace Learning_Database
{
    public partial class FormMain : Form
    {
        SqlConnection connection; // needed to connect to SQL
        string connectionString; // information on where database is, how to connect, what credentials, etc.
        public FormMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Learning_Database.Properties.Settings.CookbookConnectionString"].ConnectionString; // name comes from App.config 
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateRecipies();
            PopulateAllIngredients();
        }

        /// <summary>
        /// Fills the 'lstRecipies' box with data from our database.
        /// </summary>
        private void PopulateRecipies()
        {
            // connection implements IDisposible, so we don't need to call 'connection.Close()'. It will do that for us.
            using (connection = new SqlConnection(connectionString)) // connection is used for opening and closing connection.
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipie", connection))
            {
                // SqlDataAdapter takes care of calling 'connection.Open()' and because it implements IDisposible, it will '.close()' for us.

                // Holds data in this object returned from Query (ran from 'adapter').
                DataTable recipieTable = new DataTable();
                adapter.Fill(recipieTable); // Fill the recipieTable with the results from Query ran from 'adapter'.

                lstRecipies.DisplayMember = "Name";
                lstRecipies.ValueMember = "Id";
                lstRecipies.DataSource = recipieTable; // hook up listbox to data in recipietable
            }
        }

        private void PopulateAllIngredients()
        {
            // connection implements IDisposible, so we don't need to call 'connection.Close()'. It will do that for us.
            using (connection = new SqlConnection(connectionString)) // connection is used for opening and closing connection.
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ingredient", connection))
            {
                // SqlDataAdapter takes care of calling 'connection.Open()' and because it implements IDisposible, it will '.close()' for us.

                // Holds data in this object returned from Query (ran from 'adapter').
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable); // Fill the recipieTable with the results from Query ran from 'adapter'.

                lstAllIngredients.DisplayMember = "Name";
                lstAllIngredients.ValueMember = "Id";
                lstAllIngredients.DataSource = ingredientTable; // hook up listbox to data in recipietable
            }
        }

        private void PopulateIngredients()
        {
            string query = "SELECT a.Name FROM Ingredient a " +
                "INNER JOIN RecipieIngredient b ON a.Id = b.IngredientId " +
                "WHERE b.RecipieId = @RecipieId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection)) // another form of handling select query, supports params.
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("RecipieID", lstRecipies.SelectedValue); // whatever recipie is selcted in the listbox, get value of that, and pass it into this query. returns ingredients tied to that recipie.
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable); 

                lstIngredients.DisplayMember = "Name";
                lstIngredients.ValueMember = "Id";
                lstIngredients.DataSource = ingredientTable; 
            }
        }


        /// <summary>
        /// When selected index of Recipie List changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstRecipies_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredients();
        }

        private void btnAddRecipie_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipie VALUES (@RecipieName, 80, 'blah blah')";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection)) 
            {
                connection.Open();
                command.Parameters.AddWithValue("RecipieName", txtRecipieName.Text);
                command.ExecuteNonQuery();
            }

            PopulateRecipies();
        }

        private void btnUpdateRecipieName_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipie SET Name = @RecipieName WHERE Id = @RecipieId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("RecipieName", txtRecipieName.Text);
                command.Parameters.AddWithValue("@RecipieId", lstRecipies.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateRecipies();
        }

        private void btnAddToRecipie_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipieIngredient VALUES (@RecipieId, @IngredientId)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("RecipieId",lstRecipies.SelectedValue);
                command.Parameters.AddWithValue("IngredientId", lstAllIngredients.SelectedValue);

                command.ExecuteNonQuery();
            }

            PopulateRecipies();
        }
    }
}
