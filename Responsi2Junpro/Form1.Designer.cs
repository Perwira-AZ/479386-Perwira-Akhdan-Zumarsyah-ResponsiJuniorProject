namespace Responsi2Junpro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lbLogo = new Label();
            lbNama = new Label();
            lbDepartemen = new Label();
            listBox1 = new ListBox();
            tbNama = new TextBox();
            cbDep = new ComboBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 33);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Location = new Point(60, 21);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(44, 15);
            lbLogo.TabIndex = 1;
            lbLogo.Text = "Z Logo";
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.Location = new Point(12, 66);
            lbNama.Name = "lbNama";
            lbNama.Size = new Size(99, 15);
            lbNama.TabIndex = 2;
            lbNama.Text = "Nama Karyawan :";
            // 
            // lbDepartemen
            // 
            lbDepartemen.AutoSize = true;
            lbDepartemen.Location = new Point(20, 94);
            lbDepartemen.Name = "lbDepartemen";
            lbDepartemen.Size = new Size(91, 15);
            lbDepartemen.TabIndex = 3;
            lbDepartemen.Text = "Dep. Karyawan :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen:", "HR : HR", "ENG : Engineering", "DEV : Developer", "PM : Project Manager", "FIN : Finanace" });
            listBox1.Location = new Point(304, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(132, 94);
            listBox1.TabIndex = 4;
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.FixedSingle;
            tbNama.Location = new Point(117, 58);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(169, 23);
            tbNama.TabIndex = 5;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(117, 91);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(169, 23);
            cbDep.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(20, 129);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(115, 129);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(211, 129);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 190);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(424, 150);
            dgvData.TabIndex = 10;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 361);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(listBox1);
            Controls.Add(lbDepartemen);
            Controls.Add(lbNama);
            Controls.Add(lbLogo);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbLogo;
        private Label lbNama;
        private Label lbDepartemen;
        private ListBox listBox1;
        private TextBox tbNama;
        private ComboBox cbDep;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
    }
}