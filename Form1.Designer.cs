namespace задание_25_бл_схемы
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GenerateMass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LastDiap = new System.Windows.Forms.TextBox();
            this.firstDiap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputElCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateNewMass = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Unic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.GenerateMass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LastDiap);
            this.groupBox1.Controls.Add(this.firstDiap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.InputElCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инициализируем исходный одномерный массив . . .";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(200, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(370, 76);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            // 
            // GenerateMass
            // 
            this.GenerateMass.Location = new System.Drawing.Point(287, 68);
            this.GenerateMass.Name = "GenerateMass";
            this.GenerateMass.Size = new System.Drawing.Size(199, 29);
            this.GenerateMass.TabIndex = 6;
            this.GenerateMass.Text = "Сгенерировать массив";
            this.GenerateMass.UseVisualStyleBackColor = true;
            this.GenerateMass.Click += new System.EventHandler(this.GenerateMass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // LastDiap
            // 
            this.LastDiap.Location = new System.Drawing.Point(615, 35);
            this.LastDiap.Name = "LastDiap";
            this.LastDiap.Size = new System.Drawing.Size(48, 27);
            this.LastDiap.TabIndex = 4;
            this.LastDiap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastDiap_KeyPress);
            // 
            // firstDiap
            // 
            this.firstDiap.Location = new System.Drawing.Point(540, 35);
            this.firstDiap.Name = "firstDiap";
            this.firstDiap.Size = new System.Drawing.Size(48, 27);
            this.firstDiap.TabIndex = 3;
            this.firstDiap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstDiap_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Диапазон чисел:";
            // 
            // InputElCount
            // 
            this.InputElCount.Location = new System.Drawing.Point(257, 35);
            this.InputElCount.Name = "InputElCount";
            this.InputElCount.Size = new System.Drawing.Size(125, 27);
            this.InputElCount.TabIndex = 1;
            this.InputElCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputElCount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество элементов в массиве:";
            // 
            // CreateNewMass
            // 
            this.CreateNewMass.Location = new System.Drawing.Point(299, 197);
            this.CreateNewMass.Name = "CreateNewMass";
            this.CreateNewMass.Size = new System.Drawing.Size(199, 29);
            this.CreateNewMass.TabIndex = 1;
            this.CreateNewMass.Text = "Собрать новый массив";
            this.CreateNewMass.UseVisualStyleBackColor = true;
            this.CreateNewMass.Click += new System.EventHandler(this.CreateNewMass_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unic,
            this.Repeating,
            this.Position});
            this.dataGridView2.Location = new System.Drawing.Point(212, 242);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(370, 168);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.Visible = false;
            // 
            // Unic
            // 
            this.Unic.HeaderText = "Уникальные элементы";
            this.Unic.MinimumWidth = 6;
            this.Unic.Name = "Unic";
            this.Unic.Width = 24;
            // 
            // Repeating
            // 
            this.Repeating.HeaderText = "Кол-во повторов";
            this.Repeating.MinimumWidth = 6;
            this.Repeating.Name = "Repeating";
            this.Repeating.Width = 24;
            // 
            // Position
            // 
            this.Position.HeaderText = "Точка входа/выхода";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.Width = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CreateNewMass);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Программа считает: 1 - уник. знач., 2 - повтор, 3 - т. входа(\"-\"), т. выхода(\"+\"," +
    " 0)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox LastDiap;
        private TextBox firstDiap;
        private Label label2;
        private TextBox InputElCount;
        private Label label1;
        private Label label3;
        private DataGridView dataGridView1;
        private Button GenerateMass;
        private Button CreateNewMass;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Unic;
        private DataGridViewTextBoxColumn Repeating;
        private DataGridViewTextBoxColumn Position;
    }
}