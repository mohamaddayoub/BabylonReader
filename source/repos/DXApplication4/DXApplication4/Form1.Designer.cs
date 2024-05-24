namespace DXApplication4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Viewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.ribbon_TopBar = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_OpenFilePdf = new DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem();
            this.btn_SaveAs = new DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem();
            this.btn_Print = new DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem();
            this.btn_Find = new DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem();
            this.btn_PreviousPage = new DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem();
            this.btn_NextPage = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
            this.txt_PageNumber = new DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem();
            this.repositoryItemPageNumberEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit();
            this.btn_ZoomOut = new DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem();
            this.btn_ZoomIn = new DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem();
            this.btn_Zoom = new DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem();
            this.pdfZoom10CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem();
            this.pdfZoom25CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem();
            this.pdfZoom50CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem();
            this.pdfZoom75CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem();
            this.pdfZoom100CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem();
            this.pdfZoom125CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem();
            this.pdfZoom150CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem();
            this.pdfZoom200CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem();
            this.pdfZoom400CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem();
            this.pdfZoom500CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem();
            this.pdfSetActualSizeZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem();
            this.pdfSetPageLevelZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem();
            this.pdfSetFitWidthZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem();
            this.pdfSetFitVisibleZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem();
            this.btn_Highlight = new DevExpress.XtraPdfViewer.Bars.PdfTextHighlightBarItem();
            this.btn_Strikethrough = new DevExpress.XtraPdfViewer.Bars.PdfTextStrikethroughBarItem();
            this.btn_Underline = new DevExpress.XtraPdfViewer.Bars.PdfTextUnderlineBarItem();
            this.btn_StickyNote = new DevExpress.XtraPdfViewer.Bars.PdfStickyNoteBarItem();
            this.btn_Export = new DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem();
            this.btn_Import = new DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem();
            this.btn_FirstPage = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LastPage = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExtractText = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButton_extractPageText = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_extractFileText = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DigitalSignture = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.tab_PdfViewer = new DevExpress.XtraPdfViewer.Bars.PdfRibbonPage();
            this.grp_File = new DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup();
            this.grp_Find = new DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup();
            this.grp_Navigation = new DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup();
            this.grp_Zoom = new DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup();
            this.grpEdition = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_Comment = new DevExpress.XtraPdfViewer.Bars.PdfCommentRibbonPage();
            this.grp_Text = new DevExpress.XtraPdfViewer.Bars.PdfTextCommentPageGroup();
            this.grp_Note = new DevExpress.XtraPdfViewer.Bars.PdfNoteCommentPageGroup();
            this.tab_InterActive = new DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage();
            this.pdfFormDataBarPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pdfBarController1 = new DevExpress.XtraPdfViewer.Bars.PdfBarController(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.pdfNextPageBarItem2 = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
            this.pdfNextPageBarItem3 = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
            this.pdfExactZoomListBarSubItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon_TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.Viewer.AutoScroll = true;
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.Location = new System.Drawing.Point(0, 183);
            this.Viewer.MenuManager = this.ribbon_TopBar;
            this.Viewer.Name = "Viewer";
            this.Viewer.NavigationPaneWidth = 203;
            this.Viewer.Size = new System.Drawing.Size(1220, 264);
            this.Viewer.TabIndex = 0;
            this.Viewer.Load += new System.EventHandler(this.Viewer_Load);
            // 
            // ribbon_TopBar
            // 
            this.ribbon_TopBar.ExpandCollapseItem.Id = 0;
            this.ribbon_TopBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon_TopBar.ExpandCollapseItem,
            this.ribbon_TopBar.SearchEditItem,
            this.btn_OpenFilePdf,
            this.btn_SaveAs,
            this.btn_Print,
            this.btn_Find,
            this.btn_PreviousPage,
            this.btn_NextPage,
            this.txt_PageNumber,
            this.btn_ZoomOut,
            this.btn_ZoomIn,
            this.btn_Zoom,
            this.pdfZoom10CheckItem1,
            this.pdfZoom25CheckItem1,
            this.pdfZoom50CheckItem1,
            this.pdfZoom75CheckItem1,
            this.pdfZoom100CheckItem1,
            this.pdfZoom125CheckItem1,
            this.pdfZoom150CheckItem1,
            this.pdfZoom200CheckItem1,
            this.pdfZoom400CheckItem1,
            this.pdfZoom500CheckItem1,
            this.pdfSetActualSizeZoomModeCheckItem1,
            this.pdfSetPageLevelZoomModeCheckItem1,
            this.pdfSetFitWidthZoomModeCheckItem1,
            this.pdfSetFitVisibleZoomModeCheckItem1,
            this.btn_Highlight,
            this.btn_Strikethrough,
            this.btn_Underline,
            this.btn_StickyNote,
            this.btn_Export,
            this.btn_Import,
            this.btn_FirstPage,
            this.btn_LastPage,
            this.btn_ExtractText,
            this.btn_DigitalSignture,
            this.barSubItem1,
            this.barEditItem1,
            this.barButton_extractPageText,
            this.barButton_extractFileText});
            this.ribbon_TopBar.Location = new System.Drawing.Point(0, 0);
            this.ribbon_TopBar.MaxItemId = 47;
            this.ribbon_TopBar.Name = "ribbon_TopBar";
            this.ribbon_TopBar.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tab_PdfViewer,
            this.tab_Comment,
            this.tab_InterActive});
            this.ribbon_TopBar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPageNumberEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2,
            this.repositoryItemButtonEdit3,
            this.repositoryItemComboBox1});
            this.ribbon_TopBar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbon_TopBar.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon_TopBar.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon_TopBar.Size = new System.Drawing.Size(1220, 183);
            // 
            // btn_OpenFilePdf
            // 
            this.btn_OpenFilePdf.Id = 1;
            this.btn_OpenFilePdf.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btn_OpenFilePdf.Name = "btn_OpenFilePdf";
            // 
            // btn_SaveAs
            // 
            this.btn_SaveAs.Id = 2;
            this.btn_SaveAs.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btn_SaveAs.Name = "btn_SaveAs";
            // 
            // btn_Print
            // 
            this.btn_Print.Id = 3;
            this.btn_Print.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btn_Print.Name = "btn_Print";
            // 
            // btn_Find
            // 
            this.btn_Find.Id = 4;
            this.btn_Find.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.btn_Find.Name = "btn_Find";
            // 
            // btn_PreviousPage
            // 
            this.btn_PreviousPage.Id = 5;
            this.btn_PreviousPage.Name = "btn_PreviousPage";
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Id = 6;
            this.btn_NextPage.Name = "btn_NextPage";
            // 
            // txt_PageNumber
            // 
            this.txt_PageNumber.Edit = this.repositoryItemPageNumberEdit1;
            this.txt_PageNumber.Id = 7;
            this.txt_PageNumber.Name = "txt_PageNumber";
            // 
            // repositoryItemPageNumberEdit1
            // 
            this.repositoryItemPageNumberEdit1.AutoHeight = false;
            this.repositoryItemPageNumberEdit1.Mask.EditMask = "########;";
            this.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1";
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.Id = 8;
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.Id = 9;
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            // 
            // btn_Zoom
            // 
            this.btn_Zoom.Id = 10;
            this.btn_Zoom.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom10CheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom25CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom50CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom75CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom100CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom125CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom150CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom200CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom400CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom500CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetActualSizeZoomModeCheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageLevelZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitWidthZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitVisibleZoomModeCheckItem1)});
            this.btn_Zoom.Name = "btn_Zoom";
            this.btn_Zoom.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // pdfZoom10CheckItem1
            // 
            this.pdfZoom10CheckItem1.Id = 11;
            this.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1";
            // 
            // pdfZoom25CheckItem1
            // 
            this.pdfZoom25CheckItem1.Id = 12;
            this.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1";
            // 
            // pdfZoom50CheckItem1
            // 
            this.pdfZoom50CheckItem1.Id = 13;
            this.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1";
            // 
            // pdfZoom75CheckItem1
            // 
            this.pdfZoom75CheckItem1.Id = 14;
            this.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1";
            // 
            // pdfZoom100CheckItem1
            // 
            this.pdfZoom100CheckItem1.Id = 15;
            this.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1";
            // 
            // pdfZoom125CheckItem1
            // 
            this.pdfZoom125CheckItem1.Id = 16;
            this.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1";
            // 
            // pdfZoom150CheckItem1
            // 
            this.pdfZoom150CheckItem1.Id = 17;
            this.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1";
            // 
            // pdfZoom200CheckItem1
            // 
            this.pdfZoom200CheckItem1.Id = 18;
            this.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1";
            // 
            // pdfZoom400CheckItem1
            // 
            this.pdfZoom400CheckItem1.Id = 19;
            this.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1";
            // 
            // pdfZoom500CheckItem1
            // 
            this.pdfZoom500CheckItem1.Id = 20;
            this.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1";
            // 
            // pdfSetActualSizeZoomModeCheckItem1
            // 
            this.pdfSetActualSizeZoomModeCheckItem1.Id = 21;
            this.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1";
            // 
            // pdfSetPageLevelZoomModeCheckItem1
            // 
            this.pdfSetPageLevelZoomModeCheckItem1.Id = 22;
            this.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1";
            // 
            // pdfSetFitWidthZoomModeCheckItem1
            // 
            this.pdfSetFitWidthZoomModeCheckItem1.Id = 23;
            this.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1";
            // 
            // pdfSetFitVisibleZoomModeCheckItem1
            // 
            this.pdfSetFitVisibleZoomModeCheckItem1.Id = 24;
            this.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1";
            // 
            // btn_Highlight
            // 
            this.btn_Highlight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.btn_Highlight.Id = 25;
            this.btn_Highlight.Name = "btn_Highlight";
            // 
            // btn_Strikethrough
            // 
            this.btn_Strikethrough.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.btn_Strikethrough.Id = 26;
            this.btn_Strikethrough.Name = "btn_Strikethrough";
            // 
            // btn_Underline
            // 
            this.btn_Underline.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.btn_Underline.Id = 27;
            this.btn_Underline.Name = "btn_Underline";
            // 
            // btn_StickyNote
            // 
            this.btn_StickyNote.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.btn_StickyNote.Id = 28;
            this.btn_StickyNote.Name = "btn_StickyNote";
            // 
            // btn_Export
            // 
            this.btn_Export.Id = 29;
            this.btn_Export.Name = "btn_Export";
            // 
            // btn_Import
            // 
            this.btn_Import.Id = 30;
            this.btn_Import.Name = "btn_Import";
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.Caption = "First";
            this.btn_FirstPage.Hint = "Show first page";
            this.btn_FirstPage.Id = 31;
            this.btn_FirstPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_FirstPage.ImageOptions.Image")));
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_FirstPage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_LastPage
            // 
            this.btn_LastPage.Caption = "Last";
            this.btn_LastPage.Hint = "Show last page";
            this.btn_LastPage.Id = 33;
            this.btn_LastPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LastPage.ImageOptions.Image")));
            this.btn_LastPage.Name = "btn_LastPage";
            this.btn_LastPage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_LastPage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btn_ExtractText
            // 
            this.btn_ExtractText.ActAsDropDown = true;
            this.btn_ExtractText.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            this.btn_ExtractText.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btn_ExtractText.Caption = "Extract Text";
            this.btn_ExtractText.CloseRadialMenuOnItemClick = true;
            this.btn_ExtractText.DropDownControl = this.popupMenu1;
            this.btn_ExtractText.Id = 34;
            this.btn_ExtractText.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExtractText.ImageOptions.Image")));
            this.btn_ExtractText.Name = "btn_ExtractText";
            this.btn_ExtractText.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButton_extractPageText);
            this.popupMenu1.ItemLinks.Add(this.barButton_extractFileText);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon_TopBar;
            // 
            // barButton_extractPageText
            // 
            this.barButton_extractPageText.Caption = "Extract page text";
            this.barButton_extractPageText.Id = 45;
            this.barButton_extractPageText.Name = "barButton_extractPageText";
            this.barButton_extractPageText.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_extractPageText_event);
            // 
            // barButton_extractFileText
            // 
            this.barButton_extractFileText.Caption = "Extract file text";
            this.barButton_extractFileText.Id = 46;
            this.barButton_extractFileText.Name = "barButton_extractFileText";
            this.barButton_extractFileText.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_extractFileText_event);
            // 
            // btn_DigitalSignture
            // 
            this.btn_DigitalSignture.Caption = "Digital Signutre";
            this.btn_DigitalSignture.Id = 35;
            this.btn_DigitalSignture.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DigitalSignture.ImageOptions.Image")));
            this.btn_DigitalSignture.Name = "btn_DigitalSignture";
            this.btn_DigitalSignture.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 43;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 44;
            this.barEditItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barEditItem1.ImageOptions.Image")));
            this.barEditItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barEditItem1.ImageOptions.LargeImage")));
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // tab_PdfViewer
            // 
            this.tab_PdfViewer.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grp_File,
            this.grp_Find,
            this.grp_Navigation,
            this.grp_Zoom,
            this.grpEdition,
            this.ribbonPageGroup1});
            this.tab_PdfViewer.Name = "tab_PdfViewer";
            // 
            // grp_File
            // 
            this.grp_File.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.grp_File.ItemLinks.Add(this.btn_OpenFilePdf);
            this.grp_File.ItemLinks.Add(this.btn_SaveAs);
            this.grp_File.ItemLinks.Add(this.btn_Print);
            this.grp_File.Name = "grp_File";
            // 
            // grp_Find
            // 
            this.grp_Find.AllowTextClipping = false;
            this.grp_Find.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.grp_Find.ItemLinks.Add(this.btn_Find);
            this.grp_Find.Name = "grp_Find";
            // 
            // grp_Navigation
            // 
            this.grp_Navigation.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.grp_Navigation.ItemLinks.Add(this.btn_PreviousPage);
            this.grp_Navigation.ItemLinks.Add(this.btn_NextPage);
            this.grp_Navigation.ItemLinks.Add(this.txt_PageNumber);
            this.grp_Navigation.ItemLinks.Add(this.btn_FirstPage);
            this.grp_Navigation.ItemLinks.Add(this.btn_LastPage);
            this.grp_Navigation.Name = "grp_Navigation";
            // 
            // grp_Zoom
            // 
            this.grp_Zoom.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.grp_Zoom.ItemLinks.Add(this.btn_ZoomOut);
            this.grp_Zoom.ItemLinks.Add(this.btn_ZoomIn);
            this.grp_Zoom.ItemLinks.Add(this.btn_Zoom);
            this.grp_Zoom.Name = "grp_Zoom";
            // 
            // grpEdition
            // 
            this.grpEdition.ItemLinks.Add(this.btn_ExtractText);
            this.grpEdition.ItemLinks.Add(this.btn_DigitalSignture);
            this.grpEdition.Name = "grpEdition";
            this.grpEdition.Text = "Edition";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // tab_Comment
            // 
            this.tab_Comment.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grp_Text,
            this.grp_Note});
            this.tab_Comment.Name = "tab_Comment";
            // 
            // grp_Text
            // 
            this.grp_Text.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.grp_Text.ItemLinks.Add(this.btn_Highlight);
            this.grp_Text.ItemLinks.Add(this.btn_Strikethrough);
            this.grp_Text.ItemLinks.Add(this.btn_Underline);
            this.grp_Text.Name = "grp_Text";
            // 
            // grp_Note
            // 
            this.grp_Note.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.grp_Note.ItemLinks.Add(this.btn_StickyNote);
            this.grp_Note.Name = "grp_Note";
            // 
            // tab_InterActive
            // 
            this.tab_InterActive.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pdfFormDataBarPageGroup1});
            this.tab_InterActive.Name = "tab_InterActive";
            this.tab_InterActive.Visible = false;
            // 
            // pdfFormDataBarPageGroup1
            // 
            this.pdfFormDataBarPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pdfFormDataBarPageGroup1.ItemLinks.Add(this.btn_Export);
            this.pdfFormDataBarPageGroup1.ItemLinks.Add(this.btn_Import);
            this.pdfFormDataBarPageGroup1.Name = "pdfFormDataBarPageGroup1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            // 
            // pdfBarController1
            // 
            this.pdfBarController1.BarItems.Add(this.btn_OpenFilePdf);
            this.pdfBarController1.BarItems.Add(this.btn_SaveAs);
            this.pdfBarController1.BarItems.Add(this.btn_Print);
            this.pdfBarController1.BarItems.Add(this.btn_Find);
            this.pdfBarController1.BarItems.Add(this.btn_PreviousPage);
            this.pdfBarController1.BarItems.Add(this.btn_NextPage);
            this.pdfBarController1.BarItems.Add(this.txt_PageNumber);
            this.pdfBarController1.BarItems.Add(this.btn_ZoomOut);
            this.pdfBarController1.BarItems.Add(this.btn_ZoomIn);
            this.pdfBarController1.BarItems.Add(this.pdfZoom10CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom25CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom50CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom75CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom100CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom125CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom150CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom200CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom400CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom500CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetActualSizeZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageLevelZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitWidthZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitVisibleZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.btn_Zoom);
            this.pdfBarController1.BarItems.Add(this.btn_Highlight);
            this.pdfBarController1.BarItems.Add(this.btn_Strikethrough);
            this.pdfBarController1.BarItems.Add(this.btn_Underline);
            this.pdfBarController1.BarItems.Add(this.btn_StickyNote);
            this.pdfBarController1.BarItems.Add(this.btn_Export);
            this.pdfBarController1.BarItems.Add(this.btn_Import);
            this.pdfBarController1.Control = this.Viewer;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem1";
            this.barButtonItem2.Hint = "Go To First Page";
            this.barButtonItem2.Id = 31;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // pdfNextPageBarItem2
            // 
            this.pdfNextPageBarItem2.Id = 6;
            this.pdfNextPageBarItem2.Name = "pdfNextPageBarItem2";
            // 
            // pdfNextPageBarItem3
            // 
            this.pdfNextPageBarItem3.Id = 6;
            this.pdfNextPageBarItem3.Name = "pdfNextPageBarItem3";
            // 
            // pdfExactZoomListBarSubItem1
            // 
            this.pdfExactZoomListBarSubItem1.Id = 10;
            this.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom10CheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom25CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom50CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom75CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom100CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom125CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom150CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom200CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom400CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom500CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetActualSizeZoomModeCheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageLevelZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitWidthZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitVisibleZoomModeCheckItem1)});
            this.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1";
            this.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbon_TopBar;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 447);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.ribbon_TopBar);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon_TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer Viewer;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon_TopBar;
        private DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem btn_OpenFilePdf;
        private DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem btn_SaveAs;
        private DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem btn_Print;
        private DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem btn_Find;
        private DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem btn_PreviousPage;
        private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem btn_NextPage;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem txt_PageNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit repositoryItemPageNumberEdit1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem btn_ZoomOut;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem btn_ZoomIn;
        private DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem btn_Zoom;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem pdfZoom10CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem pdfZoom25CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem pdfZoom50CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem pdfZoom75CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem pdfZoom100CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem pdfZoom125CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem pdfZoom150CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem pdfZoom200CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem pdfZoom400CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem pdfZoom500CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem pdfSetActualSizeZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem pdfSetPageLevelZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem pdfSetFitWidthZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem pdfSetFitVisibleZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfTextHighlightBarItem btn_Highlight;
        private DevExpress.XtraPdfViewer.Bars.PdfTextStrikethroughBarItem btn_Strikethrough;
        private DevExpress.XtraPdfViewer.Bars.PdfTextUnderlineBarItem btn_Underline;
        private DevExpress.XtraPdfViewer.Bars.PdfStickyNoteBarItem btn_StickyNote;
        private DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem btn_Export;
        private DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem btn_Import;
        private DevExpress.XtraPdfViewer.Bars.PdfRibbonPage tab_PdfViewer;
        private DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup grp_File;
        private DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup grp_Find;
        private DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup grp_Navigation;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup grp_Zoom;
        private DevExpress.XtraPdfViewer.Bars.PdfCommentRibbonPage tab_Comment;
        private DevExpress.XtraPdfViewer.Bars.PdfTextCommentPageGroup grp_Text;
        private DevExpress.XtraPdfViewer.Bars.PdfNoteCommentPageGroup grp_Note;
        private DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage tab_InterActive;
        private DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup pdfFormDataBarPageGroup1;
        private DevExpress.XtraPdfViewer.Bars.PdfBarController pdfBarController1;
        private DevExpress.XtraBars.BarButtonItem btn_FirstPage;
        private DevExpress.XtraBars.BarButtonItem btn_LastPage;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem pdfNextPageBarItem2;
        private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem pdfNextPageBarItem3;
        private DevExpress.XtraBars.BarButtonItem btn_ExtractText;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grpEdition;
        private DevExpress.XtraBars.BarButtonItem btn_DigitalSignture;
        private DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem pdfExactZoomListBarSubItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButton_extractPageText;
        private DevExpress.XtraBars.BarButtonItem barButton_extractFileText;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

