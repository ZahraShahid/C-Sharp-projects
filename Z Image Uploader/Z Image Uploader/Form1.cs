using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Image_Uploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void img_UploadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.img_UploadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myImages);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myImages.Img_Upload' table. You can move, or remove it, as needed.
            this.img_UploadTableAdapter.Fill(this.myImages.Img_Upload);

        }

        private void idLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";
            DialogResult dr = opfd.ShowDialog();
            imgPictureBox.Image = Image.FromFile(opfd.FileName);
            imgPathLabel1.Text = opfd.FileName;
        }
    }
}
