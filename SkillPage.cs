using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sheltered_2_SE
{
    public class SkillPage : Form1
    {

        public class SkillLevelImage
        {
            public string name;
            public int starCount;
            public string skillTab;
        }

        public class Skills
        {
            // Internal key of skill
            public int skillKey;
            public int skillLevel;
            public int accuracyLevel;
            public int damageLevel;
            public int staminaLevel;
            public int chanceLevel;

            public Skills()
            {

            }

        }

        //public void ProcessSkillLevel(object sender, MouseEventArgs e)
        //{
        //    switch (e.Button)
        //    {
        //        case MouseButtons.Right:
        //            {
        //                if (ProcessData.skillLevel == 5)
        //                {
        //                    pbxStrSkillLevel1.Image = skillLevelIcons.Images[2];
        //                    ProcessData.skillLevel = 2;
        //                }
        //                else if (ProcessData.skillLevel == 7)
        //                {
        //                    pbxStrSkillLevel1.Image = skillLevelIcons.Images[5];
        //                    ProcessData.skillLevel = 5;
        //                }
        //                else if (ProcessData.skillLevel == 8)
        //                {
        //                    pbxStrSkillLevel1.Image = skillLevelIcons.Images[7];
        //                    ProcessData.skillLevel = 7;
        //                }
        //            }
        //            break;
        //    }
        //    switch (e.Button)
        //    {
        //        case MouseButtons.Left:
        //            {
        //                if (ProcessData.skillLevel == 2)
        //                {
        //                    pbxStrSkillLevel1.Image = skillLevelIcons.Images[5];
        //                    ProcessData.skillLevel = 5;
        //                }
        //                else if (ProcessData.skillLevel == 5)
        //                {
        //                    pbxStrSkillLevel1.Image = skillLevelIcons.Images[7];
        //                    ProcessData.skillLevel = 7;
        //                }
        //                else if (ProcessData.skillLevel == 7)
        //                {
        //                    pbxStrSkillLevel1.Image = skillLevelIcons.Images[8];
        //                    ProcessData.skillLevel = 8;
        //                }
        //            }
        //            break;
        //    }
        //}
    }
}
