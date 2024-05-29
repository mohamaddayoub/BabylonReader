using Docnet.Core;
using Docnet.Core.Models;
using Docnet.Core.Readers;
using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Document = Microsoft.Office.Interop.Word.Document;
using DevExpress.XtraPdfViewer;
using DevExpress.Pdf;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;
using GroupDocs.Conversion.Options.Convert;
using System.Data.SqlClient;

namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static Image Signature = Image.FromFile(@"C:\Users\Eiad rehawe\Downloads\Signature.png");
        public static string Language = "en";
        public Form1()
        {
            setLanguage();
            InitializeComponent();
        }
        private void setLanguage()
        {
            if (DXApplication4.Properties.Settings.Default.Language == "en") Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
        }
        private void btnFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Viewer.CurrentPageNumber = 1;
        }
        private void btnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Viewer.CurrentPageNumber = Viewer.PageCount;
        }
        private string extractText(int page_number, IDocReader docReader)
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
                        //extracted_text += processor.GetPageText(i + 1);
                        extracted_text = extractText(i, docReader);
                    }
                }
                barButtons_extract_text(extracted_text);
            }
        }
        private void barButtons_extract_text(string extracted_text)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;
            Document wordDoc = wordApp.Documents.Add();
            wordDoc.Content.Text = extracted_text;
        }
        private void Viewer_Load(object sender, EventArgs e)
        {
            if (File.Exists(Introduction.SelectedPathFile))
            {
                Viewer.LoadDocument(Introduction.SelectedPathFile);
                addToRecentFiles();
            }
            
            //CheckInstallationDate();

            //if (IsExpired() && !(DXApplication4.Properties.Settings.Default.IsExpired))
            //{
            //    string msg, title;
            //    if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
            //    {
            //        msg = "The application has expired. Please activate the application";
            //        title = "Warning";
            //    }
            //    else
            //    {
            //        msg = ".لقد انتهت صلاحية التطبيق. يرجى تفعيل التطبيق";
            //        title = "تحذير";
            //    }
            //    MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //    frmActivate frmactivate = new frmActivate();
            //    if (frmactivate.ShowDialog() == DialogResult.OK)
            //    {
            //        ActivateApp();
            //    }
            //    else Application.Exit();
            //}
        }
        private void CheckInstallationDate()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("BabylonReader", true); 
            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey("BabylonReader");
                key.SetValue("InstallationDate", DateTime.Now.ToString());
            }
        }
        private bool IsExpired()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("BabylonReader", false);
            if (key != null)
            {
                string installationDateStr = key.GetValue("InstallationDate").ToString();
                DateTime installationDate = DateTime.Parse(installationDateStr);

                DateTime expirationDate = installationDate.AddMonths(6);

                if (DateTime.Now > expirationDate)
                {
                    return true; 
                }
                DXApplication4.Properties.Settings.Default["IsExpired"] = true;
                DXApplication4.Properties.Settings.Default.Save();
            }
            return false; 
        }
        private void addToRecentFiles()
        {
            DXApplication4.Properties.Settings.Default["RT_Ten"] = DXApplication4.Properties.Settings.Default["RT_Nine"];
            DXApplication4.Properties.Settings.Default["RT_Nine"] = DXApplication4.Properties.Settings.Default["RT_Eight"];
            DXApplication4.Properties.Settings.Default["RT_Eight"] = DXApplication4.Properties.Settings.Default["RT_Seven"];
            DXApplication4.Properties.Settings.Default["RT_Seven"] = DXApplication4.Properties.Settings.Default["RT_Six"];
            DXApplication4.Properties.Settings.Default["RT_Six"] = DXApplication4.Properties.Settings.Default["RT_Five"];
            DXApplication4.Properties.Settings.Default["RT_Five"] = DXApplication4.Properties.Settings.Default["RT_Four"];
            DXApplication4.Properties.Settings.Default["RT_Four"] = DXApplication4.Properties.Settings.Default["RT_Three"];
            DXApplication4.Properties.Settings.Default["RT_Three"] = DXApplication4.Properties.Settings.Default["RT_Two"];
            DXApplication4.Properties.Settings.Default["RT_Two"] = DXApplication4.Properties.Settings.Default["RT_One"];
            DXApplication4.Properties.Settings.Default["RT_One"] = Viewer.DocumentFilePath;
            DXApplication4.Properties.Settings.Default.Save();
        }

        private void Viewer_DocumentChanged(object sender, PdfDocumentChangedEventArgs e)
        {
            if (Viewer.DocumentFilePath != "")
            {
                btnFirstPage.Enabled = btnLastPage.Enabled = true;
                _documentPath = Viewer.DocumentFilePath;
            }
        }
        private void btnEditText_ItemClick(object sender, ItemClickEventArgs e)
        {
            //using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
            //{
            //    // Load a document:
            //    processor.LoadDocument(Viewer.DocumentFilePath);

            //    // Create a text box field:
            //    PdfAcroFormTextBoxField textBox =
            //         new PdfAcroFormTextBoxField("text box", 1, new DevExpress.Pdf.PdfRectangle(230, 690, 280, 710));

            //    // Specify text box text and appearance:
            //    textBox.Text = "Type here";
            //    textBox.Appearance.BackgroundColor = new PdfRGBColor(0.8, 0.5, 0.3);
            //    textBox.Appearance.FontSize = 12;

            //    // Add form fields to the page:

            //    processor.AddFormFields(textBox);

            //    // Save the resulting document:
            //    processor.SaveDocument(@"C:\Users\Eiad rehawe\Downloads\Result.pdf");
            //    Viewer.DocumentFilePath = @"C:\Users\Eiad rehawe\Downloads\Result.pdf";
                var doc = new Aspose.Words.Document(Viewer.DocumentFilePath);
            //}
            //doc.Save(@"C:\Users\Eiad rehawe\Downloads\Output2.docx", SaveFormat.Docx);//Load the PDF document.
            // ********************Spire.PDf
            //Spire.Pdf.PdfDocument pdf = new Spire.Pdf.PdfDocument();

            ////Load a PDF document
            //pdf.LoadFromFile(Viewer.DocumentFilePath);

            ////Convert the PDF to Docx
            //pdf.SaveToFile(@"C:\Users\Eiad rehawe\Downloads\Spire_Output3.docx", FileFormat.DOCX);
            //pdf.Close();
            //************SautinSoft
            //SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            //f.OpenPdf(Viewer.DocumentFilePath);
            //if (f.PageCount > 0)
            //{
            //    f.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx;
            //    f.ToWord(@"C:\Users\Eiad rehawe\Downloads\SautinSoftOutput4.docx");
            //}
            // ************************** Spire2
            //Spire.Pdf.PdfDocument docc = new Spire.Pdf.PdfDocument();
            //    docc.LoadFromFile(Viewer.DocumentFilePath);
            //    docc.ConvertOptions.SetPdfToDocOptions(true, true);
            //    docc.SaveToFile(@"C:\Users\Eiad rehawe\Downloads\Spire2Output5.docx", FileFormat.DOCX);
            //    docc.Close();
            //*********************** Syncfusion 
            try
            {
                string path = Viewer.DocumentFilePath;
                Viewer.CloseDocument();
                using (var converter = new GroupDocs.Conversion.Converter(path))
                {
                    var options = new WordProcessingConvertOptions();
                    converter.Convert(@"C:\Users\Eiad rehawe\Downloads\GroupDocsOutput6.docx", options);

                }Viewer.LoadDocument(path);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Confirm_SwitchLanguage(string msg, string title, bool IsEnglish)
        {
            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (IsEnglish)
                    DXApplication4.Properties.Settings.Default["Language"] = "en";
                else
                    DXApplication4.Properties.Settings.Default["Language"] = "ar";
                DXApplication4.Properties.Settings.Default.Save();
                string path = Viewer.DocumentFilePath;
               
                setLanguage();
                this.Controls.Clear();
                InitializeComponent();
                Viewer.LoadDocument(path);
            }
        }
        private void btnEnglishLagnuage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string msg = "";
            string title = "";
            msg = "هل انت تريد تبديل لغة التطبيق الى اللغة الانكليزية ؟";
            title = "تبديل اللغة";
            Confirm_SwitchLanguage(msg, title, true);
        }
        private void btnArabicLanguage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string msg = "";
            string title = "";
            msg = "Are you want to switch the language of the application to Arabic ?";
            title = "Switch Language";
            Confirm_SwitchLanguage(msg, title, false);
        }
        private void btnDigitalSignature_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmDigitalSignature frmDigital = new frmDigitalSignature();
            frmDigital.ShowDialog();

            flag = !flag;
        } 

        // *************************************************************************************
        private string _documentPath;

        private static int _counter = 0;

        public Image GetImageWaterMask()
        {
            var img = Signature;
            return SetImageOpacity(img, 0.3f);
        }

        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            Vertres = 10,
            Desktopvertres = 117,
        }
        private float GetScalingFactor()
        {
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr desktop = g.GetHdc();
                try
                {
                    int logicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.Vertres);
                    int physicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.Desktopvertres);
                    float screenScalingFactor = (float)physicalScreenHeight / (float)logicalScreenHeight;
                    return screenScalingFactor;
                }
                finally
                {
                    g.ReleaseHdc();
                }
            }
        }
        private void Viewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (!flag) { return; }
            if (!Viewer.IsDocumentOpened)
            {
                return;
            }
            var hitPoint = Viewer.GetDocumentPosition(e.Location, false);
            if (hitPoint != null)
            {
                var currentPageNumber = hitPoint.PageNumber - 1;

                using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
                {
                    processor.LoadDocument(_documentPath);

                    var page = processor.Document.Pages[currentPageNumber];

                    var image = GetImageWaterMask();
                    var factor = GetScalingFactor();

                    var graph = processor.CreateGraphics();
                    var width = image.Width / image.HorizontalResolution * 62f / factor;
                    var height = image.Height / image.VerticalResolution * 62f / factor;
                    var r = new RectangleF((float)hitPoint.Point.X - (width / 2), (float)page.CropBox.Top - (float)hitPoint.Point.Y - (height / 2), width, height);

                    graph.DrawImage(image, r);

                    graph.AddToPageForeground(page, 72f, 72f);
                    var filenmae = string.Format(@"test{0}.pdf", _counter);
                    processor.SaveDocument(filenmae);
                    Viewer.LoadDocument(filenmae);
                    ++_counter;
                    flag = false;
                    Cursor = Cursors.Default;
                }
            }
            else
            {
                return;
            }
        }
        public Cursor CreateCursor(Bitmap bitmap, Size size)
        {
            bitmap = new Bitmap(bitmap, size);
            return new Cursor(bitmap.GetHicon());
        }
        public Image SetImageOpacity(Image image, float opacity)
        {
            try
            {
                Bitmap bmp = new Bitmap(image.Width, image.Height);
                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    ColorMatrix matrix = new ColorMatrix();

                    matrix.Matrix33 = opacity;

                    ImageAttributes attributes = new ImageAttributes();

                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private void Viewer_MouseMove(object sender, MouseEventArgs e)
        {
            if (!flag) { return; }
            var hitPoint = Viewer.GetDocumentPosition(e.Location, false);
            if (hitPoint != null)
            {
                this.Text = hitPoint.Point.X + "/" + hitPoint.Point.Y;
                var bitmap = (Bitmap)GetImageWaterMask();
                this.Cursor = CreateCursor(bitmap, new Size(bitmap.Width, bitmap.Height));
                Viewer.CursorMode = DevExpress.XtraPdfViewer.PdfCursorMode.Custom;
            }
            else
            {
                this.Text = "0/0";
                var bitmap = (Bitmap)GetImageWaterMask();
                this.Cursor = Cursors.Default;
            }
        }
        bool flag = false;
        private void btnActivate_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmActivate frmActivate = new frmActivate();
            frmActivate.ShowDialog();
        }
    }
}