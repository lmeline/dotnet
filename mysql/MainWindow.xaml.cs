using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace mysql
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connect();
        }

        private void Connect()
        {
            //MessageBox.Show("Connexion à la bdd");
            string connexionString = "server=localhost;database=patte_a_patte;uid=root;password=;";
            MySqlConnection connexion = new MySqlConnection(connexionString);
            try
            {
                connexion.Open();
                MessageBox.Show("Base de données ouverte");
                connexion.Close();
            }
            catch(Exception e) {
                throw new Exception("Erreur à l'ouverture de la bdd:" +e.Message);
            }

        }
    }
}