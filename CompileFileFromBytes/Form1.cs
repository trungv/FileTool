using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CompileFileFromBytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse TXT file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = openFileDialog1.FileName;
            }
        }

        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in save file");
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show("Please select your bytes file");
                return;
            }

            byte[] filebyte;
            try
            {
                var fileDetail = File.ReadAllText(txtUrl.Text);
                fileDetail = fileDetail.Replace("\r\n", string.Empty);
                //fileDetail = fileDetail.Replace("\r", string.Empty);
                fileDetail = fileDetail.Replace(" ", string.Empty);

                var yyyy = fileDetail.Split(',');
                filebyte = yyyy.Select(byte.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Please check file content");
                return;
            }


            using (var fbd = new SaveFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (ByteArrayToFile(fbd.FileName, filebyte))
                    {
                        MessageBox.Show("done");
                    }
                }
            }
        }
    }
}
