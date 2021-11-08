using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToDoToDoing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void btnToDoToDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2");
        }

        private void btnDoingToToDo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3");
        }

        private void btnDoingToDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4");
        }

        private void btnDoneToToDo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5");
        }

        private void btnDoneToDoing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        public void AddTask()
        {
            var valor1 = Int32.Parse(txtInput.Text);
            var valor2 = Int32.Parse(txtInput2.Text);

            var soma = valor1 + valor2;
            grdToDo.Rows.Add(soma.ToString());
            lblToDo.Text = "Somar";

            var subtracao = valor1 - valor2;
            grdDoing.Rows.Add(subtracao.ToString());
            lblDoing.Text = "Subtrair";

            var multiplicacao = valor1 * valor2;
            grdDone.Rows.Add(multiplicacao.ToString());
            lblDone.Text = "Multiplicar";


            //var newTask = txtInput.Text;
            //grdToDo.Rows.Add(newTask);
        }
    }
}
