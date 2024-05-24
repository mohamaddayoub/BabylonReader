using Docnet.Core;
using Docnet.Core.Models;
using Docnet.Core.Readers;
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using DevExpress.XtraBars;

namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Viewer.CurrentPageNumber = 1;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Viewer.CurrentPageNumber = Viewer.PageCount;
        }
        private string extractText(int page_number,IDocReader docReader)
        {
            string extracted_text = "";
            using (var pageReader = docReader.GetPageReader(page_number))
            {
                var text = pageReader.GetText();
                extracted_text += text;
            }
            return extracted_text;
        }
        private void barButton_extractPageText_event(object sender, ItemClickEventArgs e)
        {
            string extracted_text = "";
            if (File.Exists(Viewer.DocumentFilePath))
            {
                using (var docReader = DocLib.Instance.GetDocReader(Viewer.DocumentFilePath, new PageDimensions()))
                {
                    extracted_text += extractText(Viewer.CurrentPageNumber - 1, docReader);
                }
                barButtons_extract_text(extracted_text);
            }
        }
        private void barButton_extractFileText_event(object sender, ItemClickEventArgs e)
        {
            string extracted_text = "";
            if (File.Exists(Viewer.DocumentFilePath))
            {
                using (var docReader = DocLib.Instance.GetDocReader(Viewer.DocumentFilePath, new PageDimensions()))
                {
                    for (var i = 0; i < docReader.GetPageCount(); i++)
                    {
                        extracted_text += extractText(i, docReader);
                    }
                }
                barButtons_extract_text(extracted_text);
            }
        }
        private void barButtons_extract_text(string extracted_text)
        {
            string tempPath = Path.GetTempFileName();
            using (StreamWriter writer = new StreamWriter(tempPath))
            {
                writer.Write(extracted_text);
            }

            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = wordApp.Documents.Open(tempPath);
            wordApp.Visible = true;
        }

        private void Viewer_Load(object sender, EventArgs e)
        {

        }
    }
}
