Imports Microsoft.VisualBasic
Imports System
Namespace PlainTextExport
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.categoryMisc = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowActiveViewType = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions_Export = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions_Export_PlainText = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions_Export_PlainText_Encoding = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions_Export_PlainText_ExportBulletsAndNumbering = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions_Export_PlainText_ExportHiddenText = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions_Export_PlainText_FieldCodeEndMarker = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions_Export_PlainText_FieldCodeStartMarker = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptions_Export_PlainText_FieldResultEndMarker = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowViews = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel1_Container.SuspendLayout()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnExport)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(343, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(665, 47)
			Me.panelControl1.TabIndex = 0
			' 
			' btnExport
			' 
			Me.btnExport.Location = New System.Drawing.Point(12, 12)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New System.Drawing.Size(119, 23)
			Me.btnExport.TabIndex = 0
			Me.btnExport.Text = "Export to Plain Text"
'			Me.btnExport.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(343, 47)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(665, 211)
			Me.richEditControl1.TabIndex = 1
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel1})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
			Me.dockPanel1.ID = New System.Guid("cd17b78d-09ea-4d72-9410-1dfd76b16e7c")
			Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(343, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(343, 562)
			Me.dockPanel1.Text = "RichEditControl Properties"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Controls.Add(Me.propertyGridControl1)
			Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(335, 535)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.RecordWidth = 62
			Me.propertyGridControl1.RowHeaderWidth = 138
			Me.propertyGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryMisc})
			Me.propertyGridControl1.SelectedObject = Me.richEditControl1
			Me.propertyGridControl1.Size = New System.Drawing.Size(335, 535)
			Me.propertyGridControl1.TabIndex = 0
			' 
			' categoryMisc
			' 
			Me.categoryMisc.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowActiveViewType, Me.rowOptions, Me.rowViews})
			Me.categoryMisc.Name = "categoryMisc"
			Me.categoryMisc.Properties.Caption = "Misc"
			' 
			' rowActiveViewType
			' 
			Me.rowActiveViewType.Name = "rowActiveViewType"
			Me.rowActiveViewType.Properties.Caption = "ActiveViewType"
			Me.rowActiveViewType.Properties.FieldName = "ActiveViewType"
			' 
			' rowOptions
			' 
			Me.rowOptions.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowOptions_Export})
			Me.rowOptions.Name = "rowOptions"
			Me.rowOptions.Properties.Caption = "Options"
			Me.rowOptions.Properties.FieldName = "Options"
			' 
			' rowOptions_Export
			' 
			Me.rowOptions_Export.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowOptions_Export_PlainText})
			Me.rowOptions_Export.Name = "rowOptions_Export"
			Me.rowOptions_Export.Properties.Caption = "Export"
			Me.rowOptions_Export.Properties.FieldName = "Options.Export"
			' 
			' rowOptions_Export_PlainText
			' 
			Me.rowOptions_Export_PlainText.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowOptions_Export_PlainText_Encoding, Me.rowOptions_Export_PlainText_ExportBulletsAndNumbering, Me.rowOptions_Export_PlainText_ExportHiddenText, Me.rowOptions_Export_PlainText_FieldCodeEndMarker, Me.rowOptions_Export_PlainText_FieldCodeStartMarker, Me.rowOptions_Export_PlainText_FieldResultEndMarker})
			Me.rowOptions_Export_PlainText.Name = "rowOptions_Export_PlainText"
			Me.rowOptions_Export_PlainText.Properties.Caption = "PlainText"
			Me.rowOptions_Export_PlainText.Properties.FieldName = "Options.Export.PlainText"
			' 
			' rowOptions_Export_PlainText_Encoding
			' 
			Me.rowOptions_Export_PlainText_Encoding.Name = "rowOptions_Export_PlainText_Encoding"
			Me.rowOptions_Export_PlainText_Encoding.Properties.Caption = "Encoding"
			Me.rowOptions_Export_PlainText_Encoding.Properties.FieldName = "Options.Export.PlainText.Encoding"
			' 
			' rowOptions_Export_PlainText_ExportBulletsAndNumbering
			' 
			Me.rowOptions_Export_PlainText_ExportBulletsAndNumbering.Name = "rowOptions_Export_PlainText_ExportBulletsAndNumbering"
			Me.rowOptions_Export_PlainText_ExportBulletsAndNumbering.Properties.Caption = "ExportBulletsAndNumbering"
			Me.rowOptions_Export_PlainText_ExportBulletsAndNumbering.Properties.FieldName = "Options.Export.PlainText.ExportBulletsAndNumbering"
			' 
			' rowOptions_Export_PlainText_ExportHiddenText
			' 
			Me.rowOptions_Export_PlainText_ExportHiddenText.Name = "rowOptions_Export_PlainText_ExportHiddenText"
			Me.rowOptions_Export_PlainText_ExportHiddenText.Properties.Caption = "ExportHiddenText"
			Me.rowOptions_Export_PlainText_ExportHiddenText.Properties.FieldName = "Options.Export.PlainText.ExportHiddenText"
			' 
			' rowOptions_Export_PlainText_FieldCodeEndMarker
			' 
			Me.rowOptions_Export_PlainText_FieldCodeEndMarker.Name = "rowOptions_Export_PlainText_FieldCodeEndMarker"
			Me.rowOptions_Export_PlainText_FieldCodeEndMarker.Properties.Caption = "FieldCodeEndMarker"
			Me.rowOptions_Export_PlainText_FieldCodeEndMarker.Properties.FieldName = "Options.Export.PlainText.FieldCodeEndMarker"
			' 
			' rowOptions_Export_PlainText_FieldCodeStartMarker
			' 
			Me.rowOptions_Export_PlainText_FieldCodeStartMarker.Name = "rowOptions_Export_PlainText_FieldCodeStartMarker"
			Me.rowOptions_Export_PlainText_FieldCodeStartMarker.Properties.Caption = "FieldCodeStartMarker"
			Me.rowOptions_Export_PlainText_FieldCodeStartMarker.Properties.FieldName = "Options.Export.PlainText.FieldCodeStartMarker"
			' 
			' rowOptions_Export_PlainText_FieldResultEndMarker
			' 
			Me.rowOptions_Export_PlainText_FieldResultEndMarker.Name = "rowOptions_Export_PlainText_FieldResultEndMarker"
			Me.rowOptions_Export_PlainText_FieldResultEndMarker.Properties.Caption = "FieldResultEndMarker"
			Me.rowOptions_Export_PlainText_FieldResultEndMarker.Properties.FieldName = "Options.Export.PlainText.FieldResultEndMarker"
			' 
			' rowViews
			' 
			Me.rowViews.Expanded = False
			Me.rowViews.IsChildRowsLoaded = False
			Me.rowViews.Name = "rowViews"
			Me.rowViews.Properties.Caption = "Views"
			Me.rowViews.Properties.FieldName = "Views"
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.memoEdit1.Location = New System.Drawing.Point(343, 258)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(665, 304)
			Me.memoEdit1.TabIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 562)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.memoEdit1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.dockPanel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel1_Container.ResumeLayout(False)
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private categoryMisc As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowActiveViewType As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowViews As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions_Export As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions_Export_PlainText As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions_Export_PlainText_Encoding As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions_Export_PlainText_ExportBulletsAndNumbering As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions_Export_PlainText_ExportHiddenText As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions_Export_PlainText_FieldCodeEndMarker As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions_Export_PlainText_FieldCodeStartMarker As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptions_Export_PlainText_FieldResultEndMarker As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
	End Class
End Namespace

