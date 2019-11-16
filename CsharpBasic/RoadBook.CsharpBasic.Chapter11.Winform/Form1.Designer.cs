namespace RoadBook.CsharpBasic.Chapter11.Winform
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMenu01 = new System.Windows.Forms.Button();
            this.btnMenu02 = new System.Windows.Forms.Button();
            this.btnMenu03 = new System.Windows.Forms.Button();
            this.btnMenu04 = new System.Windows.Forms.Button();
            this.btnMenu05 = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문현황";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(17, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 316);
            this.listBox1.TabIndex = 1;
            // 
            // btnMenu01
            // 
            this.btnMenu01.Location = new System.Drawing.Point(225, 58);
            this.btnMenu01.Name = "btnMenu01";
            this.btnMenu01.Size = new System.Drawing.Size(116, 58);
            this.btnMenu01.TabIndex = 2;
            this.btnMenu01.Tag = "1";
            this.btnMenu01.Text = "김밥";
            this.btnMenu01.UseVisualStyleBackColor = true;
            this.btnMenu01.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu02
            // 
            this.btnMenu02.Location = new System.Drawing.Point(225, 122);
            this.btnMenu02.Name = "btnMenu02";
            this.btnMenu02.Size = new System.Drawing.Size(116, 58);
            this.btnMenu02.TabIndex = 3;
            this.btnMenu02.Tag = "2";
            this.btnMenu02.Text = "라면";
            this.btnMenu02.UseVisualStyleBackColor = true;
            this.btnMenu02.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu03
            // 
            this.btnMenu03.Location = new System.Drawing.Point(225, 186);
            this.btnMenu03.Name = "btnMenu03";
            this.btnMenu03.Size = new System.Drawing.Size(116, 58);
            this.btnMenu03.TabIndex = 4;
            this.btnMenu03.Tag = "3";
            this.btnMenu03.Text = "떡볶이";
            this.btnMenu03.UseVisualStyleBackColor = true;
            this.btnMenu03.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu04
            // 
            this.btnMenu04.Location = new System.Drawing.Point(225, 250);
            this.btnMenu04.Name = "btnMenu04";
            this.btnMenu04.Size = new System.Drawing.Size(116, 58);
            this.btnMenu04.TabIndex = 5;
            this.btnMenu04.Tag = "4";
            this.btnMenu04.Text = "순대";
            this.btnMenu04.UseVisualStyleBackColor = true;
            this.btnMenu04.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu05
            // 
            this.btnMenu05.Location = new System.Drawing.Point(225, 314);
            this.btnMenu05.Name = "btnMenu05";
            this.btnMenu05.Size = new System.Drawing.Size(116, 58);
            this.btnMenu05.TabIndex = 6;
            this.btnMenu05.Tag = "5";
            this.btnMenu05.Text = "공기밥";
            this.btnMenu05.UseVisualStyleBackColor = true;
            this.btnMenu05.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(405, 314);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(134, 60);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "결제하기";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Location = new System.Drawing.Point(556, 362);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(81, 12);
            this.lblPaymentInfo.TabIndex = 8;
            this.lblPaymentInfo.Text = "결제전입니다.";
            this.lblPaymentInfo.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.lblPaymentInfo);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnMenu05);
            this.Controls.Add(this.btnMenu04);
            this.Controls.Add(this.btnMenu03);
            this.Controls.Add(this.btnMenu02);
            this.Controls.Add(this.btnMenu01);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMenu01;
        private System.Windows.Forms.Button btnMenu02;
        private System.Windows.Forms.Button btnMenu03;
        private System.Windows.Forms.Button btnMenu04;
        private System.Windows.Forms.Button btnMenu05;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblPaymentInfo;
    }
}

