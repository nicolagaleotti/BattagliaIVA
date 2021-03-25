using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibreriaBattagliaIVA;

namespace WpfBattagliaIVA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string[] razze = new string[] { "Uomini", "Elfi", "Maghi", "Troll", "Orchi", "Stregoni" };
        List<Personaggio> personaggi = new List<Personaggio>();
        Razza[] razzeRazza = new Razza[] { Uomini.Istanza, Elfi.Istanza, Maghi.Istanza, Troll.Istanza, Orchi.Istanza, Stregoni.Istanza };

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    throw new Exception("Inserire un nome!");
                }
                if (cmbRazza.SelectedIndex == -1)
                {
                    throw new Exception("Selezionare una razza!");
                }
                int i = cmbRazza.SelectedIndex;
                Personaggio p = new Personaggio(txtNome.Text, razzeRazza[i]);
                lbNuovoPersonaggio.Items.Add($"Personaggio '{p.Nome} [{p.Razza}]' creato.");
                txtNome.Text = "";
                cmbRazza.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRazza_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string s in razze)
                cmbRazza.Items.Add(s);
        }
    }
}
