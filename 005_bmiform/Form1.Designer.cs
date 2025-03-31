namespace _005_bmiform
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
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.lblW = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(332, 235);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(154, 45);
            this.btnBMI.TabIndex = 11;
            this.btnBMI.Text = "BMI 계산";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.BackColor = System.Drawing.SystemColors.Info;
            this.lblBMI.Location = new System.Drawing.Point(146, 320);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 24);
            this.lblBMI.TabIndex = 10;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(278, 165);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(209, 35);
            this.txtW.TabIndex = 9;
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(146, 176);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(97, 24);
            this.lblW.TabIndex = 8;
            this.lblW.Text = "체중(kg)";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(278, 89);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(209, 35);
            this.txtH.TabIndex = 7;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(146, 100);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(81, 24);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "키(cm)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblH);
            this.Name = "Form1";
            this.Text = "BMI 계산기 연습 by김규리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblH;
    }
}

