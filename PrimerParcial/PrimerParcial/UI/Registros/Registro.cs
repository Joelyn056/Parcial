using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimerParcial.BLL;
using PrimerParcial.DAL.Scripts;
using PrimerParcial.Entidades;
using System.Threading.Tasks;



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

            if (GruposIDnumericUpDown.Value == 0)
                paso = BLL.GrupoBLL.Guardar(grupos);
            else
                paso = BLL.GrupoBLL.Modificar(LlenaClase());

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

            grupos.GruposID = Convert.ToInt32(GruposIDnumericUpDown.Value);
            grupos.Fecha = FechaDateTimePicker.Value.Date;
            grupos.Descripcion = DescripciontextBox1.Text;
            grupos.Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value);
            grupos.grupos1 = Convert.ToInt32(GrupoNumericUpDown.Value);
            grupos.Integrantes = Convert.ToInt32(IntegrantesNumericUpDown.Value);

            return grupos;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int GruposID = Convert.ToInt32(GruposIDnumericUpDown.Value);

            if (BLL.GrupoBLL.Eliminar(GruposID))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevobutton.PerformClick();
            }
            else
                MessageBox.Show("no se elimino", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            GruposIDnumericUpDown.Value = 0;
            DescripciontextBox1.Clear();
            CantidadNumericUpDown.Value = 0;
            GrupoNumericUpDown.Value = 0;
            IntegrantesNumericUpDown.Value = 0;

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(GruposIDnumericUpDown.Value);
            Grupos grupos = BLL.GrupoBLL.Buscar(ID);

            if (grupos != null)
            {
                GruposIDnumericUpDown.Value = grupos.GruposID;
                FechaDateTimePicker.Value = grupos.Fecha;
                DescripciontextBox1.Text = grupos.Descripcion;
                CantidadNumericUpDown.Value = grupos.Cantidad;
                GrupoNumericUpDown.Value = grupos.grupos1;
                IntegrantesNumericUpDown.Value = grupos.Integrantes;

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
      
        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (GrupoNumericUpDown.Value != 0)
                if (CantidadNumericUpDown.Value != 0)
                {
                    IntegrantesNumericUpDown.Value = CantidadNumericUpDown.Value / GrupoNumericUpDown.Value;
                }
        }

        private void GrupoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (CantidadNumericUpDown.Value != 0)
                if (GrupoNumericUpDown.Value != 0)
                {
                    IntegrantesNumericUpDown.Value = CantidadNumericUpDown.Value / GrupoNumericUpDown.Value;
                }
        }

      
    }
}
