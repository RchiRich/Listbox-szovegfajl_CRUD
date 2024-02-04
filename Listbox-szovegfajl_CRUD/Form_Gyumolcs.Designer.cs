namespace Listbox_szovegfajl_CRUD
{
    partial class Form_Gyumolcs
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
            this.label_termekKod = new System.Windows.Forms.Label();
            this.textBox_termekKod = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.label_mennyiseg = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mennyiseg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_termekKod
            // 
            this.label_termekKod.AutoSize = true;
            this.label_termekKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_termekKod.Location = new System.Drawing.Point(41, 31);
            this.label_termekKod.Name = "label_termekKod";
            this.label_termekKod.Size = new System.Drawing.Size(143, 29);
            this.label_termekKod.TabIndex = 0;
            this.label_termekKod.Text = "Termék kód";
            // 
            // textBox_termekKod
            // 
            this.textBox_termekKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_termekKod.Location = new System.Drawing.Point(246, 38);
            this.textBox_termekKod.Name = "textBox_termekKod";
            this.textBox_termekKod.ReadOnly = true;
            this.textBox_termekKod.Size = new System.Drawing.Size(163, 34);
            this.textBox_termekKod.TabIndex = 1;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nev.Location = new System.Drawing.Point(44, 97);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(56, 29);
            this.label_nev.TabIndex = 2;
            this.label_nev.Text = "Név";
            // 
            // label_mennyiseg
            // 
            this.label_mennyiseg.AutoSize = true;
            this.label_mennyiseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_mennyiseg.Location = new System.Drawing.Point(44, 187);
            this.label_mennyiseg.Name = "label_mennyiseg";
            this.label_mennyiseg.Size = new System.Drawing.Size(130, 29);
            this.label_mennyiseg.TabIndex = 3;
            this.label_mennyiseg.Text = "Mennyiség";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nev.Location = new System.Drawing.Point(246, 104);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(163, 34);
            this.textBox_nev.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(68, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(432, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "kg";
            // 
            // textBox_mennyiseg
            // 
            this.textBox_mennyiseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_mennyiseg.Location = new System.Drawing.Point(246, 187);
            this.textBox_mennyiseg.Name = "textBox_mennyiseg";
            this.textBox_mennyiseg.Size = new System.Drawing.Size(163, 34);
            this.textBox_mennyiseg.TabIndex = 3;
            // 
            // Form_Gyumolcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_mennyiseg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label_mennyiseg);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.textBox_termekKod);
            this.Controls.Add(this.label_termekKod);
            this.Name = "Form_Gyumolcs";
            this.Text = "Form_Gyumolcs";
            this.Load += new System.EventHandler(this.Form_Gyumolcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_termekKod;
        private System.Windows.Forms.TextBox textBox_termekKod;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label_mennyiseg;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mennyiseg;
    }
}