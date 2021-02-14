using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(textBoxSalario.Text);
            decimal calculo;
            decimal descuento;

            if (rbtnGerente.Checked == true)
            {
                descuento = sueldo * 20 / 100;
                calculo = sueldo - descuento;

                lblAns.Text = "El salario del Gerente " + textBoxNombre.Text + " es $" + sueldo + ". Se le aplica un descuento de $" + descuento + ", " + " por lo que su salario liquido es de $" + calculo ;

            }
            else if (rbtnSubGerente.Checked == true)
            {
                descuento = sueldo * 15 / 100;
                calculo = sueldo - descuento;

                lblAns.Text = "El salario del Sub Gerente " + textBoxNombre.Text + " es $" + sueldo + ". Se le aplica un descuento de $" + descuento + ", " + " por lo que su salario liquido es de $" + calculo;
            }
            else
            {
                descuento = sueldo * 5 / 100;
                calculo = sueldo - descuento;

                lblAns.Text = "El salario de la secretaria " + textBoxNombre.Text + " es $" + sueldo + ". Se le aplica un descuento de $" + descuento + ", " + " por lo que su salario liquido es de $" + calculo;
            }
        }
    }
}
