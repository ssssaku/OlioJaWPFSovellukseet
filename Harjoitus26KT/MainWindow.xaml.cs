using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;

namespace Harjoitus26KT
{
    public partial class MainWindow : Window
    {
        List<Tehtava> tehtavat = new List<Tehtava>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LisaaTehtava_Click(object sender, RoutedEventArgs e)
        {
            string tehtavaNimi = TehtavaKentta.Text;

            if (!string.IsNullOrWhiteSpace(tehtavaNimi))
            {
                Tehtava uusiTehtava = new Tehtava(tehtavaNimi);
                tehtavat.Add(uusiTehtava);
                PaivitaTehtavaLista();
                TehtavaKentta.Clear();
            }
            else
            {
                MessageBox.Show("Tehtävän nimi ei voi olla tyhjä.");
            }
        }

        private void MuokkaaTehtavanTilaa_Click(object sender, RoutedEventArgs e)
        {
            if (TehtavaLista.SelectedItem is Tehtava valittuTehtava)
            {
                valittuTehtava.SeuraavaTila();
                PaivitaTehtavaLista();
            }
            else
            {
                MessageBox.Show("Valitse ensin tehtävä, jonka tilaa haluat muokata.");
            }
        }

        private void PoistaTehtava_Click(object sender, RoutedEventArgs e)
        {
            if (TehtavaLista.SelectedItem is Tehtava valittuTehtava)
            {
                tehtavat.Remove(valittuTehtava);
                PaivitaTehtavaLista();
            }
            else
            {
                MessageBox.Show("Valitse ensin tehtävä, jonka haluat poistaa.");
            }
        }

        private void PaivitaTehtavaLista()
        {
            TehtavaLista.Items.Clear();
            foreach (var tehtava in tehtavat)
            {
                TehtavaLista.Items.Add(tehtava);
            }
        }
    }

    public class Tehtava
    {
        public string Nimi { get; set; }
        public TehtavanTila Tila { get; set; }

        public Tehtava(string nimi)
        {
            Nimi = nimi;
            Tila = TehtavanTila.Tekematta;
        }

        public void SeuraavaTila()
        {
            switch (Tila)
            {
                case TehtavanTila.Tekematta:
                    Tila = TehtavanTila.TyonAlla;
                    break;
                case TehtavanTila.TyonAlla:
                    Tila = TehtavanTila.Suoritettu;
                    break;
                case TehtavanTila.Suoritettu:
                    Tila = TehtavanTila.Tekematta;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Nimi} - {Tila}";
        }
    }

    public enum TehtavanTila
    {
        Tekematta,
        TyonAlla,
        Suoritettu
    }
}