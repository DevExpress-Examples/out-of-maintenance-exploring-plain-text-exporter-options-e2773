namespace PlainTextExport
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.categoryMisc = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowActiveViewType = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions_Export = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions_Export_PlainText = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions_Export_PlainText_Encoding = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions_Export_PlainText_ExportBulletsAndNumbering = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions_Export_PlainText_ExportHiddenText = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions_Export_PlainText_FieldCodeEndMarker = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions_Export_PlainText_FieldCodeStartMarker = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowOptions_Export_PlainText_FieldResultEndMarker = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.rowViews = new DevExpress.XtraVerticalGrid.Rows.PGridEditorRow();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(343, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(665, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export to Plain Text";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(343, 47);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(665, 211);
            this.richEditControl1.TabIndex = 1;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("cd17b78d-09ea-4d72-9410-1dfd76b16e7c");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(343, 200);
            this.dockPanel1.Size = new System.Drawing.Size(343, 562);
            this.dockPanel1.Text = "RichEditControl Properties";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.propertyGridControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(335, 535);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(0, 0);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.RecordWidth = 62;
            this.propertyGridControl1.RowHeaderWidth = 138;
            this.propertyGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryMisc});
            this.propertyGridControl1.SelectedObject = this.richEditControl1;
            this.propertyGridControl1.Size = new System.Drawing.Size(335, 535);
            this.propertyGridControl1.TabIndex = 0;
            // 
            // categoryMisc
            // 
            this.categoryMisc.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowActiveViewType,
            this.rowOptions,
            this.rowViews});
            this.categoryMisc.Name = "categoryMisc";
            this.categoryMisc.Properties.Caption = "Misc";
            // 
            // rowActiveViewType
            // 
            this.rowActiveViewType.Name = "rowActiveViewType";
            this.rowActiveViewType.Properties.Caption = "ActiveViewType";
            this.rowActiveViewType.Properties.FieldName = "ActiveViewType";
            // 
            // rowOptions
            // 
            this.rowOptions.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowOptions_Export});
            this.rowOptions.Name = "rowOptions";
            this.rowOptions.Properties.Caption = "Options";
            this.rowOptions.Properties.FieldName = "Options";
            // 
            // rowOptions_Export
            // 
            this.rowOptions_Export.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowOptions_Export_PlainText});
            this.rowOptions_Export.Name = "rowOptions_Export";
            this.rowOptions_Export.Properties.Caption = "Export";
            this.rowOptions_Export.Properties.FieldName = "Options.Export";
            // 
            // rowOptions_Export_PlainText
            // 
            this.rowOptions_Export_PlainText.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowOptions_Export_PlainText_Encoding,
            this.rowOptions_Export_PlainText_ExportBulletsAndNumbering,
            this.rowOptions_Export_PlainText_ExportHiddenText,
            this.rowOptions_Export_PlainText_FieldCodeEndMarker,
            this.rowOptions_Export_PlainText_FieldCodeStartMarker,
            this.rowOptions_Export_PlainText_FieldResultEndMarker});
            this.rowOptions_Export_PlainText.Name = "rowOptions_Export_PlainText";
            this.rowOptions_Export_PlainText.Properties.Caption = "PlainText";
            this.rowOptions_Export_PlainText.Properties.FieldName = "Options.Export.PlainText";
            // 
            // rowOptions_Export_PlainText_Encoding
            // 
            this.rowOptions_Export_PlainText_Encoding.Name = "rowOptions_Export_PlainText_Encoding";
            this.rowOptions_Export_PlainText_Encoding.Properties.Caption = "Encoding";
            this.rowOptions_Export_PlainText_Encoding.Properties.FieldName = "Options.Export.PlainText.Encoding";
            // 
            // rowOptions_Export_PlainText_ExportBulletsAndNumbering
            // 
            this.rowOptions_Export_PlainText_ExportBulletsAndNumbering.Name = "rowOptions_Export_PlainText_ExportBulletsAndNumbering";
            this.rowOptions_Export_PlainText_ExportBulletsAndNumbering.Properties.Caption = "ExportBulletsAndNumbering";
            this.rowOptions_Export_PlainText_ExportBulletsAndNumbering.Properties.FieldName = "Options.Export.PlainText.ExportBulletsAndNumbering";
            // 
            // rowOptions_Export_PlainText_ExportHiddenText
            // 
            this.rowOptions_Export_PlainText_ExportHiddenText.Name = "rowOptions_Export_PlainText_ExportHiddenText";
            this.rowOptions_Export_PlainText_ExportHiddenText.Properties.Caption = "ExportHiddenText";
            this.rowOptions_Export_PlainText_ExportHiddenText.Properties.FieldName = "Options.Export.PlainText.ExportHiddenText";
            // 
            // rowOptions_Export_PlainText_FieldCodeEndMarker
            // 
            this.rowOptions_Export_PlainText_FieldCodeEndMarker.Name = "rowOptions_Export_PlainText_FieldCodeEndMarker";
            this.rowOptions_Export_PlainText_FieldCodeEndMarker.Properties.Caption = "FieldCodeEndMarker";
            this.rowOptions_Export_PlainText_FieldCodeEndMarker.Properties.FieldName = "Options.Export.PlainText.FieldCodeEndMarker";
            // 
            // rowOptions_Export_PlainText_FieldCodeStartMarker
            // 
            this.rowOptions_Export_PlainText_FieldCodeStartMarker.Name = "rowOptions_Export_PlainText_FieldCodeStartMarker";
            this.rowOptions_Export_PlainText_FieldCodeStartMarker.Properties.Caption = "FieldCodeStartMarker";
            this.rowOptions_Export_PlainText_FieldCodeStartMarker.Properties.FieldName = "Options.Export.PlainText.FieldCodeStartMarker";
            // 
            // rowOptions_Export_PlainText_FieldResultEndMarker
            // 
            this.rowOptions_Export_PlainText_FieldResultEndMarker.Name = "rowOptions_Export_PlainText_FieldResultEndMarker";
            this.rowOptions_Export_PlainText_FieldResultEndMarker.Properties.Caption = "FieldResultEndMarker";
            this.rowOptions_Export_PlainText_FieldResultEndMarker.Properties.FieldName = "Options.Export.PlainText.FieldResultEndMarker";
            // 
            // rowViews
            // 
            this.rowViews.Expanded = false;
            this.rowViews.IsChildRowsLoaded = false;
            this.rowViews.Name = "rowViews";
            this.rowViews.Properties.Caption = "Views";
            this.rowViews.Properties.FieldName = "Views";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memoEdit1.Location = new System.Drawing.Point(343, 258);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(665, 304);
            this.memoEdit1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryMisc;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowActiveViewType;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowViews;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions_Export;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions_Export_PlainText;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions_Export_PlainText_Encoding;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions_Export_PlainText_ExportBulletsAndNumbering;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions_Export_PlainText_ExportHiddenText;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions_Export_PlainText_FieldCodeEndMarker;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions_Export_PlainText_FieldCodeStartMarker;
        private DevExpress.XtraVerticalGrid.Rows.PGridEditorRow rowOptions_Export_PlainText_FieldResultEndMarker;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}

