using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        //======== aredondar borda
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse

    );

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        Point DragCursor;
        Point DragForm;
        bool Dragging;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CALCULAR_Click(object sender, EventArgs e)
        {
            double NTI1, NTI2, NPC, FEIRA, PROVÃO ,total;
            
          

            if (txb_ALUNO.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO ALUNO", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_ALUNO.Clear();
                txb_ALUNO.Focus();
            }

            else if (txb_DISCIPLINA.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO DISCIPLINA", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_DISCIPLINA.Clear();
                txb_DISCIPLINA.Focus();
            }

            else if (txb_NTI1.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO NTI 1", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_NTI1.Clear();
                txb_NTI1.Focus();
            }

            else if (txb_NTI2.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO NTI 2", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_NTI2.Clear();
                txb_NTI2.Focus();
            }

            else if (txb_npc.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO NPC", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_npc.Clear();
                txb_npc.Focus();
            }

            else if (txb_feira.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO FEIRA", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_feira.Clear();
                txb_feira.Focus();
            }

            else if (txb_provao.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO PROVÃO", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_provao.Clear();
                txb_provao.Focus();
            }

            else if (double.TryParse(txb_NTI1.Text, out NTI1) == false || NTI1 < 0 || NTI1 > 10)
            {
                MessageBox.Show("SÓ PODEM SER DIGITADOS VALORES MENORES QUE 10", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_NTI1.Clear();
                txb_NTI1.Focus();
            }

            else if (double.TryParse(txb_NTI2.Text, out NTI2) == false || NTI2 < 0 || NTI2 > 10)
            {
                MessageBox.Show("SÓ PODEM SER DIGITADOS VALORES MENORES QUE 10", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_NTI1.Clear();
                txb_NTI2.Focus();
            }

            else if (double.TryParse(txb_npc.Text, out NPC) == false || NPC < 0 || NPC > 10)
            {
                MessageBox.Show("SÓ PODEM SER DIGITADOS VALORES MENORES QUE 10", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_npc.Clear();
                txb_npc.Focus();
            }

            else if (double.TryParse(txb_feira.Text, out FEIRA) == false || FEIRA < 0 || FEIRA > 10)
            {
                MessageBox.Show("SÓ PODEM SER DIGITADOS VALORES MENORES QUE 10", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_feira.Clear();
                txb_feira.Focus();
            }

            else if (double.TryParse(txb_provao.Text, out PROVÃO) == false || PROVÃO < 0 || PROVÃO > 10)
            {
                MessageBox.Show("SÓ PODEM SER DIGITADOS VALORES MENORES QUE 10", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_provao.Clear();
                txb_provao.Focus();
            }

            else if (double.TryParse(txb_NTI1.Text, out NTI1) == false)
            {
                MessageBox.Show("N1 INVÁLIDO", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_ALUNO.Focus();
            }

            else if (double.TryParse(txb_NTI2.Text, out NTI2) == false)
            {
                MessageBox.Show("N2 INVÁLIDO", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_ALUNO.Focus();
            }

            else if (double.TryParse(txb_npc.Text, out NPC) == false)
            {
                MessageBox.Show("NPC INVÁLIDO", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_ALUNO.Focus();
            }

            else if (double.TryParse(txb_feira.Text, out FEIRA) == false)
            {
                MessageBox.Show("FEIRA INVÁLIDO", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_ALUNO.Focus();
            }

            else if (double.TryParse(txb_provao.Text, out PROVÃO) == false)
            {
                MessageBox.Show("PROVÃO INVÁLIDO", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_ALUNO.Focus();
            }
            

            else{

                total = (((NTI1 + NTI2) / 2) + NPC + FEIRA + PROVÃO) / 4;
                

                if (total >= 7)
                {
                    VariavelGlobal.nome = txb_ALUNO.Text;
                    VariavelGlobal.disciplina = txb_DISCIPLINA.Text;
                    VariavelGlobal.nota_final = total.ToString(); ;

                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                }

                else if (total >= 4.5)
                {
                    VariavelGlobal.nome = txb_ALUNO.Text;
                    VariavelGlobal.disciplina = txb_DISCIPLINA.Text;
                    VariavelGlobal.nota_final = total.ToString();

                    Form3 frm3 = new Form3();
                    frm3.ShowDialog();
                }

                else 
                {
                    VariavelGlobal.nome = txb_ALUNO.Text;
                    VariavelGlobal.disciplina = txb_DISCIPLINA.Text;
                    VariavelGlobal.nota_final = total.ToString(); 

                    Form4 frm4 = new Form4();
                    frm4.ShowDialog();
                }

                txb_NTI1.Clear();
                txb_NTI2.Clear();
                txb_npc.Clear();
                txb_feira.Clear();
                txb_provao.Clear();
            }

            

         
        }

        private void txb_numero1_Enter(object sender, EventArgs e)
        {
            txb_NTI1.BackColor = Color.Blue;
            txb_NTI1.ForeColor = Color.White;

            
        }

        private void txb_numero1_Leave(object sender, EventArgs e)
        {
            txb_NTI1.BackColor = Color.White;
            txb_NTI1.ForeColor = Color.Black;
        }

        private void txb_numero2_Enter(object sender, EventArgs e)
        {
            txb_NTI2.BackColor = Color.Blue;
            txb_NTI2.ForeColor = Color.White;
        }

        private void txb_numero2_Leave(object sender, EventArgs e)
        {
            txb_NTI2.BackColor = Color.White;
            txb_NTI2.ForeColor = Color.Black;
        }

        private void txb_cliente_Click(object sender, EventArgs e)
        {
            txb_ALUNO.Clear();
        }

        private void txb_numero1_Click(object sender, EventArgs e)
        {
            txb_NTI1.Clear();
        }

        private void txb_numero2_Click(object sender, EventArgs e)
        {
            txb_NTI2.Clear();
        }

        private void txb_cliente_Enter(object sender, EventArgs e)
        {
            txb_ALUNO.BackColor = Color.Blue;
            txb_ALUNO.ForeColor = Color.White;
        }


        private void txb_ALUNO_Leave(object sender, EventArgs e)
        {
            txb_ALUNO.BackColor = Color.White;
            txb_ALUNO.ForeColor = Color.Black;
        }

        private void txb_DISCIPLINA_Enter(object sender, EventArgs e)
        {
            txb_DISCIPLINA.BackColor = Color.Blue;
            txb_DISCIPLINA.ForeColor = Color.White;
        }

        private void txb_DISCIPLINA_Leave(object sender, EventArgs e)
        {
            txb_DISCIPLINA.BackColor = Color.White;
            txb_DISCIPLINA.ForeColor = Color.Black;
        }

        private void txb_npc_Enter(object sender, EventArgs e)
        {
            txb_npc.BackColor = Color.Blue;
            txb_npc.ForeColor = Color.White;
        }

        private void txb_npc_Leave(object sender, EventArgs e)
        {
            txb_npc.BackColor = Color.White;
            txb_npc.ForeColor = Color.Black;
        }

        private void txb_feira_Enter(object sender, EventArgs e)
        {
            txb_feira.BackColor = Color.Blue;
            txb_feira.ForeColor = Color.White;
        }

        private void txb_feira_Leave(object sender, EventArgs e)
        {
            txb_feira.BackColor = Color.White;
            txb_feira.ForeColor = Color.Black;
        }

        private void txb_provao_Enter(object sender, EventArgs e)
        {
            txb_provao.BackColor = Color.Blue;
            txb_provao.ForeColor = Color.White;
        }

       

        private void txb_provao_Leave(object sender, EventArgs e)
        {
            txb_provao.BackColor = Color.White;
            txb_provao.ForeColor = Color.Black;
        }

        private void txb_DISCIPLINA_Click(object sender, EventArgs e)
        {
            txb_DISCIPLINA.Clear();
        }

        private void txb_npc_Click(object sender, EventArgs e)
        {
            txb_npc.Clear();
        }

        private void txb_feira_Click(object sender, EventArgs e)
        {
            txb_feira.Clear();
        }

        private void txb_provao_Click(object sender, EventArgs e)
        {
            txb_provao.Clear();
        }
    }
}
