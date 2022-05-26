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
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Sheltered_2_SE
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection pfc = new PrivateFontCollection();

        public static Font bebas;
        public static Font bebas10;
        public static Font bebas16;
        public static Font bebas30;

        public Form1()
        {

            InitializeComponent();

            byte[] fontData = Properties.Resources.BebasNeue_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            pfc.AddMemoryFont(fontPtr, Properties.Resources.BebasNeue_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.BebasNeue_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            bebas = new Font(pfc.Families[0], 12.0F);
            bebas10 = new Font(pfc.Families[0], 10.0F);
            bebas16 = new Font(pfc.Families[0], 16.0F);
            bebas30 = new Font(pfc.Families[0], 30.0F);



            //read in embeded font 
            tabControlMain.Font = bebas;
            characterStatsTab.Font = bebas;
            lblCharacterStats.Font = bebas16;
            lblWarning.Font = bebas;

            characterSkillsTab.Font = bebas;
            lblSkillsCharacterName.Font = bebas16;
            btnSaveCharacterSkills.Font = bebas;
            btnMaxAllSkills.Font = bebas;
            skillPageStr.Font = bebas;
            skillPageDex.Font = bebas;
            skillPageInt.Font = bebas;
            skillPageCha.Font = bebas;
            skillPagePer.Font = bebas;
            skillPageFor.Font = bebas;
            lblStrTier1.Font = bebas16;
            lblStrTier2.Font = bebas16;
            lblStrTier3.Font = bebas16;
            lblDexTier1.Font = bebas16;
            lblDexTier2.Font = bebas16;
            lblDexTier3.Font = bebas16;
            lblIntTier1.Font = bebas16;
            lblIntTier2.Font = bebas16;
            lblIntTier3.Font = bebas16;
            lblChaTier1.Font = bebas16;
            lblChaTier2.Font = bebas16;
            lblChaTier3.Font = bebas16;
            lblPerTier1.Font = bebas16;
            lblPerTier2.Font = bebas16;
            lblPerTier3.Font = bebas16;
            lblForTier1.Font = bebas16;
            lblForTier2.Font = bebas16;
            lblForTier3.Font = bebas16;

            petsTab.Font = bebas;
            lblPetsToBeAdded.Font = bebas30;

            deseasesTab.Font = bebas;
            lblDeseasesToBeAdded.Font = bebas30;

            unlockingTab.Font = bebas;
            cbxDraftingTableTier2.Font = bebas10;
            cbxDraftingTableTier3.Font = bebas10;
            cbxDraftingTableTier4.Font = bebas10;
            cbxWorkbenchTier2.Font = bebas10;
            cbxWorkbenchTier3.Font = bebas10;
            cbxWorkbenchTier4.Font = bebas10;
            cbxBpBatteryBank.Font = bebas10;
            cbxBpFlashbangMine.Font = bebas10;
            cbxBpIndustrialGenerator.Font = bebas10;
            cbxBpMedicalBed.Font = bebas10;
            cbxBpGasMine.Font = bebas10;
            cbxBpEfficientPlanter.Font = bebas10;
            cbxBpQuantumBattery.Font = bebas10;
            cbxBpDefibrilator.Font = bebas10;
            cbxBpElectricityTrap.Font = bebas10;
            cbxBpLaboratory.Font = bebas10;
            cbxBpRecycler.Font = bebas10;
            cbxBpSolarPanel.Font = bebas10;
            cbxDrugsAlcohol.Font = bebas10;
            cbxDrugsCrunk.Font = bebas10;
            cbxDrugsFeederral.Font = bebas10;
            cbxDrugsPython.Font = bebas10;
            cbxDrugsSigma.Font = bebas10;
            cbxDrugsSnodge.Font = bebas10;
            cbxDrugsTrankwill.Font = bebas10;
            cbxOtherTrading.Font = bebas10;
            cbxOtherGunCrafting.Font = bebas10;
            cbxOtherCarPartsCrafting.Font = bebas10;
            cbxMedicineCrafting.Font = bebas10;
            cbxDamageAmplifier.Font = bebas10;
            cbxRewardChurchQ1.Font = bebas10;
            cbxRewardChurchQ2.Font = bebas10;
            cbxRewardChurchQ3.Font = bebas10;
            cbxRewardCtkQ1.Font = bebas10;
            cbxRewardCtkQ2.Font = bebas10;
            cbxRewardCtkQ3.Font = bebas10;
            cbxRewardNewQ1.Font = bebas10;
            cbxRewardNewQ2.Font = bebas10;
            cbxRewardNewQ3.Font = bebas10;
            cbxRewardBlackQ1.Font = bebas10;
            cbxRewardBlackQ2.Font = bebas10;
            cbxRewardBlackQ3.Font = bebas10;
            cbxRewardLosQ1.Font = bebas10;
            cbxRewardLosQ2.Font = bebas10;
            cbxRewardLosQ3.Font = bebas10;

            debugTab.Font = bebas;
            lblDebugToBeAdded.Font = bebas30;

            shelterDesignerTab.Font = bebas;

            LoadSkillImages();
            GetClick();


            tabControlMain.Visible = false;

        }

        private void GetClick()
        {
            var tabPagesList = new List<TabPage> { skillPageStr, skillPageDex, skillPageInt, skillPageCha, skillPagePer, skillPageFor };

            List<PictureBox> skillList = new List<PictureBox>();
            foreach (var tabPage in tabPagesList)
            {
                skillList = tabPage.Controls.OfType<PictureBox>()
                   .Where(p => p.Name.Contains("Skill") && !p.Name.Contains("Level"))
                   .ToList();
                foreach (var pictureBox in skillList)
                {
                    pictureBox.MouseClick += PictureBoxClick;
                }
            }
        }

        private void PictureBoxClick(object sender, MouseEventArgs e)
        {
            var picBoxName = ((PictureBox)sender).Name.Insert(11, "Level");

            var tabPagesList = new List<TabPage> { skillPageStr, skillPageDex, skillPageInt, skillPageCha, skillPagePer, skillPageFor };

            List<PictureBox> skillList = new List<PictureBox>();
            foreach (var tabPage in tabPagesList)
            {
                skillList = tabPage.Controls.OfType<PictureBox>()
                   .Where(p => p.Name.Contains("SkillLevel"))
                   .ToList();
                foreach (var pictureBox in skillList)
                {
                    var availablePointsList = new List<Label>() { lblPointsAvailableStrValue, lblPointsAvailableDexValue, lblPointsAvailableIntValue, lblPointsAvailableChaValue, lblPointsAvailablePerValue, lblPointsAvailableForValue };
                    foreach (var label in availablePointsList)
                    {
                        var checkTab = tabPage.Name.Remove(0, 9) + "Value";
                        var checkLabel = label.Name.Remove(0, 18);
                        if (checkTab == checkLabel)
                        {
                            if (picBoxName == pictureBox.Name)
                            {
                                int labelValue = Convert.ToInt32(label.Text);
                                switch (e.Button)
                                {
                                    case MouseButtons.Right:
                                        {
                                            if (Convert.ToInt32(label.Text) >= 0)
                                            {
                                                if (pictureBox.Tag.ToString() == "0")
                                                {
                                                    if (pictureBox.AccessibleName == "1")
                                                    {
                                                        pictureBox.AccessibleName = "0";
                                                        pictureBox.Image = skillLevelIcons.Images[0];
                                                        labelValue += 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                }
                                                else if (pictureBox.Tag.ToString() == "1")
                                                {
                                                    if (pictureBox.AccessibleName == "1")
                                                    {
                                                        pictureBox.AccessibleName = "0";
                                                        pictureBox.Image = skillLevelIcons.Images[1];
                                                        labelValue += 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                    else if (pictureBox.AccessibleName == "2")
                                                    {
                                                        pictureBox.AccessibleName = "1";
                                                        pictureBox.Image = skillLevelIcons.Images[4];
                                                        labelValue += 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                }
                                                else if (pictureBox.Tag.ToString() == "2")
                                                {
                                                    if (pictureBox.AccessibleName == "1")
                                                    {
                                                        pictureBox.AccessibleName = "0";
                                                        pictureBox.Image = skillLevelIcons.Images[2];
                                                        labelValue += 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                    else if (pictureBox.AccessibleName == "2")
                                                    {
                                                        pictureBox.AccessibleName = "1";
                                                        pictureBox.Image = skillLevelIcons.Images[6];
                                                        labelValue += 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                    else if (pictureBox.AccessibleName == "3")
                                                    {
                                                        pictureBox.AccessibleName = "2";
                                                        pictureBox.Image = skillLevelIcons.Images[7];
                                                        labelValue += 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                }
                                switch (e.Button)
                                {
                                    case MouseButtons.Left:
                                        {
                                            if (Convert.ToInt32(label.Text) > 0)
                                            {
                                                if (pictureBox.Tag.ToString() == "0")
                                                {
                                                    if (pictureBox.AccessibleName == "0")
                                                    {
                                                        pictureBox.AccessibleName = "1";
                                                        pictureBox.Image = skillLevelIcons.Images[3];
                                                        labelValue -= 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                }
                                                else if (pictureBox.Tag.ToString() == "1")
                                                {
                                                    if (pictureBox.AccessibleName == "0")
                                                    {
                                                        pictureBox.AccessibleName = "1";
                                                        pictureBox.Image = skillLevelIcons.Images[4];
                                                        labelValue -= 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                    else if (pictureBox.AccessibleName == "1")
                                                    {
                                                        pictureBox.AccessibleName = "2";
                                                        pictureBox.Image = skillLevelIcons.Images[5];
                                                        labelValue -= 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                }
                                                else if (pictureBox.Tag.ToString() == "2")
                                                {
                                                    if (pictureBox.AccessibleName == "0")
                                                    {
                                                        pictureBox.AccessibleName = "1";
                                                        pictureBox.Image = skillLevelIcons.Images[6];
                                                        labelValue -= 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                    else if (pictureBox.AccessibleName == "1")
                                                    {
                                                        pictureBox.AccessibleName = "2";
                                                        pictureBox.Image = skillLevelIcons.Images[7];
                                                        labelValue -= 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                    else if (pictureBox.AccessibleName == "2")
                                                    {
                                                        pictureBox.AccessibleName = "3";
                                                        pictureBox.Image = skillLevelIcons.Images[8];
                                                        labelValue -= 1;
                                                        label.Text = labelValue.ToString();
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
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
                var xDoc = XElement.Load(ProcessFile.tempFilePath);
                List<LoadNames> fullName = xDoc.Descendants("FamilyMembers").Descendants().Where(x => x.Name.LocalName.StartsWith("Member_"))
                    .Select(p => new LoadNames()
                    {
                        FirstName = p.DescendantsAndSelf("firstName").FirstOrDefault().Value,
                        LastName = p.DescendantsAndSelf("lastName").FirstOrDefault().Value

                    }).ToList();
                foreach (var name in fullName)
                {
                    cbxCharacterSelect.Items.Add(name.FirstName + " " + name.LastName);
                    ProcessData.familyMemberCount++;
                }
            }
            tabControlMain.Visible = true;


            //Set Values of Character for available Points
            var doc = XElement.Load(ProcessFile.tempFilePath);

            List<GetSkillPoints> skillPoints = doc.Descendants("FamilyMembers").Descendants().Where(x => x.Name.LocalName.StartsWith("Member_"))
                .Select(p => new GetSkillPoints()
                {
                    FirstName = p.DescendantsAndSelf("firstName").FirstOrDefault().Value,
                    LastName = p.DescendantsAndSelf("lastName").FirstOrDefault().Value,
                    StrengthLevelBefore = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Strength").Descendants("level").FirstOrDefault().Value),
                    DexterityLevelBefore = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Dexterity").Descendants("level").FirstOrDefault().Value),
                    IntelligenceLevelBefore = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Intelligence").Descendants("level").FirstOrDefault().Value),
                    CharismaLevelBefore = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Charisma").Descendants("level").FirstOrDefault().Value),
                    PerceptionLevelBefore = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Perception").Descendants("level").FirstOrDefault().Value),
                    FortitudeLevelBefore = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Fortitude").Descendants("level").FirstOrDefault().Value),

                }).ToList();

            GetSkillPoints._getSkillPoints = skillPoints;

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
                    if (member.FirstName + " " + member.LastName == txbFirstname.Text)
                    {
                        txbFirstname.Text = member.FirstName;
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

            List<GetSkillPoints> skillPoints = new List<GetSkillPoints>();
            foreach (var skill in skillPoints)
            {
                skill.StrengthLevelBefore = Convert.ToInt32(txbLevelStrenght.Text);
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
            cbxCharacterSelect.Items.Insert(ProcessData.memberNr, txbFirstname.Text + " " + txbLastname.Text);
            cbxCharacterSelect.SelectedItem = txbFirstname + " " + txbLastname;
            cbxCharacterSelect.Text = "Select Character";


            xDoc.Save(ProcessFile.tempFilePath);
            MessageBox.Show("Character saved successfully" + "\n" + "--------------------------------" + "\n" + "\n" + "\n" + "***** IMPORTANT *****" + "\n" + "You still need to save the Savegame!");
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

        }

        private void LoadSkillImages()
        {
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
                tabControlSkills.SelectedIndex = 0;

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
                string draftingTier2 = xDoc.Descendants("FactionAchievement_Building101").Descendants().First().Value;
                string draftingTier3 = xDoc.Descendants("FactionAchievement_SkilledBuilder").Descendants().First().Value;
                string draftingTier4 = xDoc.Descendants("FactionAchievement_ExpertBuilder").Descendants().First().Value;
                string workbenchTier2 = xDoc.Descendants("FactionAchievement_Engineering101").Descendants().First().Value;
                string workbenchTier3 = xDoc.Descendants("FactionAchievement_SkilledEngineer").Descendants().First().Value;
                string workbenchTier4 = xDoc.Descendants("FactionAchievement_ExpertEngineer").Descendants().First().Value;

                //BPs
                string batteryBank = xDoc.Descendants("RecipebatteryBank").Descendants().First().Value;
                string flashbangMine = xDoc.Descendants("RecipeflashbangMine").Descendants().First().Value;
                string industrialGenerator = xDoc.Descendants("RecipeindustrialGenerator").Descendants().First().Value;
                string medicalBed = xDoc.Descendants("RecipemedicalBed").Descendants().First().Value;
                string gasMine = xDoc.Descendants("RecipegasMine").Descendants().First().Value;
                string efficientPlanter = xDoc.Descendants("RecipeEfficientPlanter").Descendants().First().Value;
                string quantumBattery = xDoc.Descendants("RecipequantumBattery").Descendants().First().Value;
                string defibrilator = xDoc.Descendants("Recipedefib").Descendants().First().Value;
                string electricityTrap = xDoc.Descendants("RecipeelectricityTrap").Descendants().First().Value;
                string laboratory = xDoc.Descendants("Recipelaboratory").Descendants().First().Value;
                string recycler = xDoc.Descendants("Reciperecycler").Descendants().First().Value;
                string solarPanel = xDoc.Descendants("RecipesolarPanel").Descendants().First().Value;

                //Other unlocks
                string betterTrading = xDoc.Descendants("FactionAchievement_InsiderTrading").Descendants().First().Value;
                string guncrafting = xDoc.Descendants("FactionAchievement_GunCrafting").Descendants().First().Value;
                string carPartsCrafting = xDoc.Descendants("FactionAchievement_Mechanic").Descendants().First().Value;
                string craftMedicine = xDoc.Descendants("FactionAchievement_Chemistry").Descendants().First().Value;

                //Drugs
                string alcohol = xDoc.Descendants("RecipeAlcohol").Descendants().First().Value;
                string crunk = xDoc.Descendants("RecipeCrunk").Descendants().First().Value;
                string feederral = xDoc.Descendants("RecipeFeederral").Descendants().First().Value;
                string python = xDoc.Descendants("RecipePython").Descendants().First().Value;
                string sigma = xDoc.Descendants("RecipeSigma").Descendants().First().Value;
                string snodge = xDoc.Descendants("RecipeSnodge").Descendants().First().Value;
                string trankwill = xDoc.Descendants("RecipeTrankwill").Descendants().First().Value;

                //Ally Rewards
                string indoctirnationCell1 = xDoc.Descendants("RecipeIndoctrinationCell").Descendants().First().Value;
                string indoctirnationCell2 = xDoc.Descendants("RecipeAdvancedIndoctrinationCell").Descendants().First().Value;
                string indoctirnationCell3 = xDoc.Descendants("RecipeUltimateIndoctrinationCell").Descendants().First().Value;
                string morningstar1 = xDoc.Descendants("Recipemorningstar").Descendants().First().Value;
                string morningstar2 = xDoc.Descendants("RecipetoxicMorningstar").Descendants().First().Value;
                string morningstar3 = xDoc.Descendants("RecipebrutalMorningstar").Descendants().First().Value;
                string pulsefireRifle1 = xDoc.Descendants("RecipePRiflePoor").Descendants().First().Value;
                string pulsefireRifle2 = xDoc.Descendants("RecipePRifleGood").Descendants().First().Value;
                string pulsefireRifle3 = xDoc.Descendants("RecipePRifleExcellent").Descendants().First().Value;
                string sentryTurret1 = xDoc.Descendants("RecipesentryTurret").Descendants().First().Value;
                string sentryTurret2 = xDoc.Descendants("RecipeImprovedSentryTurret").Descendants().First().Value;
                string sentryTurret3 = xDoc.Descendants("RecipeMilitarySentryTurret").Descendants().First().Value;
                string vaccine1 = xDoc.Descendants("Recipevaccinepoor").Descendants().First().Value;
                string vaccine2 = xDoc.Descendants("Recipevaccinegood").Descendants().First().Value;
                string vaccine3 = xDoc.Descendants("Recipevaccineexcellent").Descendants().First().Value;

                //Load values into Form

                if (draftingTier2 == "5") { cbxDraftingTableTier2.Checked = true; }
                if (draftingTier3 == "5") { cbxDraftingTableTier3.Checked = true; }
                if (draftingTier4 == "1") { cbxDraftingTableTier4.Checked = true; }
                if (workbenchTier2 == "25") { cbxWorkbenchTier2.Checked = true; }
                if (workbenchTier3 == "25") { cbxWorkbenchTier3.Checked = true; }
                if (workbenchTier4 == "1") { cbxWorkbenchTier4.Checked = true; }

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

                if (indoctirnationCell1 == "True") { cbxRewardChurchQ1.Checked = true; }
                if (indoctirnationCell2 == "True") { cbxRewardChurchQ2.Checked = true; }
                if (indoctirnationCell3 == "True") { cbxRewardChurchQ3.Checked = true; }
                if (morningstar1 == "True") { cbxRewardCtkQ1.Checked = true; }
                if (morningstar2 == "True") { cbxRewardCtkQ2.Checked = true; }
                if (morningstar3 == "True") { cbxRewardCtkQ3.Checked = true; }
                if (pulsefireRifle1 == "True") { cbxRewardNewQ1.Checked = true; }
                if (pulsefireRifle2 == "True") { cbxRewardNewQ2.Checked = true; }
                if (pulsefireRifle3 == "True") { cbxRewardNewQ3.Checked = true; }
                if (sentryTurret1 == "True") { cbxRewardBlackQ1.Checked = true; }
                if (sentryTurret2 == "True") { cbxRewardBlackQ2.Checked = true; }
                if (sentryTurret3 == "True") { cbxRewardBlackQ3.Checked = true; }
                if (vaccine1 == "True") { cbxRewardLosQ1.Checked = true; }
                if (vaccine2 == "True") { cbxRewardLosQ2.Checked = true; }
                if (vaccine3 == "True") { cbxRewardLosQ3.Checked = true; }


                if (tabControlMain.SelectedIndex == 5)

                {

                }
            }


        }

        private void cbxSkillsCharacterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Read in User Skill Values into List
            tabControlSkills.Visible = true;
            btnMaxAllSkills.Visible=true;
            btnSaveCharacterSkills.Visible = true;

            var doc = XDocument.Load(ProcessFile.tempFilePath);

            List<NewSkillPoints> getNewSkillPoints = doc.Descendants("FamilyMembers").Descendants().Where(x => x.Name.LocalName.StartsWith("Member_"))

                .Select(p => new NewSkillPoints()
                {
                    FirstName = p.DescendantsAndSelf("firstName").FirstOrDefault().Value,
                    LastName = p.DescendantsAndSelf("lastName").FirstOrDefault().Value,
                    StrengthLevelNew = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Strength").Descendants("level").FirstOrDefault().Value),
                    DexterityLevelNew = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Dexterity").Descendants("level").FirstOrDefault().Value),
                    IntelligenceLevelNew = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Intelligence").Descendants("level").FirstOrDefault().Value),
                    CharismaLevelNew = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Charisma").Descendants("level").FirstOrDefault().Value),
                    PerceptionLevelNew = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Perception").Descendants("level").FirstOrDefault().Value),
                    FortitudeLevelNew = Convert.ToInt32(p.Descendants("BaseStats").Descendants("Fortitude").Descendants("level").FirstOrDefault().Value),

                }).ToList();

            

            //Get available Points

            string selectedName = Convert.ToString(cbxSkillsCharacterSelect.SelectedItem);
            List<GetSkillPoints> getOldSkillValues = new List<GetSkillPoints>(GetSkillPoints._getSkillPoints);

            foreach (var point in getNewSkillPoints)
            {
                if (selectedName == point.FirstName + " " + point.LastName)
                {
                    foreach (var oldPoint in getOldSkillValues)
                    {
                        if (selectedName == oldPoint.FirstName + " " + oldPoint.LastName)
                        {
                            lblPointsAvailableStrValue.Text = (point.StrengthLevelNew - oldPoint.StrengthLevelBefore).ToString();
                            lblPointsAvailableDexValue.Text = (point.DexterityLevelNew - oldPoint.DexterityLevelBefore).ToString();
                            lblPointsAvailableIntValue.Text = (point.IntelligenceLevelNew - oldPoint.IntelligenceLevelBefore).ToString();
                            lblPointsAvailableChaValue.Text = (point.CharismaLevelNew - oldPoint.CharismaLevelBefore).ToString();
                            lblPointsAvailablePerValue.Text = (point.PerceptionLevelNew - oldPoint.PerceptionLevelBefore).ToString();
                            lblPointsAvailableForValue.Text = (point.FortitudeLevelNew - oldPoint.FortitudeLevelBefore).ToString();

                        }
                    }
                }
            }
            lblPointsAvailableStrValue.Refresh();
            lblPointsAvailableDexValue.Refresh();
            lblPointsAvailableIntValue.Refresh();
            lblPointsAvailableChaValue.Refresh();
            lblPointsAvailablePerValue.Refresh();
            lblPointsAvailableForValue.Refresh();


            //Reset the Skills each time a character is chosen
            var skillNum = new[]
            {
                new {Nr = 14, Skill = "Str"},
                new {Nr = 12, Skill = "Dex"},
                new {Nr = 17, Skill = "Int"},
                new {Nr = 13, Skill = "Cha"},
                new {Nr = 17, Skill = "Per"},
                new {Nr = 20, Skill = "For"}

            }.ToList();
            foreach (var num in skillNum)
            {
                for (int i = 1; i <= num.Nr; i++)
                {
                    var imageBox = tabControlSkills.SelectedTab.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "pbx" + num.Skill + "SkillLevel" + i.ToString());
                    if (imageBox != null)
                    {
                        imageBox.AccessibleName = "0";
                        if (imageBox.Tag.ToString() == "0")
                        {
                            imageBox.Image = skillLevelIcons.Images[0];
                        }
                        else if (imageBox.Tag.ToString() == "1")
                        {
                            imageBox.Image = skillLevelIcons.Images[1];
                        }
                        else if (imageBox.Tag.ToString() == "2")
                        {
                            imageBox.Image = skillLevelIcons.Images[2];
                        }
                    }
                }
            }

            LoadSkills();
        }


        private void LoadSkills()
        {
            var firstName = cbxSkillsCharacterSelect.Text.ToString();
            var lastName = "";

            List<GetFamilyMemberData> familyMembers = ProcessData.FamilyMembersList();

            foreach (GetFamilyMemberData member in familyMembers)
            {
                if (member.FirstName + " " + member.LastName == firstName)
                {
                    firstName = member.FirstName;
                    lastName = member.LastName;
                }
            }

            lblSkillsCharacterName.Text = firstName + " " + lastName;
            var xDoc = XDocument.Load(ProcessFile.tempFilePath);

            //Get MemberNumber

            ProcessData.skillMember = xDoc.Descendants("FamilyMembers").Descendants("firstName").Where(p => p.Value == firstName && p.ElementsAfterSelf("lastName").FirstOrDefault().Value == lastName).Ancestors().First().Name.ToString();

            //Load in Available Points

            List<GetFamilyMemberData> getAvailablePoints = new List<GetFamilyMemberData>();

            foreach (var member in getAvailablePoints)
            {
                lblPointsAvailableStrValue.Text = Convert.ToString(member.StrengthLevel);
            }

            int strValue = Convert.ToInt32(lblPointsAvailableStrValue.Text);
            int dexValue = Convert.ToInt32(lblPointsAvailableDexValue.Text);
            int intValue = Convert.ToInt32(lblPointsAvailableIntValue.Text);
            int chaValue = Convert.ToInt32(lblPointsAvailableChaValue.Text);
            int perValue = Convert.ToInt32(lblPointsAvailablePerValue.Text);
            int forValue = Convert.ToInt32(lblPointsAvailableForValue.Text);

            //Load in Availabe Points
            strValue += Convert.ToInt32(xDoc.Descendants("FamilyMembers").Elements(ProcessData.skillMember).Descendants("Strength").Descendants("ProfessionPoints").First().Value);
            dexValue += Convert.ToInt32(xDoc.Descendants("FamilyMembers").Elements(ProcessData.skillMember).Descendants("Dexterity").Descendants("ProfessionPoints").First().Value);
            intValue += Convert.ToInt32(xDoc.Descendants("FamilyMembers").Elements(ProcessData.skillMember).Descendants("Intelligence").Descendants("ProfessionPoints").First().Value);
            chaValue += Convert.ToInt32(xDoc.Descendants("FamilyMembers").Elements(ProcessData.skillMember).Descendants("Charisma").Descendants("ProfessionPoints").First().Value);
            perValue += Convert.ToInt32(xDoc.Descendants("FamilyMembers").Elements(ProcessData.skillMember).Descendants("Perception").Descendants("ProfessionPoints").First().Value);
            forValue += Convert.ToInt32(xDoc.Descendants("FamilyMembers").Elements(ProcessData.skillMember).Descendants("Fortitude").Descendants("ProfessionPoints").First().Value);

            //Get skill amount
            string skillType = "";
            if (tabControlSkills.SelectedIndex == 0)
            {
                skillType = "strength";
                ProcessData.skillName = "Str";
            }
            else if (tabControlSkills.SelectedIndex == 1)
            {
                skillType = "dexterity";
                ProcessData.skillName = "Dex";
            }
            if (tabControlSkills.SelectedIndex == 2)
            {
                skillType = "intelligence";
                ProcessData.skillName = "Int";
            }
            else if (tabControlSkills.SelectedIndex == 3)
            {
                skillType = "charisma";
                ProcessData.skillName = "Cha";
            }
            else if (tabControlSkills.SelectedIndex == 4)
            {
                skillType = "perception";
                ProcessData.skillName = "Per";
            }
            else if (tabControlSkills.SelectedIndex == 5)
            {
                skillType = "fortitude";
                ProcessData.skillName = "For";
            }

            var skillsAmount = xDoc.Descendants("FamilyMembers").Elements(ProcessData.skillMember).Descendants("Profession").Descendants(skillType + "Skills").FirstOrDefault().Attribute("size").Value;


            //var getSkillInput = new GetFamilyMemberData();


            //Get All Members
            var members = xDoc.Descendants("FamilyMembers").Elements().Where(p => p.Name.LocalName.StartsWith("Member_"));

            //Load in skills
            //Strength
            if (skillType == "strength")
            {
                skillPageStr.Select();

                for (int i = 0; i < Convert.ToInt32(skillsAmount); i++)
                {
                    List<Skills> strSkills = xDoc
                        .Descendants("FamilyMembers")
                        .Elements(ProcessData.skillMember)
                        .Descendants("Profession")
                        .Descendants(skillType + "Skills")
                        .Descendants("i" + i)
                        .Select(q => new Skills()
                        {
                            SkillKey = q.Element("skillKey").Value,
                            SkillLevel = q.Element("skillLevel").Value
                        })
                        .ToList();
                    foreach (var skill in strSkills)
                    {
                        for (int j = 1; j <= 14; j++)
                        {
                            var imageName = skillPageStr.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "pbxStrSkillLevel" + j.ToString());

                            if (imageName.AccessibleDescription == skill.SkillKey)
                            {
                                if (imageName.Tag.ToString() == "0")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 2];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "1")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 3];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "2")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 5];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                            }
                        }
                    }
                    Skills._strSkillList = strSkills;
                }
            }
            else if (skillType == "dexterity")
            {
                skillPageDex.Select();
                for (int i = 0; i < Convert.ToInt32(skillsAmount); i++)
                {
                    List<Skills> dexSkills = xDoc
                        .Descendants("FamilyMembers")
                        .Elements(ProcessData.skillMember)
                        .Descendants("Profession")
                        .Descendants(skillType + "Skills")
                        .Descendants("i" + i)
                        .Select(q => new Skills()
                        {
                            SkillKey = q.Element("skillKey").Value,
                            SkillLevel = q.Element("skillLevel").Value
                        })
                        .ToList();
                    foreach (var skill in dexSkills)
                    {
                        for (int j = 1; j <= 12; j++)
                        {
                            var imageName = skillPageDex.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "pbxDexSkillLevel" + j.ToString());

                            if (imageName.AccessibleDescription == skill.SkillKey)
                            {
                                if (imageName.Tag.ToString() == "0")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 2];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "1")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 3];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "2")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 5];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                            }
                        }
                    }
                    Skills._dexSkillList = dexSkills;
                }
            }
            else if (skillType == "intelligence")
            {
                skillPageInt.Select();
                for (int i = 0; i < Convert.ToInt32(skillsAmount); i++)
                {
                    List<Skills> intSkills = xDoc
                        .Descendants("FamilyMembers")
                        .Elements(ProcessData.skillMember)
                        .Descendants("Profession")
                        .Descendants(skillType + "Skills")
                        .Descendants("i" + i)
                        .Select(q => new Skills()
                        {
                            SkillKey = q.Element("skillKey").Value,
                            SkillLevel = q.Element("skillLevel").Value
                        })
                        .ToList();
                    foreach (var skill in intSkills)
                    {
                        for (int j = 1; j <= 17; j++)
                        {
                            var imageName = skillPageInt.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "pbxIntSkillLevel" + j.ToString());

                            if (imageName.AccessibleDescription == skill.SkillKey)
                            {
                                if (imageName.Tag.ToString() == "0")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 2];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "1")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 3];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "2")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 5];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                            }
                        }
                    }
                    Skills._intSkillList = intSkills;
                }
            }
            else if (skillType == "charisma")
            {
                skillPageCha.Select();
                for (int i = 0; i < Convert.ToInt32(skillsAmount); i++)
                {
                    List<Skills> chaSkills = xDoc
                        .Descendants("FamilyMembers")
                        .Elements(ProcessData.skillMember)
                        .Descendants("Profession")
                        .Descendants(skillType + "Skills")
                        .Descendants("i" + i)
                        .Select(q => new Skills()
                        {
                            SkillKey = q.Element("skillKey").Value,
                            SkillLevel = q.Element("skillLevel").Value
                        })
                        .ToList();
                    foreach (var skill in chaSkills)
                    {
                        for (int j = 1; j <= 13; j++)
                        {
                            var imageName = skillPageCha.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "pbxChaSkillLevel" + j.ToString());

                            if (imageName.AccessibleDescription == skill.SkillKey)
                            {
                                if (imageName.Tag.ToString() == "0")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 2];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "1")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 3];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "2")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 5];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                            }
                        }
                    }
                    Skills._chaSkillList = chaSkills;
                }
            }
            else if (skillType == "perception")
            {
                skillPagePer.Select();
                for (int i = 0; i < Convert.ToInt32(skillsAmount); i++)
                {
                    List<Skills> perSkills = xDoc
                        .Descendants("FamilyMembers")
                        .Elements(ProcessData.skillMember)
                        .Descendants("Profession")
                        .Descendants(skillType + "Skills")
                        .Descendants("i" + i)
                        .Select(q => new Skills()
                        {
                            SkillKey = q.Element("skillKey").Value,
                            SkillLevel = q.Element("skillLevel").Value
                        })
                        .ToList();
                    foreach (var skill in perSkills)
                    {
                        for (int j = 1; j <= 17; j++)
                        {
                            var imageName = skillPagePer.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "pbxPerSkillLevel" + j.ToString());

                            if (imageName.AccessibleDescription == skill.SkillKey)
                            {
                                if (imageName.Tag.ToString() == "0")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 2];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "1")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 3];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "2")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 5];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                            }
                        }
                    }
                    Skills._perSkillList = perSkills;
                }
            }
            else if (skillType == "fortitude")
            {
                skillPageFor.Select();
                for (int i = 0; i < Convert.ToInt32(skillsAmount); i++)
                {
                    List<Skills> forSkills = xDoc
                        .Descendants("FamilyMembers")
                        .Elements(ProcessData.skillMember)
                        .Descendants("Profession")
                        .Descendants(skillType + "Skills")
                        .Descendants("i" + i)
                        .Select(q => new Skills()
                        {
                            SkillKey = q.Element("skillKey").Value,
                            SkillLevel = q.Element("skillLevel").Value
                        })
                        .ToList();
                    foreach (var skill in forSkills)
                    {
                        for (int j = 1; j <= 20; j++)
                        {
                            var imageName = skillPageFor.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "pbxForSkillLevel" + j.ToString());

                            if (imageName.AccessibleDescription == skill.SkillKey)
                            {
                                if (imageName.Tag.ToString() == "0")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 2];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "1")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 3];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                                else if (imageName.Tag.ToString() == "2")
                                {
                                    imageName.Image = skillLevelIcons.Images[Convert.ToInt32(skill.SkillLevel) + 5];
                                    imageName.AccessibleName = skill.SkillLevel;
                                }
                            }
                        }
                    }
                    Skills._forSkillList = forSkills;
                }
            }
        }

        public void GetSkillKey()
        {

            //Load in Images

            var skillList = new[]
            {
                new { Number =  14, Name = "Str"},
                new { Number =  12, Name = "Dex"},
                new { Number =  17, Name = "Int"},
                new { Number =  13, Name = "Cha"},
                new { Number =  17, Name = "Per"},
                new { Number =  20, Name = "For"}

            }.ToList();
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
            MessageBox.Show("Map revealed succesfully." + "\n" + "--------------------------------" + "\n" + "\n" + "\n" + "***** IMPORTANT *****" + "\n" + "You still need to save the Savegame!");


        }

        private void btnSaveUnlocks_Click(object sender, EventArgs e)
        {
            var xDoc = XDocument.Load(ProcessFile.tempFilePath);

            if (cbxDraftingTableTier2.Checked == true)
            {
                xDoc.Descendants("FactionAchievement_Building101").Descendants().First().Value = "5";
                xDoc.Descendants("BuiltBed").First().Value = "True";
                xDoc.Descendants("BuiltToilet").First().Value = "True";
                xDoc.Descendants("BuiltShower").First().Value = "True";
                xDoc.Descendants("BuiltRoom").First().Value = "True";
                xDoc.Descendants("BuiltStove").First().Value = "True";
            }
            if (cbxDraftingTableTier3.Checked == true) { xDoc.Descendants("FactionAchievement_SkilledBuilder").Descendants().First().Value = "5"; }
            if (cbxDraftingTableTier4.Checked == true) { xDoc.Descendants("FactionAchievement_ExpertBuilder").Descendants().First().Value = "1"; }
            if (cbxDraftingTableTier2.Checked == true) { xDoc.Descendants("FactionAchievement_Engineering101").Descendants().First().Value = "25"; }
            if (cbxDraftingTableTier3.Checked == true) { xDoc.Descendants("FactionAchievement_SkilledEngineer").Descendants().First().Value = "25"; }
            if (cbxDraftingTableTier4.Checked == true) { xDoc.Descendants("FactionAchievement_ExpertEngineer").Descendants().First().Value = "1"; }

            if (cbxBpBatteryBank.Checked == true) { xDoc.Descendants("RecipebatteryBank").Descendants().First().Value = "True"; }
            if (cbxBpFlashbangMine.Checked == true) { xDoc.Descendants("RecipeflashbangMine").Descendants().First().Value = "True"; }
            if (cbxBpIndustrialGenerator.Checked == true) { xDoc.Descendants("RecipeindustrialGenerator").Descendants().First().Value = "True"; }
            if (cbxBpMedicalBed.Checked == true) { xDoc.Descendants("RecipemedicalBed").Descendants().First().Value = "True"; }
            if (cbxBpGasMine.Checked == true) { xDoc.Descendants("RecipegasMine").Descendants().First().Value = "True"; }
            if (cbxBpEfficientPlanter.Checked == true) { xDoc.Descendants("RecipeEfficientPlanter").Descendants().First().Value = "True"; }
            if (cbxBpQuantumBattery.Checked == true) { xDoc.Descendants("RecipequantumBattery").Descendants().First().Value = "True"; }
            if (cbxBpDefibrilator.Checked == true) { xDoc.Descendants("Recipedefib").Descendants().First().Value = "True"; }
            if (cbxBpElectricityTrap.Checked == true) { xDoc.Descendants("RecipeelectricityTrap").Descendants().First().Value = "True"; }
            if (cbxBpLaboratory.Checked == true) { xDoc.Descendants("Recipelaboratory").Descendants().First().Value = "True"; }
            if (cbxBpRecycler.Checked == true) { xDoc.Descendants("Reciperecycler").Descendants().First().Value = "True"; }
            if (cbxBpSolarPanel.Checked == true) { xDoc.Descendants("RecipesolarPanel").Descendants().First().Value = "True"; }

            if (cbxDrugsAlcohol.Checked == true) { xDoc.Descendants("RecipeAlcohol").Descendants().First().Value = "True"; }
            if (cbxDrugsCrunk.Checked == true) { xDoc.Descendants("RecipeCrunk").Descendants().First().Value = "True"; }
            if (cbxDrugsFeederral.Checked == true) { xDoc.Descendants("RecipeFeederral").Descendants().First().Value = "True"; }
            if (cbxDrugsPython.Checked == true) { xDoc.Descendants("RecipePython").Descendants().First().Value = "True"; }
            if (cbxDrugsSigma.Checked == true) { xDoc.Descendants("RecipeSigma").Descendants().First().Value = "True"; }
            if (cbxDrugsSnodge.Checked == true) { xDoc.Descendants("RecipeSnodge").Descendants().First().Value = "True"; }
            if (cbxDrugsTrankwill.Checked == true) { xDoc.Descendants("RecipeTrankwill").Descendants().First().Value = "True"; }

            if (cbxOtherTrading.Checked == true) { xDoc.Descendants("FactionAchievement_InsiderTrading").Descendants().First().Value = "1"; }
            if (cbxOtherGunCrafting.Checked == true) { xDoc.Descendants("FactionAchievement_GunCrafting").Descendants().First().Value = "1"; }
            if (cbxOtherCarPartsCrafting.Checked == true) { xDoc.Descendants("FactionAchievement_Mechanic").Descendants().First().Value = "1"; }
            if (cbxMedicineCrafting.Checked == true) { xDoc.Descendants("FactionAchievement_Chemistry").Descendants().First().Value = "1"; }
            if (cbxDamageAmplifier.Checked == true) { xDoc.Descendants("RecipedamageAmplifier").First().Value = "True"; }

            if (cbxRewardChurchQ1.Checked == true) { xDoc.Descendants("RecipeIndoctrinationCell").Descendants().First().Value = "True"; }
            if (cbxRewardChurchQ2.Checked == true) { xDoc.Descendants("RecipeAdvancedIndoctrinationCell").Descendants().First().Value = "True"; }
            if (cbxRewardChurchQ3.Checked == true) { xDoc.Descendants("RecipeUltimateIndoctrinationCell").Descendants().First().Value = "True"; }
            if (cbxRewardCtkQ1.Checked == true) { xDoc.Descendants("Recipemorningstar").Descendants().First().Value = "True"; }
            if (cbxRewardCtkQ2.Checked == true) { xDoc.Descendants("RecipetoxicMorningstar").Descendants().First().Value = "True"; }
            if (cbxRewardCtkQ3.Checked == true) { xDoc.Descendants("RecipebrutalMorningstar").Descendants().First().Value = "True"; }
            if (cbxRewardNewQ1.Checked == true) { xDoc.Descendants("RecipePRiflePoor").Descendants().First().Value = "True"; xDoc.Descendants("RecipeantimatterCellRecipe").Descendants().First().Value = "True"; }
            if (cbxRewardNewQ2.Checked == true) { xDoc.Descendants("RecipePRifleGood").Descendants().First().Value = "True"; xDoc.Descendants("RecipeantimatterCellRecipe").Descendants().First().Value = "True"; }
            if (cbxRewardNewQ3.Checked == true) { xDoc.Descendants("RecipePRifleExcellent").Descendants().First().Value = "True"; xDoc.Descendants("RecipeantimatterCellRecipe").Descendants().First().Value = "True"; }
            if (cbxRewardBlackQ1.Checked == true) { xDoc.Descendants("RecipesentryTurret").Descendants().First().Value = "True"; xDoc.Descendants("RecipesentryTurretAmmo").Descendants().First().Value = "True"; }
            if (cbxRewardBlackQ2.Checked == true) { xDoc.Descendants("RecipeImprovedSentryTurret").Descendants().First().Value = "True"; xDoc.Descendants("RecipesentryTurretAmmo").Descendants().First().Value = "True"; }
            if (cbxRewardBlackQ3.Checked == true) { xDoc.Descendants("RecipeMilitarySentryTurret").Descendants().First().Value = "True"; xDoc.Descendants("RecipesentryTurretAmmo").Descendants().First().Value = "True"; }
            if (cbxRewardLosQ1.Checked == true) { xDoc.Descendants("Recipevaccinepoor").Descendants().First().Value = "True"; }
            if (cbxRewardLosQ2.Checked == true) { xDoc.Descendants("Recipevaccinegood").Descendants().First().Value = "True"; }
            if (cbxRewardLosQ3.Checked == true) { xDoc.Descendants("Recipevaccineexcellent").Descendants().First().Value = "True"; }
            if (cbxRewardOldQ1.Checked == true) { /*toADD*/ }
            if (cbxRewardOldQ2.Checked == true) { /*toADD*/ }
            if (cbxRewardOldQ3.Checked == true) { /*toADD*/ }

            xDoc.Save(ProcessFile.tempFilePath);
            MessageBox.Show("Unlocks saved successfully." + "\n" + "--------------------------------" + "\n" + "\n" + "\n" + "***** IMPORTANT *****" + "\n" + "You still need to save the Savegame!");


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

        private void tabControlSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSkills();
        }

        private void btnSaveCharacterSkills_Click(object sender, EventArgs e)
        {
            var xDoc = XDocument.Load(ProcessFile.tempFilePath);
            var tabPagesList = new List<TabPage> { skillPageStr, skillPageDex, skillPageInt, skillPageCha, skillPagePer, skillPageFor };
            List<PictureBox> skillList = new List<PictureBox>();
            List<Skills> newSkillList = new List<Skills>();
            foreach (var tabPage in tabPagesList)
            {
                skillList = tabPage.Controls.OfType<PictureBox>()
                   .Where(p => p.Name.Contains("SkillLevel"))
                   .ToList();
                foreach (var pictureBox in skillList)
                {
                    newSkillList.Add(new Skills { Type = tabPage.Name, SkillKey = pictureBox.AccessibleDescription, SkillLevel = pictureBox.AccessibleName });
                }
            }

            List<GetFamilyMemberData> getNames =
                xDoc.Descendants("FamilyMembers").Descendants().Where(x => x.Name.LocalName.StartsWith("Member_"))
                    .Select(p => new GetFamilyMemberData()
                    {
                        FirstName = p.DescendantsAndSelf("firstName").FirstOrDefault().Value,
                        LastName = p.DescendantsAndSelf("lastName").FirstOrDefault().Value

                    }).ToList();
            string firstName = "";
            string lastName = "";
            foreach (var name in getNames)
            {
                if(name.FirstName + " " + name.LastName == cbxSkillsCharacterSelect.SelectedItem.ToString())
                {
                    firstName = name.FirstName;
                    lastName = name.LastName;
                }
            }          

            //string firstName = "";
            
            int skillAmount = 0;

            var memberNr = xDoc.Descendants("FamilyMembers").Descendants().Where(x => x.Value.Contains(firstName) && x.Value.Contains(lastName)).AncestorsAndSelf().FirstOrDefault().Name;

            //Save Strength Skills

            List<Skills> strSkillList = new List<Skills>(newSkillList)
             .Where(x => x.Type
             .Contains("Str") && Convert.ToInt32(x.SkillLevel) > 0)
             .ToList();

            int skillsAdded = 0;
            int attributeValue = Convert.ToInt32(xDoc.Descendants(memberNr).Descendants("Profession").Descendants("strengthSkills").First().Attribute("size").Value);
            foreach (var skill in strSkillList)
            {
                skillAmount = strSkillList.Count();
                if (attributeValue > 0)
                {  
                    for (int i = 0; i < attributeValue; i++)
                    {
                        xDoc.Descendants(memberNr).Descendants("strengthSkills").Descendants("i"+ i).Remove();
                    }
                    attributeValue = 0;                    
                }
                if(skillsAdded == 0)
                {
                    xDoc.Descendants(memberNr).Descendants("StrengthSkills").Descendants("strengthSkills").FirstOrDefault().Add(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
                else
                {
                    xDoc.Descendants(memberNr).Descendants("strengthSkills").Descendants("i" + (skillsAdded - 1)).FirstOrDefault().AddAfterSelf(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
            }
            xDoc.Descendants(memberNr).Descendants("Profession").Descendants("strengthSkills").First().Attribute("size").Value = skillsAdded.ToString();
            //save Available Points           
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Strength").Descendants("ProfessionPoints").FirstOrDefault().Value = lblPointsAvailableStrValue.Text;
            //Add Points Spent Tiers
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Strength").Descendants("pointsSpent_tierOne").FirstOrDefault().Value = skillAmount.ToString();

            //Save Dexterity Skills
            List<Skills> dexSkillList = new List<Skills>(newSkillList)
                .Where(x => x.Type
                .Contains("Dex") && Convert.ToInt32(x.SkillLevel) > 0)
                .ToList();

            skillsAdded = 0;
            attributeValue = Convert.ToInt32(xDoc.Descendants(memberNr).Descendants("Profession").Descendants("dexteritySkills").First().Attribute("size").Value);
            foreach (var skill in dexSkillList)
            {
                skillAmount = dexSkillList.Count();
                if (attributeValue > 0)
                {
                    for (int i = 0; i < attributeValue; i++)
                    {
                        xDoc.Descendants(memberNr).Descendants("dexteritySkills").Descendants("i" + i).Remove();
                    }
                    attributeValue = 0;
                }
                if (skillsAdded == 0)
                {
                    xDoc.Descendants(memberNr).Descendants("DexteritySkills").Descendants("dexteritySkills").FirstOrDefault().Add(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
                else
                {
                    xDoc.Descendants(memberNr).Descendants("dexteritySkills").Descendants("i" + (skillsAdded - 1)).FirstOrDefault().AddAfterSelf(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
            }
            xDoc.Descendants(memberNr).Descendants("Profession").Descendants("dexteritySkills").First().Attribute("size").Value = skillsAdded.ToString();
            //save Available Points           
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Dexterity").Descendants("ProfessionPoints").FirstOrDefault().Value = lblPointsAvailableDexValue.Text;
            //Add Points Spent Tiers
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Dexterity").Descendants("pointsSpent_tierOne").FirstOrDefault().Value = skillAmount.ToString();

            //Save Intelligence Skills
            List<Skills> intSkillList = new List<Skills>(newSkillList)
                .Where(x => x.Type
                .Contains("Int") && Convert.ToInt32(x.SkillLevel) > 0)
                .ToList();

            skillsAdded = 0;
            attributeValue = Convert.ToInt32(xDoc.Descendants(memberNr).Descendants("Profession").Descendants("intelligenceSkills").First().Attribute("size").Value);
            foreach (var skill in intSkillList)
            {
                skillAmount = intSkillList.Count();
                if (attributeValue > 0)
                {
                    for (int i = 0; i < attributeValue; i++)
                    {
                        xDoc.Descendants(memberNr).Descendants("intelligenceSkills").Descendants("i" + i).Remove();
                    }
                    attributeValue = 0;
                }
                if (skillsAdded == 0)
                {
                    xDoc.Descendants(memberNr).Descendants("IntelligenceSkills").Descendants("intelligenceSkills").FirstOrDefault().Add(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
                else
                {
                    xDoc.Descendants(memberNr).Descendants("intelligenceSkills").Descendants("i" + (skillsAdded - 1)).FirstOrDefault().AddAfterSelf(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
            }
            xDoc.Descendants(memberNr).Descendants("Profession").Descendants("intelligenceSkills").First().Attribute("size").Value = skillsAdded.ToString();
            //save Available Points           
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Intelligence").Descendants("ProfessionPoints").FirstOrDefault().Value = lblPointsAvailableIntValue.Text;
            //Add Points Spent Tiers
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Intelligence").Descendants("pointsSpent_tierOne").FirstOrDefault().Value = skillAmount.ToString();

            //Save Charisma Skills
            List<Skills> chaSkillList = new List<Skills>(newSkillList)
                .Where(x => x.Type
                .Contains("Cha") && Convert.ToInt32(x.SkillLevel) > 0)
                .ToList();

            skillsAdded = 0;
            attributeValue = Convert.ToInt32(xDoc.Descendants(memberNr).Descendants("Profession").Descendants("charismaSkills").First().Attribute("size").Value);
            foreach (var skill in chaSkillList)
            {
                skillAmount = chaSkillList.Count();
                if (attributeValue > 0)
                {
                    for (int i = 0; i < attributeValue; i++)
                    {
                        xDoc.Descendants(memberNr).Descendants("charismaSkills").Descendants("i" + i).Remove();
                    }
                    attributeValue = 0;
                }
                if (skillsAdded == 0)
                {
                    xDoc.Descendants(memberNr).Descendants("CharismaSkills").Descendants("charismaSkills").FirstOrDefault().Add(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
                else
                {
                    xDoc.Descendants(memberNr).Descendants("charismaSkills").Descendants("i" + (skillsAdded - 1)).FirstOrDefault().AddAfterSelf(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
            }
            xDoc.Descendants(memberNr).Descendants("Profession").Descendants("charismaSkills").First().Attribute("size").Value = skillsAdded.ToString();
            //save Available Points           
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Charisma").Descendants("ProfessionPoints").FirstOrDefault().Value = lblPointsAvailableChaValue.Text;
            //Add Points Spent Tiers
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Charisma").Descendants("pointsSpent_tierOne").FirstOrDefault().Value = skillAmount.ToString();

            //Save Perception Skills
            List<Skills> perSkillList = new List<Skills>(newSkillList)
                .Where(x => x.Type
                .Contains("Per") && Convert.ToInt32(x.SkillLevel) > 0)
                .ToList();

            skillsAdded = 0;
            attributeValue = Convert.ToInt32(xDoc.Descendants(memberNr).Descendants("Profession").Descendants("perceptionSkills").First().Attribute("size").Value);
            foreach (var skill in perSkillList)
            {
                skillAmount = perSkillList.Count();
                if (attributeValue > 0)
                {
                    for (int i = 0; i < attributeValue; i++)
                    {
                        xDoc.Descendants(memberNr).Descendants("perceptionSkills").Descendants("i" + i).Remove();
                    }
                    attributeValue = 0;
                }
                if (skillsAdded == 0)
                {
                    xDoc.Descendants(memberNr).Descendants("PerceptionSkills").Descendants("perceptionSkills").FirstOrDefault().Add(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
                else
                {
                    xDoc.Descendants(memberNr).Descendants("perceptionSkills").Descendants("i" + (skillsAdded - 1)).FirstOrDefault().AddAfterSelf(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
            }            
            xDoc.Descendants(memberNr).Descendants("Profession").Descendants("perceptionSkills").First().Attribute("size").Value = skillsAdded.ToString();
            //save Available Points           
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Perception").Descendants("ProfessionPoints").FirstOrDefault().Value = lblPointsAvailablePerValue.Text;
            //Add Points Spent Tiers
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Perception").Descendants("pointsSpent_tierOne").FirstOrDefault().Value = skillAmount.ToString();
            //Save Fortitude Skills
            List<Skills> forSkillList = new List<Skills>(newSkillList)
                .Where(x => x.Type
                .Contains("For") && Convert.ToInt32(x.SkillLevel) > 0)
                .ToList();

            skillsAdded = 0;
            attributeValue = Convert.ToInt32(xDoc.Descendants(memberNr).Descendants("Profession").Descendants("fortitudeSkills").First().Attribute("size").Value);
            foreach (var skill in forSkillList)
            {
                skillAmount = forSkillList.Count();
                if (attributeValue > 0)
                {
                    for (int i = 0; i < attributeValue; i++)
                    {
                        xDoc.Descendants(memberNr).Descendants("fortitudeSkills").Descendants("i" + i).Remove();
                    }
                    attributeValue = 0;
                }
                if (skillsAdded == 0)
                {
                    xDoc.Descendants(memberNr).Descendants("FortitudeSkills").Descendants("fortitudeSkills").FirstOrDefault().Add(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
                else
                {
                    xDoc.Descendants(memberNr).Descendants("fortitudeSkills").Descendants("i" + (skillsAdded - 1)).FirstOrDefault().AddAfterSelf(
                        new XElement("i" + skillsAdded,
                        new XElement("skillKey", skill.SkillKey),
                        new XElement("skillLevel", skill.SkillLevel),
                        new XElement("accuracyLevel", "0"),
                        new XElement("damageLevel", "0"),
                        new XElement("staminaLevel", "0"),
                        new XElement("chanceLevel", "0")
                        ));
                    skillsAdded++;
                }
            }            
            xDoc.Descendants(memberNr).Descendants("Profession").Descendants("fortitudeSkills").First().Attribute("size").Value = skillsAdded.ToString();
            //save Available Points           
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Fortitude").Descendants("ProfessionPoints").FirstOrDefault().Value = lblPointsAvailableForValue.Text;
            //Add Points Spent Tiers
            xDoc.Descendants(memberNr).Descendants("BaseStats").Descendants("Fortitude").Descendants("pointsSpent_tierOne").FirstOrDefault().Value = skillAmount.ToString();

            xDoc.Save(ProcessFile.tempFilePath);

            if (ProcessData.ignore == false)
            {
                MessageBox.Show("Character skills saved successfully." + "\n" + "--------------------------------" + "\n" + "\n" + "\n" + "***** IMPORTANT *****" + "\n" + "You still need to save the Savegame!");                
            }
            ProcessData.ignore = false;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var xDoc = XDocument.Load(ProcessFile.tempFilePath);

            var tabPagesList = new List<TabPage> { skillPageStr, skillPageDex, skillPageInt, skillPageCha, skillPagePer, skillPageFor };

            List<PictureBox> skillList = new List<PictureBox>();
            foreach (var tabPage in tabPagesList)
            {
                skillList = tabPage.Controls.OfType<PictureBox>()
                   .Where(p => p.Name.Contains("Skill") && !p.Name.Contains("Level"))
                   .ToList();
                foreach (var pictureBox in skillList)
                {
                    pictureBox.MouseClick -= PictureBoxClick;
                }
            }

            Application.Exit();
        }

        private void btnMaxAllSkills_Click(object sender, EventArgs e)
        {
            var tabPagesList = new List<TabPage> { skillPageStr, skillPageDex, skillPageInt, skillPageCha, skillPagePer, skillPageFor };
            List<PictureBox>skillList = new List<PictureBox>();
            List<Skills> newSkillList = new List<Skills>();
            foreach (var tabPage in tabPagesList)
            {
                skillList = tabPage.Controls.OfType<PictureBox>()
                   .Where(p => p.Name.Contains("SkillLevel"))
                   .ToList();
                foreach (var pictureBox in skillList)
                {
                    var name = pictureBox.Name;
                   if(pictureBox.Tag.ToString() == "0")
                    {
                        
                        pictureBox.AccessibleName = "1";
                        pictureBox.Image = skillLevelIcons.Images[3];                      

                    }
                    else if (pictureBox.Tag.ToString() == "1")
                    {
                        pictureBox.AccessibleName = "2";
                        pictureBox.Image = skillLevelIcons.Images[5];

                    }
                    else if (pictureBox.Tag.ToString() == "2")
                    {
                        pictureBox.AccessibleName = "3";
                        pictureBox.Image = skillLevelIcons.Images[8];
                    }
                }
            }
            ProcessData.ignore = true;
            lblPointsAvailableStrValue.Text = "0";
            lblPointsAvailableDexValue.Text = "0";
            lblPointsAvailableIntValue.Text = "0";
            lblPointsAvailableChaValue.Text = "0";
            lblPointsAvailablePerValue.Text = "0";
            lblPointsAvailableForValue.Text = "0";
            btnSaveCharacterSkills.PerformClick();  
            



        }
    }
}



