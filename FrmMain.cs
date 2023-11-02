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
{/// <summary>
/// Ejercicio 2 Desarrollo de Interafaces - RELOJ -
/// Este es el formulario principal de la aplicación. He añadido un Dictionary y he necesitado meter un boolean para poder actualizar el menú 
/// si han ocurrido cambios. Además uso un int para determinar la diferencia horaria que debo mostrar.
/// </summary>
    public partial class FrmMain : Form
    {
        // variables static para el control de la aplicación
        internal static Dictionary<string, int> zonasHorarias = new Dictionary<string, int>();
        internal static bool isChanged = false;
        private static int difHoraActual = 0;


        /// <summary>
        /// Método para insertar un país y su zona horaria en el Dictionary.
        /// </summary>
        /// <param name="pais">País a insertar</param>
        /// <param name="difHora">Diferencia horaria en enteros</param>
        /// <returns>True si se hace la inserción correctamente. Falso en caso contrario</returns>
        /// <remarks>
        /// Este método comprueba e inserta en el Dictionary zonasHorarias el pais y la diferencia
        /// horaria como un par clave-valor. Es llamado desde el Form adiccional que se crear al agregar un país.
        /// </remarks>
        public static bool InsertarPais(string pais, int difHora)
        {
            if (!zonasHorarias.ContainsKey(pais))
            {
                zonasHorarias.Add(pais, difHora);
                isChanged = true;
                return true;
            } else
            {
                MessageBox.Show("El país que está intentando agregar ya existe en la aplicación.");
                return false;
            }
            
        }
        /// <summary>
        /// Método que crea y añade a los menús el país correspondiente.
        /// </summary>
        /// <param name="pais">País a crear</param>
        /// <param name="difHoraria">Diferencia horaria que se añadira al Tag del Control</param>
        /// <remarks>He decidido añadir al menú borrar todos los paises guardados. Estos tendrán un 
        /// controlador de evento diferente, para que al hacer click sobre ellos se borren de la app</remarks>
        private void PintarMenu(string pais, int difHoraria)
        {
            ToolStripMenuItem ts = new ToolStripMenuItem();
            ts.Text = pais;
            ts.Tag = difHoraria;
            ts.Click += new EventHandler(EventSeleccionarPais);
            TsMenu.DropDownItems.Add(ts);

            // No puede ser el mismo Ts, tienen controladores diferentes.
            ToolStripMenuItem tsMenuBorrar = new ToolStripMenuItem();
            tsMenuBorrar.Text = pais;
            tsMenuBorrar.Click += new EventHandler(EventBorrarPais);
            TsMenuBorrar.DropDownItems.Add(tsMenuBorrar);
        }

        /// <summary>
        /// Controlador del evento Click de los países del menú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Este método es el que se asigna a todos los TS de paises que se van agregando.
        /// Cambia el valor de la variable difHoraActual por el del Tag de TS que ha desencadenado el evento.
        /// </remarks>
        private void EventSeleccionarPais(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            difHoraActual = Convert.ToInt32(ts.Tag);
            LblPais.Text = ts.Text;
        }

        /// <summary>
        /// Controlador del evento Click de los TS de paises del menú Borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Se asigna a todos los TS de paises del menú borrar. El controlador modifica el diccionario y cambia 
        /// la variable isChanged a true. 
        /// Si el país se borra correctamente lanza un dialogo al usuario.
        /// </remarks>
        private void EventBorrarPais(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            String paisBorrar = ts.Text;

            if (zonasHorarias.Remove(paisBorrar))
            {
                MessageBox.Show("Se ha borrado el país correctamente.");
                isChanged = true;
            }
        }

        /// <summary>
        /// Este método se encarga de organizar y repintar el menú. 
        /// </summary>
        /// <remarks>
        /// Se ejecuta cuando el bool isChaged es true (se comprueba en el evento Tick del 
        /// Timer). Primero borra todos los paises de los menús y los vuelve a crear uno a uno de manera ordenada.
        /// </remarks>
        private void RePintarMenus()
        {
            // Borro todos los menús que contengan un Tag (solo lo contienen los paises).
            // Como debo modificar el DropDownItems, primero localizo los ToolStrip a borrar, los guardo en una List
            // y luego los borro. Si no lo hacía así me daba error por modificar la lista de DropDownItems directamente
            // mientras lo recorría con el foreach.

            List<ToolStripItem> listItemsBorrar = new List<ToolStripItem>();            
            
            foreach (ToolStripItem ts in TsMenu.DropDownItems)
            {
                if (ts.Tag == null) continue;
                listItemsBorrar.Add(ts);
            }
            
            foreach (ToolStripItem ts in listItemsBorrar)
            {
                TsMenu.DropDownItems.Remove(ts);
            }

            // Borro el menú Borrar.
            TsMenuBorrar.DropDownItems.Clear();

            // Ordeno el diccionario y pinto los menús.
            zonasHorarias = zonasHorarias.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (KeyValuePair<string, int> kvp in zonasHorarias)
            {
                PintarMenu(kvp.Key, kvp.Value);
            }
        }
        public FrmMain()
        {
            InitializeComponent();            
            TimerMain.Interval = 1000; ;
            TimerMain.Start();
        }

        /// <summary>
        /// Controlador del Timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Se ejecuta cada segundo. Se comprueba y dibuja la hora actual y la diferencia horaria. Además comprueba
        /// la variable isChanged por si se tiene que repintar los menús.
        /// </remarks>
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            TbHora.Text = horaActual.Hour.ToString("D2") + " : " + horaActual.Minute.ToString("D2") + " : " + horaActual.Second.ToString("D2");

            if (LblPais.Text.Length != 0)
            {
                DateTime horaDesfasada = horaActual.AddHours(difHoraActual);               
                TbZonasHorarias.Text = horaDesfasada.Hour.ToString("D2") + " : " + horaDesfasada.Minute.ToString("D2") + " : " + horaDesfasada.Second.ToString("D2");
                
            }

            if (isChanged)
            {
                RePintarMenus();
                isChanged = false;
            }
        }

        /// <summary>
        /// Controlador Click del TS Salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsMenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Controlador del TS agregar. Abre un nuevo Form para agregar un nuevo país.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsMenuAgregar_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.ShowDialog();
        }
    }
}
