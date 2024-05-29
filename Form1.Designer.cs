namespace WinFormsApp3
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            listBox2 = new ListBox();
            tabPage3 = new TabPage();
            pictureBox3 = new PictureBox();
            listBox3 = new ListBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(14, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(764, 376);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ControlDark;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(756, 348);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Names";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(504, -134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 666);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(66, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 22);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 55);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(28, 22);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top;
            listBox1.BackColor = Color.FromArgb(192, 0, 0);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = SystemColors.Menu;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(262, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 276);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listbox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlDark;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(756, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Location";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(504, -134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(324, 666);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top;
            listBox2.BackColor = Color.FromArgb(192, 0, 0);
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.ForeColor = SystemColors.Menu;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 23;
            listBox2.Location = new Point(262, 26);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(236, 276);
            listBox2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlDark;
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Controls.Add(listBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(756, 348);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Desc";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(504, -134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(324, 666);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(192, 0, 0);
            listBox3.BorderStyle = BorderStyle.None;
            listBox3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox3.ForeColor = SystemColors.Menu;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 23;
            listBox3.Location = new Point(262, 26);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(236, 276);
            listBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(692, 398);
            button1.Name = "button1";
            button1.Size = new Size(86, 40);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.Menu;
            checkBox1.Location = new Point(23, 394);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Karyna ist da";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Spirits";
            TransparencyKey = Color.Transparent;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private CheckBox checkBox1;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox2;
        private TabPage tabPage3;
        private ListBox listBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
