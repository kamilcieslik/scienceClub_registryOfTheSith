using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamilCieślikLab2PD
{
    [Serializable]
    public class LordSith:Sith
    {

        public string SpecialPower { set; get; }
        public int NumberOfHolocrones { get; set; }
        public string KindOfPossesedArmy { get; set; }

        public LordSith(string Name, string Planet, string ImagePath, int YearOfBirth, bool WasJedi, string ColourOfLightsaber, string LightsaberCombat, int AmountOfKilledJedi, 
            int YearOfDeath, string SpecialPower,int NumberOfHolocrones, string KindOfPossesedArmy) :base(Planet,YearOfBirth,WasJedi,ColourOfLightsaber,LightsaberCombat,AmountOfKilledJedi,YearOfDeath,ImagePath)

        {
            this.Name = "Lord Sith " + Name;
            this.SpecialPower = SpecialPower;
            this.NumberOfHolocrones = NumberOfHolocrones;
            this.KindOfPossesedArmy = KindOfPossesedArmy;
        }

        public LordSith(string Name, string Planet, string ImagePath, int YearOfBirth, bool WasJedi, string ColourOfLightsaber, string LightsaberCombat, int AmountOfKilledJedi,
            string SpecialPower, int NumberOfHolocrones, string KindOfPossesedArmy) : base(Planet, YearOfBirth, WasJedi, ColourOfLightsaber, LightsaberCombat, AmountOfKilledJedi, ImagePath)
        {
            this.Name = "Lord Sith " + Name;
            this.SpecialPower = SpecialPower;
            this.NumberOfHolocrones = NumberOfHolocrones;
            this.KindOfPossesedArmy = KindOfPossesedArmy;
        }
        /// <summary>
        /// Rozszerzenie metody odziedziczonej po klasie Sith.
        /// Metoda odpowiada za poprawne wyświetlanie atrybutów obiektu.
        /// </summary>
        /// <returns></returns>
        public override string View()
        {
            return base.View()+"" + Environment.NewLine+"Specjalna umiejętność: "+SpecialPower+"."+ Environment.NewLine+"Ilość tajemniczych źródeł wiedzy - HOLOKRONÓW: "+NumberOfHolocrones+"." + Environment.NewLine+"Rodzaj posiadanej armi: "+KindOfPossesedArmy+".";
        }
    }
}
