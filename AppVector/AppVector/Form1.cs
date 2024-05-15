using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVector
{
    public partial class Frmvectores : Form
    {
        //creando una instancia de mi clase vector
        clsVector v = new clsVector();
        public Frmvectores()
        {
            InitializeComponent();
        }
        private void mostrarVector() {
            lbresultado.Text = "";
            for (int i = 0; i < v.longitud(); i++) {
                lbresultado.Text = lbresultado.Text + v.obtenervalor(i) + ",";
            }
            lbresultado.Text = lbresultado.Text + "]";
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertir();
            mostrarVector();
        }

        private void cantDeParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.contarNumerosPares();
            MessageBox.Show("Cantidad de Elementos Pares: " + c.ToString());
        }

        private void ordenarDeMenorAMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.ordenarVector();
            mostrarVector();
        }

        private void eliminarElementosPosPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt16(txtvalor.Text);
            v.eliminarElementosPos(p);
            mostrarVector();
        }

        private void cantDeImparesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.contarNumerosImpares();
            MessageBox.Show("Cantidad de Elememtos Impares: " + c.ToString());
        }

        private void cantidadQueSonCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.contarNumerosCapicua();
            MessageBox.Show("Cantidad de Elememtos Capicua: " + c.ToString());
        }

        private void canElementosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.contarNumerosPrimos();
            MessageBox.Show("Cantidad de Elememtos Primos: " + c.ToString());

        }

        private void invertirCadaElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertirCadaElementos();
            mostrarVector();

        }
    }
}
