using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sheltered_2_SE
{

    class GetSkillPoints
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StrengthLevelBefore { get; set; }
        public int DexterityLevelBefore { get; set; }
        public int IntelligenceLevelBefore { get; set; }
        public int CharismaLevelBefore { get; set; }
        public int PerceptionLevelBefore { get; set; }
        public int FortitudeLevelBefore { get; set; }

        public static List<GetSkillPoints> _getSkillPoints;
    }

    class NewSkillPoints
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StrengthLevelNew{ get; set; }
        public int DexterityLevelNew { get; set; }
        public int IntelligenceLevelNew { get; set; }
        public int CharismaLevelNew { get; set; }
        public int PerceptionLevelNew { get; set; }
        public int FortitudeLevelNew { get; set; }
    }

    class LoadNames
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class GetFamilyMemberData
    {
        public string MemberNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public bool Interacting { get; set; }
        public bool InteractingWithObj { get; set; }
        public int AnimHash { get; set; }
        public float AnimTime { get; set; }
        public bool HasBeenDefibbed { get; set; }
        public int StrengthCap { get; set; }
        public int StrengthLevel { get; set; }
        public int DexterityLevel { get; set; }
        public int DexterityCap { get; set; }
        public int IntelligenceLevel { get; set; }
        public int IntelligenceCap { get; set; }
        public int CharismaLevel { get; set; }
        public int CharismaCap { get; set; }
        public int PerceptionLevel { get; set; }
        public int PerceptionCap { get; set; }
        public int FortitudeLevel { get; set; }
        public int FortitudeCap { get; set; }


        public override string ToString()
        {
            return MemberNumber + "\n" + FirstName + "\n" + LastName + "\n" + Health + "\n" + MaxHealth + "\n" + Interacting + "\n" + InteractingWithObj + "\n" + AnimHash + "\n" +
                AnimTime + "\n" + HasBeenDefibbed + "\n" + StrengthCap + "\n" + StrengthLevel + "\n" + DexterityCap + "\n" + DexterityLevel + "\n" + IntelligenceCap + "\n" +
                IntelligenceLevel + "\n" + CharismaCap + "\n" + CharismaLevel + "\n" + PerceptionCap + "\n" + PerceptionLevel + "\n" + FortitudeCap + "\n" + FortitudeLevel;
        }
    }

    class Skills
    {
        public string Type { get; set; }   
        public string SkillKey { get; set; }
        public string SkillLevel { get; set; }

        //public Lists
        public static List<Skills> _strSkillList;
        public static List<Skills> _dexSkillList;
        public static List<Skills> _intSkillList;
        public static List<Skills> _chaSkillList;
        public static List<Skills> _perSkillList;
        public static List<Skills> _forSkillList;

        //Strength Skill Keys
        public static int _strSkillKey1 = 15;
        public static int _strSkillKey2 = 19;
        public static int _strSkillKey3 = 12;
        public static int _strSkillKey4 = 41;
        public static int _strSkillKey5 = 30;
        public static int _strSkillKey6 = 28;
        public static int _strSkillKey7 = 25;
        public static int _strSkillKey8 = 4;
        public static int _strSkillKey9 = 42;
        public static int _strSkillKey10 = 0;
        public static int _strSkillKey11 = 8;
        public static int _strSkillKey12 = 24;
        public static int _strSkillKey13 = 31;
        public static int _strSkillKey14 = 37;

        //Dexterity Skill Keys
        public static int _dexSkillKey1 = 102;
        public static int _dexSkillKey2 = 105;
        public static int _dexSkillKey3 = 131;
        public static int _dexSkillKey4 = 143;
        public static int _dexSkillKey5 = 110;
        public static int _dexSkillKey6 = 122;
        public static int _dexSkillKey7 = 100;
        public static int _dexSkillKey8 = 115;
        public static int _dexSkillKey9 = 139;
        public static int _dexSkillKey10 = 127;
        public static int _dexSkillKey11 = 106;
        public static int _dexSkillKey12 = 104;

        //Intelligence Skill Keys
        public static int _intSkillKey1 = 214;
        public static int _intSkillKey2 = 200;
        public static int _intSkillKey3 = 208;
        public static int _intSkillKey4 = 229;
        public static int _intSkillKey5 = 240;
        public static int _intSkillKey6 = 234;
        public static int _intSkillKey7 = 230;
        public static int _intSkillKey8 = 239;
        public static int _intSkillKey9 = 210;
        public static int _intSkillKey10 = 201;
        public static int _intSkillKey11 = 213;
        public static int _intSkillKey12 = 241;
        public static int _intSkillKey13 = 209;
        public static int _intSkillKey14 = 235;
        public static int _intSkillKey15 = 206;
        public static int _intSkillKey16 = 243;
        public static int _intSkillKey17 = 224;

        //Charisma Skill Keys
        public static int _chaSkillKey1 = 327;
        public static int _chaSkillKey2 = 309;
        public static int _chaSkillKey3 = 302;
        public static int _chaSkillKey4 = 304;
        public static int _chaSkillKey5 = 316;
        public static int _chaSkillKey6 = 319;
        public static int _chaSkillKey7 = 320;
        public static int _chaSkillKey8 = 324;
        public static int _chaSkillKey9 = 301;
        public static int _chaSkillKey10 = 429;
        public static int _chaSkillKey11 = 326;
        public static int _chaSkillKey12 = 306;
        public static int _chaSkillKey13 = 300;

        //Perception Skill Keys
        public static int _perSkillKey1 = 405;
        public static int _perSkillKey2 = 433;
        public static int _perSkillKey3 = 432;
        public static int _perSkillKey4 = 431;
        public static int _perSkillKey5 = 406;
        public static int _perSkillKey6 = 424;
        public static int _perSkillKey7 = 507;
        public static int _perSkillKey8 = 402;
        public static int _perSkillKey9 = 425;
        public static int _perSkillKey10 = 420;
        public static int _perSkillKey11 = 517;
        public static int _perSkillKey12 = 413;
        public static int _perSkillKey13 = 403;
        public static int _perSkillKey14 = 419;
        public static int _perSkillKey15 = 416;
        public static int _perSkillKey16 = 410;
        public static int _perSkillKey17 = 422;

        //Fortitude Skill Keys
        public static int _forSkillKey1 = 519;
        public static int _forSkillKey2 = 500;
        public static int _forSkillKey3 = 502;
        public static int _forSkillKey4 = 505;
        public static int _forSkillKey5 = 524;
        public static int _forSkillKey6 = 518;
        public static int _forSkillKey7 = 522;
        public static int _forSkillKey8 = 513;
        public static int _forSkillKey9 = 515;
        public static int _forSkillKey10 = 506;
        public static int _forSkillKey11 = 501;
        public static int _forSkillKey12 = 504;
        public static int _forSkillKey13 = 521;
        public static int _forSkillKey14 = 523;
        public static int _forSkillKey15 = 512;
        public static int _forSkillKey16 = 526;
        public static int _forSkillKey17 = 503;
        public static int _forSkillKey18 = 509;
        public static int _forSkillKey19 = 510;
        public static int _forSkillKey20 = 516;

        //SkillAmounts
        public static int _strSkillAmount = 14;
        public static int _dexSkillAmount = 12;
        public static int _intSkillAmount = 17;
        public static int _chaSkillAmount = 13;
        public static int _perSkillAmount = 17;
        public static int _forSkillAmount = 20;

    }

    class SkillList
    {

        private List<Skills> skill = new List<Skills>();

        public bool AddSkill(string aSkillKey, string aSkillLevel)
        {
            skill.Add(new Skills
            {
                SkillKey = aSkillKey,
                SkillLevel = aSkillLevel
            });
            return true;
        }

    }



}
