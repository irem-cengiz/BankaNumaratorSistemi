namespace BankaUygulamasi
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            dgvMusteriBilgi = new DataGridView();
            btnSiraİleGetir = new Button();
            textBox1 = new TextBox();
            cmbTurler = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriBilgi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 52);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "TC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 96);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Müşteri Türü:";
            // 
            // button1
            // 
            button1.Location = new Point(163, 135);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 2;
            button1.Text = "BANKAYA EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvMusteriBilgi
            // 
            dgvMusteriBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriBilgi.Location = new Point(292, 42);
            dgvMusteriBilgi.Name = "dgvMusteriBilgi";
            dgvMusteriBilgi.RowTemplate.Height = 25;
            dgvMusteriBilgi.Size = new Size(296, 315);
            dgvMusteriBilgi.TabIndex = 3;
            // 
            // btnSiraİleGetir
            // 
            btnSiraİleGetir.Location = new Point(292, 363);
            btnSiraİleGetir.Name = "btnSiraİleGetir";
            btnSiraİleGetir.Size = new Size(296, 33);
            btnSiraİleGetir.TabIndex = 4;
            btnSiraİleGetir.Text = "SIRADAKİNİ GETİR";
            btnSiraİleGetir.UseVisualStyleBackColor = true;
            btnSiraİleGetir.Click += btnSiraİleGetir_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 5;
            // 
            // cmbTurler
            // 
            cmbTurler.FormattingEnabled = true;
            cmbTurler.Location = new Point(143, 92);
            cmbTurler.Name = "cmbTurler";
            cmbTurler.Size = new Size(131, 23);
            cmbTurler.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 450);
            Controls.Add(cmbTurler);
            Controls.Add(textBox1);
            Controls.Add(btnSiraİleGetir);
            Controls.Add(dgvMusteriBilgi);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMusteriBilgi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridView dgvMusteriBilgi;
        private Button btnSiraİleGetir;
        private TextBox textBox1;
        private ComboBox cmbTurler;
    }
}