namespace random_kaldı_geçti__96
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNot = new System.Windows.Forms.Button();
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.lblKaldi = new System.Windows.Forms.Label();
            this.lblDuz = new System.Windows.Forms.Label();
            this.lblTesekkur = new System.Windows.Forms.Label();
            this.lblTaktir = new System.Windows.Forms.Label();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNot
            // 
            this.btnNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNot.Location = new System.Drawing.Point(25, 37);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(83, 49);
            this.btnNot.TabIndex = 0;
            this.btnNot.Text = "NOT";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // lbNotlar
            // 
            this.lbNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.ItemHeight = 25;
            this.lbNotlar.Location = new System.Drawing.Point(25, 108);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(175, 279);
            this.lbNotlar.TabIndex = 1;
            // 
            // lblKaldi
            // 
            this.lblKaldi.AutoSize = true;
            this.lblKaldi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaldi.Location = new System.Drawing.Point(206, 108);
            this.lblKaldi.Name = "lblKaldi";
            this.lblKaldi.Size = new System.Drawing.Size(43, 16);
            this.lblKaldi.TabIndex = 2;
            this.lblKaldi.Text = "Kaldı :";
            // 
            // lblDuz
            // 
            this.lblDuz.AutoSize = true;
            this.lblDuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuz.Location = new System.Drawing.Point(206, 202);
            this.lblDuz.Name = "lblDuz";
            this.lblDuz.Size = new System.Drawing.Size(36, 16);
            this.lblDuz.TabIndex = 3;
            this.lblDuz.Text = "Düz :";
            // 
            // lblTesekkur
            // 
            this.lblTesekkur.AutoSize = true;
            this.lblTesekkur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTesekkur.Location = new System.Drawing.Point(206, 271);
            this.lblTesekkur.Name = "lblTesekkur";
            this.lblTesekkur.Size = new System.Drawing.Size(70, 16);
            this.lblTesekkur.TabIndex = 4;
            this.lblTesekkur.Text = "Teşekkür :";
            // 
            // lblTaktir
            // 
            this.lblTaktir.AutoSize = true;
            this.lblTaktir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaktir.Location = new System.Drawing.Point(206, 355);
            this.lblTaktir.Name = "lblTaktir";
            this.lblTaktir.Size = new System.Drawing.Size(47, 16);
            this.lblTaktir.TabIndex = 5;
            this.lblTaktir.Text = "Taktir :";
            // 
            // btnKontrol
            // 
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.Location = new System.Drawing.Point(114, 37);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(86, 49);
            this.btnKontrol.TabIndex = 6;
            this.btnKontrol.Text = "KONTROL";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.lblTaktir);
            this.Controls.Add(this.lblTesekkur);
            this.Controls.Add(this.lblDuz);
            this.Controls.Add(this.lblKaldi);
            this.Controls.Add(this.lbNotlar);
            this.Controls.Add(this.btnNot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Label lblKaldi;
        private System.Windows.Forms.Label lblDuz;
        private System.Windows.Forms.Label lblTesekkur;
        private System.Windows.Forms.Label lblTaktir;
        private System.Windows.Forms.Button btnKontrol;
    }
}

