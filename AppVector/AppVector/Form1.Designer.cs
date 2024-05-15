namespace AppVector
{
    partial class Frmvectores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDeParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarDeMenorAMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementosPosPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDeImparesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadQueSonCapicuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canElementosPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirCadaElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.Location = new System.Drawing.Point(14, 57);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(31, 13);
            this.lbvalor.TabIndex = 0;
            this.lbvalor.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(75, 50);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(201, 46);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(14, 90);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(55, 13);
            this.lbresultado.TabIndex = 3;
            this.lbresultado.Text = "Resultado";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(12, 127);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicaToolStripMenuItem,
            this.avanzadoToolStripMenuItem,
            this.avanzadoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicaToolStripMenuItem
            // 
            this.basicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.basicaToolStripMenuItem.Name = "basicaToolStripMenuItem";
            this.basicaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.basicaToolStripMenuItem.Text = "Basica";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // invertirToolStripMenuItem1
            // 
            this.invertirToolStripMenuItem1.Name = "invertirToolStripMenuItem1";
            this.invertirToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // avanzadoToolStripMenuItem1
            // 
            this.avanzadoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirToolStripMenuItem,
            this.cantDeParesToolStripMenuItem,
            this.ordenarDeMenorAMayorToolStripMenuItem,
            this.eliminarElementosPosPToolStripMenuItem,
            this.cantDeImparesToolStripMenuItem,
            this.cantidadQueSonCapicuaToolStripMenuItem,
            this.canElementosPrimosToolStripMenuItem,
            this.invertirCadaElementoToolStripMenuItem});
            this.avanzadoToolStripMenuItem1.Name = "avanzadoToolStripMenuItem1";
            this.avanzadoToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem1.Text = "Avanzado";
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invertirToolStripMenuItem.Text = "Invertir";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // cantDeParesToolStripMenuItem
            // 
            this.cantDeParesToolStripMenuItem.Name = "cantDeParesToolStripMenuItem";
            this.cantDeParesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cantDeParesToolStripMenuItem.Text = "Cant. de Pares";
            this.cantDeParesToolStripMenuItem.Click += new System.EventHandler(this.cantDeParesToolStripMenuItem_Click);
            // 
            // ordenarDeMenorAMayorToolStripMenuItem
            // 
            this.ordenarDeMenorAMayorToolStripMenuItem.Name = "ordenarDeMenorAMayorToolStripMenuItem";
            this.ordenarDeMenorAMayorToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ordenarDeMenorAMayorToolStripMenuItem.Text = "Ordenar de Menor a Mayor";
            this.ordenarDeMenorAMayorToolStripMenuItem.Click += new System.EventHandler(this.ordenarDeMenorAMayorToolStripMenuItem_Click);
            // 
            // eliminarElementosPosPToolStripMenuItem
            // 
            this.eliminarElementosPosPToolStripMenuItem.Name = "eliminarElementosPosPToolStripMenuItem";
            this.eliminarElementosPosPToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.eliminarElementosPosPToolStripMenuItem.Text = "Eliminar Elementos Pos P";
            this.eliminarElementosPosPToolStripMenuItem.Click += new System.EventHandler(this.eliminarElementosPosPToolStripMenuItem_Click);
            // 
            // cantDeImparesToolStripMenuItem
            // 
            this.cantDeImparesToolStripMenuItem.Name = "cantDeImparesToolStripMenuItem";
            this.cantDeImparesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cantDeImparesToolStripMenuItem.Text = "Cant. de Impares";
            this.cantDeImparesToolStripMenuItem.Click += new System.EventHandler(this.cantDeImparesToolStripMenuItem_Click);
            // 
            // cantidadQueSonCapicuaToolStripMenuItem
            // 
            this.cantidadQueSonCapicuaToolStripMenuItem.Name = "cantidadQueSonCapicuaToolStripMenuItem";
            this.cantidadQueSonCapicuaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cantidadQueSonCapicuaToolStripMenuItem.Text = "Cantidad que son Capicua";
            this.cantidadQueSonCapicuaToolStripMenuItem.Click += new System.EventHandler(this.cantidadQueSonCapicuaToolStripMenuItem_Click);
            // 
            // canElementosPrimosToolStripMenuItem
            // 
            this.canElementosPrimosToolStripMenuItem.Name = "canElementosPrimosToolStripMenuItem";
            this.canElementosPrimosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.canElementosPrimosToolStripMenuItem.Text = "Can. Elementos Primos";
            this.canElementosPrimosToolStripMenuItem.Click += new System.EventHandler(this.canElementosPrimosToolStripMenuItem_Click);
            // 
            // invertirCadaElementoToolStripMenuItem
            // 
            this.invertirCadaElementoToolStripMenuItem.Name = "invertirCadaElementoToolStripMenuItem";
            this.invertirCadaElementoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.invertirCadaElementoToolStripMenuItem.Text = "Invertir cada Elemento";
            this.invertirCadaElementoToolStripMenuItem.Click += new System.EventHandler(this.invertirCadaElementoToolStripMenuItem_Click);
            // 
            // Frmvectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 162);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lbvalor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmvectores";
            this.Text = "Vectores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantDeParesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarDeMenorAMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElementosPosPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantDeImparesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadQueSonCapicuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canElementosPrimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirCadaElementoToolStripMenuItem;
    }
}

