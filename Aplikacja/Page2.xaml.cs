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

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            LoadKonta();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DataPickerPage2.SelectedDate.HasValue)
                {
                    Bilans bilans = new Bilans();
                    
                    
                    bilans.WyliczanieZbiorowAktywnych(DataPickerPage2.SelectedDate.Value);
                    bilans.WczytanieWylicznoychDanychAktywow();

                    bilans.WyliczanieZbiorowPasywnych(DataPickerPage2.SelectedDate.Value);
                    bilans.WczytanieWyliczonychDanychPasywnych();
                    
                    listaAktywow.ItemsSource = bilans.WynikiKontAktywnych;
                    listaPasywow.ItemsSource = bilans.WynikiKontPasywnych;
                    if (bilans.CzyAktywaRownePasywom())
                    {
                        MessageBox.Show("AKTYWA nie są równe PASYWOM!!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                    MessageBox.Show("Wybierz jakąś datę!", "Brak daty.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButton.OK , MessageBoxImage.Error);
            }
        }
        private void LoadKonta()
        {
            string json = Properties.Settings.Default.combo;
            if (!string.IsNullOrEmpty(json))
            {
                var konta = KontoSerializer.Deserialize(json);
                var app = Application.Current as App;
                app.Konta = konta;
            }
        }

    }
}
