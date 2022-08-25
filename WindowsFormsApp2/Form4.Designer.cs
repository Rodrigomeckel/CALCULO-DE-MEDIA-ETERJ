namespace WindowsFormsApp2
{
    partial class Form4
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
            this.lbl_disciplina = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nota_final = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nome1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_disciplina
            // 
            this.lbl_disciplina.AutoSize = true;
            this.lbl_disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disciplina.Location = new System.Drawing.Point(182, 98);
            this.lbl_disciplina.Name = "lbl_disciplina";
            this.lbl_disciplina.Size = new System.Drawing.Size(77, 24);
            this.lbl_disciplina.TabIndex = 67;
            this.lbl_disciplina.Text = "label14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 38);
            this.label5.TabIndex = 66;
            this.label5.Text = "DISCIPLINA :";
            // 
            // lbl_nota_final
            // 
            this.lbl_nota_final.AutoSize = true;
            this.lbl_nota_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota_final.Location = new System.Drawing.Point(182, 157);
            this.lbl_nota_final.Name = "lbl_nota_final";
            this.lbl_nota_final.Size = new System.Drawing.Size(77, 24);
            this.lbl_nota_final.TabIndex = 65;
            this.lbl_nota_final.Text = "label14";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
            this.label2.TabIndex = 64;
            this.label2.Text = "NOTA FINAL :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 63;
            this.label1.Text = "REPROVADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 51);
            this.label3.TabIndex = 62;
            this.label3.Text = "SITUAÇÃO :";
            // 
            // lbl_nome1
            // 
            this.lbl_nome1.AutoSize = true;
            this.lbl_nome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome1.Location = new System.Drawing.Point(182, 42);
            this.lbl_nome1.Name = "lbl_nome1";
            this.lbl_nome1.Size = new System.Drawing.Size(77, 24);
            this.lbl_nome1.TabIndex = 61;
            this.lbl_nome1.Text = "label14";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 38);
            this.label4.TabIndex = 60;
            this.label4.Text = "SEU NOME :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(414, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(453, 303);
            this.Controls.Add(this.lbl_disciplina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_nota_final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_nome1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_disciplina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_nota_final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nome1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}