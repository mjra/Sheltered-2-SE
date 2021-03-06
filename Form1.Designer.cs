
namespace Sheltered_2_SE
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unstuckCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unstuckPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsNotInUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptionEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptSaveOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptSaveOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblMaxHealth = new System.Windows.Forms.Label();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.txbLastname = new System.Windows.Forms.TextBox();
            this.txbMaxHealth = new System.Windows.Forms.TextBox();
            this.txbHealth = new System.Windows.Forms.TextBox();
            this.cbxCharacterSelect = new System.Windows.Forms.ComboBox();
            this.lblCharacterStats = new System.Windows.Forms.Label();
            this.lblStrenght = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblPerception = new System.Windows.Forms.Label();
            this.lblFortitude = new System.Windows.Forms.Label();
            this.txbLevelStrenght = new System.Windows.Forms.TextBox();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txbLevelDexterity = new System.Windows.Forms.TextBox();
            this.txbLevelIntelligence = new System.Windows.Forms.TextBox();
            this.txbLevelCharisma = new System.Windows.Forms.TextBox();
            this.txbLevelPerception = new System.Windows.Forms.TextBox();
            this.txbLevelFortitude = new System.Windows.Forms.TextBox();
            this.txbCapFortitude = new System.Windows.Forms.TextBox();
            this.txbCapPerception = new System.Windows.Forms.TextBox();
            this.txbCapCharisma = new System.Windows.Forms.TextBox();
            this.txbCapIntelligence = new System.Windows.Forms.TextBox();
            this.txbCapDexterity = new System.Windows.Forms.TextBox();
            this.txbCapStrenght = new System.Windows.Forms.TextBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnUnstuckCharacter = new System.Windows.Forms.Button();
            this.pbxWarning = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSaveCharacter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.decryptionEncryptionToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unstuckCharactersToolStripMenuItem,
            this.unstuckPetToolStripMenuItem,
            this.itemsNotInUseToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // unstuckCharactersToolStripMenuItem
            // 
            this.unstuckCharactersToolStripMenuItem.Name = "unstuckCharactersToolStripMenuItem";
            this.unstuckCharactersToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.unstuckCharactersToolStripMenuItem.Text = "Edit Characters";
            // 
            // unstuckPetToolStripMenuItem
            // 
            this.unstuckPetToolStripMenuItem.Name = "unstuckPetToolStripMenuItem";
            this.unstuckPetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.unstuckPetToolStripMenuItem.Text = "Edit Pets";
            // 
            // itemsNotInUseToolStripMenuItem
            // 
            this.itemsNotInUseToolStripMenuItem.Name = "itemsNotInUseToolStripMenuItem";
            this.itemsNotInUseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.itemsNotInUseToolStripMenuItem.Text = "Edit ";
            // 
            // decryptionEncryptionToolStripMenuItem
            // 
            this.decryptionEncryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptSaveOnlyToolStripMenuItem,
            this.encryptSaveOnlyToolStripMenuItem});
            this.decryptionEncryptionToolStripMenuItem.Name = "decryptionEncryptionToolStripMenuItem";
            this.decryptionEncryptionToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.decryptionEncryptionToolStripMenuItem.Text = "View";
            // 
            // decryptSaveOnlyToolStripMenuItem
            // 
            this.decryptSaveOnlyToolStripMenuItem.Name = "decryptSaveOnlyToolStripMenuItem";
            this.decryptSaveOnlyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.decryptSaveOnlyToolStripMenuItem.Text = "Decrypt Save only";
            // 
            // encryptSaveOnlyToolStripMenuItem
            // 
            this.encryptSaveOnlyToolStripMenuItem.Name = "encryptSaveOnlyToolStripMenuItem";
            this.encryptSaveOnlyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.encryptSaveOnlyToolStripMenuItem.Text = "Encrypt Save only";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.infoToolStripMenuItem.Text = "Extra";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Info";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 48);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(391, 584);
            this.Output.TabIndex = 1;
            this.Output.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(20, 44);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(55, 13);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Firstname:";
            this.lblFirstname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(20, 70);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(56, 13);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Lastname:";
            this.lblLastname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(20, 96);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(41, 13);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health:";
            // 
            // lblMaxHealth
            // 
            this.lblMaxHealth.AutoSize = true;
            this.lblMaxHealth.Location = new System.Drawing.Point(20, 122);
            this.lblMaxHealth.Name = "lblMaxHealth";
            this.lblMaxHealth.Size = new System.Drawing.Size(64, 13);
            this.lblMaxHealth.TabIndex = 3;
            this.lblMaxHealth.Text = "Max Health:";
            // 
            // txbFirstname
            // 
            this.txbFirstname.Location = new System.Drawing.Point(87, 41);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(128, 20);
            this.txbFirstname.TabIndex = 4;
            // 
            // txbLastname
            // 
            this.txbLastname.Location = new System.Drawing.Point(87, 67);
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.Size = new System.Drawing.Size(128, 20);
            this.txbLastname.TabIndex = 5;
            // 
            // txbMaxHealth
            // 
            this.txbMaxHealth.Location = new System.Drawing.Point(87, 119);
            this.txbMaxHealth.Name = "txbMaxHealth";
            this.txbMaxHealth.Size = new System.Drawing.Size(128, 20);
            this.txbMaxHealth.TabIndex = 6;
            // 
            // txbHealth
            // 
            this.txbHealth.Location = new System.Drawing.Point(87, 93);
            this.txbHealth.Name = "txbHealth";
            this.txbHealth.Size = new System.Drawing.Size(128, 20);
            this.txbHealth.TabIndex = 7;
            // 
            // cbxCharacterSelect
            // 
            this.cbxCharacterSelect.FormattingEnabled = true;
            this.cbxCharacterSelect.Location = new System.Drawing.Point(87, 8);
            this.cbxCharacterSelect.Name = "cbxCharacterSelect";
            this.cbxCharacterSelect.Size = new System.Drawing.Size(128, 21);
            this.cbxCharacterSelect.TabIndex = 8;
            this.cbxCharacterSelect.Tag = "";
            this.cbxCharacterSelect.Text = "Select Character";
            this.cbxCharacterSelect.SelectedIndexChanged += new System.EventHandler(this.cbxCharacterSelect_SelectedIndexChanged);
            // 
            // lblCharacterStats
            // 
            this.lblCharacterStats.AutoSize = true;
            this.lblCharacterStats.Location = new System.Drawing.Point(5, 313);
            this.lblCharacterStats.Name = "lblCharacterStats";
            this.lblCharacterStats.Size = new System.Drawing.Size(83, 13);
            this.lblCharacterStats.TabIndex = 9;
            this.lblCharacterStats.Text = "Character Stats:";
            // 
            // lblStrenght
            // 
            this.lblStrenght.AutoSize = true;
            this.lblStrenght.Location = new System.Drawing.Point(56, 335);
            this.lblStrenght.Name = "lblStrenght";
            this.lblStrenght.Size = new System.Drawing.Size(47, 13);
            this.lblStrenght.TabIndex = 10;
            this.lblStrenght.Text = "Strength";
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Location = new System.Drawing.Point(109, 335);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(48, 13);
            this.lblDexterity.TabIndex = 11;
            this.lblDexterity.Text = "Dexterity";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(163, 335);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(61, 13);
            this.lblIntelligence.TabIndex = 12;
            this.lblIntelligence.Text = "Intelligence";
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Location = new System.Drawing.Point(230, 335);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(50, 13);
            this.lblCharisma.TabIndex = 13;
            this.lblCharisma.Text = "Charisma";
            // 
            // lblPerception
            // 
            this.lblPerception.AutoSize = true;
            this.lblPerception.Location = new System.Drawing.Point(286, 335);
            this.lblPerception.Name = "lblPerception";
            this.lblPerception.Size = new System.Drawing.Size(58, 13);
            this.lblPerception.TabIndex = 14;
            this.lblPerception.Text = "Perception";
            // 
            // lblFortitude
            // 
            this.lblFortitude.AutoSize = true;
            this.lblFortitude.Location = new System.Drawing.Point(350, 335);
            this.lblFortitude.Name = "lblFortitude";
            this.lblFortitude.Size = new System.Drawing.Size(48, 13);
            this.lblFortitude.TabIndex = 15;
            this.lblFortitude.Text = "Fortitude";
            // 
            // txbLevelStrenght
            // 
            this.txbLevelStrenght.Location = new System.Drawing.Point(59, 351);
            this.txbLevelStrenght.Name = "txbLevelStrenght";
            this.txbLevelStrenght.Size = new System.Drawing.Size(44, 20);
            this.txbLevelStrenght.TabIndex = 16;
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(5, 382);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(29, 13);
            this.lblCap.TabIndex = 17;
            this.lblCap.Text = "Cap:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(5, 354);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 18;
            this.lblLevel.Text = "Level:";
            // 
            // txbLevelDexterity
            // 
            this.txbLevelDexterity.Location = new System.Drawing.Point(112, 351);
            this.txbLevelDexterity.Name = "txbLevelDexterity";
            this.txbLevelDexterity.Size = new System.Drawing.Size(45, 20);
            this.txbLevelDexterity.TabIndex = 19;
            // 
            // txbLevelIntelligence
            // 
            this.txbLevelIntelligence.Location = new System.Drawing.Point(166, 351);
            this.txbLevelIntelligence.Name = "txbLevelIntelligence";
            this.txbLevelIntelligence.Size = new System.Drawing.Size(58, 20);
            this.txbLevelIntelligence.TabIndex = 20;
            // 
            // txbLevelCharisma
            // 
            this.txbLevelCharisma.Location = new System.Drawing.Point(233, 351);
            this.txbLevelCharisma.Name = "txbLevelCharisma";
            this.txbLevelCharisma.Size = new System.Drawing.Size(50, 20);
            this.txbLevelCharisma.TabIndex = 21;
            // 
            // txbLevelPerception
            // 
            this.txbLevelPerception.Location = new System.Drawing.Point(289, 351);
            this.txbLevelPerception.Name = "txbLevelPerception";
            this.txbLevelPerception.Size = new System.Drawing.Size(55, 20);
            this.txbLevelPerception.TabIndex = 22;
            // 
            // txbLevelFortitude
            // 
            this.txbLevelFortitude.Location = new System.Drawing.Point(353, 351);
            this.txbLevelFortitude.Name = "txbLevelFortitude";
            this.txbLevelFortitude.Size = new System.Drawing.Size(45, 20);
            this.txbLevelFortitude.TabIndex = 23;
            // 
            // txbCapFortitude
            // 
            this.txbCapFortitude.Location = new System.Drawing.Point(353, 379);
            this.txbCapFortitude.Name = "txbCapFortitude";
            this.txbCapFortitude.Size = new System.Drawing.Size(45, 20);
            this.txbCapFortitude.TabIndex = 29;
            // 
            // txbCapPerception
            // 
            this.txbCapPerception.Location = new System.Drawing.Point(289, 379);
            this.txbCapPerception.Name = "txbCapPerception";
            this.txbCapPerception.Size = new System.Drawing.Size(55, 20);
            this.txbCapPerception.TabIndex = 28;
            // 
            // txbCapCharisma
            // 
            this.txbCapCharisma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCapCharisma.Location = new System.Drawing.Point(233, 379);
            this.txbCapCharisma.Name = "txbCapCharisma";
            this.txbCapCharisma.Size = new System.Drawing.Size(50, 20);
            this.txbCapCharisma.TabIndex = 27;
            // 
            // txbCapIntelligence
            // 
            this.txbCapIntelligence.Location = new System.Drawing.Point(166, 379);
            this.txbCapIntelligence.Name = "txbCapIntelligence";
            this.txbCapIntelligence.Size = new System.Drawing.Size(58, 20);
            this.txbCapIntelligence.TabIndex = 26;
            // 
            // txbCapDexterity
            // 
            this.txbCapDexterity.Location = new System.Drawing.Point(112, 379);
            this.txbCapDexterity.Name = "txbCapDexterity";
            this.txbCapDexterity.Size = new System.Drawing.Size(45, 20);
            this.txbCapDexterity.TabIndex = 25;
            // 
            // txbCapStrenght
            // 
            this.txbCapStrenght.Location = new System.Drawing.Point(59, 379);
            this.txbCapStrenght.Name = "txbCapStrenght";
            this.txbCapStrenght.Size = new System.Drawing.Size(44, 20);
            this.txbCapStrenght.TabIndex = 24;
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(5, 441);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(48, 13);
            this.lblDebug.TabIndex = 30;
            this.lblDebug.Text = "DEBUG:";
            // 
            // btnUnstuckCharacter
            // 
            this.btnUnstuckCharacter.Location = new System.Drawing.Point(8, 457);
            this.btnUnstuckCharacter.Name = "btnUnstuckCharacter";
            this.btnUnstuckCharacter.Size = new System.Drawing.Size(106, 23);
            this.btnUnstuckCharacter.TabIndex = 31;
            this.btnUnstuckCharacter.Text = "Unstuck Character";
            this.btnUnstuckCharacter.UseVisualStyleBackColor = true;
            // 
            // pbxWarning
            // 
            this.pbxWarning.BackColor = System.Drawing.SystemColors.Control;
            this.pbxWarning.Image = ((System.Drawing.Image)(resources.GetObject("pbxWarning.Image")));
            this.pbxWarning.Location = new System.Drawing.Point(193, 427);
            this.pbxWarning.Name = "pbxWarning";
            this.pbxWarning.Size = new System.Drawing.Size(31, 27);
            this.pbxWarning.TabIndex = 32;
            this.pbxWarning.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(230, 427);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(155, 39);
            this.lblWarning.TabIndex = 33;
            this.lblWarning.Text = "WARNING\r\nRaising the Cap above 20 may \r\ncause Savegame corruption";
            this.lblWarning.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.Location = new System.Drawing.Point(143, 528);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(121, 22);
            this.btnSaveCharacter.TabIndex = 34;
            this.btnSaveCharacter.Text = "Save Character";
            this.btnSaveCharacter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Location = new System.Drawing.Point(421, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(448, 582);
            this.tabControl.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveCharacter);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cbxCharacterSelect);
            this.tabPage1.Controls.Add(this.lblWarning);
            this.tabPage1.Controls.Add(this.lblFirstname);
            this.tabPage1.Controls.Add(this.pbxWarning);
            this.tabPage1.Controls.Add(this.lblLastname);
            this.tabPage1.Controls.Add(this.btnUnstuckCharacter);
            this.tabPage1.Controls.Add(this.lblHealth);
            this.tabPage1.Controls.Add(this.lblDebug);
            this.tabPage1.Controls.Add(this.lblMaxHealth);
            this.tabPage1.Controls.Add(this.txbCapFortitude);
            this.tabPage1.Controls.Add(this.txbFirstname);
            this.tabPage1.Controls.Add(this.txbCapPerception);
            this.tabPage1.Controls.Add(this.txbLastname);
            this.tabPage1.Controls.Add(this.txbCapCharisma);
            this.tabPage1.Controls.Add(this.txbMaxHealth);
            this.tabPage1.Controls.Add(this.txbCapIntelligence);
            this.tabPage1.Controls.Add(this.txbHealth);
            this.tabPage1.Controls.Add(this.txbCapDexterity);
            this.tabPage1.Controls.Add(this.lblCharacterStats);
            this.tabPage1.Controls.Add(this.txbCapStrenght);
            this.tabPage1.Controls.Add(this.lblStrenght);
            this.tabPage1.Controls.Add(this.txbLevelFortitude);
            this.tabPage1.Controls.Add(this.lblDexterity);
            this.tabPage1.Controls.Add(this.txbLevelPerception);
            this.tabPage1.Controls.Add(this.lblIntelligence);
            this.tabPage1.Controls.Add(this.txbLevelCharisma);
            this.tabPage1.Controls.Add(this.lblCharisma);
            this.tabPage1.Controls.Add(this.txbLevelIntelligence);
            this.tabPage1.Controls.Add(this.lblPerception);
            this.tabPage1.Controls.Add(this.txbLevelDexterity);
            this.tabPage1.Controls.Add(this.lblFortitude);
            this.tabPage1.Controls.Add(this.lblLevel);
            this.tabPage1.Controls.Add(this.txbLevelStrenght);
            this.tabPage1.Controls.Add(this.lblCap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Characters Stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Character Traits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(440, 556);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(440, 556);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Deseases/Infestations";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(440, 556);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Unlocking";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(440, 556);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Debug";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sheltered 2 Savegame Editor by mJrA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unstuckCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unstuckPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsNotInUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptionEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptSaveOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptSaveOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txbHealth;
        private System.Windows.Forms.TextBox txbMaxHealth;
        private System.Windows.Forms.TextBox txbLastname;
        private System.Windows.Forms.TextBox txbFirstname;
        private System.Windows.Forms.Label lblMaxHealth;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Button btnUnstuckCharacter;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.TextBox txbCapFortitude;
        private System.Windows.Forms.TextBox txbCapPerception;
        private System.Windows.Forms.TextBox txbCapCharisma;
        private System.Windows.Forms.TextBox txbCapIntelligence;
        private System.Windows.Forms.TextBox txbCapDexterity;
        private System.Windows.Forms.TextBox txbCapStrenght;
        private System.Windows.Forms.TextBox txbLevelFortitude;
        private System.Windows.Forms.TextBox txbLevelPerception;
        private System.Windows.Forms.TextBox txbLevelCharisma;
        private System.Windows.Forms.TextBox txbLevelIntelligence;
        private System.Windows.Forms.TextBox txbLevelDexterity;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.TextBox txbLevelStrenght;
        private System.Windows.Forms.Label lblFortitude;
        private System.Windows.Forms.Label lblPerception;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblStrenght;
        private System.Windows.Forms.Label lblCharacterStats;
        private System.Windows.Forms.ComboBox cbxCharacterSelect;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox pbxWarning;
        private System.Windows.Forms.Button btnSaveCharacter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button2;
    }
}

