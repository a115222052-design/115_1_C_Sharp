namespace tutorial2_3
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.germanbutton = new System.Windows.Forms.Button();
            this.spanishbutton = new System.Windows.Forms.Button();
            this.italianbutton = new System.Windows.Forms.Button();
            this.translateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(144, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "選擇語言,我告訴你怎麼說\'\'早安\'\'";
            // 
            // germanbutton
            // 
            this.germanbutton.Location = new System.Drawing.Point(465, 296);
            this.germanbutton.Name = "germanbutton";
            this.germanbutton.Size = new System.Drawing.Size(220, 55);
            this.germanbutton.TabIndex = 2;
            this.germanbutton.Text = "德國";
            this.germanbutton.UseVisualStyleBackColor = true;
            this.germanbutton.Click += new System.EventHandler(this.德國button_Click);
            // 
            // spanishbutton
            // 
            this.spanishbutton.Location = new System.Drawing.Point(244, 296);
            this.spanishbutton.Name = "spanishbutton";
            this.spanishbutton.Size = new System.Drawing.Size(215, 55);
            this.spanishbutton.TabIndex = 3;
            this.spanishbutton.Text = "西班牙";
            this.spanishbutton.UseVisualStyleBackColor = true;
            this.spanishbutton.Click += new System.EventHandler(this.西班牙button_Click);
            // 
            // italianbutton
            // 
            this.italianbutton.Location = new System.Drawing.Point(26, 296);
            this.italianbutton.Name = "italianbutton";
            this.italianbutton.Size = new System.Drawing.Size(212, 55);
            this.italianbutton.TabIndex = 4;
            this.italianbutton.Text = "義大利";
            this.italianbutton.UseVisualStyleBackColor = true;
            this.italianbutton.Click += new System.EventHandler(this.italianbutton_Click);
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateLabel.Location = new System.Drawing.Point(254, 155);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(205, 73);
            this.translateLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.italianbutton);
            this.Controls.Add(this.spanishbutton);
            this.Controls.Add(this.germanbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button germanbutton;
        private System.Windows.Forms.Button spanishbutton;
        private System.Windows.Forms.Button italianbutton;
        private System.Windows.Forms.Label translateLabel;
    }
}

