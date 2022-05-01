namespace lab7
{
    public partial class Form1 : Form
    {
        //public int count = 0;
        //private Form2 getForm;
        public BindingSource bsPhotos;
        public Form1()
        {
            InitializeComponent();

            bsPhotos = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsPhotos.DataSource = typeof(List<PhotoInfo>);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = bsPhotos;

            columnOrderNumber.DataPropertyName = nameof(PhotoInfo.OrderNumber);
            columnComment.DataPropertyName = nameof(PhotoInfo.Comment);
            columnPath.DataPropertyName = nameof(PhotoInfo.Path);
        }

        private void addInformationButton_Click(object sender, EventArgs e)
        {
            var getForm = new Form2(bsPhotos.Count);
            getForm.Tag = this;
            getForm.Show();
            getForm.Owner = this;
        }

        private void deleteInformationButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count == 0)
            {
                return;
            }

            var result = MessageBox.Show(
                $"Вы действительно хотите удалить {dataGridView.SelectedCells[0].RowIndex + 1} строку?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly); ;

            if (result == DialogResult.Yes)
            {
                try
                {
                    int ind = dataGridView.SelectedCells[0].RowIndex;
                    dataGridView.Rows.RemoveAt(ind);

                    for (int i = ind; i < bsPhotos.Count; i++)
                    {
                        dataGridView.Rows[i].Cells[0].Value = (int)dataGridView.Rows[i].Cells[0].Value - 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
        }

        private void clearInformationButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Вы действительно хотите очистить таблицу?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly); ;

            if (result == DialogResult.Yes)
            {
                try
                {
                    dataGridView.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveDBButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string db = "";
            saveFileDialog1.ShowDialog();
            for (int i = 0; i < bsPhotos.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    db += dataGridView.Rows[i].Cells[j].Value + ";";
                }
            }

            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(fileName, db);
            MessageBox.Show("Сохранение прошло успешно");
        }

        private void loadDBButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFileDialog1.FileName;

            try
            {
                string fileText = File.ReadAllText(path);
                var splitedText = fileText.Split(';');
                for (int i = 0; i < splitedText.Length - 1; i += 3)
                {
                    //dataGridView.Rows.Add(splitedText[i], splitedText[i + 1], splitedText[i + 2]);
                    var result = new PhotoInfo
                    {
                        OrderNumber = int.Parse(splitedText[i]),
                        Comment = splitedText[i + 1],
                        Path = new string(splitedText[i + 2].ToCharArray()),
                    };
                    bsPhotos.Add(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}