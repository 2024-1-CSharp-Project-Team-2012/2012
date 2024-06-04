namespace _2012
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
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(1, -2);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(130, 30);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Game Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(167, -2);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(130, 30);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "Game Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
    }
}

