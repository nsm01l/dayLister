namespace dayLister
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weekStart = new System.Windows.Forms.ComboBox();
            this.weekEnd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.chkIsLonger = new System.Windows.Forms.CheckBox();
            this.txtFormatRange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormatOneday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(12, 34);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(117, 19);
            this.dateStart.TabIndex = 0;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(163, 34);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(117, 19);
            this.dateEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "開始日:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "終了日:";
            // 
            // weekStart
            // 
            this.weekStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weekStart.FormattingEnabled = true;
            this.weekStart.Items.AddRange(new object[] {
            "日",
            "月",
            "火",
            "水",
            "木",
            "金",
            "土"});
            this.weekStart.Location = new System.Drawing.Point(12, 92);
            this.weekStart.Name = "weekStart";
            this.weekStart.Size = new System.Drawing.Size(117, 20);
            this.weekStart.TabIndex = 4;
            // 
            // weekEnd
            // 
            this.weekEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weekEnd.FormattingEnabled = true;
            this.weekEnd.Items.AddRange(new object[] {
            "日",
            "月",
            "火",
            "水",
            "木",
            "金",
            "土"});
            this.weekEnd.Location = new System.Drawing.Point(163, 92);
            this.weekEnd.Name = "weekEnd";
            this.weekEnd.Size = new System.Drawing.Size(117, 20);
            this.weekEnd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "曜日(終了):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "曜日(開始):";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(190, 132);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 8;
            this.btnGen.Text = "生成";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(12, 161);
            this.txtGen.Multiline = true;
            this.txtGen.Name = "txtGen";
            this.txtGen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGen.Size = new System.Drawing.Size(268, 110);
            this.txtGen.TabIndex = 9;
            this.txtGen.DoubleClick += new System.EventHandler(this.txtGen_DoubleClick);
            // 
            // chkIsLonger
            // 
            this.chkIsLonger.AutoSize = true;
            this.chkIsLonger.Location = new System.Drawing.Point(14, 136);
            this.chkIsLonger.Name = "chkIsLonger";
            this.chkIsLonger.Size = new System.Drawing.Size(170, 16);
            this.chkIsLonger.TabIndex = 10;
            this.chkIsLonger.Text = "開始・終了は日にちを重視する";
            this.chkIsLonger.UseVisualStyleBackColor = true;
            // 
            // txtFormatRange
            // 
            this.txtFormatRange.Location = new System.Drawing.Point(49, 282);
            this.txtFormatRange.Name = "txtFormatRange";
            this.txtFormatRange.Size = new System.Drawing.Size(231, 19);
            this.txtFormatRange.TabIndex = 11;
            this.txtFormatRange.Text = "%md1% - %md2%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "範囲:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "1日:";
            // 
            // txtFormatOneday
            // 
            this.txtFormatOneday.Location = new System.Drawing.Point(49, 307);
            this.txtFormatOneday.Name = "txtFormatOneday";
            this.txtFormatOneday.Size = new System.Drawing.Size(231, 19);
            this.txtFormatOneday.TabIndex = 13;
            this.txtFormatOneday.Text = "%md%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 336);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFormatOneday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFormatRange);
            this.Controls.Add(this.chkIsLonger);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weekEnd);
            this.Controls.Add(this.weekStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DayLister";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox weekStart;
        private System.Windows.Forms.ComboBox weekEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.CheckBox chkIsLonger;
        private System.Windows.Forms.TextBox txtFormatRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFormatOneday;
    }
}

