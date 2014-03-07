using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Ehocam_Excel_Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region AnaDegiskenler
        // Excel uygulaması tanımlıyoruz.
        Excel.ApplicationClass ExcelUygulama;
        // Çalışma Kitabı tanımlıyoruz.
        Excel.Workbook CalismaKitabi;
        // Çalışma Sayfası tanımlıyoruz.
        Excel.Worksheet CalismaSayfasi;
        #endregion

        #region Excel_Olustur
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            // Yeni Bir Excel uygulaması yaratıyoruz.
            ExcelUygulama = new Excel.ApplicationClass();
            // Excel Uygulamasının görünürlüğü
            ExcelUygulama.Visible = true;

            // Excel Uygulamamıza Yeni Bir Çalışma Kitabı Ekliyoruz.
            CalismaKitabi = ExcelUygulama.Workbooks.Add(Type.Missing);

            // Oluşturduğumuz Çalışma Kitabımıza Yeni Bir Çalışma Sayfası Oluşturuyoruz.
            // Fakat Çalışma Kitabı oluşturulduğunda, 3 tane hazır sayfa gelmektedir.
            // Eğer projenizde birkaç sayfa kullacaksanız eklemenize gerek yok.
            // Eğer 3 den fazla sayfa ile uğraşacaksanız eklemenizi öneririm.
            // Calisma Kitabımızdaki ilk sayfayı alıyoruz. Alırken Excel.WorkSheet olarak 
            // casting ediyoruz.
            // Daha sonra ilk sayfayı CalismaSayfasından alıyoruz. 
            CalismaSayfasi = (Excel.Worksheet)CalismaKitabi.Worksheets.get_Item(1);

            // Yeni Bir sayfa eklemek için aşağıdaki kodu kullanabilirsiniz.
            // Eklediğiniz sayfa en başta gözükecektir.
            CalismaSayfasi = CalismaKitabi.Worksheets.Add(
                        CalismaKitabi.Worksheets[1],
                        Type.Missing,
                        Type.Missing,
                        Type.Missing) as Excel.Worksheet;
            CalismaSayfasi.Name = "Ehocam.Com(1)";


            // Eğer yeni ekleyeceğimiz sayfanın en sonda olmasını istiyorsak 
            // aşağıdaki kodu kullanabiiriz.
            CalismaSayfasi = CalismaKitabi.Worksheets.Add(
                        Type.Missing,
                        CalismaKitabi.Worksheets[CalismaKitabi.Worksheets.Count],
                        Type.Missing,
                        Type.Missing) as Excel.Worksheet;
            CalismaSayfasi.Name = "Ehocam.Com(2)";

        }
        private void linkAsama1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.ehocam.com/?p=1238");
        }
        #endregion

        #region Excel_Kaydet
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //     SaveAs(object Filename = Type.Missing, 
            //            object FileFormat = Type.Missing, 
            //            object Password = Type.Missing, 
            //            object WriteResPassword = Type.Missing, 
            //            object ReadOnlyRecommended = Type.Missing, 
            //            object CreateBackup = Type.Missing, 
            //            XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange, 
            //            object ConflictResolution = Type.Missing, 
            //            object AddToMru = Type.Missing, 
            //            object TextCodepage = Type.Missing, 
            //            object TextVisualLayout = Type.Missing, 
            //            object Local = Type.Missing);

            try
            {
                if (cbSifreVarMi.Checked == true)
                {

                    CalismaKitabi.SaveAs(@"C:\Excel1.xlsx",
                                    Excel.XlFileFormat.xlWorkbookDefault,
                                    txtSifre.Text.ToString(),
                                    Type.Missing,
                                    false,
                                    Type.Missing,
                                    Excel.XlSaveAsAccessMode.xlExclusive);
                    MessageBox.Show("Excel Başarıyla Şifreli Bir Şekilde Kaydedilmiştir. Şifre : " + txtSifre.Text.ToString());
                }
                else
                {

                    CalismaKitabi.SaveAs(@"C:\Excel1.xlsx",
                                    Excel.XlFileFormat.xlWorkbookDefault,
                                    Type.Missing,
                                    Type.Missing,
                                    false,
                                    Type.Missing,
                                    Excel.XlSaveAsAccessMode.xlExclusive);
                    MessageBox.Show("Excel Başarıyla Oluşturulmuştur Kaydedilmiştir.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ExcelUygulama.Quit();
            }
        }
        private void cbSifreVarMi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreVarMi.Checked)
            {
                txtSifre.Enabled = true;
            }
            else
            {
                txtSifre.Enabled = false;
            }
        }
        private void linkAsama2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.ehocam.com/?p=1281");
        }
        #endregion
    }
}
