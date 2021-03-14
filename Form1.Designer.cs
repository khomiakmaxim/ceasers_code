namespace Crypto1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sourceStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSourceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readEnctyptedStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEnctyptedStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printEnctyptedStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxSource = new System.Windows.Forms.RichTextBox();
            this.richTextBoxWork = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonexecute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonUkr = new System.Windows.Forms.RadioButton();
            this.radioButtonLat = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonEncrypted = new System.Windows.Forms.RadioButton();
            this.radioButtonCrypted = new System.Windows.Forms.RadioButton();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxBruteForce = new System.Windows.Forms.CheckBox();
            this.buttonEncrypted = new System.Windows.Forms.Button();
            this.sweetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sweetsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sweetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sweetsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceStripMenuItem1,
            this.encryptedToolStripMenuItem,
            this.developerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(860, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sourceStripMenuItem1
            // 
            this.sourceStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readSourceToolStripMenuItem,
            this.saveSourceToolStripMenuItem1,
            this.printSourceToolStripMenuItem});
            this.sourceStripMenuItem1.Name = "sourceStripMenuItem1";
            this.sourceStripMenuItem1.Size = new System.Drawing.Size(69, 21);
            this.sourceStripMenuItem1.Text = "Source";
            this.sourceStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // readSourceToolStripMenuItem
            // 
            this.readSourceToolStripMenuItem.Name = "readSourceToolStripMenuItem";
            this.readSourceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.readSourceToolStripMenuItem.Text = "Read file";
            this.readSourceToolStripMenuItem.Click += new System.EventHandler(this.readSourceToolStripMenuItem_Click);
            // 
            // saveSourceToolStripMenuItem1
            // 
            this.saveSourceToolStripMenuItem1.Name = "saveSourceToolStripMenuItem1";
            this.saveSourceToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.saveSourceToolStripMenuItem1.Text = "Save file";
            this.saveSourceToolStripMenuItem1.Click += new System.EventHandler(this.saveSourceToolStripMenuItem1_Click);
            // 
            // printSourceToolStripMenuItem
            // 
            this.printSourceToolStripMenuItem.Name = "printSourceToolStripMenuItem";
            this.printSourceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.printSourceToolStripMenuItem.Text = "Print file";
            this.printSourceToolStripMenuItem.Click += new System.EventHandler(this.printSourceStripMenuItem_Click);
            // 
            // encryptedToolStripMenuItem
            // 
            this.encryptedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readEnctyptedStripMenuItem,
            this.saveEnctyptedStripMenuItem1,
            this.printEnctyptedStripMenuItem1});
            this.encryptedToolStripMenuItem.Name = "encryptedToolStripMenuItem";
            this.encryptedToolStripMenuItem.Size = new System.Drawing.Size(125, 21);
            this.encryptedToolStripMenuItem.Text = "Encrypted text";
            // 
            // readEnctyptedStripMenuItem
            // 
            this.readEnctyptedStripMenuItem.Name = "readEnctyptedStripMenuItem";
            this.readEnctyptedStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.readEnctyptedStripMenuItem.Text = "Read file";
            this.readEnctyptedStripMenuItem.Click += new System.EventHandler(this.readEnctyptedStripMenuItem_Click);
            // 
            // saveEnctyptedStripMenuItem1
            // 
            this.saveEnctyptedStripMenuItem1.Name = "saveEnctyptedStripMenuItem1";
            this.saveEnctyptedStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.saveEnctyptedStripMenuItem1.Text = "Save file";
            this.saveEnctyptedStripMenuItem1.Click += new System.EventHandler(this.saveEncryptedStripMenuItem1_Click);
            // 
            // printEnctyptedStripMenuItem1
            // 
            this.printEnctyptedStripMenuItem1.Name = "printEnctyptedStripMenuItem1";
            this.printEnctyptedStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.printEnctyptedStripMenuItem1.Text = "Print file";
            this.printEnctyptedStripMenuItem1.Click += new System.EventHandler(this.printEncryptedStripMenuItem1_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.developerToolStripMenuItem.Text = "Creator";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(56, 338);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(254, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About  author";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "Хом\'як Максим\r\n\r\n     ПМІ-35\r\n\r\n";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 191);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ok";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files(*.txt) |*.txt|Word files(*.doc)|*.doc|Word files(*.docx)|*.docx";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBoxSource
            // 
            this.richTextBoxSource.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSource.Location = new System.Drawing.Point(40, 101);
            this.richTextBoxSource.Name = "richTextBoxSource";
            this.richTextBoxSource.Size = new System.Drawing.Size(304, 300);
            this.richTextBoxSource.TabIndex = 6;
            this.richTextBoxSource.Text = "";
            // 
            // richTextBoxWork
            // 
            this.richTextBoxWork.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxWork.Location = new System.Drawing.Point(510, 101);
            this.richTextBoxWork.Name = "richTextBoxWork";
            this.richTextBoxWork.Size = new System.Drawing.Size(304, 300);
            this.richTextBoxWork.TabIndex = 7;
            this.richTextBoxWork.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Текст для шифрування";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(518, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Зашифрований текст";
            // 
            // buttonexecute
            // 
            this.buttonexecute.BackColor = System.Drawing.Color.Tan;
            this.buttonexecute.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonexecute.Location = new System.Drawing.Point(369, 433);
            this.buttonexecute.Name = "buttonexecute";
            this.buttonexecute.Size = new System.Drawing.Size(118, 44);
            this.buttonexecute.TabIndex = 14;
            this.buttonexecute.Text = "Виконати";
            this.buttonexecute.UseVisualStyleBackColor = false;
            this.buttonexecute.Click += new System.EventHandler(this.buttonexecute_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonUkr);
            this.panel1.Controls.Add(this.radioButtonLat);
            this.panel1.Location = new System.Drawing.Point(361, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 82);
            this.panel1.TabIndex = 18;
            // 
            // radioButtonUkr
            // 
            this.radioButtonUkr.AutoSize = true;
            this.radioButtonUkr.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonUkr.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonUkr.Location = new System.Drawing.Point(0, 53);
            this.radioButtonUkr.Name = "radioButtonUkr";
            this.radioButtonUkr.Size = new System.Drawing.Size(120, 22);
            this.radioButtonUkr.TabIndex = 12;
            this.radioButtonUkr.Text = "Українська";
            this.radioButtonUkr.UseVisualStyleBackColor = true;
            this.radioButtonUkr.CheckedChanged += new System.EventHandler(this.radioButtonUkr_CheckedChanged);
            // 
            // radioButtonLat
            // 
            this.radioButtonLat.AutoSize = true;
            this.radioButtonLat.Checked = true;
            this.radioButtonLat.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonLat.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonLat.Location = new System.Drawing.Point(0, 12);
            this.radioButtonLat.Name = "radioButtonLat";
            this.radioButtonLat.Size = new System.Drawing.Size(86, 22);
            this.radioButtonLat.TabIndex = 11;
            this.radioButtonLat.TabStop = true;
            this.radioButtonLat.Text = "Латина";
            this.radioButtonLat.UseVisualStyleBackColor = true;
            this.radioButtonLat.CheckedChanged += new System.EventHandler(this.radioButtonLat_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonEncrypted);
            this.panel2.Controls.Add(this.radioButtonCrypted);
            this.panel2.Location = new System.Drawing.Point(360, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 95);
            this.panel2.TabIndex = 19;
            // 
            // radioButtonEncrypted
            // 
            this.radioButtonEncrypted.AutoSize = true;
            this.radioButtonEncrypted.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEncrypted.Location = new System.Drawing.Point(0, 55);
            this.radioButtonEncrypted.Name = "radioButtonEncrypted";
            this.radioButtonEncrypted.Size = new System.Drawing.Size(108, 22);
            this.radioButtonEncrypted.TabIndex = 19;
            this.radioButtonEncrypted.Text = "Розшифр.";
            this.radioButtonEncrypted.UseVisualStyleBackColor = true;
            // 
            // radioButtonCrypted
            // 
            this.radioButtonCrypted.AutoSize = true;
            this.radioButtonCrypted.Checked = true;
            this.radioButtonCrypted.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCrypted.Location = new System.Drawing.Point(0, 3);
            this.radioButtonCrypted.Name = "radioButtonCrypted";
            this.radioButtonCrypted.Size = new System.Drawing.Size(122, 22);
            this.radioButtonCrypted.TabIndex = 18;
            this.radioButtonCrypted.TabStop = true;
            this.radioButtonCrypted.Text = "Шифрувати";
            this.radioButtonCrypted.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "TXT File|*.txt|RTF File|*.rtf";
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "TXT File|*.txt|RTF File|*.rtf";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(397, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ключ";
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.Font = new System.Drawing.Font("Verdana", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.comboBoxKey.Location = new System.Drawing.Point(401, 244);
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(46, 24);
            this.comboBoxKey.TabIndex = 22;
            this.comboBoxKey.TextChanged += new System.EventHandler(this.comboBoxKey_TextChanged);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Text files(*.txt) |*.txt|Word files(*.doc)|*.doc|Word files(*.docx)|*.docx";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // checkBoxBruteForce
            // 
            this.checkBoxBruteForce.AutoSize = true;
            this.checkBoxBruteForce.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBruteForce.Location = new System.Drawing.Point(562, 441);
            this.checkBoxBruteForce.Name = "checkBoxBruteForce";
            this.checkBoxBruteForce.Size = new System.Drawing.Size(80, 18);
            this.checkBoxBruteForce.TabIndex = 23;
            this.checkBoxBruteForce.Text = "Перебір";
            this.checkBoxBruteForce.UseVisualStyleBackColor = true;
            this.checkBoxBruteForce.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonEncrypted
            // 
            this.buttonEncrypted.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonEncrypted.Enabled = false;
            this.buttonEncrypted.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypted.Location = new System.Drawing.Point(690, 433);
            this.buttonEncrypted.Name = "buttonEncrypted";
            this.buttonEncrypted.Size = new System.Drawing.Size(124, 37);
            this.buttonEncrypted.TabIndex = 24;
            this.buttonEncrypted.Text = "Розшифроване";
            this.buttonEncrypted.UseVisualStyleBackColor = false;
            this.buttonEncrypted.Click += new System.EventHandler(this.buttonEncrypted_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.Sort = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 517);
            this.Controls.Add(this.buttonEncrypted);
            this.Controls.Add(this.checkBoxBruteForce);
            this.Controls.Add(this.comboBoxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonexecute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxWork);
            this.Controls.Add(this.richTextBoxSource);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифр Цезаря";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sweetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sweetsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sourceStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encryptedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSourceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveEnctyptedStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printEnctyptedStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource sweetsBindingSource;
        private System.Windows.Forms.BindingSource sweetsBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem printSourceToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxSource;
        private System.Windows.Forms.RichTextBox richTextBoxWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonexecute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonUkr;
        private System.Windows.Forms.RadioButton radioButtonLat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonEncrypted;
        private System.Windows.Forms.RadioButton radioButtonCrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKey;
        private System.Windows.Forms.ToolStripMenuItem readEnctyptedStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.CheckBox checkBoxBruteForce;
        private System.Windows.Forms.Button buttonEncrypted;
    }

}

