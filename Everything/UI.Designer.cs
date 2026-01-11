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
            KayitliOgrenciGetir = new Button();
            KayitliOgrenciBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
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
            StudentAddButton.Location = new Point(617, 277);
            StudentAddButton.Name = "StudentAddButton";
            StudentAddButton.Size = new Size(161, 23);
            StudentAddButton.TabIndex = 0;
            StudentAddButton.Text = "Öğrenci Ekle";
            StudentAddButton.UseVisualStyleBackColor = false;
            StudentAddButton.Click += StudentAddButton_Click;
            // 
            // StudentShowButton
            // 
            StudentShowButton.BackColor = Color.Lavender;
            StudentShowButton.FlatStyle = FlatStyle.Popup;
            StudentShowButton.Location = new Point(92, 352);
            StudentShowButton.Name = "StudentShowButton";
            StudentShowButton.Size = new Size(161, 23);
            StudentShowButton.TabIndex = 2;
            StudentShowButton.Text = "Tüm Öğrencileri Göster";
            StudentShowButton.UseVisualStyleBackColor = false;
            StudentShowButton.Click += button2_Click;
            // 
            // StudentNameBox
            // 
            StudentNameBox.Location = new Point(606, 213);
            StudentNameBox.Name = "StudentNameBox";
            StudentNameBox.Size = new Size(182, 23);
            StudentNameBox.TabIndex = 3;
            // 
            // StudentPasswordBox
            // 
            StudentPasswordBox.Location = new Point(606, 248);
            StudentPasswordBox.Name = "StudentPasswordBox";
            StudentPasswordBox.Size = new Size(182, 23);
            StudentPasswordBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Monocraft", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(467, 215);
            label1.Name = "label1";
            label1.Size = new Size(115, 16);
            label1.TabIndex = 5;
            label1.Text = "Öğrenci İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monocraft", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(467, 248);
            label3.Name = "label3";
            label3.Size = new Size(133, 16);
            label3.TabIndex = 7;
            label3.Text = "Öğrenci Parola";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._20250730_0145_Şık_Y_Logo_simple_compose_01k1c5q78bfq999zbs951ket0z;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(507, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 164);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(39, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(281, 306);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // KayitliOgrenciGetir
            // 
            KayitliOgrenciGetir.BackColor = Color.Lavender;
            KayitliOgrenciGetir.FlatStyle = FlatStyle.Popup;
            KayitliOgrenciGetir.Location = new Point(617, 367);
            KayitliOgrenciGetir.Name = "KayitliOgrenciGetir";
            KayitliOgrenciGetir.Size = new Size(161, 23);
            KayitliOgrenciGetir.TabIndex = 10;
            KayitliOgrenciGetir.Text = "Kayıtlı Öğrenci Getir";
            KayitliOgrenciGetir.UseVisualStyleBackColor = false;
            KayitliOgrenciGetir.Click += KayitliOgrenciGetir_Click;
            // 
            // KayitliOgrenciBox
            // 
            KayitliOgrenciBox.Location = new Point(606, 338);
            KayitliOgrenciBox.Name = "KayitliOgrenciBox";
            KayitliOgrenciBox.Size = new Size(182, 23);
            KayitliOgrenciBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monocraft", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(467, 340);
            label2.Name = "label2";
            label2.Size = new Size(115, 16);
            label2.TabIndex = 12;
            label2.Text = "Öğrenci İsim";
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(617, 396);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 13;
            button1.Text = "Kayıtlı Öğrenci Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(92, 381);
            button2.Name = "button2";
            button2.Size = new Size(161, 23);
            button2.TabIndex = 14;
            button2.Text = "Tüm Öğrencileri Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(KayitliOgrenciBox);
            Controls.Add(KayitliOgrenciGetir);
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
        private Button KayitliOgrenciGetir;
        private TextBox KayitliOgrenciBox;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
