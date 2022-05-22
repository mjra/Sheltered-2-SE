using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
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


            //Load in Images
            string skillName = "";
            int numberSkills = 0;

            var skillList = new[]


            {
                new { Number =  14, Name = "Str"},
                new { Number =  12, Name = "Dex"},
                new { Number =  17, Name = "Int"},
                new { Number =  13, Name = "Cha"},
                new { Number =  17, Name = "Per"},
                new { Number =  20, Name = "For"}

            }.ToList();
            int indexAdd = 0;
            int selectedTab = 0;
            foreach (dynamic skill in skillList)
            {

                numberSkills = skill.Number;
                skillName = skill.Name;

                for (int i = 0; i < numberSkills; i++)

                {
                    tabControlSkills.SelectTab(selectedTab);
                    var imageBox = tabControlSkills.SelectedTab.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "pbx" + skillName + "Skill" + (i + 1).ToString());
                    imageBox.Image = skillIcons.Images[i + indexAdd];
                }
                indexAdd += numberSkills;
                selectedTab++;
            }
            tabControlSkills.SelectTab(0);

            var tabSelect = new[]
            {
                new { Name = "Str"},
                new { Name = "Dex"},
                new { Name = "Int"},
                new { Name = "Cha"},
                new { Name = "Per"},
                new { Name = "For"}

            }.ToList(); foreach (var skill in tabSelect)
            {
                var getSkill = tabControlSkills.TabPages["skillPage" + skill.Name].Controls;

                foreach (Control container in getSkill)
                {
                    if (container is PictureBox changeImage)
                    {
                        if (changeImage.Name.StartsWith("pbx" + skill.Name + "SkillLevel"))
                        {
                            changeImage.Image = skillLevelIcons.Images[Convert.ToInt32(changeImage.Tag)];
                        }
                    }
                }
            }

            tabControlMain.Visible = false;

        }
        ProcessFile processFile = new ProcessFile();
        ProcessData processData = new ProcessData();
        OpenFileDialog openSaveFile = new OpenFileDialog();
        //SaveFileDialog saveFileDialog = new SaveFileDialog();

        public string decodedData = string.Empty;
        public string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) + "\\AppData\\LocalLow\\Unicube\\Sheltered2\\";

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbxCharacterSelect.Items.Clear();
            cbxCharacterSelect.Text = "Select Character";
            Utilities.ResetAllControls(characterStatsTab);

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
                foreach (XElement member in fN)
                {
                    cbxCharacterSelect.Items.Add(member.Value);
                    ProcessData.familyMemberCount++;
                }
            }
            tabControlMain.Visible = true;
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

        }

        public void cbxCharacterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ProcessData.saved == 0)
            {

                List<GetFamilyMemberData> f = ProcessData.FamilyMembersList();

                int memberAmount = 0;

                foreach (GetFamilyMemberData member in f)
                {
                    memberAmount++;
                }


                var selectedItem = cbxCharacterSelect.Items[cbxCharacterSelect.SelectedIndex];

                ProcessData.memberNr = cbxCharacterSelect.SelectedIndex;

                txbFirstname.Text = selectedItem.ToString();
                List<GetFamilyMemberData> familyMembers = ProcessData.FamilyMembersList();

                foreach (GetFamilyMemberData member in familyMembers)
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
                        lblAnimTimeValue.Text = Convert.ToString(member.AnimTime);
                    }
                }
                txbCapStrenght.Text = f.ElementAt(ProcessData.memberNr).StrengthCap.ToString();
                txbLevelStrenght.Text = f.ElementAt(ProcessData.memberNr).StrengthLevel.ToString();

                txbCapDexterity.Text = f.ElementAt(ProcessData.memberNr).DexterityCap.ToString();
                txbLevelDexterity.Text = f.ElementAt(ProcessData.memberNr).DexterityLevel.ToString();

                txbCapIntelligence.Text = f.ElementAt(ProcessData.memberNr).IntelligenceCap.ToString();
                txbLevelIntelligence.Text = f.ElementAt(ProcessData.memberNr).IntelligenceLevel.ToString();

                txbCapCharisma.Text = f.ElementAt(ProcessData.memberNr).CharismaCap.ToString();
                txbLevelCharisma.Text = f.ElementAt(ProcessData.memberNr).CharismaLevel.ToString();

                txbCapPerception.Text = f.ElementAt(ProcessData.memberNr).PerceptionCap.ToString();
                txbLevelPerception.Text = f.ElementAt(ProcessData.memberNr).PerceptionLevel.ToString();

                txbCapFortitude.Text = f.ElementAt(ProcessData.memberNr).FortitudeCap.ToString();
                txbLevelFortitude.Text = f.ElementAt(ProcessData.memberNr).FortitudeLevel.ToString();
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
                MessageBox.Show("ERROR - No Savegame loaded");
            }
        }


        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(ProcessFile.tempFilePath);

            //Read in the nr of the Member (Member_x) into variable


            // Read userinput into List
            List<GetFamilyMemberData> familyMembers = ProcessData.FamilyMembersList();

            familyMembers[ProcessData.memberNr].FirstName = txbFirstname.Text;
            familyMembers[ProcessData.memberNr].LastName = txbLastname.Text;
            familyMembers[ProcessData.memberNr].Health = Convert.ToInt32(txbHealth.Text);
            familyMembers[ProcessData.memberNr].MaxHealth = Convert.ToInt32(txbMaxHealth.Text);
            familyMembers[ProcessData.memberNr].Interacting = Convert.ToBoolean(cBInteracting.Checked);
            familyMembers[ProcessData.memberNr].InteractingWithObj = Convert.ToBoolean(cBInteractingWithObj.Checked);
            familyMembers[ProcessData.memberNr].HasBeenDefibbed = Convert.ToBoolean(cBHasBeenDefibbed.Checked);
            familyMembers[ProcessData.memberNr].AnimHash = Convert.ToInt32(lblAnimHashValue.Text);
            familyMembers[ProcessData.memberNr].AnimTime = float.Parse(lblAnimTimeValue.Text);

            familyMembers[ProcessData.memberNr].StrengthCap = Convert.ToInt32(txbCapStrenght.Text);
            familyMembers[ProcessData.memberNr].StrengthLevel = Convert.ToInt32(txbLevelStrenght.Text);
            familyMembers[ProcessData.memberNr].DexterityCap = Convert.ToInt32(txbCapDexterity.Text);
            familyMembers[ProcessData.memberNr].DexterityLevel = Convert.ToInt32(txbLevelDexterity.Text);
            familyMembers[ProcessData.memberNr].IntelligenceCap = Convert.ToInt32(txbCapIntelligence.Text);
            familyMembers[ProcessData.memberNr].IntelligenceLevel = Convert.ToInt32(txbLevelIntelligence.Text);
            familyMembers[ProcessData.memberNr].CharismaCap = Convert.ToInt32(txbCapCharisma.Text);
            familyMembers[ProcessData.memberNr].CharismaLevel = Convert.ToInt32(txbLevelCharisma.Text);
            familyMembers[ProcessData.memberNr].PerceptionCap = Convert.ToInt32(txbCapPerception.Text);
            familyMembers[ProcessData.memberNr].PerceptionLevel = Convert.ToInt32(txbLevelPerception.Text);
            familyMembers[ProcessData.memberNr].FortitudeCap = Convert.ToInt32(txbCapFortitude.Text);
            familyMembers[ProcessData.memberNr].FortitudeLevel = Convert.ToInt32(txbLevelFortitude.Text);


            //int memberAmount = 0;
            //foreach (GetFamilyMemberData member in familyMembers)
            //{
            //    var getMemberNr = member.MemberNumber;
            //    memberAmount++;
            //}

            foreach (GetFamilyMemberData member in familyMembers)

            {
                var getBaseStat = xDoc
                .Element("root")
                .Element("FamilyMembers")
                .Elements(familyMembers[ProcessData.memberNr].MemberNumber)
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
                       .Elements(familyMembers[ProcessData.memberNr].MemberNumber);
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
                    getStrengthCap.Value = familyMembers[ProcessData.memberNr].StrengthCap.ToString();
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

                }

            }

            cbxCharacterSelect.Items.RemoveAt(ProcessData.memberNr);
            cbxCharacterSelect.Items.Insert(ProcessData.memberNr, txbFirstname.Text);
            cbxCharacterSelect.SelectedItem = txbFirstname;
            cbxCharacterSelect.Text = "Select Character";

            MessageBox.Show("Character saved successfully" +"\n" + "--------------------------------" + "\n" + "\n" + "\n" + "***** IMPORTANT *****" + "\n" + "You still need to save the Savegame!");

            xDoc.Save(ProcessFile.tempFilePath);

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

        private void btnMaxStats_Click(object sender, EventArgs e)
        {
            txbCapStrenght.Text = "20";
            txbLevelStrenght.Text = "20";
            txbCapDexterity.Text = "20";
            txbLevelDexterity.Text = "20";
            txbCapIntelligence.Text = "20";
            txbLevelIntelligence.Text = "20";
            txbCapCharisma.Text = "20";
            txbLevelCharisma.Text = "20";
            txbLevelPerception.Text = "20";
            txbCapPerception.Text = "20";
            txbLevelFortitude.Text = "20";
            txbCapFortitude.Text = "20";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Output.Text = "";

            //SkillPage.SkillLevelImage skill1 = new SkillPage.SkillLevelImage();
            //skill1.name = "pbx" + "SkillLevel" + "1";

            //var test = pbxStrSkill1 as PictureBox;

            //SkillPage.GetClick((PictureBox)test);

            var xDoc = XDocument.Load(ProcessFile.tempFilePath);
            for (int i = 0; i <= 80; i++)
            {
                List<ShelterRoom> roomList = xDoc.Descendants("ShelterCellList").Descendants("i" + i)
                             .Select(q => new ShelterRoom()
                             {
                                 RoomType = q.Element("type").Value,
                                 RoomMaterial = q.Element("roomType").Value,
                                 PercentExcavated = q.Element("percentageExcavated").Value
                             }).ToList<ShelterRoom>();
                foreach (var item in roomList)
                {
                    Output.AppendText("i" + i + "\n"
                        + item.RoomType + "\n"
                        + item.RoomMaterial + "\n"
                        + item.PercentExcavated + "\n"
                        + "___________________________________________" + "\n");


                }
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void pbxForSkill1_Click(object sender, EventArgs e)
        {

        }

        private void pbxStrSkill1_MouseClick(object sender, MouseEventArgs e)
        {


            //switch (e.Button)
            //{
            //    case MouseButtons.Right:
            //        {
            //            if (ProcessData.skillLevel == 5)
            //            {
            //                pbxStrSkillLevel1.Image = skillLevelIcons.Images[2];
            //                ProcessData.skillLevel = 2;
            //            }
            //            else if (ProcessData.skillLevel == 7)
            //            {
            //                pbxStrSkillLevel1.Image = skillLevelIcons.Images[5];
            //                ProcessData.skillLevel = 5;
            //            }
            //            else if (ProcessData.skillLevel == 8)
            //            {
            //                pbxStrSkillLevel1.Image = skillLevelIcons.Images[7];
            //                ProcessData.skillLevel = 7;
            //            }
            //        }
            //        break;
            //}
            //switch (e.Button)
            //{
            //    case MouseButtons.Left:
            //        {
            //            if (ProcessData.skillLevel == 2)
            //            {
            //                pbxStrSkillLevel1.Image = skillLevelIcons.Images[5];
            //                ProcessData.skillLevel = 5;
            //            }
            //            else if (ProcessData.skillLevel == 5)
            //            {
            //                pbxStrSkillLevel1.Image = skillLevelIcons.Images[7];
            //                ProcessData.skillLevel = 7;
            //            }
            //            else if (ProcessData.skillLevel == 7)
            //            {
            //                pbxStrSkillLevel1.Image = skillLevelIcons.Images[8];
            //                ProcessData.skillLevel = 8;
            //            }
            //        }
            //        break;
            //}
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex != 1)
            {
                cbxSkillsCharacterSelect.Items.Clear();
            }
            if (tabControlMain.SelectedIndex == 1)
            {
                cbxSkillsCharacterSelect.Items.AddRange(cbxCharacterSelect.Items.Cast<Object>().ToArray());
                lblSkillsCharacterName.Text = cbxSkillsCharacterSelect.Text;
            }

            if (tabControlMain.SelectedIndex == 2)
            {

            }
            if (tabControlMain.SelectedIndex == 3)
            {

            }
            if (tabControlMain.SelectedIndex == 4)
            {
                //Load in Unlocks from XML into variables
                var xDoc = XDocument.Load(ProcessFile.tempFilePath);

                string draftingTier2 = xDoc.Descendants("FactionAchievement_Building101").First().Value;
                string draftingTier3 = xDoc.Descendants("FactionAchievement_SkilledBuilder").First().Value;
                string draftingTier4 = xDoc.Descendants("FactionAchievement_ExpertBuilder").First().Value;
                string workbenchTier2 = xDoc.Descendants("FactionAchievement_Engineering101").First().Value;
                string workbenchTier3 = xDoc.Descendants("FactionAchievement_SkilledEngineer").First().Value;
                string workbenchTier4 = xDoc.Descendants("FactionAchievement_ExpertEngineer").First().Value;

                //BPs
                string batteryBank = xDoc.Descendants("RecipebatteryBank").First().Value;
                string flashbangMine = xDoc.Descendants("RecipeflashbangMine").First().Value;
                string industrialGenerator = xDoc.Descendants("RecipeindustrialGenerator").First().Value;
                string medicalBed = xDoc.Descendants("RecipemedicalBed").First().Value;
                string gasMine = xDoc.Descendants("RecipegasMine").First().Value;
                string efficientPlanter = xDoc.Descendants("RecipeEfficientPlanter").First().Value;
                string quantumBattery = xDoc.Descendants("RecipequantumBattery").First().Value;
                string defibrilator = xDoc.Descendants("Recipedefib").First().Value;
                string electricityTrap = xDoc.Descendants("RecipeelectricityTrap").First().Value;
                string laboratory = xDoc.Descendants("Recipelaboratory").First().Value;
                string recycler = xDoc.Descendants("Reciperecycler").First().Value;
                string solarPanel = xDoc.Descendants("RecipesolarPanel").First().Value;

                //Other unlocks
                string betterTrading = xDoc.Descendants("FactionAchievement_InsiderTrading").First().Value;
                string guncrafting = xDoc.Descendants("FactionAchievement_GunCrafting").First().Value;
                string carPartsCrafting = xDoc.Descendants("FactionAchievement_Mechanic").First().Value;
                string craftMedicine = xDoc.Descendants("FactionAchievement_Chemistry").First().Value;

                //Drugs
                string alcohol = xDoc.Descendants("RecipeAlcohol").First().Value;
                string crunk = xDoc.Descendants("RecipeCrunk").First().Value;
                string feederral = xDoc.Descendants("RecipeFeederral").First().Value;
                string python = xDoc.Descendants("RecipePython").First().Value;
                string sigma = xDoc.Descendants("RecipeSigma").First().Value;
                string snodge = xDoc.Descendants("RecipeSnodge").First().Value;
                string trankwill = xDoc.Descendants("RecipeTrankwill").First().Value;

                //Ally Rewards
                string indoctirnationCell1 = xDoc.Descendants("RecipeIndoctrinationCell").First().Value;
                string indoctirnationCell2 = xDoc.Descendants("RecipeAdvancedIndoctrinationCell").First().Value;
                string indoctirnationCell3 = xDoc.Descendants("RecipeUltimateIndoctrinationCell").First().Value;
                string morningstar1 = xDoc.Descendants("Recipemorningstar").First().Value;
                string morningstar2 = xDoc.Descendants("RecipetoxicMorningstar").First().Value;
                string morningstar3 = xDoc.Descendants("RecipebrutalMorningstar").First().Value;
                string pulsefireRifle1 = xDoc.Descendants("RecipePRiflePoor").First().Value;
                string pulsefireRifle2 = xDoc.Descendants("RecipePRifleGood").First().Value;
                string pulsefireRifle3 = xDoc.Descendants("RecipePRifleExcellent").First().Value;
                string sentryTurret1 = xDoc.Descendants("RecipesentryTurret").First().Value;
                string sentryTurret2 = xDoc.Descendants("RecipeImprovedSentryTurret").First().Value;
                string sentryTurret3 = xDoc.Descendants("RecipeMilitarySentryTurret").First().Value;
                string vaccine1 = xDoc.Descendants("Recipevaccinepoor").First().Value;
                string vaccine2 = xDoc.Descendants("Recipevaccinegood").First().Value;
                string vaccine3 = xDoc.Descendants("Recipevaccineexcellent").First().Value;

                //Load values into Form

                if (draftingTier2 == "5") { cbxDraftingTableTier2.Checked = true; }
                if (draftingTier3 == "5") { cbxDraftingTableTier3.Checked = true; }
                if (draftingTier4 == "1") { cbxDraftingTableTier4.Checked = true; }
                if (workbenchTier2 == "25") { cbxDraftingTableTier2.Checked = true; }
                if (workbenchTier3 == "25") { cbxDraftingTableTier3.Checked = true; }
                if (workbenchTier4 == "1") { cbxDraftingTableTier4.Checked = true; }

                if (batteryBank == "True") { cbxBpBatteryBank.Checked = true; }
                if (flashbangMine == "True") { cbxBpFlashbangMine.Checked = true; }
                if (industrialGenerator == "True") { cbxBpIndustrialGenerator.Checked = true; }
                if (medicalBed == "True") { cbxBpMedicalBed.Checked = true; }
                if (gasMine == "True") { cbxBpGasMine.Checked = true; }
                if (efficientPlanter == "True") { cbxBpEfficientPlanter.Checked = true; }
                if (quantumBattery == "True") { cbxBpQuantumBattery.Checked = true; }
                if (defibrilator == "True") { cbxBpDefibrilator.Checked = true; }
                if (electricityTrap == "True") { cbxBpElectricityTrap.Checked = true; }
                if (laboratory == "True") { cbxBpLaboratory.Checked = true; }
                if (recycler == "True") { cbxBpRecycler.Checked = true; }
                if (solarPanel == "True") { cbxBpSolarPanel.Checked = true; }

                if (alcohol == "True") { cbxDrugsAlcohol.Checked = true; }
                if (crunk == "True") { cbxDrugsCrunk.Checked = true; }
                if (feederral == "True") { cbxDrugsFeederral.Checked = true; }
                if (python == "True") { cbxDrugsPython.Checked = true; }
                if (sigma == "True") { cbxDrugsSigma.Checked = true; }
                if (snodge == "True") { cbxDrugsSnodge.Checked = true; }
                if (trankwill == "True") { cbxDrugsTrankwill.Checked = true; }

                if (betterTrading == "1") { cbxOtherTrading.Checked = true; }
                if (guncrafting == "1") { cbxOtherGunCrafting.Checked = true; }
                if (carPartsCrafting == "1") { cbxOtherCarPartsCrafting.Checked = true; }
                if (craftMedicine == "1") { cbxMedicineCrafting.Checked = true; }

                if (indoctirnationCell1 == "True") { cbxDraftingTableTier2.Checked = true; }
                if (indoctirnationCell2 == "True") { cbxDraftingTableTier3.Checked = true; }
                if (indoctirnationCell3 == "True") { cbxDraftingTableTier4.Checked = true; }
                if (morningstar1 == "True") { cbxBpBatteryBank.Checked = true; }
                if (morningstar2 == "True") { cbxBpFlashbangMine.Checked = true; }
                if (morningstar3 == "True") { cbxBpIndustrialGenerator.Checked = true; }
                if (pulsefireRifle1 == "True") { cbxBpMedicalBed.Checked = true; }
                if (pulsefireRifle2 == "True") { cbxBpGasMine.Checked = true; }
                if (pulsefireRifle3 == "True") { cbxBpEfficientPlanter.Checked = true; }
                if (sentryTurret1 == "True") { cbxBpQuantumBattery.Checked = true; }
                if (sentryTurret2 == "True") { cbxBpDefibrilator.Checked = true; }
                if (sentryTurret3 == "True") { cbxBpElectricityTrap.Checked = true; }
                if (vaccine1 == "True") { cbxBpLaboratory.Checked = true; }
                if (vaccine2 == "True") { cbxBpRecycler.Checked = true; }
                if (vaccine3 == "True") { cbxBpSolarPanel.Checked = true; }


                if (tabControlMain.SelectedIndex == 5)

                {

                }
            }


        }

        private void cbxSkillsCharacterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblSkillsCharacterName.Text = cbxSkillsCharacterSelect.Text;

        }

        private void unlockingTab_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenDesigner_Click(object sender, EventArgs e)
        {

            // Create a new instance of the Form2 class
            ShelterDesigner shelterDesignerForm = new ShelterDesigner();

            // Show the settings form
            shelterDesignerForm.Show();

        }

        private void btnRevealMap_Click(object sender, EventArgs e)
        {
            var xDoc = XDocument.Load(ProcessFile.tempFilePath);

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    xDoc.Descendants("Map").Elements().Where(p => p.Name == "MapTile_" + i + "_" + j).Descendants("Discovered").First().Value = "True";
                }
            }




            xDoc.Save(ProcessFile.tempFilePath);
            MessageBox.Show("Map revealed succesfully." + "\n"+ "--------------------------------" + "\n" + "\n"+"\n"+ "***** IMPORTANT *****" + "\n" + "You still need to save the Savegame!");


        }

        private void btnSaveUnlocks_Click(object sender, EventArgs e)
        {
            var xDoc = XDocument.Load(ProcessFile.tempFilePath);

            if (cbxDraftingTableTier2.Checked == true) { xDoc.Descendants("FactionAchievement_Building101").First().Value = "5"; }
            if (cbxDraftingTableTier3.Checked == true) { xDoc.Descendants("FactionAchievement_SkilledBuilder").First().Value = "5"; }
            if (cbxDraftingTableTier4.Checked == true) { xDoc.Descendants("FactionAchievement_ExpertBuilder").First().Value = "1"; }
            if (cbxDraftingTableTier2.Checked == true) { xDoc.Descendants("FactionAchievement_Engineering101").First().Value = "25"; }
            if (cbxDraftingTableTier3.Checked == true) { xDoc.Descendants("FactionAchievement_SkilledEngineer").First().Value = "25"; }
            if (cbxDraftingTableTier4.Checked == true) { xDoc.Descendants("FactionAchievement_ExpertEngineer").First().Value = "1"; }

            if (cbxBpBatteryBank.Checked == true) { xDoc.Descendants("RecipebatteryBank").First().Value = "True"; }
            if (cbxBpFlashbangMine.Checked == true) { xDoc.Descendants("RecipeflashbangMine").First().Value = "True"; }
            if (cbxBpIndustrialGenerator.Checked == true) { xDoc.Descendants("RecipeindustrialGenerator").First().Value = "True"; }
            if (cbxBpMedicalBed.Checked == true) { xDoc.Descendants("RecipemedicalBed").First().Value = "True"; }
            if (cbxBpGasMine.Checked == true) { xDoc.Descendants("RecipegasMine").First().Value = "True"; }
            if (cbxBpEfficientPlanter.Checked == true) { xDoc.Descendants("RecipeEfficientPlanter").First().Value = "True"; }
            if (cbxBpQuantumBattery.Checked == true) { xDoc.Descendants("RecipequantumBattery").First().Value = "True"; }
            if (cbxBpDefibrilator.Checked == true) { xDoc.Descendants("Recipedefib").First().Value = "True"; }
            if (cbxBpElectricityTrap.Checked == true) { xDoc.Descendants("RecipeelectricityTrap").First().Value = "True"; }
            if (cbxBpLaboratory.Checked == true) { xDoc.Descendants("Recipelaboratory").First().Value = "True"; }
            if (cbxBpRecycler.Checked == true) { xDoc.Descendants("Reciperecycler").First().Value = "True"; }
            if (cbxBpSolarPanel.Checked == true) { xDoc.Descendants("RecipesolarPanel").First().Value = "True"; }

            if (cbxDrugsAlcohol.Checked == true) { xDoc.Descendants("RecipeAlcohol").First().Value = "True"; }
            if (cbxDrugsCrunk.Checked == true) { xDoc.Descendants("RecipeCrunk").First().Value = "True"; }
            if (cbxDrugsFeederral.Checked == true) { xDoc.Descendants("RecipeFeederral").First().Value = "True"; }
            if (cbxDrugsPython.Checked == true) { xDoc.Descendants("RecipePython").First().Value = "True"; }
            if (cbxDrugsSigma.Checked == true) { xDoc.Descendants("RecipeSigma").First().Value = "True"; }
            if (cbxDrugsSnodge.Checked == true) { xDoc.Descendants("RecipeSnodge").First().Value = "True"; }
            if (cbxDrugsTrankwill.Checked == true) { xDoc.Descendants("RecipeTrankwill").First().Value = "True"; }

            if (cbxOtherTrading.Checked == true) { xDoc.Descendants("FactionAchievement_InsiderTrading").First().Value = "1"; }
            if (cbxOtherGunCrafting.Checked == true) { xDoc.Descendants("FactionAchievement_GunCrafting").First().Value = "1"; }
            if (cbxOtherCarPartsCrafting.Checked == true) { xDoc.Descendants("FactionAchievement_Mechanic").First().Value = "1"; }
            if (cbxMedicineCrafting.Checked == true) { xDoc.Descendants("FactionAchievement_Chemistry").First().Value = "1"; }
            if (cbxDamageAmplifier.Checked == true) { xDoc.Descendants("RecipedamageAmplifier").First().Value = "True"; }

            if (cbxRewardChurchQ1.Checked == true) { xDoc.Descendants("RecipeIndoctrinationCell").First().Value = "True"; }
            if (cbxRewardChurchQ2.Checked == true) { xDoc.Descendants("RecipeAdvancedIndoctrinationCell").First().Value = "True"; }
            if (cbxRewardChurchQ3.Checked == true) { xDoc.Descendants("RecipeUltimateIndoctrinationCell").First().Value = "True"; }
            if (cbxRewardCtkQ1.Checked == true) { xDoc.Descendants("Recipemorningstar").First().Value = "True"; }
            if (cbxRewardCtkQ2.Checked == true) { xDoc.Descendants("RecipetoxicMorningstar").First().Value = "True"; }
            if (cbxRewardCtkQ3.Checked == true) { xDoc.Descendants("RecipebrutalMorningstar").First().Value = "True"; }
            if (cbxRewardNewQ1.Checked == true) { xDoc.Descendants("RecipePRiflePoor").First().Value = "True"; xDoc.Descendants("RecipeantimatterCellRecipe").First().Value = "True"; }
            if (cbxRewardNewQ2.Checked == true) { xDoc.Descendants("RecipePRifleGood").First().Value = "True"; xDoc.Descendants("RecipeantimatterCellRecipe").First().Value = "True"; }
            if (cbxRewardNewQ3.Checked == true) { xDoc.Descendants("RecipePRifleExcellent").First().Value = "True"; xDoc.Descendants("RecipeantimatterCellRecipe").First().Value = "True"; }
            if (cbxRewardBlackQ1.Checked == true) { xDoc.Descendants("RecipesentryTurret").First().Value = "True"; xDoc.Descendants("RecipesentryTurretAmmo").First().Value = "True"; }
            if (cbxRewardBlackQ2.Checked == true) { xDoc.Descendants("RecipeImprovedSentryTurret").First().Value = "True"; xDoc.Descendants("RecipesentryTurretAmmo").First().Value = "True"; }
            if (cbxRewardBlackQ3.Checked == true) { xDoc.Descendants("RecipeMilitarySentryTurret").First().Value = "True"; xDoc.Descendants("RecipesentryTurretAmmo").First().Value = "True"; }
            if (cbxRewardLosQ1.Checked == true) { xDoc.Descendants("Recipevaccinepoor").First().Value = "True"; }
            if (cbxRewardLosQ2.Checked == true) { xDoc.Descendants("Recipevaccinegood").First().Value = "True"; }
            if (cbxRewardLosQ3.Checked == true) { xDoc.Descendants("Recipevaccineexcellent").First().Value = "True"; }
            if (cbxRewardOldQ1.Checked == true) { /*toADD*/ }
            if (cbxRewardOldQ2.Checked == true) { /*toADD*/ }
            if (cbxRewardOldQ3.Checked == true) { /*toADD*/ }

            MessageBox.Show("Unlocks saved successfully." + "\n" + "--------------------------------" + "\n" + "\n" + "\n" + "***** IMPORTANT *****" + "\n" + "You still need to save the Savegame!");
            xDoc.Save(ProcessFile.tempFilePath);

        }

        private void btnUnlockAll_Click(object sender, EventArgs e)
        {

            foreach (CheckBox cB in tabControlMain.SelectedTab.Controls.OfType<CheckBox>())
            {
                if (cB.Enabled == true)
                {
                    if (cB.Name.Contains("Q1") || cB.Name.Contains("Q2"))
                    {

                    }
                    else
                    {
                        cB.Checked = true;
                    }
                }

            }

        }
    }
}



