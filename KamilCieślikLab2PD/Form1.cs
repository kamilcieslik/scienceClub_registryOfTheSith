using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamilCieślikLab2PD
{
    public partial class Form1 : Form
    {
        private List<Sith> listOfSith;
        private List<LordSith> listOfLordSith;
        private CreateSith formCreateSith;
        private CreateLordSith formCreateLordSith;
        private EditSith formEditSith;
        private EditLordSith formEditLordSith;
        int index;

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
        public Form1()
        {
            listOfSith = new List<Sith>();
            listOfLordSith = new List<LordSith>();
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
            formCreateSith = new CreateSith(listOfSith);
            this.Visible = false;
            formCreateSith.ShowDialog();
            if (formCreateSith.IsAccessible == false) Visible = true;
            listOfSith = formCreateSith.ListOfSith;
            RefreshDataGridViewSith();
        }

        private void buttonAddLordSith_Click(object sender, EventArgs e)
        {
            formCreateLordSith = new CreateLordSith(listOfLordSith);
            this.Visible = false;
            formCreateLordSith.ShowDialog();
            if (formCreateLordSith.IsAccessible == false) Visible = true;
            listOfLordSith = formCreateLordSith.ListOfLordSith;
            RefreshDataGridViewLordSith();
        }

        public void RefreshDataGridViewSith()
        {
            dataGridViewSith.DataSource = null;
            dataGridViewSith.DataSource = listOfSith;
            dataGridViewSith.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewSith.Columns[2].Visible = false;
        }

        public void RefreshDataGridViewLordSith()
        {
            dataGridViewLordSith.DataSource = null;
            dataGridViewLordSith.DataSource = listOfLordSith;
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

                        foreach (DataGridViewRow a in dataGridViewSith.SelectedRows)
                        {
                            int temporaryIndex = a.Index;
                            if (index == temporaryIndex)
                            {
                                RefreshDetails();
                            }
                            listOfSith.RemoveAt(temporaryIndex);
                        }

                        RefreshDataGridViewSith();
                    }
                    else if ((dataGridViewSith.Visible == false) && (dataGridViewLordSith.Visible == true))
                    {

                        foreach (DataGridViewRow a in dataGridViewLordSith.SelectedRows)
                        {
                            int temporaryIndex = a.Index;
                            if (index == temporaryIndex)
                            {
                                RefreshDetails();
                            }
                            listOfLordSith.RemoveAt(temporaryIndex);
                        }

                        RefreshDataGridViewLordSith();
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wykryto zaznaczych pozycji!");
            }
        }

        /// <summary>
        /// Metoda odpowiadająca za wyświetlenie szczegółowych informacji o zaznaczonym obiekcie w odpowiedni sposób, z aktualnie wybranej listy.
        /// </summary>
        public void ShowList()
        {
            try
            {
                if ((dataGridViewSith.Visible == true)&& (dataGridViewLordSith.Visible == false))
                {
                    textBoxDetails.Clear();
                    textBoxDetails.TextAlign = HorizontalAlignment.Center;
                    index = dataGridViewSith.SelectedRows[0].Index;
                    pictureBoxSithImage.Load(listOfSith[index].ImagePath);
                    textBoxDetails.AcceptsReturn = true;
                    textBoxDetails.AppendText(listOfSith[index].View());
                    textBoxName.TextAlign = HorizontalAlignment.Center;
                    textBoxName.Clear();
                    textBoxName.AppendText(listOfSith[index].Name);
                }
                else if ((dataGridViewSith.Visible == false) && (dataGridViewLordSith.Visible == true))
                {
                    textBoxDetails.Clear();
                    textBoxDetails.TextAlign = HorizontalAlignment.Center;
                    index = dataGridViewLordSith.SelectedRows[0].Index;
                    pictureBoxSithImage.Load(listOfLordSith[index].ImagePath);
                    textBoxDetails.AcceptsReturn = true;
                    textBoxDetails.AppendText(listOfLordSith[index].View());
                    textBoxName.TextAlign = HorizontalAlignment.Center;
                    textBoxName.Clear();
                    textBoxName.AppendText(listOfLordSith[index].Name);
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Nie wykryto zaznaczenia!");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Czy na pewno chcesz wyjść z aplikacji?",
                "Zamknij", MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            ShowList();
        }
        
        /// <summary>
        /// Zapisywanie wyserializowanych obiektów list Sith oraz LordSith do plików.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Czy na pewno chcesz zapisać/nadpisać obecne kroniki do plików?",
               "Zapis do pliku", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                IFormatter binary = new BinaryFormatter();
                FileStream fileSith = new FileStream("filewithsith.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                binary.Serialize(fileSith, listOfSith);
                fileSith.Close();

                FileStream fileLordSith = new FileStream("filewithlordsith.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                binary.Serialize(fileLordSith, listOfLordSith);
                fileLordSith.Close();
            }   
        }

        /// <summary>
        /// Deserializacja i odczyt z plików.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try {
                IFormatter binary = new BinaryFormatter();
                FileStream fileSith = new FileStream("filewithsith.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                listOfSith = (List<Sith>)binary.Deserialize(fileSith);
                fileSith.Close();
                RefreshDataGridViewSith();

                FileStream fileLordSith = new FileStream("filewithlordsith.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                listOfLordSith = (List<LordSith>)binary.Deserialize(fileLordSith);
                fileLordSith.Close();
                RefreshDataGridViewLordSith();
                RefreshDetails();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Plik z którego próbujesz odczytać dane nie istnieje!");
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
                if ((dataGridViewSith.Visible == true) && (dataGridViewLordSith.Visible == false))
                {
                    index = dataGridViewSith.SelectedRows[0].Index;
                    formEditSith = new EditSith(listOfSith[index]);
                    this.Visible = false;
                    formEditSith.ShowDialog();
                    if (formEditSith.IsAccessible == false) Visible = true;
                    listOfSith[index] = formEditSith.Sith;
                    RefreshDataGridViewSith();
                    ShowList();
                }
                else if ((dataGridViewSith.Visible == false) && (dataGridViewLordSith.Visible == true))
                {
                    index = dataGridViewLordSith.SelectedRows[0].Index;
                    formEditLordSith = new EditLordSith(listOfLordSith[index]);
                    this.Visible = false;
                    formEditLordSith.ShowDialog();
                    if (formEditLordSith.IsAccessible == false) Visible = true;
                    listOfLordSith[index] = formEditLordSith.LordSith;
                    RefreshDataGridViewLordSith();
                    ShowList();
                }


            
            }
            catch (Exception)
            {
                MessageBox.Show("Wybierz element, którego dane chcesz edytować!");
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
