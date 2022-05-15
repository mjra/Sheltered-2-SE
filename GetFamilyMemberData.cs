using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sheltered_2_SE
{


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

        //public FamilyMembers()
        //{

        //}

        ////public FamilyMembers(
        ////    string memberNr, string firstName, string lastName, int health, int maxHealth, bool interacting, bool interactingWithObj, int animHash, float animTime,
        ////    bool hasBeenDefibbed, int strCap, int strLvl, int dexCap, int dexLvl, int intCap, int intLvl, int charCap, int charLvl, int perCap, int perLvl, int forCap,
        ////    int forLvl)
        ////{
        
        ////}
    }
}
