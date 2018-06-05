using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Consultas
{
    public partial class Consuntar : Form
    {
        public Consuntar()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            {
                
                Expression<Func<Grupos, bool>> filtro = x => true;

                int id;
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0:
                        id = Convert.ToInt32(CriteriotextBox.Text);
                        filtro = x => x.GruposID == id;
                        break;
                    case 1:
                        filtro = x => x.GruposId.Contains(CriteriotextBox.Text);
                        break;
                    case 2:
                        filtro = x => x.Fecha.Equals(CriteriotextBox.Text);
                        break;
                    case 3:
                        filtro = x => x.Descripcion.Contains(CriteriotextBox.Text);
                        break;
                    case 4:
                        filtro = x => x.Cantidad.Equals(CriteriotextBox.Text);
                        break;
                    case 5:
                        filtro = x => x.Integrantes.Equals(CriteriotexBox.Text);
                        break;
                            }


                ConsultadataGridView.DataSource = BLL.GetList(filtro);
            }





        }
    }
}
