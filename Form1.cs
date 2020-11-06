using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nani
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Numeri Binari";

            //butto
            btnCancella.Text = "Cancella";
            btnConverti.Text = "Converti";
            btnVisualizza.Text = "Visualizza";
            btnInput.Text = "Input";


            btnVisualizza.Enabled = false;
            btnConverti.Enabled = false;

            //groupbox
            grpVisualizza.Text = "Valori binari";
            grpSelezioneV.Text = "Visualizzazione selettiva";
            grpConversione.Text = "Selezione per conversione";
            grpInput.Text = "Input";

            //Check box
            chkValore1.Text = "Valore 1";               //inzializzazione testo check box
            chkValore2.Text = "Valore 2";
            chkValore3.Text = "Valore 3";
            chkValore4.Text = "Valore 4";

            chkValore1.Checked = false;                 //inizializzazioni checkbox non selezionate
            chkValore2.Checked = false;
            chkValore3.Checked = false;
            chkValore4.Checked = false;

            //radio button
            rdbValore1.Text = "Valore 1";                //inzializzazione testo check box
            rdbValore2.Text = "Valore 2";
            rdbValore3.Text = "Valore 3";
            rdbValore4.Text = "Valore 4";

            rdbInput1.Text = "Valore 1";
            rdbInput2.Text = "Valore 2";
            rdbInput3.Text = "Valore 3";
            rdbInput4.Text = "Valore 4";



            rdbValore1.Checked = false;                  //inzializzazione  radio button non selezionati
            rdbValore2.Checked = false;
            rdbValore3.Checked = false;
            rdbValore4.Checked = false;

            rdbInput1.Checked = false;
            rdbInput2.Checked = false;
            rdbInput3.Checked = false;
            rdbInput4.Checked = false;

            rdbInput1.CheckedChanged += RdbInput_CheckedChanged;
            rdbInput2.CheckedChanged += RdbInput_CheckedChanged;
            rdbInput3.CheckedChanged += RdbInput_CheckedChanged;
            rdbInput4.CheckedChanged += RdbInput_CheckedChanged;

            //visualizzazione valori iniziali
            int[,] mat = Globals.val;

            for (int i = 0; i <= mat.GetUpperBound(0); i++)
            {
                txtVisualizza.Text += "N" + Convert.ToString(i + 1) + " ";           //stampa indice numer es N1
                for (int j = 0; j <= mat.GetUpperBound(1); j++)
                    txtVisualizza.Text = txtVisualizza.Text + Convert.ToString(mat[i, j]);      //stampa ogni numero
                txtVisualizza.Text += "\r\n";
            }
        }

        private void RdbInput_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            //ripristino variabili e stati controllori

            chkValore1.Checked = false;
            chkValore2.Checked = false;
            chkValore3.Checked = false;
            chkValore4.Checked = false;

            rdbValore1.Checked = false;
            rdbValore2.Checked = false;
            rdbValore3.Checked = false;
            rdbValore4.Checked = false;

            txtVisualizza.Text = "";

            btnVisualizza.Enabled = false;
            btnConverti.Enabled = false;
        }

        private void chkValore1_CheckedChanged(object sender, EventArgs e)
        {
            btnVisualizza.Enabled = true;
            if (chkValore1.Checked)
            {
                Globals.visualizza[0] = 1;    //Salvataggio indice (Magic number? :( )
            }
            else
            {
                Globals.visualizza[0] = 0;
                if (Verifica(Globals.visualizza))             //se non rimangono check selezionate disabilito
                    btnVisualizza.Enabled = false;
            }
        }

        private void chkValore2_CheckedChanged(object sender, EventArgs e)
        {
            btnVisualizza.Enabled = true;
            if (chkValore2.Checked)
            {
                Globals.visualizza[1] = 1;
            }
            else
            {
                Globals.visualizza[1] = 0;
                if (Verifica(Globals.visualizza))             //se non rimangono check selezionate disabilito
                    btnVisualizza.Enabled = false;
            }

        }

        private void chkValore3_CheckedChanged(object sender, EventArgs e)
        {
            btnVisualizza.Enabled = true;
            if (chkValore3.Checked)
                Globals.visualizza[2] = 1;

            else
            {
                Globals.visualizza[2] = 0;
                if (Verifica(Globals.visualizza))
                    btnVisualizza.Enabled = false;
            }
        }

        private void chkValore4_CheckedChanged(object sender, EventArgs e)
        {
            btnVisualizza.Enabled = true;
            if (chkValore4.Checked)
            {
                Globals.visualizza[3] = 1;
            }
            else
            {
                Globals.visualizza[3] = 0;
                if (Verifica(Globals.visualizza))             //se non rimangono check selezionate disabilito
                    btnVisualizza.Enabled = false;
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            int[,] mat = Globals.val;
            txtVisualizza.Text = "";
            for (int i = 0; i <= mat.GetUpperBound(0); i++)
            {
                if (Globals.visualizza[i] == 1)                                   //per ogni check trovata selezionata
                {
                    txtVisualizza.Text += "N" + Convert.ToString(i + 1) + " ";   //stampo indice numero e numero
                    for (int j = 0; j <= mat.GetUpperBound(1); j++)
                    {
                        txtVisualizza.Text += mat[i, j];
                    }
                    txtVisualizza.Text += "\r\n";
                }
            }
        }

        private void rdbValore1_CheckedChanged(object sender, EventArgs e)
        {
            Globals.decimale = 0;          //ripristino valore conversione
            btnConverti.Enabled = true;
            if (rdbValore1.Checked)
            {
                Globals.conversione = 0;     //Salvataggio indice
            }
        }

        private void rdbValore2_CheckedChanged(object sender, EventArgs e)
        {
            Globals.decimale = 0;
            btnConverti.Enabled = true;
            if (rdbValore2.Checked)
            {
                Globals.conversione = 1;
            }
        }

        private void rdbValore3_CheckedChanged(object sender, EventArgs e)
        {
            Globals.decimale = 0;
            btnConverti.Enabled = true;
            if (rdbValore3.Checked)
            {
                Globals.conversione = 2;
            }
        }

        private void rdbValore4_CheckedChanged(object sender, EventArgs e)
        {
            Globals.decimale = 0;
            btnConverti.Enabled = true;
            if (rdbValore4.Checked)
            {
                Globals.conversione = 3;
            }
        }

        private void btnConverti_Click(object sender, EventArgs e)
        {
            int[,] mat = Globals.val;
            int aggiungi = 1;
            for (int j = 0; j <= mat.GetUpperBound(1); j++)
            {
                if (mat[Globals.conversione, j] == 1)
                {
                    switch (j)
                    {
                        case 0: Globals.decimale += 8; break;
                        case 1: Globals.decimale += 4; break;
                        case 2: Globals.decimale += 2; break;
                        case 3: Globals.decimale += 1; break;
                        default: break;
                    }
                }

            }

            txtVisualizza.Text = "N" + Convert.ToString(Globals.conversione + 1) + " ";
            for (int j = 0; j <= mat.GetUpperBound(1); j++)
            {
                txtVisualizza.Text += Convert.ToString(mat[Globals.conversione, j]);
            }
            txtVisualizza.Text += "= " + Convert.ToString(Globals.decimale);
        }

        private bool Verifica(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (Globals.visualizza[i] == 1)
                {
                    return false;
                }
            }
            return true;
        }


    }

}
