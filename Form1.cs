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
        

        public string decodedData = string.Empty;

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openSaveFile = new OpenFileDialog();
            openSaveFile.Filter = "Sheltered 2 Savegame|*.dat";
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = ProcessFile.fileName;
            String Filename = "";
            DialogResult saveResult = saveFileDialog.ShowDialog();
            if (saveResult == DialogResult.OK)
            {

                Filename = saveFileDialog.FileName;

                try
                {
                    StreamWriter sw = new StreamWriter(ProcessFile.tempFilePath);
                    sw.Write(Output.Text);
                    sw.Close();
                    processFile.SaveFile(saveFileDialog.FileName);
                    MessageBox.Show("File saved succesfully!", "File Saved");

                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error saving File: " + ioe.Message);
                }
                {

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

            //List<FamilyMembers> familyMembers = ProcessData.FamilyMembersList();

            //foreach (FamilyMembers member in familyMembers)
            //{
            //    Output.AppendText(member.ToString() + "\n");

            //}

            List<BaseStats> baseStats = ProcessData.BaseStatsList();
            
            foreach (BaseStats stat in baseStats)
            {
                    Output.AppendText(stat.ToString()+"\n");
            }
        }

        


        private void cbxCharacterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cbxCharacterSelect.Items[cbxCharacterSelect.SelectedIndex];

            txbFirstname.Text = selectedItem.ToString();
            ProcessData.memberFN = selectedItem.ToString();

            //List<string>MemberList = FamilyMembers.concat(BaseStats) //////////////

            List<FamilyMembers> familyMembers = ProcessData.FamilyMembersList();
            foreach (FamilyMembers member in familyMembers)
            {
                if (member.FirstName == txbFirstname.Text) 
                {
                    txbLastname.Text = member.LastName;
                    txbHealth.Text = Convert.ToString (member.Health);
                    txbMaxHealth.Text = Convert.ToString (member.MaxHealth);

                } 
            }
            
            //List<BaseStats> baseStats = ProcessData.BaseStatsList();
            
            //int i = 0;

            //foreach (BaseStats stat in baseStats)
            //{
                

            //    if (ProcessData.memberFN == txbFirstname.Text)
            //    {
                    
            //        string strCap = Convert.ToString(stat.StrengthCap);
            //        string strLvl = Convert.ToString(stat.StrengthCap);
                    
            //        string dexCap = Convert.ToString(stat.DexterityCap );
            //        string dexLvl = Convert.ToString(stat.DexterityLevel);

            //        string intCap = Convert.ToString(stat.IntelligenceCap);
            //        string intLvl = Convert.ToString(stat.IntelligenceLevel);

            //        string chaCap = Convert.ToString(stat.CharismaCap);
            //        string chaLvl = Convert.ToString(stat.CharismaLevel);

            //        string perCap = Convert.ToString(stat.PerceptionCap);
            //        string perLvl = Convert.ToString(stat.PerceptionLevel);

            //        string forCap = Convert.ToString(stat.FortitudeCap);
            //        string forLvl = Convert.ToString(stat.FortitudeLevel);

            //    }

            //    txbCapStrenght.Text = "";
            //    txbCapStrenght.Text = "";
            //    txbCapDexterity.Text = "";
            //    txbLevelDexterity.Text = "";
            //    txbCapIntelligence.Text = "";
            //    txbLevelIntelligence.Text=  "";
            //    txbCapCharisma.Text = "";
            //    txbLevelCharisma.Text = "";
            //    txbCapPerception.Text = "";
            //    txbLevelPerception.Text=  "";
            //    txbCapFortitude.Text=  "";
            //    txbLevelFortitude.Text = "";


                }

        private void button2_Click(object sender, EventArgs e)
        {
            Output.Text = File.ReadAllText(ProcessFile.tempFilePath);
        }
    }
    }


