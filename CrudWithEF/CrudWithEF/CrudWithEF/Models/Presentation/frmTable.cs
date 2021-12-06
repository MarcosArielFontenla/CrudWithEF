using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CrudWithEF.Models;

namespace CrudWithEF.Models.Presentation
{
    public partial class frmTable : Form
    {
        public int? id;
        private Persona dbTable = null;

        public frmTable(int? id = null)
        {
            InitializeComponent();
            this.id = id;

            if (id != null)
                LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (CrudWithEFEntities db = new CrudWithEFEntities())                // crea un objeto de la tabla del sql para almacenarle a cada campo de la db, lo que venga en los textbox, le hace un Add al objeto de la tabla y guarda los cambios.
            {                           
                if (id == null)
                    dbTable = new Persona();

                dbTable.Name = txtName.Text;
                dbTable.Email = txtEmail.Text;
                dbTable.Birthdate = dtpBirth.Value;

                if (id == null)
                    db.Persona.Add(dbTable);
                else
                {
                    db.Entry(dbTable).State = EntityState.Modified;
                }
                db.SaveChanges();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "Helper methods"
        private void LoadData()                                                     // metodo que crea un objeto de la db para almacenar en los textbox los datos que vienen de la db.
        {
            using (CrudWithEFEntities db = new CrudWithEFEntities())
            {
                dbTable = db.Persona.Find(id);
                txtName.Text = dbTable.Name;
                txtEmail.Text = dbTable.Email;
                dtpBirth.Value = dbTable.Birthdate;
            }
        }
        #endregion
    }
}
