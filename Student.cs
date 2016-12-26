using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4
{
    class Student:Osoba
    {
        protected int Rok;
        protected int nrGrupy;
        public Student() { }
        public Student(string Imie,string Nazwisko,int rokUr,int Rok,int nrGrupy,string miejsceZamieszkania)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.rokUr = rokUr;
            this.Rok = Rok;
            this.nrGrupy = nrGrupy;
            ustawMiejsce(miejsceZamieszkania);
        }
        public void wypiszInfo()
        {
            Console.WriteLine("Imie :{0}, Nazwisko: {1}, rokUr: {2}, Rok: {3}, nrGrupy: {4}, miejsceZam: {5}", Imie, Nazwisko, rokUr,Rok,nrGrupy,zwracamMiejsce());
        }
    }
}
