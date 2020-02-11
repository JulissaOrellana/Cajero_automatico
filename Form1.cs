using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtCantidad.Text);
            sbyte n = 0;
            string respuesta = "Total: \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    n++;
                    cantidad -= denominacion;
                }

                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? " Billetes de " : " Monedas de ") + denominacion + "\n";
                }
                n = 0;
            }

            lblTotal.Text = respuesta;
            txtCantidad.Text = "";
        }

        private void btnPagare_Click(object sender, EventArgs e)
        {
            double Cp = double.Parse(txtCantidadProduc.Text), Cpr = double.Parse(txtCantidadPagre.Text), Totally;
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            sbyte Pc = 0;
            string Rspst = "Total: \n";
            foreach (double denominacion in denominaciones)
            {
                Totally = Cp - Cpr;
                while (denominacion <= Math.Round(Cp, 2))
                {
                    Cp++;
                    Cp -= denominacion;
                }
                if (Pc > 0)
                {
                    Rspst += Totally + "\n" + Cp + (denominacion > 1 ? " Billetes de " : " Monedas de ") + denominacion;
                    Pc = 0;
                    lblCantidadProdu.Text = Rspst;
                }
            }
        }

        private void btnFbncc_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtFbncc.Text), F = 0, N = 1, CC, i;
            string respuesta = "";
            for (i = 0; i < n; i++)
            {
                CC = F;
                F = N;
                N = CC + F;
                respuesta += "Al sumar " + F + " es " + N + "\n";
                lblFbncc.Text = "" + respuesta;
                
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            int P= 0, i, M;
            M = int.Parse(txtNumero.Text);
            P = 0;
            for (i = 1; i < (M+ 1); i++)

                if (M % i == 0)
                    P++;
            lblRespuesta.Text = ((P != 2) ? M + " El numero ingresado no es primo " : M + " El numero ingresado es primo" + "\n");
            txtNumero.Text = "";
        }
    }
}
