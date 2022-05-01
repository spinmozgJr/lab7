using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form2 : Form
    {
        public EventHandler DataEntered;
        private readonly PhotoInfo photoInfo;
        int count = 0;
        //private readonly BindingSource bsPhotos;

        Form1 form1 = (Form1)Application.OpenForms["Form1"];
        
        public Form2(int cnt)
        {
            InitializeComponent();

            count = cnt + 1;
            photoInfo = new PhotoInfo();

            commentTextBox.DataBindings.Add("Text", photoInfo, nameof(photoInfo.Comment),
                true, DataSourceUpdateMode.OnPropertyChanged);
            pathTextBox.DataBindings.Add("Text", photoInfo, nameof(photoInfo.Path),
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathTextBox.Text = openFileDialog1.FileName;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pathTextBox.Text == null || false == File.Exists(pathTextBox.Text))
            {
                MessageBox.Show("Выберите корректный файл");
                return;
            }

            if (form1 != null)
            {
                if (commentTextBox.Text == "")
                {
                    var result = new PhotoInfo
                    {
                        OrderNumber = count,
                        Comment = "",
                        Path = new string(photoInfo.Path.ToCharArray()),
                    };

                    form1.bsPhotos.Add(result);
                    this.Close();
                }
                else
                {
                    var result = new PhotoInfo
                    {
                        OrderNumber = count,
                        Comment = new string(photoInfo.Comment.ToCharArray()),
                        Path = new string(photoInfo.Path.ToCharArray()),
                    };

                    form1.bsPhotos.Add(result);
                }
            }
                                
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Вы действительно хотите закрыть форму?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.DoEvents();
            }
            this.TopMost = true;
        }
    }
}
