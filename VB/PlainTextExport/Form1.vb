Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports System.IO
Imports DevExpress.XtraRichEdit.Export

Namespace PlainTextExport
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("sample.docx", DocumentFormat.OpenXml)
            richEditControl1.Options.Export.PlainText.ExportHiddenText = True
        End Sub

        Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
            Dim stream As New MemoryStream()
            richEditControl1.SaveDocument(stream, DocumentFormat.PlainText)
            stream.Position = 0
            Dim sr As New StreamReader(stream, richEditControl1.Options.Export.PlainText.Encoding)
            memoEdit1.Text = sr.ReadToEnd()
        End Sub
    End Class
End Namespace