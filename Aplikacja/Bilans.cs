using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace Aplikacja
{
    internal class Bilans
    {   
        public List<Konto> listaKontWBilansie;
        public List<WynikKonta> WynikiKontAktywnych;
        public List<WynikKonta> WynikiKontPasywnych;
        

        public double AktywaTrwaleB, AktywaTrwaleP;
        public double WartosciNiematerialneIPrawneB, WartosciNiematerialneIPrawneP;
        public double RzeczoweAktywaTrwaleB, RzeczoweAktywaTrwaleP;
        public double SrodkiTrwaleB, SrodkiTrwaleP;
        public double NaleznosciDlugoterminoweB, NaleznosciDlugoterminoweP;

        public double KosztZakonczonychPracRozwojowychB, KosztZakonczonychPracRozwojowychP;
        public double WartoscFirmyB, WartoscFirmyP;
        public double InneWartosciNiematerialneIPrawneB, InneWartosciNieMaterialneIPrawneP;
        public double ZaliczkiNaWartosciNiematerilaneIPrawneB, ZaliczkiNaWartosciNiematerialneIPrawneP;

        public double GruntyWTymPrawoUzytkowaniaWieczystegoGruntuB, GruntyWTymPrawoUzytkowaniaWieczystegoGruntuP;
        public double BudynkiLokalePrawaDoLokaliIObiektyInzynieriLadawejIWodnejB, BudynkiLokalePrawaDoLokaliIObiektyInzynieriLadawejIWodnejP;
        public double UrzadzeniaTechniczneIMaszynyB, UrzadzeniaTechniczneIMaszynyP;
        public double SrodkiTransportuB, SrodkiTransportuP;
        public double InneSrodkiTrwaleB, InneSrodkiTrwaleP;
        public double SrodkiTrwaleWBudowieB, SrodkiTrwaleWBudowieP;
        public double ZaliczkiNaSrodkitrwaleWBudowieB, ZaliczkiNaSrodkitrwaleWBudowieP;

        public double OdJednostekPowiazanychB, OdJednostekPowiazanychP;
        public double OdPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB, OdPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP;
        public double OdPozostalychJednostekB, OdPozostalychJednostekP;

        public double InwestycjeDlugoterminoweB, InwestycjeDlugoterminoweP;
        public double NieruchomosciB, NieruchomosciP;
        public double InwestycjeDlugoterminoweWartosciNiematerialneIPrawneB, InwestycjeDlugoterminoweWartosciNiematerialneIPrawneP;
        public double DlugoterminoweAktywaFinansoweB, DlugoterminoweAktywaFinansoweP;
        public double DlugoterminoweAktywaFinansoweWJednostkachPowiazanychB, DlugoterminoweAktywaFinansoweWJednostkachPowiazanychP;
        public double DlugotermnoweAktywaFinansoweWJednostakchPowiazanychUdzialyLubAkcjeB, DlugotermnoweAktywaFinansoweWJednostakchPowiazanychUdzialyLubAkcjeP;
        public double DlugotermnoweAktywaFinansoweWJednostakchPowiazanychInneParpieryWartoscioweB, DlugotermnoweAktywaFinansoweWJednostakchPowiazanychInneParpieryWartoscioweP;
        public double DlugoterminoweAktywaFinansoweWJednostkachPowiazanychUdzielonePozyczkiB, DlugoterminoweAktywaFinansoweWJednostkachPowiazanychUdzielonePozyczkiP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleP;
        public double DlugoterminoweAktywaFinansoweWJednostkachPowiazanychInneDlugoterminoweAktywaFinansoweB, DlugoterminoweAktywaFinansoweWJednostkachPowiazanychInneDlugoterminoweAktywaFinansoweP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzialyLubAkcjeB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzialyLubAkcjeP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneParpieryWartoscioweB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneParpieryWartoscioweP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzielonePozyczkiB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzielonePozyczkiP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneDlugoterminoweAktywaFinansoweB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneDlugoterminoweAktywaFinansoweP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachInnePapieryWartoscioweB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachInnePapieryWartoscioweP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzielonePozyczkiB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzielonePozyczkiP;
        public double DlugoterminoweAktywaFinansoweWPozostalychJednostkachInneDlugoterminoweAktywaFinansoweB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachInneDlugoterminoweAktywaFinansoweP;
        public double InneInwestycjeDlugoterminoweB, InneInwestycjeDlugoterminoweP;

        public double DlugoterminoweRozliczeniaMiedzyokresoweB, DlugoterminoweRozliczeniaMiedzyokresoweP;
        public double AktywaZTytuluOdroczonegoPodatkuDochodowegoB, AktywaZTytuluOdroczonegoPodatkuDochodowegoP;
        public double InneRozliczeniaMiedzyokresoweB, InneRozliczeniaMiedzyokresoweP;

        public double AktywaObrotoweB, AktywaObrotoweP;
        public double ZapasyB, ZapasyP;
        public double MaterialyB, MaterialyP;
        public double PolproduktyIProduktyWTokuB, PolproduktyIProduktyWTokuP;
        public double ProduktyGotoweB, ProduktyGotoweP;
        public double TowaryB, TowaryP;
        public double ZaliczkiNaDostawyIUslugiB, ZaliczkiNaDostawyIUslugiP;

        public double NaleznosciKrotkoterminoweB, NaleznosciKrotkoterminoweP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychInneB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychInneP;

        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP;
        public double NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleInneB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleInneP;
        
        public double NaleznosicOdPozostalychJednostekB, NaleznosicOdPozostalychJednostekP;
        public double NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyB, NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyP;
        public double NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB, NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP;
        public double NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB, NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP;
        public double NaleznosicOdPozostalychJednostekZTytuluPodatkowDotacjiCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoprawnychB, NaleznosicOdPozostalychJednostekZTytuluPodatkowDotacjiCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoprawnychP;
        public double NaleznosicOdPozostalychJednostekInneB, NaleznosicOdPozostalychJednostekInneP;
        public double NaleznosicOdPozostalychJednostekDochodzoneNaDrodzeSadawejB, NaleznosicOdPozostalychJednostekDochodzoneNaDrodzeSadawejP;

        public double InwestycjeKrotkoterminoweB, InwestycjeKrotkoterminoweP;
        public double KrotkoterminoweAktywaFinansoweB, KrotkoterminoweAktywaFinansoweP;
        public double KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychP;
        public double KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzialyLubAkcjeB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzialyLubAkcjeP;
        public double KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInnePapiryWartoscioweB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInnePapiryWartoscioweP;
        public double KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzilonePozyczkiB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzilonePozyczkiP;
        public double KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInneKrotkoterminoweAKtywaFinansoweB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInneKrotkoterminoweAKtywaFinansoweP;

        public double KrotkoterminoweAktywaFinansoweWPozostalychJednostkachB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachP;
        public double KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeP;
        public double KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInnePapiryWartoscioweB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInnePapiryWartoscioweP;
        public double KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzilonePozyczkiB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzilonePozyczkiP;
        public double KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInneKrotkoterminoweAKtywaFinansoweB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInneKrotkoterminoweAKtywaFinansoweP;

        public double KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneB, KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneP;
        public double KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneSrodkiPieniezneWKasieINaRachunkuB, KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneSrodkiPieniezneWKasieINaRachunkuP;
        public double KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneSrodkiPieniezneB, KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneSrodkiPieniezneP;
        public double KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneAKtywaPieniezneB, KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneAKtywaPieniezneP;
        
        public double InneInwestycjeKrotkoterminoweB, InneInwestycjeKrotkoterminoweP;
        public double KrotkoterminoweRozliczeniaMiedzyokresoweB, KrotkoterminoweRozliczeniaMiedzyokresoweP;
        public double NalezneWplatyNaKapitalFunduszPodstawowyB, NalezneWplatyNaKapitalFunduszPodstawowyP;
        public double UdzialyAkcjeWlasneB, UdzialyAkcjeWlasneP;
        public double AktywaRazemB, AktywaRazemP;


        //Pasywa
        public double KapitalFunduszWlasnyB, KapitalFunduszWlasnyP;

        public double KapitalFunduszPodstawowyB, KapitalFunduszPodstawowyP;

        public double KapitalFunduszZapasowyWTymB, KapitalFunduszZapasowyWTymP;
        public double KapitalFunduszZapasowyWTymNadwyzkawartosciSprzedazyWartosciEmisyjnejNadWartosciaNominalnaUdzialowAkcjiB, KapitalFunduszZapasowyWTymNadwyzkawartosciSprzedazyWartosciEmisyjnejNadWartosciaNominalnaUdzialowAkcjiP;

        public double KapitalFunduszZAktualizacjiWycentyWTymB, KapitalFunduszZAktualizacjiWycentyWTymP;
        public double KapitalFunduszZAktualizacjiWycentyWTymZTytuluAktualizacjiWartosciGodziwejB, KapitalFunduszZAktualizacjiWycentyWTymZTytuluAktualizacjiWartosciGodziwejP;

        public double PozostaleKapitalyFunduszeRezerwoweWTymB, PozostaleKapitalyFunduszeRezerwoweWTymP;
        public double PozostaleKapitalyFunduszeRezerwoweWTymTworzoneZgodnieZUmowaStatutemSpolkiB, PozostaleKapitalyFunduszeRezerwoweWTymTworzoneZgodnieZUmowaStatutemSpolkiP;
        public double PozostaleKapitalyFunduszeRezerwoweWTymNaUdzialyAkcjeWlasneB, PozostaleKapitalyFunduszeRezerwoweWTymNaUdzialyAkcjeWlasneP;

        public double ZyskStrataZLatUbieglychB, ZyskStrataZLatUbieglychP;

        public double ZyskStrataNettoB, ZyskStrataNettoP;

        public double OdpisyZZyskuNettoWCiaguRokuObrotowegoWielkoscUjemnaB, OdpisyZZyskuNettoWCiaguRokuObrotowegoWielkoscUjemnaP;

        public double ZobowiazaniaIRezerwyNaZobowiazaniaB, ZobowiazaniaIRezerwyNaZobowiazaniaP;

        public double RezerwyNaZobowiazaniaB, RezerwyNaZobowiazaniaP;
        public double RezerwaZTytuluOdroczonegoPodatkuDochodowegoB, RezerwaZTytuluOdroczonegoPodatkuDochodowegoP;
        public double RezerwaNaSwiadczeniaEmerytalneIPodobneB, RezerwaNaSwiadczeniaEmerytalneIPodobneP;
        public double RezerwaNaSwiadczeniaEmerytalneIPodobneDlugoterminowaB, RezerwaNaSwiadczeniaEmerytalneIPodobneDlugoterminowaP;
        public double RezerwaNaSwiadczeniaEmerytalneIPodobneKrotkoterminowaB, RezerwaNaSwiadczeniaEmerytalneIPodobneKrotkoterminowaP;
        public double PozostaleRezerwyB, PozostaleRezerwyP;
        public double PozostaleRezerwyDlugoterminoweB, PozostaleRezerwyDlugoterminoweP;
        public double PozostaleRezerwyKrotkoterminoweB, PozostaleRezerwyKrotkoterminoweP;

        public double ZobowiazaniaDlugoterminoweB, ZobowiazaniaDlugoterminoweP;
        public double ZobowiazaniaDlugoterminoweWobecJednostekPowiazanychB, ZobowiazaniaDlugoterminoweWobecJednostekPowiazanychP;
        public double ZobowiazaniaDlugoterminoweWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP;
        public double ZobowiazaniaDlugoterminoweWobecPozostalychJednostekB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekP;
        public double ZobowiazaniaDlugoterminoweWobecPozostalychJednostekKredytyIPozyczkiB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekKredytyIPozyczkiP;
        public double ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZTytuluEmisjiDluznychPapierowWartosciowychB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZTytuluEmisjiDluznychPapierowWartosciowychP;
        public double ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneZobowiazaniaFinansoweB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneZobowiazaniaFinansoweP;
        public double ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZobowiazaniaWekseloweB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZobowiazaniaWekseloweP;
        public double ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneP;

        public double ZobowiazaniaKrotkoterminoweB, ZobowiazaniaKrotkoterminoweP;

        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychInneB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychInneP;

        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneP;

        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekKredytyIPozyczkiB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekKredytyIPozyczkiP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluEmisjiDluznychPapierowWartosciowychB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluEmisjiDluznychPapierowWartosciowychP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneZobowiazaniaFinansoweB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneZobowiazaniaFinansoweP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZaliczkiOtrzymaneNaDostawyIUslugiB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZaliczkiOtrzymaneNaDostawyIUslugiP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZobowiazaniaWekseloweB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZobowiazaniaWekseloweP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluPodatkowCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoPrawnychB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluPodatkowCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoPrawnychP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluWynagrodzenB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluWynagrodzenP;
        public double ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneP;
       
        public double ZobowiazaniaKrotkoterminoweFunduszeSpecjalneB, ZobowiazaniaKrotkoterminoweFunduszeSpecjalneP;

        public double RozliczeniaMiedzyokresoweB, RozliczeniaMiedzyokresoweP;
        public double UjemnaWartoscFirmyB, UjemnaWartoscFirmyP;
        public double RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweB, RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweP;
        public double RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweDlugoterminoweB, RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweDlugoterminoweP;
        public double RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweKrotkoterminoweB, RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweKrotkoterminoweP;
        public double PasywaB, PasywaP;

        public Bilans()
        {
            this.WartosciNiematerialneIPrawneB = 0.0;
            this.WartosciNiematerialneIPrawneP = 0.0;
            this.AktywaTrwaleB = 0.0;
            this.AktywaTrwaleP = 0.0;
            this.RzeczoweAktywaTrwaleB = 0.0;
            this.RzeczoweAktywaTrwaleP = 0.0;
            this.SrodkiTrwaleB = 0.0;
            this.SrodkiTrwaleP = 0.0;
            this.NaleznosciDlugoterminoweB = 0.0;
            this.NaleznosciDlugoterminoweP = 0.0;
            this.KosztZakonczonychPracRozwojowychB = 0.0;
            this.KosztZakonczonychPracRozwojowychP = 0.0;
            this.WartoscFirmyB = 0.0;
            this.WartoscFirmyP = 0.0;
            this.InneWartosciNiematerialneIPrawneB = 0.0;
            this.InneWartosciNieMaterialneIPrawneP = 0.0;
            this.ZaliczkiNaWartosciNiematerilaneIPrawneB = 0.0;
            this.ZaliczkiNaWartosciNiematerialneIPrawneP = 0.0;
            this.GruntyWTymPrawoUzytkowaniaWieczystegoGruntuB = 0.0;
            this.GruntyWTymPrawoUzytkowaniaWieczystegoGruntuP = 0.0;
            this.BudynkiLokalePrawaDoLokaliIObiektyInzynieriLadawejIWodnejB = 0.0;
            this.BudynkiLokalePrawaDoLokaliIObiektyInzynieriLadawejIWodnejP = 0.0;
            this.UrzadzeniaTechniczneIMaszynyB = 0.0;
            this.UrzadzeniaTechniczneIMaszynyP = 0.0;
            this.SrodkiTransportuB = 0.0;
            this.SrodkiTransportuP = 0.0;
            this.InneSrodkiTrwaleB = 0.0;
            this.InneSrodkiTrwaleP = 0.0;
            this.SrodkiTrwaleWBudowieB = 0.0;
            this.SrodkiTrwaleWBudowieP = 0.0;
            this.ZaliczkiNaSrodkitrwaleWBudowieB = 0.0;
            this.ZaliczkiNaSrodkitrwaleWBudowieP = 0.0;

            this.OdJednostekPowiazanychB = 0.0;
            this.OdJednostekPowiazanychP = 0.0;
            this.OdPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB = 0.0;
            this.OdPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP = 0.0;
            this.OdPozostalychJednostekB = 0.0;
            this.OdPozostalychJednostekP = 0.0;

            //Od inwestycji długoterminoweych

            this.InwestycjeDlugoterminoweB = 0.0;
            this.InwestycjeDlugoterminoweP = 0.0;
            this.NieruchomosciB = 0.0;
            this.NieruchomosciP = 0.0;
            this.InwestycjeDlugoterminoweWartosciNiematerialneIPrawneB = 0.0;
            this.InwestycjeDlugoterminoweWartosciNiematerialneIPrawneP = 0.0;
            this.DlugoterminoweAktywaFinansoweB = 0.0;
            this.DlugoterminoweAktywaFinansoweP = 0.0;
            this.DlugoterminoweAktywaFinansoweWJednostkachPowiazanychB = 0.0;
            this.DlugoterminoweAktywaFinansoweWJednostkachPowiazanychP = 0.0;
            this.DlugotermnoweAktywaFinansoweWJednostakchPowiazanychUdzialyLubAkcjeB = 0.0;
            this.DlugotermnoweAktywaFinansoweWJednostakchPowiazanychUdzialyLubAkcjeP = 0.0;
            this.DlugotermnoweAktywaFinansoweWJednostakchPowiazanychInneParpieryWartoscioweB = 0.0;
            this.DlugotermnoweAktywaFinansoweWJednostakchPowiazanychInneParpieryWartoscioweP = 0.0;
            this.DlugoterminoweAktywaFinansoweWJednostkachPowiazanychUdzielonePozyczkiB = 0.0;
            this.DlugoterminoweAktywaFinansoweWJednostkachPowiazanychUdzielonePozyczkiP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleP = 0.0;
            this.DlugoterminoweAktywaFinansoweWJednostkachPowiazanychInneDlugoterminoweAktywaFinansoweB = 0.0;
            this.DlugoterminoweAktywaFinansoweWJednostkachPowiazanychInneDlugoterminoweAktywaFinansoweP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzialyLubAkcjeB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzialyLubAkcjeP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneParpieryWartoscioweB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneParpieryWartoscioweP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzielonePozyczkiB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzielonePozyczkiP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneDlugoterminoweAktywaFinansoweB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneDlugoterminoweAktywaFinansoweP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachInnePapieryWartoscioweB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachInnePapieryWartoscioweP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzielonePozyczkiB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzielonePozyczkiP = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachInneDlugoterminoweAktywaFinansoweB = 0.0;
            this.DlugoterminoweAktywaFinansoweWPozostalychJednostkachInneDlugoterminoweAktywaFinansoweP = 0.0;
            this.InneInwestycjeDlugoterminoweB = 0.0;
            this.InneInwestycjeDlugoterminoweP = 0.0;

            this.DlugoterminoweRozliczeniaMiedzyokresoweB = 0.0;
            this.DlugoterminoweRozliczeniaMiedzyokresoweP = 0.0;
            this.AktywaZTytuluOdroczonegoPodatkuDochodowegoB = 0.0;
            this.AktywaZTytuluOdroczonegoPodatkuDochodowegoP = 0.0;
            this.InneRozliczeniaMiedzyokresoweB = 0.0;
            this.InneRozliczeniaMiedzyokresoweP = 0.0;

            this.AktywaObrotoweB = 0.0;
            this.AktywaObrotoweP = 0.0;
            this.ZapasyB = 0.0;
            this.ZapasyP = 0.0;
            this.MaterialyB = 0.0;
            this.MaterialyP = 0.0;
            this.PolproduktyIProduktyWTokuB = 0.0;
            this.PolproduktyIProduktyWTokuP = 0.0;
            this.ProduktyGotoweB = 0.0;
            this.ProduktyGotoweP = 0.0;
            this.TowaryB = 0.0;
            this.TowaryP = 0.0;
            this.ZaliczkiNaDostawyIUslugiB = 0.0;
            this.ZaliczkiNaDostawyIUslugiP = 0.0;

            this.NaleznosciKrotkoterminoweB = 0.0;
            this.NaleznosciKrotkoterminoweP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychInneB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychInneP = 0.0;

            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleInneB = 0.0;
            this.NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleInneP = 0.0;

            this.NaleznosicOdPozostalychJednostekB = 0.0;
            this.NaleznosicOdPozostalychJednostekP = 0.0;
            this.NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyB = 0.0;
            this.NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyP = 0.0;
            this.NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB = 0.0;
            this.NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP = 0.0;
            this.NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB = 0.0;
            this.NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP = 0.0;
            this.NaleznosicOdPozostalychJednostekZTytuluPodatkowDotacjiCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoprawnychB = 0.0;
            this.NaleznosicOdPozostalychJednostekZTytuluPodatkowDotacjiCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoprawnychP = 0.0;
            this.NaleznosicOdPozostalychJednostekInneB = 0.0;
            this.NaleznosicOdPozostalychJednostekInneP = 0.0;
            this.NaleznosicOdPozostalychJednostekDochodzoneNaDrodzeSadawejB = 0.0;
            this.NaleznosicOdPozostalychJednostekDochodzoneNaDrodzeSadawejP = 0.0;

            this.InwestycjeKrotkoterminoweB = 0.0;
            this.InwestycjeKrotkoterminoweP = 0.0;
            this.KrotkoterminoweAktywaFinansoweB = 0.0;
            this.KrotkoterminoweAktywaFinansoweP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzialyLubAkcjeB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzialyLubAkcjeP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInnePapiryWartoscioweB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInnePapiryWartoscioweP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzilonePozyczkiB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzilonePozyczkiP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInneKrotkoterminoweAKtywaFinansoweB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInneKrotkoterminoweAKtywaFinansoweP = 0.0;

            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInnePapiryWartoscioweB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInnePapiryWartoscioweP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzilonePozyczkiB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzilonePozyczkiP = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInneKrotkoterminoweAKtywaFinansoweB = 0.0;
            this.KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInneKrotkoterminoweAKtywaFinansoweP = 0.0;

            this.KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneB = 0.0;
            this.KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneP = 0.0;
            this.KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneSrodkiPieniezneWKasieINaRachunkuB = 0.0;
            this.KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneSrodkiPieniezneWKasieINaRachunkuP = 0.0;
            this.KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneSrodkiPieniezneB = 0.0;
            this.KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneSrodkiPieniezneP = 0.0;
            this.KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneAKtywaPieniezneB = 0.0;
            this.KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneAKtywaPieniezneP = 0.0;

            this.InneInwestycjeKrotkoterminoweB = 0.0;
            this.InneInwestycjeKrotkoterminoweP = 0.0;
            this.KrotkoterminoweRozliczeniaMiedzyokresoweB = 0.0;
            this.KrotkoterminoweRozliczeniaMiedzyokresoweP = 0.0;
            this.NalezneWplatyNaKapitalFunduszPodstawowyB = 0.0;
            this.NalezneWplatyNaKapitalFunduszPodstawowyP = 0.0;
            this.UdzialyAkcjeWlasneB = 0.0;
            this.UdzialyAkcjeWlasneP = 0.0;
            this.AktywaRazemB = 0.0;
            this.AktywaRazemP = 0.0;

            this.KapitalFunduszWlasnyB = 0.0;
            this.KapitalFunduszWlasnyP = 0.0;

            this.KapitalFunduszPodstawowyB = 0.0;
            this.KapitalFunduszPodstawowyP = 0.0;
            this.KapitalFunduszZapasowyWTymB = 0.0;
            this.KapitalFunduszZapasowyWTymP = 0.0;
            this.KapitalFunduszZapasowyWTymNadwyzkawartosciSprzedazyWartosciEmisyjnejNadWartosciaNominalnaUdzialowAkcjiB = 0.0;
            this.KapitalFunduszZapasowyWTymNadwyzkawartosciSprzedazyWartosciEmisyjnejNadWartosciaNominalnaUdzialowAkcjiP = 0.0;

            this.KapitalFunduszZAktualizacjiWycentyWTymB = 0.0;
            this.KapitalFunduszZAktualizacjiWycentyWTymP = 0.0;
            this.KapitalFunduszZAktualizacjiWycentyWTymZTytuluAktualizacjiWartosciGodziwejB = 0.0;
            this.KapitalFunduszZAktualizacjiWycentyWTymZTytuluAktualizacjiWartosciGodziwejP = 0.0;

            this.PozostaleKapitalyFunduszeRezerwoweWTymB = 0.0;
            this.PozostaleKapitalyFunduszeRezerwoweWTymP = 0.0;
            this.PozostaleKapitalyFunduszeRezerwoweWTymTworzoneZgodnieZUmowaStatutemSpolkiB = 0.0;
            this.PozostaleKapitalyFunduszeRezerwoweWTymTworzoneZgodnieZUmowaStatutemSpolkiP = 0.0;
            this.PozostaleKapitalyFunduszeRezerwoweWTymNaUdzialyAkcjeWlasneB = 0.0;
            this.PozostaleKapitalyFunduszeRezerwoweWTymNaUdzialyAkcjeWlasneP = 0.0;

            this.ZyskStrataZLatUbieglychB = 0.0;
            this.ZyskStrataZLatUbieglychP = 0.0;

            this.ZyskStrataNettoB = 0.0;
            this.ZyskStrataNettoP = 0.0;

            this.OdpisyZZyskuNettoWCiaguRokuObrotowegoWielkoscUjemnaB = 0.0;
            this.OdpisyZZyskuNettoWCiaguRokuObrotowegoWielkoscUjemnaP = 0.0;

            this.ZobowiazaniaIRezerwyNaZobowiazaniaB = 0.0;
            this.ZobowiazaniaIRezerwyNaZobowiazaniaP = 0.0;

            this.RezerwyNaZobowiazaniaB = 0.0;
            this.RezerwyNaZobowiazaniaP = 0.0;
            this.RezerwaZTytuluOdroczonegoPodatkuDochodowegoB = 0.0;
            this.RezerwaZTytuluOdroczonegoPodatkuDochodowegoP = 0.0;
            this.RezerwaNaSwiadczeniaEmerytalneIPodobneB = 0.0;
            this.RezerwaNaSwiadczeniaEmerytalneIPodobneP = 0.0;
            this.RezerwaNaSwiadczeniaEmerytalneIPodobneDlugoterminowaB = 0.0;
            this.RezerwaNaSwiadczeniaEmerytalneIPodobneDlugoterminowaP = 0.0;
            this.RezerwaNaSwiadczeniaEmerytalneIPodobneKrotkoterminowaB = 0.0;
            this.RezerwaNaSwiadczeniaEmerytalneIPodobneKrotkoterminowaP = 0.0;
            this.PozostaleRezerwyB = 0.0;
            this.PozostaleRezerwyP = 0.0;
            this.PozostaleRezerwyDlugoterminoweB = 0.0;
            this.PozostaleRezerwyDlugoterminoweP = 0.0;
            this.PozostaleRezerwyKrotkoterminoweB = 0.0;
            this.PozostaleRezerwyKrotkoterminoweP = 0.0;

            this.ZobowiazaniaDlugoterminoweB = 0.0;
            this.ZobowiazaniaDlugoterminoweP = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecJednostekPowiazanychB = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecJednostekPowiazanychP = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekB = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekP = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekKredytyIPozyczkiB = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekKredytyIPozyczkiP = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZTytuluEmisjiDluznychPapierowWartosciowychB = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZTytuluEmisjiDluznychPapierowWartosciowychP = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneZobowiazaniaFinansoweB = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneZobowiazaniaFinansoweP = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZobowiazaniaWekseloweB = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZobowiazaniaWekseloweP = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneB = 0.0;
            this.ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneP = 0.0;

            this.ZobowiazaniaKrotkoterminoweB = 0.0;
            this.ZobowiazaniaKrotkoterminoweP = 0.0;

            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychInneB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychInneP = 0.0;

            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneP = 0.0;

            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekKredytyIPozyczkiB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekKredytyIPozyczkiP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluEmisjiDluznychPapierowWartosciowychB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluEmisjiDluznychPapierowWartosciowychP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneZobowiazaniaFinansoweB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneZobowiazaniaFinansoweP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZaliczkiOtrzymaneNaDostawyIUslugiB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZaliczkiOtrzymaneNaDostawyIUslugiP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZobowiazaniaWekseloweB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZobowiazaniaWekseloweP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluPodatkowCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoPrawnychB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluPodatkowCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoPrawnychP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluWynagrodzenB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluWynagrodzenP = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneB = 0.0;
            this.ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneP = 0.0;

            this.ZobowiazaniaKrotkoterminoweFunduszeSpecjalneB = 0.0;
            this.ZobowiazaniaKrotkoterminoweFunduszeSpecjalneP = 0.0;

            this.RozliczeniaMiedzyokresoweB = 0.0;
            this.RozliczeniaMiedzyokresoweP = 0.0;
            this.UjemnaWartoscFirmyB = 0.0;
            this.UjemnaWartoscFirmyP = 0.0;
            this.RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweB = 0.0;
            this.RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweP = 0.0;
            this.RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweDlugoterminoweB = 0.0;
            this.RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweDlugoterminoweP = 0.0;
            this.RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweKrotkoterminoweB = 0.0;
            this.RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweKrotkoterminoweP = 0.0;
            this.PasywaB = 0.0;
            this.PasywaP = 0.0;

        listaKontWBilansie = ((App)Application.Current).Konta;
            WynikiKontAktywnych = new List<WynikKonta>();
            WynikiKontPasywnych = new List<WynikKonta>();
            
        }

        public void WyliczanieZbiorowAktywnych(DateTime data)
        {
            
            string dateString = $"31/12/{data.Year-1}";
            DateTime dataRokPoprzedni = DateTime.ParseExact(dateString, "dd/MM/yyyy", null);
            double WartoscBiezaca;
            double WartoscPoprzednia;

            string[] ZbiorWartosciNiematerialnychIPrawnych = new string[]
            {
                "Koszty zakończonych prac rozwojowych",
                "Wartość firmy",
                "Inne wartości niematerialne i prawne",
                "Zaliczki na wartości niematerialne i prawne"
            };

            string[] ZbiorRzeczoweAktywaTrwale = new string[]
            {
                "Grunty (w tym prawo użytkowania wieczystego gruntu)",
                "Budynki, lokale, prawa do lokali i obiekty inżynierii lądowej i wodnej",
                "Urządzenia techniczne i maszyny",
                "Środki transportu",
                "Inne środki trwałe",

                "Środki trwałe w budowie",
                "Zaliczki na środki trwałe w budowie"
            };

            string[] ZbiorSrodkiTrwale= new string[]
            {
                "Grunty (w tym prawo użytkowania wieczystego gruntu)",
                "Budynki, lokale, prawa do lokali i obiekty inżynierii lądowej i wodnej",
                "Urządzenia techniczne i maszyny",
                "Środki transportu",
                "Inne środki trwałe",
            };

            string[] ZbiorNaleznosciDlugoterminowe = new string[]
            {
                "Należności długoterminowe Od jednostek powiązanych",
                "Należności długoterminowe Od pozostałych jednostek, w których jednostka posiada zaangażowanie w kapitale",
                "Należności długoterminowe Od pozostałych jednostek"
            };

            string[] ZbiorInwestycjeDlugoterminowe = new string[]
            {
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
                "Inne inwestycje długoterminowe"
            };

            string[] ZbiorDlugoterminoweAktywaFinansowe = new string[]
            {
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
            };

            string[] ZbiorDlugoterminoweAktywaFinansoweWJednostkachPowiazanych = new string[]
            {
                "Długoterminowe aktywa finansowe w jednostkach powiązanych udziały lub akcje",
                "Długoterminowe aktywa finansowe w jednostkach powiązanych inne papiery wartościowe",
                "Długoterminowe aktywa finansowe w jednostkach powiązanych udzielone pożyczki",
                "Długoterminowe aktywa finansowe w jednostkach powiązanych inne długoterminowe aktywa finansowe",
            };
            string[] ZbiorDlugoterminoweAktywaFinansoweWPozostalychJednostkachPosiadaZaangazowanieWKapitele = new string[]
            {
                "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale udziały lub akcje",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale inne papiery wartościowe",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale udzielone pożyczki",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale inne długoterminowe aktywa finansowe"
            };
            string[] ZbiorDlugoterminoweAktywaFinansoweWPozostalychJednotkach = new string[]
            {
                "Długoterminowe aktywa finansowe w pozostałych jednostkach udziały lub akcje",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach inne papiery wartościowe",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach udzielone pożyczki",
                "Długoterminowe aktywa finansowe w pozostałych jednostkach inne długoterminowe aktywa finansowe"
            };
            string[] ZbiorDlugoTerminoweRozliczeniaMiedzyokresowe = new string[]
            {
                "Aktywa z tytułu odroczonego podatku dochodowego",
                "Inne rozliczenia międzyokresowe"
            };

            string[] ZbiorZapasy = new string[]
            {
                "Materiały",
                "Półprodukty i produkty w toku",
                "Produkty gotowe",
                "Towary",
                "Zaliczki na dostawy i usługi"
            };
            string[] ZbiorNaleznosciKrotkoterminowe = new string[]
            {
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
                "Należności od pozostałych jednostek dochodzone na drodze sądowej"
            };

            string[] ZbiorNaleznosciOdJednostekPowiazanych = new string[]
            {
                "Należności od jednostek powiązanych z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od jednostek powiązanych z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy",
                "Należności od jednostek powiązanych inne"
            };

            string[] ZbiorNaleznosciOdJednostekPowiazanychZtytuluDostawIuslugOOkresieSplaty = new string[]
            {
                "Należności od jednostek powiązanych z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od jednostek powiązanych z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy"
            };
            
            string[] ZbiorNaleznosciKrotkoterminoweNaleznosciOdPozostalychjednostekWKtorychJednostkaPosiadaZaangazowanieWKapitale = new string[]
            {
                "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy",
                "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale inne"
            };

            string[] ZbiorNaleznosciKrotkoterminoweNaleznosciOdPozostalychjednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieSplaty = new string[]
            {
                "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy",
            };

            string[] ZbiorNaleznosciKrotkoterminoweNaleznosciOdPozostalychJednostek = new string[]
            {
                "Należności od pozostałych jednostek z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od pozostałych jednostek z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy",
                "Należności od pozostałych jednostek z tytułu podatków dotacji ceł ubezpieczeń społecznych i zdrowotnych oraz innych tytułów publicznoprawnych",
                "Należności od pozostałych jednostek inne",
                "Należności od pozostałych jednostek dochodzone na drodze sądowej"
            };

            string[] ZbiorNaleznosciKrotkoterminoweNaleznosciOdPozostalychJednostekZtytuluDostawIUslugOOkresieSplaty = new string[]
            {
                "Należności od pozostałych jednostek z tytułu dostaw i usług o okresie spłaty do 12 miesięcy",
                "Należności od pozostałych jednostek z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy"
            };
            string[] ZbiorInwestycjeKrotkoterminowe = new string[]
            {
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
                "Inne inwestycje krótkoterminowe"
            };
            string[] ZbiorKrotkoterminoweAktywaFinansowe = new string[]
            {
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
                "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne inne aktywa pieniężne"
            };
            string[] ZbiorWjednostkachPowiazanych = new string[]
            {
                "Któtkoterminowe aktywa finansowe w jednostakch powiązanych udziały lub akcje",
                "Któtkoterminowe aktywa finansowe w jednostakch powiązanych inne papiery wartościowe",
                "Któtkoterminowe aktywa finansowe w jednostakch powiązanych udzielone pożyczki",
                "Któtkoterminowe aktywa finansowe w jednostakch powiązanych inne którkoterminowe aktywa finansowe"
            };
            string[] ZbiorWpozostalychJednostkach = new string[]
            {
                "Któtkoterminowe aktywa finansowe w pozostałych jednostkach udziały lub akcje",
                "Któtkoterminowe aktywa finansowe w pozostałych jednostkach inne papiery wartościowe",
                "Któtkoterminowe aktywa finansowe w pozostałych jednostkach udzielone pożyczki",
                "Któtkoterminowe aktywa finansowe w pozostałych jednostkach inne krótkoterminowe aktywa finansowe"
            };
            string[] ZbiorSrodkiPieniezneIInneAktywaPieniezne = new string[]
            {
                "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne środki pieniężne w kasie i na rachunkach",
                "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne inne środki pieniężne",
                "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne inne aktywa pieniężne"
            };
            
            foreach (var item in listaKontWBilansie)
            {
                WartoscBiezaca = 0.0;
                WartoscPoprzednia = 0.0;
                WartoscBiezaca += item.SumaSaldDT(data);
                WartoscPoprzednia += item.SumaSaldDT(dataRokPoprzedni);

                if (ZbiorWartosciNiematerialnychIPrawnych.Contains(item.PolaczenieBilansowe) || ZbiorRzeczoweAktywaTrwale.Contains(item.PolaczenieBilansowe) || 
                    ZbiorNaleznosciDlugoterminowe.Contains(item.PolaczenieBilansowe) || ZbiorInwestycjeDlugoterminowe.Contains(item.PolaczenieBilansowe) || 
                    ZbiorDlugoTerminoweRozliczeniaMiedzyokresowe.Contains(item.PolaczenieBilansowe))
                {
                    AktywaRazemB += WartoscBiezaca;
                    AktywaRazemP += WartoscPoprzednia;
                    AktywaTrwaleB += WartoscBiezaca;
                    AktywaTrwaleP += WartoscPoprzednia;

                    if (ZbiorWartosciNiematerialnychIPrawnych.Contains(item.PolaczenieBilansowe))
                    {
                        WartosciNiematerialneIPrawneB += WartoscBiezaca;
                        WartosciNiematerialneIPrawneP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Koszty zakończonych prac rozwojowych")
                        {
                            KosztZakonczonychPracRozwojowychB += WartoscBiezaca;
                            KosztZakonczonychPracRozwojowychP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Wartość firmy")
                        {
                            WartoscFirmyB += WartoscBiezaca;
                            WartoscFirmyP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Inne wartości niematerialne i prawne")
                        {
                            InneWartosciNiematerialneIPrawneB += WartoscBiezaca;
                            InneWartosciNieMaterialneIPrawneP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Zaliczki na wartości niematerialne i prawne")
                        {
                            ZaliczkiNaWartosciNiematerilaneIPrawneB += WartoscBiezaca;
                            ZaliczkiNaWartosciNiematerialneIPrawneP += WartoscPoprzednia;
                        }
                    }
                    else if (ZbiorRzeczoweAktywaTrwale.Contains(item.PolaczenieBilansowe))
                    {
                        RzeczoweAktywaTrwaleB += WartoscBiezaca;
                        RzeczoweAktywaTrwaleP += WartoscPoprzednia;

                        if (ZbiorSrodkiTrwale.Contains(item.PolaczenieBilansowe))
                        {
                            SrodkiTrwaleB += WartoscBiezaca;
                            SrodkiTrwaleP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Grunty (w tym prawo użytkowania wieczystego gruntu)")
                            {
                                GruntyWTymPrawoUzytkowaniaWieczystegoGruntuB += WartoscBiezaca;
                                GruntyWTymPrawoUzytkowaniaWieczystegoGruntuP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Budynki, lokale, prawa do lokali i obiekty inżynierii lądowej i wodnej")
                            {
                                BudynkiLokalePrawaDoLokaliIObiektyInzynieriLadawejIWodnejB += WartoscBiezaca;
                                BudynkiLokalePrawaDoLokaliIObiektyInzynieriLadawejIWodnejP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Urządzenia techniczne i maszyny")
                            {
                                UrzadzeniaTechniczneIMaszynyB += WartoscBiezaca;
                                UrzadzeniaTechniczneIMaszynyP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Środki transportu")
                            {
                                SrodkiTransportuB += WartoscBiezaca;
                                SrodkiTransportuP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Inne środki trwałe")
                            {
                                InneSrodkiTrwaleB += WartoscBiezaca;
                                InneSrodkiTrwaleP += WartoscPoprzednia;
                            }

                        }
                        else if (item.PolaczenieBilansowe == "Środki trwałe w budowie")
                        {
                            SrodkiTrwaleWBudowieB += WartoscBiezaca;
                            SrodkiTrwaleWBudowieP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Zaliczki na środki trwałe w budowie")
                        {
                            ZaliczkiNaSrodkitrwaleWBudowieB += WartoscBiezaca;
                            ZaliczkiNaSrodkitrwaleWBudowieP += WartoscPoprzednia;
                        }
                    }
                    else if (ZbiorNaleznosciDlugoterminowe.Contains(item.PolaczenieBilansowe))
                    {
                        NaleznosciDlugoterminoweB += WartoscBiezaca;
                        NaleznosciDlugoterminoweP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Należności długoterminowe Od jednostek powiązanych")
                        {
                            OdJednostekPowiazanychB += WartoscBiezaca;
                            OdJednostekPowiazanychP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Należności długoterminowe Od pozostałych jednostek, w których jednostka posiada zaangażowanie w kapitale")
                        {
                            OdPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB += WartoscBiezaca;
                            OdPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Należności długoterminowe Od pozostałych jednostek")
                        {
                            OdPozostalychJednostekB += WartoscBiezaca;
                            OdPozostalychJednostekP += WartoscPoprzednia;
                        }
                    }
                    else if (ZbiorInwestycjeDlugoterminowe.Contains(item.PolaczenieBilansowe))
                    {
                        InwestycjeDlugoterminoweB += WartoscBiezaca;
                        InwestycjeDlugoterminoweP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Nieruchomości")
                        {
                            NieruchomosciB += WartoscBiezaca;
                            NieruchomosciP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Inwestycje długoterminowe wartości niematerilane i prawne")
                        {
                            InwestycjeDlugoterminoweWartosciNiematerialneIPrawneB += WartoscBiezaca;
                            InwestycjeDlugoterminoweWartosciNiematerialneIPrawneP += WartoscPoprzednia;
                        }
                        else if (ZbiorDlugoterminoweAktywaFinansowe.Contains(item.PolaczenieBilansowe))
                        {
                            DlugoterminoweAktywaFinansoweB += WartoscBiezaca;
                            DlugoterminoweAktywaFinansoweP += WartoscPoprzednia;

                            if (ZbiorDlugoterminoweAktywaFinansoweWJednostkachPowiazanych.Contains(item.PolaczenieBilansowe))
                            {
                                DlugoterminoweAktywaFinansoweWJednostkachPowiazanychB += WartoscBiezaca;
                                DlugoterminoweAktywaFinansoweWJednostkachPowiazanychP += WartoscPoprzednia;

                                if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w jednostkach powiązanych udziały lub akcje")
                                {
                                    DlugotermnoweAktywaFinansoweWJednostakchPowiazanychUdzialyLubAkcjeB += WartoscBiezaca;
                                    DlugotermnoweAktywaFinansoweWJednostakchPowiazanychUdzialyLubAkcjeP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w jednostkach powiązanych inne papiery wartościowe")
                                {
                                    DlugotermnoweAktywaFinansoweWJednostakchPowiazanychInneParpieryWartoscioweB += WartoscBiezaca;
                                    DlugotermnoweAktywaFinansoweWJednostakchPowiazanychInneParpieryWartoscioweP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w jednostkach powiązanych udzielone pożyczki")
                                {
                                    DlugoterminoweAktywaFinansoweWJednostkachPowiazanychUdzielonePozyczkiB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWJednostkachPowiazanychUdzielonePozyczkiP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w jednostkach powiązanych inne długoterminowe aktywa finansowe")
                                {
                                    DlugoterminoweAktywaFinansoweWJednostkachPowiazanychInneDlugoterminoweAktywaFinansoweB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWJednostkachPowiazanychInneDlugoterminoweAktywaFinansoweP += WartoscPoprzednia;
                                }
                            }
                            else if (ZbiorDlugoterminoweAktywaFinansoweWPozostalychJednostkachPosiadaZaangazowanieWKapitele.Contains(item.PolaczenieBilansowe))
                            {
                                DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleB += WartoscBiezaca;
                                DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleP += WartoscPoprzednia;

                                if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale udziały lub akcje")
                                {
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzialyLubAkcjeB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzialyLubAkcjeB += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale inne papiery wartościowe")
                                {
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneParpieryWartoscioweB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneParpieryWartoscioweP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale udzielone pożyczki")
                                {
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzielonePozyczkiB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzielonePozyczkiP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w pozostałych jednostkach w których jednostka posiada zaangażowanie w kapitale inne długoterminowe aktywa finansowe")
                                {
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneDlugoterminoweAktywaFinansoweB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneDlugoterminoweAktywaFinansoweP += WartoscPoprzednia;
                                }
                            }
                            else if (ZbiorDlugoterminoweAktywaFinansoweWPozostalychJednotkach.Contains(item.PolaczenieBilansowe))
                            {
                                DlugoterminoweAktywaFinansoweWPozostalychJednostkachB += WartoscBiezaca;
                                DlugoterminoweAktywaFinansoweWPozostalychJednostkachP += WartoscPoprzednia;

                                if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w pozostałych jednostkach udziały lub akcje")
                                {
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w pozostałych jednostkach inne papiery wartościowe")
                                {
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachInnePapieryWartoscioweB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachInnePapieryWartoscioweP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w pozostałych jednostkach udzielone pożyczki")
                                {
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzielonePozyczkiB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzielonePozyczkiP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Długoterminowe aktywa finansowe w pozostałych jednostkach inne długoterminowe aktywa finansowe")
                                {
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachInneDlugoterminoweAktywaFinansoweB += WartoscBiezaca;
                                    DlugoterminoweAktywaFinansoweWPozostalychJednostkachInneDlugoterminoweAktywaFinansoweP += WartoscPoprzednia;
                                }
                            }
                        }
                        else if (item.PolaczenieBilansowe == "Inne inwestycje długoterminowe")
                        {
                            InneInwestycjeDlugoterminoweB += WartoscBiezaca;
                            InneInwestycjeDlugoterminoweP += WartoscPoprzednia;
                        }
                    }
                    else if (ZbiorDlugoTerminoweRozliczeniaMiedzyokresowe.Contains(item.PolaczenieBilansowe))
                    {
                        DlugoterminoweRozliczeniaMiedzyokresoweB += WartoscBiezaca;
                        DlugoterminoweRozliczeniaMiedzyokresoweP += WartoscPoprzednia;
                        if (item.PolaczenieBilansowe == "Aktywa z tytułu odroczonego podatku dochodowego")
                        {
                            AktywaZTytuluOdroczonegoPodatkuDochodowegoB += WartoscBiezaca;
                            AktywaZTytuluOdroczonegoPodatkuDochodowegoP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Inne rozliczenia międzyokresowe")
                        {
                            InneRozliczeniaMiedzyokresoweB += WartoscBiezaca;
                            InneRozliczeniaMiedzyokresoweP += WartoscPoprzednia;
                        }
                    }
                }
                else if (ZbiorNaleznosciKrotkoterminowe.Contains(item.PolaczenieBilansowe) || ZbiorZapasy.Contains(item.PolaczenieBilansowe))
                {
                    AktywaRazemB += WartoscBiezaca;
                    AktywaRazemP += WartoscPoprzednia;
                    AktywaObrotoweB += WartoscBiezaca;
                    AktywaObrotoweP += WartoscPoprzednia;

                    if (ZbiorZapasy.Contains(item.PolaczenieBilansowe))
                    {
                        ZapasyB += WartoscBiezaca;
                        ZapasyP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Materiały")
                        {
                            MaterialyB += WartoscBiezaca;
                            MaterialyP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Półprodukty i produkty w toku")
                        {
                            PolproduktyIProduktyWTokuB += WartoscBiezaca;
                            PolproduktyIProduktyWTokuP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Produkty gotowe")
                        {
                            ProduktyGotoweB += WartoscBiezaca;
                            ProduktyGotoweP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Towary")
                        {
                            TowaryB += WartoscBiezaca;
                            TowaryP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Zaliczki na dostawy i usługi")
                        {
                            ZaliczkiNaDostawyIUslugiB += WartoscBiezaca;
                            ZaliczkiNaDostawyIUslugiP += WartoscPoprzednia;
                        }
                    }
                    else if (ZbiorNaleznosciKrotkoterminowe.Contains(item.PolaczenieBilansowe))
                    {
                        NaleznosciKrotkoterminoweB += WartoscBiezaca;
                        NaleznosciKrotkoterminoweP += WartoscPoprzednia;

                        if (ZbiorNaleznosciOdJednostekPowiazanych.Contains(item.PolaczenieBilansowe))
                        {
                            NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychB += WartoscBiezaca;
                            NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychP += WartoscPoprzednia;

                            if (ZbiorNaleznosciOdJednostekPowiazanychZtytuluDostawIuslugOOkresieSplaty.Contains(item.PolaczenieBilansowe))
                            {
                                NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyB += WartoscBiezaca;
                                NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyP += WartoscPoprzednia;

                                if (item.PolaczenieBilansowe == "Należności od jednostek powiązanych z tytułu dostaw i usług o okresie spłaty do 12 miesięcy")
                                {
                                    NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB += WartoscBiezaca;
                                    NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Należności od jednostek powiązanych z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy")
                                {
                                    NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB += WartoscBiezaca;
                                    NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP += WartoscPoprzednia;
                                }
                            }
                            else if (item.PolaczenieBilansowe == "Należności od jednostek powiązanych inne")
                            {
                                NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychInneB += WartoscBiezaca;
                                NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychInneP += WartoscPoprzednia;
                            }
                        }
                        else if (ZbiorNaleznosciKrotkoterminoweNaleznosciOdPozostalychjednostekWKtorychJednostkaPosiadaZaangazowanieWKapitale.Contains(item.PolaczenieBilansowe))
                        {
                            NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleB += WartoscBiezaca;
                            NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleP += WartoscPoprzednia;

                            if (ZbiorNaleznosciKrotkoterminoweNaleznosciOdPozostalychjednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieSplaty.Contains(item.PolaczenieBilansowe))
                            {
                                NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyB += WartoscBiezaca;
                                NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyP += WartoscPoprzednia;
                                if (item.PolaczenieBilansowe == "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie spłaty do 12 miesięcy")
                                {
                                    NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB += WartoscBiezaca;
                                    NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy")
                                {
                                    NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB += WartoscBiezaca;
                                    NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP += WartoscPoprzednia;
                                }
                            }
                            else if (item.PolaczenieBilansowe == "Należności od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale inne")
                            {
                                NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleInneB += WartoscBiezaca;
                                NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleInneP += WartoscPoprzednia;
                            }
                        }
                        else if (ZbiorNaleznosciKrotkoterminoweNaleznosciOdPozostalychJednostek.Contains(item.PolaczenieBilansowe))
                        {
                            NaleznosicOdPozostalychJednostekB += WartoscBiezaca;
                            NaleznosicOdPozostalychJednostekP += WartoscPoprzednia;

                            if (ZbiorNaleznosciKrotkoterminoweNaleznosciOdPozostalychJednostekZtytuluDostawIUslugOOkresieSplaty.Contains(item.PolaczenieBilansowe))
                            {
                                NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyB += WartoscBiezaca;
                                NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyP += WartoscPoprzednia;

                                if (item.PolaczenieBilansowe == "Należności od pozostałych jednostek z tytułu dostaw i usług o okresie spłaty do 12 miesięcy")
                                {
                                    NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB += WartoscBiezaca;
                                    NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Należności od pozostałych jednostek z tytułu dostaw i usług o okresie spłaty powyżej 12 miesięcy")
                                {
                                    NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB += WartoscBiezaca;
                                    NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP += WartoscPoprzednia;
                                }
                            }
                            else if (item.PolaczenieBilansowe == "Należności od pozostałych jednostek z tytułu podatków dotacji ceł ubezpieczeń społecznych i zdrowotnych oraz innych tytułów publicznoprawnych")
                            {
                                NaleznosicOdPozostalychJednostekZTytuluPodatkowDotacjiCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoprawnychB += WartoscBiezaca;
                                NaleznosicOdPozostalychJednostekZTytuluPodatkowDotacjiCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoprawnychP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Należności od pozostałych jednostek inne")
                            {
                                NaleznosicOdPozostalychJednostekInneB += WartoscBiezaca;
                                NaleznosicOdPozostalychJednostekInneP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Należności od pozostałych jednostek dochodzone na drodze sądowej")
                            {
                                NaleznosicOdPozostalychJednostekDochodzoneNaDrodzeSadawejB += WartoscBiezaca;
                                NaleznosicOdPozostalychJednostekDochodzoneNaDrodzeSadawejP += WartoscPoprzednia;
                            }
                        }
                    }
                }
                else if (ZbiorInwestycjeKrotkoterminowe.Contains(item.PolaczenieBilansowe))
                {
                    AktywaRazemB += WartoscBiezaca;
                    AktywaRazemP += WartoscPoprzednia;
                    AktywaObrotoweB += WartoscBiezaca;
                    AktywaObrotoweP += WartoscPoprzednia;
                    InwestycjeKrotkoterminoweB += WartoscBiezaca;
                    InwestycjeKrotkoterminoweP += WartoscPoprzednia;

                    if (ZbiorKrotkoterminoweAktywaFinansowe.Contains(item.PolaczenieBilansowe))
                    {
                        KrotkoterminoweAktywaFinansoweB += WartoscBiezaca;
                        KrotkoterminoweAktywaFinansoweP += WartoscPoprzednia;

                        if (ZbiorWjednostkachPowiazanych.Contains(item.PolaczenieBilansowe))
                        {
                            KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychB += WartoscBiezaca;
                            KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe w jednostakch powiązanych udziały lub akcje")
                            {
                                KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzialyLubAkcjeB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzialyLubAkcjeP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe w jednostakch powiązanych inne papiery wartościowe")
                            {
                                KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInnePapiryWartoscioweB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInnePapiryWartoscioweP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe w jednostakch powiązanych udzielone pożyczki")
                            {
                                KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzilonePozyczkiB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzilonePozyczkiP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe w jednostakch powiązanych inne którkoterminowe aktywa finansowe")
                            {
                                KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInneKrotkoterminoweAKtywaFinansoweB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInneKrotkoterminoweAKtywaFinansoweP += WartoscPoprzednia;
                            }
                        }
                        else if (ZbiorWpozostalychJednostkach.Contains(item.PolaczenieBilansowe))
                        {
                            KrotkoterminoweAktywaFinansoweWPozostalychJednostkachB += WartoscBiezaca;
                            KrotkoterminoweAktywaFinansoweWPozostalychJednostkachP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe w pozostałych jednostkach udziały lub akcje")
                            {
                                KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe w pozostałych jednostkach inne papiery wartościowe")
                            {
                                KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInnePapiryWartoscioweB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInnePapiryWartoscioweP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe w pozostałych jednostkach udzielone pożyczki")
                            {
                                KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzilonePozyczkiB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzilonePozyczkiP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe w pozostałych jednostkach inne krótkoterminowe aktywa finansowe")
                            {
                                KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInneKrotkoterminoweAKtywaFinansoweB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInneKrotkoterminoweAKtywaFinansoweP += WartoscPoprzednia;
                            }
                        }
                        else if (ZbiorSrodkiPieniezneIInneAktywaPieniezne.Contains(item.PolaczenieBilansowe))
                        {
                            KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneB += WartoscBiezaca;
                            KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne środki pieniężne w kasie i na rachunkach")
                            {

                                KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneSrodkiPieniezneWKasieINaRachunkuB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneSrodkiPieniezneWKasieINaRachunkuP += WartoscPoprzednia;

                            }
                            else if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne inne środki pieniężne")
                            {
                                KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneSrodkiPieniezneB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneSrodkiPieniezneP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Któtkoterminowe aktywa finansowe środki pienieżne i inne aktywa pieniężne inne aktywa pieniężne")
                            {
                                KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneAKtywaPieniezneB += WartoscBiezaca;
                                KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneAKtywaPieniezneP += WartoscPoprzednia;
                            }
                        }
                    }
                    else if (item.PolaczenieBilansowe == "Inne inwestycje krótkoterminowe")
                    {
                        InneInwestycjeKrotkoterminoweB += WartoscBiezaca;
                        InneInwestycjeKrotkoterminoweP += WartoscPoprzednia;
                    }
                   
                }
                else if (item.PolaczenieBilansowe == "Krótkterminowe rozliczenia międzyokresowe")
                {
                    AktywaRazemB += WartoscBiezaca;
                    AktywaRazemP += WartoscPoprzednia;
                    AktywaObrotoweB += WartoscBiezaca;
                    AktywaObrotoweP += WartoscPoprzednia;
                    KrotkoterminoweRozliczeniaMiedzyokresoweB += WartoscBiezaca;
                    KrotkoterminoweRozliczeniaMiedzyokresoweP += WartoscPoprzednia;
                }
                else if (item.PolaczenieBilansowe == "Należne wpłaty na kapitał (fundusz) podstawowy")
                {
                    AktywaRazemB += WartoscBiezaca;
                    AktywaRazemP += WartoscPoprzednia;
                    NalezneWplatyNaKapitalFunduszPodstawowyB += WartoscBiezaca;
                    NalezneWplatyNaKapitalFunduszPodstawowyP += WartoscPoprzednia;
                }
                else if (item.PolaczenieBilansowe == "Udziały (akcje) własne")
                {
                    AktywaRazemB += WartoscBiezaca;
                    AktywaRazemP += WartoscPoprzednia;
                    UdzialyAkcjeWlasneB += WartoscBiezaca;
                    UdzialyAkcjeWlasneP += WartoscPoprzednia;
                }

            }

        }
        public void WczytanieWylicznoychDanychAktywow()
        {
            WynikiKontAktywnych.Add(new WynikKonta("A","Aktywa trwałe", AktywaTrwaleB, AktywaTrwaleP));

            WynikiKontAktywnych.Add(new WynikKonta("I", "Wartości niematerialne i prawne", WartosciNiematerialneIPrawneB, WartosciNiematerialneIPrawneP));
            WynikiKontAktywnych.Add(new WynikKonta("1", "Koszty zakończonych prac rozwojowych", KosztZakonczonychPracRozwojowychB, KosztZakonczonychPracRozwojowychP));
            WynikiKontAktywnych.Add(new WynikKonta("2", "Wartość firmy", WartoscFirmyB, WartoscFirmyP));
            WynikiKontAktywnych.Add(new WynikKonta("3", "Inne wartości niematerialne i prawne", InneWartosciNiematerialneIPrawneB, InneWartosciNieMaterialneIPrawneP));
            WynikiKontAktywnych.Add(new WynikKonta("4", "Zaliczki na wartości niematerialne i prawne", ZaliczkiNaWartosciNiematerilaneIPrawneB, ZaliczkiNaWartosciNiematerialneIPrawneP));

            WynikiKontAktywnych.Add(new WynikKonta("II", "Rzeczowe aktywa trwałe", RzeczoweAktywaTrwaleB, RzeczoweAktywaTrwaleP));
            WynikiKontAktywnych.Add(new WynikKonta("1", "Środki trwałe:", SrodkiTrwaleB, SrodkiTrwaleP));
            WynikiKontAktywnych.Add(new WynikKonta("a)", "Grunty (w tym prawo użytkowania wieczystego gruntu)", GruntyWTymPrawoUzytkowaniaWieczystegoGruntuB, GruntyWTymPrawoUzytkowaniaWieczystegoGruntuP));
            WynikiKontAktywnych.Add(new WynikKonta("b)", "Budynki, lokale, prawa do lokali i obiekty inżynierii lądowej i wodnej", BudynkiLokalePrawaDoLokaliIObiektyInzynieriLadawejIWodnejB, BudynkiLokalePrawaDoLokaliIObiektyInzynieriLadawejIWodnejP));
            WynikiKontAktywnych.Add(new WynikKonta("c)", "Urządzenia techniczne i maszyny", UrzadzeniaTechniczneIMaszynyB, UrzadzeniaTechniczneIMaszynyP));
            WynikiKontAktywnych.Add(new WynikKonta("d)", "Środki transportu", SrodkiTransportuB, SrodkiTransportuP));
            WynikiKontAktywnych.Add(new WynikKonta("e)", "Inne środki trwałe", InneSrodkiTrwaleB, InneSrodkiTrwaleP));
            WynikiKontAktywnych.Add(new WynikKonta("2", "Środki trwałe w budowie", SrodkiTrwaleWBudowieB, SrodkiTrwaleWBudowieP));
            WynikiKontAktywnych.Add(new WynikKonta("3", "Zaliczki na środki trwałe w budowie", ZaliczkiNaSrodkitrwaleWBudowieB, ZaliczkiNaSrodkitrwaleWBudowieP));

            WynikiKontAktywnych.Add(new WynikKonta("III", "Należności długoterminowe", NaleznosciDlugoterminoweB, NaleznosciDlugoterminoweP));
            WynikiKontAktywnych.Add(new WynikKonta("1", "Od jednostek powiązanych", OdJednostekPowiazanychB, OdJednostekPowiazanychP));
            WynikiKontAktywnych.Add(new WynikKonta("2", "Od pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale", OdPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB, OdPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP));
            WynikiKontAktywnych.Add(new WynikKonta("3", "Od pozostałych jednostek", OdPozostalychJednostekB, OdJednostekPowiazanychP));

            WynikiKontAktywnych.Add(new WynikKonta("IV", "Inwestycje długoterminowe", InwestycjeDlugoterminoweB, InwestycjeDlugoterminoweP));
            WynikiKontAktywnych.Add(new WynikKonta("1", "Nieruchomości", NieruchomosciB, NieruchomosciP));
            WynikiKontAktywnych.Add(new WynikKonta("2", "Wartości niematerialne i prawne", InwestycjeDlugoterminoweWartosciNiematerialneIPrawneB, InwestycjeDlugoterminoweWartosciNiematerialneIPrawneP));
            WynikiKontAktywnych.Add(new WynikKonta("3", "Długoterminowe aktywa finansowe", DlugoterminoweAktywaFinansoweB, DlugoterminoweAktywaFinansoweP));
            WynikiKontAktywnych.Add(new WynikKonta("a)", "w jednostkach powiązanych", DlugoterminoweAktywaFinansoweWJednostkachPowiazanychB, DlugoterminoweAktywaFinansoweWJednostkachPowiazanychP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udziały lub akcje", DlugotermnoweAktywaFinansoweWJednostakchPowiazanychUdzialyLubAkcjeB, DlugotermnoweAktywaFinansoweWJednostakchPowiazanychUdzialyLubAkcjeP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne papiery wartościowe", DlugotermnoweAktywaFinansoweWJednostakchPowiazanychInneParpieryWartoscioweB, DlugotermnoweAktywaFinansoweWJednostakchPowiazanychInneParpieryWartoscioweP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udzielne pożyczki", DlugoterminoweAktywaFinansoweWJednostkachPowiazanychUdzielonePozyczkiB, DlugoterminoweAktywaFinansoweWJednostkachPowiazanychUdzielonePozyczkiP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne długoterminowe aktywa finansowe", DlugoterminoweAktywaFinansoweWJednostkachPowiazanychInneDlugoterminoweAktywaFinansoweB, DlugoterminoweAktywaFinansoweWJednostkachPowiazanychInneDlugoterminoweAktywaFinansoweP));
            WynikiKontAktywnych.Add(new WynikKonta("b)", "w pozostałych jednostkach, w których jednostka posiada zaangażowanie w kapitale", DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udziały lub akcje", DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzialyLubAkcjeB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzialyLubAkcjeP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne papiery wartościowe", DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneParpieryWartoscioweB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneParpieryWartoscioweP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udzielone pożyczki", DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzielonePozyczkiB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleUdzielonePozyczkiP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne długoterminowe aktywa finansowe", DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneDlugoterminoweAktywaFinansoweB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneDlugoterminoweAktywaFinansoweP));
            WynikiKontAktywnych.Add(new WynikKonta("c)", "w pozostałych jednostkach", DlugoterminoweAktywaFinansoweWPozostalychJednostkachB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udziały lub akcje", DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne papiery wartościowe", DlugoterminoweAktywaFinansoweWPozostalychJednostkachInnePapieryWartoscioweB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachInnePapieryWartoscioweP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udzielone pożyczki", DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzielonePozyczkiB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachUdzielonePozyczkiP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne długoterminowe aktywa finansowe", DlugoterminoweAktywaFinansoweWPozostalychJednostkachInneDlugoterminoweAktywaFinansoweB, DlugoterminoweAktywaFinansoweWPozostalychJednostkachInneDlugoterminoweAktywaFinansoweP));
            WynikiKontAktywnych.Add(new WynikKonta("4", "Inne inwestycje długoterminowe", InneInwestycjeDlugoterminoweB, InneInwestycjeDlugoterminoweP));
            //długoterminowe rozliczenia miedzy okresowe
            WynikiKontAktywnych.Add(new WynikKonta("V", "Długoterminowe rozliczenia międzyokresowe", DlugoterminoweRozliczeniaMiedzyokresoweB, DlugoterminoweRozliczeniaMiedzyokresoweP));
            WynikiKontAktywnych.Add(new WynikKonta("1", "Aktywa z tytułu odroczonego podatku dochodowego", AktywaZTytuluOdroczonegoPodatkuDochodowegoB, AktywaZTytuluOdroczonegoPodatkuDochodowegoP));
            WynikiKontAktywnych.Add(new WynikKonta("2", "Inne rozliczenia międzyokresowe", InneRozliczeniaMiedzyokresoweB, InneRozliczeniaMiedzyokresoweP));
 
            //Aktywa obrotowe
            WynikiKontAktywnych.Add(new WynikKonta("B", "Aktywa obrotowe", AktywaObrotoweB, AktywaObrotoweP));

            WynikiKontAktywnych.Add(new WynikKonta("I", "Zapasy", ZapasyB, ZapasyP));
            WynikiKontAktywnych.Add(new WynikKonta("1", "Materiały", MaterialyB, MaterialyP));
            WynikiKontAktywnych.Add(new WynikKonta("2", "Półprodukty i produkty w toku", PolproduktyIProduktyWTokuB, PolproduktyIProduktyWTokuP));
            WynikiKontAktywnych.Add(new WynikKonta("3", "Produkty gotowe", ProduktyGotoweB, ProduktyGotoweP));
            WynikiKontAktywnych.Add(new WynikKonta("4", "Towary", TowaryB, TowaryP));
            WynikiKontAktywnych.Add(new WynikKonta("5", "Zaliczki na dostawy i usługi", ZaliczkiNaDostawyIUslugiB, ZaliczkiNaDostawyIUslugiP));

            WynikiKontAktywnych.Add(new WynikKonta("II", "Należności krótkoterminowe", NaleznosciKrotkoterminoweB, NaleznosciKrotkoterminoweP));
            WynikiKontAktywnych.Add(new WynikKonta("1", "Należności od jednostek powiązanych", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychP));
            WynikiKontAktywnych.Add(new WynikKonta("a)", "z tytułu dostaw i usług, o okresi spłaty:", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- do 12 miesięcy", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- powyżej 12 miesięcy", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP));
            WynikiKontAktywnych.Add(new WynikKonta("b)", "inne", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychInneB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychInneP));

            WynikiKontAktywnych.Add(new WynikKonta("2", "Należności od pozostałych jednostek, w których jednostka posiada zaangażowanie w kapitale", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleP));
            WynikiKontAktywnych.Add(new WynikKonta("a)", "z tytułu dostaw i usług, o okresie spłaty:", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- do 12 miesięcy", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- powyżej 12 miesięcy", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP));
            WynikiKontAktywnych.Add(new WynikKonta("b)", "inne", NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleInneB, NaleznosciKrotkoterminoweNaleznosciOdJednostkPowiazanychNaleznosciOdPozostalychJednostkWKtorychJednostkaPosiadaZaangazwanieWKapitaleInneP));

            WynikiKontAktywnych.Add(new WynikKonta("3", "Należności od pozostałych jednostek", NaleznosicOdPozostalychJednostekB, NaleznosicOdPozostalychJednostekP));
            WynikiKontAktywnych.Add(new WynikKonta("a)", "z tytułu dostaw i usług, o okresie spłaty:", NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyB, NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- do 12 miesięcy", NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyB, NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyDo12MiesiecyP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- powyżej 12 miesięcy", NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyB, NaleznosicOdPozostalychJednostekZTytuluDostawIUslugOOkresieSplatyPowyzej12MiesiecyP));
            WynikiKontAktywnych.Add(new WynikKonta("b)", "z tytułu podatków, dotacji, ceł, ubezpieczeń społecznych i zdrowotnych oraz innych tytułów publicznoprawnych", NaleznosicOdPozostalychJednostekZTytuluPodatkowDotacjiCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoprawnychB, NaleznosicOdPozostalychJednostekZTytuluPodatkowDotacjiCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoprawnychP));
            WynikiKontAktywnych.Add(new WynikKonta("c)", "inne", NaleznosicOdPozostalychJednostekInneB, NaleznosicOdPozostalychJednostekInneP));
            WynikiKontAktywnych.Add(new WynikKonta("d)", "dochodzone na drodze sądowej", NaleznosicOdPozostalychJednostekDochodzoneNaDrodzeSadawejB, NaleznosicOdPozostalychJednostekDochodzoneNaDrodzeSadawejP));
            WynikiKontAktywnych.Add(new WynikKonta("III", "Inwestycje krótkoterminowe", InwestycjeKrotkoterminoweB, InwestycjeKrotkoterminoweP));
            WynikiKontAktywnych.Add(new WynikKonta("1", "Krótkoterminowe aktywa finansowe", KrotkoterminoweAktywaFinansoweB, KrotkoterminoweAktywaFinansoweP));
            WynikiKontAktywnych.Add(new WynikKonta("a)", "w jednostkach powiązanych", KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udziały lub akcje", KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzialyLubAkcjeB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzialyLubAkcjeP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne papiery wartościowe", KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInnePapiryWartoscioweB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInnePapiryWartoscioweP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udzielone pożyczki", KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzilonePozyczkiB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychUdzilonePozyczkiP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne krótkoterminowe aktywa finansowe", KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInneKrotkoterminoweAKtywaFinansoweB, KrotkoterminoweAktywaFinansoweWJednostkachPowiazanychInneKrotkoterminoweAKtywaFinansoweP));
            WynikiKontAktywnych.Add(new WynikKonta("b)", "w pozostałych jednostkach", KrotkoterminoweAktywaFinansoweWPozostalychJednostkachB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udziały lub akcje", KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzialyLubAkcjeP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne papiery wartościowe", KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInnePapiryWartoscioweB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInnePapiryWartoscioweP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- udzielone pożyczki", KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzilonePozyczkiB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachUdzilonePozyczkiP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne krótkoterminowe aktywa finansowe", KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInneKrotkoterminoweAKtywaFinansoweB, KrotkoterminoweAktywaFinansoweWPozostalychJednostkachInneKrotkoterminoweAKtywaFinansoweP));
            WynikiKontAktywnych.Add(new WynikKonta("c)", "środki pieniężne i inne aktywa pieniężne", KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneB, KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- środki pieniężne w kasie i na rachunkach", KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneSrodkiPieniezneWKasieINaRachunkuB, KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneSrodkiPieniezneWKasieINaRachunkuP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne środki pieniężne", KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneSrodkiPieniezneB, KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneSrodkiPieniezneP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "- inne aktywa pieniężne", KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneAKtywaPieniezneB, KrotkoterminoweAktywaFinansoweSrodkiPieniezneIInneAktywaPieniezneInneAKtywaPieniezneP));
            WynikiKontAktywnych.Add(new WynikKonta("2", "Inne inwestycje krótkoterminowe", InneInwestycjeKrotkoterminoweB, InneInwestycjeKrotkoterminoweP));
            WynikiKontAktywnych.Add(new WynikKonta("IV", "Krótkoterminowe rozliczenia między okresowe", KrotkoterminoweRozliczeniaMiedzyokresoweB, KrotkoterminoweRozliczeniaMiedzyokresoweP));
            WynikiKontAktywnych.Add(new WynikKonta("C", "Należne wpłaty na kapitał (fundusz) podstawowy", NalezneWplatyNaKapitalFunduszPodstawowyB, NalezneWplatyNaKapitalFunduszPodstawowyP));
            WynikiKontAktywnych.Add(new WynikKonta("D", "Udziały (akcje) własne", UdzialyAkcjeWlasneB, UdzialyAkcjeWlasneP));
            WynikiKontAktywnych.Add(new WynikKonta(" ", "AKTYWA razem (suma poz.A i B i C i D)", AktywaRazemB, AktywaRazemP));

        }

        public void WyliczanieZbiorowPasywnych(DateTime data)
        {
            string dateString = $"31/12/{data.Year - 1}";
            DateTime dataRokPoprzedni = DateTime.ParseExact(dateString, "dd/MM/yyyy", null);
            double WartoscBiezaca;
            double WartoscPoprzednia;

            string[] ZbiorKapitalFunduszWlasny = new string[]
            {
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
                "Odpisy z zysku netto w ciągu roku obrotowego (wielkość ujemna)"
            };

            string[] ZbiorKapitalFunduszZapasowy = new string[]
            {
                "Kapitał (fundusz) zapasowy w tym",
                "Kapitał (fundusz) zapasowy w tym nadwyżka wartości sprzedaży (wartości emisyjnej) nad wartością nominalną udziałów (akcji)"
            };

            string[] ZbiorKapitalFunduszZAktualizacjiWyceny = new string[]
            {
                "Kapitał (fundusz) z aktualizacji wyceny w tym",
                "Kapitał (fundusz) z aktualizacji wyceny w tym z tytułu aktualizacji wartości godziwej"
            };

            string[] ZbiorPozostaleKapitalyFunduszeRezerwowe = new string[]
            {
                "Pozostałe kapitały (fundusze) rezerwowe w tym",
                "Pozostałe kapitały (fundusze) rezerwowe w tym tworzone zgodnie z umową (statusem) spółki",
                "Pozostałe kapitały (fundusze) rezerwowe w tym na udziały (akcje) własne"
            };

            string[] ZbiorRezerwyNaZobowiazania = new string[]
            {
                "Rezerwa na zobowiązania rezerwa z tytułu odroczonego podatku dochodowego",
                "Rezerwa na zobowiązania rezerwa na świadczenia emerytalne i podobne długoterminowa",
                "Rezerwa na zobowiązania rezerwa na świadczenia emerytalne i podobne krótkoterminowa",
                "Rezerwa na zobowiązania pozostałe rezerwy długoterminowe",
                "Rezerwa na zobowiązania pozostałe rezerwy krótkoterminowe"
            };

            string[] PodzbiorRezerwaNaSwiadczeniaEmerytalneIPodobne = new string[]
            {
                "Rezerwa na zobowiązania rezerwa na świadczenia emerytalne i podobne długoterminowa",
                "Rezerwa na zobowiązania rezerwa na świadczenia emerytalne i podobne krótkoterminowa",
            };

            string[] PodzbiorPozostaleRezerwy = new string[]
            {
                "Rezerwa na zobowiązania pozostałe rezerwy długoterminowe",
                "Rezerwa na zobowiązania pozostałe rezerwy krótkoterminowe"
            };

            string[] ZbiorZobowiazaniaDlugoterminowe = new string[]
            {
                "Zobowiązania długoterminowe wobec jednostek powiązanych",
                "Zobowiązania długoterminowe wobec pozostałych jednostek w których jednostak posiada zaangażowanie w kapitale",
                "Zobowiązania długoterminowe wobec pozostałych jednostek kredyty i pożyczki",
                "Zobowiązania długoterminowe wobec pozostałych jednostek z tytułu emisji dłużnych papierów wartościowych",
                "Zobowiązania długoterminowe wobec pozostałych jednostek inne zobowiązania finansowe",
                "Zobowiązania długoterminowe wobec pozostałych jednostek zobowiązania wekselowe",
                "Zobowiązania długoterminowe wobec pozostałych jednostek inne"
            };

            string[] PodzbiorZobowiazaniaDlugoterminoweWobecPozostalychJednostek = new string[]
            {
                "Zobowiązania długoterminowe wobec pozostałych jednostek kredyty i pożyczki",
                "Zobowiązania długoterminowe wobec pozostałych jednostek z tytułu emisji dłużnych papierów wartościowych",
                "Zobowiązania długoterminowe wobec pozostałych jednostek inne zobowiązania finansowe",
                "Zobowiązania długoterminowe wobec pozostałych jednostek zobowiązania wekselowe",
                "Zobowiązania długoterminowe wobec pozostałych jednostek inne"
            };

            string[] ZbiorZobowiazaniaKrotkoterrminowe = new string[]
            {
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
                "Zobowiązania krótkoterminowe fundusze specjalne"
            };

            string[] PodzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanych = new string[]
            {
                "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych inne"
            };

            string[] PodzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresiewymagalnosci = new string[]
            {
                "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy",
            };

            string[] PozdzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostkeWKtorychJednostkaPosiadaZaangazowanieWKapitale = new string[]
            {
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale inne"
            };
            string[] PozdzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostkeWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresiewymagalnosci = new string[]
            {
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy",
            };

            string[] PodzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostek = new string[]
            {
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek kredyty i pożyczki",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu emisji dłużnych papierów wartościowych",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek inne zobowiązania finansowe",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek zaliczki otrzymane na dostawy i usługi",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek zobowiązania wekselowe",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu podatków ceł ubezpieczeńspołecznych i zdrowotnych oraz innych tytułów publicznoprawnych",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu wynagrodzeń",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek inne"
            };

            string[] PodzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluDostawIUslugOOkresieWymagalnosci = new string[]
            {
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy",
                "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy"
            };

            string[] ZbiorRozliczeniaMiedzyokresowe = new string[]
            {
                "Rozliczenia międzyokresowe ujemna wartość firmy",
                "Rozliczenia międzyokresowe inne rozliczenia międzyokresowe długoterminowe",
                "Rozliczenia międzyokresowe inne rozliczenia międzyokresowe krótkoterminowe"
            };

            string[] PodzbiorRozliczeniaMiedzyOkresowe = new string[]
            {
                "Rozliczenia międzyokresowe inne rozliczenia międzyokresowe długoterminowe",
                "Rozliczenia międzyokresowe inne rozliczenia międzyokresowe krótkoterminowe"
            };

            foreach (var item in listaKontWBilansie)
            {
                WartoscBiezaca = 0.0;
                WartoscPoprzednia = 0.0;
                WartoscBiezaca += item.SumaSaldCT(data);
                WartoscPoprzednia += item.SumaSaldCT(dataRokPoprzedni);

                
                if (ZbiorKapitalFunduszWlasny.Contains(item.PolaczenieBilansowe))
                {
                    KapitalFunduszWlasnyB += WartoscBiezaca;
                    KapitalFunduszWlasnyP += WartoscPoprzednia;
                    PasywaB += WartoscBiezaca;
                    PasywaP += WartoscPoprzednia;

                    if (item.PolaczenieBilansowe == "Kapitał (fundusz) podstawowy")
                    {
                        KapitalFunduszPodstawowyB += WartoscBiezaca;
                        KapitalFunduszPodstawowyP += WartoscPoprzednia;
                    }
                    else if (ZbiorKapitalFunduszZapasowy.Contains(item.PolaczenieBilansowe))
                    {
                        KapitalFunduszZapasowyWTymB += WartoscBiezaca;
                        KapitalFunduszZapasowyWTymP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Kapitał (fundusz) zapasowy w tym nadwyżka wartości sprzedaży (wartości emisyjnej) nad wartością nominalną udziałów (akcji)")
                        {
                            KapitalFunduszZapasowyWTymNadwyzkawartosciSprzedazyWartosciEmisyjnejNadWartosciaNominalnaUdzialowAkcjiB += WartoscBiezaca;
                            KapitalFunduszZapasowyWTymNadwyzkawartosciSprzedazyWartosciEmisyjnejNadWartosciaNominalnaUdzialowAkcjiP += WartoscPoprzednia;
                        }
                    }
                    else if (ZbiorKapitalFunduszZAktualizacjiWyceny.Contains(item.PolaczenieBilansowe))
                    {
                        KapitalFunduszZAktualizacjiWycentyWTymB += WartoscBiezaca;
                        KapitalFunduszZAktualizacjiWycentyWTymP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Kapitał (fundusz) z aktualizacji wyceny w tym z tytułu aktualizacji wartości godziwej")
                        {
                            KapitalFunduszZAktualizacjiWycentyWTymZTytuluAktualizacjiWartosciGodziwejB += WartoscBiezaca;
                            KapitalFunduszZAktualizacjiWycentyWTymZTytuluAktualizacjiWartosciGodziwejP += WartoscPoprzednia;
                        }
                    }
                    else if (ZbiorPozostaleKapitalyFunduszeRezerwowe.Contains(item.PolaczenieBilansowe))
                    {
                        PozostaleKapitalyFunduszeRezerwoweWTymB += WartoscBiezaca;
                        PozostaleKapitalyFunduszeRezerwoweWTymP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Pozostałe kapitały (fundusze) rezerwowe w tym tworzone zgodnie z umową (statusem) spółki")
                        {
                            PozostaleKapitalyFunduszeRezerwoweWTymTworzoneZgodnieZUmowaStatutemSpolkiB += WartoscBiezaca;
                            PozostaleKapitalyFunduszeRezerwoweWTymTworzoneZgodnieZUmowaStatutemSpolkiP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Pozostałe kapitały (fundusze) rezerwowe w tym na udziały (akcje) własne")
                        {
                            PozostaleKapitalyFunduszeRezerwoweWTymNaUdzialyAkcjeWlasneB += WartoscBiezaca;
                            PozostaleKapitalyFunduszeRezerwoweWTymNaUdzialyAkcjeWlasneP += WartoscPoprzednia;
                        }
                    }
                    else if (item.PolaczenieBilansowe == "Zysk (strata) z lat ubiegłych")
                    {
                        ZyskStrataZLatUbieglychB += WartoscBiezaca;
                        ZyskStrataZLatUbieglychP += WartoscPoprzednia;
                    }
                    else if (item.PolaczenieBilansowe == "Zysk (strata) netto")
                    {
                        ZyskStrataNettoB += WartoscBiezaca;
                        ZyskStrataNettoP += WartoscPoprzednia;
                    }
                    else if (item.PolaczenieBilansowe == "Odpisy z zysku netto w ciągu roku obrotowego (wielkość ujemna)")
                    {
                        OdpisyZZyskuNettoWCiaguRokuObrotowegoWielkoscUjemnaB += WartoscBiezaca;
                        OdpisyZZyskuNettoWCiaguRokuObrotowegoWielkoscUjemnaP += WartoscPoprzednia;
                    }
                }
                else if (ZbiorRezerwyNaZobowiazania.Contains(item.PolaczenieBilansowe) || ZbiorZobowiazaniaDlugoterminowe.Contains(item.PolaczenieBilansowe) ||
                        ZbiorZobowiazaniaKrotkoterrminowe.Contains(item.PolaczenieBilansowe) || ZbiorRozliczeniaMiedzyokresowe.Contains(item.PolaczenieBilansowe))
                {
                    ZobowiazaniaIRezerwyNaZobowiazaniaB += WartoscBiezaca;
                    ZobowiazaniaIRezerwyNaZobowiazaniaP += WartoscPoprzednia;
                    PasywaB += WartoscBiezaca;
                    PasywaP += WartoscPoprzednia;

                    if (ZbiorRezerwyNaZobowiazania.Contains(item.PolaczenieBilansowe))
                    {
                        RezerwyNaZobowiazaniaB += WartoscBiezaca;
                        RezerwyNaZobowiazaniaP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Rezerwa na zobowiązania rezerwa z tytułu odroczonego podatku dochodowego")
                        {
                            RezerwaZTytuluOdroczonegoPodatkuDochodowegoB += WartoscBiezaca;
                            RezerwaZTytuluOdroczonegoPodatkuDochodowegoP += WartoscPoprzednia;
                        }
                        else if (PodzbiorRezerwaNaSwiadczeniaEmerytalneIPodobne.Contains(item.PolaczenieBilansowe))
                        {
                            RezerwaNaSwiadczeniaEmerytalneIPodobneB += WartoscBiezaca;
                            RezerwaNaSwiadczeniaEmerytalneIPodobneP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Rezerwa na zobowiązania rezerwa na świadczenia emerytalne i podobne długoterminowa")
                            {
                                RezerwaNaSwiadczeniaEmerytalneIPodobneDlugoterminowaB += WartoscBiezaca;
                                RezerwaNaSwiadczeniaEmerytalneIPodobneDlugoterminowaP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Rezerwa na zobowiązania rezerwa na świadczenia emerytalne i podobne krótkoterminowa")
                            {
                                RezerwaNaSwiadczeniaEmerytalneIPodobneKrotkoterminowaB += WartoscBiezaca;
                                RezerwaNaSwiadczeniaEmerytalneIPodobneKrotkoterminowaP += WartoscPoprzednia;
                            }
                        }
                        else if (PodzbiorPozostaleRezerwy.Contains(item.PolaczenieBilansowe))
                        {
                            PozostaleRezerwyB += WartoscBiezaca;
                            PozostaleRezerwyP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Rezerwa na zobowiązania pozostałe rezerwy długoterminowe")
                            {
                                PozostaleRezerwyDlugoterminoweB += WartoscBiezaca;
                                PozostaleRezerwyDlugoterminoweP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Rezerwa na zobowiązania pozostałe rezerwy krótkoterminowe")
                            {
                                PozostaleRezerwyKrotkoterminoweB += WartoscBiezaca;
                                PozostaleRezerwyKrotkoterminoweP += WartoscPoprzednia;
                            }
                        }
                    }
                    else if (ZbiorZobowiazaniaDlugoterminowe.Contains(item.PolaczenieBilansowe))
                    {
                        ZobowiazaniaDlugoterminoweB += WartoscBiezaca;
                        ZobowiazaniaDlugoterminoweP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Zobowiązania długoterminowe wobec jednostek powiązanych")
                        {
                            ZobowiazaniaDlugoterminoweWobecJednostekPowiazanychB += WartoscBiezaca;
                            ZobowiazaniaDlugoterminoweWobecJednostekPowiazanychP += WartoscPoprzednia;
                        }
                        else if (item.PolaczenieBilansowe == "Zobowiązania długoterminowe wobec pozostałych jednostek w których jednostak posiada zaangażowanie w kapitale")
                        {
                            ZobowiazaniaDlugoterminoweWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB += WartoscBiezaca;
                            ZobowiazaniaDlugoterminoweWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP += WartoscPoprzednia;
                        }
                        else if (PodzbiorZobowiazaniaDlugoterminoweWobecPozostalychJednostek.Contains(item.PolaczenieBilansowe))
                        {
                            ZobowiazaniaDlugoterminoweWobecPozostalychJednostekB += WartoscBiezaca;
                            ZobowiazaniaDlugoterminoweWobecPozostalychJednostekP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Zobowiązania długoterminowe wobec pozostałych jednostek kredyty i pożyczki")
                            {
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekKredytyIPozyczkiB += WartoscBiezaca;
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekKredytyIPozyczkiP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania długoterminowe wobec pozostałych jednostek z tytułu emisji dłużnych papierów wartościowych")
                            {
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZTytuluEmisjiDluznychPapierowWartosciowychB += WartoscBiezaca;
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZTytuluEmisjiDluznychPapierowWartosciowychP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania długoterminowe wobec pozostałych jednostek inne zobowiązania finansowe")
                            {
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneZobowiazaniaFinansoweB += WartoscBiezaca;
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneZobowiazaniaFinansoweP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania długoterminowe wobec pozostałych jednostek zobowiązania wekselowe")
                            {
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZobowiazaniaWekseloweB += WartoscBiezaca;
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZobowiazaniaWekseloweP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania długoterminowe wobec pozostałych jednostek inne")
                            {
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneB += WartoscBiezaca;
                                ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneP += WartoscPoprzednia;
                            }
                        }
                    }
                    else if (ZbiorZobowiazaniaKrotkoterrminowe.Contains(item.PolaczenieBilansowe))//tutaj beda zobowiazania krotkoterminowe i elo
                    {
                        ZobowiazaniaKrotkoterminoweB += WartoscBiezaca;
                        ZobowiazaniaKrotkoterminoweP += WartoscPoprzednia;

                        if (PodzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanych.Contains(item.PolaczenieBilansowe))
                        {
                            ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychB += WartoscBiezaca;
                            ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychP += WartoscPoprzednia;

                            if (PodzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresiewymagalnosci.Contains(item.PolaczenieBilansowe))
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciP += WartoscPoprzednia;

                                if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy")
                                {
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB += WartoscBiezaca;
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy")
                                {
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB += WartoscBiezaca;
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP += WartoscPoprzednia;
                                }
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec jednostek powiązanych inne")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychInneB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychInneP += WartoscPoprzednia;
                            }
                        }
                        else if (PozdzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostkeWKtorychJednostkaPosiadaZaangazowanieWKapitale.Contains(item.PolaczenieBilansowe))
                        {
                            ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB += WartoscBiezaca;
                            ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP += WartoscPoprzednia;

                            if (PozdzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostkeWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresiewymagalnosci.Contains(item.PolaczenieBilansowe))
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciP += WartoscPoprzednia;

                                if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy")
                                {
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB += WartoscBiezaca;
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy")
                                {
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB += WartoscBiezaca;
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP += WartoscPoprzednia;
                                }
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek w których jednostka posiada zaangażowanie w kapitale inne")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneP += WartoscPoprzednia;
                            }
                        }
                        else if (PodzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostek.Contains(item.PolaczenieBilansowe))
                        {
                            ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekB += WartoscBiezaca;
                            ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek kredyty i pożyczki")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekKredytyIPozyczkiB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekKredytyIPozyczkiP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu emisji dłużnych papierów wartościowych")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluEmisjiDluznychPapierowWartosciowychB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluEmisjiDluznychPapierowWartosciowychP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek inne zobowiązania finansowe")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneZobowiazaniaFinansoweB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneZobowiazaniaFinansoweP += WartoscPoprzednia;
                            }
                            else if (PodzbiorZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluDostawIUslugOOkresieWymagalnosci.Contains(item.PolaczenieBilansowe))
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciP += WartoscPoprzednia;

                                if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu dostaw i usług o okresie wymagalności do 12 miesięcy")
                                {
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB += WartoscBiezaca;
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP += WartoscPoprzednia;
                                }
                                else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu dostaw i usług o okresie wymagalności powyżej 12 miesięcy")
                                {
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB += WartoscBiezaca;
                                    ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP += WartoscPoprzednia;
                                }
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek zaliczki otrzymane na dostawy i usługi")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZaliczkiOtrzymaneNaDostawyIUslugiB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZaliczkiOtrzymaneNaDostawyIUslugiP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek zobowiązania wekselowe")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZobowiazaniaWekseloweB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZobowiazaniaWekseloweP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu podatków ceł ubezpieczeńspołecznych i zdrowotnych oraz innych tytułów publicznoprawnych")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluPodatkowCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoPrawnychB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluPodatkowCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoPrawnychP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek z tytułu wynagrodzeń")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluWynagrodzenB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluWynagrodzenP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe zobowiązania wobec pozostałych jednostek inne")
                            {
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneB += WartoscBiezaca;
                                ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneP += WartoscPoprzednia;
                            }

                        }
                        else if (item.PolaczenieBilansowe == "Zobowiązania krótkoterminowe fundusze specjalne")
                        {
                            ZobowiazaniaKrotkoterminoweFunduszeSpecjalneB += WartoscBiezaca;
                            ZobowiazaniaKrotkoterminoweFunduszeSpecjalneP += WartoscPoprzednia;
                        }
                    }
                    else if (ZbiorRozliczeniaMiedzyokresowe.Contains(item.PolaczenieBilansowe))
                    {
                        RozliczeniaMiedzyokresoweB += WartoscBiezaca;
                        RozliczeniaMiedzyokresoweP += WartoscPoprzednia;

                        if (item.PolaczenieBilansowe == "Rozliczenia międzyokresowe ujemna wartość firmy")
                        {
                            UjemnaWartoscFirmyB += WartoscBiezaca;
                            UjemnaWartoscFirmyP += WartoscPoprzednia;
                        }
                        else if (PodzbiorRozliczeniaMiedzyOkresowe.Contains(item.PolaczenieBilansowe))
                        {
                            RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweB += WartoscBiezaca;
                            RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweP += WartoscPoprzednia;

                            if (item.PolaczenieBilansowe == "Rozliczenia międzyokresowe inne rozliczenia międzyokresowe długoterminowe")
                            {
                                RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweDlugoterminoweB += WartoscBiezaca;
                                RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweDlugoterminoweP += WartoscPoprzednia;
                            }
                            else if (item.PolaczenieBilansowe == "Rozliczenia międzyokresowe inne rozliczenia międzyokresowe krótkoterminowe")
                            {
                                RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweKrotkoterminoweB += WartoscBiezaca;
                                RozliczeniaMiedzyokresoweInneRozliczeniaMiedzyokresoweKrotkoterminoweP += WartoscPoprzednia;
                            }
                        }
                    }
                }

            }
        }

        public void WczytanieWyliczonychDanychPasywnych()
        {
            WynikiKontPasywnych.Add(new WynikKonta("A", "Kapitał (fundusz) własny", KapitalFunduszWlasnyB, KapitalFunduszWlasnyP));
            WynikiKontPasywnych.Add(new WynikKonta("I", "Kapitał (fundusz) podstawowy", KapitalFunduszPodstawowyB, KapitalFunduszPodstawowyP));
            WynikiKontPasywnych.Add(new WynikKonta("II", "Kapitał (fundusz) zapasowy w tym:", KapitalFunduszZapasowyWTymB, KapitalFunduszZapasowyWTymP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- nadwyżka wartości sprzedaży (wartości emisyjnej) nad wartością nominalną udziałów (akcji)", KapitalFunduszZapasowyWTymNadwyzkawartosciSprzedazyWartosciEmisyjnejNadWartosciaNominalnaUdzialowAkcjiB, KapitalFunduszZapasowyWTymNadwyzkawartosciSprzedazyWartosciEmisyjnejNadWartosciaNominalnaUdzialowAkcjiP));
            WynikiKontPasywnych.Add(new WynikKonta("III", "Kapitał (fundusz) z akutalizacji wyceny, w tym:", KapitalFunduszZAktualizacjiWycentyWTymB, KapitalFunduszZAktualizacjiWycentyWTymP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- z tytułu aktualizacji wartości godziwej", KapitalFunduszZAktualizacjiWycentyWTymZTytuluAktualizacjiWartosciGodziwejB, KapitalFunduszZAktualizacjiWycentyWTymZTytuluAktualizacjiWartosciGodziwejP));
            WynikiKontPasywnych.Add(new WynikKonta("IV", "Pozostałe kapitały (fundusze) rezerwowe, w tym:", PozostaleKapitalyFunduszeRezerwoweWTymB, PozostaleKapitalyFunduszeRezerwoweWTymP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- tworzenie zgodnie z umową (statutem) spółki", PozostaleKapitalyFunduszeRezerwoweWTymTworzoneZgodnieZUmowaStatutemSpolkiB, PozostaleKapitalyFunduszeRezerwoweWTymTworzoneZgodnieZUmowaStatutemSpolkiP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- na udziały (akcje) własne", PozostaleKapitalyFunduszeRezerwoweWTymNaUdzialyAkcjeWlasneB, PozostaleKapitalyFunduszeRezerwoweWTymNaUdzialyAkcjeWlasneP));
            WynikiKontPasywnych.Add(new WynikKonta("V", "Zysk (strata) z lat ubiegłych", ZyskStrataZLatUbieglychB, ZyskStrataZLatUbieglychP));

            WynikiKontPasywnych.Add(new WynikKonta("VI", "Zysk (strata) netto", ZyskStrataNettoB, ZyskStrataNettoP));
            WynikiKontPasywnych.Add(new WynikKonta("VII", "Odpisy z zysku netto w ciągu roku obrotowego (wielkość ujemna)", OdpisyZZyskuNettoWCiaguRokuObrotowegoWielkoscUjemnaB, OdpisyZZyskuNettoWCiaguRokuObrotowegoWielkoscUjemnaP));

            WynikiKontPasywnych.Add(new WynikKonta("B", "Zobowiązania i rezerwy na zobowiązania", ZobowiazaniaIRezerwyNaZobowiazaniaB, ZobowiazaniaIRezerwyNaZobowiazaniaP));
            WynikiKontPasywnych.Add(new WynikKonta("I", "Rezerwy na zobowiązania", RezerwyNaZobowiazaniaB, RezerwyNaZobowiazaniaP));
            WynikiKontPasywnych.Add(new WynikKonta("1", "Rezerwy z tytułu odroczonego podatku dochodowego", RezerwaZTytuluOdroczonegoPodatkuDochodowegoB, RezerwaZTytuluOdroczonegoPodatkuDochodowegoP));
            WynikiKontPasywnych.Add(new WynikKonta("2", "Rezerwy na świadczenia emerytalne i podobne", RezerwaNaSwiadczeniaEmerytalneIPodobneB, RezerwaNaSwiadczeniaEmerytalneIPodobneP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- długoterminowe", RezerwaNaSwiadczeniaEmerytalneIPodobneDlugoterminowaB, RezerwaNaSwiadczeniaEmerytalneIPodobneDlugoterminowaP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- krótkoterminowe", RezerwaNaSwiadczeniaEmerytalneIPodobneKrotkoterminowaB, RezerwaNaSwiadczeniaEmerytalneIPodobneKrotkoterminowaP));
            WynikiKontPasywnych.Add(new WynikKonta("3", "Pozostałe rezerwy", PozostaleRezerwyB, PozostaleRezerwyP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- dłogoterminowe", PozostaleRezerwyDlugoterminoweB, PozostaleRezerwyDlugoterminoweP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- krótkoterminowe", PozostaleRezerwyKrotkoterminoweB, PozostaleRezerwyKrotkoterminoweP));

            WynikiKontPasywnych.Add(new WynikKonta("II", "Zobowiązania długoterminowe", ZobowiazaniaDlugoterminoweB, ZobowiazaniaDlugoterminoweP));
            WynikiKontPasywnych.Add(new WynikKonta("1", "Wobec jednostek powiązanych", ZobowiazaniaDlugoterminoweWobecJednostekPowiazanychB, ZobowiazaniaDlugoterminoweWobecJednostekPowiazanychP));
            WynikiKontPasywnych.Add(new WynikKonta("2", "Wobec pozostałych jednostek, w których jednostka posiada zaangażowanie w kapitale", ZobowiazaniaDlugoterminoweWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP));
            WynikiKontPasywnych.Add(new WynikKonta("3", "Wobec pozostałych jednostek", ZobowiazaniaDlugoterminoweWobecPozostalychJednostekB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekP));
            WynikiKontPasywnych.Add(new WynikKonta("a)", "Kredyty i pożyczki", ZobowiazaniaDlugoterminoweWobecPozostalychJednostekKredytyIPozyczkiB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekKredytyIPozyczkiP));
            WynikiKontPasywnych.Add(new WynikKonta("b)", "Z tytułu emijsi dłużnych papierów wartościowych", ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZTytuluEmisjiDluznychPapierowWartosciowychB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZTytuluEmisjiDluznychPapierowWartosciowychP));
            WynikiKontPasywnych.Add(new WynikKonta("c)", "inne zobowiązania finansowe", ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneZobowiazaniaFinansoweB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneZobowiazaniaFinansoweP));
            WynikiKontPasywnych.Add(new WynikKonta("d)", "zobowiązania weksolwe", ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZobowiazaniaWekseloweB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekZobowiazaniaWekseloweP));
            WynikiKontPasywnych.Add(new WynikKonta("e)", "inne", ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneB, ZobowiazaniaDlugoterminoweWobecPozostalychJednostekInneP));

            WynikiKontPasywnych.Add(new WynikKonta("III", "Zobowiązania krótkoterminowe", ZobowiazaniaKrotkoterminoweB, ZobowiazaniaKrotkoterminoweP));
            WynikiKontPasywnych.Add(new WynikKonta("1", "Zobowiązania wobec jednostek powiązanych", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychP));
            WynikiKontPasywnych.Add(new WynikKonta("a)", "z tytułu dostaw i usług, o okresie wymagalności", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- do 12 miesięcy", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- powyżej 12 miesięcy", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP));
            WynikiKontPasywnych.Add(new WynikKonta("b)", "inne", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychInneB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecJednostekPowiazanychInneP));
            WynikiKontPasywnych.Add(new WynikKonta("2", "Zobowiązania wobec pozostałych jednostek, w których jednostka posiada zaangażowanie w kapitale", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleP));
            WynikiKontPasywnych.Add(new WynikKonta("a)", "z tytułu dostaw i usług, o okresie wymagalności", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- do 12 miesięcy", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- powyżej 12 miesięcy", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleZTytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP));
            WynikiKontPasywnych.Add(new WynikKonta("b)", "inne", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekWKtorychJednostkaPosiadaZaangazowanieWKapitaleInneP));
            WynikiKontPasywnych.Add(new WynikKonta("3", "Zobowiązania wobec pozostałych jednostek", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekP));
            WynikiKontPasywnych.Add(new WynikKonta("a)", "kredyty i pożyczki", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekKredytyIPozyczkiB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekKredytyIPozyczkiP));
            WynikiKontPasywnych.Add(new WynikKonta("b)", "z tytułu emisji dłużnych papierów wartościowych", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluEmisjiDluznychPapierowWartosciowychB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluEmisjiDluznychPapierowWartosciowychP));
            WynikiKontPasywnych.Add(new WynikKonta("c)", "inne zobowiązania finansowe", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneZobowiazaniaFinansoweB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneZobowiazaniaFinansoweP));
            WynikiKontPasywnych.Add(new WynikKonta("d)", "z tytułu dostaw i usług o okresie wymagalności", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- do 12 miesięcy", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciDo12MiesiecyP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "- powyżej 12 miesięcy", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluDostawIUslugOOkresieWymagalnosciPowyzej12MiesiecyP));
            WynikiKontPasywnych.Add(new WynikKonta("e)", "zaliczki otrzymane na dostawy i usługi", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZaliczkiOtrzymaneNaDostawyIUslugiB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZaliczkiOtrzymaneNaDostawyIUslugiP));
            WynikiKontPasywnych.Add(new WynikKonta("f)", "zobowiązania wekslowe", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZobowiazaniaWekseloweB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZobowiazaniaWekseloweP));
            WynikiKontPasywnych.Add(new WynikKonta("g)", "z tytułu podatków, ceł, ubezpieczeń społecznych i zdrowotnych oraz innych tytułów publicznoprawnych", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluPodatkowCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoPrawnychB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZtytuluPodatkowCelUbezpieczenSpolecznychIZdrowotnychOrazInnychTytulowPublicznoPrawnychP));
            WynikiKontPasywnych.Add(new WynikKonta("h)", "z tytułu wynagrodzeń", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluWynagrodzenB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekZTytuluWynagrodzenP));
            WynikiKontPasywnych.Add(new WynikKonta("i)", "inne", ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneB, ZobowiazaniaKrotkoterminoweZobowiazaniaWobecPozostalychJednostekInneP));
            WynikiKontPasywnych.Add(new WynikKonta("4", "Fundusze specjalne", ZobowiazaniaKrotkoterminoweFunduszeSpecjalneB, ZobowiazaniaKrotkoterminoweFunduszeSpecjalneP));
            WynikiKontPasywnych.Add(new WynikKonta(" ", "PASYWA razem (suma poz. A i B)", PasywaB, PasywaP));

        }

        public bool CzyAktywaRownePasywom()
        {
            if (AktywaRazemB == PasywaB)
            {
                return false;
            }
            else 
                return true;
        }
    }
}
