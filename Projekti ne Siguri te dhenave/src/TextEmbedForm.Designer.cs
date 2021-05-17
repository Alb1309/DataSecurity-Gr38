namespace ProductionProject
{
    partial class TextEmbedForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textToEmbed = new System.Windows.Forms.TextBox();
            this.embedButton = new System.Windows.Forms.Button();
            this.embedLabel = new System.Windows.Forms.Label();
            this.decodeButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Caesar_btn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decodedLabel = new System.Windows.Forms.Label();
            this.decodedText = new System.Windows.Forms.TextBox();
            this.stegoLengthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.openTextBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveStegoBtn = new System.Windows.Forms.Button();
            this.openStegoBtn = new System.Windows.Forms.Button();
            this.inputStegoLabel = new System.Windows.Forms.Label();
            this.stegobox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.routeBox = new System.Windows.Forms.TextBox();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.infoStorage = new System.Windows.Forms.Label();
            this.infoPixelDepth = new System.Windows.Forms.Label();
            this.infoRes = new System.Windows.Forms.Label();
            this.infoHeight = new System.Windows.Forms.Label();
            this.infoWidth = new System.Windows.Forms.Label();
            this.infoSize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBoxStego = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.Lsb1Button = new System.Windows.Forms.RadioButton();
            this.Lsb2Button = new System.Windows.Forms.RadioButton();
            this.Lsb3Button = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Lsb4Button = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStego)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textToEmbed
            // 
            this.textToEmbed.BackColor = System.Drawing.Color.White;
            this.textToEmbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToEmbed.Location = new System.Drawing.Point(13, 242);
            this.textToEmbed.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textToEmbed.MaxLength = 200000;
            this.textToEmbed.Multiline = true;
            this.textToEmbed.Name = "textToEmbed";
            this.textToEmbed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToEmbed.Size = new System.Drawing.Size(444, 230);
            this.textToEmbed.TabIndex = 6;
            // 
            // embedButton
            // 
            this.embedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.embedButton.Location = new System.Drawing.Point(375, 565);
            this.embedButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.embedButton.Name = "embedButton";
            this.embedButton.Size = new System.Drawing.Size(80, 26);
            this.embedButton.TabIndex = 7;
            this.embedButton.Text = "Mberthyrja";
            this.embedButton.UseVisualStyleBackColor = true;
            this.embedButton.Click += new System.EventHandler(this.embedButton_Click);
            // 
            // embedLabel
            // 
            this.embedLabel.AutoSize = true;
            this.embedLabel.Location = new System.Drawing.Point(17, 226);
            this.embedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.embedLabel.Name = "embedLabel";
            this.embedLabel.Size = new System.Drawing.Size(78, 13);
            this.embedLabel.TabIndex = 8;
            this.embedLabel.Text = "Teksti per tu mberthyer:";
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(375, 595);
            this.decodeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(80, 26);
            this.decodeButton.TabIndex = 9;
            this.decodeButton.Text = "Dekodo";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click_1);

            // contextMenuStrip1

            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);

            // radioButton1

            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 44);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Simetrik";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Celsi enkriptues";
            // 
            // decodedLabel
            // 
            this.decodedLabel.AutoSize = true;
            this.decodedLabel.Location = new System.Drawing.Point(21, 631);
            this.decodedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decodedLabel.Name = "decodedLabel";
            this.decodedLabel.Size = new System.Drawing.Size(74, 13);
            this.decodedLabel.TabIndex = 32;
            this.decodedLabel.Text = "Teksti i dekodum:";
            // 
            // decodedText
            // 
            this.decodedText.BackColor = System.Drawing.Color.White;
            this.decodedText.Location = new System.Drawing.Point(13, 648);
            this.decodedText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.decodedText.Multiline = true;
            this.decodedText.Name = "decodedText";
            this.decodedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decodedText.Size = new System.Drawing.Size(444, 230);
            this.decodedText.TabIndex = 33;
            this.decodedText.TextChanged += new System.EventHandler(this.decodedText_TextChanged);
            // 
            // openTextBtn
            // 
            this.openTextBtn.Location = new System.Drawing.Point(196, 214);
            this.openTextBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.openTextBtn.Name = "openTextBtn";
            this.openTextBtn.Size = new System.Drawing.Size(80, 26);
            this.openTextBtn.TabIndex = 36;
            this.openTextBtn.Text = "Hap tekstin...";
            this.openTextBtn.UseVisualStyleBackColor = true;
            this.openTextBtn.Click += new System.EventHandler(this.openTextBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveStegoBtn);
            this.groupBox1.Controls.Add(this.openStegoBtn);
            this.groupBox1.Controls.Add(this.inputStegoLabel);
            this.groupBox1.Controls.Add(this.stegobox);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.routeBox);
            this.groupBox1.Controls.Add(this.inputFileLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(280, 178);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fajlli:";
            // 
            // saveStegoBtn
            // 
            this.saveStegoBtn.Enabled = false;
            this.saveStegoBtn.Location = new System.Drawing.Point(184, 136);
            this.saveStegoBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.saveStegoBtn.Name = "saveStegoBtn";
            this.saveStegoBtn.Size = new System.Drawing.Size(80, 26);
            this.saveStegoBtn.TabIndex = 39;
            this.saveStegoBtn.Text = "Ruaj...";
            this.saveStegoBtn.UseVisualStyleBackColor = true;
            this.saveStegoBtn.Click += new System.EventHandler(this.saveStegoBtn_Click_1);
            // 
            // openStegoBtn
            // 
            this.openStegoBtn.Location = new System.Drawing.Point(92, 136);
            this.openStegoBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.openStegoBtn.Name = "openStegoBtn";
            this.openStegoBtn.Size = new System.Drawing.Size(80, 26);
            this.openStegoBtn.TabIndex = 38;
            this.openStegoBtn.Text = "Hap...";
            this.openStegoBtn.UseVisualStyleBackColor = true;
            this.openStegoBtn.Click += new System.EventHandler(this.openStegoBtn_Click_1);
            // 
            // inputStegoLabel
            // 
            this.inputStegoLabel.AutoSize = true;
            this.inputStegoLabel.Location = new System.Drawing.Point(6, 94);
            this.inputStegoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputStegoLabel.Name = "inputStegoLabel";
            this.inputStegoLabel.Size = new System.Drawing.Size(65, 13);
            this.inputStegoLabel.TabIndex = 37;
            this.inputStegoLabel.Text = "Procesi i mbulimit:";
            // 
            // stegobox
            // 
            this.stegobox.Location = new System.Drawing.Point(4, 108);
            this.stegobox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.stegobox.Name = "stegobox";
            this.stegobox.Size = new System.Drawing.Size(260, 20);
            this.stegobox.TabIndex = 36;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(92, 66);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(80, 26);
            this.openButton.TabIndex = 34;
            this.openButton.Text = "Hap...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
            // 
            // routeBox
            // 
            this.routeBox.Location = new System.Drawing.Point(4, 38);
            this.routeBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.routeBox.Name = "routeBox";
            this.routeBox.Size = new System.Drawing.Size(260, 20);
            this.routeBox.TabIndex = 33;
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Location = new System.Drawing.Point(6, 17);
            this.inputFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(66, 13);
            this.inputFileLabel.TabIndex = 32;
            this.inputFileLabel.Text = "Foto baze:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxInput);
            this.groupBox3.Location = new System.Drawing.Point(463, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(548, 425);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Foto origjinale:";
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxInput.Location = new System.Drawing.Point(8, 17);
            this.pictureBoxInput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(536, 397);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInput.TabIndex = 5;
            this.pictureBoxInput.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pBar1);
            this.groupBox4.Controls.Add(this.pictureBoxStego);
            this.groupBox4.Location = new System.Drawing.Point(463, 457);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Size = new System.Drawing.Size(548, 421);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Foto e mbuluar:";
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(76, 4);
            this.pBar1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(464, 11);
            this.pBar1.TabIndex = 43;
            this.pBar1.Click += new System.EventHandler(this.pBar1_Click);
            // 
            // pictureBoxStego
            // 
            this.pictureBoxStego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxStego.Location = new System.Drawing.Point(6, 18);
            this.pictureBoxStego.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxStego.Name = "pictureBoxStego";
            this.pictureBoxStego.Size = new System.Drawing.Size(536, 399);
            this.pictureBoxStego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStego.TabIndex = 25;
            this.pictureBoxStego.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.decryptBtn);
            this.groupBox5.Controls.Add(this.encryptBtn);
            this.groupBox5.Controls.Add(this.Caesar_btn);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(13, 480);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Size = new System.Drawing.Size(232, 143);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Enkriptimi:";
            //
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(149, 112);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 25;
            this.decryptBtn.Text = "Dekripto";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Enabled = false;
            this.encryptBtn.Location = new System.Drawing.Point(8, 112);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 24;
            this.encryptBtn.Text = "Enkripto";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // Lsb1Button
            // 
            this.Lsb1Button.AutoSize = true;
            this.Lsb1Button.Location = new System.Drawing.Point(173, 526);
            this.Lsb1Button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Lsb1Button.Name = "Lsb1Button";
            this.Lsb1Button.Size = new System.Drawing.Size(54, 17);
            this.Lsb1Button.TabIndex = 25;
            this.Lsb1Button.TabStop = true;
            this.Lsb1Button.Text = "RGBA";
            this.Lsb1Button.UseVisualStyleBackColor = true;
            this.Lsb1Button.CheckedChanged += new System.EventHandler(this.Lsb1Button_CheckedChanged);
            //
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 23);
            this.panel1.TabIndex = 43;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENKRIPTIMI DHE DEKRIPTIMI I TEKSTIT NE FOTO";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImage = global::ProductionProject.Properties.Resources.iconfinder_exit_delete_remove_close_x_2931151;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(1004, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextEmbedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 891);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.decodedText);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Lsb1Button);
            this.Controls.Add(this.embedButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openTextBtn);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.stegoLengthLabel);
            this.Controls.Add(this.decodedLabel);
            this.Controls.Add(this.embedLabel);
            this.Controls.Add(this.textToEmbed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "TextEmbedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStego)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.TextBox textToEmbed;
        private System.Windows.Forms.Button embedButton;
        private System.Windows.Forms.Label embedLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton Caesar_btn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxStego;
        private System.Windows.Forms.Label decodedLabel;
        private System.Windows.Forms.TextBox decodedText;
        private System.Windows.Forms.Label stegoLengthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button openTextBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveStegoBtn;
        private System.Windows.Forms.Button openStegoBtn;
        private System.Windows.Forms.Label inputStegoLabel;
        private System.Windows.Forms.TextBox stegobox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox routeBox;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label infoHeight;
        private System.Windows.Forms.Label infoWidth;
        private System.Windows.Forms.Label infoSize;
        private System.Windows.Forms.Label infoPixelDepth;
        private System.Windows.Forms.Label infoRes;
        private System.Windows.Forms.Label infoStorage;
        private System.Windows.Forms.RadioButton Lsb1Button;
        private System.Windows.Forms.RadioButton Lsb2Button;
        private System.Windows.Forms.RadioButton Lsb3Button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton Lsb4Button;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

