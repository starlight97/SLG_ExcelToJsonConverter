namespace SLG_ExcelToJsonConverter
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MyText = new System.Windows.Forms.TextBox();
            this.mbtConvert = new MetroFramework.Controls.MetroButton();
            this.mbtDirectoryOpen = new MetroFramework.Controls.MetroButton();
            this.mbtClose = new MetroFramework.Controls.MetroButton();
            this.txtSysMsg = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxExcelList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MyText
            // 
            this.MyText.Enabled = false;
            this.MyText.Location = new System.Drawing.Point(12, 568);
            this.MyText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyText.Name = "MyText";
            this.MyText.Size = new System.Drawing.Size(176, 25);
            this.MyText.TabIndex = 8;
            this.MyText.Text = "만든이 : SLG";
            // 
            // mbtConvert
            // 
            this.mbtConvert.BackColor = System.Drawing.Color.Black;
            this.mbtConvert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtConvert.ForeColor = System.Drawing.Color.White;
            this.mbtConvert.Location = new System.Drawing.Point(138, 461);
            this.mbtConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mbtConvert.Name = "mbtConvert";
            this.mbtConvert.Size = new System.Drawing.Size(100, 65);
            this.mbtConvert.TabIndex = 13;
            this.mbtConvert.Text = "변환";
            this.mbtConvert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mbtConvert.UseCustomForeColor = true;
            this.mbtConvert.UseSelectable = true;
            this.mbtConvert.Click += new System.EventHandler(this.mbtConvert_Click);
            // 
            // mbtDirectoryOpen
            // 
            this.mbtDirectoryOpen.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtDirectoryOpen.ForeColor = System.Drawing.Color.White;
            this.mbtDirectoryOpen.Location = new System.Drawing.Point(14, 461);
            this.mbtDirectoryOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mbtDirectoryOpen.Name = "mbtDirectoryOpen";
            this.mbtDirectoryOpen.Size = new System.Drawing.Size(100, 65);
            this.mbtDirectoryOpen.TabIndex = 13;
            this.mbtDirectoryOpen.Text = "폴더 열기";
            this.mbtDirectoryOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mbtDirectoryOpen.UseCustomForeColor = true;
            this.mbtDirectoryOpen.UseSelectable = true;
            this.mbtDirectoryOpen.Click += new System.EventHandler(this.mbtDirectoryOpen_Click);
            // 
            // mbtClose
            // 
            this.mbtClose.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtClose.ForeColor = System.Drawing.Color.White;
            this.mbtClose.Location = new System.Drawing.Point(258, 461);
            this.mbtClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mbtClose.Name = "mbtClose";
            this.mbtClose.Size = new System.Drawing.Size(100, 65);
            this.mbtClose.TabIndex = 13;
            this.mbtClose.Text = "종료";
            this.mbtClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mbtClose.UseCustomForeColor = true;
            this.mbtClose.UseSelectable = true;
            this.mbtClose.Click += new System.EventHandler(this.mbtClose_Click);
            // 
            // txtSysMsg
            // 
            this.txtSysMsg.Enabled = false;
            this.txtSysMsg.Location = new System.Drawing.Point(11, 384);
            this.txtSysMsg.Multiline = true;
            this.txtSysMsg.Name = "txtSysMsg";
            this.txtSysMsg.Size = new System.Drawing.Size(350, 64);
            this.txtSysMsg.TabIndex = 15;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultTextBox.Location = new System.Drawing.Point(12, 534);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(346, 26);
            this.ResultTextBox.TabIndex = 10;
            this.ResultTextBox.Text = "변환 준비중....";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(96, 358);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(265, 25);
            this.txtNameSpace.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "namespace";
            // 
            // lbxExcelList
            // 
            this.lbxExcelList.FormattingEnabled = true;
            this.lbxExcelList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lbxExcelList.ItemHeight = 17;
            this.lbxExcelList.Location = new System.Drawing.Point(12, 59);
            this.lbxExcelList.Name = "lbxExcelList";
            this.lbxExcelList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxExcelList.Size = new System.Drawing.Size(346, 293);
            this.lbxExcelList.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.txtSysMsg);
            this.Controls.Add(this.lbxExcelList);
            this.Controls.Add(this.mbtClose);
            this.Controls.Add(this.mbtDirectoryOpen);
            this.Controls.Add(this.mbtConvert);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.MyText);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8, 78, 8, 10);
            this.Text = "ExcelToJsonConverter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MyText;
        private MetroFramework.Controls.MetroButton mbtConvert;
        private MetroFramework.Controls.MetroButton mbtDirectoryOpen;
        private MetroFramework.Controls.MetroButton mbtClose;
        private System.Windows.Forms.TextBox txtSysMsg;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxExcelList;
    }
}

