namespace Example02
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Num3 = new System.Windows.Forms.TextBox();
            this.Num4 = new System.Windows.Forms.TextBox();
            this.CalcuateTotalButton = new System.Windows.Forms.Button();
            this.numberLabel1 = new System.Windows.Forms.Label();
            this.numberLabel2 = new System.Windows.Forms.Label();
            this.numberLabel3 = new System.Windows.Forms.Label();
            this.numberLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(78, 24);
            this.Num1.Multiline = true;
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(160, 28);
            this.Num1.TabIndex = 0;
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(78, 62);
            this.Num2.Multiline = true;
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(160, 28);
            this.Num2.TabIndex = 1;
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(78, 100);
            this.Num3.Multiline = true;
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(160, 28);
            this.Num3.TabIndex = 2;
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(78, 138);
            this.Num4.Multiline = true;
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(160, 28);
            this.Num4.TabIndex = 3;
            // 
            // CalcuateTotalButton
            // 
            this.CalcuateTotalButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CalcuateTotalButton.Location = new System.Drawing.Point(90, 188);
            this.CalcuateTotalButton.Name = "CalcuateTotalButton";
            this.CalcuateTotalButton.Size = new System.Drawing.Size(131, 51);
            this.CalcuateTotalButton.TabIndex = 4;
            this.CalcuateTotalButton.Text = "加總";
            this.CalcuateTotalButton.UseVisualStyleBackColor = true;
            this.CalcuateTotalButton.Click += new System.EventHandler(this.CalcuateTotalButton_Click);
            // 
            // numberLabel1
            // 
            this.numberLabel1.AutoSize = true;
            this.numberLabel1.Location = new System.Drawing.Point(20, 30);
            this.numberLabel1.Name = "numberLabel1";
            this.numberLabel1.Size = new System.Drawing.Size(52, 12);
            this.numberLabel1.TabIndex = 5;
            this.numberLabel1.Text = "Number 1";
            // 
            // numberLabel2
            // 
            this.numberLabel2.AutoSize = true;
            this.numberLabel2.Location = new System.Drawing.Point(20, 68);
            this.numberLabel2.Name = "numberLabel2";
            this.numberLabel2.Size = new System.Drawing.Size(52, 12);
            this.numberLabel2.TabIndex = 6;
            this.numberLabel2.Text = "Number 2";
            // 
            // numberLabel3
            // 
            this.numberLabel3.AutoSize = true;
            this.numberLabel3.Location = new System.Drawing.Point(20, 106);
            this.numberLabel3.Name = "numberLabel3";
            this.numberLabel3.Size = new System.Drawing.Size(52, 12);
            this.numberLabel3.TabIndex = 7;
            this.numberLabel3.Text = "Number 3";
            // 
            // numberLabel4
            // 
            this.numberLabel4.AutoSize = true;
            this.numberLabel4.Location = new System.Drawing.Point(20, 144);
            this.numberLabel4.Name = "numberLabel4";
            this.numberLabel4.Size = new System.Drawing.Size(52, 12);
            this.numberLabel4.TabIndex = 8;
            this.numberLabel4.Text = "Number 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.numberLabel4);
            this.Controls.Add(this.numberLabel3);
            this.Controls.Add(this.numberLabel2);
            this.Controls.Add(this.numberLabel1);
            this.Controls.Add(this.CalcuateTotalButton);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox Num3;
        private System.Windows.Forms.TextBox Num4;
        private System.Windows.Forms.Button CalcuateTotalButton;
        private System.Windows.Forms.Label numberLabel1;
        private System.Windows.Forms.Label numberLabel2;
        private System.Windows.Forms.Label numberLabel3;
        private System.Windows.Forms.Label numberLabel4;
    }
}

