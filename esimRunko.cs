using System;
using System.Collections.Generic;

namespace henkilötietoorganisoija
{
    // Voit käyttää Henkilo-luokkaa tietojen hallinnointiin
    class Henkilo
    {
        public string nimi;
        public Henkilo(string n = "")
        {
            nimi = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Jos haluat voit yrittää laittaa tähän salasanasuojauksen
            // eli vain oikealla käyttäjätunnus/salasana -parilla
            // pystyy käyttämään ohjelmaa
            //

            // Mieti ensin tarkkaan alkutoteutus
            // miten aioit säilyttää tiedon muistissa 
            // Vaihtoehtoja on oikeastaan kaksi
            // joko käytät luokkaa henkilö ja talletat ne listaan
            // tai sitten käytät taulukkomuuttujia Array
            // joista kuhunkintulee tietty tieto

            // Jos et ole varma suunnittelusta,kysy opettajalta, koska 
            // tämä päätös vaikuttaa hyvin paljon koko loppuosion tehtäviin



            while (true)
            {
                // Tulostetaan käyttäjälle tiedot
                Console.WriteLine("Valitse toiminto:");
                Console.WriteLine("1.Tulosta henkilötiedot");
                Console.WriteLine("2.Lisää henkilötieto");
                Console.WriteLine("3.Lue tiedostosta");
                Console.WriteLine("4.Kirjoita tiedostoon");
                Console.WriteLine("5.Poista henkilötieto");
                Console.WriteLine("6.Muokkaa henkilötietoa");
                Console.WriteLine("7.Etsi henkilötiedoista");
                Console.WriteLine("8.Lopeta");

                // Luetaan käyttäjältä syöte
                int valinta = int.Parse(Console.ReadLine());
                switch (valinta)
                {
                    case 1:
                        Console.WriteLine("Tulosta tiedot valittu"); // Tämän voi poistaa
                        // kirjoita tähän koodi jolla tulostetaan muistissa olevien käyttäjien tiedot
                        break;
                    case 2:
                        Console.WriteLine("Tiedon lisäys valittu");// Tämän voi poistaa
                        // kirjoita tähän koodi, joka lisää uuden tiedon (henkilön) muistiin
                        // Jos käytät luokkia, niin voit luoda ensin tyhjän henkilön ja sen 
                        // jälkeen liittää siihen annetut ominaisuudet
                        // Muista lopuksi tallettaa luotu henkilö muistiin
                        break;
                    case 3:
                        Console.WriteLine("Tietojen lukeminen tiedostosta valittu.");
                        // Tämä osio ei ole välttämätön,
                        // Jos toteutat tämän osan ohjelmaa,
                        // voit myös asettaa sen toimimaan heti ohjelman käynnistyessä.

                        // Esimerkki:
                        // jos luet käyttäjien tiedot tiedostosta
                        // Esim: Jos data.txt näyttää tältä:
                        // Pertti Haurinen:21:kalastus
                        // voit lukea tiedoston ja muuttaa tiedoston 
                        // sisällön henkilötieto alkioiksi , jotka talletat 
                        // muistiin
                        break;
                    case 4:
                        Console.WriteLine("Tietojen kirjoittaminen tiedostoon valittu.");
                        // Tämä osio ei ole pakollinen
                        // Ohjelman toiminta tulee paljon järkevämmäksi,
                        // jos muistissa oleva tieto voidaan tallettaa
                        // tiedostoon
                        // Jos toteutat tämän, niin kannattaa yrittää käyttää
                        // pilkku tai esim puolipiste erotinta
                        // Googlaa : C# split string
                        break;
                    case 5:
                        Console.WriteLine("Tietojen poistaminen valittu");
                        // Tämä osio voisi esim for-silmukassa tulostaa
                        // ensin kaikki muistissa olevat tiedot ja viereen
                        // tiedon indeksin muistissa ja tämän jälkeen  
                        // käyttäjä voisi valita indeksinumeron,
                        // jonka kone poistaisi muistista 
                        // Esim:
                        // https://www.dotnetperls.com/list-remove
                        break;
                    case 6:
                        Console.WriteLine("Tietojen muokkaaminen valittu");
                        // Vinkki: näytä ensin käyttäjälle tiedot
                        // ja anna hänen tehdä valinta, ota sitten
                        // käyttäjältä uudet tiedot
                        break;
                    case 7:
                        Console.WriteLine("Tietojen etsiminen valittu");
                        // Vinkki: voit luupata kaikkien tietojen läpi 
                        // ja etsiä niistähakusanaa komennolla 
                        // https://www.dotnetperls.com/indexof
                        break;
                    case 8:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Tarkista valinta");
                        break;
                } // switch
            } // while            
        } // main
    } // class 
} // namespace
