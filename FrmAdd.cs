using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojApp
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

       

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Convert.ToInt32(TbDifHoraria.Text.ToString());
            } catch (FormatException exc)
            {
                MessageBox.Show("Error en la diferencia horaria. Por favor, utilice números enteros.");
                return;
            }
            if (TbPais.Text.Length <= 0)
            {
                String msg = "Debe introducir todos los campos.";
                MessageBox.Show(msg);
                return;
            }

            if (FrmMain.InsertarPais(TbPais.Text.ToString().ToUpper(), Convert.ToInt32(TbDifHoraria.Text))) {
                MessageBox.Show("Se ha insertado correctamente.");
                this.Close();
            }


        }

        
    }
}
