using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    /*
     * Vi har lavet en ny klasse, som er med til at skabe objekter (i dette tilfælde køretøjer), som sidenhen 
     * kan registreres i systemet. Klassen og koden herunder er udelukkende til for, at skabe en skabelon for,
     * hvordan vi ønsker at repræsentere køretøjer i dette system. Med skabelon menes der, at vi udelukkende
     * fortæller om, hvilke typer af informationer, som skal være med til at repræsentere køretøjer, bemærk, at
     * vi ikke på noget tidspunkt i denne fil siger noget om konkret eller specifik information, som skal kobles
     * op imod et specifikt køretøj! Dette er en generel beskrivelse af typer af informationer, som udgør køretøjer
     * i dette system.
     */
    public class Vehicle
    {
        // class variables/fields
        /*
         * Disse klasse variable er reserverede til den pågældende 'Vehicle' klasse.
         * Gennem 'private' nøgleordet, så giver vi disse variable en lag af beskyttelse,
         * og kapsler dem ind, sammen med objekter af klassen 'Vehicle'. Vi har hermed gjort
         * brug af første grundprincip i Objekt-Orienteret Programmering (OOP), nemlig Indkapsling.
         * */
        private int horsePower;
        private string registration;
        private int cost;

        // constructors, a method
        /*
         * En konstruktør er en specielt designet metode, som ikke gør brug af en returtype!
         * Metoder plejer at komme med en returtype a la: int, string, double, void og mange flere,
         * men med en konstruktør undlader man at medtage dette. Desuden er en konstruktør altid 
         * offentlig tilgængelig gennem hele projektet ('public'). Og konstruktøren har altid fuldstændig
         * det samme navn som klassen. Desuden kommer konstruktøren med et sæt input-argumenter, som
         * afspejler fuldstændig de klasse-variable, som er blevet skabt på linjerne ovenfor.
         * Bemærk: horsePower på venstre side af lighedstegnet (linje 46) ikke er det samme som, det 
         * på højre side af lighedstegnet! horsePower på venstre er selve vores klasse-variabel, som
         * fremkaldes gennem 'this' nøgleordet, imens horsePower på højre side af lighedstegnet er et
         * input argument.
         */
        public Vehicle(int horsePower, string registration, int cost) 
        {
            this.horsePower = horsePower;
            this.registration = registration;
            this.cost = cost;
        }

        // helper method, get- and set-methods
        /*
         * get metoder er med til at hente specifikt information frem! Informationen er skjult i hukkommelsen,
         * indtil man rent faktisk anvender en get metode. I virkeligheden, så kunne vi have én get metode for hver
         * klasse-variabel, men i nedenstående tilfælde henter vi kun antal hestekræfter og prisen på en bil frem.
         * set metoder er med til at overskrive en klassevariabel med en ny værdi, ligesåsnart at der er brug for dette.
         * set metoder er ikke obligatoriske, og man kan undlade at have dem med. I understående kode, så har vi
         * kun én set metode med setCost, som er med til at overskrive prisen på en bil, og sætte en ny pris ind.
         * Dette giver mening, hvis brugtbils-forretningen holder udsalg på biler.
         */
        public int getHorsePower() 
        {
            return this.horsePower;
        }

        public int getCost() 
        {
            return this.cost;
        }

        public void setCost(int newCost)
        {
            this.cost = newCost;
        }
    }
}
