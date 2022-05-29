using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sheltered_2_SE
{
    public class Pets
    {
        public string PetId { get; set; }
        public string PetSpecies { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Dead { get; set; }
        public string Health { get; set; }
        public string IsAway { get; set; }
        public string Interacting { get; set; }
        public string AnimHash { get; set; }
        public string AnimTime { get; set; }
        public string AppearanceIndex { get; set; }
        public string PreyDriveLevel { get; set; }
        public string PreyDriveCap { get; set; }
        public string ScavengingLevel { get; set; }
        public string ScavengingCap { get; set; }
        public string AffectionLevel { get; set; }
        public string AffectionCap { get; set; }
        public string ShelterPoints { get; set; }
        public string ShelterSkill1 { get; set; }
        public string ShelterSkill2 { get; set; }
        public string ShelterSkill3 { get; set; }
        public string ShelterSkill4 { get; set; }
        public string ShelterSkill5 { get; set; }
        public string ShelterSkill6 { get; set; }
        public string UtilityPoints { get; set; }
        public string UtilitySkill1 { get; set; }
        public string UtilitySkill2 { get; set; }
        public string UtilitySkill3 { get; set; }
        public string UtilitySkill4 { get; set; }
        public string UtilitySkill5 { get; set; }
        public string UtilitySkill6 { get; set; }
        public string CombatPoints { get; set; }
        public string CombatSkill1 { get; set; }
        public string CombatSkill2 { get; set; }
        public string CombatSkill3 { get; set; }
        public string CombatSkill4 { get; set; }
        public string CombatSkill5 { get; set; }
        public string CombatSkill6 { get; set; }
        public string ShelterSkillTraining1 { get; set; }
        public string ShelterSkillTraining2 { get; set; }
        public string ShelterSkillTraining3 { get; set; }
        public string ShelterSkillTraining4 { get; set; }
        public string ShelterSkillTraining5 { get; set; }
        public string ShelterSkillTraining6 { get; set; }
        public string UtilitySkillTraining1 { get; set; }
        public string UtilitySkillTraining2 { get; set; }
        public string UtilitySkillTraining3 { get; set; }
        public string UtilitySkillTraining4 { get; set; }
        public string UtilitySkillTraining5 { get; set; }
        public string UtilitySkillTraining6 { get; set; }
        public string CombatSkillTraining1 { get; set; }
        public string CombatSkillTraining2 { get; set; }
        public string CombatSkillTraining3 { get; set; }
        public string CombatSkillTraining4 { get; set; }
        public string CombatSkillTraining5 { get; set; }
        public string CombatSkillTraining6 { get; set; }

    }

    public class DogSkill
    {
        public string Name { get; set; }
        public string SkillKey { get; set; }
        public string TrainingTimeRequired { get; set; }
        public string CurrentTrainingTime { get; set; }
        public string Purchased { get; set; }
    }

    public class PetImport
    {
        public static List<Pets> GetPets()
        {
       
                return XDocument.Load(ProcessFile.tempFilePath)
                    .Element("root")
                    .Elements().Where(e => e.Name.LocalName.StartsWith("Pet_"))
                    .Select(p => ImportPet(p))
                    .ToList();         
        }

        private static Pets ImportPet(XElement p)
        {
            var pet = new Pets
            {
                PetId = p?.AncestorsAndSelf().First()?.Name.ToString(),              
                Name = p?.Element("name")?.Value,
                Age = p?.Element("age")?.Value,
                Dead = p?.Element("dead")?.Value,
                Health = p?.Element("health")?.Value,
                IsAway = p?.Element("isAway")?.Value,
                Interacting = p?.Element("interacting")?.Value,
                AnimHash = p?.Element("animHash")?.Value,
                AnimTime = p?.Element("animTime")?.Value,
                AppearanceIndex = p?.Element("Apperance_")?.Element("appearanceIndex")?.Value,
                PreyDriveLevel = p?.Element("PreyDrive")?.Element("level")?.Value,
                PreyDriveCap = p?.Element("PreyDrive")?.Element("levelCap")?.Value,
                ScavengingLevel = p?.Element("Scavenging")?.Element("level")?.Value,
                ScavengingCap = p?.Element("Scavenging")?.Element("levelCap")?.Value,
                AffectionLevel = p?.Element("Affection")?.Element("level")?.Value,
                AffectionCap = p?.Element("Affection")?.Element("levelCap")?.Value,
                //ShelterSkills
                ShelterPoints = p?.Element("Dog_Skills")?.Element("shelterPoints")?.Value,
                ShelterSkill1 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i3")?.Element("purchased")?.Value,
                ShelterSkillTraining1 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i3")?.Element("currentTrainingTime")?.Value,
                ShelterSkill2 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i5")?.Element("purchased")?.Value,
                ShelterSkillTraining2 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i5")?.Element("currentTrainingTime")?.Value,
                ShelterSkill3 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i0")?.Element("purchased")?.Value,
                ShelterSkillTraining3 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i0")?.Element("currentTrainingTime")?.Value,
                ShelterSkill4 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i1")?.Element("purchased")?.Value,
                ShelterSkillTraining4 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i1")?.Element("currentTrainingTime")?.Value,
                ShelterSkill5 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i2")?.Element("purchased")?.Value,
                ShelterSkillTraining5 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i2")?.Element("currentTrainingTime")?.Value,
                ShelterSkill6 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i4")?.Element("purchased")?.Value,
                ShelterSkillTraining6 = p?.Element("Dog_Skills")?.Element("shelterSkills")?.Element("i4")?.Element("currentTrainingTime")?.Value,
                //UtilitySkills
                UtilityPoints = p?.Element("Dog_Skills")?.Element("utilityPoints")?.Value,
                UtilitySkill1 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i4")?.Element("purchased")?.Value,
                UtilitySkillTraining1 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i4")?.Element("currentTrainingTime")?.Value,
                UtilitySkill2 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i0")?.Element("purchased")?.Value,
                UtilitySkillTraining2 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i0")?.Element("currentTrainingTime")?.Value,
                UtilitySkill3 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i5")?.Element("purchased")?.Value,
                UtilitySkillTraining3 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i5")?.Element("currentTrainingTime")?.Value,
                UtilitySkill4 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i3")?.Element("purchased")?.Value,
                UtilitySkillTraining4 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i3")?.Element("currentTrainingTime")?.Value,
                UtilitySkill5 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i1")?.Element("purchased")?.Value,
                UtilitySkillTraining5 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i1")?.Element("currentTrainingTime")?.Value,
                UtilitySkill6 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i2")?.Element("purchased")?.Value,
                UtilitySkillTraining6 = p?.Element("Dog_Skills")?.Element("utilitySkills")?.Element("i2")?.Element("currentTrainingTime")?.Value,
                //CombatSkills
                CombatPoints = p?.Element("Dog_Skills")?.Element("combatPoints")?.Value,
                CombatSkill1 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i1")?.Element("purchased")?.Value,
                CombatSkillTraining1 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i1")?.Element("currentTrainingTime")?.Value,
                CombatSkill2 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i2")?.Element("purchased")?.Value,
                CombatSkillTraining2 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i2")?.Element("currentTrainingTime")?.Value,
                CombatSkill3 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i0")?.Element("purchased")?.Value,
                CombatSkillTraining3 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i0")?.Element("currentTrainingTime")?.Value,
                CombatSkill4 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i3")?.Element("purchased")?.Value,
                CombatSkillTraining4 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i3")?.Element("currentTrainingTime")?.Value,
                CombatSkill5 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i4")?.Element("purchased")?.Value,
                CombatSkillTraining5 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i4")?.Element("currentTrainingTime")?.Value,
                CombatSkill6 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i5")?.Element("purchased")?.Value,
                CombatSkillTraining6 = p?.Element("Dog_Skills")?.Element("combatSkills")?.Element("i5")?.Element("currentTrainingTime")?.Value,
            };
            return pet;
        }

    }

}
