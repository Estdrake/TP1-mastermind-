using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        int m_nbessai;
        string[] m_ordre;
        int[] m_nombre;
        string[] m_resultat;
        string[] m_choix;
        public Form1()
        {


            InitializeComponent();

            // rendre les picturebox ronde
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb1.Width - 3, pb1.Height - 3);
            Region rg = new Region(gp);
            pb1.Region = rg;
            pb2.Region = rg;
            pb3.Region = rg;
            pb4.Region = rg;
            pb5.Region = rg;
            pbVert.Region = rg;
            pbBleu.Region = rg;
            pbOrange.Region = rg;
            pbRose.Region = rg;


            m_choix = new string[5];
            
            m_ordre = new string[] { "DeepSkyBlue", "DarkOrange", "YellowGreen", "DeepPink" };
            couleur();

        }

        private void couleur()
        {
            
            m_nombre = new int[5];
            Random chifre = new Random();

            for (int i = 0; i < 5; i++)
            {
                m_nombre[i] = chifre.Next(4);
            }
            m_resultat = new string[5];
            for (int i = 0; i < 5; i++)
            {

                m_resultat[i] = m_ordre[m_nombre[i]] ;
            }


            return;
        }

        private void btnRecomencer_Click(object sender, EventArgs e)
        {

            couleur();
            txtSoluce.Text = "";
            m_nbessai = 0;
            txtNbessai.Text = m_nbessai.ToString();
            txtBonne.Text = "";
            txtMauvai.Text = "";
            pb1.BackColor = Color.White;
            pb2.BackColor = Color.White;
            pb3.BackColor = Color.White;
            pb4.BackColor = Color.White;
            pb5.BackColor = Color.White;
        }

        private void btnVérifier_Click(object sender, EventArgs e)
        {
            int bonne=0;
            int mauvai=0;
            int i1 = 0;
            int i2 = 0;
            m_nbessai = m_nbessai + 1;
            txtNbessai.Text = m_nbessai.ToString();

            for (int i = 0; i < 5; i++)
            {
                if(m_choix[i]==m_resultat[i])
                {
                    bonne++;
                }
                
            }
            for (int i = 0; i < 5; i++)
            {
                if (m_choix[i] != m_resultat[i] && m_resultat.Contains(m_choix[i]))
                {
                    mauvai++;
                }

            }

           
            txtMauvai.Text = mauvai.ToString();
            txtBonne.Text = bonne.ToString();
            if(bonne==5)
            {
                DialogResult reponce = MessageBox.Show("bravo champion !!!!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (reponce == DialogResult.Retry)
                {
                    btnRecomencer.PerformClick();
                }
                if (reponce == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            
        }
        private void btnAficher_Click(object sender, EventArgs e)
        {
            string soluce="";   
            for (int i = 0; i < 5; i++)
            {
                soluce = soluce+m_resultat[i]+", ";

            }
            txtSoluce.Text = soluce;
        }

        // drag and drop

        //couleur 1
        private void CouleurMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb.Tag.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        //couleur2
        private void ChoixDragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string couleur = e.Data.GetData(DataFormats.Text).ToString();
           
            pb.BackColor = Color.FromName(couleur);

            if (pb == pb1)
            {
                m_choix[0] = couleur;
            }
            if (pb == pb2)
            {
                m_choix[1] = couleur;
            }
            if (pb == pb3)
            {
                m_choix[2] = couleur;
            }
            if (pb == pb4)
            {
                m_choix[3] = couleur;
            }
            if (pb == pb5)
            {
                m_choix[4] = couleur;
            }





        }


        private void ChoixDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
