using System;

namespace KamilCieślikLab2PD
{
    [Serializable]
    public class LordSith : Sith
    {
        public string SpecialPower { set; get; }
        public int NumberOfHolocrones { get; set; }
        public string KindOfPossesedArmy { get; set; }

        public LordSith(string name, string planet, string imagePath, int yearOfBirth, bool wasJedi, string colourOfLightsaber, string lightsaberCombat, int amountOfKilledJedi,
            int yearOfDeath, string specialPower, int numberOfHolocrones, string kindOfPossesedArmy) : base(planet, yearOfBirth, wasJedi, colourOfLightsaber, lightsaberCombat, amountOfKilledJedi, yearOfDeath, imagePath)
        {
            Name = "Lord Sith " + name;
            SpecialPower = specialPower;
            NumberOfHolocrones = numberOfHolocrones;
            KindOfPossesedArmy = kindOfPossesedArmy;
        }

        public LordSith(string name, string planet, string imagePath, int yearOfBirth, bool wasJedi, string colourOfLightsaber, string lightsaberCombat, int amountOfKilledJedi,
            string specialPower, int numberOfHolocrones, string kindOfPossesedArmy) : base(planet, yearOfBirth, wasJedi, colourOfLightsaber, lightsaberCombat, amountOfKilledJedi, imagePath)
        {
            Name = "Lord Sith " + name;
            SpecialPower = specialPower;
            NumberOfHolocrones = numberOfHolocrones;
            KindOfPossesedArmy = kindOfPossesedArmy;
        }
        /// <summary>
        /// Rozszerzenie metody odziedziczonej po klasie Sith.
        /// Metoda odpowiada za poprawne wyświetlanie atrybutów obiektu.
        /// </summary>
        /// <returns></returns>
        public override string View()
        {
            return base.View() + "" + Environment.NewLine + "Specjalna umiejętność: " + SpecialPower + "." + Environment.NewLine + "Ilość tajemniczych źródeł wiedzy - HOLOKRONÓW: " + NumberOfHolocrones + "." + Environment.NewLine + "Rodzaj posiadanej armi: " + KindOfPossesedArmy + ".";
        }
    }
}
