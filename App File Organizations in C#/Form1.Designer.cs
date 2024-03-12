namespace App_File_Organizations_in_C_
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListFilesData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.ApellidoTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Unidad2TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Unidad1TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Unidad3TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.IDTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ShowAll = new System.Windows.Forms.Button();
            this.organizationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecuencialsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HashMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccesoAleatorioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ListFilesData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListFilesData
            // 
            this.ListFilesData.AllowUserToAddRows = false;
            this.ListFilesData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListFilesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ListFilesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Unidad1,
            this.Unidad2,
            this.Unidad3,
            this.Promedio});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListFilesData.DefaultCellStyle = dataGridViewCellStyle8;
            this.ListFilesData.Location = new System.Drawing.Point(12, 124);
            this.ListFilesData.Name = "ListFilesData";
            this.ListFilesData.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListFilesData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ListFilesData.Size = new System.Drawing.Size(466, 314);
            this.ListFilesData.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Unidad1
            // 
            this.Unidad1.HeaderText = "Unidad1";
            this.Unidad1.Name = "Unidad1";
            this.Unidad1.ReadOnly = true;
            // 
            // Unidad2
            // 
            this.Unidad2.HeaderText = "Unidad2";
            this.Unidad2.Name = "Unidad2";
            this.Unidad2.ReadOnly = true;
            // 
            // Unidad3
            // 
            this.Unidad3.HeaderText = "Unidad3";
            this.Unidad3.Name = "Unidad3";
            this.Unidad3.ReadOnly = true;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(497, 124);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(109, 31);
            this.Add.TabIndex = 1;
            this.Add.Text = "Agregar";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // NombreTXT
            // 
            this.NombreTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTXT.Location = new System.Drawing.Point(102, 41);
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(124, 29);
            this.NombreTXT.TabIndex = 3;
            // 
            // ApellidoTXT
            // 
            this.ApellidoTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoTXT.Location = new System.Drawing.Point(102, 76);
            this.ApellidoTXT.Name = "ApellidoTXT";
            this.ApellidoTXT.Size = new System.Drawing.Size(124, 29);
            this.ApellidoTXT.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido:";
            // 
            // Unidad2TXT
            // 
            this.Unidad2TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidad2TXT.Location = new System.Drawing.Point(328, 78);
            this.Unidad2TXT.Name = "Unidad2TXT";
            this.Unidad2TXT.Size = new System.Drawing.Size(56, 29);
            this.Unidad2TXT.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unidad 2:";
            // 
            // Unidad1TXT
            // 
            this.Unidad1TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidad1TXT.Location = new System.Drawing.Point(328, 43);
            this.Unidad1TXT.Name = "Unidad1TXT";
            this.Unidad1TXT.Size = new System.Drawing.Size(56, 29);
            this.Unidad1TXT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unidad 1:";
            // 
            // Unidad3TXT
            // 
            this.Unidad3TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidad3TXT.Location = new System.Drawing.Point(497, 43);
            this.Unidad3TXT.Name = "Unidad3TXT";
            this.Unidad3TXT.Size = new System.Drawing.Size(56, 29);
            this.Unidad3TXT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unidad 3:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.organizationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveHowToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // saveHowToolStripMenuItem
            // 
            this.saveHowToolStripMenuItem.Name = "saveHowToolStripMenuItem";
            this.saveHowToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.saveHowToolStripMenuItem.Text = "Save How";
            this.saveHowToolStripMenuItem.Click += new System.EventHandler(this.SaveHowMenuItem_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(497, 161);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(109, 31);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Eliminar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(497, 235);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(109, 31);
            this.Search.TabIndex = 14;
            this.Search.Text = "Buscar";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(497, 198);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(109, 31);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Editar";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // IDTXT
            // 
            this.IDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTXT.Location = new System.Drawing.Point(439, 78);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(56, 29);
            this.IDTXT.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID:";
            // 
            // ShowAll
            // 
            this.ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAll.Location = new System.Drawing.Point(497, 272);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(109, 52);
            this.ShowAll.TabIndex = 18;
            this.ShowAll.Text = "Mostrar todos";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // organizationsToolStripMenuItem
            // 
            this.organizationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SecuencialsMenuItem,
            this.HashMenuItem,
            this.AccesoAleatorioMenuItem});
            this.organizationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizationsToolStripMenuItem.Name = "organizationsToolStripMenuItem";
            this.organizationsToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.organizationsToolStripMenuItem.Text = "Organizations";
            // 
            // SecuencialsMenuItem
            // 
            this.SecuencialsMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecuencialsMenuItem.Name = "SecuencialsMenuItem";
            this.SecuencialsMenuItem.Size = new System.Drawing.Size(225, 30);
            this.SecuencialsMenuItem.Text = "Secuencials";
            this.SecuencialsMenuItem.Click += new System.EventHandler(this.SequenciesMenuItem_Click);
            // 
            // HashMenuItem
            // 
            this.HashMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashMenuItem.Name = "HashMenuItem";
            this.HashMenuItem.Size = new System.Drawing.Size(225, 30);
            this.HashMenuItem.Text = "Hash";
            this.HashMenuItem.Click += new System.EventHandler(this.HashMenuItem_Click);
            // 
            // AccesoAleatorioMenuItem
            // 
            this.AccesoAleatorioMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccesoAleatorioMenuItem.Name = "AccesoAleatorioMenuItem";
            this.AccesoAleatorioMenuItem.Size = new System.Drawing.Size(225, 30);
            this.AccesoAleatorioMenuItem.Text = "Acceso Aleatorio";
            this.AccesoAleatorioMenuItem.Click += new System.EventHandler(this.AccesoAleatorioMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.IDTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Unidad3TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Unidad2TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Unidad1TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ApellidoTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListFilesData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListFilesData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListFilesData;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTXT;
        private System.Windows.Forms.TextBox ApellidoTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Unidad2TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Unidad1TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Unidad3TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox IDTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.ToolStripMenuItem organizationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SecuencialsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HashMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccesoAleatorioMenuItem;
    }
}

