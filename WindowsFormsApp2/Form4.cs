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
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void Form4_Load(object sender, EventArgs e)
        {
            lbl_nome1.Text = VariavelGlobal.nome.ToString();
            lbl_disciplina.Text = VariavelGlobal.disciplina.ToString();
            lbl_nota_final.Text = VariavelGlobal.nota_final.ToString();
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
