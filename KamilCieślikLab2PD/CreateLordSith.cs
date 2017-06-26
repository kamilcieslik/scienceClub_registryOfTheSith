using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamilCieślikLab2PD
{
    public partial class CreateLordSith : Form
    {
        private List<LordSith> listOfLordSith;

        public CreateLordSith(List<LordSith> listOfLordSith)
        {
            InitializeComponent();
            this.listOfLordSith = listOfLordSith;
            pictureBoxSithImage.Image = Properties.Resources.defaultImage;
        }

        public List<LordSith> ListOfLordSith
        {
            get
            {
                return listOfLordSith;
            }

            set
            {
                listOfLordSith = value;
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za sprawdzanie poprawności danych wpisywanych do textBox'ów. 
        /// W sytuacji gdy dane zostały wprowadzone poprawnie - utworzenie obiektu klasy LordSith, dodanie obiektu do listy.
        /// </summary>
        public void CheckingDataSith()
        {
            Regex correctFormOfName = new Regex("^[A-Z]{1}[a-z]+$");
            Regex correctFormOfYearOfBirth = new Regex("^[1-9]{1}[0-9]{0,3}$");
            Regex correctFormOfYearOfDeath = new Regex("(^[1-9]{1}[0-9]{0,3}$)|(^$)");
            Regex correctFormOfAmountKilledOfJedi = new Regex("(^[1-9]{1}[0-9]*$)|(^[0]{1}$)|(^$)");
            Regex correctFormOfNumberOfHolocrones = new Regex("(^[1-9]{1}[0-9]*$)|(^[0]{1}$)");
            DateTime current = DateTime.Now;
            int currentYear = current.Year;

            if ((textBoxName.Text == "") || (comboBoxPlanet.Text == "") || (textBoxYearOfBirth.Text == "") || (comboBoxColourOfLightsaber.Text == "") ||
                (comboBoxLightSaberCombat.Text == "") || (textBoxPath.Text == "")||(comboBoxSpecialPower.Text=="")||(textBoxNumberOfHolocrones.Text=="")||(comboBoxKindOfPossesedArmy.Text==""))
            {
                MessageBox.Show("Nie podano wystarczających danych!");

            }
            else
            {
                if (correctFormOfName.IsMatch(textBoxName.Text) == false)
                {
                    MessageBox.Show("Niepoprawna forma imienia!");
                }
                else if (correctFormOfYearOfBirth.IsMatch(textBoxYearOfBirth.Text) == false)
                {
                    MessageBox.Show("Niepoprawna forma roku urodzenia!");
                }
                else if (int.Parse(textBoxYearOfBirth.Text) > 2000)
                {
                    MessageBox.Show("Kronika nie przyjmuje raczkujących Sithów!");
                }
                else if (correctFormOfYearOfDeath.IsMatch(textBoxYearOfDeath.Text) == false)
                {
                    MessageBox.Show("Niepoprawna forma roku śmierci!");
                }
                else if (correctFormOfAmountKilledOfJedi.IsMatch(textBoxAmountOfKilledJedi.Text) == false)
                {
                    MessageBox.Show("Niepoprawna forma ilości zabitych Jedi!");
                }
                else if (correctFormOfNumberOfHolocrones.IsMatch(textBoxNumberOfHolocrones.Text) == false)
                {
                    MessageBox.Show("Niepoprawna forma liczby HOLOKRONÓW!");
                }
                else
                {

                    if (textBoxYearOfDeath.Text != "")
                    {
                        if ((int.Parse(textBoxYearOfDeath.Text) < int.Parse(textBoxYearOfBirth.Text)) || (int.Parse(textBoxYearOfDeath.Text) > currentYear))
                        {
                            MessageBox.Show("Jesteś pewny/a, że wpisałeś poprawny rok śmierci Sitha?!\nPamiętaj, że rok śmierci nie może być większy niż aktualny, ani mniejszy od roku urodzenia!");
                        }
                        else
                        {

                            if ((textBoxAmountOfKilledJedi.Text == "") || ((textBoxAmountOfKilledJedi.Text != "") && (int.Parse(textBoxAmountOfKilledJedi.Text) == 0)))
                            {
                                if (MessageBox.Show("Jesteś pewny/a, że ten Sith nie ma żadnego zabójstwa Jedi na koncie?", "Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    LordSith lordSith = new LordSith(textBoxName.Text, comboBoxPlanet.Text, textBoxPath.Text, int.Parse(textBoxYearOfBirth.Text), checkBoxWasJedi.Checked, comboBoxColourOfLightsaber.Text, comboBoxLightSaberCombat.Text, 0, int.Parse(textBoxYearOfDeath.Text), comboBoxSpecialPower.Text, int.Parse(textBoxNumberOfHolocrones.Text), comboBoxKindOfPossesedArmy.Text);
                                    listOfLordSith.Add(lordSith);
                                    Close();
                                }
                            }
                            else
                            {
                                LordSith lordSith = new LordSith(textBoxName.Text, comboBoxPlanet.Text, textBoxPath.Text, int.Parse(textBoxYearOfBirth.Text), checkBoxWasJedi.Checked, comboBoxColourOfLightsaber.Text, comboBoxLightSaberCombat.Text, int.Parse(textBoxAmountOfKilledJedi.Text), int.Parse(textBoxYearOfDeath.Text), comboBoxSpecialPower.Text, int.Parse(textBoxNumberOfHolocrones.Text), comboBoxKindOfPossesedArmy.Text);
                                listOfLordSith.Add(lordSith);
                                Close();
                            }
                        }
                    }
                    else
                    {
                        if ((textBoxAmountOfKilledJedi.Text == "") || ((textBoxAmountOfKilledJedi.Text != "") && (int.Parse(textBoxAmountOfKilledJedi.Text) == 0)))
                        {
                            if (MessageBox.Show("Jesteś pewny/a, że ten Sith nie ma żadnego zabójstwa Jedi na koncie?", "Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                LordSith lordSith = new LordSith(textBoxName.Text, comboBoxPlanet.Text, textBoxPath.Text, int.Parse(textBoxYearOfBirth.Text), checkBoxWasJedi.Checked, comboBoxColourOfLightsaber.Text, comboBoxLightSaberCombat.Text, 0, comboBoxSpecialPower.Text, int.Parse(textBoxNumberOfHolocrones.Text), comboBoxKindOfPossesedArmy.Text);
                                listOfLordSith.Add(lordSith);
                                Close();
                            }
                        }
                        else
                        {
                            LordSith lordSith = new LordSith(textBoxName.Text, comboBoxPlanet.Text, textBoxPath.Text, int.Parse(textBoxYearOfBirth.Text), checkBoxWasJedi.Checked, comboBoxColourOfLightsaber.Text, comboBoxLightSaberCombat.Text, int.Parse(textBoxAmountOfKilledJedi.Text), comboBoxSpecialPower.Text, int.Parse(textBoxNumberOfHolocrones.Text), comboBoxKindOfPossesedArmy.Text);
                            listOfLordSith.Add(lordSith);
                            Close();
                        }
                    }
                }
            }
        }




        private void buttonAddSith_Click(object sender, EventArgs e)
        {
            CheckingDataSith();
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = openFileDialogImage.FileName;
                pictureBoxSithImage.Load(textBoxPath.Text);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
