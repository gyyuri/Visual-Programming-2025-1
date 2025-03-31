namespace _008_login
{
    partial class Form1
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblid.Location = new System.Drawing.Point(90, 98);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(98, 37);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "아이디";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtid.Location = new System.Drawing.Point(239, 87);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(263, 43);
            this.txtid.TabIndex = 1;
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtpw.Location = new System.Drawing.Point(239, 167);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '●';
            this.txtpw.Size = new System.Drawing.Size(263, 43);
            this.txtpw.TabIndex = 3;
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblpw.Location = new System.Drawing.Point(90, 178);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(125, 37);
            this.lblpw.TabIndex = 2;
            this.lblpw.Text = "패스워드";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("맑은 고딕", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtResult.Location = new System.Drawing.Point(239, 314);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(263, 43);
            this.txtResult.TabIndex = 4;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(292, 244);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(210, 46);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "로그인";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnlogin;
    }
}

