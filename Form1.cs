using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Sheltered_2_SE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProcessFile processFile = new ProcessFile();
        ProcessData processData = new ProcessData();
        OpenFileDialog openSaveFile = new OpenFileDialog();
        //SaveFileDialog saveFileDialog = new SaveFileDialog();

        public string decodedData = string.Empty;
        public string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))+"\\AppData\\LocalLow\\Unicube\\Sheltered2\\";

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbxCharacterSelect.Items.Clear();
            cbxCharacterSelect.Text = "Select Character";
            Utilities.ResetAllControls(tabPage1);

            openSaveFile.Filter = "Sheltered 2 Savegame|*.dat";
            openSaveFile.InitialDirectory = savePath;
            openSaveFile.RestoreDirectory = false;

            String Filename = "";

            if (openSaveFile.ShowDialog() == DialogResult.OK)
            {
                decodedData = processFile.LoadFile(openSaveFile.FileName);
                if (decodedData != string.Empty)
                {
                    // Open Save and output to Textbox
                    //Output.Text = File.ReadAllText(ProcessFile.tempFilePath);
                    
                }
                else
                {   // Retry
                    MessageBox.Show("This file is not a valid Sheltered 2 save file.", "Error");
                }
                Filename = openSaveFile.FileName;

                //Initialize Data
                //Characters

                //string selectableCharacters = "";

                //XElement xElement = XElement.Load(ProcessFile.tempFilePath);

                //foreach (XElement member in xElement.Elements("FamilyMembers"))
                //{
                //    //Console.WriteLine(member);
                //    Output.AppendText(Convert.ToString(member));
                //}
                ProcessData.familyMemberCount = 0;
                XElement members = XElement.Load(ProcessFile.tempFilePath);
                IEnumerable<XElement> fN =
                    from el in members.Descendants("FamilyMembers").Descendants("firstName")
                    select el;
                foreach (XElement member in fN) {
                    cbxCharacterSelect.Items.Add(member.Value);
                    ProcessData.familyMemberCount++;
                }

            }
        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = ProcessFile.fileName;
            String Filename = "";
            DialogResult saveResult = saveFileDialog.ShowDialog();
            if (saveResult == DialogResult.OK)
            {

                Filename = saveFileDialog.FileName;

                try
                {
                    processFile.SaveFile(saveFileDialog.FileName);
                    MessageBox.Show("File saved succesfully!", "File Saved");
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error saving File: " + ioe.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeFogOfWarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Output.Text = File.ReadAllText(ProcessFile.tempFilePath);
            //Output.Text = "";

            List<FamilyMembers> familyMembers = ProcessData.FamilyMembersList();

            //foreach (FamilyMembers member in familyMembers)
            //{
            //    Output.AppendText(member.ToString() + "\n");

            //}

            List<BaseStats> baseStats = ProcessData.BaseStatsList();
            
            //foreach (BaseStats stat in baseStats)
            //{
            //    Output.AppendText(stat.ToString()+"\n");
            //}

           
            var firstItem = baseStats.ElementAt(0);
            Output.AppendText(firstItem.ToString() + "\n");


        }




        public void cbxCharacterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cbxCharacterSelect.Items[cbxCharacterSelect.SelectedIndex];
            ProcessData.memberNr = cbxCharacterSelect.SelectedIndex;

            txbFirstname.Text = selectedItem.ToString();
            List<FamilyMembers> familyMembers = ProcessData.FamilyMembersList();
            List<BaseStats> baseStats = ProcessData.BaseStatsList();


            foreach (FamilyMembers member in familyMembers)
            {
                if (member.FirstName == txbFirstname.Text)
                {
                    txbLastname.Text = member.LastName;
                    txbHealth.Text = Convert.ToString(member.Health);
                    txbMaxHealth.Text = Convert.ToString(member.MaxHealth);
                    cBInteracting.Checked = member.Interacting;
                    cBInteractingWithObj.Checked = member.InteractingWithObj;
                    cBHasBeenDefibbed.Checked = member.HasBeenDefibbed;
                    lblAnimHashValue.Text = Convert.ToString(member.AnimHash);
                    lblAnimTimeValue.Text = member.AnimTime.ToString();

                }
            }

            txbCapStrenght.Text = baseStats.ElementAt(ProcessData.memberNr).StrengthCap.ToString();
            txbLevelStrenght.Text = baseStats.ElementAt(ProcessData.memberNr).StrengthLevel.ToString();

            txbCapDexterity.Text = baseStats.ElementAt(ProcessData.memberNr).DexterityCap.ToString();
            txbLevelDexterity.Text = baseStats.ElementAt(ProcessData.memberNr).DexterityLevel.ToString();

            txbCapIntelligence.Text = baseStats.ElementAt(ProcessData.memberNr).IntelligenceCap.ToString();
            txbLevelIntelligence.Text = baseStats.ElementAt(ProcessData.memberNr).IntelligenceLevel.ToString();

            txbCapCharisma.Text = baseStats.ElementAt(ProcessData.memberNr).CharismaCap.ToString();
            txbLevelCharisma.Text = baseStats.ElementAt(ProcessData.memberNr).CharismaLevel.ToString();

            txbCapPerception.Text = baseStats.ElementAt(ProcessData.memberNr).PerceptionCap.ToString();
            txbLevelPerception.Text = baseStats.ElementAt(ProcessData.memberNr).PerceptionLevel.ToString();

            txbCapFortitude.Text = baseStats.ElementAt(ProcessData.memberNr).FortitudeCap.ToString();
            txbLevelFortitude.Text = baseStats.ElementAt(ProcessData.memberNr).FortitudeLevel.ToString();

            //do
            //{
            //    pbxWarning.Visible = true;
            //    lblWarning.Visible = true;
            //}
            //while (Convert.ToInt32(txbCapStrenght.Text) <= 20
            //    || (Convert.ToInt32(txbCapDexterity.Text) <= 20)
            //    || (Convert.ToInt32(txbCapIntelligence.Text) <= 20)
            //    || (Convert.ToInt32(txbCapCharisma.Text) <= 20)
            //    || (Convert.ToInt32(txbCapPerception.Text) <= 20)
            //    || (Convert.ToInt32(txbCapFortitude.Text) <= 20));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ProcessFile.tempFilePath != "")
            {
                Output.Text = File.ReadAllText(ProcessFile.tempFilePath);
            }
            else
            {  
                MessageBox.Show ("ERROR - No Savegame loaded");
            }
                

        }

        private void decryptSaveOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open encrypted file and decrypting it using ProcessFile Class
            
            openSaveFile.Filter = "Sheltered 2 Savegame|*.dat";
            String Filename = "";

            if (openSaveFile.ShowDialog() == DialogResult.OK)
            {
                decodedData = processFile.LoadFile(openSaveFile.FileName);
                if (decodedData != string.Empty)
                {
                    // Open Save and output to Textbox
                    Output.Text = File.ReadAllText(ProcessFile.tempFilePath);

                }
                else
                {   // Retry
                    MessageBox.Show("This file is not a valid Sheltered 2 save file.", "Error");
                }
                Filename = openSaveFile.FileName;


                // Save decrypted File
               
                saveFileDialog.Filter = "Sheltered 2 Savegame|*.dat";

                DialogResult saveResult = saveFileDialog.ShowDialog();
                if (saveResult == DialogResult.OK)
                {

                    Filename = saveFileDialog.FileName;

                    try
                    {
                        var data = File.ReadAllBytes(ProcessFile.tempFilePath);
                        using (FileStream fileStream = File.Create(saveFileDialog.FileName))
                        {
                            if (fileStream != null)
                            {
                                fileStream.Write(data, 0, data.Length);
                                fileStream.Flush();

                                MessageBox.Show("File decrypted succesfully!", "File decrypted");
                            }
                        }
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Error decrypting File: " + ioe.Message);
                    }
                }

            }
        }

        private void encryptSaveOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //open encrypted file and encrypting it using ProcessFile Class
            
            openSaveFile.Filter = "Sheltered 2 Savegame|*.dat";
            String Filename = "";

            if (openSaveFile.ShowDialog() == DialogResult.OK)
            {
                decodedData = processFile.LoadFile(openSaveFile.FileName);
                if (decodedData != string.Empty)
                {
                    Output.Text = File.ReadAllText(ProcessFile.tempFilePath);
                }
                else
                {   // Retry
                    MessageBox.Show("This file is not a valid Sheltered 2 save file.", "Error");
                }
                Filename = openSaveFile.FileName;


                // Save encrypted File
                
                saveFileDialog.Filter = "Sheltered 2 Savegame|*.dat";

                DialogResult saveResult = saveFileDialog.ShowDialog();
                if (saveResult == DialogResult.OK)
                {

                    Filename = saveFileDialog.FileName;

                    try
                    {
                        var data = File.ReadAllBytes(ProcessFile.tempFilePath);
                        using (FileStream fileStream = File.Create(saveFileDialog.FileName))
                        {
                            if (fileStream != null)
                            {
                                fileStream.Write(data, 0, data.Length);
                                fileStream.Flush();

                                MessageBox.Show("File encrypted succesfully!", "File encrypted");
                            }
                        }
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Error encrypting File: " + ioe.Message);
                    }
                }

            }

        }

        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {

            XDocument xdoc = XDocument.Load(ProcessFile.tempFilePath);

            var firstNameRead = xdoc
                   .Element("root")
                   .Element("FamilyMembers")
                   .Elements().Where(x => x.Name.LocalName.StartsWith("Member_"));
            var firstNameSave = firstNameRead.Elements("firstName").FirstOrDefault();

            if (firstNameSave != null)
            {
                firstNameSave.Value = txbFirstname.Text;
                MessageBox.Show("Character Saved successfully");
                xdoc.Save(ProcessFile.tempFilePath);
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }          
            
        }
    }
}


