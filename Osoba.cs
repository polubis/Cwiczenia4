using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4
{
    class Osoba
    {
        protected string Imie;
        protected string Nazwisko;
        protected int rokUr;
        private string miejsceZamieszkania;
        public Osoba() { }
        public Osoba(string Imie,string Nazwisko,int rokUr)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.rokUr = rokUr;
        }
        public void wypiszInfo()
        {
            Console.WriteLine("Imie :{0}, Nazwisko: {1}, rokUr: {2}", Imie, Nazwisko, rokUr);
        }
        public void obliczWiek()
        {
            Console.WriteLine(DateTime.Today.Year - rokUr);
        }
        public void ustawMiejsce(string Miejsce)
        {
            miejsceZamieszkania = Miejsce;

        }
        public string zwracamMiejsce()
        {
            return miejsceZamieszkania;
        }
    }
}
