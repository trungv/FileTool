using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SlipFileToBase64Tool
{
    public partial class Form1 : Form
    {
        private IList<byte[]> _listBytesFile;
        public Form1()
        {
            InitializeComponent();
            _listBytesFile = new List<byte[]>();
        }

        private byte[] Chunk(byte[] src, int chunkSize, ref int offset)
        {
            int length = Math.Min(chunkSize, src.Length - offset);

            var buffer = new byte[length];

            Buffer.BlockCopy(src, offset, buffer, 0, length);

            offset += length;

            return buffer;
        }

        private void btnSlipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text) || string.IsNullOrEmpty(txtChunkSize.Text))
            {
                MessageBox.Show("Please input URL and ChunkSize!!!!!!!");
                return;
            }

            _listBytesFile.Clear();
            lsbSliptFile.Items.Clear();

            byte[] buffer = File.ReadAllBytes(txtUrl.Text);

            var offset = 0;
            var index = 0;

            if (!int.TryParse(txtChunkSize.Text, out int chunkSize))
            {
                MessageBox.Show("ChunkSize must be Integer!!!!!!!");
                return;
            }

            while (offset < buffer.Count())
            {
                index++;
                var filePart = Chunk(buffer, chunkSize, ref offset);
                _listBytesFile.Add(filePart);
                lsbSliptFile.Items.Add("File part " + index);
            }

            MessageBox.Show("Slipt Done!!!!");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse PDF Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "pdf files (*.pdf)|*.pdf",
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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lsbSliptFile.Items.Count == 0)
            {
                MessageBox.Show("No data to Copy!!!!!!");
                return;
            }

            var index = lsbSliptFile.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please select file part to copy!!!!!!");
                return;
            }

            Clipboard.SetText(Convert.ToBase64String(_listBytesFile[index]));
        }

        private void txtChunkSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
