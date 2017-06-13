using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.NorthwindTableAdapter.Fill(this.dsNorthwind.Northwind);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;
            string filename;

            byte[] bytes = reportViewer1.LocalReport.Render(
               "EXCELOPENXML", null, out mimeType, out encoding,
                out extension,
               out streamids, out warnings);

            filename = string.Format("{0}.{1}", "Northwind", "xlsx");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel 2013|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.FileName = filename;
            saveFileDialog1.ShowDialog();
            FileStream fs = (FileStream)saveFileDialog1.OpenFile();
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }

        
    }
}
