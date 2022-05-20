﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sheltered_2_SE
{
    public partial class ShelterDesigner : Form
    {
        public ShelterDesigner()
        {
            InitializeComponent();


            //InitializeComponent();

            pbxRemoveRoomSelected.Visible = false;
            pbxDirtRoomSelected.Visible = false;
            pbxStoneRoomSelected.Visible = false;
            pbxDoorSelected.Visible = false;
            pbxTiledRoomSelected.Visible = false;
            pbxPlasterRoomSelected.Visible = false;

        }

        private void ShelterDesigner_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 80; i++)
            {
                var pBName = "i" + i;
                foreach (Control pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                {
                    if (pB.Name == pBName)
                    {
                        if (pB.Name == "i36")
                        {

                        }
                        else
                        {
                            pB.Click += PictureBoxClick;
                        }
                    }
                }
            }

            var xDoc = XDocument.Load(ProcessFile.tempFilePath);
            for (int i = 0; i <= 80; i++)
            {
                List<ShelterRoom> roomList = xDoc.Descendants("ShelterCellList").Descendants("i" + i)
                             .Select(q => new ShelterRoom()
                             {
                                 RoomType = q.Element("type").Value,
                                 RoomMaterial = q.Element("roomType").Value,
                                 PercentExcavated = q.Element("percentageExcavated").Value,
                                 BypassRoomSpawn = q.Element("bypassRoomSpawn").Value
                             }).ToList<ShelterRoom>();
                foreach (var item in roomList)
                {
                    var cell = "i" + i;

                    if (item.RoomType == "1")
                    {
                        foreach (Control pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                        {
                            if (pB.Name == cell)
                            {
                                pB.BackgroundImage = pbxRemoveRoom.BackgroundImage;
                                pB.Update();
                                pB.Refresh();
                            }
                        }
                    }
                    else if (item.RoomType == "3")
                    {
                        if (item.RoomMaterial == "0")
                        {
                            foreach (Control pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                            {
                                if (pB.Name == cell)
                                {
                                    if (pB.Name == "i18" && pB.Name == cell)
                                    {
                                        pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.DirtWallLeftPillar;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                    else if (pB.Name == "i54" && pB.Name == cell)
                                    {
                                        pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.DirtWallRightPillar;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                    else
                                    {
                                        pB.BackgroundImage = pbxDirtRoom.BackgroundImage;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                }
                            }
                        }
                        else if (item.RoomMaterial == "1")
                        {
                            foreach (Control pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                            {
                                if (pB.Name == cell)
                                {
                                    if (pB.Name == "i18" && pB.Name == cell)
                                    {
                                        pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.StoneWallLeftPillar;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                    else if (pB.Name == "i54" && pB.Name == cell)
                                    {
                                        pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.StoneWallRightPillar;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                    else
                                    {
                                        pB.BackgroundImage = pbxStoneRoom.BackgroundImage;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                }
                            }
                        }
                        else if (item.RoomMaterial == "2")
                        {
                            foreach (Control pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                            {
                                if (pB.Name == cell)
                                {
                                    if (pB.Name == "i18" && pB.Name == cell)
                                    {
                                        pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.TiledRoomLeftPillar;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                    else if (pB.Name == "i54" && pB.Name == cell)
                                    {
                                        pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.TiledRoomRightPillar;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                    else
                                    {
                                        pB.BackgroundImage = pbxTiledRoom.BackgroundImage;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                }
                            }
                        }
                        else if (item.RoomMaterial == "3")
                        {
                            foreach (Control pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                            {
                                if (pB.Name == cell)
                                {
                                    if (pB.Name == "i18" && pB.Name == cell)
                                    {
                                        pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.PlasterWallLeftPillar;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                    else if (pB.Name == "i54" && pB.Name == cell)
                                    {
                                        pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.PlasterWallRightPillar;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                    else
                                    {
                                        pB.BackgroundImage = pbxPlasterRoom.BackgroundImage;
                                        pB.Update();
                                        pB.Refresh();
                                    }
                                }
                            }
                        }
                    }
                    else if (item.RoomType == "4")
                    {
                        foreach (PictureBox pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                        {
                            if (pB.Name == cell)
                            {
                                if (pB.Name == "i0" && pB.Name == cell)
                                {
                                    pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.DoorTopLeft;
                                    pB.Update();
                                    pB.Refresh();
                                }
                                else
                                {
                                    pB.BackgroundImage = pbxDoor.BackgroundImage;
                                    pB.Update();
                                    pB.Refresh();
                                }
                            }
                        }
                    }
                    else if (item.RoomType == "5")
                    {
                        foreach (PictureBox pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                        {
                            if (pB.Name == cell)
                            {
                                if (pB.Name == cell)
                                {
                                    pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.cell;
                                    pB.Enabled = false;
                                    pB.Update();
                                    pB.Refresh();
                                }
                            }
                        }
                    }
                    else if (item.RoomType == "6")
                    {
                        foreach (PictureBox pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                        {
                            if (pB.Name == cell)
                            {
                                if (pB.Name == cell && item.BypassRoomSpawn == "True")
                                {
                                    pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.garage_right;
                                    pB.Enabled = false;
                                    pB.Update();
                                    pB.Refresh();
                                }
                                else
                                {
                                    pB.BackgroundImage = Sheltered_2_SE.Properties.Resources.garage_left;
                                    pB.Enabled = false;
                                    pB.Update();
                                    pB.Refresh();
                                }
                            }
                        }
                    }

                }
            }
        }

        private void pbxRemoveRoom_Click(object sender, EventArgs e)
        {

            pbxRemoveRoomSelected.Visible = true;
            pbxDirtRoomSelected.Visible = false;
            pbxStoneRoomSelected.Visible = false;
            pbxDoorSelected.Visible = false;
            pbxTiledRoomSelected.Visible = false;
            pbxPlasterRoomSelected.Visible = false;

        }

        private void pbxDoor_Click(object sender, EventArgs e)
        {

            pbxRemoveRoomSelected.Visible = false;
            pbxDirtRoomSelected.Visible = false;
            pbxStoneRoomSelected.Visible = false;
            pbxDoorSelected.Visible = true;
            pbxTiledRoomSelected.Visible = false;
            pbxPlasterRoomSelected.Visible = false;

        }

        private void pbxDirtRoom_Click(object sender, EventArgs e)
        {
            pbxRemoveRoomSelected.Visible = false;
            pbxDirtRoomSelected.Visible = true;
            pbxStoneRoomSelected.Visible = false;
            pbxDoorSelected.Visible = false;
            pbxTiledRoomSelected.Visible = false;
            pbxPlasterRoomSelected.Visible = false;
        }

        private void pbxStoneRoom_Click(object sender, EventArgs e)
        {
            pbxRemoveRoomSelected.Visible = false;
            pbxDirtRoomSelected.Visible = false;
            pbxStoneRoomSelected.Visible = true;
            pbxDoorSelected.Visible = false;
            pbxTiledRoomSelected.Visible = false;
            pbxPlasterRoomSelected.Visible = false;
        }

        private void pbxTiledRoom_Click(object sender, EventArgs e)
        {
            pbxRemoveRoomSelected.Visible = false;
            pbxDirtRoomSelected.Visible = false;
            pbxStoneRoomSelected.Visible = false;
            pbxDoorSelected.Visible = false;
            pbxTiledRoomSelected.Visible = true;
            pbxPlasterRoomSelected.Visible = false;
        }

        private void pbxPlasterRoom_Click(object sender, EventArgs e)
        {
            pbxRemoveRoomSelected.Visible = false;
            pbxDirtRoomSelected.Visible = false;
            pbxStoneRoomSelected.Visible = false;
            pbxDoorSelected.Visible = false;
            pbxTiledRoomSelected.Visible = false;
            pbxPlasterRoomSelected.Visible = true;
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            var picBoxName = ((PictureBox)sender).Name;


            foreach (Control pB in pnlShelterDesigner.Controls)
            {
                if (pB.Name == picBoxName)
                {
                    if (pbxRemoveRoomSelected.Visible == true)
                    {
                        pB.BackgroundImage = pbxRemoveRoom.BackgroundImage;
                    }
                    else if (pbxDoorSelected.Visible == true)
                    {
                        pB.BackgroundImage = pbxDoor.BackgroundImage;
                    }
                    else if (pbxDirtRoomSelected.Visible == true)
                    {
                        pB.BackgroundImage = pbxDirtRoom.BackgroundImage;
                    }
                    else if (pbxStoneRoomSelected.Visible == true)
                    {
                        pB.BackgroundImage = pbxStoneRoom.BackgroundImage;
                    }
                    else if (pbxTiledRoomSelected.Visible == true)
                    {
                        pB.BackgroundImage = pbxTiledRoom.BackgroundImage;
                    }
                    else if (pbxPlasterRoomSelected.Visible == true)
                    {
                        pB.BackgroundImage = pbxPlasterRoom.BackgroundImage;
                    }
                }
            }
        }


        private void i0_Click(object sender, EventArgs e)
        {

        }

        private void i1_Click(object sender, EventArgs e)
        {

        }

        private void i2_Click(object sender, EventArgs e)
        {

        }

        private void i3_Click(object sender, EventArgs e)
        {

        }

        private void i4_Click(object sender, EventArgs e)
        {

        }

        private void ShelterDesigner_Unload(object sender, EventArgs e)
        {
            for (int i = 0; i < 80; i++)
            {
                var pBName = "i" + i;
                foreach (Control pB in pnlShelterDesigner.Controls.OfType<PictureBox>())
                {
                    if (pB.Name == pBName)
                    {
                        pB.Click -= PictureBoxClick;
                    }
                }
            }
        }


    }


}