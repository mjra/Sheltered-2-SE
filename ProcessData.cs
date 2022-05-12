using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sheltered_2_SE
{
    class ProcessData
    {

        public static int familyMemberCount;
        public static string memberFN = "";

        public void GetStats()
        {
            
         
        }

        //Load in FamilyMembers
        public static List<FamilyMembers> FamilyMembersList()
        {
            {
                return XDocument.Load(ProcessFile.tempFilePath)
                   .Element("root")
                   .Element("FamilyMembers")
                   .Elements().Where(e => e.Name.LocalName.StartsWith("Member_"))
                   .Select(
                       p => new FamilyMembers(
                       p.Element("firstName").Value,
                       p.Element("lastName").Value,
                       Convert.ToInt32(p.Element("health").Value),
                       Convert.ToInt32(p.Element("maxHealth").Value),
                       Convert.ToBoolean(p.Element("interacting").Value),
                       Convert.ToBoolean(p.Element("interactingWithObj").Value),
                       Convert.ToInt32(p.Element("animHash").Value),
                       float.Parse(p.Element("animTime").Value, CultureInfo.InvariantCulture.NumberFormat),
                       Convert.ToBoolean(p.Element("hasBeenDefibbed").Value)
                                              )
                           ).ToList();
            }
        }
        public static List<BaseStats> BaseStatsList()
        {
            return XDocument.Load(ProcessFile.tempFilePath)
                .Element("root")
                .Element("FamilyMembers")
                .Elements().Where(e => e.Name.LocalName.StartsWith("Member_")).Select(x => x.Element("BaseStats"))
                .Select(GetStatsForMember)
                .ToList();
        }

        private static BaseStats GetStatsForMember(XElement stats)
        {
            var baseStats = new BaseStats();

            var str = GetStats(stats, "Strength");
            baseStats.StrengthCap = str.cap;
            baseStats.StrengthLevel = str.level;

            var dex = GetStats(stats, "Dexterity");
            baseStats.DexterityCap = dex.cap;
            baseStats.DexterityLevel = dex.level;

            var intel = GetStats(stats, "Intelligence");
            baseStats.IntelligenceCap = intel.cap;
            baseStats.IntelligenceLevel = intel.level;

            var cha = GetStats(stats, "Charisma");
            baseStats.CharismaCap = cha.cap;
            baseStats.CharismaLevel = cha.level;

            var perc = GetStats(stats, "Perception");
            baseStats.PerceptionCap = perc.cap;
            baseStats.PerceptionLevel  = perc.level;

            var fort = GetStats(stats, "Fortitude");
            baseStats.FortitudeCap = fort.cap;
            baseStats.FortitudeLevel = fort.level;

            return baseStats;
        }

        private static (int cap, int level) GetStats(XElement stats, string statName)
        {
            var values = stats.Element(statName);

            // int.TryParse probably
            var cap = Convert.ToInt32(values.Element("cap").Value);
            var level = Convert.ToInt32(values.Element("level").Value);

            return (cap, level);
        }


    }
}
