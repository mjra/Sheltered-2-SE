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
        public static int shelterDesignerLoad = 0;
        public static string skillMember = "";
        public static string skillName = "";
        

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
