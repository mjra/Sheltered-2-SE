using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sheltered_2_SE
{

    class ProcessData
    {
        public static int familyMemberCount;
        public static int memberNr = 0;
        public static int changed = 0;
        public static int saved = 0;
        public static int skillLevel = 2;
        

        //Load in FamilyMemberData
        public static List<GetFamilyMemberData> FamilyMembersList()
        {
            return XDocument.Load(ProcessFile.tempFilePath)
               .Element("root")
               .Element("FamilyMembers")
               .Elements().Where(e => e.Name.LocalName.StartsWith("Member_"))
               .Select(p => GetDataForMember(p))
               .ToList();
        }

        private static GetFamilyMemberData GetDataForMember(XElement p)
        {
            var f = new GetFamilyMemberData
            {
                MemberNumber = Convert.ToString(p.AncestorsAndSelf().First().Name),
                FirstName = p.Element("firstName").Value,
                LastName = p.Element("lastName").Value,
                Health = Convert.ToInt32(p.Element("health").Value),
                MaxHealth = Convert.ToInt32(p.Element("maxHealth").Value),
                Interacting = Convert.ToBoolean(p.Element("interacting").Value),
                InteractingWithObj = Convert.ToBoolean(p.Element("interactingWithObj").Value),
                AnimHash = Convert.ToInt32(p.Element("animHash").Value),
                AnimTime = float.Parse(p.Element("animTime").Value),
                HasBeenDefibbed = Convert.ToBoolean(p.Element("hasBeenDefibbed").Value),
            };

            var stats = p.Element("BaseStats");
            var str = GetStats(stats, "Strength");
            f.StrengthCap = str.cap;
            f.StrengthLevel = str.level;

            var dex = GetStats(stats, "Dexterity");
            f.DexterityCap = dex.cap;
            f.DexterityLevel = dex.level;

            var intel = GetStats(stats, "Intelligence");
            f.IntelligenceCap = intel.cap;
            f.IntelligenceLevel = intel.level;

            var cha = GetStats(stats, "Charisma");
            f.CharismaCap = cha.cap;
            f.CharismaLevel = cha.level;

            var perc = GetStats(stats, "Perception");
            f.PerceptionCap = perc.cap;
            f.PerceptionLevel = perc.level;

            var fort = GetStats(stats, "Fortitude");
            f.FortitudeCap = fort.cap;
            f.FortitudeLevel = fort.level;

            return f;
        }

        private static (int cap, int level) GetStats(XElement stats, string statName)
        {
            var values = stats.Element(statName);
            var cap = Convert.ToInt32(values.Element("cap").Value);
            var level = Convert.ToInt32(values.Element("level").Value);

            return (cap, level);
        }

        //Load in Skills
        //public static List<GetSkills> SkillsList()
        //{
        //    return XDocument.Load(ProcessFile.tempFilePath)
        //       .Element("root")
        //       .Element("FamilyMembers")
        //       .Elements().Where(e => e.Name.LocalName.StartsWith("Member_"))
        //       .Select(p => GetSkillsForMember(p))
        //       .ToList(); 
        //}

        //public static List<GetSkills> SkillsList()
        //{
        //    return XDocument.Load(ProcessFile.tempFilePath)
        //       .Element("root")
        //       .Element("FamilyMembers")
        //       .Elements().Where(e => e.Name.LocalName.StartsWith("Member_"))
        //       .Elements("Profession")
        //       .Elements("StrengthSkills")
        //       .Elements("strengthSkills")
        //       .Elements().Where(e=> e.Name.LocalName.StartsWith("i"))
        //       .Select.Element("skillKey").Value
        //       .ToList();
        //}


        //private static GetSkills GetSkillsForMember(XElement p)
        //{
        //    var f = new GetSkills
            
        //    {
        //        MemberNumber = Convert.ToString(p.AncestorsAndSelf().First().Name)  
        //    };


        //    //var skillIndex = p.Element("i" + indexNr);


        //    var prof = p.Element("Profession");

        //    var size = p.Attribute("size").Value;
        //    var indexNr = size;
        //    var skillsAttribute = p.Element("strengthSkills");
        //    var attribute = p.Attributes(size);
        //    var gI = p.Elements().Where(i => i.Name.LocalName.StartsWith("i"));

           

        //    var str = GetSkills(prof, "StrengthSkills", skillsAttribute, attribute);
            
        //    f.Strength = str.getStr;

        //    var dex = GetSkills(prof, "DexteritySkills", skillsAttribute, attribute);

        //    f.Dexterity = dex.aSkillKey;


        //    var intel = GetSkills(prof, "IntelligenceSkills", skillsAttribute, attribute);

        //    f.Intelligence = intel.aSkillKey;


        //    var cha = GetSkills(prof, "CharismaSkills", skillsAttribute, attribute);

        //    f.Charisma = cha.aSkillKey;


        //    var perc = GetSkills(prof, "PerceptionSkills", skillsAttribute, attribute);

        //    f.Perception = perc.aSkillKey;


        //    var fort = GetSkills(prof, "FortitudeSkills", skillsAttribute, attribute);

        //    f.Fortitude = fort.aSkillKey;

        //    var v = new GetSkills
        //    {

        //    };


        //    var getV = GetValues((XElement)gI);
        //    f.SkillKey = gI.aSkillKey;
        //    f.SkillLevel = gI.aSkillLevel;
        //    f.AccuracyLevel = gI.aAccuracyLevel;
        //    f.DamageLevel = gI.aDamageLevel;
        //    f.StaminaLevel = gI.aStaminaLevel;
        //    f.ChanceLevel = gI.aChanceLevel;


        //    return f;
        //}

        //private static object GetSkills(XElement prof, string statName, XElement skillsAttribute, XElement attribute)
        //{

        //    var getStr = Convert.ToInt32(gI.Element("skillKey").Value);




        //    return (getStr, getDex, getInt, getCha, getPer, getFor);
        //}

        private static (int aSkillKey, int aSkillLevel, int aAccuracyLevel, int aDamageLevel, int aStaminaLevel, int aChanceLevel) GetValues(XElement gI)
        {

            var aSkillKey = Convert.ToInt32(gI.Element("skillKey").Value);
            var aSkillLevel = Convert.ToInt32(gI.Element("skillLevel").Value);
            var aAccuracyLevel = Convert.ToInt32(gI.Element("accuracyLevel").Value);
            var aDamageLevel = Convert.ToInt32(gI.Element("damageLevel").Value);
            var aStaminaLevel = Convert.ToInt32(gI.Element("staminaLevel").Value);
            var aChanceLevel = Convert.ToInt32(gI.Element("chanceLevel").Value);


            return (aSkillKey, aSkillLevel, aAccuracyLevel, aDamageLevel, aStaminaLevel, aChanceLevel);
        }

    }

    //Reset Controls
    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }
    }
}
