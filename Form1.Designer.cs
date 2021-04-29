
namespace CPPKConverter
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
            this.header = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.scanFileButton = new System.Windows.Forms.Button();
            this.infoContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileQuestions = new System.Windows.Forms.Label();
            this.fileType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.fileEaterContainer = new System.Windows.Forms.Panel();
            this.fileEater = new System.Windows.Forms.Panel();
            this.dropInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.TextBox();
            this.themeName = new System.Windows.Forms.TextBox();
            this.newFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.convertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newFileName = new System.Windows.Forms.TextBox();
            this.bakeStatus = new System.Windows.Forms.Label();
            this.folderChoose = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.header.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.infoContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fileEaterContainer.SuspendLayout();
            this.fileEater.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.panel3);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.hideButton);
            this.header.Controls.Add(this.closeButton);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 46);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 46);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPPK Converter";
            // 
            // hideButton
            // 
            this.hideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hideButton.ForeColor = System.Drawing.Color.White;
            this.hideButton.Location = new System.Drawing.Point(702, 0);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(49, 46);
            this.hideButton.TabIndex = 1;
            this.hideButton.Text = "_";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(751, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(49, 46);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.sidePanel.Controls.Add(this.scanFileButton);
            this.sidePanel.Controls.Add(this.infoContainer);
            this.sidePanel.Controls.Add(this.fileEaterContainer);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 46);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(230, 462);
            this.sidePanel.TabIndex = 1;
            // 
            // scanFileButton
            // 
            this.scanFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(169)))));
            this.scanFileButton.FlatAppearance.BorderSize = 0;
            this.scanFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanFileButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scanFileButton.ForeColor = System.Drawing.Color.White;
            this.scanFileButton.Location = new System.Drawing.Point(12, 399);
            this.scanFileButton.Name = "scanFileButton";
            this.scanFileButton.Size = new System.Drawing.Size(205, 51);
            this.scanFileButton.TabIndex = 2;
            this.scanFileButton.Text = "Обработать файл";
            this.scanFileButton.UseVisualStyleBackColor = false;
            this.scanFileButton.Click += new System.EventHandler(this.scanFileButton_Click);
            // 
            // infoContainer
            // 
            this.infoContainer.Controls.Add(this.panel2);
            this.infoContainer.Controls.Add(this.fileName);
            this.infoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoContainer.Location = new System.Drawing.Point(0, 196);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Size = new System.Drawing.Size(230, 188);
            this.infoContainer.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fileQuestions);
            this.panel2.Controls.Add(this.fileType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 107);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // fileQuestions
            // 
            this.fileQuestions.ForeColor = System.Drawing.Color.White;
            this.fileQuestions.Location = new System.Drawing.Point(12, 38);
            this.fileQuestions.Name = "fileQuestions";
            this.fileQuestions.Size = new System.Drawing.Size(205, 48);
            this.fileQuestions.TabIndex = 2;
            this.fileQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileType
            // 
            this.fileType.AutoSize = true;
            this.fileType.ForeColor = System.Drawing.Color.White;
            this.fileType.Location = new System.Drawing.Point(71, 10);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(34, 15);
            this.fileType.TabIndex = 3;
            this.fileType.Text = "fjjhgj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "формат:";
            // 
            // fileName
            // 
            this.fileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(169)))));
            this.fileName.Location = new System.Drawing.Point(0, 0);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(230, 38);
            this.fileName.TabIndex = 2;
            this.fileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileEaterContainer
            // 
            this.fileEaterContainer.Controls.Add(this.fileEater);
            this.fileEaterContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileEaterContainer.Location = new System.Drawing.Point(0, 0);
            this.fileEaterContainer.Name = "fileEaterContainer";
            this.fileEaterContainer.Size = new System.Drawing.Size(230, 196);
            this.fileEaterContainer.TabIndex = 2;
            // 
            // fileEater
            // 
            this.fileEater.AllowDrop = true;
            this.fileEater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.fileEater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileEater.BackgroundImage")));
            this.fileEater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fileEater.Controls.Add(this.dropInfo);
            this.fileEater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileEater.Location = new System.Drawing.Point(17, 22);
            this.fileEater.Name = "fileEater";
            this.fileEater.Size = new System.Drawing.Size(200, 153);
            this.fileEater.TabIndex = 2;
            this.fileEater.Click += new System.EventHandler(this.fileEater_Click);
            this.fileEater.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileEater_DragDrop);
            this.fileEater.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileEater_DragEnter);
            // 
            // dropInfo
            // 
            this.dropInfo.ForeColor = System.Drawing.Color.White;
            this.dropInfo.Location = new System.Drawing.Point(12, 110);
            this.dropInfo.Name = "dropInfo";
            this.dropInfo.Size = new System.Drawing.Size(176, 42);
            this.dropInfo.TabIndex = 2;
            this.dropInfo.Text = "Перетащите сюда файл или нажмите сюда";
            this.dropInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 144);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(234, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Параметры";
            // 
            // courseName
            // 
            this.courseName.Enabled = false;
            this.courseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseName.Location = new System.Drawing.Point(245, 97);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(533, 29);
            this.courseName.TabIndex = 3;
            // 
            // themeName
            // 
            this.themeName.Enabled = false;
            this.themeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themeName.Location = new System.Drawing.Point(245, 148);
            this.themeName.Name = "themeName";
            this.themeName.Size = new System.Drawing.Size(533, 29);
            this.themeName.TabIndex = 4;
            // 
            // newFilePath
            // 
            this.newFilePath.Enabled = false;
            this.newFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newFilePath.Location = new System.Drawing.Point(245, 199);
            this.newFilePath.Name = "newFilePath";
            this.newFilePath.Size = new System.Drawing.Size(428, 29);
            this.newFilePath.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(255, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Конечный формат";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(265, 362);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "txt";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(265, 411);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "xml";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(265, 387);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 19);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "gift";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(169)))));
            this.convertButton.Enabled = false;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(636, 454);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(142, 39);
            this.convertButton.TabIndex = 10;
            this.convertButton.Text = "Конвертировать";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(255, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "название курса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(258, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "название темы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(260, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "путь к новому файлу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(260, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "название нового файла";
            // 
            // newFileName
            // 
            this.newFileName.BackColor = System.Drawing.SystemColors.Window;
            this.newFileName.Enabled = false;
            this.newFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newFileName.ForeColor = System.Drawing.Color.Black;
            this.newFileName.Location = new System.Drawing.Point(245, 251);
            this.newFileName.Name = "newFileName";
            this.newFileName.Size = new System.Drawing.Size(533, 29);
            this.newFileName.TabIndex = 6;
            // 
            // bakeStatus
            // 
            this.bakeStatus.Enabled = false;
            this.bakeStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bakeStatus.Location = new System.Drawing.Point(255, 460);
            this.bakeStatus.Name = "bakeStatus";
            this.bakeStatus.Size = new System.Drawing.Size(375, 39);
            this.bakeStatus.TabIndex = 16;
            this.bakeStatus.Text = "...";
            this.bakeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // folderChoose
            // 
            this.folderChoose.Enabled = false;
            this.folderChoose.Location = new System.Drawing.Point(679, 199);
            this.folderChoose.Name = "folderChoose";
            this.folderChoose.Size = new System.Drawing.Size(99, 29);
            this.folderChoose.TabIndex = 17;
            this.folderChoose.Text = "Обзор...";
            this.folderChoose.UseVisualStyleBackColor = true;
            this.folderChoose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.folderChoose_MouseClick);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(265, 436);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 19);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.Text = "xml2";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.folderChoose);
            this.Controls.Add(this.bakeStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newFileName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newFilePath);
            this.Controls.Add(this.themeName);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 508);
            this.MinimumSize = new System.Drawing.Size(800, 508);
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.infoContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fileEaterContainer.ResumeLayout(false);
            this.fileEater.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button scanFileButton;
        private System.Windows.Forms.Panel infoContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fileQuestions;
        private System.Windows.Forms.Label fileType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Panel fileEaterContainer;
        private System.Windows.Forms.Panel fileEater;
        private System.Windows.Forms.Label dropInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.TextBox themeName;
        private System.Windows.Forms.TextBox newFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newFileName;
        private System.Windows.Forms.Label bakeStatus;
        private System.Windows.Forms.Button folderChoose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

