using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KamilCieślikLab2PD
{
    public partial class EditSith : Form
    {
        public EditSith(Sith sith)
        {
            Sith = sith;
            InitializeComponent();
            pictureBoxSithImage.Load(sith.ImagePath);
            textBoxDetails.TextAlign = HorizontalAlignment.Center;
            textBoxDetails.AppendText(sith.View());
        }

        public Sith Sith { get; set; }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - zmiana Name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            Regex correctFormOfName = new Regex("^[A-Z]{1}[a-z]+$");
            if (textBoxName.Text == "")
            {
                MessageBox.Show(@"Pole z imieniem jest puste!");
            }
            else if (correctFormOfName.IsMatch(textBoxName.Text) == false)
            {
                MessageBox.Show(@"Niepoprawna forma imienia!");
            }
            else
            {
                if (MessageBox.Show(@"Wprowadzono poprawną formę imienia.
 Na pewno chcesz je zmienić?", @"Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Sith.Name = "Darth " + textBoxName.Text;
                    textBoxDetails.Clear();
                    textBoxDetails.TextAlign = HorizontalAlignment.Center;
                    textBoxDetails.AppendText(Sith.View());
                }
            }
        }
        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - Planet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangePlanet_Click(object sender, EventArgs e)
        {
            if (comboBoxPlanet.Text == "")
            {
                MessageBox.Show(@"Pole z planetą pochodzenia jest puste!");
            }
            else
            {
                if (MessageBox.Show(@"Na pewno chcesz zmienić planetę pochodzenia Sitha?", @"Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Sith.Planet = comboBoxPlanet.Text;
                    textBoxDetails.Clear();
                    textBoxDetails.TextAlign = HorizontalAlignment.Center;
                    textBoxDetails.AppendText(Sith.View());
                }
            }
        }

        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - zmiana yearOfBirth.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeYearOfBirth_Click(object sender, EventArgs e)
        {
            var correctFormOfYear = new Regex("^[1-9]{1}[0-9]{0,3}$");
            if (textBoxYearOfBirth.Text == "")
            {
                MessageBox.Show(@"Pole z rokiem urodzenia jest puste!");
            }
            else if (correctFormOfYear.IsMatch(textBoxYearOfBirth.Text) == false)
            {
                MessageBox.Show(@"Niepoprawna forma roku urodzenia!");
            }
            else if (int.Parse(textBoxYearOfBirth.Text) >= Sith.YearOfDeath)
            {
                MessageBox.Show(@"Rok urodzenia nie może być większy bądź równy dacie śmierci!
Jeżeli chcesz zapisać podaną formę, w pierwszej kolejności odpowiednio przesuń datę śmierci!");
            }
            else
            {
                if (MessageBox.Show(@"Wprowadzono poprawną formę roku urodzenia.
 Na pewno chcesz go zmienić?", @"Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                    DialogResult.Yes) return;
                Sith.YearOfBirth = int.Parse(textBoxYearOfBirth.Text);
                textBoxDetails.Clear();
                textBoxDetails.TextAlign = HorizontalAlignment.Center;
                textBoxDetails.AppendText(Sith.View());
            }
        }
        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - zmiana yearOfDeath.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeYearOfDeath_Click(object sender, EventArgs e)
        {
            var correctFormOfYear = new Regex("^[1-9]{1}[0-9]{0,3}$");
            if (textBoxYearOfDeath.Text == "")
            {
                MessageBox.Show(@"Pole z rokiem śmierci jest puste!");
            }
            else if (correctFormOfYear.IsMatch(textBoxYearOfDeath.Text) == false)
            {
                MessageBox.Show(@"Niepoprawna forma roku śmierci!");
            }
            else if (int.Parse(textBoxYearOfDeath.Text) <= Sith.YearOfBirth)
            {
                MessageBox.Show(@"Rok śmierci nie może być mniejszy bądź równy urodzenia!
Jeżeli chcesz zapisać podaną formę, w pierwszej kolejności odpowiednio przesuń datę urodzenia!");
            }
            else
            {
                if (
                    MessageBox.Show(@"Wprowadzono poprawną formę roku śmierci.
 Na pewno chcesz go zmienić?",
                        @"Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                Sith.YearOfDeath = int.Parse(textBoxYearOfDeath.Text);
                textBoxDetails.Clear();
                textBoxDetails.TextAlign = HorizontalAlignment.Center;
                textBoxDetails.AppendText(Sith.View());
            }
        }

        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - zmiana WasJedi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeWasJedi_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(@"Jesteś pewny wprowadzanej zmiany?", @"Pytanie kontrolne!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;
            Sith.WasJedi = checkBoxWasJedi.Checked;
            textBoxDetails.Clear();
            textBoxDetails.TextAlign = HorizontalAlignment.Center;
            textBoxDetails.AppendText(Sith.View());
        }
        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - zmiana ColourOfLishtSaber.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeColourOfLightSaber_Click(object sender, EventArgs e)
        {
            if (comboBoxColourOfLightsaber.Text == "")
            {
                MessageBox.Show(@"Pole z kolorem miecza świetlnego jest puste!");
            }
            else
            {
                if (
                    MessageBox.Show(@"Na pewno chcesz zmienić kolor miecza świetlnego Sitha?", @"Pytanie kontrolne!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                Sith.ColourOfLightsaber = comboBoxColourOfLightsaber.Text;
                textBoxDetails.Clear();
                textBoxDetails.TextAlign = HorizontalAlignment.Center;
                textBoxDetails.AppendText(Sith.View());
            }
        }
        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - zmiana LightSaberCombat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeLightSaberCombat_Click(object sender, EventArgs e)
        {
            if (comboBoxLightSaberCombat.Text == "")
            {
                MessageBox.Show(@"Pole ze stylem walki mieczem świetlnym jest puste!");
            }
            else
            {
                if (
                    MessageBox.Show(@"Na pewno chcesz zmienić styl walki mieczem świetlnym?", @"Pytanie kontrolne!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                Sith.LightsaberCombat = comboBoxLightSaberCombat.Text;
                textBoxDetails.Clear();
                textBoxDetails.TextAlign = HorizontalAlignment.Center;
                textBoxDetails.AppendText(Sith.View());
            }
        }
        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - zmiana AmountKilledOfJedi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeAmountOfKilledJedi_Click(object sender, EventArgs e)
        {
            var correctFormOfAmountKilledOfJedi = new Regex("(^[1-9]{1}[0-9]*$)|(^[0]{1}$)");
            if (textBoxAmountOfKilledJedi.Text == "")
            {
                MessageBox.Show(@"Pole z ilością zabitych Jedi jest puste!");
            }
            else if (correctFormOfAmountKilledOfJedi.IsMatch(textBoxAmountOfKilledJedi.Text) == false)
            {
                MessageBox.Show(@"Niepoprawna forma ilości zabitych Jedi!");
            }
            else
            {
                if (MessageBox.Show(@"Wprowadzono poprawną liczbę.
 Na pewno chcesz ją zmienić?", @"Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                    DialogResult.Yes) return;
                Sith.AmountOfKilledJedi = int.Parse(textBoxAmountOfKilledJedi.Text);
                textBoxDetails.Clear();
                textBoxDetails.TextAlign = HorizontalAlignment.Center;
                textBoxDetails.AppendText(Sith.View());
            }
        }
        /// <summary>
        /// Sprawdzanie poprawności wpisywanych danych. Jeśli poprawne - zmiana ImagePath.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = openFileDialogImage.FileName;
                pictureBoxSithImage.Load(textBoxPath.Text);
            }
            if (MessageBox.Show(@"Zapisać wybrany wizerunek?", @"Pytanie kontrolne!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sith.ImagePath = textBoxPath.Text;
            }
            else
            {
                pictureBoxSithImage.Load(Sith.ImagePath);
            }
        }
    }
}
