using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KamilCieślikLab2PD
{
    public partial class CreateSith : Form
    {
        public CreateSith(List<Sith> listOfSith)
        {
            InitializeComponent();
            ListOfSith = listOfSith;
            pictureBoxSithImage.Image = Properties.Resources.defaultImage;
        }

        public List<Sith> ListOfSith { get; set; }

        /// <summary>
        /// Metoda odpowiedzialna za sprawdzanie poprawności danych wpisywanych do textBox'ów. 
        /// W sytuacji gdy dane zostały wprowadzone poprawnie - utworzenie obiektu klasy Sith, dodanie obiektu do listy.
        /// </summary>
        public void CheckingDataSith()
        {
            var correctFormOfName = new Regex("^[A-Z]{1}[a-z]+$");
            var correctFormOfYearOfBirth = new Regex("^[1-9]{1}[0-9]{0,3}$");
            var correctFormOfYearOfDeath = new Regex("(^[1-9]{1}[0-9]{0,3}$)|(^$)");
            var correctFormOfAmountKilledOfJedi = new Regex("(^[1-9]{1}[0-9]*$)|(^[0]{1}$)|(^$)");
            var current = DateTime.Now;
            var currentYear = current.Year;

            if ((textBoxName.Text == "") || (comboBoxPlanet.Text == "") || (textBoxYearOfBirth.Text == "") || (comboBoxColourOfLightsaber.Text == "") || (comboBoxLightSaberCombat.Text == "") || (textBoxPath.Text == ""))
            {
                MessageBox.Show(@"Nie podano wystarczających danych!");
            }
            else
            {
                if (correctFormOfName.IsMatch(textBoxName.Text) == false)
                {
                    MessageBox.Show(@"Niepoprawna forma imienia!");
                }
                else if (correctFormOfYearOfBirth.IsMatch(textBoxYearOfBirth.Text) == false)
                {
                    MessageBox.Show(@"Niepoprawna forma roku urodzenia!");
                }
                else if (int.Parse(textBoxYearOfBirth.Text) > 2000)
                {
                    MessageBox.Show(@"Kronika nie przyjmuje raczkujących Sithów!");
                }
                else if (correctFormOfYearOfDeath.IsMatch(textBoxYearOfDeath.Text) == false)
                {
                    MessageBox.Show(@"Niepoprawna forma roku śmierci!");
                }
                else if (correctFormOfAmountKilledOfJedi.IsMatch(textBoxAmountOfKilledJedi.Text) == false)
                {
                    MessageBox.Show(@"Niepoprawna forma ilości zabitych Jedi!");
                }
                else
                {

                    if (textBoxYearOfDeath.Text != "")
                    {
                        if ((int.Parse(textBoxYearOfDeath.Text) < int.Parse(textBoxYearOfBirth.Text)) || (int.Parse(textBoxYearOfDeath.Text) > currentYear))
                        {
                            MessageBox.Show(@"Jesteś pewny/a, że wpisałeś poprawny rok śmierci Sitha?!
Pamiętaj, że rok śmierci nie może być większy niż aktualny, ani mniejszy od roku urodzenia!");
                        }
                        else
                        {

                            if ((textBoxAmountOfKilledJedi.Text == "") || ((textBoxAmountOfKilledJedi.Text != "") && (int.Parse(textBoxAmountOfKilledJedi.Text) == 0)))
                            {
                                if (
                                    MessageBox.Show(
                                        @"Jesteś pewny/a, że ten Sith nie ma żadnego zabójstwa Jedi na koncie?",
                                        @"Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                                    DialogResult.Yes) return;
                                var sith = new Sith(textBoxName.Text, comboBoxPlanet.Text, int.Parse(textBoxYearOfBirth.Text), checkBoxWasJedi.Checked, comboBoxColourOfLightsaber.Text, comboBoxLightSaberCombat.Text, 0, int.Parse(textBoxYearOfDeath.Text), textBoxPath.Text);
                                ListOfSith.Add(sith);
                                Close();
                            }
                            else
                            {
                                var sith = new Sith(textBoxName.Text, comboBoxPlanet.Text, int.Parse(textBoxYearOfBirth.Text), checkBoxWasJedi.Checked, comboBoxColourOfLightsaber.Text, comboBoxLightSaberCombat.Text, int.Parse(textBoxAmountOfKilledJedi.Text), int.Parse(textBoxYearOfDeath.Text), textBoxPath.Text);
                                ListOfSith.Add(sith);
                                Close();
                            }
                        }
                    }
                    else
                    {
                        if ((textBoxAmountOfKilledJedi.Text == "") || ((textBoxAmountOfKilledJedi.Text != "") && (int.Parse(textBoxAmountOfKilledJedi.Text) == 0)))
                        {
                            if (
                                MessageBox.Show(@"Jesteś pewny/a, że ten Sith nie ma żadnego zabójstwa Jedi na koncie?",
                                    @"Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                                DialogResult.Yes) return;
                            var sith = new Sith(textBoxName.Text, comboBoxPlanet.Text, int.Parse(textBoxYearOfBirth.Text), checkBoxWasJedi.Checked, comboBoxColourOfLightsaber.Text, comboBoxLightSaberCombat.Text, 0, textBoxPath.Text);
                            ListOfSith.Add(sith);
                            Close();
                        }
                        else
                        {
                            var sith = new Sith(textBoxName.Text, comboBoxPlanet.Text, int.Parse(textBoxYearOfBirth.Text), checkBoxWasJedi.Checked, comboBoxColourOfLightsaber.Text, comboBoxLightSaberCombat.Text, int.Parse(textBoxAmountOfKilledJedi.Text), textBoxPath.Text);
                            ListOfSith.Add(sith);
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() != DialogResult.OK) return;
            textBoxPath.Text = openFileDialogImage.FileName;
            pictureBoxSithImage.Load(textBoxPath.Text);
        }
    }
}
