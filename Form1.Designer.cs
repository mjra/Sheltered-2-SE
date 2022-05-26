
using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptionEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptSaveOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptSaveOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyMeACoffeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSaveCharacter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.characterStatsTab = new System.Windows.Forms.TabPage();
            this.btnMaxStats = new System.Windows.Forms.Button();
            this.lblAnimTimeValue = new System.Windows.Forms.Label();
            this.lblAnimTime = new System.Windows.Forms.Label();
            this.lblAnimHashValue = new System.Windows.Forms.Label();
            this.lblAnimHash = new System.Windows.Forms.Label();
            this.cBHasBeenDefibbed = new System.Windows.Forms.CheckBox();
            this.cBInteractingWithObj = new System.Windows.Forms.CheckBox();
            this.cBInteracting = new System.Windows.Forms.CheckBox();
            this.pbxWarning = new System.Windows.Forms.PictureBox();
            this.characterSkillsTab = new System.Windows.Forms.TabPage();
            this.btnSaveCharacterSkills = new System.Windows.Forms.Button();
            this.tabControlSkills = new System.Windows.Forms.TabControl();
            this.skillPageStr = new System.Windows.Forms.TabPage();
            this.lblPointsAvailableStrValue = new System.Windows.Forms.Label();
            this.lblPointsAvailableStrName = new System.Windows.Forms.Label();
            this.pbxAvailablePointsStr = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel14 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel13 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel12 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel11 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel10 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel9 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel8 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel7 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel6 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel5 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel4 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel3 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel2 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkillLevel1 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill14 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill13 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill12 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill11 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill10 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill9 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill8 = new System.Windows.Forms.PictureBox();
            this.lblStrTier3 = new System.Windows.Forms.Label();
            this.lblStrTier2 = new System.Windows.Forms.Label();
            this.lblStrTier1 = new System.Windows.Forms.Label();
            this.pbxStrSkill7 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill6 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill5 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill4 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill3 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill2 = new System.Windows.Forms.PictureBox();
            this.pbxStrSkill1 = new System.Windows.Forms.PictureBox();
            this.skillPageDex = new System.Windows.Forms.TabPage();
            this.lblPointsAvailableDexValue = new System.Windows.Forms.Label();
            this.lblPointsAvailableDexName = new System.Windows.Forms.Label();
            this.lblDexTier3 = new System.Windows.Forms.Label();
            this.lblDexTier2 = new System.Windows.Forms.Label();
            this.lblDexTier1 = new System.Windows.Forms.Label();
            this.pbxAvailablePointsDex = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel12 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel11 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel10 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel9 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel8 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel7 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel6 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel5 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel4 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel3 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel2 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkillLevel1 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill12 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill11 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill10 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill9 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill8 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill7 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill6 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill5 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill4 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill3 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill2 = new System.Windows.Forms.PictureBox();
            this.pbxDexSkill1 = new System.Windows.Forms.PictureBox();
            this.skillPageInt = new System.Windows.Forms.TabPage();
            this.lblPointsAvailableIntValue = new System.Windows.Forms.Label();
            this.lblPointsAvailableIntName = new System.Windows.Forms.Label();
            this.lblIntTier3 = new System.Windows.Forms.Label();
            this.lblIntTier2 = new System.Windows.Forms.Label();
            this.lblIntTier1 = new System.Windows.Forms.Label();
            this.pbxAvailablePointsInt = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel17 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel16 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel15 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel14 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel13 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel12 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel11 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel10 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel9 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel8 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel7 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel6 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel5 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel4 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel3 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel2 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkillLevel1 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill17 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill16 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill15 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill14 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill13 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill12 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill11 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill10 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill9 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill8 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill7 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill6 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill5 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill4 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill3 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill2 = new System.Windows.Forms.PictureBox();
            this.pbxIntSkill1 = new System.Windows.Forms.PictureBox();
            this.skillPageCha = new System.Windows.Forms.TabPage();
            this.lblPointsAvailableChaValue = new System.Windows.Forms.Label();
            this.lblPointsAvailableChaName = new System.Windows.Forms.Label();
            this.lblChaTier3 = new System.Windows.Forms.Label();
            this.lblChaTier2 = new System.Windows.Forms.Label();
            this.lblChaTier1 = new System.Windows.Forms.Label();
            this.pbxAvailablePointsCha = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel13 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel12 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel11 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel10 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel9 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel8 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel7 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel6 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel5 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel4 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel3 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel2 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkillLevel1 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill13 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill12 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill11 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill10 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill9 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill8 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill7 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill6 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill5 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill4 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill3 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill2 = new System.Windows.Forms.PictureBox();
            this.pbxChaSkill1 = new System.Windows.Forms.PictureBox();
            this.skillPagePer = new System.Windows.Forms.TabPage();
            this.lblPointsAvailablePerValue = new System.Windows.Forms.Label();
            this.lblPointsAvailablePerName = new System.Windows.Forms.Label();
            this.lblPerTier3 = new System.Windows.Forms.Label();
            this.lblPerTier2 = new System.Windows.Forms.Label();
            this.lblPerTier1 = new System.Windows.Forms.Label();
            this.pbxAvailablePointsPer = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel17 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel16 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel15 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel14 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel13 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel12 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel11 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel10 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel9 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel8 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel7 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel6 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel5 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel4 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel3 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel2 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkillLevel1 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill17 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill16 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill15 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill14 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill13 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill12 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill11 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill10 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill9 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill8 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill7 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill6 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill5 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill4 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill3 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill2 = new System.Windows.Forms.PictureBox();
            this.pbxPerSkill1 = new System.Windows.Forms.PictureBox();
            this.skillPageFor = new System.Windows.Forms.TabPage();
            this.lblPointsAvailableForValue = new System.Windows.Forms.Label();
            this.lblPointsAvailableForName = new System.Windows.Forms.Label();
            this.lblForTier3 = new System.Windows.Forms.Label();
            this.lblForTier2 = new System.Windows.Forms.Label();
            this.lblForTier1 = new System.Windows.Forms.Label();
            this.pbxAvailablePointsFor = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel20 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel19 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel18 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel17 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel16 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel15 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel14 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel13 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel12 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel11 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel10 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel9 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel8 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel7 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel6 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel5 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel4 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel3 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel2 = new System.Windows.Forms.PictureBox();
            this.pbxForSkillLevel1 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill20 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill19 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill18 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill17 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill16 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill15 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill14 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill13 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill12 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill11 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill10 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill9 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill8 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill7 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill6 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill5 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill4 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill3 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill2 = new System.Windows.Forms.PictureBox();
            this.pbxForSkill1 = new System.Windows.Forms.PictureBox();
            this.tabIcons = new System.Windows.Forms.ImageList(this.components);
            this.lblSkillsCharacterName = new System.Windows.Forms.Label();
            this.cbxSkillsCharacterSelect = new System.Windows.Forms.ComboBox();
            this.petsTab = new System.Windows.Forms.TabPage();
            this.lblPetsToBeAdded = new System.Windows.Forms.Label();
            this.deseasesTab = new System.Windows.Forms.TabPage();
            this.lblDeseasesToBeAdded = new System.Windows.Forms.Label();
            this.unlockingTab = new System.Windows.Forms.TabPage();
            this.cbxDamageAmplifier = new System.Windows.Forms.CheckBox();
            this.cbxMedicineCrafting = new System.Windows.Forms.CheckBox();
            this.cbxBpSolarPanel = new System.Windows.Forms.CheckBox();
            this.cbxBpRecycler = new System.Windows.Forms.CheckBox();
            this.cbxBpQuantumBattery = new System.Windows.Forms.CheckBox();
            this.cbxBpIndustrialGenerator = new System.Windows.Forms.CheckBox();
            this.cbxBpDefibrilator = new System.Windows.Forms.CheckBox();
            this.cbxBpLaboratory = new System.Windows.Forms.CheckBox();
            this.cbxBpEfficientPlanter = new System.Windows.Forms.CheckBox();
            this.cbxBpFlashbangMine = new System.Windows.Forms.CheckBox();
            this.cbxBpMedicalBed = new System.Windows.Forms.CheckBox();
            this.cbxBpElectricityTrap = new System.Windows.Forms.CheckBox();
            this.cbxBpGasMine = new System.Windows.Forms.CheckBox();
            this.cbxBpBatteryBank = new System.Windows.Forms.CheckBox();
            this.cbxOtherCarPartsCrafting = new System.Windows.Forms.CheckBox();
            this.cbxOtherGunCrafting = new System.Windows.Forms.CheckBox();
            this.cbxOtherTrading = new System.Windows.Forms.CheckBox();
            this.cbxRewardOldQ3 = new System.Windows.Forms.CheckBox();
            this.cbxRewardOldQ2 = new System.Windows.Forms.CheckBox();
            this.cbxRewardOldQ1 = new System.Windows.Forms.CheckBox();
            this.cbxRewardLosQ3 = new System.Windows.Forms.CheckBox();
            this.cbxRewardLosQ2 = new System.Windows.Forms.CheckBox();
            this.cbxRewardLosQ1 = new System.Windows.Forms.CheckBox();
            this.btnSaveUnlocks = new System.Windows.Forms.Button();
            this.btnUnlockAll = new System.Windows.Forms.Button();
            this.cbxRewardBlackQ3 = new System.Windows.Forms.CheckBox();
            this.cbxRewardBlackQ2 = new System.Windows.Forms.CheckBox();
            this.cbxRewardBlackQ1 = new System.Windows.Forms.CheckBox();
            this.cbxRewardNewQ3 = new System.Windows.Forms.CheckBox();
            this.cbxRewardNewQ2 = new System.Windows.Forms.CheckBox();
            this.cbxRewardNewQ1 = new System.Windows.Forms.CheckBox();
            this.cbxRewardCtkQ3 = new System.Windows.Forms.CheckBox();
            this.cbxRewardCtkQ2 = new System.Windows.Forms.CheckBox();
            this.cbxRewardCtkQ1 = new System.Windows.Forms.CheckBox();
            this.cbxDrugsTrankwill = new System.Windows.Forms.CheckBox();
            this.cbxDrugsSnodge = new System.Windows.Forms.CheckBox();
            this.cbxDrugsSigma = new System.Windows.Forms.CheckBox();
            this.cbxDrugsPython = new System.Windows.Forms.CheckBox();
            this.cbxDrugsFeederral = new System.Windows.Forms.CheckBox();
            this.cbxDrugsCrunk = new System.Windows.Forms.CheckBox();
            this.cbxDrugsAlcohol = new System.Windows.Forms.CheckBox();
            this.cbxRewardChurchQ3 = new System.Windows.Forms.CheckBox();
            this.cbxRewardChurchQ2 = new System.Windows.Forms.CheckBox();
            this.cbxRewardChurchQ1 = new System.Windows.Forms.CheckBox();
            this.btnRevealMap = new System.Windows.Forms.Button();
            this.cbxWorkbenchTier4 = new System.Windows.Forms.CheckBox();
            this.cbxWorkbenchTier3 = new System.Windows.Forms.CheckBox();
            this.cbxWorkbenchTier2 = new System.Windows.Forms.CheckBox();
            this.cbxDraftingTableTier4 = new System.Windows.Forms.CheckBox();
            this.cbxDraftingTableTier3 = new System.Windows.Forms.CheckBox();
            this.cbxDraftingTableTier2 = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblWorkbench = new System.Windows.Forms.Label();
            this.lblDraftingTable = new System.Windows.Forms.Label();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.lblDebugToBeAdded = new System.Windows.Forms.Label();
            this.shelterDesignerTab = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.btnOpenDesigner = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDebugCharacter = new System.Windows.Forms.Label();
            this.tTStrSkill1 = new System.Windows.Forms.ToolTip(this.components);
            this.skillIcons = new System.Windows.Forms.ImageList(this.components);
            this.skillLevelIcons = new System.Windows.Forms.ImageList(this.components);
            this.AvailablePointsIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnMaxAllSkills = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.characterStatsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).BeginInit();
            this.characterSkillsTab.SuspendLayout();
            this.tabControlSkills.SuspendLayout();
            this.skillPageStr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill1)).BeginInit();
            this.skillPageDex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill1)).BeginInit();
            this.skillPageInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill1)).BeginInit();
            this.skillPageCha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill1)).BeginInit();
            this.skillPagePer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill1)).BeginInit();
            this.skillPageFor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill1)).BeginInit();
            this.petsTab.SuspendLayout();
            this.deseasesTab.SuspendLayout();
            this.unlockingTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.shelterDesignerTab.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            this.decryptSaveOnlyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.decryptSaveOnlyToolStripMenuItem.Text = "Decrypt Save only";
            this.decryptSaveOnlyToolStripMenuItem.Click += new System.EventHandler(this.decryptSaveOnlyToolStripMenuItem_Click);
            // 
            // encryptSaveOnlyToolStripMenuItem
            // 
            this.encryptSaveOnlyToolStripMenuItem.Name = "encryptSaveOnlyToolStripMenuItem";
            this.encryptSaveOnlyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.encryptSaveOnlyToolStripMenuItem.Text = "Encrypt Save only";
            this.encryptSaveOnlyToolStripMenuItem.Click += new System.EventHandler(this.encryptSaveOnlyToolStripMenuItem_Click);
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            this.helpStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpStripMenuItem.Text = "Help";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyMeACoffeeToolStripMenuItem,
            this.version01ToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Info";
            // 
            // buyMeACoffeeToolStripMenuItem
            // 
            this.buyMeACoffeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.buyMeACoffeeToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.buyMeACoffeeToolStripMenuItem.Name = "buyMeACoffeeToolStripMenuItem";
            this.buyMeACoffeeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.buyMeACoffeeToolStripMenuItem.Text = "Buy me a Coffee";
            this.buyMeACoffeeToolStripMenuItem.Click += new System.EventHandler(this.buyMeACoffeeToolStripMenuItem_Click);
            // 
            // version01ToolStripMenuItem
            // 
            this.version01ToolStripMenuItem.Enabled = false;
            this.version01ToolStripMenuItem.Name = "version01ToolStripMenuItem";
            this.version01ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.version01ToolStripMenuItem.Text = "Sheltered 2 SE Version 0.40";
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
            this.lblFirstname.Location = new System.Drawing.Point(25, 47);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(55, 13);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Firstname:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(25, 79);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(56, 13);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Lastname:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(25, 111);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(41, 13);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health:";
            // 
            // lblMaxHealth
            // 
            this.lblMaxHealth.AutoSize = true;
            this.lblMaxHealth.Location = new System.Drawing.Point(25, 143);
            this.lblMaxHealth.Name = "lblMaxHealth";
            this.lblMaxHealth.Size = new System.Drawing.Size(64, 13);
            this.lblMaxHealth.TabIndex = 3;
            this.lblMaxHealth.Text = "Max Health:";
            // 
            // txbFirstname
            // 
            this.txbFirstname.Location = new System.Drawing.Point(104, 44);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(258, 20);
            this.txbFirstname.TabIndex = 4;
            // 
            // txbLastname
            // 
            this.txbLastname.Location = new System.Drawing.Point(104, 76);
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.Size = new System.Drawing.Size(258, 20);
            this.txbLastname.TabIndex = 5;
            // 
            // txbMaxHealth
            // 
            this.txbMaxHealth.Location = new System.Drawing.Point(104, 140);
            this.txbMaxHealth.Name = "txbMaxHealth";
            this.txbMaxHealth.Size = new System.Drawing.Size(54, 20);
            this.txbMaxHealth.TabIndex = 6;
            // 
            // txbHealth
            // 
            this.txbHealth.Location = new System.Drawing.Point(104, 108);
            this.txbHealth.Name = "txbHealth";
            this.txbHealth.Size = new System.Drawing.Size(54, 20);
            this.txbHealth.TabIndex = 7;
            // 
            // cbxCharacterSelect
            // 
            this.cbxCharacterSelect.FormattingEnabled = true;
            this.cbxCharacterSelect.Location = new System.Drawing.Point(104, 9);
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
            this.lblCharacterStats.Location = new System.Drawing.Point(3, 286);
            this.lblCharacterStats.Name = "lblCharacterStats";
            this.lblCharacterStats.Size = new System.Drawing.Size(83, 13);
            this.lblCharacterStats.TabIndex = 9;
            this.lblCharacterStats.Text = "Character Stats:";
            // 
            // lblStrenght
            // 
            this.lblStrenght.AutoSize = true;
            this.lblStrenght.Location = new System.Drawing.Point(63, 324);
            this.lblStrenght.Name = "lblStrenght";
            this.lblStrenght.Size = new System.Drawing.Size(47, 13);
            this.lblStrenght.TabIndex = 10;
            this.lblStrenght.Text = "Strength";
            this.lblStrenght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Location = new System.Drawing.Point(122, 324);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(48, 13);
            this.lblDexterity.TabIndex = 11;
            this.lblDexterity.Text = "Dexterity";
            this.lblDexterity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(186, 324);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(61, 13);
            this.lblIntelligence.TabIndex = 12;
            this.lblIntelligence.Text = "Intelligence";
            this.lblIntelligence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Location = new System.Drawing.Point(263, 324);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(50, 13);
            this.lblCharisma.TabIndex = 13;
            this.lblCharisma.Text = "Charisma";
            this.lblCharisma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerception
            // 
            this.lblPerception.AutoSize = true;
            this.lblPerception.Location = new System.Drawing.Point(331, 324);
            this.lblPerception.Name = "lblPerception";
            this.lblPerception.Size = new System.Drawing.Size(58, 13);
            this.lblPerception.TabIndex = 14;
            this.lblPerception.Text = "Perception";
            this.lblPerception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFortitude
            // 
            this.lblFortitude.AutoSize = true;
            this.lblFortitude.Location = new System.Drawing.Point(407, 324);
            this.lblFortitude.Name = "lblFortitude";
            this.lblFortitude.Size = new System.Drawing.Size(48, 13);
            this.lblFortitude.TabIndex = 15;
            this.lblFortitude.Text = "Fortitude";
            this.lblFortitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbLevelStrenght
            // 
            this.txbLevelStrenght.Location = new System.Drawing.Point(59, 353);
            this.txbLevelStrenght.Name = "txbLevelStrenght";
            this.txbLevelStrenght.Size = new System.Drawing.Size(59, 20);
            this.txbLevelStrenght.TabIndex = 16;
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(5, 390);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(29, 13);
            this.lblCap.TabIndex = 17;
            this.lblCap.Text = "Cap:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(5, 356);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 18;
            this.lblLevel.Text = "Level:";
            // 
            // txbLevelDexterity
            // 
            this.txbLevelDexterity.Location = new System.Drawing.Point(122, 353);
            this.txbLevelDexterity.Name = "txbLevelDexterity";
            this.txbLevelDexterity.Size = new System.Drawing.Size(58, 20);
            this.txbLevelDexterity.TabIndex = 19;
            // 
            // txbLevelIntelligence
            // 
            this.txbLevelIntelligence.Location = new System.Drawing.Point(186, 353);
            this.txbLevelIntelligence.Name = "txbLevelIntelligence";
            this.txbLevelIntelligence.Size = new System.Drawing.Size(71, 20);
            this.txbLevelIntelligence.TabIndex = 20;
            // 
            // txbLevelCharisma
            // 
            this.txbLevelCharisma.Location = new System.Drawing.Point(263, 353);
            this.txbLevelCharisma.Name = "txbLevelCharisma";
            this.txbLevelCharisma.Size = new System.Drawing.Size(60, 20);
            this.txbLevelCharisma.TabIndex = 21;
            // 
            // txbLevelPerception
            // 
            this.txbLevelPerception.Location = new System.Drawing.Point(329, 353);
            this.txbLevelPerception.Name = "txbLevelPerception";
            this.txbLevelPerception.Size = new System.Drawing.Size(68, 20);
            this.txbLevelPerception.TabIndex = 22;
            // 
            // txbLevelFortitude
            // 
            this.txbLevelFortitude.Location = new System.Drawing.Point(403, 353);
            this.txbLevelFortitude.Name = "txbLevelFortitude";
            this.txbLevelFortitude.Size = new System.Drawing.Size(61, 20);
            this.txbLevelFortitude.TabIndex = 23;
            // 
            // txbCapFortitude
            // 
            this.txbCapFortitude.Location = new System.Drawing.Point(403, 387);
            this.txbCapFortitude.Name = "txbCapFortitude";
            this.txbCapFortitude.Size = new System.Drawing.Size(61, 20);
            this.txbCapFortitude.TabIndex = 29;
            // 
            // txbCapPerception
            // 
            this.txbCapPerception.Location = new System.Drawing.Point(329, 387);
            this.txbCapPerception.Name = "txbCapPerception";
            this.txbCapPerception.Size = new System.Drawing.Size(68, 20);
            this.txbCapPerception.TabIndex = 28;
            // 
            // txbCapCharisma
            // 
            this.txbCapCharisma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCapCharisma.Location = new System.Drawing.Point(263, 387);
            this.txbCapCharisma.Name = "txbCapCharisma";
            this.txbCapCharisma.Size = new System.Drawing.Size(60, 20);
            this.txbCapCharisma.TabIndex = 27;
            // 
            // txbCapIntelligence
            // 
            this.txbCapIntelligence.Location = new System.Drawing.Point(186, 387);
            this.txbCapIntelligence.Name = "txbCapIntelligence";
            this.txbCapIntelligence.Size = new System.Drawing.Size(71, 20);
            this.txbCapIntelligence.TabIndex = 26;
            // 
            // txbCapDexterity
            // 
            this.txbCapDexterity.Location = new System.Drawing.Point(122, 387);
            this.txbCapDexterity.Name = "txbCapDexterity";
            this.txbCapDexterity.Size = new System.Drawing.Size(58, 20);
            this.txbCapDexterity.TabIndex = 25;
            // 
            // txbCapStrenght
            // 
            this.txbCapStrenght.Location = new System.Drawing.Point(59, 387);
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
            this.btnUnstuckCharacter.Size = new System.Drawing.Size(139, 23);
            this.btnUnstuckCharacter.TabIndex = 31;
            this.btnUnstuckCharacter.Text = "Unstuck Character";
            this.btnUnstuckCharacter.UseVisualStyleBackColor = true;
            this.btnUnstuckCharacter.Click += new System.EventHandler(this.btnUnstuckCharacter_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(312, 442);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(280, 52);
            this.lblWarning.TabIndex = 33;
            this.lblWarning.Text = "WARNING\r\nThe \"Save Character\" doesn\'t save the XML, it just saves\r\nthe changes. W" +
    "hen done you still have to save using the \r\nmenu \"File\" then save\r\n";
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.Location = new System.Drawing.Point(195, 519);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(121, 26);
            this.btnSaveCharacter.TabIndex = 34;
            this.btnSaveCharacter.Text = "Save Character";
            this.btnSaveCharacter.UseVisualStyleBackColor = true;
            this.btnSaveCharacter.Click += new System.EventHandler(this.btnSaveCharacter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "debug button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.characterStatsTab);
            this.tabControlMain.Controls.Add(this.characterSkillsTab);
            this.tabControlMain.Controls.Add(this.petsTab);
            this.tabControlMain.Controls.Add(this.deseasesTab);
            this.tabControlMain.Controls.Add(this.unlockingTab);
            this.tabControlMain.Controls.Add(this.debugTab);
            this.tabControlMain.Controls.Add(this.shelterDesignerTab);
            this.tabControlMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlMain.Location = new System.Drawing.Point(317, 48);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(667, 582);
            this.tabControlMain.TabIndex = 37;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // characterStatsTab
            // 
            this.characterStatsTab.BackColor = System.Drawing.Color.LightGray;
            this.characterStatsTab.Controls.Add(this.btnMaxStats);
            this.characterStatsTab.Controls.Add(this.lblAnimTimeValue);
            this.characterStatsTab.Controls.Add(this.lblAnimTime);
            this.characterStatsTab.Controls.Add(this.lblAnimHashValue);
            this.characterStatsTab.Controls.Add(this.lblAnimHash);
            this.characterStatsTab.Controls.Add(this.cBHasBeenDefibbed);
            this.characterStatsTab.Controls.Add(this.cBInteractingWithObj);
            this.characterStatsTab.Controls.Add(this.cBInteracting);
            this.characterStatsTab.Controls.Add(this.btnSaveCharacter);
            this.characterStatsTab.Controls.Add(this.cbxCharacterSelect);
            this.characterStatsTab.Controls.Add(this.lblWarning);
            this.characterStatsTab.Controls.Add(this.lblFirstname);
            this.characterStatsTab.Controls.Add(this.pbxWarning);
            this.characterStatsTab.Controls.Add(this.lblLastname);
            this.characterStatsTab.Controls.Add(this.btnUnstuckCharacter);
            this.characterStatsTab.Controls.Add(this.lblHealth);
            this.characterStatsTab.Controls.Add(this.lblDebug);
            this.characterStatsTab.Controls.Add(this.lblMaxHealth);
            this.characterStatsTab.Controls.Add(this.txbCapFortitude);
            this.characterStatsTab.Controls.Add(this.txbFirstname);
            this.characterStatsTab.Controls.Add(this.txbCapPerception);
            this.characterStatsTab.Controls.Add(this.txbLastname);
            this.characterStatsTab.Controls.Add(this.txbCapCharisma);
            this.characterStatsTab.Controls.Add(this.txbMaxHealth);
            this.characterStatsTab.Controls.Add(this.txbCapIntelligence);
            this.characterStatsTab.Controls.Add(this.txbHealth);
            this.characterStatsTab.Controls.Add(this.txbCapDexterity);
            this.characterStatsTab.Controls.Add(this.lblCharacterStats);
            this.characterStatsTab.Controls.Add(this.txbCapStrenght);
            this.characterStatsTab.Controls.Add(this.lblStrenght);
            this.characterStatsTab.Controls.Add(this.txbLevelFortitude);
            this.characterStatsTab.Controls.Add(this.lblDexterity);
            this.characterStatsTab.Controls.Add(this.txbLevelPerception);
            this.characterStatsTab.Controls.Add(this.lblIntelligence);
            this.characterStatsTab.Controls.Add(this.txbLevelCharisma);
            this.characterStatsTab.Controls.Add(this.lblCharisma);
            this.characterStatsTab.Controls.Add(this.txbLevelIntelligence);
            this.characterStatsTab.Controls.Add(this.lblPerception);
            this.characterStatsTab.Controls.Add(this.txbLevelDexterity);
            this.characterStatsTab.Controls.Add(this.lblFortitude);
            this.characterStatsTab.Controls.Add(this.lblLevel);
            this.characterStatsTab.Controls.Add(this.txbLevelStrenght);
            this.characterStatsTab.Controls.Add(this.lblCap);
            this.characterStatsTab.Location = new System.Drawing.Point(4, 22);
            this.characterStatsTab.Name = "characterStatsTab";
            this.characterStatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.characterStatsTab.Size = new System.Drawing.Size(659, 556);
            this.characterStatsTab.TabIndex = 0;
            this.characterStatsTab.Text = "Characters Stats";
            // 
            // btnMaxStats
            // 
            this.btnMaxStats.Location = new System.Drawing.Point(135, 287);
            this.btnMaxStats.Name = "btnMaxStats";
            this.btnMaxStats.Size = new System.Drawing.Size(72, 26);
            this.btnMaxStats.TabIndex = 42;
            this.btnMaxStats.Text = "Max Stats";
            this.btnMaxStats.UseVisualStyleBackColor = true;
            this.btnMaxStats.Click += new System.EventHandler(this.btnMaxStats_Click);
            // 
            // lblAnimTimeValue
            // 
            this.lblAnimTimeValue.AutoSize = true;
            this.lblAnimTimeValue.Location = new System.Drawing.Point(67, 506);
            this.lblAnimTimeValue.Name = "lblAnimTimeValue";
            this.lblAnimTimeValue.Size = new System.Drawing.Size(0, 13);
            this.lblAnimTimeValue.TabIndex = 41;
            // 
            // lblAnimTime
            // 
            this.lblAnimTime.AutoSize = true;
            this.lblAnimTime.Location = new System.Drawing.Point(6, 506);
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
            this.cBHasBeenDefibbed.Location = new System.Drawing.Point(288, 207);
            this.cBHasBeenDefibbed.Name = "cBHasBeenDefibbed";
            this.cBHasBeenDefibbed.Size = new System.Drawing.Size(126, 17);
            this.cBHasBeenDefibbed.TabIndex = 37;
            this.cBHasBeenDefibbed.Text = "Has been defibrilated";
            this.cBHasBeenDefibbed.UseVisualStyleBackColor = true;
            // 
            // cBInteractingWithObj
            // 
            this.cBInteractingWithObj.AutoSize = true;
            this.cBInteractingWithObj.Location = new System.Drawing.Point(126, 207);
            this.cBInteractingWithObj.Name = "cBInteractingWithObj";
            this.cBInteractingWithObj.Size = new System.Drawing.Size(132, 17);
            this.cBInteractingWithObj.TabIndex = 36;
            this.cBInteractingWithObj.Text = "Interacting with Object";
            this.cBInteractingWithObj.UseVisualStyleBackColor = true;
            // 
            // cBInteracting
            // 
            this.cBInteracting.AutoSize = true;
            this.cBInteracting.Location = new System.Drawing.Point(29, 207);
            this.cBInteracting.Name = "cBInteracting";
            this.cBInteracting.Size = new System.Drawing.Size(76, 17);
            this.cBInteracting.TabIndex = 35;
            this.cBInteracting.Text = "Interacting";
            this.cBInteracting.UseVisualStyleBackColor = true;
            // 
            // pbxWarning
            // 
            this.pbxWarning.BackColor = System.Drawing.SystemColors.Control;
            this.pbxWarning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxWarning.Image = ((System.Drawing.Image)(resources.GetObject("pbxWarning.Image")));
            this.pbxWarning.Location = new System.Drawing.Point(273, 442);
            this.pbxWarning.Name = "pbxWarning";
            this.pbxWarning.Size = new System.Drawing.Size(33, 32);
            this.pbxWarning.TabIndex = 32;
            this.pbxWarning.TabStop = false;
            // 
            // characterSkillsTab
            // 
            this.characterSkillsTab.BackColor = System.Drawing.Color.LightGray;
            this.characterSkillsTab.Controls.Add(this.btnMaxAllSkills);
            this.characterSkillsTab.Controls.Add(this.btnSaveCharacterSkills);
            this.characterSkillsTab.Controls.Add(this.tabControlSkills);
            this.characterSkillsTab.Controls.Add(this.lblSkillsCharacterName);
            this.characterSkillsTab.Controls.Add(this.cbxSkillsCharacterSelect);
            this.characterSkillsTab.Location = new System.Drawing.Point(4, 22);
            this.characterSkillsTab.Name = "characterSkillsTab";
            this.characterSkillsTab.Padding = new System.Windows.Forms.Padding(3);
            this.characterSkillsTab.Size = new System.Drawing.Size(659, 556);
            this.characterSkillsTab.TabIndex = 1;
            this.characterSkillsTab.Text = "Character Skills";
            // 
            // btnSaveCharacterSkills
            // 
            this.btnSaveCharacterSkills.Location = new System.Drawing.Point(239, 507);
            this.btnSaveCharacterSkills.Name = "btnSaveCharacterSkills";
            this.btnSaveCharacterSkills.Size = new System.Drawing.Size(184, 26);
            this.btnSaveCharacterSkills.TabIndex = 12;
            this.btnSaveCharacterSkills.Text = "Save Character Skills";
            this.btnSaveCharacterSkills.UseVisualStyleBackColor = true;
            this.btnSaveCharacterSkills.Visible = false;
            this.btnSaveCharacterSkills.Click += new System.EventHandler(this.btnSaveCharacterSkills_Click);
            // 
            // tabControlSkills
            // 
            this.tabControlSkills.Controls.Add(this.skillPageStr);
            this.tabControlSkills.Controls.Add(this.skillPageDex);
            this.tabControlSkills.Controls.Add(this.skillPageInt);
            this.tabControlSkills.Controls.Add(this.skillPageCha);
            this.tabControlSkills.Controls.Add(this.skillPagePer);
            this.tabControlSkills.Controls.Add(this.skillPageFor);
            this.tabControlSkills.HotTrack = true;
            this.tabControlSkills.ImageList = this.tabIcons;
            this.tabControlSkills.ItemSize = new System.Drawing.Size(70, 18);
            this.tabControlSkills.Location = new System.Drawing.Point(0, 51);
            this.tabControlSkills.Name = "tabControlSkills";
            this.tabControlSkills.Padding = new System.Drawing.Point(5, 3);
            this.tabControlSkills.SelectedIndex = 0;
            this.tabControlSkills.Size = new System.Drawing.Size(663, 339);
            this.tabControlSkills.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlSkills.TabIndex = 11;
            this.tabControlSkills.Tag = "2";
            this.tabControlSkills.Visible = false;
            this.tabControlSkills.SelectedIndexChanged += new System.EventHandler(this.tabControlSkills_SelectedIndexChanged);
            // 
            // skillPageStr
            // 
            this.skillPageStr.Controls.Add(this.lblPointsAvailableStrValue);
            this.skillPageStr.Controls.Add(this.lblPointsAvailableStrName);
            this.skillPageStr.Controls.Add(this.pbxAvailablePointsStr);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel14);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel13);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel12);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel11);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel10);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel9);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel8);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel7);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel6);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel5);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel4);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel3);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel2);
            this.skillPageStr.Controls.Add(this.pbxStrSkillLevel1);
            this.skillPageStr.Controls.Add(this.pbxStrSkill14);
            this.skillPageStr.Controls.Add(this.pbxStrSkill13);
            this.skillPageStr.Controls.Add(this.pbxStrSkill12);
            this.skillPageStr.Controls.Add(this.pbxStrSkill11);
            this.skillPageStr.Controls.Add(this.pbxStrSkill10);
            this.skillPageStr.Controls.Add(this.pbxStrSkill9);
            this.skillPageStr.Controls.Add(this.pbxStrSkill8);
            this.skillPageStr.Controls.Add(this.lblStrTier3);
            this.skillPageStr.Controls.Add(this.lblStrTier2);
            this.skillPageStr.Controls.Add(this.lblStrTier1);
            this.skillPageStr.Controls.Add(this.pbxStrSkill7);
            this.skillPageStr.Controls.Add(this.pbxStrSkill6);
            this.skillPageStr.Controls.Add(this.pbxStrSkill5);
            this.skillPageStr.Controls.Add(this.pbxStrSkill4);
            this.skillPageStr.Controls.Add(this.pbxStrSkill3);
            this.skillPageStr.Controls.Add(this.pbxStrSkill2);
            this.skillPageStr.Controls.Add(this.pbxStrSkill1);
            this.skillPageStr.ImageIndex = 0;
            this.skillPageStr.Location = new System.Drawing.Point(4, 22);
            this.skillPageStr.Name = "skillPageStr";
            this.skillPageStr.Padding = new System.Windows.Forms.Padding(3);
            this.skillPageStr.Size = new System.Drawing.Size(655, 313);
            this.skillPageStr.TabIndex = 0;
            this.skillPageStr.Tag = "Str";
            this.skillPageStr.Text = "Strength";
            this.skillPageStr.UseVisualStyleBackColor = true;
            // 
            // lblPointsAvailableStrValue
            // 
            this.lblPointsAvailableStrValue.AutoSize = true;
            this.lblPointsAvailableStrValue.Location = new System.Drawing.Point(584, 246);
            this.lblPointsAvailableStrValue.Name = "lblPointsAvailableStrValue";
            this.lblPointsAvailableStrValue.Size = new System.Drawing.Size(0, 13);
            this.lblPointsAvailableStrValue.TabIndex = 71;
            // 
            // lblPointsAvailableStrName
            // 
            this.lblPointsAvailableStrName.AutoSize = true;
            this.lblPointsAvailableStrName.Location = new System.Drawing.Point(546, 224);
            this.lblPointsAvailableStrName.Name = "lblPointsAvailableStrName";
            this.lblPointsAvailableStrName.Size = new System.Drawing.Size(82, 13);
            this.lblPointsAvailableStrName.TabIndex = 70;
            this.lblPointsAvailableStrName.Text = "Points Available";
            // 
            // pbxAvailablePointsStr
            // 
            this.pbxAvailablePointsStr.BackgroundImage = global::Sheltered_2_SE.Properties.Resources.AvailableSkillsStr;
            this.pbxAvailablePointsStr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxAvailablePointsStr.Location = new System.Drawing.Point(547, 131);
            this.pbxAvailablePointsStr.Name = "pbxAvailablePointsStr";
            this.pbxAvailablePointsStr.Size = new System.Drawing.Size(90, 90);
            this.pbxAvailablePointsStr.TabIndex = 72;
            this.pbxAvailablePointsStr.TabStop = false;
            // 
            // pbxStrSkillLevel14
            // 
            this.pbxStrSkillLevel14.AccessibleDescription = "37";
            this.pbxStrSkillLevel14.AccessibleName = "0";
            this.pbxStrSkillLevel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel14.Location = new System.Drawing.Point(369, 267);
            this.pbxStrSkillLevel14.Name = "pbxStrSkillLevel14";
            this.pbxStrSkillLevel14.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel14.TabIndex = 68;
            this.pbxStrSkillLevel14.TabStop = false;
            this.pbxStrSkillLevel14.Tag = "2";
            // 
            // pbxStrSkillLevel13
            // 
            this.pbxStrSkillLevel13.AccessibleDescription = "31";
            this.pbxStrSkillLevel13.AccessibleName = "0";
            this.pbxStrSkillLevel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel13.Location = new System.Drawing.Point(302, 267);
            this.pbxStrSkillLevel13.Name = "pbxStrSkillLevel13";
            this.pbxStrSkillLevel13.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel13.TabIndex = 67;
            this.pbxStrSkillLevel13.TabStop = false;
            this.pbxStrSkillLevel13.Tag = "2";
            // 
            // pbxStrSkillLevel12
            // 
            this.pbxStrSkillLevel12.AccessibleDescription = "24";
            this.pbxStrSkillLevel12.AccessibleName = "0";
            this.pbxStrSkillLevel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel12.Location = new System.Drawing.Point(235, 267);
            this.pbxStrSkillLevel12.Name = "pbxStrSkillLevel12";
            this.pbxStrSkillLevel12.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel12.TabIndex = 66;
            this.pbxStrSkillLevel12.TabStop = false;
            this.pbxStrSkillLevel12.Tag = "1";
            // 
            // pbxStrSkillLevel11
            // 
            this.pbxStrSkillLevel11.AccessibleDescription = "8";
            this.pbxStrSkillLevel11.AccessibleName = "0";
            this.pbxStrSkillLevel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel11.Location = new System.Drawing.Point(403, 173);
            this.pbxStrSkillLevel11.Name = "pbxStrSkillLevel11";
            this.pbxStrSkillLevel11.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel11.TabIndex = 60;
            this.pbxStrSkillLevel11.TabStop = false;
            this.pbxStrSkillLevel11.Tag = "2";
            // 
            // pbxStrSkillLevel10
            // 
            this.pbxStrSkillLevel10.AccessibleDescription = "0";
            this.pbxStrSkillLevel10.AccessibleName = "0";
            this.pbxStrSkillLevel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel10.Location = new System.Drawing.Point(336, 173);
            this.pbxStrSkillLevel10.Name = "pbxStrSkillLevel10";
            this.pbxStrSkillLevel10.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel10.TabIndex = 59;
            this.pbxStrSkillLevel10.TabStop = false;
            this.pbxStrSkillLevel10.Tag = "2";
            // 
            // pbxStrSkillLevel9
            // 
            this.pbxStrSkillLevel9.AccessibleDescription = "42";
            this.pbxStrSkillLevel9.AccessibleName = "0";
            this.pbxStrSkillLevel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel9.Location = new System.Drawing.Point(269, 173);
            this.pbxStrSkillLevel9.Name = "pbxStrSkillLevel9";
            this.pbxStrSkillLevel9.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel9.TabIndex = 58;
            this.pbxStrSkillLevel9.TabStop = false;
            this.pbxStrSkillLevel9.Tag = "2";
            // 
            // pbxStrSkillLevel8
            // 
            this.pbxStrSkillLevel8.AccessibleDescription = "4";
            this.pbxStrSkillLevel8.AccessibleName = "0";
            this.pbxStrSkillLevel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel8.Location = new System.Drawing.Point(202, 173);
            this.pbxStrSkillLevel8.Name = "pbxStrSkillLevel8";
            this.pbxStrSkillLevel8.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel8.TabIndex = 57;
            this.pbxStrSkillLevel8.TabStop = false;
            this.pbxStrSkillLevel8.Tag = "2";
            // 
            // pbxStrSkillLevel7
            // 
            this.pbxStrSkillLevel7.AccessibleDescription = "25";
            this.pbxStrSkillLevel7.AccessibleName = "0";
            this.pbxStrSkillLevel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel7.Location = new System.Drawing.Point(503, 79);
            this.pbxStrSkillLevel7.Name = "pbxStrSkillLevel7";
            this.pbxStrSkillLevel7.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel7.TabIndex = 54;
            this.pbxStrSkillLevel7.TabStop = false;
            this.pbxStrSkillLevel7.Tag = "0";
            // 
            // pbxStrSkillLevel6
            // 
            this.pbxStrSkillLevel6.AccessibleDescription = "28";
            this.pbxStrSkillLevel6.AccessibleName = "0";
            this.pbxStrSkillLevel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel6.Location = new System.Drawing.Point(436, 79);
            this.pbxStrSkillLevel6.Name = "pbxStrSkillLevel6";
            this.pbxStrSkillLevel6.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel6.TabIndex = 53;
            this.pbxStrSkillLevel6.TabStop = false;
            this.pbxStrSkillLevel6.Tag = "2";
            // 
            // pbxStrSkillLevel5
            // 
            this.pbxStrSkillLevel5.AccessibleDescription = "30";
            this.pbxStrSkillLevel5.AccessibleName = "0";
            this.pbxStrSkillLevel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel5.Location = new System.Drawing.Point(369, 79);
            this.pbxStrSkillLevel5.Name = "pbxStrSkillLevel5";
            this.pbxStrSkillLevel5.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel5.TabIndex = 52;
            this.pbxStrSkillLevel5.TabStop = false;
            this.pbxStrSkillLevel5.Tag = "2";
            // 
            // pbxStrSkillLevel4
            // 
            this.pbxStrSkillLevel4.AccessibleDescription = "41";
            this.pbxStrSkillLevel4.AccessibleName = "0";
            this.pbxStrSkillLevel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel4.Location = new System.Drawing.Point(302, 79);
            this.pbxStrSkillLevel4.Name = "pbxStrSkillLevel4";
            this.pbxStrSkillLevel4.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel4.TabIndex = 51;
            this.pbxStrSkillLevel4.TabStop = false;
            this.pbxStrSkillLevel4.Tag = "0";
            // 
            // pbxStrSkillLevel3
            // 
            this.pbxStrSkillLevel3.AccessibleDescription = "12";
            this.pbxStrSkillLevel3.AccessibleName = "0";
            this.pbxStrSkillLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel3.Location = new System.Drawing.Point(235, 79);
            this.pbxStrSkillLevel3.Name = "pbxStrSkillLevel3";
            this.pbxStrSkillLevel3.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel3.TabIndex = 50;
            this.pbxStrSkillLevel3.TabStop = false;
            this.pbxStrSkillLevel3.Tag = "2";
            // 
            // pbxStrSkillLevel2
            // 
            this.pbxStrSkillLevel2.AccessibleDescription = "19";
            this.pbxStrSkillLevel2.AccessibleName = "0";
            this.pbxStrSkillLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel2.Location = new System.Drawing.Point(168, 79);
            this.pbxStrSkillLevel2.Name = "pbxStrSkillLevel2";
            this.pbxStrSkillLevel2.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel2.TabIndex = 49;
            this.pbxStrSkillLevel2.TabStop = false;
            this.pbxStrSkillLevel2.Tag = "2";
            // 
            // pbxStrSkillLevel1
            // 
            this.pbxStrSkillLevel1.AccessibleDescription = "15";
            this.pbxStrSkillLevel1.AccessibleName = "0";
            this.pbxStrSkillLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkillLevel1.Location = new System.Drawing.Point(101, 79);
            this.pbxStrSkillLevel1.Name = "pbxStrSkillLevel1";
            this.pbxStrSkillLevel1.Size = new System.Drawing.Size(50, 18);
            this.pbxStrSkillLevel1.TabIndex = 48;
            this.pbxStrSkillLevel1.TabStop = false;
            this.pbxStrSkillLevel1.Tag = "2";
            // 
            // pbxStrSkill14
            // 
            this.pbxStrSkill14.AccessibleDescription = "";
            this.pbxStrSkill14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill14.Location = new System.Drawing.Point(369, 218);
            this.pbxStrSkill14.Name = "pbxStrSkill14";
            this.pbxStrSkill14.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill14.TabIndex = 41;
            this.pbxStrSkill14.TabStop = false;
            // 
            // pbxStrSkill13
            // 
            this.pbxStrSkill13.AccessibleDescription = "";
            this.pbxStrSkill13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill13.Location = new System.Drawing.Point(302, 218);
            this.pbxStrSkill13.Name = "pbxStrSkill13";
            this.pbxStrSkill13.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill13.TabIndex = 40;
            this.pbxStrSkill13.TabStop = false;
            // 
            // pbxStrSkill12
            // 
            this.pbxStrSkill12.AccessibleDescription = "";
            this.pbxStrSkill12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill12.Location = new System.Drawing.Point(235, 218);
            this.pbxStrSkill12.Name = "pbxStrSkill12";
            this.pbxStrSkill12.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill12.TabIndex = 39;
            this.pbxStrSkill12.TabStop = false;
            // 
            // pbxStrSkill11
            // 
            this.pbxStrSkill11.AccessibleDescription = "";
            this.pbxStrSkill11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill11.Location = new System.Drawing.Point(403, 124);
            this.pbxStrSkill11.Name = "pbxStrSkill11";
            this.pbxStrSkill11.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill11.TabIndex = 33;
            this.pbxStrSkill11.TabStop = false;
            // 
            // pbxStrSkill10
            // 
            this.pbxStrSkill10.AccessibleDescription = "";
            this.pbxStrSkill10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill10.Location = new System.Drawing.Point(336, 124);
            this.pbxStrSkill10.Name = "pbxStrSkill10";
            this.pbxStrSkill10.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill10.TabIndex = 32;
            this.pbxStrSkill10.TabStop = false;
            // 
            // pbxStrSkill9
            // 
            this.pbxStrSkill9.AccessibleDescription = "";
            this.pbxStrSkill9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill9.Location = new System.Drawing.Point(269, 124);
            this.pbxStrSkill9.Name = "pbxStrSkill9";
            this.pbxStrSkill9.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill9.TabIndex = 31;
            this.pbxStrSkill9.TabStop = false;
            // 
            // pbxStrSkill8
            // 
            this.pbxStrSkill8.AccessibleDescription = "";
            this.pbxStrSkill8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill8.Location = new System.Drawing.Point(202, 124);
            this.pbxStrSkill8.Name = "pbxStrSkill8";
            this.pbxStrSkill8.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill8.TabIndex = 30;
            this.pbxStrSkill8.TabStop = false;
            // 
            // lblStrTier3
            // 
            this.lblStrTier3.AutoSize = true;
            this.lblStrTier3.Location = new System.Drawing.Point(5, 232);
            this.lblStrTier3.Name = "lblStrTier3";
            this.lblStrTier3.Size = new System.Drawing.Size(41, 13);
            this.lblStrTier3.TabIndex = 27;
            this.lblStrTier3.Text = "TIER 3";
            // 
            // lblStrTier2
            // 
            this.lblStrTier2.AutoSize = true;
            this.lblStrTier2.Location = new System.Drawing.Point(6, 136);
            this.lblStrTier2.Name = "lblStrTier2";
            this.lblStrTier2.Size = new System.Drawing.Size(41, 13);
            this.lblStrTier2.TabIndex = 26;
            this.lblStrTier2.Text = "TIER 2";
            // 
            // lblStrTier1
            // 
            this.lblStrTier1.AutoSize = true;
            this.lblStrTier1.Location = new System.Drawing.Point(6, 40);
            this.lblStrTier1.Name = "lblStrTier1";
            this.lblStrTier1.Size = new System.Drawing.Size(41, 13);
            this.lblStrTier1.TabIndex = 18;
            this.lblStrTier1.Text = "TIER 1";
            // 
            // pbxStrSkill7
            // 
            this.pbxStrSkill7.AccessibleDescription = "";
            this.pbxStrSkill7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill7.Location = new System.Drawing.Point(503, 30);
            this.pbxStrSkill7.Name = "pbxStrSkill7";
            this.pbxStrSkill7.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill7.TabIndex = 17;
            this.pbxStrSkill7.TabStop = false;
            // 
            // pbxStrSkill6
            // 
            this.pbxStrSkill6.AccessibleDescription = "";
            this.pbxStrSkill6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill6.Location = new System.Drawing.Point(436, 30);
            this.pbxStrSkill6.Name = "pbxStrSkill6";
            this.pbxStrSkill6.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill6.TabIndex = 16;
            this.pbxStrSkill6.TabStop = false;
            // 
            // pbxStrSkill5
            // 
            this.pbxStrSkill5.AccessibleDescription = "";
            this.pbxStrSkill5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill5.Location = new System.Drawing.Point(369, 30);
            this.pbxStrSkill5.Name = "pbxStrSkill5";
            this.pbxStrSkill5.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill5.TabIndex = 15;
            this.pbxStrSkill5.TabStop = false;
            // 
            // pbxStrSkill4
            // 
            this.pbxStrSkill4.AccessibleDescription = "";
            this.pbxStrSkill4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill4.Location = new System.Drawing.Point(302, 30);
            this.pbxStrSkill4.Name = "pbxStrSkill4";
            this.pbxStrSkill4.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill4.TabIndex = 14;
            this.pbxStrSkill4.TabStop = false;
            // 
            // pbxStrSkill3
            // 
            this.pbxStrSkill3.AccessibleDescription = "";
            this.pbxStrSkill3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill3.Location = new System.Drawing.Point(235, 30);
            this.pbxStrSkill3.Name = "pbxStrSkill3";
            this.pbxStrSkill3.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill3.TabIndex = 13;
            this.pbxStrSkill3.TabStop = false;
            // 
            // pbxStrSkill2
            // 
            this.pbxStrSkill2.AccessibleDescription = "";
            this.pbxStrSkill2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill2.Location = new System.Drawing.Point(168, 30);
            this.pbxStrSkill2.Name = "pbxStrSkill2";
            this.pbxStrSkill2.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrSkill2.TabIndex = 12;
            this.pbxStrSkill2.TabStop = false;
            // 
            // pbxStrSkill1
            // 
            this.pbxStrSkill1.AccessibleDescription = "";
            this.pbxStrSkill1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxStrSkill1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStrSkill1.Location = new System.Drawing.Point(101, 30);
            this.pbxStrSkill1.Name = "pbxStrSkill1";
            this.pbxStrSkill1.Size = new System.Drawing.Size(50, 50);
            this.pbxStrSkill1.TabIndex = 11;
            this.pbxStrSkill1.TabStop = false;
            this.pbxStrSkill1.Tag = "";
            this.tTStrSkill1.SetToolTip(this.pbxStrSkill1, "Attack Skill\r\n\r\na jab to the targets Windpipe, \r\ncausing the winded status effect" +
        ".");
            // 
            // skillPageDex
            // 
            this.skillPageDex.Controls.Add(this.lblPointsAvailableDexValue);
            this.skillPageDex.Controls.Add(this.lblPointsAvailableDexName);
            this.skillPageDex.Controls.Add(this.lblDexTier3);
            this.skillPageDex.Controls.Add(this.lblDexTier2);
            this.skillPageDex.Controls.Add(this.lblDexTier1);
            this.skillPageDex.Controls.Add(this.pbxAvailablePointsDex);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel12);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel11);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel10);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel9);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel8);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel7);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel6);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel5);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel4);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel3);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel2);
            this.skillPageDex.Controls.Add(this.pbxDexSkillLevel1);
            this.skillPageDex.Controls.Add(this.pbxDexSkill12);
            this.skillPageDex.Controls.Add(this.pbxDexSkill11);
            this.skillPageDex.Controls.Add(this.pbxDexSkill10);
            this.skillPageDex.Controls.Add(this.pbxDexSkill9);
            this.skillPageDex.Controls.Add(this.pbxDexSkill8);
            this.skillPageDex.Controls.Add(this.pbxDexSkill7);
            this.skillPageDex.Controls.Add(this.pbxDexSkill6);
            this.skillPageDex.Controls.Add(this.pbxDexSkill5);
            this.skillPageDex.Controls.Add(this.pbxDexSkill4);
            this.skillPageDex.Controls.Add(this.pbxDexSkill3);
            this.skillPageDex.Controls.Add(this.pbxDexSkill2);
            this.skillPageDex.Controls.Add(this.pbxDexSkill1);
            this.skillPageDex.ImageIndex = 1;
            this.skillPageDex.Location = new System.Drawing.Point(4, 22);
            this.skillPageDex.Name = "skillPageDex";
            this.skillPageDex.Padding = new System.Windows.Forms.Padding(3);
            this.skillPageDex.Size = new System.Drawing.Size(655, 313);
            this.skillPageDex.TabIndex = 1;
            this.skillPageDex.Tag = "Dex";
            this.skillPageDex.Text = "Dexterity";
            this.skillPageDex.UseVisualStyleBackColor = true;
            // 
            // lblPointsAvailableDexValue
            // 
            this.lblPointsAvailableDexValue.AutoSize = true;
            this.lblPointsAvailableDexValue.Location = new System.Drawing.Point(584, 246);
            this.lblPointsAvailableDexValue.Name = "lblPointsAvailableDexValue";
            this.lblPointsAvailableDexValue.Size = new System.Drawing.Size(0, 13);
            this.lblPointsAvailableDexValue.TabIndex = 128;
            // 
            // lblPointsAvailableDexName
            // 
            this.lblPointsAvailableDexName.AutoSize = true;
            this.lblPointsAvailableDexName.Location = new System.Drawing.Point(546, 224);
            this.lblPointsAvailableDexName.Name = "lblPointsAvailableDexName";
            this.lblPointsAvailableDexName.Size = new System.Drawing.Size(82, 13);
            this.lblPointsAvailableDexName.TabIndex = 127;
            this.lblPointsAvailableDexName.Text = "Points Available";
            // 
            // lblDexTier3
            // 
            this.lblDexTier3.AutoSize = true;
            this.lblDexTier3.Location = new System.Drawing.Point(5, 232);
            this.lblDexTier3.Name = "lblDexTier3";
            this.lblDexTier3.Size = new System.Drawing.Size(41, 13);
            this.lblDexTier3.TabIndex = 84;
            this.lblDexTier3.Text = "TIER 3";
            // 
            // lblDexTier2
            // 
            this.lblDexTier2.AutoSize = true;
            this.lblDexTier2.Location = new System.Drawing.Point(6, 136);
            this.lblDexTier2.Name = "lblDexTier2";
            this.lblDexTier2.Size = new System.Drawing.Size(41, 13);
            this.lblDexTier2.TabIndex = 83;
            this.lblDexTier2.Text = "TIER 2";
            // 
            // lblDexTier1
            // 
            this.lblDexTier1.AutoSize = true;
            this.lblDexTier1.Location = new System.Drawing.Point(6, 40);
            this.lblDexTier1.Name = "lblDexTier1";
            this.lblDexTier1.Size = new System.Drawing.Size(41, 13);
            this.lblDexTier1.TabIndex = 82;
            this.lblDexTier1.Text = "TIER 1";
            // 
            // pbxAvailablePointsDex
            // 
            this.pbxAvailablePointsDex.BackgroundImage = global::Sheltered_2_SE.Properties.Resources.AvailableSkillsDex;
            this.pbxAvailablePointsDex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxAvailablePointsDex.Location = new System.Drawing.Point(547, 131);
            this.pbxAvailablePointsDex.Name = "pbxAvailablePointsDex";
            this.pbxAvailablePointsDex.Size = new System.Drawing.Size(90, 90);
            this.pbxAvailablePointsDex.TabIndex = 129;
            this.pbxAvailablePointsDex.TabStop = false;
            // 
            // pbxDexSkillLevel12
            // 
            this.pbxDexSkillLevel12.AccessibleDescription = "104";
            this.pbxDexSkillLevel12.AccessibleName = "0";
            this.pbxDexSkillLevel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel12.Location = new System.Drawing.Point(369, 267);
            this.pbxDexSkillLevel12.Name = "pbxDexSkillLevel12";
            this.pbxDexSkillLevel12.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel12.TabIndex = 125;
            this.pbxDexSkillLevel12.TabStop = false;
            this.pbxDexSkillLevel12.Tag = "0";
            // 
            // pbxDexSkillLevel11
            // 
            this.pbxDexSkillLevel11.AccessibleDescription = "106";
            this.pbxDexSkillLevel11.AccessibleName = "0";
            this.pbxDexSkillLevel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel11.Location = new System.Drawing.Point(302, 267);
            this.pbxDexSkillLevel11.Name = "pbxDexSkillLevel11";
            this.pbxDexSkillLevel11.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel11.TabIndex = 124;
            this.pbxDexSkillLevel11.TabStop = false;
            this.pbxDexSkillLevel11.Tag = "0";
            // 
            // pbxDexSkillLevel10
            // 
            this.pbxDexSkillLevel10.AccessibleDescription = "127";
            this.pbxDexSkillLevel10.AccessibleName = "0";
            this.pbxDexSkillLevel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel10.Location = new System.Drawing.Point(235, 267);
            this.pbxDexSkillLevel10.Name = "pbxDexSkillLevel10";
            this.pbxDexSkillLevel10.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel10.TabIndex = 123;
            this.pbxDexSkillLevel10.TabStop = false;
            this.pbxDexSkillLevel10.Tag = "2";
            // 
            // pbxDexSkillLevel9
            // 
            this.pbxDexSkillLevel9.AccessibleDescription = "139";
            this.pbxDexSkillLevel9.AccessibleName = "0";
            this.pbxDexSkillLevel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel9.Location = new System.Drawing.Point(369, 173);
            this.pbxDexSkillLevel9.Name = "pbxDexSkillLevel9";
            this.pbxDexSkillLevel9.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel9.TabIndex = 116;
            this.pbxDexSkillLevel9.TabStop = false;
            this.pbxDexSkillLevel9.Tag = "2";
            // 
            // pbxDexSkillLevel8
            // 
            this.pbxDexSkillLevel8.AccessibleDescription = "115";
            this.pbxDexSkillLevel8.AccessibleName = "0";
            this.pbxDexSkillLevel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel8.Location = new System.Drawing.Point(302, 173);
            this.pbxDexSkillLevel8.Name = "pbxDexSkillLevel8";
            this.pbxDexSkillLevel8.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel8.TabIndex = 115;
            this.pbxDexSkillLevel8.TabStop = false;
            this.pbxDexSkillLevel8.Tag = "2";
            // 
            // pbxDexSkillLevel7
            // 
            this.pbxDexSkillLevel7.AccessibleDescription = "100";
            this.pbxDexSkillLevel7.AccessibleName = "0";
            this.pbxDexSkillLevel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel7.Location = new System.Drawing.Point(235, 173);
            this.pbxDexSkillLevel7.Name = "pbxDexSkillLevel7";
            this.pbxDexSkillLevel7.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel7.TabIndex = 114;
            this.pbxDexSkillLevel7.TabStop = false;
            this.pbxDexSkillLevel7.Tag = "2";
            // 
            // pbxDexSkillLevel6
            // 
            this.pbxDexSkillLevel6.AccessibleDescription = "122";
            this.pbxDexSkillLevel6.AccessibleName = "0";
            this.pbxDexSkillLevel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel6.Location = new System.Drawing.Point(470, 79);
            this.pbxDexSkillLevel6.Name = "pbxDexSkillLevel6";
            this.pbxDexSkillLevel6.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel6.TabIndex = 110;
            this.pbxDexSkillLevel6.TabStop = false;
            this.pbxDexSkillLevel6.Tag = "2";
            // 
            // pbxDexSkillLevel5
            // 
            this.pbxDexSkillLevel5.AccessibleDescription = "110";
            this.pbxDexSkillLevel5.AccessibleName = "0";
            this.pbxDexSkillLevel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel5.Location = new System.Drawing.Point(403, 79);
            this.pbxDexSkillLevel5.Name = "pbxDexSkillLevel5";
            this.pbxDexSkillLevel5.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel5.TabIndex = 109;
            this.pbxDexSkillLevel5.TabStop = false;
            this.pbxDexSkillLevel5.Tag = "2";
            // 
            // pbxDexSkillLevel4
            // 
            this.pbxDexSkillLevel4.AccessibleDescription = "143";
            this.pbxDexSkillLevel4.AccessibleName = "0";
            this.pbxDexSkillLevel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel4.Location = new System.Drawing.Point(336, 79);
            this.pbxDexSkillLevel4.Name = "pbxDexSkillLevel4";
            this.pbxDexSkillLevel4.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel4.TabIndex = 108;
            this.pbxDexSkillLevel4.TabStop = false;
            this.pbxDexSkillLevel4.Tag = "2";
            // 
            // pbxDexSkillLevel3
            // 
            this.pbxDexSkillLevel3.AccessibleDescription = "131";
            this.pbxDexSkillLevel3.AccessibleName = "0";
            this.pbxDexSkillLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel3.Location = new System.Drawing.Point(269, 79);
            this.pbxDexSkillLevel3.Name = "pbxDexSkillLevel3";
            this.pbxDexSkillLevel3.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel3.TabIndex = 107;
            this.pbxDexSkillLevel3.TabStop = false;
            this.pbxDexSkillLevel3.Tag = "2";
            // 
            // pbxDexSkillLevel2
            // 
            this.pbxDexSkillLevel2.AccessibleDescription = "105";
            this.pbxDexSkillLevel2.AccessibleName = "0";
            this.pbxDexSkillLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel2.Location = new System.Drawing.Point(202, 79);
            this.pbxDexSkillLevel2.Name = "pbxDexSkillLevel2";
            this.pbxDexSkillLevel2.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel2.TabIndex = 106;
            this.pbxDexSkillLevel2.TabStop = false;
            this.pbxDexSkillLevel2.Tag = "2";
            // 
            // pbxDexSkillLevel1
            // 
            this.pbxDexSkillLevel1.AccessibleDescription = "102";
            this.pbxDexSkillLevel1.AccessibleName = "0";
            this.pbxDexSkillLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkillLevel1.Location = new System.Drawing.Point(135, 79);
            this.pbxDexSkillLevel1.Name = "pbxDexSkillLevel1";
            this.pbxDexSkillLevel1.Size = new System.Drawing.Size(50, 18);
            this.pbxDexSkillLevel1.TabIndex = 105;
            this.pbxDexSkillLevel1.TabStop = false;
            this.pbxDexSkillLevel1.Tag = "2";
            // 
            // pbxDexSkill12
            // 
            this.pbxDexSkill12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill12.Location = new System.Drawing.Point(369, 218);
            this.pbxDexSkill12.Name = "pbxDexSkill12";
            this.pbxDexSkill12.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill12.TabIndex = 98;
            this.pbxDexSkill12.TabStop = false;
            // 
            // pbxDexSkill11
            // 
            this.pbxDexSkill11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill11.Location = new System.Drawing.Point(302, 218);
            this.pbxDexSkill11.Name = "pbxDexSkill11";
            this.pbxDexSkill11.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill11.TabIndex = 97;
            this.pbxDexSkill11.TabStop = false;
            // 
            // pbxDexSkill10
            // 
            this.pbxDexSkill10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill10.Location = new System.Drawing.Point(235, 218);
            this.pbxDexSkill10.Name = "pbxDexSkill10";
            this.pbxDexSkill10.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill10.TabIndex = 96;
            this.pbxDexSkill10.TabStop = false;
            // 
            // pbxDexSkill9
            // 
            this.pbxDexSkill9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill9.Location = new System.Drawing.Point(369, 124);
            this.pbxDexSkill9.Name = "pbxDexSkill9";
            this.pbxDexSkill9.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill9.TabIndex = 89;
            this.pbxDexSkill9.TabStop = false;
            // 
            // pbxDexSkill8
            // 
            this.pbxDexSkill8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill8.Location = new System.Drawing.Point(302, 124);
            this.pbxDexSkill8.Name = "pbxDexSkill8";
            this.pbxDexSkill8.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill8.TabIndex = 88;
            this.pbxDexSkill8.TabStop = false;
            // 
            // pbxDexSkill7
            // 
            this.pbxDexSkill7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill7.Location = new System.Drawing.Point(235, 124);
            this.pbxDexSkill7.Name = "pbxDexSkill7";
            this.pbxDexSkill7.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill7.TabIndex = 87;
            this.pbxDexSkill7.TabStop = false;
            // 
            // pbxDexSkill6
            // 
            this.pbxDexSkill6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill6.Location = new System.Drawing.Point(470, 30);
            this.pbxDexSkill6.Name = "pbxDexSkill6";
            this.pbxDexSkill6.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill6.TabIndex = 80;
            this.pbxDexSkill6.TabStop = false;
            // 
            // pbxDexSkill5
            // 
            this.pbxDexSkill5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill5.Location = new System.Drawing.Point(403, 30);
            this.pbxDexSkill5.Name = "pbxDexSkill5";
            this.pbxDexSkill5.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill5.TabIndex = 79;
            this.pbxDexSkill5.TabStop = false;
            // 
            // pbxDexSkill4
            // 
            this.pbxDexSkill4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill4.Location = new System.Drawing.Point(336, 30);
            this.pbxDexSkill4.Name = "pbxDexSkill4";
            this.pbxDexSkill4.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill4.TabIndex = 78;
            this.pbxDexSkill4.TabStop = false;
            // 
            // pbxDexSkill3
            // 
            this.pbxDexSkill3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill3.Location = new System.Drawing.Point(269, 30);
            this.pbxDexSkill3.Name = "pbxDexSkill3";
            this.pbxDexSkill3.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill3.TabIndex = 77;
            this.pbxDexSkill3.TabStop = false;
            // 
            // pbxDexSkill2
            // 
            this.pbxDexSkill2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill2.Location = new System.Drawing.Point(202, 30);
            this.pbxDexSkill2.Name = "pbxDexSkill2";
            this.pbxDexSkill2.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill2.TabIndex = 76;
            this.pbxDexSkill2.TabStop = false;
            // 
            // pbxDexSkill1
            // 
            this.pbxDexSkill1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxDexSkill1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDexSkill1.Location = new System.Drawing.Point(135, 30);
            this.pbxDexSkill1.Name = "pbxDexSkill1";
            this.pbxDexSkill1.Size = new System.Drawing.Size(50, 50);
            this.pbxDexSkill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDexSkill1.TabIndex = 75;
            this.pbxDexSkill1.TabStop = false;
            this.tTStrSkill1.SetToolTip(this.pbxDexSkill1, "Attack Skill\r\n\r\na jab to the targets Windpipe, \r\ncausing the winded status effect" +
        ".");
            // 
            // skillPageInt
            // 
            this.skillPageInt.Controls.Add(this.lblPointsAvailableIntValue);
            this.skillPageInt.Controls.Add(this.lblPointsAvailableIntName);
            this.skillPageInt.Controls.Add(this.lblIntTier3);
            this.skillPageInt.Controls.Add(this.lblIntTier2);
            this.skillPageInt.Controls.Add(this.lblIntTier1);
            this.skillPageInt.Controls.Add(this.pbxAvailablePointsInt);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel17);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel16);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel15);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel14);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel13);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel12);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel11);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel10);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel9);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel8);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel7);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel6);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel5);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel4);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel3);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel2);
            this.skillPageInt.Controls.Add(this.pbxIntSkillLevel1);
            this.skillPageInt.Controls.Add(this.pbxIntSkill17);
            this.skillPageInt.Controls.Add(this.pbxIntSkill16);
            this.skillPageInt.Controls.Add(this.pbxIntSkill15);
            this.skillPageInt.Controls.Add(this.pbxIntSkill14);
            this.skillPageInt.Controls.Add(this.pbxIntSkill13);
            this.skillPageInt.Controls.Add(this.pbxIntSkill12);
            this.skillPageInt.Controls.Add(this.pbxIntSkill11);
            this.skillPageInt.Controls.Add(this.pbxIntSkill10);
            this.skillPageInt.Controls.Add(this.pbxIntSkill9);
            this.skillPageInt.Controls.Add(this.pbxIntSkill8);
            this.skillPageInt.Controls.Add(this.pbxIntSkill7);
            this.skillPageInt.Controls.Add(this.pbxIntSkill6);
            this.skillPageInt.Controls.Add(this.pbxIntSkill5);
            this.skillPageInt.Controls.Add(this.pbxIntSkill4);
            this.skillPageInt.Controls.Add(this.pbxIntSkill3);
            this.skillPageInt.Controls.Add(this.pbxIntSkill2);
            this.skillPageInt.Controls.Add(this.pbxIntSkill1);
            this.skillPageInt.ImageIndex = 2;
            this.skillPageInt.Location = new System.Drawing.Point(4, 22);
            this.skillPageInt.Name = "skillPageInt";
            this.skillPageInt.Size = new System.Drawing.Size(655, 313);
            this.skillPageInt.TabIndex = 2;
            this.skillPageInt.Tag = "Int";
            this.skillPageInt.Text = "Intelligence";
            this.skillPageInt.UseVisualStyleBackColor = true;
            // 
            // lblPointsAvailableIntValue
            // 
            this.lblPointsAvailableIntValue.AutoSize = true;
            this.lblPointsAvailableIntValue.Location = new System.Drawing.Point(584, 246);
            this.lblPointsAvailableIntValue.Name = "lblPointsAvailableIntValue";
            this.lblPointsAvailableIntValue.Size = new System.Drawing.Size(0, 13);
            this.lblPointsAvailableIntValue.TabIndex = 129;
            // 
            // lblPointsAvailableIntName
            // 
            this.lblPointsAvailableIntName.AutoSize = true;
            this.lblPointsAvailableIntName.Location = new System.Drawing.Point(546, 224);
            this.lblPointsAvailableIntName.Name = "lblPointsAvailableIntName";
            this.lblPointsAvailableIntName.Size = new System.Drawing.Size(82, 13);
            this.lblPointsAvailableIntName.TabIndex = 128;
            this.lblPointsAvailableIntName.Text = "Points Available";
            // 
            // lblIntTier3
            // 
            this.lblIntTier3.AutoSize = true;
            this.lblIntTier3.Location = new System.Drawing.Point(5, 232);
            this.lblIntTier3.Name = "lblIntTier3";
            this.lblIntTier3.Size = new System.Drawing.Size(41, 13);
            this.lblIntTier3.TabIndex = 84;
            this.lblIntTier3.Text = "TIER 3";
            // 
            // lblIntTier2
            // 
            this.lblIntTier2.AutoSize = true;
            this.lblIntTier2.Location = new System.Drawing.Point(6, 136);
            this.lblIntTier2.Name = "lblIntTier2";
            this.lblIntTier2.Size = new System.Drawing.Size(41, 13);
            this.lblIntTier2.TabIndex = 83;
            this.lblIntTier2.Text = "TIER 2";
            // 
            // lblIntTier1
            // 
            this.lblIntTier1.AutoSize = true;
            this.lblIntTier1.Location = new System.Drawing.Point(6, 40);
            this.lblIntTier1.Name = "lblIntTier1";
            this.lblIntTier1.Size = new System.Drawing.Size(41, 13);
            this.lblIntTier1.TabIndex = 82;
            this.lblIntTier1.Text = "TIER 1";
            // 
            // pbxAvailablePointsInt
            // 
            this.pbxAvailablePointsInt.BackgroundImage = global::Sheltered_2_SE.Properties.Resources.AvailableSkillsInt;
            this.pbxAvailablePointsInt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxAvailablePointsInt.Location = new System.Drawing.Point(547, 131);
            this.pbxAvailablePointsInt.Name = "pbxAvailablePointsInt";
            this.pbxAvailablePointsInt.Size = new System.Drawing.Size(90, 90);
            this.pbxAvailablePointsInt.TabIndex = 130;
            this.pbxAvailablePointsInt.TabStop = false;
            // 
            // pbxIntSkillLevel17
            // 
            this.pbxIntSkillLevel17.AccessibleDescription = "224";
            this.pbxIntSkillLevel17.AccessibleName = "0";
            this.pbxIntSkillLevel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel17.Location = new System.Drawing.Point(403, 267);
            this.pbxIntSkillLevel17.Name = "pbxIntSkillLevel17";
            this.pbxIntSkillLevel17.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel17.TabIndex = 126;
            this.pbxIntSkillLevel17.TabStop = false;
            this.pbxIntSkillLevel17.Tag = "0";
            // 
            // pbxIntSkillLevel16
            // 
            this.pbxIntSkillLevel16.AccessibleDescription = "243";
            this.pbxIntSkillLevel16.AccessibleName = "0";
            this.pbxIntSkillLevel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel16.Location = new System.Drawing.Point(336, 267);
            this.pbxIntSkillLevel16.Name = "pbxIntSkillLevel16";
            this.pbxIntSkillLevel16.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel16.TabIndex = 125;
            this.pbxIntSkillLevel16.TabStop = false;
            this.pbxIntSkillLevel16.Tag = "0";
            // 
            // pbxIntSkillLevel15
            // 
            this.pbxIntSkillLevel15.AccessibleDescription = "206";
            this.pbxIntSkillLevel15.AccessibleName = "0";
            this.pbxIntSkillLevel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel15.Location = new System.Drawing.Point(269, 267);
            this.pbxIntSkillLevel15.Name = "pbxIntSkillLevel15";
            this.pbxIntSkillLevel15.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel15.TabIndex = 124;
            this.pbxIntSkillLevel15.TabStop = false;
            this.pbxIntSkillLevel15.Tag = "2";
            // 
            // pbxIntSkillLevel14
            // 
            this.pbxIntSkillLevel14.AccessibleDescription = "235";
            this.pbxIntSkillLevel14.AccessibleName = "0";
            this.pbxIntSkillLevel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel14.Location = new System.Drawing.Point(202, 267);
            this.pbxIntSkillLevel14.Name = "pbxIntSkillLevel14";
            this.pbxIntSkillLevel14.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel14.TabIndex = 123;
            this.pbxIntSkillLevel14.TabStop = false;
            this.pbxIntSkillLevel14.Tag = "2";
            // 
            // pbxIntSkillLevel13
            // 
            this.pbxIntSkillLevel13.AccessibleDescription = "209";
            this.pbxIntSkillLevel13.AccessibleName = "0";
            this.pbxIntSkillLevel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel13.Location = new System.Drawing.Point(436, 173);
            this.pbxIntSkillLevel13.Name = "pbxIntSkillLevel13";
            this.pbxIntSkillLevel13.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel13.TabIndex = 118;
            this.pbxIntSkillLevel13.TabStop = false;
            this.pbxIntSkillLevel13.Tag = "0";
            // 
            // pbxIntSkillLevel12
            // 
            this.pbxIntSkillLevel12.AccessibleDescription = "241";
            this.pbxIntSkillLevel12.AccessibleName = "0";
            this.pbxIntSkillLevel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel12.Location = new System.Drawing.Point(369, 173);
            this.pbxIntSkillLevel12.Name = "pbxIntSkillLevel12";
            this.pbxIntSkillLevel12.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel12.TabIndex = 117;
            this.pbxIntSkillLevel12.TabStop = false;
            this.pbxIntSkillLevel12.Tag = "2";
            // 
            // pbxIntSkillLevel11
            // 
            this.pbxIntSkillLevel11.AccessibleDescription = "213";
            this.pbxIntSkillLevel11.AccessibleName = "0";
            this.pbxIntSkillLevel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel11.Location = new System.Drawing.Point(302, 173);
            this.pbxIntSkillLevel11.Name = "pbxIntSkillLevel11";
            this.pbxIntSkillLevel11.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel11.TabIndex = 116;
            this.pbxIntSkillLevel11.TabStop = false;
            this.pbxIntSkillLevel11.Tag = "2";
            // 
            // pbxIntSkillLevel10
            // 
            this.pbxIntSkillLevel10.AccessibleDescription = "201";
            this.pbxIntSkillLevel10.AccessibleName = "0";
            this.pbxIntSkillLevel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel10.Location = new System.Drawing.Point(235, 173);
            this.pbxIntSkillLevel10.Name = "pbxIntSkillLevel10";
            this.pbxIntSkillLevel10.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel10.TabIndex = 115;
            this.pbxIntSkillLevel10.TabStop = false;
            this.pbxIntSkillLevel10.Tag = "0";
            // 
            // pbxIntSkillLevel9
            // 
            this.pbxIntSkillLevel9.AccessibleDescription = "210";
            this.pbxIntSkillLevel9.AccessibleName = "0";
            this.pbxIntSkillLevel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel9.Location = new System.Drawing.Point(168, 173);
            this.pbxIntSkillLevel9.Name = "pbxIntSkillLevel9";
            this.pbxIntSkillLevel9.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel9.TabIndex = 114;
            this.pbxIntSkillLevel9.TabStop = false;
            this.pbxIntSkillLevel9.Tag = "2";
            // 
            // pbxIntSkillLevel8
            // 
            this.pbxIntSkillLevel8.AccessibleDescription = "239";
            this.pbxIntSkillLevel8.AccessibleName = "0";
            this.pbxIntSkillLevel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel8.Location = new System.Drawing.Point(537, 79);
            this.pbxIntSkillLevel8.Name = "pbxIntSkillLevel8";
            this.pbxIntSkillLevel8.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel8.TabIndex = 112;
            this.pbxIntSkillLevel8.TabStop = false;
            this.pbxIntSkillLevel8.Tag = "2";
            // 
            // pbxIntSkillLevel7
            // 
            this.pbxIntSkillLevel7.AccessibleDescription = "230";
            this.pbxIntSkillLevel7.AccessibleName = "0";
            this.pbxIntSkillLevel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel7.Location = new System.Drawing.Point(470, 79);
            this.pbxIntSkillLevel7.Name = "pbxIntSkillLevel7";
            this.pbxIntSkillLevel7.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel7.TabIndex = 111;
            this.pbxIntSkillLevel7.TabStop = false;
            this.pbxIntSkillLevel7.Tag = "2";
            // 
            // pbxIntSkillLevel6
            // 
            this.pbxIntSkillLevel6.AccessibleDescription = "234";
            this.pbxIntSkillLevel6.AccessibleName = "0";
            this.pbxIntSkillLevel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel6.Location = new System.Drawing.Point(403, 79);
            this.pbxIntSkillLevel6.Name = "pbxIntSkillLevel6";
            this.pbxIntSkillLevel6.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel6.TabIndex = 110;
            this.pbxIntSkillLevel6.TabStop = false;
            this.pbxIntSkillLevel6.Tag = "2";
            // 
            // pbxIntSkillLevel5
            // 
            this.pbxIntSkillLevel5.AccessibleDescription = "240";
            this.pbxIntSkillLevel5.AccessibleName = "0";
            this.pbxIntSkillLevel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel5.Location = new System.Drawing.Point(336, 79);
            this.pbxIntSkillLevel5.Name = "pbxIntSkillLevel5";
            this.pbxIntSkillLevel5.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel5.TabIndex = 109;
            this.pbxIntSkillLevel5.TabStop = false;
            this.pbxIntSkillLevel5.Tag = "0";
            // 
            // pbxIntSkillLevel4
            // 
            this.pbxIntSkillLevel4.AccessibleDescription = "229";
            this.pbxIntSkillLevel4.AccessibleName = "0";
            this.pbxIntSkillLevel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel4.Location = new System.Drawing.Point(269, 79);
            this.pbxIntSkillLevel4.Name = "pbxIntSkillLevel4";
            this.pbxIntSkillLevel4.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel4.TabIndex = 108;
            this.pbxIntSkillLevel4.TabStop = false;
            this.pbxIntSkillLevel4.Tag = "2";
            // 
            // pbxIntSkillLevel3
            // 
            this.pbxIntSkillLevel3.AccessibleDescription = "208";
            this.pbxIntSkillLevel3.AccessibleName = "0";
            this.pbxIntSkillLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel3.Location = new System.Drawing.Point(202, 79);
            this.pbxIntSkillLevel3.Name = "pbxIntSkillLevel3";
            this.pbxIntSkillLevel3.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel3.TabIndex = 107;
            this.pbxIntSkillLevel3.TabStop = false;
            this.pbxIntSkillLevel3.Tag = "2";
            // 
            // pbxIntSkillLevel2
            // 
            this.pbxIntSkillLevel2.AccessibleDescription = "200";
            this.pbxIntSkillLevel2.AccessibleName = "0";
            this.pbxIntSkillLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel2.Location = new System.Drawing.Point(135, 79);
            this.pbxIntSkillLevel2.Name = "pbxIntSkillLevel2";
            this.pbxIntSkillLevel2.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel2.TabIndex = 106;
            this.pbxIntSkillLevel2.TabStop = false;
            this.pbxIntSkillLevel2.Tag = "2";
            // 
            // pbxIntSkillLevel1
            // 
            this.pbxIntSkillLevel1.AccessibleDescription = "214";
            this.pbxIntSkillLevel1.AccessibleName = "0";
            this.pbxIntSkillLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkillLevel1.Location = new System.Drawing.Point(68, 79);
            this.pbxIntSkillLevel1.Name = "pbxIntSkillLevel1";
            this.pbxIntSkillLevel1.Size = new System.Drawing.Size(50, 18);
            this.pbxIntSkillLevel1.TabIndex = 105;
            this.pbxIntSkillLevel1.TabStop = false;
            this.pbxIntSkillLevel1.Tag = "0";
            // 
            // pbxIntSkill17
            // 
            this.pbxIntSkill17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill17.Location = new System.Drawing.Point(403, 218);
            this.pbxIntSkill17.Name = "pbxIntSkill17";
            this.pbxIntSkill17.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill17.TabIndex = 99;
            this.pbxIntSkill17.TabStop = false;
            // 
            // pbxIntSkill16
            // 
            this.pbxIntSkill16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill16.Location = new System.Drawing.Point(336, 218);
            this.pbxIntSkill16.Name = "pbxIntSkill16";
            this.pbxIntSkill16.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill16.TabIndex = 98;
            this.pbxIntSkill16.TabStop = false;
            // 
            // pbxIntSkill15
            // 
            this.pbxIntSkill15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill15.Location = new System.Drawing.Point(269, 218);
            this.pbxIntSkill15.Name = "pbxIntSkill15";
            this.pbxIntSkill15.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill15.TabIndex = 97;
            this.pbxIntSkill15.TabStop = false;
            // 
            // pbxIntSkill14
            // 
            this.pbxIntSkill14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill14.Location = new System.Drawing.Point(202, 218);
            this.pbxIntSkill14.Name = "pbxIntSkill14";
            this.pbxIntSkill14.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill14.TabIndex = 96;
            this.pbxIntSkill14.TabStop = false;
            // 
            // pbxIntSkill13
            // 
            this.pbxIntSkill13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill13.Location = new System.Drawing.Point(436, 124);
            this.pbxIntSkill13.Name = "pbxIntSkill13";
            this.pbxIntSkill13.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill13.TabIndex = 91;
            this.pbxIntSkill13.TabStop = false;
            // 
            // pbxIntSkill12
            // 
            this.pbxIntSkill12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill12.Location = new System.Drawing.Point(369, 124);
            this.pbxIntSkill12.Name = "pbxIntSkill12";
            this.pbxIntSkill12.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill12.TabIndex = 90;
            this.pbxIntSkill12.TabStop = false;
            // 
            // pbxIntSkill11
            // 
            this.pbxIntSkill11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill11.Location = new System.Drawing.Point(302, 124);
            this.pbxIntSkill11.Name = "pbxIntSkill11";
            this.pbxIntSkill11.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill11.TabIndex = 89;
            this.pbxIntSkill11.TabStop = false;
            // 
            // pbxIntSkill10
            // 
            this.pbxIntSkill10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill10.Location = new System.Drawing.Point(235, 124);
            this.pbxIntSkill10.Name = "pbxIntSkill10";
            this.pbxIntSkill10.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill10.TabIndex = 88;
            this.pbxIntSkill10.TabStop = false;
            // 
            // pbxIntSkill9
            // 
            this.pbxIntSkill9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill9.Location = new System.Drawing.Point(168, 124);
            this.pbxIntSkill9.Name = "pbxIntSkill9";
            this.pbxIntSkill9.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill9.TabIndex = 87;
            this.pbxIntSkill9.TabStop = false;
            // 
            // pbxIntSkill8
            // 
            this.pbxIntSkill8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill8.Location = new System.Drawing.Point(537, 30);
            this.pbxIntSkill8.Name = "pbxIntSkill8";
            this.pbxIntSkill8.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill8.TabIndex = 85;
            this.pbxIntSkill8.TabStop = false;
            // 
            // pbxIntSkill7
            // 
            this.pbxIntSkill7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill7.Location = new System.Drawing.Point(470, 30);
            this.pbxIntSkill7.Name = "pbxIntSkill7";
            this.pbxIntSkill7.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill7.TabIndex = 81;
            this.pbxIntSkill7.TabStop = false;
            // 
            // pbxIntSkill6
            // 
            this.pbxIntSkill6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill6.Location = new System.Drawing.Point(403, 30);
            this.pbxIntSkill6.Name = "pbxIntSkill6";
            this.pbxIntSkill6.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill6.TabIndex = 80;
            this.pbxIntSkill6.TabStop = false;
            // 
            // pbxIntSkill5
            // 
            this.pbxIntSkill5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill5.Location = new System.Drawing.Point(336, 30);
            this.pbxIntSkill5.Name = "pbxIntSkill5";
            this.pbxIntSkill5.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill5.TabIndex = 79;
            this.pbxIntSkill5.TabStop = false;
            // 
            // pbxIntSkill4
            // 
            this.pbxIntSkill4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill4.Location = new System.Drawing.Point(269, 30);
            this.pbxIntSkill4.Name = "pbxIntSkill4";
            this.pbxIntSkill4.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill4.TabIndex = 78;
            this.pbxIntSkill4.TabStop = false;
            // 
            // pbxIntSkill3
            // 
            this.pbxIntSkill3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill3.Location = new System.Drawing.Point(202, 30);
            this.pbxIntSkill3.Name = "pbxIntSkill3";
            this.pbxIntSkill3.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill3.TabIndex = 77;
            this.pbxIntSkill3.TabStop = false;
            // 
            // pbxIntSkill2
            // 
            this.pbxIntSkill2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill2.Location = new System.Drawing.Point(135, 30);
            this.pbxIntSkill2.Name = "pbxIntSkill2";
            this.pbxIntSkill2.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill2.TabIndex = 76;
            this.pbxIntSkill2.TabStop = false;
            // 
            // pbxIntSkill1
            // 
            this.pbxIntSkill1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxIntSkill1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxIntSkill1.Location = new System.Drawing.Point(68, 30);
            this.pbxIntSkill1.Name = "pbxIntSkill1";
            this.pbxIntSkill1.Size = new System.Drawing.Size(50, 50);
            this.pbxIntSkill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIntSkill1.TabIndex = 75;
            this.pbxIntSkill1.TabStop = false;
            this.tTStrSkill1.SetToolTip(this.pbxIntSkill1, "Attack Skill\r\n\r\na jab to the targets Windpipe, \r\ncausing the winded status effect" +
        ".");
            // 
            // skillPageCha
            // 
            this.skillPageCha.Controls.Add(this.lblPointsAvailableChaValue);
            this.skillPageCha.Controls.Add(this.lblPointsAvailableChaName);
            this.skillPageCha.Controls.Add(this.lblChaTier3);
            this.skillPageCha.Controls.Add(this.lblChaTier2);
            this.skillPageCha.Controls.Add(this.lblChaTier1);
            this.skillPageCha.Controls.Add(this.pbxAvailablePointsCha);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel13);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel12);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel11);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel10);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel9);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel8);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel7);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel6);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel5);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel4);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel3);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel2);
            this.skillPageCha.Controls.Add(this.pbxChaSkillLevel1);
            this.skillPageCha.Controls.Add(this.pbxChaSkill13);
            this.skillPageCha.Controls.Add(this.pbxChaSkill12);
            this.skillPageCha.Controls.Add(this.pbxChaSkill11);
            this.skillPageCha.Controls.Add(this.pbxChaSkill10);
            this.skillPageCha.Controls.Add(this.pbxChaSkill9);
            this.skillPageCha.Controls.Add(this.pbxChaSkill8);
            this.skillPageCha.Controls.Add(this.pbxChaSkill7);
            this.skillPageCha.Controls.Add(this.pbxChaSkill6);
            this.skillPageCha.Controls.Add(this.pbxChaSkill5);
            this.skillPageCha.Controls.Add(this.pbxChaSkill4);
            this.skillPageCha.Controls.Add(this.pbxChaSkill3);
            this.skillPageCha.Controls.Add(this.pbxChaSkill2);
            this.skillPageCha.Controls.Add(this.pbxChaSkill1);
            this.skillPageCha.ImageIndex = 3;
            this.skillPageCha.Location = new System.Drawing.Point(4, 22);
            this.skillPageCha.Name = "skillPageCha";
            this.skillPageCha.Size = new System.Drawing.Size(655, 313);
            this.skillPageCha.TabIndex = 3;
            this.skillPageCha.Tag = "Cha";
            this.skillPageCha.Text = "Charisma";
            this.skillPageCha.UseVisualStyleBackColor = true;
            // 
            // lblPointsAvailableChaValue
            // 
            this.lblPointsAvailableChaValue.AutoSize = true;
            this.lblPointsAvailableChaValue.Location = new System.Drawing.Point(584, 246);
            this.lblPointsAvailableChaValue.Name = "lblPointsAvailableChaValue";
            this.lblPointsAvailableChaValue.Size = new System.Drawing.Size(0, 13);
            this.lblPointsAvailableChaValue.TabIndex = 127;
            // 
            // lblPointsAvailableChaName
            // 
            this.lblPointsAvailableChaName.AutoSize = true;
            this.lblPointsAvailableChaName.Location = new System.Drawing.Point(546, 224);
            this.lblPointsAvailableChaName.Name = "lblPointsAvailableChaName";
            this.lblPointsAvailableChaName.Size = new System.Drawing.Size(82, 13);
            this.lblPointsAvailableChaName.TabIndex = 126;
            this.lblPointsAvailableChaName.Text = "Points Available";
            // 
            // lblChaTier3
            // 
            this.lblChaTier3.AutoSize = true;
            this.lblChaTier3.Location = new System.Drawing.Point(5, 232);
            this.lblChaTier3.Name = "lblChaTier3";
            this.lblChaTier3.Size = new System.Drawing.Size(41, 13);
            this.lblChaTier3.TabIndex = 84;
            this.lblChaTier3.Text = "TIER 3";
            // 
            // lblChaTier2
            // 
            this.lblChaTier2.AutoSize = true;
            this.lblChaTier2.Location = new System.Drawing.Point(6, 136);
            this.lblChaTier2.Name = "lblChaTier2";
            this.lblChaTier2.Size = new System.Drawing.Size(41, 13);
            this.lblChaTier2.TabIndex = 83;
            this.lblChaTier2.Text = "TIER 2";
            // 
            // lblChaTier1
            // 
            this.lblChaTier1.AutoSize = true;
            this.lblChaTier1.Location = new System.Drawing.Point(6, 40);
            this.lblChaTier1.Name = "lblChaTier1";
            this.lblChaTier1.Size = new System.Drawing.Size(41, 13);
            this.lblChaTier1.TabIndex = 82;
            this.lblChaTier1.Text = "TIER 1";
            // 
            // pbxAvailablePointsCha
            // 
            this.pbxAvailablePointsCha.BackgroundImage = global::Sheltered_2_SE.Properties.Resources.AvailableSkillsCha;
            this.pbxAvailablePointsCha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxAvailablePointsCha.Location = new System.Drawing.Point(547, 131);
            this.pbxAvailablePointsCha.Name = "pbxAvailablePointsCha";
            this.pbxAvailablePointsCha.Size = new System.Drawing.Size(90, 90);
            this.pbxAvailablePointsCha.TabIndex = 128;
            this.pbxAvailablePointsCha.TabStop = false;
            // 
            // pbxChaSkillLevel13
            // 
            this.pbxChaSkillLevel13.AccessibleDescription = "300";
            this.pbxChaSkillLevel13.AccessibleName = "0";
            this.pbxChaSkillLevel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel13.Location = new System.Drawing.Point(336, 267);
            this.pbxChaSkillLevel13.Name = "pbxChaSkillLevel13";
            this.pbxChaSkillLevel13.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel13.TabIndex = 124;
            this.pbxChaSkillLevel13.TabStop = false;
            this.pbxChaSkillLevel13.Tag = "2";
            // 
            // pbxChaSkillLevel12
            // 
            this.pbxChaSkillLevel12.AccessibleDescription = "306";
            this.pbxChaSkillLevel12.AccessibleName = "0";
            this.pbxChaSkillLevel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel12.Location = new System.Drawing.Point(269, 267);
            this.pbxChaSkillLevel12.Name = "pbxChaSkillLevel12";
            this.pbxChaSkillLevel12.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel12.TabIndex = 123;
            this.pbxChaSkillLevel12.TabStop = false;
            this.pbxChaSkillLevel12.Tag = "0";
            // 
            // pbxChaSkillLevel11
            // 
            this.pbxChaSkillLevel11.AccessibleDescription = "326";
            this.pbxChaSkillLevel11.AccessibleName = "0";
            this.pbxChaSkillLevel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel11.Location = new System.Drawing.Point(403, 173);
            this.pbxChaSkillLevel11.Name = "pbxChaSkillLevel11";
            this.pbxChaSkillLevel11.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel11.TabIndex = 117;
            this.pbxChaSkillLevel11.TabStop = false;
            this.pbxChaSkillLevel11.Tag = "0";
            // 
            // pbxChaSkillLevel10
            // 
            this.pbxChaSkillLevel10.AccessibleDescription = "429";
            this.pbxChaSkillLevel10.AccessibleName = "0";
            this.pbxChaSkillLevel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel10.Location = new System.Drawing.Point(336, 173);
            this.pbxChaSkillLevel10.Name = "pbxChaSkillLevel10";
            this.pbxChaSkillLevel10.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel10.TabIndex = 116;
            this.pbxChaSkillLevel10.TabStop = false;
            this.pbxChaSkillLevel10.Tag = "2";
            // 
            // pbxChaSkillLevel9
            // 
            this.pbxChaSkillLevel9.AccessibleDescription = "301";
            this.pbxChaSkillLevel9.AccessibleName = "0";
            this.pbxChaSkillLevel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel9.Location = new System.Drawing.Point(269, 173);
            this.pbxChaSkillLevel9.Name = "pbxChaSkillLevel9";
            this.pbxChaSkillLevel9.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel9.TabIndex = 115;
            this.pbxChaSkillLevel9.TabStop = false;
            this.pbxChaSkillLevel9.Tag = "2";
            // 
            // pbxChaSkillLevel8
            // 
            this.pbxChaSkillLevel8.AccessibleDescription = "324";
            this.pbxChaSkillLevel8.AccessibleName = "0";
            this.pbxChaSkillLevel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel8.Location = new System.Drawing.Point(202, 173);
            this.pbxChaSkillLevel8.Name = "pbxChaSkillLevel8";
            this.pbxChaSkillLevel8.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel8.TabIndex = 114;
            this.pbxChaSkillLevel8.TabStop = false;
            this.pbxChaSkillLevel8.Tag = "0";
            // 
            // pbxChaSkillLevel7
            // 
            this.pbxChaSkillLevel7.AccessibleDescription = "320";
            this.pbxChaSkillLevel7.AccessibleName = "0";
            this.pbxChaSkillLevel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel7.Location = new System.Drawing.Point(503, 79);
            this.pbxChaSkillLevel7.Name = "pbxChaSkillLevel7";
            this.pbxChaSkillLevel7.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel7.TabIndex = 111;
            this.pbxChaSkillLevel7.TabStop = false;
            this.pbxChaSkillLevel7.Tag = "2";
            // 
            // pbxChaSkillLevel6
            // 
            this.pbxChaSkillLevel6.AccessibleDescription = "319";
            this.pbxChaSkillLevel6.AccessibleName = "0";
            this.pbxChaSkillLevel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel6.Location = new System.Drawing.Point(436, 79);
            this.pbxChaSkillLevel6.Name = "pbxChaSkillLevel6";
            this.pbxChaSkillLevel6.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel6.TabIndex = 110;
            this.pbxChaSkillLevel6.TabStop = false;
            this.pbxChaSkillLevel6.Tag = "2";
            // 
            // pbxChaSkillLevel5
            // 
            this.pbxChaSkillLevel5.AccessibleDescription = "316";
            this.pbxChaSkillLevel5.AccessibleName = "0";
            this.pbxChaSkillLevel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel5.Location = new System.Drawing.Point(369, 79);
            this.pbxChaSkillLevel5.Name = "pbxChaSkillLevel5";
            this.pbxChaSkillLevel5.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel5.TabIndex = 109;
            this.pbxChaSkillLevel5.TabStop = false;
            this.pbxChaSkillLevel5.Tag = "0";
            // 
            // pbxChaSkillLevel4
            // 
            this.pbxChaSkillLevel4.AccessibleDescription = "304";
            this.pbxChaSkillLevel4.AccessibleName = "0";
            this.pbxChaSkillLevel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel4.Location = new System.Drawing.Point(302, 79);
            this.pbxChaSkillLevel4.Name = "pbxChaSkillLevel4";
            this.pbxChaSkillLevel4.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel4.TabIndex = 108;
            this.pbxChaSkillLevel4.TabStop = false;
            this.pbxChaSkillLevel4.Tag = "2";
            // 
            // pbxChaSkillLevel3
            // 
            this.pbxChaSkillLevel3.AccessibleDescription = "302";
            this.pbxChaSkillLevel3.AccessibleName = "0";
            this.pbxChaSkillLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel3.Location = new System.Drawing.Point(235, 79);
            this.pbxChaSkillLevel3.Name = "pbxChaSkillLevel3";
            this.pbxChaSkillLevel3.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel3.TabIndex = 107;
            this.pbxChaSkillLevel3.TabStop = false;
            this.pbxChaSkillLevel3.Tag = "2";
            // 
            // pbxChaSkillLevel2
            // 
            this.pbxChaSkillLevel2.AccessibleDescription = "309";
            this.pbxChaSkillLevel2.AccessibleName = "0";
            this.pbxChaSkillLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel2.Location = new System.Drawing.Point(168, 79);
            this.pbxChaSkillLevel2.Name = "pbxChaSkillLevel2";
            this.pbxChaSkillLevel2.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel2.TabIndex = 106;
            this.pbxChaSkillLevel2.TabStop = false;
            this.pbxChaSkillLevel2.Tag = "2";
            // 
            // pbxChaSkillLevel1
            // 
            this.pbxChaSkillLevel1.AccessibleDescription = "327";
            this.pbxChaSkillLevel1.AccessibleName = "0";
            this.pbxChaSkillLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkillLevel1.Location = new System.Drawing.Point(101, 79);
            this.pbxChaSkillLevel1.Name = "pbxChaSkillLevel1";
            this.pbxChaSkillLevel1.Size = new System.Drawing.Size(50, 18);
            this.pbxChaSkillLevel1.TabIndex = 105;
            this.pbxChaSkillLevel1.TabStop = false;
            this.pbxChaSkillLevel1.Tag = "0";
            // 
            // pbxChaSkill13
            // 
            this.pbxChaSkill13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill13.Location = new System.Drawing.Point(336, 218);
            this.pbxChaSkill13.Name = "pbxChaSkill13";
            this.pbxChaSkill13.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill13.TabIndex = 97;
            this.pbxChaSkill13.TabStop = false;
            // 
            // pbxChaSkill12
            // 
            this.pbxChaSkill12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill12.Location = new System.Drawing.Point(269, 218);
            this.pbxChaSkill12.Name = "pbxChaSkill12";
            this.pbxChaSkill12.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill12.TabIndex = 96;
            this.pbxChaSkill12.TabStop = false;
            // 
            // pbxChaSkill11
            // 
            this.pbxChaSkill11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill11.Location = new System.Drawing.Point(403, 124);
            this.pbxChaSkill11.Name = "pbxChaSkill11";
            this.pbxChaSkill11.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill11.TabIndex = 90;
            this.pbxChaSkill11.TabStop = false;
            // 
            // pbxChaSkill10
            // 
            this.pbxChaSkill10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill10.Location = new System.Drawing.Point(336, 124);
            this.pbxChaSkill10.Name = "pbxChaSkill10";
            this.pbxChaSkill10.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill10.TabIndex = 89;
            this.pbxChaSkill10.TabStop = false;
            // 
            // pbxChaSkill9
            // 
            this.pbxChaSkill9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill9.Location = new System.Drawing.Point(269, 124);
            this.pbxChaSkill9.Name = "pbxChaSkill9";
            this.pbxChaSkill9.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill9.TabIndex = 88;
            this.pbxChaSkill9.TabStop = false;
            // 
            // pbxChaSkill8
            // 
            this.pbxChaSkill8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill8.Location = new System.Drawing.Point(202, 124);
            this.pbxChaSkill8.Name = "pbxChaSkill8";
            this.pbxChaSkill8.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill8.TabIndex = 87;
            this.pbxChaSkill8.TabStop = false;
            // 
            // pbxChaSkill7
            // 
            this.pbxChaSkill7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill7.Location = new System.Drawing.Point(503, 30);
            this.pbxChaSkill7.Name = "pbxChaSkill7";
            this.pbxChaSkill7.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill7.TabIndex = 81;
            this.pbxChaSkill7.TabStop = false;
            // 
            // pbxChaSkill6
            // 
            this.pbxChaSkill6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill6.Location = new System.Drawing.Point(436, 30);
            this.pbxChaSkill6.Name = "pbxChaSkill6";
            this.pbxChaSkill6.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill6.TabIndex = 80;
            this.pbxChaSkill6.TabStop = false;
            // 
            // pbxChaSkill5
            // 
            this.pbxChaSkill5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill5.Location = new System.Drawing.Point(369, 30);
            this.pbxChaSkill5.Name = "pbxChaSkill5";
            this.pbxChaSkill5.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill5.TabIndex = 79;
            this.pbxChaSkill5.TabStop = false;
            // 
            // pbxChaSkill4
            // 
            this.pbxChaSkill4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill4.Location = new System.Drawing.Point(302, 30);
            this.pbxChaSkill4.Name = "pbxChaSkill4";
            this.pbxChaSkill4.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill4.TabIndex = 78;
            this.pbxChaSkill4.TabStop = false;
            // 
            // pbxChaSkill3
            // 
            this.pbxChaSkill3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill3.Location = new System.Drawing.Point(235, 30);
            this.pbxChaSkill3.Name = "pbxChaSkill3";
            this.pbxChaSkill3.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill3.TabIndex = 77;
            this.pbxChaSkill3.TabStop = false;
            // 
            // pbxChaSkill2
            // 
            this.pbxChaSkill2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill2.Location = new System.Drawing.Point(168, 30);
            this.pbxChaSkill2.Name = "pbxChaSkill2";
            this.pbxChaSkill2.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill2.TabIndex = 76;
            this.pbxChaSkill2.TabStop = false;
            // 
            // pbxChaSkill1
            // 
            this.pbxChaSkill1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxChaSkill1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChaSkill1.Location = new System.Drawing.Point(101, 30);
            this.pbxChaSkill1.Name = "pbxChaSkill1";
            this.pbxChaSkill1.Size = new System.Drawing.Size(50, 50);
            this.pbxChaSkill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChaSkill1.TabIndex = 75;
            this.pbxChaSkill1.TabStop = false;
            this.tTStrSkill1.SetToolTip(this.pbxChaSkill1, "Attack Skill\r\n\r\na jab to the targets Windpipe, \r\ncausing the winded status effect" +
        ".");
            // 
            // skillPagePer
            // 
            this.skillPagePer.Controls.Add(this.lblPointsAvailablePerValue);
            this.skillPagePer.Controls.Add(this.lblPointsAvailablePerName);
            this.skillPagePer.Controls.Add(this.lblPerTier3);
            this.skillPagePer.Controls.Add(this.lblPerTier2);
            this.skillPagePer.Controls.Add(this.lblPerTier1);
            this.skillPagePer.Controls.Add(this.pbxAvailablePointsPer);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel17);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel16);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel15);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel14);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel13);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel12);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel11);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel10);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel9);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel8);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel7);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel6);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel5);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel4);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel3);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel2);
            this.skillPagePer.Controls.Add(this.pbxPerSkillLevel1);
            this.skillPagePer.Controls.Add(this.pbxPerSkill17);
            this.skillPagePer.Controls.Add(this.pbxPerSkill16);
            this.skillPagePer.Controls.Add(this.pbxPerSkill15);
            this.skillPagePer.Controls.Add(this.pbxPerSkill14);
            this.skillPagePer.Controls.Add(this.pbxPerSkill13);
            this.skillPagePer.Controls.Add(this.pbxPerSkill12);
            this.skillPagePer.Controls.Add(this.pbxPerSkill11);
            this.skillPagePer.Controls.Add(this.pbxPerSkill10);
            this.skillPagePer.Controls.Add(this.pbxPerSkill9);
            this.skillPagePer.Controls.Add(this.pbxPerSkill8);
            this.skillPagePer.Controls.Add(this.pbxPerSkill7);
            this.skillPagePer.Controls.Add(this.pbxPerSkill6);
            this.skillPagePer.Controls.Add(this.pbxPerSkill5);
            this.skillPagePer.Controls.Add(this.pbxPerSkill4);
            this.skillPagePer.Controls.Add(this.pbxPerSkill3);
            this.skillPagePer.Controls.Add(this.pbxPerSkill2);
            this.skillPagePer.Controls.Add(this.pbxPerSkill1);
            this.skillPagePer.ImageIndex = 4;
            this.skillPagePer.Location = new System.Drawing.Point(4, 22);
            this.skillPagePer.Name = "skillPagePer";
            this.skillPagePer.Size = new System.Drawing.Size(655, 313);
            this.skillPagePer.TabIndex = 4;
            this.skillPagePer.Tag = "Per";
            this.skillPagePer.Text = "Perception";
            this.skillPagePer.UseVisualStyleBackColor = true;
            // 
            // lblPointsAvailablePerValue
            // 
            this.lblPointsAvailablePerValue.AutoSize = true;
            this.lblPointsAvailablePerValue.Location = new System.Drawing.Point(584, 246);
            this.lblPointsAvailablePerValue.Name = "lblPointsAvailablePerValue";
            this.lblPointsAvailablePerValue.Size = new System.Drawing.Size(0, 13);
            this.lblPointsAvailablePerValue.TabIndex = 130;
            // 
            // lblPointsAvailablePerName
            // 
            this.lblPointsAvailablePerName.AutoSize = true;
            this.lblPointsAvailablePerName.Location = new System.Drawing.Point(546, 224);
            this.lblPointsAvailablePerName.Name = "lblPointsAvailablePerName";
            this.lblPointsAvailablePerName.Size = new System.Drawing.Size(82, 13);
            this.lblPointsAvailablePerName.TabIndex = 129;
            this.lblPointsAvailablePerName.Text = "Points Available";
            // 
            // lblPerTier3
            // 
            this.lblPerTier3.AutoSize = true;
            this.lblPerTier3.Location = new System.Drawing.Point(5, 232);
            this.lblPerTier3.Name = "lblPerTier3";
            this.lblPerTier3.Size = new System.Drawing.Size(41, 13);
            this.lblPerTier3.TabIndex = 84;
            this.lblPerTier3.Text = "TIER 3";
            // 
            // lblPerTier2
            // 
            this.lblPerTier2.AutoSize = true;
            this.lblPerTier2.Location = new System.Drawing.Point(6, 136);
            this.lblPerTier2.Name = "lblPerTier2";
            this.lblPerTier2.Size = new System.Drawing.Size(41, 13);
            this.lblPerTier2.TabIndex = 83;
            this.lblPerTier2.Text = "TIER 2";
            // 
            // lblPerTier1
            // 
            this.lblPerTier1.AutoSize = true;
            this.lblPerTier1.Location = new System.Drawing.Point(6, 40);
            this.lblPerTier1.Name = "lblPerTier1";
            this.lblPerTier1.Size = new System.Drawing.Size(41, 13);
            this.lblPerTier1.TabIndex = 82;
            this.lblPerTier1.Text = "TIER 1";
            // 
            // pbxAvailablePointsPer
            // 
            this.pbxAvailablePointsPer.BackgroundImage = global::Sheltered_2_SE.Properties.Resources.AvailableSkillsPer;
            this.pbxAvailablePointsPer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxAvailablePointsPer.Location = new System.Drawing.Point(547, 131);
            this.pbxAvailablePointsPer.Name = "pbxAvailablePointsPer";
            this.pbxAvailablePointsPer.Size = new System.Drawing.Size(90, 90);
            this.pbxAvailablePointsPer.TabIndex = 131;
            this.pbxAvailablePointsPer.TabStop = false;
            // 
            // pbxPerSkillLevel17
            // 
            this.pbxPerSkillLevel17.AccessibleDescription = "422";
            this.pbxPerSkillLevel17.AccessibleName = "0";
            this.pbxPerSkillLevel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel17.Location = new System.Drawing.Point(436, 267);
            this.pbxPerSkillLevel17.Name = "pbxPerSkillLevel17";
            this.pbxPerSkillLevel17.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel17.TabIndex = 127;
            this.pbxPerSkillLevel17.TabStop = false;
            this.pbxPerSkillLevel17.Tag = "0";
            // 
            // pbxPerSkillLevel16
            // 
            this.pbxPerSkillLevel16.AccessibleDescription = "410";
            this.pbxPerSkillLevel16.AccessibleName = "0";
            this.pbxPerSkillLevel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel16.Location = new System.Drawing.Point(369, 267);
            this.pbxPerSkillLevel16.Name = "pbxPerSkillLevel16";
            this.pbxPerSkillLevel16.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel16.TabIndex = 126;
            this.pbxPerSkillLevel16.TabStop = false;
            this.pbxPerSkillLevel16.Tag = "0";
            // 
            // pbxPerSkillLevel15
            // 
            this.pbxPerSkillLevel15.AccessibleDescription = "416";
            this.pbxPerSkillLevel15.AccessibleName = "0";
            this.pbxPerSkillLevel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel15.Location = new System.Drawing.Point(302, 267);
            this.pbxPerSkillLevel15.Name = "pbxPerSkillLevel15";
            this.pbxPerSkillLevel15.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel15.TabIndex = 125;
            this.pbxPerSkillLevel15.TabStop = false;
            this.pbxPerSkillLevel15.Tag = "0";
            // 
            // pbxPerSkillLevel14
            // 
            this.pbxPerSkillLevel14.AccessibleDescription = "419";
            this.pbxPerSkillLevel14.AccessibleName = "0";
            this.pbxPerSkillLevel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel14.Location = new System.Drawing.Point(235, 267);
            this.pbxPerSkillLevel14.Name = "pbxPerSkillLevel14";
            this.pbxPerSkillLevel14.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel14.TabIndex = 124;
            this.pbxPerSkillLevel14.TabStop = false;
            this.pbxPerSkillLevel14.Tag = "0";
            // 
            // pbxPerSkillLevel13
            // 
            this.pbxPerSkillLevel13.AccessibleDescription = "403";
            this.pbxPerSkillLevel13.AccessibleName = "0";
            this.pbxPerSkillLevel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel13.Location = new System.Drawing.Point(168, 267);
            this.pbxPerSkillLevel13.Name = "pbxPerSkillLevel13";
            this.pbxPerSkillLevel13.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel13.TabIndex = 123;
            this.pbxPerSkillLevel13.TabStop = false;
            this.pbxPerSkillLevel13.Tag = "0";
            // 
            // pbxPerSkillLevel12
            // 
            this.pbxPerSkillLevel12.AccessibleDescription = "413";
            this.pbxPerSkillLevel12.AccessibleName = "0";
            this.pbxPerSkillLevel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel12.Location = new System.Drawing.Point(436, 173);
            this.pbxPerSkillLevel12.Name = "pbxPerSkillLevel12";
            this.pbxPerSkillLevel12.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel12.TabIndex = 118;
            this.pbxPerSkillLevel12.TabStop = false;
            this.pbxPerSkillLevel12.Tag = "2";
            // 
            // pbxPerSkillLevel11
            // 
            this.pbxPerSkillLevel11.AccessibleDescription = "517";
            this.pbxPerSkillLevel11.AccessibleName = "0";
            this.pbxPerSkillLevel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel11.Location = new System.Drawing.Point(369, 173);
            this.pbxPerSkillLevel11.Name = "pbxPerSkillLevel11";
            this.pbxPerSkillLevel11.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel11.TabIndex = 117;
            this.pbxPerSkillLevel11.TabStop = false;
            this.pbxPerSkillLevel11.Tag = "0";
            // 
            // pbxPerSkillLevel10
            // 
            this.pbxPerSkillLevel10.AccessibleDescription = "420";
            this.pbxPerSkillLevel10.AccessibleName = "0";
            this.pbxPerSkillLevel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel10.Location = new System.Drawing.Point(302, 173);
            this.pbxPerSkillLevel10.Name = "pbxPerSkillLevel10";
            this.pbxPerSkillLevel10.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel10.TabIndex = 116;
            this.pbxPerSkillLevel10.TabStop = false;
            this.pbxPerSkillLevel10.Tag = "2";
            // 
            // pbxPerSkillLevel9
            // 
            this.pbxPerSkillLevel9.AccessibleDescription = "425";
            this.pbxPerSkillLevel9.AccessibleName = "0";
            this.pbxPerSkillLevel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel9.Location = new System.Drawing.Point(235, 173);
            this.pbxPerSkillLevel9.Name = "pbxPerSkillLevel9";
            this.pbxPerSkillLevel9.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel9.TabIndex = 115;
            this.pbxPerSkillLevel9.TabStop = false;
            this.pbxPerSkillLevel9.Tag = "2";
            // 
            // pbxPerSkillLevel8
            // 
            this.pbxPerSkillLevel8.AccessibleDescription = "402";
            this.pbxPerSkillLevel8.AccessibleName = "0";
            this.pbxPerSkillLevel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel8.Location = new System.Drawing.Point(168, 173);
            this.pbxPerSkillLevel8.Name = "pbxPerSkillLevel8";
            this.pbxPerSkillLevel8.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel8.TabIndex = 114;
            this.pbxPerSkillLevel8.TabStop = false;
            this.pbxPerSkillLevel8.Tag = "0";
            // 
            // pbxPerSkillLevel7
            // 
            this.pbxPerSkillLevel7.AccessibleDescription = "507";
            this.pbxPerSkillLevel7.AccessibleName = "0";
            this.pbxPerSkillLevel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel7.Location = new System.Drawing.Point(503, 79);
            this.pbxPerSkillLevel7.Name = "pbxPerSkillLevel7";
            this.pbxPerSkillLevel7.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel7.TabIndex = 111;
            this.pbxPerSkillLevel7.TabStop = false;
            this.pbxPerSkillLevel7.Tag = "2";
            // 
            // pbxPerSkillLevel6
            // 
            this.pbxPerSkillLevel6.AccessibleDescription = "424";
            this.pbxPerSkillLevel6.AccessibleName = "0";
            this.pbxPerSkillLevel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel6.Location = new System.Drawing.Point(436, 79);
            this.pbxPerSkillLevel6.Name = "pbxPerSkillLevel6";
            this.pbxPerSkillLevel6.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel6.TabIndex = 110;
            this.pbxPerSkillLevel6.TabStop = false;
            this.pbxPerSkillLevel6.Tag = "0";
            // 
            // pbxPerSkillLevel5
            // 
            this.pbxPerSkillLevel5.AccessibleDescription = "406";
            this.pbxPerSkillLevel5.AccessibleName = "0";
            this.pbxPerSkillLevel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel5.Location = new System.Drawing.Point(369, 79);
            this.pbxPerSkillLevel5.Name = "pbxPerSkillLevel5";
            this.pbxPerSkillLevel5.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel5.TabIndex = 109;
            this.pbxPerSkillLevel5.TabStop = false;
            this.pbxPerSkillLevel5.Tag = "2";
            // 
            // pbxPerSkillLevel4
            // 
            this.pbxPerSkillLevel4.AccessibleDescription = "431";
            this.pbxPerSkillLevel4.AccessibleName = "0";
            this.pbxPerSkillLevel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel4.Location = new System.Drawing.Point(302, 79);
            this.pbxPerSkillLevel4.Name = "pbxPerSkillLevel4";
            this.pbxPerSkillLevel4.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel4.TabIndex = 108;
            this.pbxPerSkillLevel4.TabStop = false;
            this.pbxPerSkillLevel4.Tag = "2";
            // 
            // pbxPerSkillLevel3
            // 
            this.pbxPerSkillLevel3.AccessibleDescription = "432";
            this.pbxPerSkillLevel3.AccessibleName = "0";
            this.pbxPerSkillLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel3.Location = new System.Drawing.Point(235, 79);
            this.pbxPerSkillLevel3.Name = "pbxPerSkillLevel3";
            this.pbxPerSkillLevel3.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel3.TabIndex = 107;
            this.pbxPerSkillLevel3.TabStop = false;
            this.pbxPerSkillLevel3.Tag = "2";
            // 
            // pbxPerSkillLevel2
            // 
            this.pbxPerSkillLevel2.AccessibleDescription = "433";
            this.pbxPerSkillLevel2.AccessibleName = "0";
            this.pbxPerSkillLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel2.Location = new System.Drawing.Point(168, 79);
            this.pbxPerSkillLevel2.Name = "pbxPerSkillLevel2";
            this.pbxPerSkillLevel2.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel2.TabIndex = 106;
            this.pbxPerSkillLevel2.TabStop = false;
            this.pbxPerSkillLevel2.Tag = "2";
            // 
            // pbxPerSkillLevel1
            // 
            this.pbxPerSkillLevel1.AccessibleDescription = "405";
            this.pbxPerSkillLevel1.AccessibleName = "0";
            this.pbxPerSkillLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkillLevel1.Location = new System.Drawing.Point(101, 79);
            this.pbxPerSkillLevel1.Name = "pbxPerSkillLevel1";
            this.pbxPerSkillLevel1.Size = new System.Drawing.Size(50, 18);
            this.pbxPerSkillLevel1.TabIndex = 105;
            this.pbxPerSkillLevel1.TabStop = false;
            this.pbxPerSkillLevel1.Tag = "0";
            // 
            // pbxPerSkill17
            // 
            this.pbxPerSkill17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill17.Location = new System.Drawing.Point(436, 218);
            this.pbxPerSkill17.Name = "pbxPerSkill17";
            this.pbxPerSkill17.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill17.TabIndex = 100;
            this.pbxPerSkill17.TabStop = false;
            // 
            // pbxPerSkill16
            // 
            this.pbxPerSkill16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill16.Location = new System.Drawing.Point(369, 218);
            this.pbxPerSkill16.Name = "pbxPerSkill16";
            this.pbxPerSkill16.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill16.TabIndex = 99;
            this.pbxPerSkill16.TabStop = false;
            // 
            // pbxPerSkill15
            // 
            this.pbxPerSkill15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill15.Location = new System.Drawing.Point(302, 218);
            this.pbxPerSkill15.Name = "pbxPerSkill15";
            this.pbxPerSkill15.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill15.TabIndex = 98;
            this.pbxPerSkill15.TabStop = false;
            // 
            // pbxPerSkill14
            // 
            this.pbxPerSkill14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill14.Location = new System.Drawing.Point(235, 218);
            this.pbxPerSkill14.Name = "pbxPerSkill14";
            this.pbxPerSkill14.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill14.TabIndex = 97;
            this.pbxPerSkill14.TabStop = false;
            // 
            // pbxPerSkill13
            // 
            this.pbxPerSkill13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill13.Location = new System.Drawing.Point(168, 218);
            this.pbxPerSkill13.Name = "pbxPerSkill13";
            this.pbxPerSkill13.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill13.TabIndex = 96;
            this.pbxPerSkill13.TabStop = false;
            // 
            // pbxPerSkill12
            // 
            this.pbxPerSkill12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill12.Location = new System.Drawing.Point(436, 124);
            this.pbxPerSkill12.Name = "pbxPerSkill12";
            this.pbxPerSkill12.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill12.TabIndex = 91;
            this.pbxPerSkill12.TabStop = false;
            // 
            // pbxPerSkill11
            // 
            this.pbxPerSkill11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill11.Location = new System.Drawing.Point(369, 124);
            this.pbxPerSkill11.Name = "pbxPerSkill11";
            this.pbxPerSkill11.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill11.TabIndex = 90;
            this.pbxPerSkill11.TabStop = false;
            // 
            // pbxPerSkill10
            // 
            this.pbxPerSkill10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill10.Location = new System.Drawing.Point(302, 124);
            this.pbxPerSkill10.Name = "pbxPerSkill10";
            this.pbxPerSkill10.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill10.TabIndex = 89;
            this.pbxPerSkill10.TabStop = false;
            // 
            // pbxPerSkill9
            // 
            this.pbxPerSkill9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill9.Location = new System.Drawing.Point(235, 124);
            this.pbxPerSkill9.Name = "pbxPerSkill9";
            this.pbxPerSkill9.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill9.TabIndex = 88;
            this.pbxPerSkill9.TabStop = false;
            // 
            // pbxPerSkill8
            // 
            this.pbxPerSkill8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill8.Location = new System.Drawing.Point(168, 124);
            this.pbxPerSkill8.Name = "pbxPerSkill8";
            this.pbxPerSkill8.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill8.TabIndex = 87;
            this.pbxPerSkill8.TabStop = false;
            // 
            // pbxPerSkill7
            // 
            this.pbxPerSkill7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill7.Location = new System.Drawing.Point(503, 30);
            this.pbxPerSkill7.Name = "pbxPerSkill7";
            this.pbxPerSkill7.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill7.TabIndex = 81;
            this.pbxPerSkill7.TabStop = false;
            // 
            // pbxPerSkill6
            // 
            this.pbxPerSkill6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill6.Location = new System.Drawing.Point(436, 30);
            this.pbxPerSkill6.Name = "pbxPerSkill6";
            this.pbxPerSkill6.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill6.TabIndex = 80;
            this.pbxPerSkill6.TabStop = false;
            // 
            // pbxPerSkill5
            // 
            this.pbxPerSkill5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill5.Location = new System.Drawing.Point(369, 30);
            this.pbxPerSkill5.Name = "pbxPerSkill5";
            this.pbxPerSkill5.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill5.TabIndex = 79;
            this.pbxPerSkill5.TabStop = false;
            // 
            // pbxPerSkill4
            // 
            this.pbxPerSkill4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill4.Location = new System.Drawing.Point(302, 30);
            this.pbxPerSkill4.Name = "pbxPerSkill4";
            this.pbxPerSkill4.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill4.TabIndex = 78;
            this.pbxPerSkill4.TabStop = false;
            // 
            // pbxPerSkill3
            // 
            this.pbxPerSkill3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill3.Location = new System.Drawing.Point(235, 30);
            this.pbxPerSkill3.Name = "pbxPerSkill3";
            this.pbxPerSkill3.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill3.TabIndex = 77;
            this.pbxPerSkill3.TabStop = false;
            // 
            // pbxPerSkill2
            // 
            this.pbxPerSkill2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill2.Location = new System.Drawing.Point(168, 30);
            this.pbxPerSkill2.Name = "pbxPerSkill2";
            this.pbxPerSkill2.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill2.TabIndex = 76;
            this.pbxPerSkill2.TabStop = false;
            // 
            // pbxPerSkill1
            // 
            this.pbxPerSkill1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPerSkill1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPerSkill1.Location = new System.Drawing.Point(101, 30);
            this.pbxPerSkill1.Name = "pbxPerSkill1";
            this.pbxPerSkill1.Size = new System.Drawing.Size(50, 50);
            this.pbxPerSkill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerSkill1.TabIndex = 75;
            this.pbxPerSkill1.TabStop = false;
            this.tTStrSkill1.SetToolTip(this.pbxPerSkill1, "Attack Skill\r\n\r\na jab to the targets Windpipe, \r\ncausing the winded status effect" +
        ".");
            // 
            // skillPageFor
            // 
            this.skillPageFor.Controls.Add(this.lblPointsAvailableForValue);
            this.skillPageFor.Controls.Add(this.lblPointsAvailableForName);
            this.skillPageFor.Controls.Add(this.lblForTier3);
            this.skillPageFor.Controls.Add(this.lblForTier2);
            this.skillPageFor.Controls.Add(this.lblForTier1);
            this.skillPageFor.Controls.Add(this.pbxAvailablePointsFor);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel20);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel19);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel18);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel17);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel16);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel15);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel14);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel13);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel12);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel11);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel10);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel9);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel8);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel7);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel6);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel5);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel4);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel3);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel2);
            this.skillPageFor.Controls.Add(this.pbxForSkillLevel1);
            this.skillPageFor.Controls.Add(this.pbxForSkill20);
            this.skillPageFor.Controls.Add(this.pbxForSkill19);
            this.skillPageFor.Controls.Add(this.pbxForSkill18);
            this.skillPageFor.Controls.Add(this.pbxForSkill17);
            this.skillPageFor.Controls.Add(this.pbxForSkill16);
            this.skillPageFor.Controls.Add(this.pbxForSkill15);
            this.skillPageFor.Controls.Add(this.pbxForSkill14);
            this.skillPageFor.Controls.Add(this.pbxForSkill13);
            this.skillPageFor.Controls.Add(this.pbxForSkill12);
            this.skillPageFor.Controls.Add(this.pbxForSkill11);
            this.skillPageFor.Controls.Add(this.pbxForSkill10);
            this.skillPageFor.Controls.Add(this.pbxForSkill9);
            this.skillPageFor.Controls.Add(this.pbxForSkill8);
            this.skillPageFor.Controls.Add(this.pbxForSkill7);
            this.skillPageFor.Controls.Add(this.pbxForSkill6);
            this.skillPageFor.Controls.Add(this.pbxForSkill5);
            this.skillPageFor.Controls.Add(this.pbxForSkill4);
            this.skillPageFor.Controls.Add(this.pbxForSkill3);
            this.skillPageFor.Controls.Add(this.pbxForSkill2);
            this.skillPageFor.Controls.Add(this.pbxForSkill1);
            this.skillPageFor.ImageIndex = 5;
            this.skillPageFor.Location = new System.Drawing.Point(4, 22);
            this.skillPageFor.Name = "skillPageFor";
            this.skillPageFor.Size = new System.Drawing.Size(655, 313);
            this.skillPageFor.TabIndex = 5;
            this.skillPageFor.Tag = "For";
            this.skillPageFor.Text = "Fortitude";
            this.skillPageFor.UseVisualStyleBackColor = true;
            // 
            // lblPointsAvailableForValue
            // 
            this.lblPointsAvailableForValue.AutoSize = true;
            this.lblPointsAvailableForValue.Location = new System.Drawing.Point(584, 246);
            this.lblPointsAvailableForValue.Name = "lblPointsAvailableForValue";
            this.lblPointsAvailableForValue.Size = new System.Drawing.Size(0, 13);
            this.lblPointsAvailableForValue.TabIndex = 130;
            // 
            // lblPointsAvailableForName
            // 
            this.lblPointsAvailableForName.AutoSize = true;
            this.lblPointsAvailableForName.Location = new System.Drawing.Point(546, 224);
            this.lblPointsAvailableForName.Name = "lblPointsAvailableForName";
            this.lblPointsAvailableForName.Size = new System.Drawing.Size(82, 13);
            this.lblPointsAvailableForName.TabIndex = 129;
            this.lblPointsAvailableForName.Text = "Points Available";
            // 
            // lblForTier3
            // 
            this.lblForTier3.AutoSize = true;
            this.lblForTier3.Location = new System.Drawing.Point(5, 232);
            this.lblForTier3.Name = "lblForTier3";
            this.lblForTier3.Size = new System.Drawing.Size(41, 13);
            this.lblForTier3.TabIndex = 84;
            this.lblForTier3.Text = "TIER 3";
            // 
            // lblForTier2
            // 
            this.lblForTier2.AutoSize = true;
            this.lblForTier2.Location = new System.Drawing.Point(6, 136);
            this.lblForTier2.Name = "lblForTier2";
            this.lblForTier2.Size = new System.Drawing.Size(41, 13);
            this.lblForTier2.TabIndex = 83;
            this.lblForTier2.Text = "TIER 2";
            // 
            // lblForTier1
            // 
            this.lblForTier1.AutoSize = true;
            this.lblForTier1.Location = new System.Drawing.Point(6, 40);
            this.lblForTier1.Name = "lblForTier1";
            this.lblForTier1.Size = new System.Drawing.Size(41, 13);
            this.lblForTier1.TabIndex = 82;
            this.lblForTier1.Text = "TIER 1";
            // 
            // pbxAvailablePointsFor
            // 
            this.pbxAvailablePointsFor.BackgroundImage = global::Sheltered_2_SE.Properties.Resources.AvailableSkillsFor;
            this.pbxAvailablePointsFor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxAvailablePointsFor.Location = new System.Drawing.Point(547, 131);
            this.pbxAvailablePointsFor.Name = "pbxAvailablePointsFor";
            this.pbxAvailablePointsFor.Size = new System.Drawing.Size(90, 90);
            this.pbxAvailablePointsFor.TabIndex = 131;
            this.pbxAvailablePointsFor.TabStop = false;
            // 
            // pbxForSkillLevel20
            // 
            this.pbxForSkillLevel20.AccessibleDescription = "516";
            this.pbxForSkillLevel20.AccessibleName = "0";
            this.pbxForSkillLevel20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel20.Location = new System.Drawing.Point(436, 267);
            this.pbxForSkillLevel20.Name = "pbxForSkillLevel20";
            this.pbxForSkillLevel20.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel20.TabIndex = 127;
            this.pbxForSkillLevel20.TabStop = false;
            this.pbxForSkillLevel20.Tag = "2";
            // 
            // pbxForSkillLevel19
            // 
            this.pbxForSkillLevel19.AccessibleDescription = "510";
            this.pbxForSkillLevel19.AccessibleName = "0";
            this.pbxForSkillLevel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel19.Location = new System.Drawing.Point(369, 267);
            this.pbxForSkillLevel19.Name = "pbxForSkillLevel19";
            this.pbxForSkillLevel19.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel19.TabIndex = 126;
            this.pbxForSkillLevel19.TabStop = false;
            this.pbxForSkillLevel19.Tag = "0";
            // 
            // pbxForSkillLevel18
            // 
            this.pbxForSkillLevel18.AccessibleDescription = "509";
            this.pbxForSkillLevel18.AccessibleName = "0";
            this.pbxForSkillLevel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel18.Location = new System.Drawing.Point(302, 267);
            this.pbxForSkillLevel18.Name = "pbxForSkillLevel18";
            this.pbxForSkillLevel18.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel18.TabIndex = 125;
            this.pbxForSkillLevel18.TabStop = false;
            this.pbxForSkillLevel18.Tag = "0";
            // 
            // pbxForSkillLevel17
            // 
            this.pbxForSkillLevel17.AccessibleDescription = "503";
            this.pbxForSkillLevel17.AccessibleName = "0";
            this.pbxForSkillLevel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel17.Location = new System.Drawing.Point(235, 267);
            this.pbxForSkillLevel17.Name = "pbxForSkillLevel17";
            this.pbxForSkillLevel17.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel17.TabIndex = 124;
            this.pbxForSkillLevel17.TabStop = false;
            this.pbxForSkillLevel17.Tag = "0";
            // 
            // pbxForSkillLevel16
            // 
            this.pbxForSkillLevel16.AccessibleDescription = "526";
            this.pbxForSkillLevel16.AccessibleName = "0";
            this.pbxForSkillLevel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel16.Location = new System.Drawing.Point(168, 267);
            this.pbxForSkillLevel16.Name = "pbxForSkillLevel16";
            this.pbxForSkillLevel16.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel16.TabIndex = 123;
            this.pbxForSkillLevel16.TabStop = false;
            this.pbxForSkillLevel16.Tag = "2";
            // 
            // pbxForSkillLevel15
            // 
            this.pbxForSkillLevel15.AccessibleDescription = "512";
            this.pbxForSkillLevel15.AccessibleName = "0";
            this.pbxForSkillLevel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel15.Location = new System.Drawing.Point(470, 173);
            this.pbxForSkillLevel15.Name = "pbxForSkillLevel15";
            this.pbxForSkillLevel15.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel15.TabIndex = 119;
            this.pbxForSkillLevel15.TabStop = false;
            this.pbxForSkillLevel15.Tag = "2";
            // 
            // pbxForSkillLevel14
            // 
            this.pbxForSkillLevel14.AccessibleDescription = "523";
            this.pbxForSkillLevel14.AccessibleName = "0";
            this.pbxForSkillLevel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel14.Location = new System.Drawing.Point(403, 173);
            this.pbxForSkillLevel14.Name = "pbxForSkillLevel14";
            this.pbxForSkillLevel14.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel14.TabIndex = 118;
            this.pbxForSkillLevel14.TabStop = false;
            this.pbxForSkillLevel14.Tag = "0";
            // 
            // pbxForSkillLevel13
            // 
            this.pbxForSkillLevel13.AccessibleDescription = "521";
            this.pbxForSkillLevel13.AccessibleName = "0";
            this.pbxForSkillLevel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel13.Location = new System.Drawing.Point(336, 173);
            this.pbxForSkillLevel13.Name = "pbxForSkillLevel13";
            this.pbxForSkillLevel13.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel13.TabIndex = 117;
            this.pbxForSkillLevel13.TabStop = false;
            this.pbxForSkillLevel13.Tag = "0";
            // 
            // pbxForSkillLevel12
            // 
            this.pbxForSkillLevel12.AccessibleDescription = "504";
            this.pbxForSkillLevel12.AccessibleName = "0";
            this.pbxForSkillLevel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel12.Location = new System.Drawing.Point(269, 173);
            this.pbxForSkillLevel12.Name = "pbxForSkillLevel12";
            this.pbxForSkillLevel12.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel12.TabIndex = 116;
            this.pbxForSkillLevel12.TabStop = false;
            this.pbxForSkillLevel12.Tag = "0";
            // 
            // pbxForSkillLevel11
            // 
            this.pbxForSkillLevel11.AccessibleDescription = "501";
            this.pbxForSkillLevel11.AccessibleName = "0";
            this.pbxForSkillLevel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel11.Location = new System.Drawing.Point(202, 173);
            this.pbxForSkillLevel11.Name = "pbxForSkillLevel11";
            this.pbxForSkillLevel11.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel11.TabIndex = 115;
            this.pbxForSkillLevel11.TabStop = false;
            this.pbxForSkillLevel11.Tag = "2";
            // 
            // pbxForSkillLevel10
            // 
            this.pbxForSkillLevel10.AccessibleDescription = "506";
            this.pbxForSkillLevel10.AccessibleName = "0";
            this.pbxForSkillLevel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel10.Location = new System.Drawing.Point(135, 173);
            this.pbxForSkillLevel10.Name = "pbxForSkillLevel10";
            this.pbxForSkillLevel10.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel10.TabIndex = 114;
            this.pbxForSkillLevel10.TabStop = false;
            this.pbxForSkillLevel10.Tag = "0";
            // 
            // pbxForSkillLevel9
            // 
            this.pbxForSkillLevel9.AccessibleDescription = "515";
            this.pbxForSkillLevel9.AccessibleName = "0";
            this.pbxForSkillLevel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel9.Location = new System.Drawing.Point(600, 79);
            this.pbxForSkillLevel9.Name = "pbxForSkillLevel9";
            this.pbxForSkillLevel9.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel9.TabIndex = 113;
            this.pbxForSkillLevel9.TabStop = false;
            this.pbxForSkillLevel9.Tag = "2";
            // 
            // pbxForSkillLevel8
            // 
            this.pbxForSkillLevel8.AccessibleDescription = "513";
            this.pbxForSkillLevel8.AccessibleName = "0";
            this.pbxForSkillLevel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel8.Location = new System.Drawing.Point(533, 79);
            this.pbxForSkillLevel8.Name = "pbxForSkillLevel8";
            this.pbxForSkillLevel8.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel8.TabIndex = 112;
            this.pbxForSkillLevel8.TabStop = false;
            this.pbxForSkillLevel8.Tag = "2";
            // 
            // pbxForSkillLevel7
            // 
            this.pbxForSkillLevel7.AccessibleDescription = "522";
            this.pbxForSkillLevel7.AccessibleName = "0";
            this.pbxForSkillLevel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel7.Location = new System.Drawing.Point(466, 79);
            this.pbxForSkillLevel7.Name = "pbxForSkillLevel7";
            this.pbxForSkillLevel7.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel7.TabIndex = 111;
            this.pbxForSkillLevel7.TabStop = false;
            this.pbxForSkillLevel7.Tag = "2";
            // 
            // pbxForSkillLevel6
            // 
            this.pbxForSkillLevel6.AccessibleDescription = "518";
            this.pbxForSkillLevel6.AccessibleName = "0";
            this.pbxForSkillLevel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel6.Location = new System.Drawing.Point(399, 79);
            this.pbxForSkillLevel6.Name = "pbxForSkillLevel6";
            this.pbxForSkillLevel6.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel6.TabIndex = 110;
            this.pbxForSkillLevel6.TabStop = false;
            this.pbxForSkillLevel6.Tag = "2";
            // 
            // pbxForSkillLevel5
            // 
            this.pbxForSkillLevel5.AccessibleDescription = "524";
            this.pbxForSkillLevel5.AccessibleName = "0";
            this.pbxForSkillLevel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel5.Location = new System.Drawing.Point(332, 79);
            this.pbxForSkillLevel5.Name = "pbxForSkillLevel5";
            this.pbxForSkillLevel5.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel5.TabIndex = 109;
            this.pbxForSkillLevel5.TabStop = false;
            this.pbxForSkillLevel5.Tag = "2";
            // 
            // pbxForSkillLevel4
            // 
            this.pbxForSkillLevel4.AccessibleDescription = "505";
            this.pbxForSkillLevel4.AccessibleName = "0";
            this.pbxForSkillLevel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel4.Location = new System.Drawing.Point(265, 79);
            this.pbxForSkillLevel4.Name = "pbxForSkillLevel4";
            this.pbxForSkillLevel4.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel4.TabIndex = 108;
            this.pbxForSkillLevel4.TabStop = false;
            this.pbxForSkillLevel4.Tag = "2";
            // 
            // pbxForSkillLevel3
            // 
            this.pbxForSkillLevel3.AccessibleDescription = "502";
            this.pbxForSkillLevel3.AccessibleName = "0";
            this.pbxForSkillLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel3.Location = new System.Drawing.Point(198, 79);
            this.pbxForSkillLevel3.Name = "pbxForSkillLevel3";
            this.pbxForSkillLevel3.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel3.TabIndex = 107;
            this.pbxForSkillLevel3.TabStop = false;
            this.pbxForSkillLevel3.Tag = "2";
            // 
            // pbxForSkillLevel2
            // 
            this.pbxForSkillLevel2.AccessibleDescription = "500";
            this.pbxForSkillLevel2.AccessibleName = "0";
            this.pbxForSkillLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel2.Location = new System.Drawing.Point(131, 79);
            this.pbxForSkillLevel2.Name = "pbxForSkillLevel2";
            this.pbxForSkillLevel2.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel2.TabIndex = 106;
            this.pbxForSkillLevel2.TabStop = false;
            this.pbxForSkillLevel2.Tag = "2";
            // 
            // pbxForSkillLevel1
            // 
            this.pbxForSkillLevel1.AccessibleDescription = "519";
            this.pbxForSkillLevel1.AccessibleName = "0";
            this.pbxForSkillLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkillLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkillLevel1.Location = new System.Drawing.Point(64, 79);
            this.pbxForSkillLevel1.Name = "pbxForSkillLevel1";
            this.pbxForSkillLevel1.Size = new System.Drawing.Size(50, 18);
            this.pbxForSkillLevel1.TabIndex = 105;
            this.pbxForSkillLevel1.TabStop = false;
            this.pbxForSkillLevel1.Tag = "0";
            // 
            // pbxForSkill20
            // 
            this.pbxForSkill20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill20.Location = new System.Drawing.Point(436, 218);
            this.pbxForSkill20.Name = "pbxForSkill20";
            this.pbxForSkill20.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill20.TabIndex = 100;
            this.pbxForSkill20.TabStop = false;
            // 
            // pbxForSkill19
            // 
            this.pbxForSkill19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill19.Location = new System.Drawing.Point(369, 218);
            this.pbxForSkill19.Name = "pbxForSkill19";
            this.pbxForSkill19.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill19.TabIndex = 99;
            this.pbxForSkill19.TabStop = false;
            // 
            // pbxForSkill18
            // 
            this.pbxForSkill18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill18.Location = new System.Drawing.Point(302, 218);
            this.pbxForSkill18.Name = "pbxForSkill18";
            this.pbxForSkill18.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill18.TabIndex = 98;
            this.pbxForSkill18.TabStop = false;
            // 
            // pbxForSkill17
            // 
            this.pbxForSkill17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill17.Location = new System.Drawing.Point(235, 218);
            this.pbxForSkill17.Name = "pbxForSkill17";
            this.pbxForSkill17.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill17.TabIndex = 97;
            this.pbxForSkill17.TabStop = false;
            // 
            // pbxForSkill16
            // 
            this.pbxForSkill16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill16.Location = new System.Drawing.Point(168, 218);
            this.pbxForSkill16.Name = "pbxForSkill16";
            this.pbxForSkill16.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill16.TabIndex = 96;
            this.pbxForSkill16.TabStop = false;
            // 
            // pbxForSkill15
            // 
            this.pbxForSkill15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill15.Location = new System.Drawing.Point(470, 124);
            this.pbxForSkill15.Name = "pbxForSkill15";
            this.pbxForSkill15.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill15.TabIndex = 92;
            this.pbxForSkill15.TabStop = false;
            // 
            // pbxForSkill14
            // 
            this.pbxForSkill14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill14.Location = new System.Drawing.Point(403, 124);
            this.pbxForSkill14.Name = "pbxForSkill14";
            this.pbxForSkill14.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill14.TabIndex = 91;
            this.pbxForSkill14.TabStop = false;
            // 
            // pbxForSkill13
            // 
            this.pbxForSkill13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill13.Location = new System.Drawing.Point(336, 124);
            this.pbxForSkill13.Name = "pbxForSkill13";
            this.pbxForSkill13.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill13.TabIndex = 90;
            this.pbxForSkill13.TabStop = false;
            // 
            // pbxForSkill12
            // 
            this.pbxForSkill12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill12.Location = new System.Drawing.Point(269, 124);
            this.pbxForSkill12.Name = "pbxForSkill12";
            this.pbxForSkill12.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill12.TabIndex = 89;
            this.pbxForSkill12.TabStop = false;
            // 
            // pbxForSkill11
            // 
            this.pbxForSkill11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill11.Location = new System.Drawing.Point(202, 124);
            this.pbxForSkill11.Name = "pbxForSkill11";
            this.pbxForSkill11.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill11.TabIndex = 88;
            this.pbxForSkill11.TabStop = false;
            // 
            // pbxForSkill10
            // 
            this.pbxForSkill10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill10.Location = new System.Drawing.Point(135, 124);
            this.pbxForSkill10.Name = "pbxForSkill10";
            this.pbxForSkill10.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill10.TabIndex = 87;
            this.pbxForSkill10.TabStop = false;
            // 
            // pbxForSkill9
            // 
            this.pbxForSkill9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill9.Location = new System.Drawing.Point(600, 30);
            this.pbxForSkill9.Name = "pbxForSkill9";
            this.pbxForSkill9.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill9.TabIndex = 86;
            this.pbxForSkill9.TabStop = false;
            // 
            // pbxForSkill8
            // 
            this.pbxForSkill8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill8.Location = new System.Drawing.Point(533, 30);
            this.pbxForSkill8.Name = "pbxForSkill8";
            this.pbxForSkill8.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill8.TabIndex = 85;
            this.pbxForSkill8.TabStop = false;
            // 
            // pbxForSkill7
            // 
            this.pbxForSkill7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill7.Location = new System.Drawing.Point(466, 30);
            this.pbxForSkill7.Name = "pbxForSkill7";
            this.pbxForSkill7.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill7.TabIndex = 81;
            this.pbxForSkill7.TabStop = false;
            // 
            // pbxForSkill6
            // 
            this.pbxForSkill6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill6.Location = new System.Drawing.Point(399, 30);
            this.pbxForSkill6.Name = "pbxForSkill6";
            this.pbxForSkill6.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill6.TabIndex = 80;
            this.pbxForSkill6.TabStop = false;
            // 
            // pbxForSkill5
            // 
            this.pbxForSkill5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill5.Location = new System.Drawing.Point(332, 30);
            this.pbxForSkill5.Name = "pbxForSkill5";
            this.pbxForSkill5.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill5.TabIndex = 79;
            this.pbxForSkill5.TabStop = false;
            // 
            // pbxForSkill4
            // 
            this.pbxForSkill4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill4.Location = new System.Drawing.Point(265, 30);
            this.pbxForSkill4.Name = "pbxForSkill4";
            this.pbxForSkill4.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill4.TabIndex = 78;
            this.pbxForSkill4.TabStop = false;
            // 
            // pbxForSkill3
            // 
            this.pbxForSkill3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill3.Location = new System.Drawing.Point(198, 30);
            this.pbxForSkill3.Name = "pbxForSkill3";
            this.pbxForSkill3.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill3.TabIndex = 77;
            this.pbxForSkill3.TabStop = false;
            // 
            // pbxForSkill2
            // 
            this.pbxForSkill2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill2.Location = new System.Drawing.Point(131, 30);
            this.pbxForSkill2.Name = "pbxForSkill2";
            this.pbxForSkill2.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill2.TabIndex = 76;
            this.pbxForSkill2.TabStop = false;
            // 
            // pbxForSkill1
            // 
            this.pbxForSkill1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxForSkill1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxForSkill1.Location = new System.Drawing.Point(64, 30);
            this.pbxForSkill1.Name = "pbxForSkill1";
            this.pbxForSkill1.Size = new System.Drawing.Size(50, 50);
            this.pbxForSkill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxForSkill1.TabIndex = 75;
            this.pbxForSkill1.TabStop = false;
            this.tTStrSkill1.SetToolTip(this.pbxForSkill1, "Attack Skill\r\n\r\na jab to the targets Windpipe, \r\ncausing the winded status effect" +
        ".");
            // 
            // tabIcons
            // 
            this.tabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabIcons.ImageStream")));
            this.tabIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.tabIcons.Images.SetKeyName(0, "StrIcon.png");
            this.tabIcons.Images.SetKeyName(1, "DexIcon.png");
            this.tabIcons.Images.SetKeyName(2, "IntIcon.png");
            this.tabIcons.Images.SetKeyName(3, "ChaIcon.png");
            this.tabIcons.Images.SetKeyName(4, "PerIcon.png");
            this.tabIcons.Images.SetKeyName(5, "ForIcon.png");
            // 
            // lblSkillsCharacterName
            // 
            this.lblSkillsCharacterName.AutoSize = true;
            this.lblSkillsCharacterName.Location = new System.Drawing.Point(257, 10);
            this.lblSkillsCharacterName.Name = "lblSkillsCharacterName";
            this.lblSkillsCharacterName.Size = new System.Drawing.Size(84, 13);
            this.lblSkillsCharacterName.TabIndex = 10;
            this.lblSkillsCharacterName.Text = "Character Name";
            // 
            // cbxSkillsCharacterSelect
            // 
            this.cbxSkillsCharacterSelect.FormattingEnabled = true;
            this.cbxSkillsCharacterSelect.Location = new System.Drawing.Point(35, 6);
            this.cbxSkillsCharacterSelect.Name = "cbxSkillsCharacterSelect";
            this.cbxSkillsCharacterSelect.Size = new System.Drawing.Size(128, 21);
            this.cbxSkillsCharacterSelect.TabIndex = 9;
            this.cbxSkillsCharacterSelect.Tag = "";
            this.cbxSkillsCharacterSelect.Text = "Select Character";
            this.cbxSkillsCharacterSelect.SelectedIndexChanged += new System.EventHandler(this.cbxSkillsCharacterSelect_SelectedIndexChanged);
            // 
            // petsTab
            // 
            this.petsTab.Controls.Add(this.lblPetsToBeAdded);
            this.petsTab.Location = new System.Drawing.Point(4, 22);
            this.petsTab.Name = "petsTab";
            this.petsTab.Size = new System.Drawing.Size(659, 556);
            this.petsTab.TabIndex = 2;
            this.petsTab.Text = "Pets";
            this.petsTab.UseVisualStyleBackColor = true;
            // 
            // lblPetsToBeAdded
            // 
            this.lblPetsToBeAdded.AutoSize = true;
            this.lblPetsToBeAdded.Location = new System.Drawing.Point(3, 0);
            this.lblPetsToBeAdded.Name = "lblPetsToBeAdded";
            this.lblPetsToBeAdded.Size = new System.Drawing.Size(68, 13);
            this.lblPetsToBeAdded.TabIndex = 1;
            this.lblPetsToBeAdded.Text = "To be added";
            this.lblPetsToBeAdded.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deseasesTab
            // 
            this.deseasesTab.Controls.Add(this.lblDeseasesToBeAdded);
            this.deseasesTab.Location = new System.Drawing.Point(4, 22);
            this.deseasesTab.Name = "deseasesTab";
            this.deseasesTab.Size = new System.Drawing.Size(659, 556);
            this.deseasesTab.TabIndex = 3;
            this.deseasesTab.Text = "Deseases/Infestations";
            this.deseasesTab.UseVisualStyleBackColor = true;
            // 
            // lblDeseasesToBeAdded
            // 
            this.lblDeseasesToBeAdded.AutoSize = true;
            this.lblDeseasesToBeAdded.Location = new System.Drawing.Point(3, 0);
            this.lblDeseasesToBeAdded.Name = "lblDeseasesToBeAdded";
            this.lblDeseasesToBeAdded.Size = new System.Drawing.Size(71, 13);
            this.lblDeseasesToBeAdded.TabIndex = 1;
            this.lblDeseasesToBeAdded.Text = "To be added ";
            this.lblDeseasesToBeAdded.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unlockingTab
            // 
            this.unlockingTab.BackColor = System.Drawing.Color.LightGray;
            this.unlockingTab.Controls.Add(this.cbxDamageAmplifier);
            this.unlockingTab.Controls.Add(this.cbxMedicineCrafting);
            this.unlockingTab.Controls.Add(this.cbxBpSolarPanel);
            this.unlockingTab.Controls.Add(this.cbxBpRecycler);
            this.unlockingTab.Controls.Add(this.cbxBpQuantumBattery);
            this.unlockingTab.Controls.Add(this.cbxBpIndustrialGenerator);
            this.unlockingTab.Controls.Add(this.cbxBpDefibrilator);
            this.unlockingTab.Controls.Add(this.cbxBpLaboratory);
            this.unlockingTab.Controls.Add(this.cbxBpEfficientPlanter);
            this.unlockingTab.Controls.Add(this.cbxBpFlashbangMine);
            this.unlockingTab.Controls.Add(this.cbxBpMedicalBed);
            this.unlockingTab.Controls.Add(this.cbxBpElectricityTrap);
            this.unlockingTab.Controls.Add(this.cbxBpGasMine);
            this.unlockingTab.Controls.Add(this.cbxBpBatteryBank);
            this.unlockingTab.Controls.Add(this.cbxOtherCarPartsCrafting);
            this.unlockingTab.Controls.Add(this.cbxOtherGunCrafting);
            this.unlockingTab.Controls.Add(this.cbxOtherTrading);
            this.unlockingTab.Controls.Add(this.cbxRewardOldQ3);
            this.unlockingTab.Controls.Add(this.cbxRewardOldQ2);
            this.unlockingTab.Controls.Add(this.cbxRewardOldQ1);
            this.unlockingTab.Controls.Add(this.cbxRewardLosQ3);
            this.unlockingTab.Controls.Add(this.cbxRewardLosQ2);
            this.unlockingTab.Controls.Add(this.cbxRewardLosQ1);
            this.unlockingTab.Controls.Add(this.btnSaveUnlocks);
            this.unlockingTab.Controls.Add(this.btnUnlockAll);
            this.unlockingTab.Controls.Add(this.cbxRewardBlackQ3);
            this.unlockingTab.Controls.Add(this.cbxRewardBlackQ2);
            this.unlockingTab.Controls.Add(this.cbxRewardBlackQ1);
            this.unlockingTab.Controls.Add(this.cbxRewardNewQ3);
            this.unlockingTab.Controls.Add(this.cbxRewardNewQ2);
            this.unlockingTab.Controls.Add(this.cbxRewardNewQ1);
            this.unlockingTab.Controls.Add(this.cbxRewardCtkQ3);
            this.unlockingTab.Controls.Add(this.cbxRewardCtkQ2);
            this.unlockingTab.Controls.Add(this.cbxRewardCtkQ1);
            this.unlockingTab.Controls.Add(this.cbxDrugsTrankwill);
            this.unlockingTab.Controls.Add(this.cbxDrugsSnodge);
            this.unlockingTab.Controls.Add(this.cbxDrugsSigma);
            this.unlockingTab.Controls.Add(this.cbxDrugsPython);
            this.unlockingTab.Controls.Add(this.cbxDrugsFeederral);
            this.unlockingTab.Controls.Add(this.cbxDrugsCrunk);
            this.unlockingTab.Controls.Add(this.cbxDrugsAlcohol);
            this.unlockingTab.Controls.Add(this.cbxRewardChurchQ3);
            this.unlockingTab.Controls.Add(this.cbxRewardChurchQ2);
            this.unlockingTab.Controls.Add(this.cbxRewardChurchQ1);
            this.unlockingTab.Controls.Add(this.btnRevealMap);
            this.unlockingTab.Controls.Add(this.cbxWorkbenchTier4);
            this.unlockingTab.Controls.Add(this.cbxWorkbenchTier3);
            this.unlockingTab.Controls.Add(this.cbxWorkbenchTier2);
            this.unlockingTab.Controls.Add(this.cbxDraftingTableTier4);
            this.unlockingTab.Controls.Add(this.cbxDraftingTableTier3);
            this.unlockingTab.Controls.Add(this.cbxDraftingTableTier2);
            this.unlockingTab.Controls.Add(this.label32);
            this.unlockingTab.Controls.Add(this.label31);
            this.unlockingTab.Controls.Add(this.label27);
            this.unlockingTab.Controls.Add(this.label26);
            this.unlockingTab.Controls.Add(this.label30);
            this.unlockingTab.Controls.Add(this.label29);
            this.unlockingTab.Controls.Add(this.label28);
            this.unlockingTab.Controls.Add(this.label25);
            this.unlockingTab.Controls.Add(this.label24);
            this.unlockingTab.Controls.Add(this.lblWorkbench);
            this.unlockingTab.Controls.Add(this.lblDraftingTable);
            this.unlockingTab.Location = new System.Drawing.Point(4, 22);
            this.unlockingTab.Name = "unlockingTab";
            this.unlockingTab.Size = new System.Drawing.Size(659, 556);
            this.unlockingTab.TabIndex = 4;
            this.unlockingTab.Text = " Unlock";
            this.unlockingTab.Click += new System.EventHandler(this.unlockingTab_Click);
            // 
            // cbxDamageAmplifier
            // 
            this.cbxDamageAmplifier.AutoSize = true;
            this.cbxDamageAmplifier.Location = new System.Drawing.Point(146, 353);
            this.cbxDamageAmplifier.Name = "cbxDamageAmplifier";
            this.cbxDamageAmplifier.Size = new System.Drawing.Size(107, 17);
            this.cbxDamageAmplifier.TabIndex = 82;
            this.cbxDamageAmplifier.Text = "Damage amplifier";
            this.cbxDamageAmplifier.UseVisualStyleBackColor = true;
            // 
            // cbxMedicineCrafting
            // 
            this.cbxMedicineCrafting.AutoSize = true;
            this.cbxMedicineCrafting.Location = new System.Drawing.Point(146, 335);
            this.cbxMedicineCrafting.Name = "cbxMedicineCrafting";
            this.cbxMedicineCrafting.Size = new System.Drawing.Size(107, 17);
            this.cbxMedicineCrafting.TabIndex = 81;
            this.cbxMedicineCrafting.Text = "Medicine crafting";
            this.cbxMedicineCrafting.UseVisualStyleBackColor = true;
            // 
            // cbxBpSolarPanel
            // 
            this.cbxBpSolarPanel.AutoSize = true;
            this.cbxBpSolarPanel.Location = new System.Drawing.Point(290, 214);
            this.cbxBpSolarPanel.Name = "cbxBpSolarPanel";
            this.cbxBpSolarPanel.Size = new System.Drawing.Size(80, 17);
            this.cbxBpSolarPanel.TabIndex = 80;
            this.cbxBpSolarPanel.Text = "Solar Panel";
            this.cbxBpSolarPanel.UseVisualStyleBackColor = true;
            // 
            // cbxBpRecycler
            // 
            this.cbxBpRecycler.AutoSize = true;
            this.cbxBpRecycler.Location = new System.Drawing.Point(290, 194);
            this.cbxBpRecycler.Name = "cbxBpRecycler";
            this.cbxBpRecycler.Size = new System.Drawing.Size(68, 17);
            this.cbxBpRecycler.TabIndex = 79;
            this.cbxBpRecycler.Text = "Recycler";
            this.cbxBpRecycler.UseVisualStyleBackColor = true;
            // 
            // cbxBpQuantumBattery
            // 
            this.cbxBpQuantumBattery.AutoSize = true;
            this.cbxBpQuantumBattery.Location = new System.Drawing.Point(160, 195);
            this.cbxBpQuantumBattery.Name = "cbxBpQuantumBattery";
            this.cbxBpQuantumBattery.Size = new System.Drawing.Size(105, 17);
            this.cbxBpQuantumBattery.TabIndex = 78;
            this.cbxBpQuantumBattery.Text = "Quantum Battery";
            this.cbxBpQuantumBattery.UseVisualStyleBackColor = true;
            // 
            // cbxBpIndustrialGenerator
            // 
            this.cbxBpIndustrialGenerator.AutoSize = true;
            this.cbxBpIndustrialGenerator.Location = new System.Drawing.Point(12, 195);
            this.cbxBpIndustrialGenerator.Name = "cbxBpIndustrialGenerator";
            this.cbxBpIndustrialGenerator.Size = new System.Drawing.Size(118, 17);
            this.cbxBpIndustrialGenerator.TabIndex = 77;
            this.cbxBpIndustrialGenerator.Text = "Industrial Generator";
            this.cbxBpIndustrialGenerator.UseVisualStyleBackColor = true;
            // 
            // cbxBpDefibrilator
            // 
            this.cbxBpDefibrilator.AutoSize = true;
            this.cbxBpDefibrilator.Location = new System.Drawing.Point(160, 214);
            this.cbxBpDefibrilator.Name = "cbxBpDefibrilator";
            this.cbxBpDefibrilator.Size = new System.Drawing.Size(76, 17);
            this.cbxBpDefibrilator.TabIndex = 75;
            this.cbxBpDefibrilator.Text = "Defibrilator";
            this.cbxBpDefibrilator.UseVisualStyleBackColor = true;
            // 
            // cbxBpLaboratory
            // 
            this.cbxBpLaboratory.AutoSize = true;
            this.cbxBpLaboratory.Location = new System.Drawing.Point(290, 176);
            this.cbxBpLaboratory.Name = "cbxBpLaboratory";
            this.cbxBpLaboratory.Size = new System.Drawing.Size(76, 17);
            this.cbxBpLaboratory.TabIndex = 74;
            this.cbxBpLaboratory.Text = "Laboratory";
            this.cbxBpLaboratory.UseVisualStyleBackColor = true;
            // 
            // cbxBpEfficientPlanter
            // 
            this.cbxBpEfficientPlanter.AutoSize = true;
            this.cbxBpEfficientPlanter.Location = new System.Drawing.Point(160, 177);
            this.cbxBpEfficientPlanter.Name = "cbxBpEfficientPlanter";
            this.cbxBpEfficientPlanter.Size = new System.Drawing.Size(100, 17);
            this.cbxBpEfficientPlanter.TabIndex = 73;
            this.cbxBpEfficientPlanter.Text = "Efficient Planter";
            this.cbxBpEfficientPlanter.UseVisualStyleBackColor = true;
            // 
            // cbxBpFlashbangMine
            // 
            this.cbxBpFlashbangMine.AutoSize = true;
            this.cbxBpFlashbangMine.Location = new System.Drawing.Point(12, 177);
            this.cbxBpFlashbangMine.Name = "cbxBpFlashbangMine";
            this.cbxBpFlashbangMine.Size = new System.Drawing.Size(101, 17);
            this.cbxBpFlashbangMine.TabIndex = 72;
            this.cbxBpFlashbangMine.Text = "Flashbang Mine";
            this.cbxBpFlashbangMine.UseVisualStyleBackColor = true;
            // 
            // cbxBpMedicalBed
            // 
            this.cbxBpMedicalBed.AutoSize = true;
            this.cbxBpMedicalBed.Location = new System.Drawing.Point(12, 214);
            this.cbxBpMedicalBed.Name = "cbxBpMedicalBed";
            this.cbxBpMedicalBed.Size = new System.Drawing.Size(85, 17);
            this.cbxBpMedicalBed.TabIndex = 71;
            this.cbxBpMedicalBed.Text = "Medical Bed";
            this.cbxBpMedicalBed.UseVisualStyleBackColor = true;
            // 
            // cbxBpElectricityTrap
            // 
            this.cbxBpElectricityTrap.AutoSize = true;
            this.cbxBpElectricityTrap.Location = new System.Drawing.Point(290, 158);
            this.cbxBpElectricityTrap.Name = "cbxBpElectricityTrap";
            this.cbxBpElectricityTrap.Size = new System.Drawing.Size(92, 17);
            this.cbxBpElectricityTrap.TabIndex = 70;
            this.cbxBpElectricityTrap.Text = "Electricity trap";
            this.cbxBpElectricityTrap.UseVisualStyleBackColor = true;
            // 
            // cbxBpGasMine
            // 
            this.cbxBpGasMine.AutoSize = true;
            this.cbxBpGasMine.Location = new System.Drawing.Point(160, 159);
            this.cbxBpGasMine.Name = "cbxBpGasMine";
            this.cbxBpGasMine.Size = new System.Drawing.Size(68, 17);
            this.cbxBpGasMine.TabIndex = 69;
            this.cbxBpGasMine.Text = "gas mine";
            this.cbxBpGasMine.UseVisualStyleBackColor = true;
            // 
            // cbxBpBatteryBank
            // 
            this.cbxBpBatteryBank.AutoSize = true;
            this.cbxBpBatteryBank.Location = new System.Drawing.Point(12, 159);
            this.cbxBpBatteryBank.Name = "cbxBpBatteryBank";
            this.cbxBpBatteryBank.Size = new System.Drawing.Size(86, 17);
            this.cbxBpBatteryBank.TabIndex = 68;
            this.cbxBpBatteryBank.Text = "Battery bank";
            this.cbxBpBatteryBank.UseVisualStyleBackColor = true;
            // 
            // cbxOtherCarPartsCrafting
            // 
            this.cbxOtherCarPartsCrafting.AutoSize = true;
            this.cbxOtherCarPartsCrafting.Location = new System.Drawing.Point(146, 315);
            this.cbxOtherCarPartsCrafting.Name = "cbxOtherCarPartsCrafting";
            this.cbxOtherCarPartsCrafting.Size = new System.Drawing.Size(107, 17);
            this.cbxOtherCarPartsCrafting.TabIndex = 63;
            this.cbxOtherCarPartsCrafting.Text = "Car Parts crafting";
            this.cbxOtherCarPartsCrafting.UseVisualStyleBackColor = true;
            // 
            // cbxOtherGunCrafting
            // 
            this.cbxOtherGunCrafting.AutoSize = true;
            this.cbxOtherGunCrafting.Location = new System.Drawing.Point(146, 297);
            this.cbxOtherGunCrafting.Name = "cbxOtherGunCrafting";
            this.cbxOtherGunCrafting.Size = new System.Drawing.Size(81, 17);
            this.cbxOtherGunCrafting.TabIndex = 62;
            this.cbxOtherGunCrafting.Text = "Guncrafting";
            this.cbxOtherGunCrafting.UseVisualStyleBackColor = true;
            // 
            // cbxOtherTrading
            // 
            this.cbxOtherTrading.AutoSize = true;
            this.cbxOtherTrading.Location = new System.Drawing.Point(146, 279);
            this.cbxOtherTrading.Name = "cbxOtherTrading";
            this.cbxOtherTrading.Size = new System.Drawing.Size(119, 17);
            this.cbxOtherTrading.TabIndex = 60;
            this.cbxOtherTrading.Text = "Better trading Deals";
            this.cbxOtherTrading.UseVisualStyleBackColor = true;
            // 
            // cbxRewardOldQ3
            // 
            this.cbxRewardOldQ3.AutoSize = true;
            this.cbxRewardOldQ3.Enabled = false;
            this.cbxRewardOldQ3.Location = new System.Drawing.Point(456, 518);
            this.cbxRewardOldQ3.Name = "cbxRewardOldQ3";
            this.cbxRewardOldQ3.Size = new System.Drawing.Size(35, 17);
            this.cbxRewardOldQ3.TabIndex = 58;
            this.cbxRewardOldQ3.Text = "---";
            this.cbxRewardOldQ3.UseVisualStyleBackColor = true;
            // 
            // cbxRewardOldQ2
            // 
            this.cbxRewardOldQ2.AutoSize = true;
            this.cbxRewardOldQ2.Enabled = false;
            this.cbxRewardOldQ2.Location = new System.Drawing.Point(456, 500);
            this.cbxRewardOldQ2.Name = "cbxRewardOldQ2";
            this.cbxRewardOldQ2.Size = new System.Drawing.Size(35, 17);
            this.cbxRewardOldQ2.TabIndex = 57;
            this.cbxRewardOldQ2.Text = "---";
            this.cbxRewardOldQ2.UseVisualStyleBackColor = true;
            // 
            // cbxRewardOldQ1
            // 
            this.cbxRewardOldQ1.AutoSize = true;
            this.cbxRewardOldQ1.Enabled = false;
            this.cbxRewardOldQ1.Location = new System.Drawing.Point(456, 482);
            this.cbxRewardOldQ1.Name = "cbxRewardOldQ1";
            this.cbxRewardOldQ1.Size = new System.Drawing.Size(35, 17);
            this.cbxRewardOldQ1.TabIndex = 56;
            this.cbxRewardOldQ1.Text = "---";
            this.cbxRewardOldQ1.UseVisualStyleBackColor = true;
            // 
            // cbxRewardLosQ3
            // 
            this.cbxRewardLosQ3.AutoSize = true;
            this.cbxRewardLosQ3.Location = new System.Drawing.Point(456, 430);
            this.cbxRewardLosQ3.Name = "cbxRewardLosQ3";
            this.cbxRewardLosQ3.Size = new System.Drawing.Size(110, 17);
            this.cbxRewardLosQ3.TabIndex = 54;
            this.cbxRewardLosQ3.Text = "Vaccine excellent";
            this.cbxRewardLosQ3.UseVisualStyleBackColor = true;
            // 
            // cbxRewardLosQ2
            // 
            this.cbxRewardLosQ2.AutoSize = true;
            this.cbxRewardLosQ2.Location = new System.Drawing.Point(456, 412);
            this.cbxRewardLosQ2.Name = "cbxRewardLosQ2";
            this.cbxRewardLosQ2.Size = new System.Drawing.Size(92, 17);
            this.cbxRewardLosQ2.TabIndex = 53;
            this.cbxRewardLosQ2.Text = "Vaccine good";
            this.cbxRewardLosQ2.UseVisualStyleBackColor = true;
            // 
            // cbxRewardLosQ1
            // 
            this.cbxRewardLosQ1.AutoSize = true;
            this.cbxRewardLosQ1.Location = new System.Drawing.Point(456, 394);
            this.cbxRewardLosQ1.Name = "cbxRewardLosQ1";
            this.cbxRewardLosQ1.Size = new System.Drawing.Size(89, 17);
            this.cbxRewardLosQ1.TabIndex = 52;
            this.cbxRewardLosQ1.Text = "Vaccine poor";
            this.cbxRewardLosQ1.UseVisualStyleBackColor = true;
            // 
            // btnSaveUnlocks
            // 
            this.btnSaveUnlocks.Location = new System.Drawing.Point(264, 507);
            this.btnSaveUnlocks.Name = "btnSaveUnlocks";
            this.btnSaveUnlocks.Size = new System.Drawing.Size(107, 26);
            this.btnSaveUnlocks.TabIndex = 50;
            this.btnSaveUnlocks.Text = "Save UNLOcKS";
            this.btnSaveUnlocks.UseVisualStyleBackColor = true;
            this.btnSaveUnlocks.Click += new System.EventHandler(this.btnSaveUnlocks_Click);
            // 
            // btnUnlockAll
            // 
            this.btnUnlockAll.Location = new System.Drawing.Point(138, 507);
            this.btnUnlockAll.Name = "btnUnlockAll";
            this.btnUnlockAll.Size = new System.Drawing.Size(107, 26);
            this.btnUnlockAll.TabIndex = 49;
            this.btnUnlockAll.Text = "Unlock ALL";
            this.btnUnlockAll.UseVisualStyleBackColor = true;
            this.btnUnlockAll.Click += new System.EventHandler(this.btnUnlockAll_Click);
            // 
            // cbxRewardBlackQ3
            // 
            this.cbxRewardBlackQ3.AutoSize = true;
            this.cbxRewardBlackQ3.Location = new System.Drawing.Point(456, 342);
            this.cbxRewardBlackQ3.Name = "cbxRewardBlackQ3";
            this.cbxRewardBlackQ3.Size = new System.Drawing.Size(122, 17);
            this.cbxRewardBlackQ3.TabIndex = 48;
            this.cbxRewardBlackQ3.Text = "Military Sentry Turret";
            this.cbxRewardBlackQ3.UseVisualStyleBackColor = true;
            // 
            // cbxRewardBlackQ2
            // 
            this.cbxRewardBlackQ2.AutoSize = true;
            this.cbxRewardBlackQ2.Location = new System.Drawing.Point(456, 324);
            this.cbxRewardBlackQ2.Name = "cbxRewardBlackQ2";
            this.cbxRewardBlackQ2.Size = new System.Drawing.Size(134, 17);
            this.cbxRewardBlackQ2.TabIndex = 47;
            this.cbxRewardBlackQ2.Text = "Improved Sentry Turret";
            this.cbxRewardBlackQ2.UseVisualStyleBackColor = true;
            // 
            // cbxRewardBlackQ1
            // 
            this.cbxRewardBlackQ1.AutoSize = true;
            this.cbxRewardBlackQ1.Location = new System.Drawing.Point(456, 306);
            this.cbxRewardBlackQ1.Name = "cbxRewardBlackQ1";
            this.cbxRewardBlackQ1.Size = new System.Drawing.Size(87, 17);
            this.cbxRewardBlackQ1.TabIndex = 46;
            this.cbxRewardBlackQ1.Text = "Sentry Turret";
            this.cbxRewardBlackQ1.UseVisualStyleBackColor = true;
            // 
            // cbxRewardNewQ3
            // 
            this.cbxRewardNewQ3.AutoSize = true;
            this.cbxRewardNewQ3.Location = new System.Drawing.Point(456, 255);
            this.cbxRewardNewQ3.Name = "cbxRewardNewQ3";
            this.cbxRewardNewQ3.Size = new System.Drawing.Size(113, 17);
            this.cbxRewardNewQ3.TabIndex = 44;
            this.cbxRewardNewQ3.Text = "Pulserifle excellent";
            this.cbxRewardNewQ3.UseVisualStyleBackColor = true;
            // 
            // cbxRewardNewQ2
            // 
            this.cbxRewardNewQ2.AutoSize = true;
            this.cbxRewardNewQ2.Location = new System.Drawing.Point(456, 237);
            this.cbxRewardNewQ2.Name = "cbxRewardNewQ2";
            this.cbxRewardNewQ2.Size = new System.Drawing.Size(95, 17);
            this.cbxRewardNewQ2.TabIndex = 43;
            this.cbxRewardNewQ2.Text = "Pulserifle good";
            this.cbxRewardNewQ2.UseVisualStyleBackColor = true;
            // 
            // cbxRewardNewQ1
            // 
            this.cbxRewardNewQ1.AutoSize = true;
            this.cbxRewardNewQ1.Location = new System.Drawing.Point(456, 219);
            this.cbxRewardNewQ1.Name = "cbxRewardNewQ1";
            this.cbxRewardNewQ1.Size = new System.Drawing.Size(92, 17);
            this.cbxRewardNewQ1.TabIndex = 42;
            this.cbxRewardNewQ1.Text = "Pulserifle poor";
            this.cbxRewardNewQ1.UseVisualStyleBackColor = true;
            // 
            // cbxRewardCtkQ3
            // 
            this.cbxRewardCtkQ3.AutoSize = true;
            this.cbxRewardCtkQ3.Location = new System.Drawing.Point(456, 167);
            this.cbxRewardCtkQ3.Name = "cbxRewardCtkQ3";
            this.cbxRewardCtkQ3.Size = new System.Drawing.Size(111, 17);
            this.cbxRewardCtkQ3.TabIndex = 40;
            this.cbxRewardCtkQ3.Text = "Brutal Morningstar";
            this.cbxRewardCtkQ3.UseVisualStyleBackColor = true;
            // 
            // cbxRewardCtkQ2
            // 
            this.cbxRewardCtkQ2.AutoSize = true;
            this.cbxRewardCtkQ2.Location = new System.Drawing.Point(456, 149);
            this.cbxRewardCtkQ2.Name = "cbxRewardCtkQ2";
            this.cbxRewardCtkQ2.Size = new System.Drawing.Size(110, 17);
            this.cbxRewardCtkQ2.TabIndex = 39;
            this.cbxRewardCtkQ2.Text = "Toxic Morningstar";
            this.cbxRewardCtkQ2.UseVisualStyleBackColor = true;
            // 
            // cbxRewardCtkQ1
            // 
            this.cbxRewardCtkQ1.AutoSize = true;
            this.cbxRewardCtkQ1.Location = new System.Drawing.Point(456, 131);
            this.cbxRewardCtkQ1.Name = "cbxRewardCtkQ1";
            this.cbxRewardCtkQ1.Size = new System.Drawing.Size(81, 17);
            this.cbxRewardCtkQ1.TabIndex = 38;
            this.cbxRewardCtkQ1.Text = "Morningstar";
            this.cbxRewardCtkQ1.UseVisualStyleBackColor = true;
            // 
            // cbxDrugsTrankwill
            // 
            this.cbxDrugsTrankwill.AutoSize = true;
            this.cbxDrugsTrankwill.Location = new System.Drawing.Point(12, 389);
            this.cbxDrugsTrankwill.Name = "cbxDrugsTrankwill";
            this.cbxDrugsTrankwill.Size = new System.Drawing.Size(68, 17);
            this.cbxDrugsTrankwill.TabIndex = 20;
            this.cbxDrugsTrankwill.Text = "Trankwill";
            this.cbxDrugsTrankwill.UseVisualStyleBackColor = true;
            // 
            // cbxDrugsSnodge
            // 
            this.cbxDrugsSnodge.AutoSize = true;
            this.cbxDrugsSnodge.Location = new System.Drawing.Point(12, 371);
            this.cbxDrugsSnodge.Name = "cbxDrugsSnodge";
            this.cbxDrugsSnodge.Size = new System.Drawing.Size(63, 17);
            this.cbxDrugsSnodge.TabIndex = 19;
            this.cbxDrugsSnodge.Text = "Snodge";
            this.cbxDrugsSnodge.UseVisualStyleBackColor = true;
            // 
            // cbxDrugsSigma
            // 
            this.cbxDrugsSigma.AutoSize = true;
            this.cbxDrugsSigma.Location = new System.Drawing.Point(12, 353);
            this.cbxDrugsSigma.Name = "cbxDrugsSigma";
            this.cbxDrugsSigma.Size = new System.Drawing.Size(55, 17);
            this.cbxDrugsSigma.TabIndex = 18;
            this.cbxDrugsSigma.Text = "Sigma";
            this.cbxDrugsSigma.UseVisualStyleBackColor = true;
            // 
            // cbxDrugsPython
            // 
            this.cbxDrugsPython.AutoSize = true;
            this.cbxDrugsPython.Location = new System.Drawing.Point(12, 335);
            this.cbxDrugsPython.Name = "cbxDrugsPython";
            this.cbxDrugsPython.Size = new System.Drawing.Size(59, 17);
            this.cbxDrugsPython.TabIndex = 17;
            this.cbxDrugsPython.Text = "Python";
            this.cbxDrugsPython.UseVisualStyleBackColor = true;
            // 
            // cbxDrugsFeederral
            // 
            this.cbxDrugsFeederral.AutoSize = true;
            this.cbxDrugsFeederral.Location = new System.Drawing.Point(12, 317);
            this.cbxDrugsFeederral.Name = "cbxDrugsFeederral";
            this.cbxDrugsFeederral.Size = new System.Drawing.Size(70, 17);
            this.cbxDrugsFeederral.TabIndex = 16;
            this.cbxDrugsFeederral.Text = "Feederral";
            this.cbxDrugsFeederral.UseVisualStyleBackColor = true;
            // 
            // cbxDrugsCrunk
            // 
            this.cbxDrugsCrunk.AutoSize = true;
            this.cbxDrugsCrunk.Location = new System.Drawing.Point(12, 299);
            this.cbxDrugsCrunk.Name = "cbxDrugsCrunk";
            this.cbxDrugsCrunk.Size = new System.Drawing.Size(54, 17);
            this.cbxDrugsCrunk.TabIndex = 15;
            this.cbxDrugsCrunk.Text = "Crunk";
            this.cbxDrugsCrunk.UseVisualStyleBackColor = true;
            // 
            // cbxDrugsAlcohol
            // 
            this.cbxDrugsAlcohol.AutoSize = true;
            this.cbxDrugsAlcohol.Location = new System.Drawing.Point(12, 281);
            this.cbxDrugsAlcohol.Name = "cbxDrugsAlcohol";
            this.cbxDrugsAlcohol.Size = new System.Drawing.Size(61, 17);
            this.cbxDrugsAlcohol.TabIndex = 14;
            this.cbxDrugsAlcohol.Text = "Alcohol";
            this.cbxDrugsAlcohol.UseVisualStyleBackColor = true;
            // 
            // cbxRewardChurchQ3
            // 
            this.cbxRewardChurchQ3.AutoSize = true;
            this.cbxRewardChurchQ3.Location = new System.Drawing.Point(456, 77);
            this.cbxRewardChurchQ3.Name = "cbxRewardChurchQ3";
            this.cbxRewardChurchQ3.Size = new System.Drawing.Size(151, 17);
            this.cbxRewardChurchQ3.TabIndex = 12;
            this.cbxRewardChurchQ3.Text = "Ultimate Indoctrination Cell";
            this.cbxRewardChurchQ3.UseVisualStyleBackColor = true;
            // 
            // cbxRewardChurchQ2
            // 
            this.cbxRewardChurchQ2.AutoSize = true;
            this.cbxRewardChurchQ2.Location = new System.Drawing.Point(456, 59);
            this.cbxRewardChurchQ2.Name = "cbxRewardChurchQ2";
            this.cbxRewardChurchQ2.Size = new System.Drawing.Size(162, 17);
            this.cbxRewardChurchQ2.TabIndex = 11;
            this.cbxRewardChurchQ2.Text = "Advanced Indoctrination Cell";
            this.cbxRewardChurchQ2.UseVisualStyleBackColor = true;
            // 
            // cbxRewardChurchQ1
            // 
            this.cbxRewardChurchQ1.AutoSize = true;
            this.cbxRewardChurchQ1.Location = new System.Drawing.Point(456, 41);
            this.cbxRewardChurchQ1.Name = "cbxRewardChurchQ1";
            this.cbxRewardChurchQ1.Size = new System.Drawing.Size(110, 17);
            this.cbxRewardChurchQ1.TabIndex = 10;
            this.cbxRewardChurchQ1.Text = "Indoctrination Cell";
            this.cbxRewardChurchQ1.UseVisualStyleBackColor = true;
            // 
            // btnRevealMap
            // 
            this.btnRevealMap.Location = new System.Drawing.Point(12, 507);
            this.btnRevealMap.Name = "btnRevealMap";
            this.btnRevealMap.Size = new System.Drawing.Size(107, 26);
            this.btnRevealMap.TabIndex = 8;
            this.btnRevealMap.Text = "Reveal Map";
            this.btnRevealMap.UseVisualStyleBackColor = true;
            this.btnRevealMap.Click += new System.EventHandler(this.btnRevealMap_Click);
            // 
            // cbxWorkbenchTier4
            // 
            this.cbxWorkbenchTier4.AutoSize = true;
            this.cbxWorkbenchTier4.Location = new System.Drawing.Point(147, 89);
            this.cbxWorkbenchTier4.Name = "cbxWorkbenchTier4";
            this.cbxWorkbenchTier4.Size = new System.Drawing.Size(53, 17);
            this.cbxWorkbenchTier4.TabIndex = 7;
            this.cbxWorkbenchTier4.Text = "Tier 4";
            this.cbxWorkbenchTier4.UseVisualStyleBackColor = true;
            // 
            // cbxWorkbenchTier3
            // 
            this.cbxWorkbenchTier3.AutoSize = true;
            this.cbxWorkbenchTier3.Location = new System.Drawing.Point(147, 72);
            this.cbxWorkbenchTier3.Name = "cbxWorkbenchTier3";
            this.cbxWorkbenchTier3.Size = new System.Drawing.Size(53, 17);
            this.cbxWorkbenchTier3.TabIndex = 6;
            this.cbxWorkbenchTier3.Text = "Tier 3";
            this.cbxWorkbenchTier3.UseVisualStyleBackColor = true;
            // 
            // cbxWorkbenchTier2
            // 
            this.cbxWorkbenchTier2.AutoSize = true;
            this.cbxWorkbenchTier2.Location = new System.Drawing.Point(147, 55);
            this.cbxWorkbenchTier2.Name = "cbxWorkbenchTier2";
            this.cbxWorkbenchTier2.Size = new System.Drawing.Size(53, 17);
            this.cbxWorkbenchTier2.TabIndex = 5;
            this.cbxWorkbenchTier2.Text = "Tier 2";
            this.cbxWorkbenchTier2.UseVisualStyleBackColor = true;
            // 
            // cbxDraftingTableTier4
            // 
            this.cbxDraftingTableTier4.AutoSize = true;
            this.cbxDraftingTableTier4.Location = new System.Drawing.Point(12, 89);
            this.cbxDraftingTableTier4.Name = "cbxDraftingTableTier4";
            this.cbxDraftingTableTier4.Size = new System.Drawing.Size(53, 17);
            this.cbxDraftingTableTier4.TabIndex = 3;
            this.cbxDraftingTableTier4.Text = "Tier 4";
            this.cbxDraftingTableTier4.UseVisualStyleBackColor = true;
            // 
            // cbxDraftingTableTier3
            // 
            this.cbxDraftingTableTier3.AutoSize = true;
            this.cbxDraftingTableTier3.Location = new System.Drawing.Point(12, 72);
            this.cbxDraftingTableTier3.Name = "cbxDraftingTableTier3";
            this.cbxDraftingTableTier3.Size = new System.Drawing.Size(53, 17);
            this.cbxDraftingTableTier3.TabIndex = 2;
            this.cbxDraftingTableTier3.Text = "Tier 3";
            this.cbxDraftingTableTier3.UseVisualStyleBackColor = true;
            // 
            // cbxDraftingTableTier2
            // 
            this.cbxDraftingTableTier2.AutoSize = true;
            this.cbxDraftingTableTier2.Location = new System.Drawing.Point(12, 55);
            this.cbxDraftingTableTier2.Name = "cbxDraftingTableTier2";
            this.cbxDraftingTableTier2.Size = new System.Drawing.Size(53, 17);
            this.cbxDraftingTableTier2.TabIndex = 1;
            this.cbxDraftingTableTier2.Text = "Tier 2";
            this.cbxDraftingTableTier2.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label32.Image = global::Sheltered_2_SE.Properties.Resources.TextBackgroundMedium;
            this.label32.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label32.Location = new System.Drawing.Point(8, 136);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 13);
            this.label32.TabIndex = 67;
            this.label32.Text = "    Blueprints          ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label31.Image = global::Sheltered_2_SE.Properties.Resources.TextBackgroundMedium;
            this.label31.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label31.Location = new System.Drawing.Point(143, 256);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(95, 13);
            this.label31.TabIndex = 64;
            this.label31.Text = "   other unlocks     ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label27.Location = new System.Drawing.Point(407, 458);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(192, 13);
            this.label27.TabIndex = 55;
            this.label27.Text = "     Reward Ally with The old clan          ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label26.Location = new System.Drawing.Point(407, 370);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(214, 13);
            this.label26.TabIndex = 51;
            this.label26.Text = "     Reward Ally with LOS MUERTOS           ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
            this.label30.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label30.Location = new System.Drawing.Point(407, 280);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(194, 13);
            this.label30.TabIndex = 45;
            this.label30.Text = "     Reward Ally with Black roses            ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label29.Image = ((System.Drawing.Image)(resources.GetObject("label29.Image")));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label29.Location = new System.Drawing.Point(407, 195);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(197, 13);
            this.label29.TabIndex = 41;
            this.label29.Text = "     Reward Ally with The New Order       ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label28.Image = global::Sheltered_2_SE.Properties.Resources.TextBackgroundNew;
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label28.Location = new System.Drawing.Point(407, 107);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(205, 13);
            this.label28.TabIndex = 37;
            this.label28.Text = "     Reward Ally with CTK Mob                   ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label25.Image = global::Sheltered_2_SE.Properties.Resources.TextBackgroundMedium;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label25.Location = new System.Drawing.Point(9, 256);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "   Drug recipes        ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.label24.Image = global::Sheltered_2_SE.Properties.Resources.TextBackgroundNew;
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label24.Location = new System.Drawing.Point(407, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(196, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "     Reward Ally with Church of Hope      ";
            // 
            // lblWorkbench
            // 
            this.lblWorkbench.AutoSize = true;
            this.lblWorkbench.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.lblWorkbench.Image = global::Sheltered_2_SE.Properties.Resources.TextBackgroundMedium;
            this.lblWorkbench.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWorkbench.Location = new System.Drawing.Point(143, 31);
            this.lblWorkbench.Name = "lblWorkbench";
            this.lblWorkbench.Size = new System.Drawing.Size(105, 13);
            this.lblWorkbench.TabIndex = 4;
            this.lblWorkbench.Text = "   Workbench           ";
            // 
            // lblDraftingTable
            // 
            this.lblDraftingTable.AutoSize = true;
            this.lblDraftingTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.lblDraftingTable.Image = global::Sheltered_2_SE.Properties.Resources.TextBackgroundMedium;
            this.lblDraftingTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDraftingTable.Location = new System.Drawing.Point(9, 31);
            this.lblDraftingTable.Name = "lblDraftingTable";
            this.lblDraftingTable.Size = new System.Drawing.Size(95, 13);
            this.lblDraftingTable.TabIndex = 0;
            this.lblDraftingTable.Text = "   Drafting Table    ";
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.lblDebugToBeAdded);
            this.debugTab.Location = new System.Drawing.Point(4, 22);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(659, 556);
            this.debugTab.TabIndex = 5;
            this.debugTab.Text = "Debug";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // lblDebugToBeAdded
            // 
            this.lblDebugToBeAdded.AutoSize = true;
            this.lblDebugToBeAdded.Location = new System.Drawing.Point(3, 0);
            this.lblDebugToBeAdded.Name = "lblDebugToBeAdded";
            this.lblDebugToBeAdded.Size = new System.Drawing.Size(68, 13);
            this.lblDebugToBeAdded.TabIndex = 1;
            this.lblDebugToBeAdded.Text = "To be added";
            this.lblDebugToBeAdded.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shelterDesignerTab
            // 
            this.shelterDesignerTab.Controls.Add(this.label33);
            this.shelterDesignerTab.Controls.Add(this.btnOpenDesigner);
            this.shelterDesignerTab.Location = new System.Drawing.Point(4, 22);
            this.shelterDesignerTab.Name = "shelterDesignerTab";
            this.shelterDesignerTab.Size = new System.Drawing.Size(659, 556);
            this.shelterDesignerTab.TabIndex = 6;
            this.shelterDesignerTab.Text = "Shelter Designer";
            this.shelterDesignerTab.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label33.Location = new System.Drawing.Point(15, 28);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(661, 230);
            this.label33.TabIndex = 1;
            this.label33.Text = "Warning the Shelter Designer is still \r\nexperimental. It can break your \r\nsavegam" +
    "e. \r\n\r\nLike Always MAKE backups!\r\n";
            // 
            // btnOpenDesigner
            // 
            this.btnOpenDesigner.Location = new System.Drawing.Point(259, 499);
            this.btnOpenDesigner.Name = "btnOpenDesigner";
            this.btnOpenDesigner.Size = new System.Drawing.Size(115, 30);
            this.btnOpenDesigner.TabIndex = 0;
            this.btnOpenDesigner.Text = "Open Designer";
            this.btnOpenDesigner.UseVisualStyleBackColor = true;
            this.btnOpenDesigner.Click += new System.EventHandler(this.btnOpenDesigner_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Load XML Tree";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(675, 633);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(269, 16);
            this.lblCopyright.TabIndex = 39;
            this.lblCopyright.Text = "Sheltered 2 SE   -   Copyright © 2022 by mJrA";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(911, 24);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 13);
            this.lblVersion.TabIndex = 40;
            this.lblVersion.Text = "Version: 0.40";
            // 
            // lblDebugCharacter
            // 
            this.lblDebugCharacter.AutoSize = true;
            this.lblDebugCharacter.Location = new System.Drawing.Point(597, 5);
            this.lblDebugCharacter.Name = "lblDebugCharacter";
            this.lblDebugCharacter.Size = new System.Drawing.Size(69, 13);
            this.lblDebugCharacter.TabIndex = 43;
            this.lblDebugCharacter.Text = "Member_022";
            this.lblDebugCharacter.Visible = false;
            // 
            // tTStrSkill1
            // 
            this.tTStrSkill1.ShowAlways = true;
            this.tTStrSkill1.ToolTipTitle = "Crush Windpipe";
            // 
            // skillIcons
            // 
            this.skillIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("skillIcons.ImageStream")));
            this.skillIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.skillIcons.Images.SetKeyName(0, "strSkill1.png");
            this.skillIcons.Images.SetKeyName(1, "strSkill2.png");
            this.skillIcons.Images.SetKeyName(2, "strSkill3.png");
            this.skillIcons.Images.SetKeyName(3, "strSkill4.png");
            this.skillIcons.Images.SetKeyName(4, "strSkill5.png");
            this.skillIcons.Images.SetKeyName(5, "strSkill6.png");
            this.skillIcons.Images.SetKeyName(6, "strSkill7.png");
            this.skillIcons.Images.SetKeyName(7, "strSkill8.png");
            this.skillIcons.Images.SetKeyName(8, "strSkill9.png");
            this.skillIcons.Images.SetKeyName(9, "strSkill10.png");
            this.skillIcons.Images.SetKeyName(10, "strSkill11.png");
            this.skillIcons.Images.SetKeyName(11, "strSkill12.png");
            this.skillIcons.Images.SetKeyName(12, "strSkill13.png");
            this.skillIcons.Images.SetKeyName(13, "strSkill14.png");
            this.skillIcons.Images.SetKeyName(14, "dexSkill1.png");
            this.skillIcons.Images.SetKeyName(15, "dexSkill2.png");
            this.skillIcons.Images.SetKeyName(16, "dexSkill3.png");
            this.skillIcons.Images.SetKeyName(17, "dexSkill4.png");
            this.skillIcons.Images.SetKeyName(18, "dexSkill5.png");
            this.skillIcons.Images.SetKeyName(19, "dexSkill6.png");
            this.skillIcons.Images.SetKeyName(20, "dexSkill7.png");
            this.skillIcons.Images.SetKeyName(21, "dexSkill8.png");
            this.skillIcons.Images.SetKeyName(22, "dexSkill9.png");
            this.skillIcons.Images.SetKeyName(23, "dexSkill10.png");
            this.skillIcons.Images.SetKeyName(24, "dexSkill11.png");
            this.skillIcons.Images.SetKeyName(25, "dexSkill12.png");
            this.skillIcons.Images.SetKeyName(26, "intSkill1.png");
            this.skillIcons.Images.SetKeyName(27, "intSkill2.png");
            this.skillIcons.Images.SetKeyName(28, "intSkill3.png");
            this.skillIcons.Images.SetKeyName(29, "intSkill4.png");
            this.skillIcons.Images.SetKeyName(30, "intSkill5.png");
            this.skillIcons.Images.SetKeyName(31, "intSkill6.png");
            this.skillIcons.Images.SetKeyName(32, "intSkill7.png");
            this.skillIcons.Images.SetKeyName(33, "intSkill8.png");
            this.skillIcons.Images.SetKeyName(34, "intSkill9.png");
            this.skillIcons.Images.SetKeyName(35, "intSkill10.png");
            this.skillIcons.Images.SetKeyName(36, "intSkill11.png");
            this.skillIcons.Images.SetKeyName(37, "intSkill12.png");
            this.skillIcons.Images.SetKeyName(38, "intSkill13.png");
            this.skillIcons.Images.SetKeyName(39, "intSkill14.png");
            this.skillIcons.Images.SetKeyName(40, "intSkill15.png");
            this.skillIcons.Images.SetKeyName(41, "intSkill16.png");
            this.skillIcons.Images.SetKeyName(42, "intSkill17.png");
            this.skillIcons.Images.SetKeyName(43, "chaSkill1.png");
            this.skillIcons.Images.SetKeyName(44, "chaSkill2.png");
            this.skillIcons.Images.SetKeyName(45, "chaSkill3.png");
            this.skillIcons.Images.SetKeyName(46, "chaSkill4.png");
            this.skillIcons.Images.SetKeyName(47, "chaSkill5.png");
            this.skillIcons.Images.SetKeyName(48, "chaSkill6.png");
            this.skillIcons.Images.SetKeyName(49, "chaSkill7.png");
            this.skillIcons.Images.SetKeyName(50, "chaSkill8.png");
            this.skillIcons.Images.SetKeyName(51, "chaSkill9.png");
            this.skillIcons.Images.SetKeyName(52, "chaSkill10.png");
            this.skillIcons.Images.SetKeyName(53, "chaSkill11.png");
            this.skillIcons.Images.SetKeyName(54, "chaSkill12.png");
            this.skillIcons.Images.SetKeyName(55, "chaSkill13.png");
            this.skillIcons.Images.SetKeyName(56, "perSkill1.png");
            this.skillIcons.Images.SetKeyName(57, "perSkill2.png");
            this.skillIcons.Images.SetKeyName(58, "perSkill3.png");
            this.skillIcons.Images.SetKeyName(59, "perSkill4.png");
            this.skillIcons.Images.SetKeyName(60, "perSkill5.png");
            this.skillIcons.Images.SetKeyName(61, "perSkill6.png");
            this.skillIcons.Images.SetKeyName(62, "perSkill7.png");
            this.skillIcons.Images.SetKeyName(63, "perSkill8.png");
            this.skillIcons.Images.SetKeyName(64, "perSkill9.png");
            this.skillIcons.Images.SetKeyName(65, "perSkill10.png");
            this.skillIcons.Images.SetKeyName(66, "perSkill11.png");
            this.skillIcons.Images.SetKeyName(67, "perSkill12.png");
            this.skillIcons.Images.SetKeyName(68, "perSkill13.png");
            this.skillIcons.Images.SetKeyName(69, "perSkill14.png");
            this.skillIcons.Images.SetKeyName(70, "perSkill15.png");
            this.skillIcons.Images.SetKeyName(71, "perSkill16.png");
            this.skillIcons.Images.SetKeyName(72, "perSkill17.png");
            this.skillIcons.Images.SetKeyName(73, "forSkill1.png");
            this.skillIcons.Images.SetKeyName(74, "forSkill2.png");
            this.skillIcons.Images.SetKeyName(75, "forSkill3.png");
            this.skillIcons.Images.SetKeyName(76, "forSkill4.png");
            this.skillIcons.Images.SetKeyName(77, "forSkill5.png");
            this.skillIcons.Images.SetKeyName(78, "forSkill6.png");
            this.skillIcons.Images.SetKeyName(79, "forSkill7.png");
            this.skillIcons.Images.SetKeyName(80, "forSkill8.png");
            this.skillIcons.Images.SetKeyName(81, "forSkill9.png");
            this.skillIcons.Images.SetKeyName(82, "forSkill10.png");
            this.skillIcons.Images.SetKeyName(83, "forSkill11.png");
            this.skillIcons.Images.SetKeyName(84, "forSkill12.png");
            this.skillIcons.Images.SetKeyName(85, "forSkill13.png");
            this.skillIcons.Images.SetKeyName(86, "forSkill14.png");
            this.skillIcons.Images.SetKeyName(87, "forSkill15.png");
            this.skillIcons.Images.SetKeyName(88, "forSkill16.png");
            this.skillIcons.Images.SetKeyName(89, "forSkill17.png");
            this.skillIcons.Images.SetKeyName(90, "forSkill18.png");
            this.skillIcons.Images.SetKeyName(91, "forSkill19.png");
            this.skillIcons.Images.SetKeyName(92, "forSkill20.png");
            // 
            // skillLevelIcons
            // 
            this.skillLevelIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("skillLevelIcons.ImageStream")));
            this.skillLevelIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.skillLevelIcons.Images.SetKeyName(0, "Skilllevel01.png");
            this.skillLevelIcons.Images.SetKeyName(1, "skillLevel02.png");
            this.skillLevelIcons.Images.SetKeyName(2, "Skilllevel03.png");
            this.skillLevelIcons.Images.SetKeyName(3, "Skilllevel11.png");
            this.skillLevelIcons.Images.SetKeyName(4, "Skilllevel12.png");
            this.skillLevelIcons.Images.SetKeyName(5, "Skilllevel22.png");
            this.skillLevelIcons.Images.SetKeyName(6, "Skilllevel13.png");
            this.skillLevelIcons.Images.SetKeyName(7, "Skilllevel23.png");
            this.skillLevelIcons.Images.SetKeyName(8, "Skilllevel33.png");
            // 
            // AvailablePointsIcon
            // 
            this.AvailablePointsIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AvailablePointsIcon.ImageStream")));
            this.AvailablePointsIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.AvailablePointsIcon.Images.SetKeyName(0, "AvailableSkillsStr.png");
            this.AvailablePointsIcon.Images.SetKeyName(1, "AvailableSkillsDex.png");
            this.AvailablePointsIcon.Images.SetKeyName(2, "AvailableSkillsInt.png");
            this.AvailablePointsIcon.Images.SetKeyName(3, "AvailableSkillsCha.png");
            this.AvailablePointsIcon.Images.SetKeyName(4, "AvailableSkillsPer.png");
            this.AvailablePointsIcon.Images.SetKeyName(5, "AvailableSkillsFor.png");
            // 
            // btnMaxAllSkills
            // 
            this.btnMaxAllSkills.Location = new System.Drawing.Point(528, 401);
            this.btnMaxAllSkills.Name = "btnMaxAllSkills";
            this.btnMaxAllSkills.Size = new System.Drawing.Size(103, 28);
            this.btnMaxAllSkills.TabIndex = 13;
            this.btnMaxAllSkills.Text = "Max all Skills";
            this.btnMaxAllSkills.UseVisualStyleBackColor = true;
            this.btnMaxAllSkills.Visible = false;
            this.btnMaxAllSkills.Click += new System.EventHandler(this.btnMaxAllSkills_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 657);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblDebugCharacter);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sheltered 2 Savegame Editor by mJrA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.characterStatsTab.ResumeLayout(false);
            this.characterStatsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).EndInit();
            this.characterSkillsTab.ResumeLayout(false);
            this.characterSkillsTab.PerformLayout();
            this.tabControlSkills.ResumeLayout(false);
            this.skillPageStr.ResumeLayout(false);
            this.skillPageStr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkillLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrSkill1)).EndInit();
            this.skillPageDex.ResumeLayout(false);
            this.skillPageDex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkillLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDexSkill1)).EndInit();
            this.skillPageInt.ResumeLayout(false);
            this.skillPageInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkillLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIntSkill1)).EndInit();
            this.skillPageCha.ResumeLayout(false);
            this.skillPageCha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkillLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChaSkill1)).EndInit();
            this.skillPagePer.ResumeLayout(false);
            this.skillPagePer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkillLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerSkill1)).EndInit();
            this.skillPageFor.ResumeLayout(false);
            this.skillPageFor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvailablePointsFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkillLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForSkill1)).EndInit();
            this.petsTab.ResumeLayout(false);
            this.petsTab.PerformLayout();
            this.deseasesTab.ResumeLayout(false);
            this.deseasesTab.PerformLayout();
            this.unlockingTab.ResumeLayout(false);
            this.unlockingTab.PerformLayout();
            this.debugTab.ResumeLayout(false);
            this.debugTab.PerformLayout();
            this.shelterDesignerTab.ResumeLayout(false);
            this.shelterDesignerTab.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cBInteracting;
        private System.Windows.Forms.Label lblAnimTimeValue;
        private System.Windows.Forms.Label lblAnimTime;
        private System.Windows.Forms.Label lblAnimHashValue;
        private System.Windows.Forms.Label lblAnimHash;
        private System.Windows.Forms.CheckBox cBHasBeenDefibbed;
        private System.Windows.Forms.CheckBox cBInteractingWithObj;
        private System.Windows.Forms.Label lblPetsToBeAdded;
        private System.Windows.Forms.Label lblDeseasesToBeAdded;
        private System.Windows.Forms.Label lblDebugToBeAdded;
        private System.Windows.Forms.ToolStripMenuItem buyMeACoffeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version01ToolStripMenuItem;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnMaxStats;
        private System.Windows.Forms.Label lblDebugCharacter;
        private System.Windows.Forms.ComboBox cbxSkillsCharacterSelect;
        public System.Windows.Forms.TabControl tabControlSkills;
        public System.Windows.Forms.TabPage skillPageStr;
        private System.Windows.Forms.Label lblStrTier3;
        private System.Windows.Forms.Label lblStrTier2;
        private System.Windows.Forms.Label lblStrTier1;
        public System.Windows.Forms.PictureBox pbxStrSkill7;
        public System.Windows.Forms.PictureBox pbxStrSkill6;
        public System.Windows.Forms.PictureBox pbxStrSkill5;
        public System.Windows.Forms.PictureBox pbxStrSkill4;
        public System.Windows.Forms.PictureBox pbxStrSkill3;
        public System.Windows.Forms.PictureBox pbxStrSkill2;
        public System.Windows.Forms.PictureBox pbxStrSkill1;
        public System.Windows.Forms.TabPage skillPageDex;
        public System.Windows.Forms.TabPage skillPageInt;
        public System.Windows.Forms.TabPage skillPageCha;
        public System.Windows.Forms.TabPage skillPagePer;
        public System.Windows.Forms.TabPage skillPageFor;
        private System.Windows.Forms.Label lblSkillsCharacterName;
        public System.Windows.Forms.PictureBox pbxStrSkill14;
        public System.Windows.Forms.PictureBox pbxStrSkill13;
        public System.Windows.Forms.PictureBox pbxStrSkill12;
        public System.Windows.Forms.PictureBox pbxStrSkill11;
        public System.Windows.Forms.PictureBox pbxStrSkill10;
        public System.Windows.Forms.PictureBox pbxStrSkill9;
        public System.Windows.Forms.PictureBox pbxStrSkill8;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel14;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel13;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel12;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel11;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel10;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel9;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel8;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel7;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel6;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel5;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel4;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel3;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel2;
        public System.Windows.Forms.PictureBox pbxStrSkillLevel1;
        private System.Windows.Forms.ToolTip tTStrSkill1;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel12;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel11;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel10;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel9;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel8;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel7;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel6;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel5;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel4;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel3;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel2;
        public System.Windows.Forms.PictureBox pbxDexSkillLevel1;
        public System.Windows.Forms.PictureBox pbxDexSkill12;
        public System.Windows.Forms.PictureBox pbxDexSkill11;
        public System.Windows.Forms.PictureBox pbxDexSkill10;
        public System.Windows.Forms.PictureBox pbxDexSkill9;
        public System.Windows.Forms.PictureBox pbxDexSkill8;
        public System.Windows.Forms.PictureBox pbxDexSkill7;
        private System.Windows.Forms.Label lblDexTier3;
        private System.Windows.Forms.Label lblDexTier2;
        private System.Windows.Forms.Label lblDexTier1;
        public System.Windows.Forms.PictureBox pbxDexSkill6;
        public System.Windows.Forms.PictureBox pbxDexSkill5;
        public System.Windows.Forms.PictureBox pbxDexSkill4;
        public System.Windows.Forms.PictureBox pbxDexSkill3;
        public System.Windows.Forms.PictureBox pbxDexSkill2;
        public System.Windows.Forms.PictureBox pbxDexSkill1;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel17;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel16;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel15;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel14;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel13;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel12;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel11;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel10;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel9;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel8;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel7;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel6;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel5;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel4;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel3;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel2;
        public System.Windows.Forms.PictureBox pbxIntSkillLevel1;
        public System.Windows.Forms.PictureBox pbxIntSkill17;
        public System.Windows.Forms.PictureBox pbxIntSkill16;
        public System.Windows.Forms.PictureBox pbxIntSkill15;
        public System.Windows.Forms.PictureBox pbxIntSkill14;
        public System.Windows.Forms.PictureBox pbxIntSkill13;
        public System.Windows.Forms.PictureBox pbxIntSkill12;
        public System.Windows.Forms.PictureBox pbxIntSkill11;
        public System.Windows.Forms.PictureBox pbxIntSkill10;
        public System.Windows.Forms.PictureBox pbxIntSkill9;
        public System.Windows.Forms.PictureBox pbxIntSkill8;
        private System.Windows.Forms.Label lblIntTier3;
        private System.Windows.Forms.Label lblIntTier2;
        private System.Windows.Forms.Label lblIntTier1;
        public System.Windows.Forms.PictureBox pbxIntSkill7;
        public System.Windows.Forms.PictureBox pbxIntSkill6;
        public System.Windows.Forms.PictureBox pbxIntSkill5;
        public System.Windows.Forms.PictureBox pbxIntSkill4;
        public System.Windows.Forms.PictureBox pbxIntSkill3;
        public System.Windows.Forms.PictureBox pbxIntSkill2;
        public System.Windows.Forms.PictureBox pbxIntSkill1;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel13;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel12;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel11;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel10;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel9;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel8;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel7;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel6;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel5;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel4;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel3;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel2;
        public System.Windows.Forms.PictureBox pbxChaSkillLevel1;
        public System.Windows.Forms.PictureBox pbxChaSkill13;
        public System.Windows.Forms.PictureBox pbxChaSkill12;
        public System.Windows.Forms.PictureBox pbxChaSkill11;
        public System.Windows.Forms.PictureBox pbxChaSkill10;
        public System.Windows.Forms.PictureBox pbxChaSkill9;
        public System.Windows.Forms.PictureBox pbxChaSkill8;
        private System.Windows.Forms.Label lblChaTier3;
        private System.Windows.Forms.Label lblChaTier2;
        private System.Windows.Forms.Label lblChaTier1;
        public System.Windows.Forms.PictureBox pbxChaSkill7;
        public System.Windows.Forms.PictureBox pbxChaSkill6;
        public System.Windows.Forms.PictureBox pbxChaSkill5;
        public System.Windows.Forms.PictureBox pbxChaSkill4;
        public System.Windows.Forms.PictureBox pbxChaSkill3;
        public System.Windows.Forms.PictureBox pbxChaSkill2;
        public System.Windows.Forms.PictureBox pbxChaSkill1;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel17;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel16;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel15;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel14;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel13;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel12;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel11;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel10;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel9;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel8;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel7;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel6;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel5;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel4;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel3;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel2;
        public System.Windows.Forms.PictureBox pbxPerSkillLevel1;
        public System.Windows.Forms.PictureBox pbxPerSkill17;
        public System.Windows.Forms.PictureBox pbxPerSkill16;
        public System.Windows.Forms.PictureBox pbxPerSkill15;
        public System.Windows.Forms.PictureBox pbxPerSkill14;
        public System.Windows.Forms.PictureBox pbxPerSkill13;
        public System.Windows.Forms.PictureBox pbxPerSkill12;
        public System.Windows.Forms.PictureBox pbxPerSkill11;
        public System.Windows.Forms.PictureBox pbxPerSkill10;
        public System.Windows.Forms.PictureBox pbxPerSkill9;
        public System.Windows.Forms.PictureBox pbxPerSkill8;
        private System.Windows.Forms.Label lblPerTier3;
        private System.Windows.Forms.Label lblPerTier2;
        private System.Windows.Forms.Label lblPerTier1;
        public System.Windows.Forms.PictureBox pbxPerSkill7;
        public System.Windows.Forms.PictureBox pbxPerSkill6;
        public System.Windows.Forms.PictureBox pbxPerSkill5;
        public System.Windows.Forms.PictureBox pbxPerSkill4;
        public System.Windows.Forms.PictureBox pbxPerSkill3;
        public System.Windows.Forms.PictureBox pbxPerSkill2;
        public System.Windows.Forms.PictureBox pbxPerSkill1;
        public System.Windows.Forms.PictureBox pbxForSkillLevel20;
        public System.Windows.Forms.PictureBox pbxForSkillLevel19;
        public System.Windows.Forms.PictureBox pbxForSkillLevel18;
        public System.Windows.Forms.PictureBox pbxForSkillLevel17;
        public System.Windows.Forms.PictureBox pbxForSkillLevel16;
        public System.Windows.Forms.PictureBox pbxForSkillLevel15;
        public System.Windows.Forms.PictureBox pbxForSkillLevel14;
        public System.Windows.Forms.PictureBox pbxForSkillLevel13;
        public System.Windows.Forms.PictureBox pbxForSkillLevel12;
        public System.Windows.Forms.PictureBox pbxForSkillLevel11;
        public System.Windows.Forms.PictureBox pbxForSkillLevel10;
        public System.Windows.Forms.PictureBox pbxForSkillLevel9;
        public System.Windows.Forms.PictureBox pbxForSkillLevel8;
        public System.Windows.Forms.PictureBox pbxForSkillLevel7;
        public System.Windows.Forms.PictureBox pbxForSkillLevel6;
        public System.Windows.Forms.PictureBox pbxForSkillLevel5;
        public System.Windows.Forms.PictureBox pbxForSkillLevel4;
        public System.Windows.Forms.PictureBox pbxForSkillLevel3;
        public System.Windows.Forms.PictureBox pbxForSkillLevel2;
        public System.Windows.Forms.PictureBox pbxForSkillLevel1;
        public System.Windows.Forms.PictureBox pbxForSkill20;
        public System.Windows.Forms.PictureBox pbxForSkill19;
        public System.Windows.Forms.PictureBox pbxForSkill18;
        public System.Windows.Forms.PictureBox pbxForSkill17;
        public System.Windows.Forms.PictureBox pbxForSkill16;
        public System.Windows.Forms.PictureBox pbxForSkill15;
        public System.Windows.Forms.PictureBox pbxForSkill14;
        public System.Windows.Forms.PictureBox pbxForSkill13;
        public System.Windows.Forms.PictureBox pbxForSkill12;
        public System.Windows.Forms.PictureBox pbxForSkill11;
        public System.Windows.Forms.PictureBox pbxForSkill10;
        public System.Windows.Forms.PictureBox pbxForSkill9;
        public System.Windows.Forms.PictureBox pbxForSkill8;
        private System.Windows.Forms.Label lblForTier3;
        private System.Windows.Forms.Label lblForTier2;
        private System.Windows.Forms.Label lblForTier1;
        public System.Windows.Forms.PictureBox pbxForSkill7;
        public System.Windows.Forms.PictureBox pbxForSkill6;
        public System.Windows.Forms.PictureBox pbxForSkill5;
        public System.Windows.Forms.PictureBox pbxForSkill4;
        public System.Windows.Forms.PictureBox pbxForSkill3;
        public System.Windows.Forms.PictureBox pbxForSkill2;
        public System.Windows.Forms.PictureBox pbxForSkill1;
        private System.Windows.Forms.ImageList tabIcons;
        private System.Windows.Forms.ImageList skillIcons;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ImageList skillLevelIcons;
        private System.Windows.Forms.ImageList AvailablePointsIcon;
        private System.Windows.Forms.Label lblPointsAvailableStrName;
        private System.Windows.Forms.PictureBox pbxAvailablePointsStr;
        private System.Windows.Forms.Label lblPointsAvailableDexName;
        private System.Windows.Forms.PictureBox pbxAvailablePointsDex;
        private System.Windows.Forms.Label lblPointsAvailableIntName;
        private System.Windows.Forms.PictureBox pbxAvailablePointsInt;
        private System.Windows.Forms.Label lblPointsAvailableChaName;
        private System.Windows.Forms.PictureBox pbxAvailablePointsCha;
        private System.Windows.Forms.Label lblPointsAvailablePerName;
        private System.Windows.Forms.PictureBox pbxAvailablePointsPer;
        private System.Windows.Forms.Label lblPointsAvailableForName;
        private System.Windows.Forms.PictureBox pbxAvailablePointsFor;
        private System.Windows.Forms.Button btnSaveUnlocks;
        private System.Windows.Forms.Button btnUnlockAll;
        private System.Windows.Forms.Button btnRevealMap;
        private System.Windows.Forms.TabPage shelterDesignerTab;
        private System.Windows.Forms.Button btnOpenDesigner;
        private System.Windows.Forms.Label label33;
        public System.Windows.Forms.CheckBox cbxBpLaboratory;
        public System.Windows.Forms.CheckBox cbxBpEfficientPlanter;
        public System.Windows.Forms.CheckBox cbxBpFlashbangMine;
        public System.Windows.Forms.CheckBox cbxBpMedicalBed;
        public System.Windows.Forms.CheckBox cbxBpElectricityTrap;
        public System.Windows.Forms.CheckBox cbxBpGasMine;
        public System.Windows.Forms.CheckBox cbxBpBatteryBank;
        public System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.CheckBox cbxOtherCarPartsCrafting;
        public System.Windows.Forms.CheckBox cbxOtherGunCrafting;
        public System.Windows.Forms.CheckBox cbxOtherTrading;
        public System.Windows.Forms.CheckBox cbxRewardOldQ3;
        public System.Windows.Forms.CheckBox cbxRewardOldQ2;
        public System.Windows.Forms.CheckBox cbxRewardOldQ1;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.CheckBox cbxRewardLosQ3;
        public System.Windows.Forms.CheckBox cbxRewardLosQ2;
        public System.Windows.Forms.CheckBox cbxRewardLosQ1;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.CheckBox cbxRewardBlackQ3;
        public System.Windows.Forms.CheckBox cbxRewardBlackQ2;
        public System.Windows.Forms.CheckBox cbxRewardBlackQ1;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.CheckBox cbxRewardNewQ3;
        public System.Windows.Forms.CheckBox cbxRewardNewQ2;
        public System.Windows.Forms.CheckBox cbxRewardNewQ1;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.CheckBox cbxRewardCtkQ3;
        public System.Windows.Forms.CheckBox cbxRewardCtkQ2;
        public System.Windows.Forms.CheckBox cbxRewardCtkQ1;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.CheckBox cbxDrugsTrankwill;
        public System.Windows.Forms.CheckBox cbxDrugsSnodge;
        public System.Windows.Forms.CheckBox cbxDrugsSigma;
        public System.Windows.Forms.CheckBox cbxDrugsPython;
        public System.Windows.Forms.CheckBox cbxDrugsFeederral;
        public System.Windows.Forms.CheckBox cbxDrugsCrunk;
        public System.Windows.Forms.CheckBox cbxDrugsAlcohol;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.CheckBox cbxRewardChurchQ3;
        public System.Windows.Forms.CheckBox cbxRewardChurchQ2;
        public System.Windows.Forms.CheckBox cbxRewardChurchQ1;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.CheckBox cbxWorkbenchTier4;
        public System.Windows.Forms.CheckBox cbxWorkbenchTier3;
        public System.Windows.Forms.CheckBox cbxWorkbenchTier2;
        public System.Windows.Forms.Label lblWorkbench;
        public System.Windows.Forms.CheckBox cbxDraftingTableTier4;
        public System.Windows.Forms.CheckBox cbxDraftingTableTier3;
        public System.Windows.Forms.CheckBox cbxDraftingTableTier2;
        public System.Windows.Forms.Label lblDraftingTable;
        public System.Windows.Forms.CheckBox cbxBpSolarPanel;
        public System.Windows.Forms.CheckBox cbxBpRecycler;
        public System.Windows.Forms.CheckBox cbxBpQuantumBattery;
        public System.Windows.Forms.CheckBox cbxBpIndustrialGenerator;
        public System.Windows.Forms.CheckBox cbxBpDefibrilator;
        public System.Windows.Forms.TabPage characterStatsTab;
        public System.Windows.Forms.TabPage characterSkillsTab;
        public System.Windows.Forms.TabPage petsTab;
        public System.Windows.Forms.TabPage deseasesTab;
        public System.Windows.Forms.TabPage unlockingTab;
        public System.Windows.Forms.TabPage debugTab;
        public System.Windows.Forms.CheckBox cbxMedicineCrafting;
        public System.Windows.Forms.CheckBox cbxDamageAmplifier;
        public System.Windows.Forms.Label lblPointsAvailableStrValue;
        public System.Windows.Forms.Label lblPointsAvailableDexValue;
        public System.Windows.Forms.Label lblPointsAvailableIntValue;
        public System.Windows.Forms.Label lblPointsAvailableChaValue;
        public System.Windows.Forms.Label lblPointsAvailablePerValue;
        public System.Windows.Forms.Label lblPointsAvailableForValue;
        private System.Windows.Forms.Button btnSaveCharacterSkills;
        private System.Windows.Forms.Button btnMaxAllSkills;
    }
}

