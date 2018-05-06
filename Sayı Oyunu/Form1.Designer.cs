namespace Sayı_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfRights = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfDigits = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDigits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOŞGELDİNİZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(172, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Oyuna Başla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numOfRights);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numOfDigits);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(29, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(9, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 37);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Tekrarsız";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hak Sayısı         :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numOfRights
            // 
            this.numOfRights.Location = new System.Drawing.Point(172, 68);
            this.numOfRights.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfRights.Name = "numOfRights";
            this.numOfRights.Size = new System.Drawing.Size(76, 20);
            this.numOfRights.TabIndex = 6;
            this.numOfRights.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Basamak Sayısı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numOfDigits
            // 
            this.numOfDigits.Location = new System.Drawing.Point(172, 23);
            this.numOfDigits.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOfDigits.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numOfDigits.Name = "numOfDigits";
            this.numOfDigits.Size = new System.Drawing.Size(76, 20);
            this.numOfDigits.TabIndex = 4;
            this.numOfDigits.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(363, 280);
            this.MinimumSize = new System.Drawing.Size(363, 280);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Giriş Ekranı";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOfRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDigits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numOfRights;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOfDigits;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

