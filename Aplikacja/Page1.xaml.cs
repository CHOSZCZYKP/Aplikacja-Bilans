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
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Data;
using System.Security.Cryptography.X509Certificates;


namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        
        public Page1()
        {
            InitializeComponent();
            LoadKonta();
            UpdateComboBox();
            LoadComboBoxKont();
        }

        private void LoadComboBoxKont()
        {
            List<string> listaKontNieutworzonych = new List<string>
            {
                "Koszty zakończonych prac rozwojowych", 
                "Wartość firmy", 
                "Inne wartości niematerialne i prawne",
                "Zaliczki na wartości niematerialne i prawne",

                "Grunty (w tym prawo użytkowania wieczystego gruntu)",
                "Budynki, lokale, prawa do lokali i obiekty inżynierii lądowej i wodnej",
                "Urządzenia techniczne i maszyny",
                "Środki transportu",
                "Inne środki trwałe",

                "Środki trwałe w budowie",
                "Zaliczki na środki trwałe w budowie",

                "Należności długoterminowe Od jednostek powiązanych",
                "Należności długoterminowe Od pozostałych jednostek, w których jednostka posiada zaangażowanie w kapitale",
                "Należności długoterminowe Od pozostałych jednostek",

                "Nieruchomości",
                "Inwestycje długoterminowe wartości niematerilane i prawne",
                "Długoterminowe aktywa finansowe w jednostkach powiązanych udziały lub akcje",
                "Długoterminowe aktywa finansowe w jednostkach powiązanych inne papiery wartościowe",
                "Długoterminowe aktywa finansowe w jednostkach powiązanych udzielone pożyczki",
                "Długoterminowe aktywa finansowe w jednostkach powiązanych inne długoterminowe aktywa finansowe",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale udziały lub akcje",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale inne papiery wartościowe",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale udzielone pożyczki",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale inne długoterminowe aktywa finansowe",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach udziały lub akcje",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach inne papiery wartościowe",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach udzielone pożyczki",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach inne długoterminowe aktywa finansowe",
                "Inne inwestycje długoterminowe",

                "Aktywa z tytułu odroczonego podatku dochodowego",
                "Inne rozliczenia międzyokresowe",

                "Materiały",
                "Półprodukty i produkty w toku",
                "Produkty gotowe",
                "Towary",
                "Zaliczki na dostawy i usługi",

                "Należności od jednostek powiązanych z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od jednostek powiązanych z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy",
                "Należności od jednostek powiązanych inne",
                "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy",
                "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale inne",
                "Należności od pozostałych jednostek z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od pozostałych jednostek z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy",
                "Należności od pozostałych jednostek z tytułu podatków dotacji ceł ubezpieczeń społecznych i zdrowotnych oraz innych tytułów publicznoprawnych",
                "Należności od pozostałych jednostek inne",
                "Należności od pozostałych jednostek dochodzone na drodze sądowej",

                "Któtkoterminowe aktywa finansowe w jednostakch powiązanych udziały lub akcje",
                "Któtkoterminowe aktywa finansowe w jednostakch powiązanych inne papiery wartościowe",
                "Któtkoterminowe aktywa finansowe w jednostakch powiązanych udzielone pożyczki",
                "Któtkoterminowe aktywa finansowe w jednostakch powiązanych inne którkoterminowe aktywa finansowe",
                "Któtkoterminowe aktywa finansowe w pozostałych jednostkach udziały lub akcje",
                "Któtkoterminowe aktywa finansowe w pozostałych jednostkach inne papiery wartościowe",
                "Któtkoterminowe aktywa finansowe w pozostałych jednostkach udzielone pożyczki",
                "Któtkoterminowe aktywa finansowe w pozostałych jednostkach inne krótkoterminowe aktywa finansowe",

                "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne środki pieniężne w kasie i na rachunkach",
                "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne inne środki pieniężne",
                "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne inne aktywa pieniężne",
                "Inne inwestycje krótkoterminowe",
                "Krótkterminowe rozliczenia międzyokresowe",
                "Należne wpłaty na kapitał (fundusz) podstawowy",
                "Udziały (akcje) własne",

                //Nazwy kont pasywnych
                "Kapitał (fundusz) podstawowy",
                "Kapitał (fundusz) zapasowy w tym",
                "Kapitał (fundusz) zapasowy w tym nadwyżka wartości sprzedaży (wartości emisyjnej) nad wartością nominalną udziałów (akcji)",
                "Kapitał (fundusz) z aktualizacji wyceny w tym",
                "Kapitał (fundusz) z aktualizacji wyceny w tym z tytułu aktualizacji wartości godziwej",
                "Pozostałe kapitały (fundusze) rezerwowe w tym",
                "Pozostałe kapitały (fundusze) rezerwowe w tym tworzone zgodnie z umową (statusem) spółki",
                "Pozostałe kapitały (fundusze) rezerwowe w tym na udziały (akcje) własne",
                "Zysk (strata) z lat ubiegłych",
                "Zysk (strata) netto",
                "Odpisy z zysku netto w ciągu roku obrotowego (wielkość ujemna)",

                "Rezerwa na zobowiązania rezerwa z tytułu odroczonego podatku dochodowego",
                "Rezerwa na zobowiązania rezerwa na świadczenia emerytalne i podobne długoterminowa",
                "Rezerwa na zobowiązania rezerwa na świadczenia emerytalne i podobne krótkoterminowa",
                "Rezerwa na zobowiązania pozostałe rezerwy długoterminowe",
                "Rezerwa na zobowiązania pozostałe rezerwy krótkoterminowe",

                "Zobowiązania długoterminowe wobec jednostek powiązanych",
                "Zobowiązania długoterminowe wobec pozostałych jednostek w których jednostak posiada zaangażowanie w kapitale",
                "Zobowiązania długoterminowe wobec pozostałych jednostek kredyty i pożyczki",
                "Zobowiązania długoterminowe wobec pozostałych jednostek z tytułu emisji dłużnych papierów wartościowych",
                "Zobowiązania długoterminowe wobec pozostałych jednostek inne zobowiązania finansowe",
                "Zobowiązania długoterminowe wobec pozostałych jednostek zobowiązania wekselowe",
                "Zobowiązania długoterminowe wobec pozostałych jednostek inne",

                "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych inne",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale inne",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek kredyty i pożyczki",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu emisji dłużnych papierów wartościowych",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek inne zobowiązania finansowe",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek zaliczki otrzymane na dostawy i usługi",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek zobowiązania wekselowe",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu podatków ceł ubezpieczeńspołecznych i zdrowotnych oraz innych tytułów publicznoprawnych",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu wynagrodzeń",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek inne",
                "Zobowiązania krótkoterminowe fundusze specjalne",

                "Rozliczenia międzyokresowe ujemna wartość firmy",
                "Rozliczenia międzyokresowe inne rozliczenia międzyokresowe długoterminowe",
                "Rozliczenia międzyokresowe inne rozliczenia międzyokresowe krótkoterminowe"
            };
            listaKontNieutworzonych.Sort();
            combobox_dodaj_konto.ItemsSource = listaKontNieutworzonych;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string podlaczenieBilansowe = combobox_dodaj_konto.Text;
            string nazwaKonta = TextBoxNazwa_konta.Text;
            if (!string.IsNullOrEmpty(nazwaKonta) && !string.IsNullOrEmpty(podlaczenieBilansowe))
            {
                Konto konto = new Konto(nazwaKonta, podlaczenieBilansowe);
                GetKonta().Add(konto);
                SaveKonta();
                UpdateComboBox();
                TextBoxNazwa_konta.Clear();
                combobox_dodaj_konto.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Nie podano nawzy konta lub nie wybrano gdzie podłączyć konto!", "Błąd dodawania konta", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void DodajOperacje(object sender, RoutedEventArgs e)
        {
            
            if (DT_wartosc_konta_1.Text != CT_wartosc_konta_2.Text && CheckSaldo.IsChecked == false)
            {
                MessageBox.Show("Wartości kont po stronie debetowej i kredytowej są różne", "Błąd wartości kont", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (DT_wartosc_konta_2.Text != CT_wartosc_konta_1.Text && CheckSaldo.IsChecked == false)
            {
                MessageBox.Show("Wartości kont po stronie debetowej i kredytowej są różne", "Błąd wartości kont", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (combobox_konta.SelectedItem == null)
                MessageBox.Show("Nie wybrano pierwszego konta!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (combobox_konta1.SelectedItem == null && CheckSaldo.IsChecked == false)
                MessageBox.Show("Nie wybrano drugiego konta!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (!DataDatePicker.SelectedDate.HasValue)
                MessageBox.Show("Wprowadź datę!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (string.IsNullOrEmpty(numer_operacji.Text))
                MessageBox.Show("Wprowadź numer operacji!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (!string.IsNullOrEmpty(DT_wartosc_konta_1.Text) && !string.IsNullOrEmpty(CT_wartosc_konta_1.Text) && CheckSaldo.IsChecked == true)
                MessageBox.Show("Musisz wybrać po której stronie chcesz wprowadzić saldo początkowe!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                if (combobox_konta.SelectedItem is Konto konto)
                {
                    if (double.TryParse(DT_wartosc_konta_1.Text, out double kwota)
                        && DataDatePicker.SelectedDate.HasValue && !string.IsNullOrEmpty(numer_operacji.Text))
                    {
                        
                        var czasOperacji = DataDatePicker.SelectedDate.Value;
                        
                        Operacja operacja = new Operacja(czasOperacji, kwota, numer_operacji.Text);

                        konto.DodajDoKontaDT(operacja);

                    }

                    if (double.TryParse(CT_wartosc_konta_1.Text, out double kwota1)
                        && DataDatePicker.SelectedDate.HasValue && !string.IsNullOrEmpty(numer_operacji.Text))
                    {
                        var czasOperacji = DataDatePicker.SelectedDate.Value;
                        if (konto.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne środki pieniężne w kasie i na rachunkach")
                        {
                            double StanKonta = konto.SumaSaldKoncowychDT(czasOperacji) - konto.SumaSaldKoncowychCT(czasOperacji);
                            if (StanKonta < kwota1)
                            {
                                MessageBox.Show("Nie można wykonać tej operacji ponieważ nie ma wystarczających środków na koncie!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }
                        }
                        
                        Operacja operacja = new Operacja(czasOperacji, kwota1, numer_operacji.Text);

                        konto.DodajDoKontaCT(operacja);

                    }

                }
                if (combobox_konta1.SelectedItem is Konto konto2)
                {
                    if (double.TryParse(DT_wartosc_konta_2.Text, out double kwota3)
                        && DataDatePicker.SelectedDate.HasValue && !string.IsNullOrEmpty(numer_operacji.Text))
                    {
                        var czasOperacji = DataDatePicker.SelectedDate.Value;
                        
                        Operacja operacja = new Operacja(czasOperacji, kwota3, numer_operacji.Text);

                        konto2.DodajDoKontaDT(operacja);

                    }

                    if (double.TryParse(CT_wartosc_konta_2.Text, out double kwota4)
                        && DataDatePicker.SelectedDate.HasValue && !string.IsNullOrEmpty(numer_operacji.Text))
                    {
                        var czasOperacji = DataDatePicker.SelectedDate.Value;
                        if (konto2.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne środki pieniężne w kasie i na rachunkach")
                        {
                            double StanKonta = konto2.SumaSaldKoncowychDT(czasOperacji) - konto2.SumaSaldKoncowychCT(czasOperacji);
                            if (StanKonta < kwota4)
                            {
                                MessageBox.Show("Nie można wykonać tej operacji ponieważ nie ma wystarczających środków na koncie!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }
                        }
                        
                        Operacja operacja = new Operacja(czasOperacji, kwota4, numer_operacji.Text);

                        konto2.DodajDoKontaCT(operacja);
                    }

                }
                SaveKonta();
                ClearInputFields();
            }
            
        }
        private void ClearInputFields()
        {
            DT_wartosc_konta_1.Clear();
            CT_wartosc_konta_1.Clear();
            DT_wartosc_konta_2.Clear();
            CT_wartosc_konta_2.Clear();
            numer_operacji.Clear();
            DataDatePicker.SelectedDate = null;
        }

        private List<Konto> GetKonta()
        {
            var app = Application.Current as App;
            return app?.Konta;
        }

        private void UpdateComboBox()
        {
            var konta = GetKonta();
            combobox_konta.Items.Clear();
            combobox_konta1.Items.Clear();
            foreach (var konto in konta)
            {
                combobox_konta.Items.Add(konto);
                combobox_konta1.Items.Add(konto);
            }
        }

        private void SaveKonta()
        {
            var konta = GetKonta();
            string json = KontoSerializer.Serialize(konta);
            Properties.Settings.Default.combo = json;
            Properties.Settings.Default.Save();
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

        private void UsunKonta_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz wyczyścić listę kont?","Potwierdzenie", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                ((App)Application.Current).Konta.Clear();
                UpdateComboBox();
            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("Operacja anulowana", "Anulowano", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            DT_wartosc_konta_2.IsEnabled = false;
            CT_wartosc_konta_2.IsEnabled = false;
            combobox_konta1.IsEnabled = false;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DT_wartosc_konta_2.IsEnabled = true;
            CT_wartosc_konta_2.IsEnabled = true;
            combobox_konta1.IsEnabled = true;
        }
    }
}
