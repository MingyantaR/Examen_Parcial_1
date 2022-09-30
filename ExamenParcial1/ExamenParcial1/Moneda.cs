using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ExamenParcial1
{
    public partial class Moneda : Form
    {
        string txtmonto;
        string txtmoneda;
        public string returntext;
        public string txtconv;
        public Moneda(string valor, string valor1, string valor2, string valor3)
        {
            InitializeComponent();
            txtmonto = valor;
            txtmoneda = valor1;
            txtconv = valor2;
            returntext = valor;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Moneda_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                if (index == 1)//CAD
                {
                    double CADEUR;
                    double CADYEN;
                    double CADPES;
                    double CADUSD;
                    if (txtmoneda == "CAD - Dolar Canadiense")
                    {
                        returntext = txtmonto;
                        txtconv = "CAD - Dolar";
                    }else if(txtmoneda == "EUR - Euro"){
                        CADEUR = double.Parse(txtmonto) * 0.76;
                        returntext = CADEUR.ToString();
                        txtconv = "EUR - Euro";
                    }
                    else if(txtmoneda == "JYP - Yen Japones"){
                        CADYEN = double.Parse(txtmonto) * 105.74;
                        returntext = CADYEN.ToString();
                        txtconv = "JPY - Yen Japones";
                    }
                    else if(txtmoneda == "MXN - Peso Mexicano"){
                        CADPES = double.Parse(txtmonto) * 14.84;
                        returntext = CADPES.ToString();
                        txtconv = "MXN - Peso";
                    }
                    else if(txtmoneda == "USD - Dolar Estadounidense"){
                        CADUSD = double.Parse(txtmonto) * 0.73;
                        returntext = CADUSD.ToString();
                        txtconv = "USD - Dolar";
                    }
                }
                else if (index == 2)//Euro
                {
                    double EURCAD;
                    double EURYEN;
                    double EURMXN;
                    double EURUSD;
                    if (txtmoneda == "CAD - Dolar Canadiense"){
                        EURCAD = double.Parse(txtmonto) * 1.32;
                        returntext = EURCAD.ToString();
                    }
                    else if (txtmoneda == "JYP - Yen Japones"){
                        EURYEN = double.Parse(txtmonto) * 139.89;
                        returntext = EURYEN.ToString();
                    }
                    else if (txtmoneda == "MXN - Peso Mexicano"){
                        EURMXN = double.Parse(txtmonto) * 19.62;
                        returntext =EURMXN.ToString();  
                    }else if (txtmoneda == "USD - Dolar Estadounidense"){
                        EURUSD = double.Parse(txtmonto) * 0.97;
                        returntext = EURUSD.ToString();  
                    }else if (txtmoneda == "EUR - Euro"){
                        returntext = txtmonto;
                    } 
                }
                else if (index == 3)//Yen
                {
                    double YENCAD;
                    double YENEUR;
                    double YENMXN;
                    double YENUSD;
                    if (txtmoneda == "CAD - Dolar Canadiense")
                    {
                        YENCAD = double.Parse(txtmonto) * 0.01;
                        returntext = YENCAD.ToString();
                    }
                    else if (txtmoneda == "EUR - Euro")
                    {
                        YENEUR = double.Parse(txtmonto) * 0.01;
                        returntext = YENEUR.ToString();
                    }
                    else if (txtmoneda == "JYP - Yen Japones")
                    {
                        returntext = txtmonto;
                    }
                    else if (txtmoneda == "MXN - Peso Mexicano")
                    {
                        YENMXN = double.Parse(txtmonto) * 0.14;
                        returntext = YENMXN.ToString();
                    }
                    else if (txtmoneda == "USD - Dolar Estadounidense")
                    {
                        YENUSD = double.Parse(txtmonto) * 0.01;
                        returntext = YENUSD.ToString();
                    }
                }
                else if (index == 4)//Peso
                {
                    double MXNCAD;
                    double MXNEUR;
                    double MXNYEN;
                    double MXNUSD;
                    if (txtmoneda == "CAD - Dolar Canadiense")
                    {
                        MXNCAD = double.Parse(txtmonto) * 0.07;
                        returntext = MXNCAD.ToString();
                    }
                    else if (txtmoneda == "EUR - Euro")
                    {
                        MXNEUR = double.Parse(txtmonto) * 0.05;
                        returntext = MXNEUR.ToString();
                    }
                    else if (txtmoneda == "JYP - Yen Japones")
                    {
                        MXNYEN = double.Parse(txtmonto) * 7.13;
                        returntext = MXNYEN.ToString();
                    }
                    else if (txtmoneda == "MXN - Peso Mexicano")
                    {
                        returntext = txtmonto;
                    }
                    else if (txtmoneda == "USD - Dolar Estadounidense")
                    {
                        MXNUSD = double.Parse(txtmonto) * 0.05;
                        returntext = MXNUSD.ToString();
                    }
                }
                else if (index == 5)//USD
                {
                    double USDCAD;
                    double USDEUR;
                    double USDYEN;
                    double USDMXN;
                    if (txtmoneda == "CAD - Dolar Canadiense")
                    {
                        USDCAD = double.Parse(txtmonto) * 1.36;
                        returntext = USDCAD.ToString();
                    }
                    else if (txtmoneda == "EUR - Euro")
                    {
                        USDEUR = double.Parse(txtmonto) * 1.03;
                        returntext = USDEUR.ToString(); 
                    }
                    else if (txtmoneda == "JYP - Yen Japones")
                    {
                        USDYEN = double.Parse(txtmonto) * 144.33;
                        returntext = USDYEN.ToString();
                    }
                    else if (txtmoneda == "MXN - Peso Mexicano")
                    {
                        USDMXN = double.Parse(txtmonto) * 20.25;
                        returntext = USDMXN.ToString();
                    }
                    else if (txtmoneda == "USD - Dolar Estadounidense")
                    {
                        returntext = txtmonto;
                    }
                }
            }

        }
    }
}
