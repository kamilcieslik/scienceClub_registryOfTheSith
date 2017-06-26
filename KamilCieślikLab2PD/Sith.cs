using System;

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
            Name = "Darth " + name;
            Planet = planet;
            YearOfBirth = yearOfBirth;
            WasJedi = wasJedi;
            ColourOfLightsaber = colourOfLightSaber;
            LightsaberCombat = lightSaberCombat;
            AmountOfKilledJedi = amountOfKilledJedi;
            YearOfDeath = yearOfDeath;
            ImagePath = imagepath;
        }

        public Sith(string name, string planet, int yearOfBirth, bool wasJedi, string colourOfLightSaber, string lightSaberCombat, int amountOfKilledJedi, string imagepath)
        {
            Name = "Darth " + name;
            Planet = planet;
            YearOfBirth = yearOfBirth;
            WasJedi = wasJedi;
            ColourOfLightsaber = colourOfLightSaber;
            LightsaberCombat = lightSaberCombat;
            AmountOfKilledJedi = amountOfKilledJedi;
            ImagePath = imagepath;
        }

        public Sith(string planet, int yearOfBirth, bool wasJedi, string colourOfLightSaber, string lightSaberCombat, int amountOfKilledJedi, int yearOfDeath, string imagepath)
        {
            Planet = planet;
            YearOfBirth = yearOfBirth;
            WasJedi = wasJedi;
            ColourOfLightsaber = colourOfLightSaber;
            LightsaberCombat = lightSaberCombat;
            AmountOfKilledJedi = amountOfKilledJedi;
            YearOfDeath = yearOfDeath;
            ImagePath = imagepath;
        }

        public Sith(string planet, int yearOfBirth, bool wasJedi, string colourOfLightSaber, string lightSaberCombat, int amountOfKilledJedi, string imagepath)
        {
            Planet = planet;
            YearOfBirth = yearOfBirth;
            WasJedi = wasJedi;
            ColourOfLightsaber = colourOfLightSaber;
            LightsaberCombat = lightSaberCombat;
            AmountOfKilledJedi = amountOfKilledJedi;
            ImagePath = imagepath;
        }

        public virtual string View()
        {
            var current = DateTime.Now;
            var currentYear = current.Year;

            var temporaryFaith = WasJedi ? "Jedi - JASNA STRONA MOCY" : "Sith - CIEMNA STRONA MOCY";
            int temporaryAge;
            if (YearOfDeath == 0)
            {
                temporaryAge = currentYear - YearOfBirth;
                return ("Imię: " + Name + "." + Environment.NewLine + "Planeta pochodzenia: " + Planet + "." + Environment.NewLine + "Rok urodzenia: " + YearOfBirth +
                    ". Wiek: " + temporaryAge + "." + Environment.NewLine + "Początkowe wyznanie: " + temporaryFaith + "." + Environment.NewLine +
                    "Kolor kryształu miecza świetlnego: " + ColourOfLightsaber + "." + Environment.NewLine + "Styl walki mieczem świetlnym: " + LightsaberCombat +
                    "." + Environment.NewLine + "Liczba unicestwionych Jedi: " + AmountOfKilledJedi + ".");
            }
            else
            {
                temporaryAge = YearOfDeath - YearOfBirth;
                return ("Imię: " + Name + "." + Environment.NewLine + "Planeta pochodzenia: " + Planet + "." + Environment.NewLine + "Rok urodzenia: " + YearOfBirth +
                    ". Żył: " + temporaryAge + " lat. Zmarł w " + YearOfDeath + " roku." + Environment.NewLine + "Początkowe wyznanie: " + temporaryFaith + "." + Environment.NewLine +
                    "Kolor kryształu miecza świetlnego: " + ColourOfLightsaber + "." + Environment.NewLine + "Styl walki mieczem świetlnym: " + LightsaberCombat +
                    "." + Environment.NewLine + "Liczba unicestwionych Jedi: " + AmountOfKilledJedi + ".");
            }

        }

    }
}