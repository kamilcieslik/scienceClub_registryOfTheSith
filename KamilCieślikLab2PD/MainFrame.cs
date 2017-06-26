using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace KamilCieślikLab2PD
{
    public partial class MainFrame : Form
    {
        private List<Sith> _listOfSith;
        private List<LordSith> _listOfLordSith;
        private CreateSith _formCreateSith;
        private CreateLordSith _formCreateLordSith;
        private EditSith _formEditSith;
        private EditLordSith _formEditLordSith;
        private int _index;

        /// <summary>
        /// Odświeżenie textBox'a i pictureBox'a odpowiedzialnych za wyświetlanie szczegółowych informacji o aktualnie zaznaczonym obiekcie.
        /// </summary>
        public void RefreshDetails()
        {
            textBoxDetails.Clear();
            textBoxDetails.TextAlign = HorizontalAlignment.Center;
            textBoxDetails.AppendText("Aby wyświetlić szczegóły obiektu" + Environment.NewLine + "w pierwszej kolejności zaznacz go na liście!");
            textBoxName.Clear();
            pictureBoxSithImage.Image = Properties.Resources.defaultImage;
        }
        public MainFrame()
        {
            _listOfSith = new List<Sith>();
            _listOfLordSith = new List<LordSith>();
            InitializeComponent();
            dataGridViewSith.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSith.MultiSelect = true;
            dataGridViewLordSith.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLordSith.MultiSelect = true;
            RefreshDetails();
            radioButtonShowGridOfSith.Checked = true;
        }


        private void buttonAddSith_Click(object sender, EventArgs e)
        {
            _formCreateSith = new CreateSith(_listOfSith);
            Visible = false;
            _formCreateSith.ShowDialog();
            if (_formCreateSith.IsAccessible == false) Visible = true;
            _listOfSith = _formCreateSith.ListOfSith;
            RefreshDataGridViewSith();
        }

        private void buttonAddLordSith_Click(object sender, EventArgs e)
        {
            _formCreateLordSith = new CreateLordSith(_listOfLordSith);
            Visible = false;
            _formCreateLordSith.ShowDialog();
            if (_formCreateLordSith.IsAccessible == false) Visible = true;
            _listOfLordSith = _formCreateLordSith.ListOfLordSith;
            RefreshDataGridViewLordSith();
        }

        public void RefreshDataGridViewSith()
        {
            dataGridViewSith.DataSource = null;
            dataGridViewSith.DataSource = _listOfSith;
            dataGridViewSith.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewSith.Columns[2].Visible = false;
        }

        public void RefreshDataGridViewLordSith()
        {
            dataGridViewLordSith.DataSource = null;
            dataGridViewLordSith.DataSource = _listOfLordSith;
            dataGridViewLordSith.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewLordSith.Columns["ImagePath"].Visible = false;
            dataGridViewLordSith.Columns["Name"].DisplayIndex = 0;
            dataGridViewLordSith.Columns["Planet"].DisplayIndex = 1;
            dataGridViewLordSith.Columns["YearOfBirth"].DisplayIndex = 2;
            dataGridViewLordSith.Columns["WasJedi"].DisplayIndex = 3;
            dataGridViewLordSith.Columns["ColourOfLightSaber"].DisplayIndex = 4;
            dataGridViewLordSith.Columns["LightSaberCombat"].DisplayIndex = 5;
            dataGridViewLordSith.Columns["AmountOfKilledJedi"].DisplayIndex = 6;
            dataGridViewLordSith.Columns["SpecialPower"].DisplayIndex = 7;
            dataGridViewLordSith.Columns["KindOfPossesedArmy"].DisplayIndex = 8;
            dataGridViewLordSith.Columns["NumberOfHolocrones"].DisplayIndex = 9;
            dataGridViewLordSith.Columns["YearOfDeath"].DisplayIndex = 10;
        }

        private void buttonDeleteSith_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dataGridViewSith.Visible == true) && (dataGridViewLordSith.Visible == false))
                {
                    foreach (var temporaryIndex in from DataGridViewRow a in dataGridViewSith.SelectedRows select a.Index)
                    {
                        if (_index == temporaryIndex)
                        {
                            RefreshDetails();
                        }
                        _listOfSith.RemoveAt(temporaryIndex);
                    }

                    RefreshDataGridViewSith();
                }
                else if ((dataGridViewSith.Visible == false) && (dataGridViewLordSith.Visible == true))
                {
                    foreach (var temporaryIndex in from DataGridViewRow a in dataGridViewLordSith.SelectedRows select a.Index)
                    {
                        if (_index == temporaryIndex)
                        {
                            RefreshDetails();
                        }
                        _listOfLordSith.RemoveAt(temporaryIndex);
                    }

                    RefreshDataGridViewLordSith();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Nie wykryto zaznaczych pozycji!");
            }
        }

        /// <summary>
        /// Metoda odpowiadająca za wyświetlenie szczegółowych informacji o zaznaczonym obiekcie w odpowiedni sposób, z aktualnie wybranej listy.
        /// </summary>
        public void ShowList()
        {
            try
            {
                if (dataGridViewSith.Visible && (dataGridViewLordSith.Visible == false))
                {
                    textBoxDetails.Clear();
                    textBoxDetails.TextAlign = HorizontalAlignment.Center;
                    _index = dataGridViewSith.SelectedRows[0].Index;
                    pictureBoxSithImage.Load(_listOfSith[_index].ImagePath);
                    textBoxDetails.AcceptsReturn = true;
                    textBoxDetails.AppendText(_listOfSith[_index].View());
                    textBoxName.TextAlign = HorizontalAlignment.Center;
                    textBoxName.Clear();
                    textBoxName.AppendText(_listOfSith[_index].Name);
                }
                else if ((dataGridViewSith.Visible == false) && dataGridViewLordSith.Visible)
                {
                    textBoxDetails.Clear();
                    textBoxDetails.TextAlign = HorizontalAlignment.Center;
                    _index = dataGridViewLordSith.SelectedRows[0].Index;
                    pictureBoxSithImage.Load(_listOfLordSith[_index].ImagePath);
                    textBoxDetails.AcceptsReturn = true;
                    textBoxDetails.AppendText(_listOfLordSith[_index].View());
                    textBoxName.TextAlign = HorizontalAlignment.Center;
                    textBoxName.Clear();
                    textBoxName.AppendText(_listOfLordSith[_index].Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Nie wykryto zaznaczenia!");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(@"Czy na pewno chcesz wyjść z aplikacji?",
                @"Zamknij", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Zapisywanie wyserializowanych obiektów list Sith oraz LordSith do plików.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show(@"Czy na pewno chcesz zapisać/nadpisać obecne kroniki do plików?",
               @"Zapis do pliku", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;
            IFormatter binary = new BinaryFormatter();
            var fileSith = new FileStream("filewithsith.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            binary.Serialize(fileSith, _listOfSith);
            fileSith.Close();

            var fileLordSith = new FileStream("filewithlordsith.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            binary.Serialize(fileLordSith, _listOfLordSith);
            fileLordSith.Close();
        }

        /// <summary>
        /// Deserializacja i odczyt z plików.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatter binary = new BinaryFormatter();
                var fileSith = new FileStream("filewithsith.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                _listOfSith = (List<Sith>)binary.Deserialize(fileSith);
                fileSith.Close();
                RefreshDataGridViewSith();

                var fileLordSith = new FileStream("filewithlordsith.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                _listOfLordSith = (List<LordSith>)binary.Deserialize(fileLordSith);
                fileLordSith.Close();
                RefreshDataGridViewLordSith();
                RefreshDetails();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(@"Plik z którego próbujesz odczytać dane nie istnieje!");
            }
        }

        private void dataGridViewSith_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowList();
        }

        private void dataGridViewLordSith_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowList();
        }

        /// <summary>
        /// Wywołanie edycji aktualnie zaznaczonego obiektu na liście i wywołanie formularza edycji odpowiedniego dla obecnej listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSith.Visible && (dataGridViewLordSith.Visible == false))
                {
                    _index = dataGridViewSith.SelectedRows[0].Index;
                    _formEditSith = new EditSith(_listOfSith[_index]);
                    Visible = false;
                    _formEditSith.ShowDialog();
                    if (_formEditSith.IsAccessible == false) Visible = true;
                    _listOfSith[_index] = _formEditSith.Sith;
                    RefreshDataGridViewSith();
                    ShowList();
                }
                else if ((dataGridViewSith.Visible == false) && dataGridViewLordSith.Visible)
                {
                    _index = dataGridViewLordSith.SelectedRows[0].Index;
                    _formEditLordSith = new EditLordSith(_listOfLordSith[_index]);
                    Visible = false;
                    _formEditLordSith.ShowDialog();
                    if (_formEditLordSith.IsAccessible == false) Visible = true;
                    _listOfLordSith[_index] = _formEditLordSith.LordSith;
                    RefreshDataGridViewLordSith();
                    ShowList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Wybierz element, którego dane chcesz edytować!");
            }
        }

        /// <summary>
        /// Przełączenie dataGridView w zależności od aktualnie wciśniętego radioButtona.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonShowGridOfSith_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSith.Visible = true;
            dataGridViewLordSith.Visible = false;
            RefreshDetails();
        }
        /// <summary>
        /// Przełączenie dataGridView w zależności od aktualnie wciśniętego radioButtona.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonShowGridOfLordSith_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSith.Visible = false;
            dataGridViewLordSith.Visible = true;
            RefreshDetails();
        }
    }
}
