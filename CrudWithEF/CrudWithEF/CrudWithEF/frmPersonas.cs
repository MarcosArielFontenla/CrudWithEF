using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudWithEF.Models;
using CrudWithEF.Models.Presentation;

namespace CrudWithEF
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTable frmTable = new frmTable();
            frmTable.ShowDialog();
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)        // Obtengo el id seleccionado, si es distinto a null va a buscarlos a la tabla, si no no hace nada.
        {
            int? id = GetId();

            if (id != null)
            {
                frmTable objFrmTable = new frmTable(id);
                objFrmTable.ShowDialog();
                Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                using (CrudWithEFEntities db = new CrudWithEFEntities())
                {
                    Persona dbTable = db.Persona.Find(id);
                    db.Persona.Remove(dbTable);
                    db.SaveChanges();
                }
                Refresh();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "Helper Methods"
        private void Refresh()      // metodo para hacer un select y que muestre los datos de la tabla, en la grilla apenas levanta el form.
        {
            using (CrudWithEFEntities db = new CrudWithEFEntities())
            {
                var lst = from d in db.Persona
                          select d;

                dgvPersonas.DataSource = lst.ToList();
            }
        }

        private int? GetId()        // Obtengo el id de la celda seleccionada.
        {
            try
            {
                return int.Parse(dgvPersonas.Rows[dgvPersonas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Hubo un error: " + ex.Message);
            }
        }
        #endregion
    }
}
