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

            //button
            btnCancella.Text = "Cancella";
            btnConverti.Text = "Converti";
            btnVisualizza.Text = "Visualizza";
            btnInput.Text = "Input";


            btnVisualizza.Enabled = false;
            btnConverti.Enabled = false;
            btnInput.Enabled = false;

            //groupbox
            grpVisualizza.Text = "Valori binari";
            grpSelezioneV.Text = "Visualizzazione selettiva";
            grpConversione.Text = "Selezione per conversione";
            grpInput.Text = "Input";
            grpConversione.Enabled = false;
            grpSelezioneV.Enabled= false;

            //Check box
            chkValore1.Text = "Valore 1";               //inzializzazione testo check box
            chkValore2.Text = "Valore 2";
            chkValore3.Text = "Valore 3";
            chkValore4.Text = "Valore 4";

            chkValore1.Checked = false;                 //inizializzazioni checkbox non selezionate
            chkValore2.Checked = false;
            chkValore3.Checked = false;
            chkValore4.Checked = false;

            chkValore1.CheckedChanged += ChkValore_CheckedChanged;
            chkValore2.CheckedChanged += ChkValore_CheckedChanged;
            chkValore3.CheckedChanged += ChkValore_CheckedChanged;
            chkValore4.CheckedChanged += ChkValore_CheckedChanged;

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

            rdbValore1.CheckedChanged += RdbValore_CheckedChanged;
            rdbValore2.CheckedChanged += RdbValore_CheckedChanged;
            rdbValore3.CheckedChanged += RdbValore_CheckedChanged;
            rdbValore4.CheckedChanged += RdbValore_CheckedChanged;
        }
        private void RdbValore_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            btnConverti.Enabled = true;
            string valore = rdb.Name;
            switch (valore)
            {
                case "rdbValore1":
                    if (rdb.Checked)
                        Globals.conversione = 0;     //Salvataggio indice 
                    break;
                case "rdbValore2":
                    if (rdb.Checked)
                        Globals.conversione = 1; break;
                case "rdbValore3":
                    if (rdb.Checked)
                        Globals.conversione = 2;      break;
                case "rdbValore4":
                    if(rdb.Checked)
                        Globals.conversione = 3; break;
                default:
                    break;
            }
        }
        private void ChkValore_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            string valore = chk.Name;
            btnVisualizza.Enabled = true;
            switch (valore)
            {
                case "chkValore1":
                    if (chkValore1.Checked)
                        Globals.visualizza[0] = 1;
                    else
                    {
                        Globals.visualizza[0] = 0;
                        if (Methods.Verifica(Globals.visualizza))
                            btnVisualizza.Enabled = false;
                    }; break;

                case "chkValore2":
                    if (chkValore2.Checked)
                        Globals.visualizza[1] = 1;
                    else
                    {
                        Globals.visualizza[1] = 0;
                        if (Methods.Verifica(Globals.visualizza))
                            btnVisualizza.Enabled = false;
                    }
                    break;

                case "chkValore3":
                    if (chkValore3.Checked)
                        Globals.visualizza[2] = 1;
                    else
                    {
                        Globals.visualizza[2] = 0;
                        if (Methods.Verifica(Globals.visualizza))
                            btnVisualizza.Enabled = false;
                    }
                    break;

                case "chkValore4":
                    if (chkValore4.Checked)
                        Globals.visualizza[3] = 1;
                    else
                    {
                        Globals.visualizza[3] = 0;
                        if (Methods.Verifica(Globals.visualizza))
                            btnVisualizza.Enabled = false;
                    }
                    break;

                default:
                    break;
            }
        }
        private void RdbInput_CheckedChanged(object sender, EventArgs e)
        {
            btnInput.Enabled = true;
            RadioButton rdb = sender as RadioButton;
            string rdb_selezionato = rdb.Name;

            switch (rdb_selezionato)
            {
                case "rdbInput1":
                    
                        Globals.input = 0; break;
                case "rdbInput2":
                    
                        Globals.input = 1; break;
                case "rdbInput3":
                   
                        Globals.input = 2; break;
                case "rdbInput4":
                    
                        Globals.input = 3; break;
                default:
                    break;
            }
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
        private void btnConverti_Click(object sender, EventArgs e)
        {
            int[,] mat = Globals.val;
            int aggiungi = 1;

            for (int j = 0; j <= mat.GetUpperBound(1); j++)
            {
                if (mat[Globals.conversione, mat.GetUpperBound(1) - j ] == 1)
                {
                    for (int i = 0; i < j; i++)
                    {
                        aggiungi *= 2;
                    }
                    Globals.decimale += aggiungi;
                }
                aggiungi = 1;
            }
            txtVisualizza.Text = "N" + Convert.ToString(Globals.conversione+1) + " ";
            for (int j = 0; j <= mat.GetUpperBound(1); j++)
            {
                txtVisualizza.Text += Convert.ToString(mat[Globals.conversione, j]);
            }
            txtVisualizza.Text += "= " + Convert.ToString(Globals.decimale);
            Globals.decimale = 0;
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            btnInput.Enabled = false;
            if (Globals.count <= 4)
            {
                Methods.RiempiMatrice(txtVisualizza.Text);
                switch (Globals.input)
                {
                    case 0: rdbInput1.Enabled = false; ;break;
                    case 1: rdbInput2.Enabled = false; ; break;
                    case 2: rdbInput3.Enabled = false; ; break;
                    case 3: rdbInput4.Enabled = false; ; break;
                }
            }
            Globals.count++;
            if(Globals.count>=4)
            {
                //visualizzazione valori iniziali
                int[,] mat = Globals.val;
                txtVisualizza.Text = "";
                for (int i = 0; i <= mat.GetUpperBound(0); i++)
                {
                    txtVisualizza.Text += "N" + Convert.ToString(i + 1) + " ";           //stampa indice numer es N1
                    for (int j = 0; j <= mat.GetUpperBound(1); j++)
                        txtVisualizza.Text = txtVisualizza.Text + Convert.ToString(mat[i, j]);      //stampa ogni numero
                    txtVisualizza.Text += "\r\n";
                }

                grpConversione.Enabled = true;
                grpSelezioneV.Enabled = true;
            }            
        }
    }
}
