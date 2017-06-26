using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamilCieślikLab2PD
{
    [Serializable]
    public class Sith
    {
        public string Name { get; set; }
        public string Planet { get; set; }
        public string ImagePath { get; set; }
        public int YearOfBirth { get; set; }
        public bool WasJedi { get; set; }
        public string ColourOfLightsaber { get; set; }
        public string LightsaberCombat { get; set; }
        public int AmountOfKilledJedi { get; set; }
        public int YearOfDeath { get; set; }

        public Sith()
        {

        }

        public Sith(string name, string planet, int yearOfBirth, bool wasJedi, string colourOfLightSaber, string lightSaberCombat, int amountOfKilledJedi, int yearOfDeath, string imagepath)
        {
            this.Name = "Darth " +name;
            this.Planet = planet;
            this.YearOfBirth = yearOfBirth;
            this.WasJedi = wasJedi;
            this.ColourOfLightsaber = colourOfLightSaber;
            this.LightsaberCombat = lightSaberCombat;
            this.AmountOfKilledJedi = amountOfKilledJedi;
            this.YearOfDeath = yearOfDeath;
           this.ImagePath = imagepath;
        }

        public Sith(string name, string planet, int yearOfBirth, bool wasJedi, string colourOfLightSaber, string lightSaberCombat, int amountOfKilledJedi, string imagepath)
        {
            this.Name = "Darth " + name;
            this.Planet = planet;
            this.YearOfBirth = yearOfBirth;
            this.WasJedi = wasJedi;
            this.ColourOfLightsaber = colourOfLightSaber;
            this.LightsaberCombat = lightSaberCombat;
            this.AmountOfKilledJedi = amountOfKilledJedi;
            this.ImagePath = imagepath;
        }

        public Sith(string planet, int yearOfBirth, bool wasJedi, string colourOfLightSaber, string lightSaberCombat, int amountOfKilledJedi, int yearOfDeath, string imagepath)
        {
            this.Planet = planet;
            this.YearOfBirth = yearOfBirth;
            this.WasJedi = wasJedi;
            this.ColourOfLightsaber = colourOfLightSaber;
            this.LightsaberCombat = lightSaberCombat;
            this.AmountOfKilledJedi = amountOfKilledJedi;
            this.YearOfDeath = yearOfDeath;
            this.ImagePath = imagepath;
        }

        public Sith( string planet, int yearOfBirth, bool wasJedi, string colourOfLightSaber, string lightSaberCombat, int amountOfKilledJedi, string imagepath)
        {
            this.Planet = planet;
            this.YearOfBirth = yearOfBirth;
            this.WasJedi = wasJedi;
            this.ColourOfLightsaber = colourOfLightSaber;
            this.LightsaberCombat = lightSaberCombat;
            this.AmountOfKilledJedi = amountOfKilledJedi;
            this.ImagePath = imagepath;
        }

        public virtual string View()
        {
            DateTime current = DateTime.Now;
            int currentYear = current.Year;

            string temporaryFaith = "";
            if (this.WasJedi == true) temporaryFaith = "Jedi - JASNA STRONA MOCY";
            else temporaryFaith = "Sith - CIEMNA STRONA MOCY";
            int temporaryAge;
            if (this.YearOfDeath == 0)
            {
                temporaryAge = currentYear - YearOfBirth;
                return ("Imię: " + Name +"."+ Environment.NewLine+"Planeta pochodzenia: " + Planet +"."+ Environment.NewLine + "Rok urodzenia: " + YearOfBirth + ". Wiek: " + temporaryAge +"."+ Environment.NewLine + "Początkowe wyznanie: " + temporaryFaith +"."+ Environment.NewLine + "Kolor kryształu miecza świetlnego: " + ColourOfLightsaber +"."+ Environment.NewLine + "Styl walki mieczem świetlnym: " + LightsaberCombat +"."+ Environment.NewLine + "Liczba unicestwionych Jedi: " + AmountOfKilledJedi+".");
            }
            else
            {
                temporaryAge = YearOfDeath - YearOfBirth;
                return ("Imię: " + Name +"."+ Environment.NewLine + "Planeta pochodzenia: " + Planet +"."+ Environment.NewLine + "Rok urodzenia: " + YearOfBirth + ". Żył: " + temporaryAge + " lat. Zmarł w "+YearOfDeath+" roku." + Environment.NewLine +"Początkowe wyznanie: " + temporaryFaith +"."+ Environment.NewLine + "Kolor kryształu miecza świetlnego: " + ColourOfLightsaber +"."+ Environment.NewLine + "Styl walki mieczem świetlnym: " + LightsaberCombat +"."+ Environment.NewLine + "Liczba unicestwionych Jedi: " + AmountOfKilledJedi+".");
            }

        }

    }
}