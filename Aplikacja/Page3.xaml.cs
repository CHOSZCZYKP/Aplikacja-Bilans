using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// Logika interakcji dla klasy Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            LoadKonta();
            UpdateComboBox();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (kontoHistoria.SelectedItem is Konto wybraneKonto)
            {
                listaDT.Items.Clear();
                listaCT.Items.Clear();
                
                //MessageBox.Show($"DT Count: {wybraneKonto.DT.Count}, CT Count: {wybraneKonto.CT.Count}");
                foreach (var item in wybraneKonto.DT)
                {
                    listaDT.Items.Add(new 
                    {
                        dataOperacji = item.Czas_operacji,
                        kwotaOperacji = item.Kwota,
                        opisOperacji = item.NrOperacji
                    });
                    
                }

                foreach (var item in wybraneKonto.CT)
                {
                    listaCT.Items.Add(new
                    {
                        dataOperacji = item.Czas_operacji,
                        kwotaOperacji = item.Kwota,
                        opisOperacji = item.NrOperacji
                    });
                    
                }
            }
        }
        
        private List<Konto> GetKonta()
        {
            var app = Application.Current as App;
            return app?.Konta;
        }
        private void UpdateComboBox()
        {
            var konta = GetKonta();
            kontoHistoria.Items.Clear();
            foreach (var konto in konta)
            {
                kontoHistoria.Items.Add(konto);
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
