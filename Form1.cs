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
                    Output.Text = File.ReadAllText(ProcessFile.tempFilePath);
                    
                }
                else
                {   // Retry
                    MessageBox.Show("This file is not a valid Sheltered 2 save file.", "Error");
                }
                Filename = openSaveFile.FileName;

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

        private void removeFogOfWarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(ProcessFile.tempFilePath);

            var getMemberNr = xDoc
                .Element("root")
                .Element("FamilyMembers")
                .Elements().Where(x => x.Name.LocalName.StartsWith("Member_"))
                .Elements("firstName");
            var memberName = getMemberNr.Ancestors().First().Name;

            var getBaseStat = xDoc
                .Element("root")
                .Element("FamilyMembers")
                .Elements(memberName)
                .Elements("BaseStats");
            var getStrengthLvl = getBaseStat.Elements("Strength").Elements("level").First().Value;
            var getStrengthCap = getBaseStat.Elements("Strength").Elements("cap").First().Value;
            var getDexterityLvl = getBaseStat.Elements("Dexterity").Elements("level").First().Value;

            MessageBox.Show(getStrengthLvl + "\n" + getStrengthCap);

        }

        public void cbxCharacterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ProcessData.saved == 0)
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
            }
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
            XDocument xDoc = XDocument.Load(ProcessFile.tempFilePath);

            //Read in the nr of the Member (Member_x) into variable

            var getMemberNr = xDoc
                .Element("root")
                .Element("FamilyMembers")
                .Elements().Where(x => x.Name.LocalName.StartsWith("Member_"))
                .Elements("firstName");
            var memberName = getMemberNr.Ancestors().First().Name;


            var getBaseStat = xDoc
                .Element("root")
                .Element("FamilyMembers")
                .Elements(memberName)
                .Elements("BaseStats");
            var getStrengthLvl = getBaseStat.Elements("Strength").Elements("level").First();
            var getStrengthCap = getBaseStat.Elements("Strength").Elements("cap").First();
            var getDexterityLvl = getBaseStat.Elements("Dexterity").Elements("level").First();
            var getDexterityCap = getBaseStat.Elements("Dexterity").Elements("cap").First();
            var getIntelligenceLvl = getBaseStat.Elements("Intelligence").Elements("level").First();
            var getIntelligenceCap = getBaseStat.Elements("Intelligence").Elements("cap").First();
            var getCharismaLvl = getBaseStat.Elements("Charisma").Elements("level").First();
            var getCharismaCap = getBaseStat.Elements("Charisma").Elements("cap").First();
            var getPerceptionLvl = getBaseStat.Elements("Perception").Elements("level").First();
            var getPerceptionCap = getBaseStat.Elements("Perception").Elements("cap").First();
            var getFortitudeLvl = getBaseStat.Elements("Fortitude").Elements("level").First();
            var getFortitudeCap = getBaseStat.Elements("Fortitude").Elements("cap").First();

            var readXML = xDoc
                   .Element("root")
                   .Element("FamilyMembers")
                   .Elements(memberName);
            var firstNameSave = readXML.Elements("firstName").FirstOrDefault();
            var lastNameSave = readXML.Elements("lastName").FirstOrDefault();
            var healthSave = readXML.Elements("health").FirstOrDefault();
            var maxHealthSave = readXML.Elements("maxHealth").FirstOrDefault();
            var interactingSave = readXML.Elements("interacting").FirstOrDefault();
            var interactingWithObjSave = readXML.Elements("interactingWithObj").FirstOrDefault();
            var hasBeenDefibbedSave = readXML.Elements("hasBeenDefibbed").FirstOrDefault();
            var animHashSave = readXML.Elements("animHash").FirstOrDefault();
            var animTimeSave = readXML.Elements("animTime").FirstOrDefault();

            if (firstNameSave != null && lastNameSave != null && healthSave != null && maxHealthSave != null && interactingSave != null 
                && interactingWithObjSave != null && hasBeenDefibbedSave != null && animHashSave != null && animTimeSave != null
                && getStrengthLvl != null && getStrengthCap != null && getDexterityLvl != null && getDexterityCap != null
                && getIntelligenceLvl != null && getIntelligenceCap != null && getCharismaLvl != null && getCharismaCap != null
                && getPerceptionLvl != null && getPerceptionCap != null && getFortitudeLvl != null && getFortitudeCap != null)

            {
                firstNameSave.Value = txbFirstname.Text;
                lastNameSave.Value = txbLastname.Text;
                healthSave.Value = txbHealth.Text;
                maxHealthSave.Value = txbMaxHealth.Text;
                interactingSave.Value = cBInteracting.Checked.ToString();
                interactingWithObjSave.Value = cBInteractingWithObj.Checked.ToString();
                hasBeenDefibbedSave.Value = cBHasBeenDefibbed.Checked.ToString();
                animHashSave.Value = lblAnimHashValue.Text;
                animTimeSave.Value = lblAnimTimeValue.Text;

                getStrengthLvl.Value = txbLevelStrenght.Text;
                getStrengthCap.Value = txbCapStrenght.Text;
                getDexterityLvl.Value = txbLevelDexterity.Text;
                getDexterityCap.Value = txbCapDexterity.Text;
                getIntelligenceLvl.Value = txbLevelIntelligence.Text;
                getIntelligenceCap.Value = txbCapIntelligence.Text;
                getCharismaLvl.Value = txbLevelCharisma.Text;
                getCharismaCap.Value = txbCapCharisma.Text;
                getPerceptionLvl.Value = txbLevelPerception.Text;
                getPerceptionCap.Value = txbCapPerception.Text;
                getFortitudeLvl.Value = txbLevelFortitude.Text;
                getFortitudeCap.Value = txbCapFortitude.Text;

                cbxCharacterSelect.Items.RemoveAt(ProcessData.memberNr);
                cbxCharacterSelect.Items.Insert(ProcessData.memberNr, txbFirstname.Text);
                cbxCharacterSelect.SelectedItem = txbFirstname;
                cbxCharacterSelect.Text = "Select Character";

                MessageBox.Show("Character Saved successfully");
                xDoc.Save(ProcessFile.tempFilePath);
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }  
        }

        private void btnUnstuckCharacter_Click(object sender, EventArgs e)
        {
            lblAnimHashValue.Text = "-541223289";
            lblAnimTimeValue.Text = "0,05509559";
        }

        static void gotoSite(string url)
        {
            System.Diagnostics.Process.Start(url);
        }


        private void buyMeACoffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string url = "https://ko-fi.com/mjra83";
            gotoSite(url);//open url in default browser

        }
    }
}


