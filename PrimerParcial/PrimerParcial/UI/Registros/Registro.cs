using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimerParcial.BLL;
using PrimerParcial.DAL;
using PrimerParcial.Entidades;


namespace PrimerParcial.UI.Registros
{
 
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Grupos grupos = LlenaClase();
            bool paso = false;

            if (IDnumericUpDown.Value == 0)
                paso = BLL.GruposBLL.Guardar(grupos);
            else
                paso = BLL.GruposBLL.Modificar(LlenaClase());

            if (paso)
                MessageBox.Show("Guardado!!", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No Se puedo Guardar", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Grupos LlenaClase()
        {
            Grupos grupos = new Grupos();

            Grupos

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumericUpDown.Value);

            if (BLL.GruposBLL(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("no se elimino", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IDnumericUpDown.Value = 0;
            GruposNumericUpDown.Clear();

        }
    }
}
