namespace задание_25_бл_схемы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateMass_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            int n = 0, a = 0, b = 0;
            try
            {
                n = int.Parse(InputElCount.Text);
                if (n <= 0) throw new Exception("Недостаточное количество элементов.");
                a = int.Parse(firstDiap.Text);
                b = int.Parse(LastDiap.Text);
                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = 2;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = rand.Next(a, b);
            }
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[1].Cells[i].Value = i;
            }
        }
        private void CreateNewMass_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;

            //Counting unique values
            List<int> uniqueValues = new List<int>();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                int value = (int)dataGridView1.Rows[0].Cells[i].Value;
                if (!uniqueValues.Contains(value))
                {
                    uniqueValues.Add(value);
                }
            }
            dataGridView2.RowCount = uniqueValues.Count;
            dataGridView2.ColumnCount = 3;

            for (int i = 0; i < uniqueValues.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = uniqueValues[i];

                int count = 0;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int value = (int)dataGridView1.Rows[0].Cells[j].Value;
                    if (value == uniqueValues[i])
                    {
                        count++;
                    }
                }

                dataGridView2.Rows[i].Cells[1].Value = count;

                if (uniqueValues[i] < 0)
                {
                    int comeIndex = -1;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        int value = (int)dataGridView1.Rows[0].Cells[j].Value;
                        if (value == uniqueValues[i])
                        {
                            comeIndex = j;
                        }
                    }
                    dataGridView2.Rows[i].Cells[2].Value = comeIndex;
                }
                else
                {
                    int leaveIndex = -1;
                    for (int j = dataGridView1.ColumnCount - 1; j >= 0; j--)
                    {
                        int value = (int)dataGridView1.Rows[0].Cells[j].Value;
                        if (value == uniqueValues[i])
                        {
                            leaveIndex = j;
                            break;
                        }
                    }
                    dataGridView2.Rows[i].Cells[2].Value = leaveIndex;
                }
            }
        }

        private void InputElCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отменить ввод символа, если это не цифра и не клавиша управления
            }
        }

        private void firstDiap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Отменить ввод символа, если это не цифра, не клавиша управления и не минус
            }
            }

        private void LastDiap_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Отменить ввод символа, если это не цифра, не клавиша управления и не минус
            }
        }
    }
}
