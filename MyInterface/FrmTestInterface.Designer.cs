namespace MyInterface
{
    partial class FrmTestInterface
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
            this.button1 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "sqlconnection - IDBConnection , IDBCommand";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(57, 24);
            this.Button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(242, 23);
            this.Button7.TabIndex = 28;
            this.Button7.Text = "Interface (定規格標準)  vs.  Abstract Class";
            this.Button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 22);
            this.button2.TabIndex = 29;
            this.button2.Text = "test Interface";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 133);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "介面架構多型   Interface Poly";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 161);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 22);
            this.button3.TabIndex = 34;
            this.button3.Text = "介面架構多型   Interface Poly";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(57, 213);
            this.Button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(227, 23);
            this.Button6.TabIndex = 35;
            this.Button6.Text = "程式碼繼承　vs.  介面繼承";
            this.Button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 272);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 18);
            this.button5.TabIndex = 36;
            this.button5.Text = "多重介面實做 IDisposable";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FrmTestInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 322);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTestInterface";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button button5;
    }
}

