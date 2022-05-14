
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
            this.decryptionEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptSaveOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptSaveOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblAnimTimeValue = new System.Windows.Forms.Label();
            this.lblAnimTime = new System.Windows.Forms.Label();
            this.lblAnimHashValue = new System.Windows.Forms.Label();
            this.lblAnimHash = new System.Windows.Forms.Label();
            this.cBHasBeenDefibbed = new System.Windows.Forms.CheckBox();
            this.cBInteractingWithObj = new System.Windows.Forms.CheckBox();
            this.cBInteracting = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyMeACoffeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.decryptionEncryptionToolStripMenuItem,
            this.helpStripMenuItem,
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
            // decryptionEncryptionToolStripMenuItem
            // 
            this.decryptionEncryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptSaveOnlyToolStripMenuItem,
            this.encryptSaveOnlyToolStripMenuItem});
            this.decryptionEncryptionToolStripMenuItem.Name = "decryptionEncryptionToolStripMenuItem";
            this.decryptionEncryptionToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.decryptionEncryptionToolStripMenuItem.Text = "Extra";
            // 
            // decryptSaveOnlyToolStripMenuItem
            // 
            this.decryptSaveOnlyToolStripMenuItem.Name = "decryptSaveOnlyToolStripMenuItem";
            this.decryptSaveOnlyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decryptSaveOnlyToolStripMenuItem.Text = "Decrypt Save only";
            this.decryptSaveOnlyToolStripMenuItem.Click += new System.EventHandler(this.decryptSaveOnlyToolStripMenuItem_Click);
            // 
            // encryptSaveOnlyToolStripMenuItem
            // 
            this.encryptSaveOnlyToolStripMenuItem.Name = "encryptSaveOnlyToolStripMenuItem";
            this.encryptSaveOnlyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encryptSaveOnlyToolStripMenuItem.Text = "Encrypt Save only";
            this.encryptSaveOnlyToolStripMenuItem.Click += new System.EventHandler(this.encryptSaveOnlyToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyMeACoffeeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Info";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 48);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(299, 584);
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
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(20, 44);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(74, 17);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Firstname:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(20, 70);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(74, 17);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Lastname:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(20, 96);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(53, 17);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health:";
            // 
            // lblMaxHealth
            // 
            this.lblMaxHealth.AutoSize = true;
            this.lblMaxHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHealth.Location = new System.Drawing.Point(20, 122);
            this.lblMaxHealth.Name = "lblMaxHealth";
            this.lblMaxHealth.Size = new System.Drawing.Size(82, 17);
            this.lblMaxHealth.TabIndex = 3;
            this.lblMaxHealth.Text = "Max Health:";
            // 
            // txbFirstname
            // 
            this.txbFirstname.Location = new System.Drawing.Point(104, 44);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(128, 20);
            this.txbFirstname.TabIndex = 4;
            // 
            // txbLastname
            // 
            this.txbLastname.Location = new System.Drawing.Point(104, 70);
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.Size = new System.Drawing.Size(128, 20);
            this.txbLastname.TabIndex = 5;
            // 
            // txbMaxHealth
            // 
            this.txbMaxHealth.Location = new System.Drawing.Point(104, 122);
            this.txbMaxHealth.Name = "txbMaxHealth";
            this.txbMaxHealth.Size = new System.Drawing.Size(128, 20);
            this.txbMaxHealth.TabIndex = 6;
            // 
            // txbHealth
            // 
            this.txbHealth.Location = new System.Drawing.Point(104, 96);
            this.txbHealth.Name = "txbHealth";
            this.txbHealth.Size = new System.Drawing.Size(128, 20);
            this.txbHealth.TabIndex = 7;
            // 
            // cbxCharacterSelect
            // 
            this.cbxCharacterSelect.FormattingEnabled = true;
            this.cbxCharacterSelect.Location = new System.Drawing.Point(104, 17);
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
            this.lblCharacterStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterStats.Location = new System.Drawing.Point(3, 305);
            this.lblCharacterStats.Name = "lblCharacterStats";
            this.lblCharacterStats.Size = new System.Drawing.Size(126, 17);
            this.lblCharacterStats.TabIndex = 9;
            this.lblCharacterStats.Text = "Character Stats:";
            // 
            // lblStrenght
            // 
            this.lblStrenght.AutoSize = true;
            this.lblStrenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrenght.Location = new System.Drawing.Point(56, 331);
            this.lblStrenght.Name = "lblStrenght";
            this.lblStrenght.Size = new System.Drawing.Size(62, 17);
            this.lblStrenght.TabIndex = 10;
            this.lblStrenght.Text = "Strength";
            this.lblStrenght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDexterity.Location = new System.Drawing.Point(119, 331);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(63, 17);
            this.lblDexterity.TabIndex = 11;
            this.lblDexterity.Text = "Dexterity";
            this.lblDexterity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligence.Location = new System.Drawing.Point(183, 331);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(79, 17);
            this.lblIntelligence.TabIndex = 12;
            this.lblIntelligence.Text = "Intelligence";
            this.lblIntelligence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharisma.Location = new System.Drawing.Point(260, 331);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(67, 17);
            this.lblCharisma.TabIndex = 13;
            this.lblCharisma.Text = "Charisma";
            this.lblCharisma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerception
            // 
            this.lblPerception.AutoSize = true;
            this.lblPerception.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerception.Location = new System.Drawing.Point(326, 331);
            this.lblPerception.Name = "lblPerception";
            this.lblPerception.Size = new System.Drawing.Size(76, 17);
            this.lblPerception.TabIndex = 14;
            this.lblPerception.Text = "Perception";
            this.lblPerception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFortitude
            // 
            this.lblFortitude.AutoSize = true;
            this.lblFortitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFortitude.Location = new System.Drawing.Point(400, 331);
            this.lblFortitude.Name = "lblFortitude";
            this.lblFortitude.Size = new System.Drawing.Size(64, 17);
            this.lblFortitude.TabIndex = 15;
            this.lblFortitude.Text = "Fortitude";
            this.lblFortitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbLevelStrenght
            // 
            this.txbLevelStrenght.Location = new System.Drawing.Point(59, 351);
            this.txbLevelStrenght.Name = "txbLevelStrenght";
            this.txbLevelStrenght.Size = new System.Drawing.Size(59, 20);
            this.txbLevelStrenght.TabIndex = 16;
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.Location = new System.Drawing.Point(5, 382);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(37, 17);
            this.lblCap.TabIndex = 17;
            this.lblCap.Text = "Cap:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(5, 354);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 17);
            this.lblLevel.TabIndex = 18;
            this.lblLevel.Text = "Level:";
            // 
            // txbLevelDexterity
            // 
            this.txbLevelDexterity.Location = new System.Drawing.Point(122, 351);
            this.txbLevelDexterity.Name = "txbLevelDexterity";
            this.txbLevelDexterity.Size = new System.Drawing.Size(58, 20);
            this.txbLevelDexterity.TabIndex = 19;
            // 
            // txbLevelIntelligence
            // 
            this.txbLevelIntelligence.Location = new System.Drawing.Point(186, 351);
            this.txbLevelIntelligence.Name = "txbLevelIntelligence";
            this.txbLevelIntelligence.Size = new System.Drawing.Size(71, 20);
            this.txbLevelIntelligence.TabIndex = 20;
            // 
            // txbLevelCharisma
            // 
            this.txbLevelCharisma.Location = new System.Drawing.Point(263, 351);
            this.txbLevelCharisma.Name = "txbLevelCharisma";
            this.txbLevelCharisma.Size = new System.Drawing.Size(60, 20);
            this.txbLevelCharisma.TabIndex = 21;
            // 
            // txbLevelPerception
            // 
            this.txbLevelPerception.Location = new System.Drawing.Point(329, 351);
            this.txbLevelPerception.Name = "txbLevelPerception";
            this.txbLevelPerception.Size = new System.Drawing.Size(68, 20);
            this.txbLevelPerception.TabIndex = 22;
            // 
            // txbLevelFortitude
            // 
            this.txbLevelFortitude.Location = new System.Drawing.Point(403, 351);
            this.txbLevelFortitude.Name = "txbLevelFortitude";
            this.txbLevelFortitude.Size = new System.Drawing.Size(61, 20);
            this.txbLevelFortitude.TabIndex = 23;
            // 
            // txbCapFortitude
            // 
            this.txbCapFortitude.Location = new System.Drawing.Point(403, 379);
            this.txbCapFortitude.Name = "txbCapFortitude";
            this.txbCapFortitude.Size = new System.Drawing.Size(61, 20);
            this.txbCapFortitude.TabIndex = 29;
            // 
            // txbCapPerception
            // 
            this.txbCapPerception.Location = new System.Drawing.Point(329, 379);
            this.txbCapPerception.Name = "txbCapPerception";
            this.txbCapPerception.Size = new System.Drawing.Size(68, 20);
            this.txbCapPerception.TabIndex = 28;
            // 
            // txbCapCharisma
            // 
            this.txbCapCharisma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCapCharisma.Location = new System.Drawing.Point(263, 379);
            this.txbCapCharisma.Name = "txbCapCharisma";
            this.txbCapCharisma.Size = new System.Drawing.Size(60, 20);
            this.txbCapCharisma.TabIndex = 27;
            // 
            // txbCapIntelligence
            // 
            this.txbCapIntelligence.Location = new System.Drawing.Point(186, 379);
            this.txbCapIntelligence.Name = "txbCapIntelligence";
            this.txbCapIntelligence.Size = new System.Drawing.Size(71, 20);
            this.txbCapIntelligence.TabIndex = 26;
            // 
            // txbCapDexterity
            // 
            this.txbCapDexterity.Location = new System.Drawing.Point(122, 379);
            this.txbCapDexterity.Name = "txbCapDexterity";
            this.txbCapDexterity.Size = new System.Drawing.Size(58, 20);
            this.txbCapDexterity.TabIndex = 25;
            // 
            // txbCapStrenght
            // 
            this.txbCapStrenght.Location = new System.Drawing.Point(59, 379);
            this.txbCapStrenght.Name = "txbCapStrenght";
            this.txbCapStrenght.Size = new System.Drawing.Size(59, 20);
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
            this.btnUnstuckCharacter.Click += new System.EventHandler(this.btnUnstuckCharacter_Click);
            // 
            // pbxWarning
            // 
            this.pbxWarning.BackColor = System.Drawing.SystemColors.Control;
            this.pbxWarning.Image = ((System.Drawing.Image)(resources.GetObject("pbxWarning.Image")));
            this.pbxWarning.Location = new System.Drawing.Point(145, 445);
            this.pbxWarning.Name = "pbxWarning";
            this.pbxWarning.Size = new System.Drawing.Size(31, 27);
            this.pbxWarning.TabIndex = 32;
            this.pbxWarning.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(182, 445);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(344, 64);
            this.lblWarning.TabIndex = 33;
            this.lblWarning.Text = "WARNING\r\nThe \"Save Character\" doesn\'t save the XML, it just saves\r\n the changes. " +
    "When done you still have to save using the \r\nmenu \"File\" then save\r\n";
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.Location = new System.Drawing.Point(185, 528);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(121, 22);
            this.btnSaveCharacter.TabIndex = 34;
            this.btnSaveCharacter.Text = "Save Character";
            this.btnSaveCharacter.UseVisualStyleBackColor = true;
            this.btnSaveCharacter.Click += new System.EventHandler(this.btnSaveCharacter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "debug button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
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
            this.tabControl.Location = new System.Drawing.Point(317, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(540, 582);
            this.tabControl.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAnimTimeValue);
            this.tabPage1.Controls.Add(this.lblAnimTime);
            this.tabPage1.Controls.Add(this.lblAnimHashValue);
            this.tabPage1.Controls.Add(this.lblAnimHash);
            this.tabPage1.Controls.Add(this.cBHasBeenDefibbed);
            this.tabPage1.Controls.Add(this.cBInteractingWithObj);
            this.tabPage1.Controls.Add(this.cBInteracting);
            this.tabPage1.Controls.Add(this.btnSaveCharacter);
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
            this.tabPage1.Size = new System.Drawing.Size(532, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Characters Stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAnimTimeValue
            // 
            this.lblAnimTimeValue.AutoSize = true;
            this.lblAnimTimeValue.Location = new System.Drawing.Point(67, 496);
            this.lblAnimTimeValue.Name = "lblAnimTimeValue";
            this.lblAnimTimeValue.Size = new System.Drawing.Size(0, 13);
            this.lblAnimTimeValue.TabIndex = 41;
            // 
            // lblAnimTime
            // 
            this.lblAnimTime.AutoSize = true;
            this.lblAnimTime.Location = new System.Drawing.Point(6, 496);
            this.lblAnimTime.Name = "lblAnimTime";
            this.lblAnimTime.Size = new System.Drawing.Size(56, 13);
            this.lblAnimTime.TabIndex = 40;
            this.lblAnimTime.Text = "AnimTime:";
            // 
            // lblAnimHashValue
            // 
            this.lblAnimHashValue.AutoSize = true;
            this.lblAnimHashValue.Location = new System.Drawing.Point(67, 483);
            this.lblAnimHashValue.Name = "lblAnimHashValue";
            this.lblAnimHashValue.Size = new System.Drawing.Size(19, 13);
            this.lblAnimHashValue.TabIndex = 39;
            this.lblAnimHashValue.Text = "    ";
            // 
            // lblAnimHash
            // 
            this.lblAnimHash.AutoSize = true;
            this.lblAnimHash.Location = new System.Drawing.Point(6, 483);
            this.lblAnimHash.Name = "lblAnimHash";
            this.lblAnimHash.Size = new System.Drawing.Size(58, 13);
            this.lblAnimHash.TabIndex = 38;
            this.lblAnimHash.Text = "AnimHash:";
            // 
            // cBHasBeenDefibbed
            // 
            this.cBHasBeenDefibbed.AutoSize = true;
            this.cBHasBeenDefibbed.Location = new System.Drawing.Point(255, 268);
            this.cBHasBeenDefibbed.Name = "cBHasBeenDefibbed";
            this.cBHasBeenDefibbed.Size = new System.Drawing.Size(126, 17);
            this.cBHasBeenDefibbed.TabIndex = 37;
            this.cBHasBeenDefibbed.Text = "Has been defibrilated";
            this.cBHasBeenDefibbed.UseVisualStyleBackColor = true;
            // 
            // cBInteractingWithObj
            // 
            this.cBInteractingWithObj.AutoSize = true;
            this.cBInteractingWithObj.Location = new System.Drawing.Point(117, 268);
            this.cBInteractingWithObj.Name = "cBInteractingWithObj";
            this.cBInteractingWithObj.Size = new System.Drawing.Size(132, 17);
            this.cBInteractingWithObj.TabIndex = 36;
            this.cBInteractingWithObj.Text = "Interacting with Object";
            this.cBInteractingWithObj.UseVisualStyleBackColor = true;
            // 
            // cBInteracting
            // 
            this.cBInteracting.AutoSize = true;
            this.cBInteracting.Location = new System.Drawing.Point(23, 268);
            this.cBInteracting.Name = "cBInteracting";
            this.cBInteracting.Size = new System.Drawing.Size(76, 17);
            this.cBInteracting.TabIndex = 35;
            this.cBInteracting.Text = "Interacting";
            this.cBInteracting.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Character Traits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(532, 556);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(532, 556);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Deseases/Infestations";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(532, 556);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Unlocking";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(532, 556);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Debug";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Load XML Tree";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "To be added";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 74);
            this.label2.TabIndex = 1;
            this.label2.Text = "To be added";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 74);
            this.label3.TabIndex = 1;
            this.label3.Text = "To be added";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 74);
            this.label4.TabIndex = 1;
            this.label4.Text = "To be added";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 74);
            this.label5.TabIndex = 1;
            this.label5.Text = "To be added";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buyMeACoffeeToolStripMenuItem
            // 
            this.buyMeACoffeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.buyMeACoffeeToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.buyMeACoffeeToolStripMenuItem.Name = "buyMeACoffeeToolStripMenuItem";
            this.buyMeACoffeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buyMeACoffeeToolStripMenuItem.Text = "Buy me a Coffee";
            this.buyMeACoffeeToolStripMenuItem.Click += new System.EventHandler(this.buyMeACoffeeToolStripMenuItem_Click);
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            this.helpStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sheltered 2 Savegame Editor by mJrA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem decryptionEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptSaveOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptSaveOnlyToolStripMenuItem;
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
        private System.Windows.Forms.CheckBox cBInteracting;
        private System.Windows.Forms.Label lblAnimTimeValue;
        private System.Windows.Forms.Label lblAnimTime;
        private System.Windows.Forms.Label lblAnimHashValue;
        private System.Windows.Forms.Label lblAnimHash;
        private System.Windows.Forms.CheckBox cBHasBeenDefibbed;
        private System.Windows.Forms.CheckBox cBInteractingWithObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem buyMeACoffeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
    }
}

