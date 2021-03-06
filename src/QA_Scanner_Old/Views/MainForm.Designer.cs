﻿namespace QA_Scanner.Views
{
    partial class MainForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.siteLink = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.teacherPasswordTB = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.subjectUrlTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.automationLog = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.opacityTrack = new System.Windows.Forms.TrackBar();
            this.findBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.selectedSubject = new System.Windows.Forms.ComboBox();
            this.isAsyncFind = new System.Windows.Forms.CheckBox();
            this.authorLink = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrack)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.automationLog);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.subjectUrlTB);
            this.tabPage2.Controls.Add(this.teacherPasswordTB);
            this.tabPage2.Controls.Add(this.passwordTB);
            this.tabPage2.Controls.Add(this.usernameTB);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.startBtn);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.siteLink);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(549, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Automation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter Username:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(11, 85);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(259, 22);
            this.usernameTB.TabIndex = 1;
            // 
            // siteLink
            // 
            this.siteLink.AutoSize = true;
            this.siteLink.Location = new System.Drawing.Point(51, 20);
            this.siteLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.siteLink.Name = "siteLink";
            this.siteLink.Size = new System.Drawing.Size(122, 17);
            this.siteLink.TabIndex = 2;
            this.siteLink.TabStop = true;
            this.siteLink.Text = "moodle.samtuit.uz";
            this.siteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.siteLink_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Site:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(11, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Enter Password:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(11, 144);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(259, 22);
            this.passwordTB.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Enter Teacher Password:";
            // 
            // teacherPasswordTB
            // 
            this.teacherPasswordTB.Location = new System.Drawing.Point(11, 220);
            this.teacherPasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.teacherPasswordTB.Name = "teacherPasswordTB";
            this.teacherPasswordTB.Size = new System.Drawing.Size(259, 22);
            this.teacherPasswordTB.TabIndex = 7;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(11, 467);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(109, 28);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 278);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Enter Subject URL:";
            // 
            // subjectUrlTB
            // 
            this.subjectUrlTB.Location = new System.Drawing.Point(11, 300);
            this.subjectUrlTB.Margin = new System.Windows.Forms.Padding(4);
            this.subjectUrlTB.Name = "subjectUrlTB";
            this.subjectUrlTB.Size = new System.Drawing.Size(259, 22);
            this.subjectUrlTB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(314, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "EXPERIMENTAL";
            // 
            // automationLog
            // 
            this.automationLog.FormattingEnabled = true;
            this.automationLog.ItemHeight = 16;
            this.automationLog.Location = new System.Drawing.Point(295, 63);
            this.automationLog.Name = "automationLog";
            this.automationLog.Size = new System.Drawing.Size(236, 420);
            this.automationLog.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(549, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.answerText);
            this.panel2.Controls.Add(this.answerLabel);
            this.panel2.Location = new System.Drawing.Point(4, 206);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 185);
            this.panel2.TabIndex = 6;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.Location = new System.Drawing.Point(11, 4);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(77, 20);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.Text = "Answer:";
            // 
            // answerText
            // 
            this.answerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerText.Location = new System.Drawing.Point(11, 28);
            this.answerText.Margin = new System.Windows.Forms.Padding(4);
            this.answerText.Multiline = true;
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(514, 146);
            this.answerText.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.questionText);
            this.panel1.Controls.Add(this.questionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 194);
            this.panel1.TabIndex = 5;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(11, 12);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(90, 20);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "Question:";
            // 
            // questionText
            // 
            this.questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionText.Location = new System.Drawing.Point(11, 36);
            this.questionText.Margin = new System.Windows.Forms.Padding(4);
            this.questionText.Multiline = true;
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(514, 146);
            this.questionText.TabIndex = 1;
            this.questionText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.questionText_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.authorLink);
            this.panel3.Controls.Add(this.isAsyncFind);
            this.panel3.Controls.Add(this.selectedSubject);
            this.panel3.Controls.Add(this.subjectLabel);
            this.panel3.Controls.Add(this.clearBtn);
            this.panel3.Controls.Add(this.findBtn);
            this.panel3.Controls.Add(this.opacityTrack);
            this.panel3.Controls.Add(this.opacityLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 107);
            this.panel3.TabIndex = 12;
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opacityLabel.Location = new System.Drawing.Point(247, 2);
            this.opacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(70, 18);
            this.opacityLabel.TabIndex = 7;
            this.opacityLabel.Text = "Opacity:";
            // 
            // opacityTrack
            // 
            this.opacityTrack.LargeChange = 10;
            this.opacityTrack.Location = new System.Drawing.Point(250, 24);
            this.opacityTrack.Margin = new System.Windows.Forms.Padding(4);
            this.opacityTrack.Maximum = 100;
            this.opacityTrack.Minimum = 5;
            this.opacityTrack.Name = "opacityTrack";
            this.opacityTrack.Size = new System.Drawing.Size(156, 56);
            this.opacityTrack.TabIndex = 4;
            this.opacityTrack.Value = 25;
            this.opacityTrack.Scroll += new System.EventHandler(this.opacityTrack_Scroll);
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBtn.Location = new System.Drawing.Point(425, 24);
            this.findBtn.Margin = new System.Windows.Forms.Padding(4);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(100, 28);
            this.findBtn.TabIndex = 4;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(425, 55);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectLabel.Location = new System.Drawing.Point(8, 2);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(69, 18);
            this.subjectLabel.TabIndex = 10;
            this.subjectLabel.Text = "Subject:";
            // 
            // selectedSubject
            // 
            this.selectedSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedSubject.FormattingEnabled = true;
            this.selectedSubject.Items.AddRange(new object[] {
            "ManualTableMethod.docx",
            "English_2019.docx",
            "DataStructure_2018.docx",
            "Digital_2019.docx",
            "ComputerNetwork_2019.docx",
            "Philosophy_2019.docx",
            "C++Programming.docx"});
            this.selectedSubject.Location = new System.Drawing.Point(11, 24);
            this.selectedSubject.Margin = new System.Windows.Forms.Padding(4);
            this.selectedSubject.Name = "selectedSubject";
            this.selectedSubject.Size = new System.Drawing.Size(217, 24);
            this.selectedSubject.TabIndex = 8;
            this.selectedSubject.SelectedIndexChanged += new System.EventHandler(this.selectedSubject_SelectedIndexChanged);
            // 
            // isAsyncFind
            // 
            this.isAsyncFind.AutoSize = true;
            this.isAsyncFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isAsyncFind.Location = new System.Drawing.Point(11, 55);
            this.isAsyncFind.Name = "isAsyncFind";
            this.isAsyncFind.Size = new System.Drawing.Size(176, 21);
            this.isAsyncFind.TabIndex = 11;
            this.isAsyncFind.Text = "Asynchronously find";
            this.isAsyncFind.UseVisualStyleBackColor = true;
            this.isAsyncFind.CheckedChanged += new System.EventHandler(this.isAsyncFind_CheckedChanged);
            // 
            // authorLink
            // 
            this.authorLink.AutoSize = true;
            this.authorLink.BackColor = System.Drawing.Color.Transparent;
            this.authorLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLink.LinkColor = System.Drawing.Color.Black;
            this.authorLink.Location = new System.Drawing.Point(8, 89);
            this.authorLink.Name = "authorLink";
            this.authorLink.Size = new System.Drawing.Size(165, 17);
            this.authorLink.TabIndex = 12;
            this.authorLink.TabStop = true;
            this.authorLink.Text = "Developed by SuxrobGM";
            this.authorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorLink_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 533);
            this.tabControl1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 533);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QA Scanner";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrack)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox automationLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectUrlTB;
        private System.Windows.Forms.TextBox teacherPasswordTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel siteLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel authorLink;
        private System.Windows.Forms.CheckBox isAsyncFind;
        private System.Windows.Forms.ComboBox selectedSubject;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TrackBar opacityTrack;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

