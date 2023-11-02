
namespace RelojApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TbHora = new System.Windows.Forms.TextBox();
            this.TbZonasHorarias = new System.Windows.Forms.TextBox();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.LblInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblHoraActual = new System.Windows.Forms.Label();
            this.LblPais = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbHora
            // 
            this.TbHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbHora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TbHora.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbHora.ForeColor = System.Drawing.SystemColors.Info;
            this.TbHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TbHora.Location = new System.Drawing.Point(12, 59);
            this.TbHora.Name = "TbHora";
            this.TbHora.ReadOnly = true;
            this.TbHora.ShortcutsEnabled = false;
            this.TbHora.Size = new System.Drawing.Size(272, 71);
            this.TbHora.TabIndex = 0;
            this.TbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbHora.WordWrap = false;
            // 
            // TbZonasHorarias
            // 
            this.TbZonasHorarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbZonasHorarias.CausesValidation = false;
            this.TbZonasHorarias.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold);
            this.TbZonasHorarias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TbZonasHorarias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TbZonasHorarias.Location = new System.Drawing.Point(12, 253);
            this.TbZonasHorarias.Name = "TbZonasHorarias";
            this.TbZonasHorarias.ReadOnly = true;
            this.TbZonasHorarias.Size = new System.Drawing.Size(272, 71);
            this.TbZonasHorarias.TabIndex = 1;
            this.TbZonasHorarias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerMain
            // 
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(12, 236);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(51, 14);
            this.LblInfo.TabIndex = 2;
            this.LblInfo.Text = "Hora en:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Gadugi", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsMenu
            // 
            this.TsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMenuAgregar,
            this.TsMenuBorrar,
            this.TsMenuSalir,
            this.toolStripMenuItem1});
            this.TsMenu.Font = new System.Drawing.Font("Gadugi", 9F);
            this.TsMenu.Name = "TsMenu";
            this.TsMenu.Size = new System.Drawing.Size(51, 20);
            this.TsMenu.Text = "Menú";
            // 
            // TsMenuAgregar
            // 
            this.TsMenuAgregar.Name = "TsMenuAgregar";
            this.TsMenuAgregar.Size = new System.Drawing.Size(118, 22);
            this.TsMenuAgregar.Text = "Agregar";
            this.TsMenuAgregar.Click += new System.EventHandler(this.TsMenuAgregar_Click);
            // 
            // TsMenuBorrar
            // 
            this.TsMenuBorrar.Name = "TsMenuBorrar";
            this.TsMenuBorrar.Size = new System.Drawing.Size(118, 22);
            this.TsMenuBorrar.Text = "Borrar";
            // 
            // TsMenuSalir
            // 
            this.TsMenuSalir.Name = "TsMenuSalir";
            this.TsMenuSalir.Size = new System.Drawing.Size(118, 22);
            this.TsMenuSalir.Text = "Salir";
            this.TsMenuSalir.Click += new System.EventHandler(this.TsMenuSalir_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // LblHoraActual
            // 
            this.LblHoraActual.AutoSize = true;
            this.LblHoraActual.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraActual.Location = new System.Drawing.Point(12, 42);
            this.LblHoraActual.Name = "LblHoraActual";
            this.LblHoraActual.Size = new System.Drawing.Size(59, 14);
            this.LblHoraActual.TabIndex = 4;
            this.LblHoraActual.Text = "Hora local";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblPais.Location = new System.Drawing.Point(66, 232);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(0, 17);
            this.LblPais.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(296, 341);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.LblHoraActual);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.TbZonasHorarias);
            this.Controls.Add(this.TbHora);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj despertador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbHora;
        private System.Windows.Forms.TextBox TbZonasHorarias;
        private System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsMenuAgregar;
        private System.Windows.Forms.ToolStripMenuItem TsMenuBorrar;
        private System.Windows.Forms.ToolStripMenuItem TsMenuSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label LblHoraActual;
        private System.Windows.Forms.ToolStripMenuItem TsMenu;
        private System.Windows.Forms.Label LblPais;
    }
}

