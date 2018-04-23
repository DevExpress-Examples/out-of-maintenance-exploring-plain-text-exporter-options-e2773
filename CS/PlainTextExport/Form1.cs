using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using System.IO;
using DevExpress.XtraRichEdit.Export;

namespace PlainTextExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.LoadDocument("sample.docx", DocumentFormat.OpenXml);
            richEditControl1.Options.Export.PlainText.ExportHiddenText = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            richEditControl1.SaveDocument(stream, DocumentFormat.PlainText);
            stream.Position = 0;
            StreamReader sr = new StreamReader(stream, richEditControl1.Options.Export.PlainText.Encoding);
            memoEdit1.Text = sr.ReadToEnd();
        }
    }
}