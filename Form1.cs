using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace DownloadWebsiteAsPDF
{
    public partial class Form1 : Form
    {
        string Title = "Download Website As PDF";
        public Form1()
        {
            InitializeComponent();
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (textBoxWebPage.Text.Length > 0)
            {
                DownloadWebPage(textBoxWebPage.Text);
            }
            else
            {
                MessageBox.Show("You need to enter a web page or sitemap address in the text box before trying to download.", Title);
            }
        }
        
        
        
        void DownloadWebPage(string url)
        {
            try
            {
                WebBrowser browser = new WebBrowser();
                browser.ScriptErrorsSuppressed = true;
                browser.ScrollBarsEnabled = false;
                browser.AllowNavigation = true;

                browser.ScriptErrorsSuppressed = true;

                browser.Navigate(url);
                browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title);
            }
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                WebBrowser browser = sender as WebBrowser;
                if (browser.ReadyState != WebBrowserReadyState.Complete)
                {
                    return;
                }
                browser.Size = browser.Document.Body.ScrollRectangle.Size;
                browser.Width = Screen.PrimaryScreen.Bounds.Width;
                using (var bitmap = new Bitmap(browser.Width, browser.Height))
                {
                    browser.DrawToBitmap(bitmap, new Rectangle(0, 0, browser.Width, browser.Height));
                    Image image = (Image)bitmap.Clone();
                    if (radioPNG.Checked == true)
                    {
                        string filename = RemoveIllegalFileNameChars(browser.Url.ToString(), "") + ".png";
                        image.Save(filename);
                    }
                    else if (radioPDF.Checked == true)
                    {
                        MemoryStream strm = new MemoryStream();
                        image.Save(strm, System.Drawing.Imaging.ImageFormat.Png);

                        XImage xImage = XImage.FromStream(strm);

                        PdfDocument document = new PdfDocument();
                        PdfPage page = document.AddPage();
                        page.Width = browser.Width;
                        page.Height = browser.Height;

                        document.Options.NoCompression = true;
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        gfx.DrawImage(xImage, new XRect(0, 0, page.Width, page.Height));
                        string filename = RemoveIllegalFileNameChars(browser.Url.ToString(), "") + ".pdf";
                        page.Close();
                        document.Save(filename);
                        xImage.Dispose();
                        strm.Close();
                        document.Dispose();
                    }
                    image.Dispose();
                    bitmap.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title);
            }
        }



        public static string RemoveIllegalFileNameChars(string input, string replacement = "")
        {
            var regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(input, replacement);
        }









        /*

        void Download(string url)
        {
            WebBrowser browser = new WebBrowser();
            browser.ScriptErrorsSuppressed = true;

            browser.Navigate(url);
            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = sender as WebBrowser;
            if (browser.ReadyState != WebBrowserReadyState.Complete)
            {
                return;
            }


            HtmlElementCollection TheImages = browser.Document.GetElementsByTagName("img");
            System.Net.WebClient wClient = new System.Net.WebClient();

            char[] filetype = new char[4];
            string gtype;

            for (int i = 0; i < TheImages.Count; i++)
            {
                try
                {
                    TheImages[i].GetAttribute("src").CopyTo(TheImages[i].GetAttribute("src").Length - 4, filetype, 0, 4);
                    gtype = new string(filetype);
                    wClient.DownloadFile(TheImages[i].GetAttribute("src"), i.ToString() + gtype);
                    LogIt(TheImages[i].GetAttribute("src"));
                }
                catch (Exception ex)
                {
                    LogIt(ex.Message.ToString());
                }
            }
        }





        void Download(string url)
        {
            HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            converter.Options.RenderingEngine = RenderingEngine.WebKit;
            converter.Options.CssMediaType = HtmlToPdfCssMediaType.Screen;
            converter.Options.DisplayCutText = true;
            converter.Options.DisplayFooter = true;
            converter.Options.DisplayHeader = true;
            converter.Options.DrawBackground = true;
            converter.Options.EmbedFonts = true;
            converter.Options.ExternalLinksEnabled = true;
            converter.Options.InternalLinksEnabled = true;
            converter.Options.JavaScriptEnabled = true;
            converter.Options.JpegCompressionEnabled = true;
            converter.Options.KeepImagesTogether = false;
            converter.Options.PdfCompressionLevel = PdfCompressionLevel.Normal;
            converter.Options.PluginsEnabled = true;


            PdfDocument doc = converter.ConvertUrl(textBoxURL.Text);

            doc.Save("test.pdf");
            doc.Close();
        }
        */










    }
}
