namespace WindowsFormsApp2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nome1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_situação = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nota_final = new System.Windows.Forms.Label();
            this.lbl_disciplina = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEU NOME :";
            // 
            // lbl_nome1
            // 
            this.lbl_nome1.AutoSize = true;
            this.lbl_nome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome1.Location = new System.Drawing.Point(182, 21);
            this.lbl_nome1.Name = "lbl_nome1";
            this.lbl_nome1.Size = new System.Drawing.Size(77, 24);
            this.lbl_nome1.TabIndex = 28;
            this.lbl_nome1.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 51);
            this.label15.TabIndex = 39;
            this.label15.Text = "SITUAÇÃO :";
            // 
            // lbl_situação
            // 
            this.lbl_situação.AutoSize = true;
            this.lbl_situação.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situação.ForeColor = System.Drawing.Color.Lime;
            this.lbl_situação.Location = new System.Drawing.Point(204, 233);
            this.lbl_situação.Name = "lbl_situação";
            this.lbl_situação.Size = new System.Drawing.Size(176, 31);
            this.lbl_situação.TabIndex = 40;
            this.lbl_situação.Text = "APROVADO";
            this.lbl_situação.Click += new System.EventHandler(this.lbl_calculo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
            this.label2.TabIndex = 41;
            this.label2.Text = "NOTA FINAL :";
            // 
            // lbl_nota_final
            // 
            this.lbl_nota_final.AutoSize = true;
            this.lbl_nota_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota_final.Location = new System.Drawing.Point(182, 136);
            this.lbl_nota_final.Name = "lbl_nota_final";
            this.lbl_nota_final.Size = new System.Drawing.Size(77, 24);
            this.lbl_nota_final.TabIndex = 43;
            this.lbl_nota_final.Text = "label14";
            // 
            // lbl_disciplina
            // 
            this.lbl_disciplina.AutoSize = true;
            this.lbl_disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disciplina.Location = new System.Drawing.Point(182, 77);
            this.lbl_disciplina.Name = "lbl_disciplina";
            this.lbl_disciplina.Size = new System.Drawing.Size(77, 24);
            this.lbl_disciplina.TabIndex = 45;
            this.lbl_disciplina.Text = "label14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 38);
            this.label5.TabIndex = 44;
            this.label5.Text = "DISCIPLINA :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(473, 313);
            this.Controls.Add(this.lbl_disciplina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_nota_final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_situação);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl_nome1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nome1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_situação;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nota_final;
        private System.Windows.Forms.Label lbl_disciplina;
        private System.Windows.Forms.Label label5;
    }
}