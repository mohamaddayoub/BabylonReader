using Docnet.Core;
using Docnet.Core.Models;
using Docnet.Core.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        private void barButtons_extract_text(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string extracted_text = "";
            if (File.Exists(Viewer.DocumentFilePath))
            {
                using (var docReader = DocLib.Instance.GetDocReader(Viewer.DocumentFilePath, new PageDimensions()))
                {
                    // error in == and transfer always to else
                    if (sender != null)
                    {
                        DevExpress.XtraBars.BarButtonItem btn = sender as DevExpress.XtraBars.BarButtonItem;
                        if (btn == barButton_extractFileText)
                        {
                            for (var i = 0; i < docReader.GetPageCount(); i++)
                            {
                                MessageBox.Show(docReader.GetPageCount().ToString());
                                extracted_text += extractText(i, docReader);
                            }
                        }
                        else
                            extracted_text += extractText(Viewer.CurrentPageNumber - 1, docReader);
                    }
                }
                Clipboard.SetText(extracted_text);
                MessageBox.Show("تم نسخ النص الى الحافظة", "", MessageBoxButtons.OK,MessageBoxIcon.Information) ;
            }
        }
    }
}   
