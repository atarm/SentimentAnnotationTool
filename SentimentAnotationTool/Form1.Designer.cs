
namespace SentimentAnotationTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.NegativeButton = new System.Windows.Forms.Button();
            this.NeutralButton = new System.Windows.Forms.Button();
            this.PositiveButton = new System.Windows.Forms.Button();
            this.BackSentence = new System.Windows.Forms.Button();
            this.NowSentence = new System.Windows.Forms.TextBox();
            this.AllFilesNum = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentFilePath = new System.Windows.Forms.TextBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.NowLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CurrentFileNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label98 = new System.Windows.Forms.Label();
            this.PrevLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NegativeButton
            // 
            this.NegativeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NegativeButton.Location = new System.Drawing.Point(0, 0);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(104, 44);
            this.NegativeButton.TabIndex = 0;
            this.NegativeButton.Text = "Negative (&1)";
            this.NegativeButton.UseVisualStyleBackColor = true;
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // NeutralButton
            // 
            this.NeutralButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeutralButton.Location = new System.Drawing.Point(0, 0);
            this.NeutralButton.Name = "NeutralButton";
            this.NeutralButton.Size = new System.Drawing.Size(109, 44);
            this.NeutralButton.TabIndex = 1;
            this.NeutralButton.Text = "Neutral (&2)";
            this.NeutralButton.UseVisualStyleBackColor = true;
            this.NeutralButton.Click += new System.EventHandler(this.NeutralButton_Click);
            // 
            // PositiveButton
            // 
            this.PositiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositiveButton.Location = new System.Drawing.Point(0, 0);
            this.PositiveButton.Name = "PositiveButton";
            this.PositiveButton.Size = new System.Drawing.Size(105, 44);
            this.PositiveButton.TabIndex = 2;
            this.PositiveButton.Text = "Positive (&3)";
            this.PositiveButton.UseVisualStyleBackColor = true;
            this.PositiveButton.Click += new System.EventHandler(this.PositiveButton_Click);
            // 
            // BackSentence
            // 
            this.BackSentence.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackSentence.Location = new System.Drawing.Point(12, 218);
            this.BackSentence.Name = "BackSentence";
            this.BackSentence.Size = new System.Drawing.Size(75, 26);
            this.BackSentence.TabIndex = 3;
            this.BackSentence.Text = "Prev (&B)";
            this.BackSentence.UseVisualStyleBackColor = true;
            this.BackSentence.Click += new System.EventHandler(this.BackSentence_Click);
            // 
            // NowSentence
            // 
            this.NowSentence.BackColor = System.Drawing.Color.White;
            this.NowSentence.Font = new System.Drawing.Font("游明朝", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NowSentence.Location = new System.Drawing.Point(12, 64);
            this.NowSentence.Multiline = true;
            this.NowSentence.Name = "NowSentence";
            this.NowSentence.ReadOnly = true;
            this.NowSentence.Size = new System.Drawing.Size(491, 130);
            this.NowSentence.TabIndex = 4;
            this.NowSentence.Text = "None";
            // 
            // AllFilesNum
            // 
            this.AllFilesNum.AutoSize = true;
            this.AllFilesNum.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllFilesNum.Location = new System.Drawing.Point(184, 45);
            this.AllFilesNum.Name = "AllFilesNum";
            this.AllFilesNum.Size = new System.Drawing.Size(16, 16);
            this.AllFilesNum.TabIndex = 6;
            this.AllFilesNum.Text = "0";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label99.Location = new System.Drawing.Point(150, 45);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(16, 16);
            this.label99.TabIndex = 7;
            this.label99.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 8;
            // 
            // CurrentFilePath
            // 
            this.CurrentFilePath.BackColor = System.Drawing.Color.White;
            this.CurrentFilePath.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CurrentFilePath.Location = new System.Drawing.Point(93, 12);
            this.CurrentFilePath.Name = "CurrentFilePath";
            this.CurrentFilePath.ReadOnly = true;
            this.CurrentFilePath.Size = new System.Drawing.Size(410, 22);
            this.CurrentFilePath.TabIndex = 9;
            this.CurrentFilePath.Text = "None";
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpenFile.Location = new System.Drawing.Point(12, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 10;
            this.OpenFile.Text = "Open";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // NowLabel
            // 
            this.NowLabel.AutoSize = true;
            this.NowLabel.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NowLabel.Location = new System.Drawing.Point(424, 197);
            this.NowLabel.Name = "NowLabel";
            this.NowLabel.Size = new System.Drawing.Size(79, 19);
            this.NowLabel.TabIndex = 11;
            this.NowLabel.Text = "Label [-]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sentence";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.splitContainer1.Location = new System.Drawing.Point(93, 200);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NegativeButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(326, 44);
            this.splitContainer1.SplitterDistance = 104;
            this.splitContainer1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.NeutralButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PositiveButton);
            this.splitContainer2.Size = new System.Drawing.Size(218, 44);
            this.splitContainer2.SplitterDistance = 109;
            this.splitContainer2.TabIndex = 0;
            // 
            // CurrentFileNum
            // 
            this.CurrentFileNum.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CurrentFileNum.Location = new System.Drawing.Point(93, 40);
            this.CurrentFileNum.Name = "CurrentFileNum";
            this.CurrentFileNum.Size = new System.Drawing.Size(51, 23);
            this.CurrentFileNum.TabIndex = 14;
            this.CurrentFileNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentFileNum_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Move";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label98.Location = new System.Drawing.Point(426, 43);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(77, 19);
            this.label98.TabIndex = 16;
            this.label98.Text = "was Set.";
            // 
            // PrevLabel
            // 
            this.PrevLabel.AutoSize = true;
            this.PrevLabel.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrevLabel.Location = new System.Drawing.Point(313, 43);
            this.PrevLabel.Name = "PrevLabel";
            this.PrevLabel.Size = new System.Drawing.Size(55, 19);
            this.PrevLabel.TabIndex = 17;
            this.PrevLabel.Text = "None";
            this.PrevLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(425, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Skip (&S)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 254);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PrevLabel);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CurrentFileNum);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NowLabel);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.CurrentFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.AllFilesNum);
            this.Controls.Add(this.NowSentence);
            this.Controls.Add(this.BackSentence);
            this.Name = "Form1";
            this.Text = "Sentiment Annotation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NegativeButton;
        private System.Windows.Forms.Button NeutralButton;
        private System.Windows.Forms.Button PositiveButton;
        private System.Windows.Forms.Button BackSentence;
        private System.Windows.Forms.TextBox NowSentence;
        private System.Windows.Forms.Label AllFilesNum;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentFilePath;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label NowLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox CurrentFileNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label PrevLabel;
        private System.Windows.Forms.Button button2;
    }
}

