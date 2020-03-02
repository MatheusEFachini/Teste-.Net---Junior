using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoDaVelha
{
    public partial class Form1 : Form
    {

        bool turno = true;
        int turnoCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void criadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickBtn(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if ((turnoCount < 9) && btn.Enabled == true)
            {
                if (turno && btn.Text == "")
                {
                    btn.Text = "X";
                }
                else if (btn.Text == "")
                {
                    btn.Text = "O";
                }
                turno = !turno;
                turnoCount = turnoCount + 1;
                checarVencedor();
            }
            else
            {
                MessageBox.Show("Empate");
            }

            void checarVencedor()
            {
                bool vencedor = false;

                //HORIZONTAL
                if ((btn11.Text == btn12.Text) && (btn12.Text == btn13.Text) && (btn11.Text != ""))
                {
                    btn11.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn12.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn13.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    vencedor = true;
                }
                if ((btn21.Text == btn22.Text) && (btn22.Text == btn23.Text) && (btn21.Text != ""))
                {
                    btn21.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn22.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn32.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    vencedor = true;
                }
                if ((btn31.Text == btn32.Text) && (btn32.Text == btn33.Text) && (btn31.Text != ""))
                {
                    btn31.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn32.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn33.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    vencedor = true;
                }

                //VERTICAL
                if ((btn11.Text == btn21.Text) && (btn21.Text == btn31.Text) && (btn11.Text != ""))
                {
                    btn11.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn21.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn31.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    vencedor = true;
                }
                if ((btn12.Text == btn22.Text) && (btn22.Text == btn32.Text) && (btn12.Text != ""))
                {
                    btn12.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn22.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn32.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    vencedor = true;
                }
                if ((btn13.Text == btn23.Text) && (btn23.Text == btn33.Text) && (btn13.Text != ""))
                {
                    btn13.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn23.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn33.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    vencedor = true;
                }

                //DIAGONAL
                if ((btn11.Text == btn22.Text) && (btn22.Text == btn33.Text) && (btn11.Text != ""))
                {
                    btn11.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn22.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn33.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    vencedor = true;
                }
                if ((btn13.Text == btn22.Text) && (btn22.Text == btn31.Text) && (btn13.Text != ""))
                {
                    btn13.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn22.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    btn31.BackgroundImage = jogoDaVelha.Properties.Resources.blue;
                    vencedor = true;
                }


                if (vencedor)
                {
                    string playerVencedor;
                    desligaJogo();

                    if (turno)
                        playerVencedor = "jogador O";
                    else
                        playerVencedor = "jogador X";


                    MessageBox.Show($"{playerVencedor} venceu!!!");
                }
            }

            void desligaJogo()
            {
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
                btn23.Enabled = false;
                btn31.Enabled = false;
                btn32.Enabled = false;
                btn33.Enabled = false;
            }
        }


        // TENTE USAR FOREACH MAS ELE CONTAVA AS LABELS E DAVA ERRO POR QUE NÃO POSSO CONVERTER LABEL EM BUTTON
        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turno = true;
            turnoCount = 0;

            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;

            btn11.BackgroundImage = jogoDaVelha.Properties.Resources._default;
            btn12.BackgroundImage = jogoDaVelha.Properties.Resources._default;
            btn13.BackgroundImage = jogoDaVelha.Properties.Resources._default;
            btn21.BackgroundImage = jogoDaVelha.Properties.Resources._default;
            btn22.BackgroundImage = jogoDaVelha.Properties.Resources._default;
            btn23.BackgroundImage = jogoDaVelha.Properties.Resources._default;
            btn31.BackgroundImage = jogoDaVelha.Properties.Resources._default;
            btn32.BackgroundImage = jogoDaVelha.Properties.Resources._default;
            btn33.BackgroundImage = jogoDaVelha.Properties.Resources._default;

            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";


        }
    }
}
