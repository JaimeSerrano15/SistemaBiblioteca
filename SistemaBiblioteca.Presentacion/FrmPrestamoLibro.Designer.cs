
namespace SistemaBiblioteca.Presentacion
{
    partial class FrmPrestamoLibro
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
            this.Libros = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Profesores = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Prestamos = new System.Windows.Forms.DataGridView();
            this.PRESTAMO = new System.Windows.Forms.Button();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.Préstamos = new System.Windows.Forms.Label();
            this.busquedal = new System.Windows.Forms.Label();
            this.busquedap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarLibro = new System.Windows.Forms.Button();
            this.buscarprofesor = new System.Windows.Forms.Button();
            this.labelbusqueda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblibro = new System.Windows.Forms.TextBox();
            this.tbprofesor = new System.Windows.Forms.TextBox();
            this.labelfecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // Libros
            // 
            this.Libros.AllowUserToAddRows = false;
            this.Libros.AllowUserToDeleteRows = false;
            this.Libros.AllowUserToOrderColumns = true;
            this.Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Libros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.Libros.Location = new System.Drawing.Point(27, 191);
            this.Libros.Name = "Libros";
            this.Libros.ReadOnly = true;
            this.Libros.RowHeadersWidth = 51;
            this.Libros.RowTemplate.Height = 24;
            this.Libros.Size = new System.Drawing.Size(636, 247);
            this.Libros.TabIndex = 0;
            this.Libros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // Profesores
            // 
            this.Profesores.AllowUserToAddRows = false;
            this.Profesores.AllowUserToDeleteRows = false;
            this.Profesores.AllowUserToOrderColumns = true;
            this.Profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Profesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.Profesores.Location = new System.Drawing.Point(797, 191);
            this.Profesores.Name = "Profesores";
            this.Profesores.ReadOnly = true;
            this.Profesores.RowHeadersWidth = 51;
            this.Profesores.RowTemplate.Height = 24;
            this.Profesores.Size = new System.Drawing.Size(636, 247);
            this.Profesores.TabIndex = 1;
            this.Profesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Profesores_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Seleccionar";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 125;
            // 
            // Prestamos
            // 
            this.Prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prestamos.Location = new System.Drawing.Point(27, 533);
            this.Prestamos.Name = "Prestamos";
            this.Prestamos.RowHeadersWidth = 51;
            this.Prestamos.RowTemplate.Height = 24;
            this.Prestamos.Size = new System.Drawing.Size(898, 190);
            this.Prestamos.TabIndex = 2;
            // 
            // PRESTAMO
            // 
            this.PRESTAMO.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRESTAMO.Location = new System.Drawing.Point(1043, 635);
            this.PRESTAMO.Name = "PRESTAMO";
            this.PRESTAMO.Size = new System.Drawing.Size(273, 75);
            this.PRESTAMO.TabIndex = 3;
            this.PRESTAMO.Text = "Registrar Préstamo";
            this.PRESTAMO.UseVisualStyleBackColor = true;
            this.PRESTAMO.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePick
            // 
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Location = new System.Drawing.Point(1042, 554);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(266, 27);
            this.datePick.TabIndex = 4;
            // 
            // Préstamos
            // 
            this.Préstamos.AutoSize = true;
            this.Préstamos.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Préstamos.Location = new System.Drawing.Point(551, 9);
            this.Préstamos.Name = "Préstamos";
            this.Préstamos.Size = new System.Drawing.Size(251, 57);
            this.Préstamos.TabIndex = 5;
            this.Préstamos.Text = "Préstamos";
            // 
            // busquedal
            // 
            this.busquedal.AutoSize = true;
            this.busquedal.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedal.Location = new System.Drawing.Point(60, 76);
            this.busquedal.Name = "busquedal";
            this.busquedal.Size = new System.Drawing.Size(164, 24);
            this.busquedal.TabIndex = 6;
            this.busquedal.Text = "Búsqueda de libro";
            // 
            // busquedap
            // 
            this.busquedap.AutoSize = true;
            this.busquedap.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedap.Location = new System.Drawing.Point(830, 64);
            this.busquedap.Name = "busquedap";
            this.busquedap.Size = new System.Drawing.Size(197, 24);
            this.busquedap.TabIndex = 7;
            this.busquedap.Text = "Búsqueda de profesor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Préstamos activos de profesor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BuscarLibro
            // 
            this.BuscarLibro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarLibro.Location = new System.Drawing.Point(433, 121);
            this.BuscarLibro.Name = "BuscarLibro";
            this.BuscarLibro.Size = new System.Drawing.Size(135, 43);
            this.BuscarLibro.TabIndex = 9;
            this.BuscarLibro.Text = "Buscar";
            this.BuscarLibro.UseVisualStyleBackColor = true;
            this.BuscarLibro.Click += new System.EventHandler(this.BuscarLibro_Click);
            // 
            // buscarprofesor
            // 
            this.buscarprofesor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarprofesor.Location = new System.Drawing.Point(1212, 121);
            this.buscarprofesor.Name = "buscarprofesor";
            this.buscarprofesor.Size = new System.Drawing.Size(135, 43);
            this.buscarprofesor.TabIndex = 10;
            this.buscarprofesor.Text = "Buscar";
            this.buscarprofesor.UseVisualStyleBackColor = true;
            this.buscarprofesor.Click += new System.EventHandler(this.buscarprofesor_Click);
            // 
            // labelbusqueda
            // 
            this.labelbusqueda.AutoSize = true;
            this.labelbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbusqueda.Location = new System.Drawing.Point(61, 114);
            this.labelbusqueda.Name = "labelbusqueda";
            this.labelbusqueda.Size = new System.Drawing.Size(226, 20);
            this.labelbusqueda.TabIndex = 11;
            this.labelbusqueda.Text = "Frase o palabra de búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(830, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre o apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tblibro
            // 
            this.tblibro.Location = new System.Drawing.Point(64, 144);
            this.tblibro.Name = "tblibro";
            this.tblibro.Size = new System.Drawing.Size(300, 22);
            this.tblibro.TabIndex = 13;
            // 
            // tbprofesor
            // 
            this.tbprofesor.Location = new System.Drawing.Point(834, 144);
            this.tbprofesor.Name = "tbprofesor";
            this.tbprofesor.Size = new System.Drawing.Size(314, 22);
            this.tbprofesor.TabIndex = 14;
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.Location = new System.Drawing.Point(1039, 519);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(207, 20);
            this.labelfecha.TabIndex = 15;
            this.labelfecha.Text = "Fecha límite de devolución";
            // 
            // FrmPrestamoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 735);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.tbprofesor);
            this.Controls.Add(this.tblibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelbusqueda);
            this.Controls.Add(this.buscarprofesor);
            this.Controls.Add(this.BuscarLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busquedap);
            this.Controls.Add(this.busquedal);
            this.Controls.Add(this.Préstamos);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.PRESTAMO);
            this.Controls.Add(this.Prestamos);
            this.Controls.Add(this.Profesores);
            this.Controls.Add(this.Libros);
            this.Name = "FrmPrestamoLibro";
            this.Text = "FrmPrestamoLibro";
            this.Load += new System.EventHandler(this.FrmPrestamoLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Libros;
        private System.Windows.Forms.DataGridView Profesores;
        private System.Windows.Forms.DataGridView Prestamos;
        private System.Windows.Forms.Button PRESTAMO;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label Préstamos;
        private System.Windows.Forms.Label busquedal;
        private System.Windows.Forms.Label busquedap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarLibro;
        private System.Windows.Forms.Button buscarprofesor;
        private System.Windows.Forms.Label labelbusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tblibro;
        private System.Windows.Forms.TextBox tbprofesor;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
    }
}