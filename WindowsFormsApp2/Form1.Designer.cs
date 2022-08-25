namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_ALUNO = new System.Windows.Forms.TextBox();
            this.txb_NTI1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_NTI2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.lbl_calculo = new System.Windows.Forms.Label();
            this.txb_DISCIPLINA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_npc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_feira = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_provao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(741, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 38);
            this.label9.TabIndex = 15;
            this.label9.Text = "NOME DO ALUNO :";
            // 
            // txb_ALUNO
            // 
            this.txb_ALUNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ALUNO.Location = new System.Drawing.Point(64, 87);
            this.txb_ALUNO.Name = "txb_ALUNO";
            this.txb_ALUNO.Size = new System.Drawing.Size(283, 29);
            this.txb_ALUNO.TabIndex = 16;
            this.txb_ALUNO.Click += new System.EventHandler(this.txb_cliente_Click);
            this.txb_ALUNO.Enter += new System.EventHandler(this.txb_cliente_Enter);
            this.txb_ALUNO.Leave += new System.EventHandler(this.txb_ALUNO_Leave);
            // 
            // txb_NTI1
            // 
            this.txb_NTI1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NTI1.Location = new System.Drawing.Point(74, 206);
            this.txb_NTI1.Name = "txb_NTI1";
            this.txb_NTI1.Size = new System.Drawing.Size(154, 29);
            this.txb_NTI1.TabIndex = 18;
            this.txb_NTI1.Click += new System.EventHandler(this.txb_numero1_Click);
            this.txb_NTI1.Enter += new System.EventHandler(this.txb_numero1_Enter);
            this.txb_NTI1.Leave += new System.EventHandler(this.txb_numero1_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 38);
            this.label11.TabIndex = 19;
            this.label11.Text = "NTI 2 :";
            // 
            // txb_NTI2
            // 
            this.txb_NTI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NTI2.Location = new System.Drawing.Point(75, 301);
            this.txb_NTI2.Name = "txb_NTI2";
            this.txb_NTI2.Size = new System.Drawing.Size(154, 29);
            this.txb_NTI2.TabIndex = 20;
            this.txb_NTI2.Click += new System.EventHandler(this.txb_numero2_Click);
            this.txb_NTI2.Enter += new System.EventHandler(this.txb_numero2_Enter);
            this.txb_NTI2.Leave += new System.EventHandler(this.txb_numero2_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(67, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 38);
            this.label13.TabIndex = 23;
            this.label13.Text = "NTI 1 :";
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(604, 430);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(162, 48);
            this.btn_multiplicar.TabIndex = 25;
            this.btn_multiplicar.Text = "CALCULAR";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.BTN_CALCULAR_Click);
            // 
            // lbl_calculo
            // 
            this.lbl_calculo.AutoSize = true;
            this.lbl_calculo.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculo.Location = new System.Drawing.Point(587, 287);
            this.lbl_calculo.Name = "lbl_calculo";
            this.lbl_calculo.Size = new System.Drawing.Size(0, 38);
            this.lbl_calculo.TabIndex = 26;
            // 
            // txb_DISCIPLINA
            // 
            this.txb_DISCIPLINA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DISCIPLINA.Location = new System.Drawing.Point(405, 87);
            this.txb_DISCIPLINA.Name = "txb_DISCIPLINA";
            this.txb_DISCIPLINA.Size = new System.Drawing.Size(283, 29);
            this.txb_DISCIPLINA.TabIndex = 28;
            this.txb_DISCIPLINA.Click += new System.EventHandler(this.txb_DISCIPLINA_Click);
            this.txb_DISCIPLINA.Enter += new System.EventHandler(this.txb_DISCIPLINA_Enter);
            this.txb_DISCIPLINA.Leave += new System.EventHandler(this.txb_DISCIPLINA_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 38);
            this.label2.TabIndex = 27;
            this.label2.Text = "DISCIPLINA :";
            // 
            // txb_npc
            // 
            this.txb_npc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_npc.Location = new System.Drawing.Point(334, 206);
            this.txb_npc.Name = "txb_npc";
            this.txb_npc.Size = new System.Drawing.Size(154, 29);
            this.txb_npc.TabIndex = 30;
            this.txb_npc.Click += new System.EventHandler(this.txb_npc_Click);
            this.txb_npc.Enter += new System.EventHandler(this.txb_npc_Enter);
            this.txb_npc.Leave += new System.EventHandler(this.txb_npc_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 38);
            this.label3.TabIndex = 29;
            this.label3.Text = "NPC :";
            // 
            // txb_feira
            // 
            this.txb_feira.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_feira.Location = new System.Drawing.Point(334, 301);
            this.txb_feira.Name = "txb_feira";
            this.txb_feira.Size = new System.Drawing.Size(154, 29);
            this.txb_feira.TabIndex = 32;
            this.txb_feira.Click += new System.EventHandler(this.txb_feira_Click);
            this.txb_feira.Enter += new System.EventHandler(this.txb_feira_Enter);
            this.txb_feira.Leave += new System.EventHandler(this.txb_feira_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 38);
            this.label4.TabIndex = 31;
            this.label4.Text = "FEIRA :";
            // 
            // txb_provao
            // 
            this.txb_provao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_provao.Location = new System.Drawing.Point(568, 238);
            this.txb_provao.Name = "txb_provao";
            this.txb_provao.Size = new System.Drawing.Size(154, 29);
            this.txb_provao.TabIndex = 34;
            this.txb_provao.Click += new System.EventHandler(this.txb_provao_Click);
            this.txb_provao.Enter += new System.EventHandler(this.txb_provao_Enter);
            this.txb_provao.Leave += new System.EventHandler(this.txb_provao_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 38);
            this.label5.TabIndex = 33;
            this.label5.Text = "PROVÃO :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(778, 490);
            this.Controls.Add(this.txb_provao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_feira);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_npc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_DISCIPLINA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_calculo);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_NTI2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txb_NTI1);
            this.Controls.Add(this.txb_ALUNO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_ALUNO;
        private System.Windows.Forms.TextBox txb_NTI1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_NTI2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Label lbl_calculo;
        private System.Windows.Forms.TextBox txb_DISCIPLINA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_npc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_feira;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_provao;
        private System.Windows.Forms.Label label5;
    }
}

