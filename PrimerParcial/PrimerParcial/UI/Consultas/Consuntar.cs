using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using PrimerParcial.BLL;
using PrimerParcial.Entidades;

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
                    case 0://id
                        id = Convert.ToInt32(CriteriotextBox.Text);
                        filtro = x => (x.GruposID == id) && (x.Fecha >= Desde_dateTimePicker.Value.Date && x.Fecha <= Hasta_dateTimePicker.Value.Date);
                        break;
                    case 1://descripcion
                        filtro = x => (x.Descripcion.Contains(CriteriotextBox.Text)) && (x.Fecha >= Desde_dateTimePicker.Value.Date && x.Fecha <= Hasta_dateTimePicker.Value.Date);
                        break;
                    case 2://cantidad
                        id = Convert.ToInt32(CriteriotextBox.Text);
                        filtro = x => (x.Cantidad.Equals(id)) && (x.Fecha >= Desde_dateTimePicker.Value.Date && x.Fecha <= Hasta_dateTimePicker.Value.Date);
                        break;
                    case 3://grupo
                        id = Convert.ToInt32(CriteriotextBox.Text);
                        filtro = x => (x.grupos1.Equals(id)) && (x.Fecha >= Desde_dateTimePicker.Value.Date && x.Fecha <= Hasta_dateTimePicker.Value.Date);
                        break;
                    case 4://integrantes
                        id = Convert.ToInt32(CriteriotextBox.Text);
                        filtro = x => (x.Integrantes.Equals(id)) && (x.Fecha >= Desde_dateTimePicker.Value.Date && x.Fecha <= Hasta_dateTimePicker.Value.Date);
                        break;
                    
                   
                 }


                ConsultarDataGridView.DataSource = BLL.GrupoBLL.GetList(filtro);
            }

        }

        private void FiltrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
