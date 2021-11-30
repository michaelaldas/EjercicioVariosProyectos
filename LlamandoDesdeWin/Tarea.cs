using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamandoDesdeWin
{
    public partial class Tarea : Form
    {
        public Tarea()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            BibliotecaDeFunciones.Operaciones ob1 = new BibliotecaDeFunciones.Operaciones();
            double num1 = Convert.ToDouble(TxtSuma1.Text);
            double num2 = Convert.ToDouble(TxtSuma2.Text);
            int Fac = Convert.ToInt32(TxtFac.Text);
            double x1 = ob1.suma(num1, num2);
            double fac = ob1.factorial(Fac);
            this.TxtResSu.Text = x1.ToString();
            this.TxtResFa.Text = fac.ToString();
        }
    }
}
