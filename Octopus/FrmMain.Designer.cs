namespace Octopus.CDIndex
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tvDatabaseFolderTree = new System.Windows.Forms.TreeView();
            this.cmTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmVolumeFolderPropertiesPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteCdInfoPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.lvDatabaseItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.cmList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmFilePropertiesPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteFileInfoPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.ilSystem = new System.Windows.Forms.ImageList(this.components);
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.slFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.slSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDatabase = new System.Windows.Forms.TabPage();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.searchBottomPanel = new System.Windows.Forms.Panel();
            this.lvSearchResults = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.filesSearchCriteriaPanel = new Octopus.CDIndex.Components.FilesSearchCriteriaPanel();
            this.stripMain = new Octopus.CDIndex.RenderedToolStrip();
            this.tsbDatabase = new System.Windows.Forms.ToolStripDropDownButton();
            this.cmDatabaseMerge = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDatabaseExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbReadCD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbProperties = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOptions = new System.Windows.Forms.ToolStripButton();
            this.tlsAbout = new System.Windows.Forms.ToolStripDropDownButton();
            this.cmHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFeatureRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.cmWhatsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.cmTree.SuspendLayout();
            this.cmList.SuspendLayout();
            this.ssBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDatabase.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.searchBottomPanel.SuspendLayout();
            this.stripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.AccessibleDescription = null;
            this.scMain.AccessibleName = null;
            resources.ApplyResources(this.scMain, "scMain");
            this.scMain.BackgroundImage = null;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Font = null;
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.AccessibleDescription = null;
            this.scMain.Panel1.AccessibleName = null;
            resources.ApplyResources(this.scMain.Panel1, "scMain.Panel1");
            this.scMain.Panel1.BackgroundImage = null;
            this.scMain.Panel1.Controls.Add(this.tvDatabaseFolderTree);
            this.scMain.Panel1.Font = null;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.AccessibleDescription = null;
            this.scMain.Panel2.AccessibleName = null;
            resources.ApplyResources(this.scMain.Panel2, "scMain.Panel2");
            this.scMain.Panel2.BackgroundImage = null;
            this.scMain.Panel2.Controls.Add(this.lvDatabaseItems);
            this.scMain.Panel2.Font = null;
            // 
            // tvDatabaseFolderTree
            // 
            this.tvDatabaseFolderTree.AccessibleDescription = null;
            this.tvDatabaseFolderTree.AccessibleName = null;
            resources.ApplyResources(this.tvDatabaseFolderTree, "tvDatabaseFolderTree");
            this.tvDatabaseFolderTree.BackgroundImage = null;
            this.tvDatabaseFolderTree.ContextMenuStrip = this.cmTree;
            this.tvDatabaseFolderTree.Font = null;
            this.tvDatabaseFolderTree.HideSelection = false;
            this.tvDatabaseFolderTree.ImageList = this.ilMain;
            this.tvDatabaseFolderTree.Name = "tvDatabaseFolderTree";
            this.tvDatabaseFolderTree.Enter += new System.EventHandler(this.tvDatabaseFolderTree_Enter);
            this.tvDatabaseFolderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDatabaseFolderTree_AfterSelect);
            this.tvDatabaseFolderTree.Leave += new System.EventHandler(this.tvDatabaseFolderTree_Leave);
            // 
            // cmTree
            // 
            this.cmTree.AccessibleDescription = null;
            this.cmTree.AccessibleName = null;
            resources.ApplyResources(this.cmTree, "cmTree");
            this.cmTree.BackgroundImage = null;
            this.cmTree.Font = null;
            this.cmTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmVolumeFolderPropertiesPopup,
            this.cmDeleteCdInfoPopup});
            this.cmTree.Name = "cmTree";
            // 
            // cmVolumeFolderPropertiesPopup
            // 
            this.cmVolumeFolderPropertiesPopup.AccessibleDescription = null;
            this.cmVolumeFolderPropertiesPopup.AccessibleName = null;
            resources.ApplyResources(this.cmVolumeFolderPropertiesPopup, "cmVolumeFolderPropertiesPopup");
            this.cmVolumeFolderPropertiesPopup.BackgroundImage = null;
            this.cmVolumeFolderPropertiesPopup.Image = global::Octopus.CDIndex.Properties.Resources.Properties;
            this.cmVolumeFolderPropertiesPopup.Name = "cmVolumeFolderPropertiesPopup";
            this.cmVolumeFolderPropertiesPopup.ShortcutKeyDisplayString = null;
            this.cmVolumeFolderPropertiesPopup.Click += new System.EventHandler(this.cmVolumeFolderProperties_Click);
            // 
            // cmDeleteCdInfoPopup
            // 
            this.cmDeleteCdInfoPopup.AccessibleDescription = null;
            this.cmDeleteCdInfoPopup.AccessibleName = null;
            resources.ApplyResources(this.cmDeleteCdInfoPopup, "cmDeleteCdInfoPopup");
            this.cmDeleteCdInfoPopup.BackgroundImage = null;
            this.cmDeleteCdInfoPopup.Image = global::Octopus.CDIndex.Properties.Resources.Delete;
            this.cmDeleteCdInfoPopup.Name = "cmDeleteCdInfoPopup";
            this.cmDeleteCdInfoPopup.ShortcutKeyDisplayString = null;
            this.cmDeleteCdInfoPopup.Click += new System.EventHandler(this.cmDeleteCdInfo_Click);
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Magenta;
            this.ilMain.Images.SetKeyName(0, "CD_16.bmp");
            this.ilMain.Images.SetKeyName(1, "OpenFolder.bmp");
            this.ilMain.Images.SetKeyName(2, "b");
            this.ilMain.Images.SetKeyName(3, "openfolderHS.png");
            // 
            // lvDatabaseItems
            // 
            this.lvDatabaseItems.AccessibleDescription = null;
            this.lvDatabaseItems.AccessibleName = null;
            resources.ApplyResources(this.lvDatabaseItems, "lvDatabaseItems");
            this.lvDatabaseItems.BackgroundImage = null;
            this.lvDatabaseItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader12});
            this.lvDatabaseItems.ContextMenuStrip = this.cmList;
            this.lvDatabaseItems.Font = null;
            this.lvDatabaseItems.HideSelection = false;
            this.lvDatabaseItems.Name = "lvDatabaseItems";
            this.lvDatabaseItems.SmallImageList = this.ilSystem;
            this.lvDatabaseItems.UseCompatibleStateImageBehavior = false;
            this.lvDatabaseItems.View = System.Windows.Forms.View.Details;
            this.lvDatabaseItems.SelectedIndexChanged += new System.EventHandler(this.lvDatabaseItems_SelectedIndexChanged);
            this.lvDatabaseItems.DoubleClick += new System.EventHandler(this.lvDatabaseItems_DoubleClick);
            this.lvDatabaseItems.Leave += new System.EventHandler(this.lvDatabaseItems_Leave);
            this.lvDatabaseItems.Enter += new System.EventHandler(this.lvDatabaseItems_Enter);
            this.lvDatabaseItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvDatabaseItems_ColumnClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // cmList
            // 
            this.cmList.AccessibleDescription = null;
            this.cmList.AccessibleName = null;
            resources.ApplyResources(this.cmList, "cmList");
            this.cmList.BackgroundImage = null;
            this.cmList.Font = null;
            this.cmList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmFilePropertiesPopup,
            this.cmDeleteFileInfoPopup});
            this.cmList.Name = "cmList";
            // 
            // cmFilePropertiesPopup
            // 
            this.cmFilePropertiesPopup.AccessibleDescription = null;
            this.cmFilePropertiesPopup.AccessibleName = null;
            resources.ApplyResources(this.cmFilePropertiesPopup, "cmFilePropertiesPopup");
            this.cmFilePropertiesPopup.BackgroundImage = null;
            this.cmFilePropertiesPopup.Image = global::Octopus.CDIndex.Properties.Resources.Properties;
            this.cmFilePropertiesPopup.Name = "cmFilePropertiesPopup";
            this.cmFilePropertiesPopup.ShortcutKeyDisplayString = null;
            this.cmFilePropertiesPopup.Click += new System.EventHandler(this.cmFileProperties_Click);
            // 
            // cmDeleteFileInfoPopup
            // 
            this.cmDeleteFileInfoPopup.AccessibleDescription = null;
            this.cmDeleteFileInfoPopup.AccessibleName = null;
            resources.ApplyResources(this.cmDeleteFileInfoPopup, "cmDeleteFileInfoPopup");
            this.cmDeleteFileInfoPopup.BackgroundImage = null;
            this.cmDeleteFileInfoPopup.Image = global::Octopus.CDIndex.Properties.Resources.Delete;
            this.cmDeleteFileInfoPopup.Name = "cmDeleteFileInfoPopup";
            this.cmDeleteFileInfoPopup.ShortcutKeyDisplayString = null;
            this.cmDeleteFileInfoPopup.Click += new System.EventHandler(this.cmDeleteFileInfoPopup_Click);
            // 
            // ilSystem
            // 
            this.ilSystem.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.ilSystem, "ilSystem");
            this.ilSystem.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ssBottom
            // 
            this.ssBottom.AccessibleDescription = null;
            this.ssBottom.AccessibleName = null;
            resources.ApplyResources(this.ssBottom, "ssBottom");
            this.ssBottom.BackgroundImage = null;
            this.ssBottom.Font = null;
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slFiles,
            this.slSize});
            this.ssBottom.Name = "ssBottom";
            // 
            // slFiles
            // 
            this.slFiles.AccessibleDescription = null;
            this.slFiles.AccessibleName = null;
            resources.ApplyResources(this.slFiles, "slFiles");
            this.slFiles.BackgroundImage = null;
            this.slFiles.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.slFiles.Name = "slFiles";
            // 
            // slSize
            // 
            this.slSize.AccessibleDescription = null;
            this.slSize.AccessibleName = null;
            resources.ApplyResources(this.slSize, "slSize");
            this.slSize.BackgroundImage = null;
            this.slSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.slSize.Name = "slSize";
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.panel1.Controls.Add(this.tcMain);
            this.panel1.Font = null;
            this.panel1.Name = "panel1";
            // 
            // tcMain
            // 
            this.tcMain.AccessibleDescription = null;
            this.tcMain.AccessibleName = null;
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.BackgroundImage = null;
            this.tcMain.Controls.Add(this.tpDatabase);
            this.tcMain.Controls.Add(this.tpSearch);
            this.tcMain.Font = null;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcMain_Selected);
            // 
            // tpDatabase
            // 
            this.tpDatabase.AccessibleDescription = null;
            this.tpDatabase.AccessibleName = null;
            resources.ApplyResources(this.tpDatabase, "tpDatabase");
            this.tpDatabase.BackColor = System.Drawing.SystemColors.Window;
            this.tpDatabase.BackgroundImage = null;
            this.tpDatabase.Controls.Add(this.scMain);
            this.tpDatabase.Font = null;
            this.tpDatabase.Name = "tpDatabase";
            // 
            // tpSearch
            // 
            this.tpSearch.AccessibleDescription = null;
            this.tpSearch.AccessibleName = null;
            resources.ApplyResources(this.tpSearch, "tpSearch");
            this.tpSearch.BackgroundImage = null;
            this.tpSearch.Controls.Add(this.searchBottomPanel);
            this.tpSearch.Controls.Add(this.filesSearchCriteriaPanel);
            this.tpSearch.Font = null;
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // searchBottomPanel
            // 
            this.searchBottomPanel.AccessibleDescription = null;
            this.searchBottomPanel.AccessibleName = null;
            resources.ApplyResources(this.searchBottomPanel, "searchBottomPanel");
            this.searchBottomPanel.BackgroundImage = null;
            this.searchBottomPanel.Controls.Add(this.lvSearchResults);
            this.searchBottomPanel.Font = null;
            this.searchBottomPanel.Name = "searchBottomPanel";
            // 
            // lvSearchResults
            // 
            this.lvSearchResults.AccessibleDescription = null;
            this.lvSearchResults.AccessibleName = null;
            resources.ApplyResources(this.lvSearchResults, "lvSearchResults");
            this.lvSearchResults.BackColor = System.Drawing.SystemColors.Window;
            this.lvSearchResults.BackgroundImage = null;
            this.lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvSearchResults.Font = null;
            this.lvSearchResults.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("lvSearchResults.Groups")))});
            this.lvSearchResults.HideSelection = false;
            this.lvSearchResults.MultiSelect = false;
            this.lvSearchResults.Name = "lvSearchResults";
            this.lvSearchResults.SmallImageList = this.ilSystem;
            this.lvSearchResults.UseCompatibleStateImageBehavior = false;
            this.lvSearchResults.View = System.Windows.Forms.View.Details;
            this.lvSearchResults.VirtualMode = true;
            this.lvSearchResults.SelectedIndexChanged += new System.EventHandler(this.lvSearchResults_SelectedIndexChanged);
            this.lvSearchResults.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvSearchResults_ColumnClick);
            this.lvSearchResults.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lvSearchResults_RetrieveVirtualItem);
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // filesSearchCriteriaPanel
            // 
            this.filesSearchCriteriaPanel.AccessibleDescription = null;
            this.filesSearchCriteriaPanel.AccessibleName = null;
            resources.ApplyResources(this.filesSearchCriteriaPanel, "filesSearchCriteriaPanel");
            this.filesSearchCriteriaPanel.BackgroundImage = null;
            this.filesSearchCriteriaPanel.Font = null;
            this.filesSearchCriteriaPanel.Name = "filesSearchCriteriaPanel";
            this.filesSearchCriteriaPanel.SearchBtnClicked += new Octopus.CDIndex.Components.SearchEventHandler(this.filesSearchCriteriaPanel_SearchBtnClicked);
            // 
            // stripMain
            // 
            this.stripMain.AccessibleDescription = null;
            this.stripMain.AccessibleName = null;
            resources.ApplyResources(this.stripMain, "stripMain");
            this.stripMain.Font = null;
            this.stripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDatabase,
            this.tsbReadCD,
            this.toolStripSeparator1,
            this.tsbProperties,
            this.tsbDelete,
            this.toolStripSeparator2,
            this.tsbOptions,
            this.tlsAbout});
            this.stripMain.Name = "stripMain";
            // 
            // tsbDatabase
            // 
            this.tsbDatabase.AccessibleDescription = null;
            this.tsbDatabase.AccessibleName = null;
            resources.ApplyResources(this.tsbDatabase, "tsbDatabase");
            this.tsbDatabase.BackgroundImage = null;
            this.tsbDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDatabaseMerge,
            this.cmDatabaseExport});
            this.tsbDatabase.Image = global::Octopus.CDIndex.Properties.Resources.dbs;
            this.tsbDatabase.Name = "tsbDatabase";
            // 
            // cmDatabaseMerge
            // 
            this.cmDatabaseMerge.AccessibleDescription = null;
            this.cmDatabaseMerge.AccessibleName = null;
            resources.ApplyResources(this.cmDatabaseMerge, "cmDatabaseMerge");
            this.cmDatabaseMerge.BackgroundImage = null;
            this.cmDatabaseMerge.Image = global::Octopus.CDIndex.Properties.Resources.openHS;
            this.cmDatabaseMerge.Name = "cmDatabaseMerge";
            this.cmDatabaseMerge.ShortcutKeyDisplayString = null;
            this.cmDatabaseMerge.Click += new System.EventHandler(this.cmDatabaseMerge_Click);
            // 
            // cmDatabaseExport
            // 
            this.cmDatabaseExport.AccessibleDescription = null;
            this.cmDatabaseExport.AccessibleName = null;
            resources.ApplyResources(this.cmDatabaseExport, "cmDatabaseExport");
            this.cmDatabaseExport.BackgroundImage = null;
            this.cmDatabaseExport.Image = global::Octopus.CDIndex.Properties.Resources.saveHS;
            this.cmDatabaseExport.Name = "cmDatabaseExport";
            this.cmDatabaseExport.ShortcutKeyDisplayString = null;
            this.cmDatabaseExport.Click += new System.EventHandler(this.cmDatabaseExport_Click);
            // 
            // tsbReadCD
            // 
            this.tsbReadCD.AccessibleDescription = null;
            this.tsbReadCD.AccessibleName = null;
            resources.ApplyResources(this.tsbReadCD, "tsbReadCD");
            this.tsbReadCD.BackgroundImage = null;
            this.tsbReadCD.Image = global::Octopus.CDIndex.Properties.Resources.CD_16;
            this.tsbReadCD.Name = "tsbReadCD";
            this.tsbReadCD.Click += new System.EventHandler(this.cmReadCd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleDescription = null;
            this.toolStripSeparator1.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tsbProperties
            // 
            this.tsbProperties.AccessibleDescription = null;
            this.tsbProperties.AccessibleName = null;
            resources.ApplyResources(this.tsbProperties, "tsbProperties");
            this.tsbProperties.BackgroundImage = null;
            this.tsbProperties.Image = global::Octopus.CDIndex.Properties.Resources.Properties;
            this.tsbProperties.Name = "tsbProperties";
            this.tsbProperties.Click += new System.EventHandler(this.tsbProperties_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AccessibleDescription = null;
            this.tsbDelete.AccessibleName = null;
            resources.ApplyResources(this.tsbDelete, "tsbDelete");
            this.tsbDelete.BackgroundImage = null;
            this.tsbDelete.Image = global::Octopus.CDIndex.Properties.Resources.Delete;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AccessibleDescription = null;
            this.toolStripSeparator2.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tsbOptions
            // 
            this.tsbOptions.AccessibleDescription = null;
            this.tsbOptions.AccessibleName = null;
            resources.ApplyResources(this.tsbOptions, "tsbOptions");
            this.tsbOptions.BackgroundImage = null;
            this.tsbOptions.Image = global::Octopus.CDIndex.Properties.Resources.OptionsHS;
            this.tsbOptions.Name = "tsbOptions";
            this.tsbOptions.Click += new System.EventHandler(this.tsbOptions_Click);
            // 
            // tlsAbout
            // 
            this.tlsAbout.AccessibleDescription = null;
            this.tlsAbout.AccessibleName = null;
            resources.ApplyResources(this.tlsAbout, "tlsAbout");
            this.tlsAbout.BackgroundImage = null;
            this.tlsAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmHomePage,
            this.cmFeatureRequests,
            this.cmWhatsNew,
            this.toolStripSeparator3,
            this.cmAbout});
            this.tlsAbout.Image = global::Octopus.CDIndex.Properties.Resources.Help;
            this.tlsAbout.Name = "tlsAbout";
            // 
            // cmHomePage
            // 
            this.cmHomePage.AccessibleDescription = null;
            this.cmHomePage.AccessibleName = null;
            resources.ApplyResources(this.cmHomePage, "cmHomePage");
            this.cmHomePage.BackgroundImage = null;
            this.cmHomePage.Name = "cmHomePage";
            this.cmHomePage.ShortcutKeyDisplayString = null;
            this.cmHomePage.Click += new System.EventHandler(this.cmHomePage_Click);
            // 
            // cmFeatureRequests
            // 
            this.cmFeatureRequests.AccessibleDescription = null;
            this.cmFeatureRequests.AccessibleName = null;
            resources.ApplyResources(this.cmFeatureRequests, "cmFeatureRequests");
            this.cmFeatureRequests.BackgroundImage = null;
            this.cmFeatureRequests.Name = "cmFeatureRequests";
            this.cmFeatureRequests.ShortcutKeyDisplayString = null;
            this.cmFeatureRequests.Click += new System.EventHandler(this.cmFeatureRequests_Click);
            // 
            // cmWhatsNew
            // 
            this.cmWhatsNew.AccessibleDescription = null;
            this.cmWhatsNew.AccessibleName = null;
            resources.ApplyResources(this.cmWhatsNew, "cmWhatsNew");
            this.cmWhatsNew.BackgroundImage = null;
            this.cmWhatsNew.Name = "cmWhatsNew";
            this.cmWhatsNew.ShortcutKeyDisplayString = null;
            this.cmWhatsNew.Click += new System.EventHandler(this.cmWhatsNew_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AccessibleDescription = null;
            this.toolStripSeparator3.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // cmAbout
            // 
            this.cmAbout.AccessibleDescription = null;
            this.cmAbout.AccessibleName = null;
            resources.ApplyResources(this.cmAbout, "cmAbout");
            this.cmAbout.BackgroundImage = null;
            this.cmAbout.Name = "cmAbout";
            this.cmAbout.ShortcutKeyDisplayString = null;
            this.cmAbout.Click += new System.EventHandler(this.cmAbout_Click);
            // 
            // FrmMain
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stripMain);
            this.Controls.Add(this.ssBottom);
            this.Name = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.ResumeLayout(false);
            this.cmTree.ResumeLayout(false);
            this.cmList.ResumeLayout(false);
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpDatabase.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.searchBottomPanel.ResumeLayout(false);
            this.stripMain.ResumeLayout(false);
            this.stripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.ContextMenuStrip cmTree;
        private System.Windows.Forms.ToolStripMenuItem cmVolumeFolderPropertiesPopup;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteCdInfoPopup;
        private System.Windows.Forms.ImageList ilMain;
		private System.Windows.Forms.StatusStrip ssBottom;
		private System.Windows.Forms.ToolStripStatusLabel slFiles;
        private System.Windows.Forms.ToolStripStatusLabel slSize;
		private System.Windows.Forms.ContextMenuStrip cmList;
        private System.Windows.Forms.ToolStripMenuItem cmFilePropertiesPopup;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteFileInfoPopup;
        private RenderedToolStrip stripMain;
        private System.Windows.Forms.ToolStripButton tsbReadCD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbProperties;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDatabase;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TreeView tvDatabaseFolderTree;
        private System.Windows.Forms.ListView lvDatabaseItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.ListView lvSearchResults;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripDropDownButton tsbDatabase;
        private System.Windows.Forms.ToolStripMenuItem cmDatabaseExport;
        private System.Windows.Forms.ToolStripMenuItem cmDatabaseMerge;
        private Octopus.CDIndex.Components.FilesSearchCriteriaPanel filesSearchCriteriaPanel;
        private System.Windows.Forms.Panel searchBottomPanel;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ToolStripButton tsbOptions;
        private System.Windows.Forms.ImageList ilSystem;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ToolStripDropDownButton tlsAbout;
        private System.Windows.Forms.ToolStripMenuItem cmHomePage;
        private System.Windows.Forms.ToolStripMenuItem cmFeatureRequests;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmAbout;
        private System.Windows.Forms.ToolStripMenuItem cmWhatsNew;
	}
}

