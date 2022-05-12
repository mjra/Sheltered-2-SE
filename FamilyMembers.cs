using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheltered_2_SE
{

    class FamilyMembers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public bool Interacting { get; set; }
        public bool InteractingWithObj { get; set; }
        public int AnimHash { get; set; }
        public float AnimTime   { get; set; }
        public bool HasBeenDefibbed { get; set; }

        public override string ToString()
        {
            return FirstName + "\n" + LastName + "\n" + Health + "\n" + MaxHealth + "\n" + Interacting + "\n" + InteractingWithObj + "\n" + AnimHash + "\n" + AnimTime + "\n" + HasBeenDefibbed;
        }

        public FamilyMembers(
            string firstName, string lastName, int health, int maxHealth, bool interacting, bool interactingWithObj, int animHash, float animTime,bool hasBeenDefibbed)

        {
            FirstName = firstName;
            LastName = lastName;
            Health = health; 
            MaxHealth = maxHealth;
            Interacting = interacting;
            InteractingWithObj = interactingWithObj;
            AnimHash = animHash;
            AnimTime = animTime;
            HasBeenDefibbed = hasBeenDefibbed; 
        }
        
    }

    class BaseStats
    {
        public int StrengthLevel { get; set; }
        public int StrengthCap { get; set; }
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
             return $@"Strength: {StrengthLevel}/{StrengthCap}
Dexterity: {DexterityLevel}/{DexterityCap}
Intelligence : {IntelligenceLevel}/{IntelligenceCap}
Charisma: {CharismaLevel}/{CharismaCap}
Perception: {PerceptionLevel}/{PerceptionCap}
Fortitude: {FortitudeLevel}/{FortitudeCap}";
        }

        //public override string ToString()
        //{
        //    return StrengthCap + "\n" + StrengthLevel + "\n" + DexterityCap  + "\n" + DexterityLevel + "\n" + IntelligenceCap + "\n" + IntelligenceLevel + "\n" + CharismaCap + "\n" + ;
        //}


        //public BaseStats(
        //    int cap, int level)
        //{
        //    StrengthCap = cap;
        //    StrengthLevel = level;
        //    DexterityCap = cap;
        //    DexterityLevel = level;
        //    IntelligenceCap = cap;
        //    IntelligenceLevel = level;    
        //    CharismaCap = cap;
        //    CharismaLevel = level;
        //    PerceptionCap = cap;
        //    PerceptionLevel = level;
        //    FortitudeCap = cap;
        //    FortitudeLevel = level;
        //}
    }
}
