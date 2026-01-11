namespace Everything
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            StudentAddButton = new Button();
            StudentShowButton = new Button();
            StudentNameBox = new TextBox();
            StudentPasswordBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // StudentAddButton
            // 
            StudentAddButton.BackColor = Color.Lavender;
            StudentAddButton.BackgroundImageLayout = ImageLayout.None;
            StudentAddButton.FlatStyle = FlatStyle.Popup;
            StudentAddButton.ForeColor = SystemColors.ActiveCaptionText;
            StudentAddButton.Location = new Point(630, 377);
            StudentAddButton.Name = "StudentAddButton";
            StudentAddButton.Size = new Size(102, 23);
            StudentAddButton.TabIndex = 0;
            StudentAddButton.Text = "Öğrenci Ekle";
            StudentAddButton.UseVisualStyleBackColor = false;
            StudentAddButton.Click += StudentAddButton_Click;
            // 
            // StudentShowButton
            // 
            StudentShowButton.BackColor = Color.Lavender;
            StudentShowButton.FlatStyle = FlatStyle.Popup;
            StudentShowButton.Location = new Point(128, 389);
            StudentShowButton.Name = "StudentShowButton";
            StudentShowButton.Size = new Size(114, 23);
            StudentShowButton.TabIndex = 2;
            StudentShowButton.Text = "Hepsini Göster";
            StudentShowButton.UseVisualStyleBackColor = false;
            StudentShowButton.Click += button2_Click;
            // 
            // StudentNameBox
            // 
            StudentNameBox.Location = new Point(606, 294);
            StudentNameBox.Name = "StudentNameBox";
            StudentNameBox.Size = new Size(145, 23);
            StudentNameBox.TabIndex = 3;
            // 
            // StudentPasswordBox
            // 
            StudentPasswordBox.Location = new Point(606, 323);
            StudentPasswordBox.Name = "StudentPasswordBox";
            StudentPasswordBox.Size = new Size(145, 23);
            StudentPasswordBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monocraft", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(467, 301);
            label1.Name = "label1";
            label1.Size = new Size(115, 16);
            label1.TabIndex = 5;
            label1.Text = "Öğrenci İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monocraft", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(467, 330);
            label3.Name = "label3";
            label3.Size = new Size(133, 16);
            label3.TabIndex = 7;
            label3.Text = "Öğrenci Parola";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._20250730_0145_Şık_Y_Logo_simple_compose_01k1c5q78bfq999zbs951ket0z;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(402, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 247);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(305, 343);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(StudentPasswordBox);
            Controls.Add(StudentNameBox);
            Controls.Add(StudentShowButton);
            Controls.Add(StudentAddButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıtlı Öğrenciler";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StudentAddButton;
        private Button StudentShowButton;
        private TextBox StudentNameBox;
        private TextBox StudentPasswordBox;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}
