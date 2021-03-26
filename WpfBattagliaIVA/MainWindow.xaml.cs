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

        List<Personaggio> personaggi = new List<Personaggio>();
        Razza[] razze = new Razza[] { Uomini.Istanza, Elfi.Istanza, Maghi.Istanza, Troll.Istanza, Orchi.Istanza, Stregoni.Istanza };

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

                Personaggio p = new Personaggio(txtNome.Text, razze[i]);
                personaggi.Add(p);

                lbNuovoPersonaggio.Items.Add($"Personaggio '{p.Nome} [{p.Razza}]' creato.");

                cmbAttaccante.Items.Add($"{p.Nome} [{p.Razza}] [{p.Razza.Squadra}]");
                cmbDifendente.Items.Add($"{p.Nome} [{p.Razza}] [{p.Razza.Squadra}]");

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
            foreach (Razza r in razze)
                cmbRazza.Items.Add($"{r} [{r.Squadra}]");
        }

        private void btnCombatti_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbAttaccante.SelectedIndex == -1)
                {
                    throw new Exception("Selezionare un attaccante!");
                }
                if (cmbDifendente.SelectedIndex == -1)
                {
                    throw new Exception("Selezionare un difendente!");
                }

                Personaggio p1 = personaggi[cmbAttaccante.SelectedIndex];
                Personaggio p2 = personaggi[cmbDifendente.SelectedIndex];

                bool battaglia = p1.Attacca(p2);

                lbBattaglia.Items.Add($"{p1.Nome} attacca {p2.Nome}. Vince: {Vincitore(p1, p2, battaglia)}.\n" +
                                      $"| {p1.Nome}: {p1.Vita}; {p1.Esperienza} | - | {p2.Nome}: {p2.Vita}; {p2.Esperienza} |");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string Vincitore(Personaggio p1, Personaggio p2, bool vittoria)
        {
            if (vittoria == true)
                return p1.Nome;
            else return p2.Nome;
        }
    }
}
