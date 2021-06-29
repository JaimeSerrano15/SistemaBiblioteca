
namespace SistemaBiblioteca.Presentacion
{
    partial class FrmLibro
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
            this.components = new System.ComponentModel.Container();
            this.tabGeneralLibro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnEliminarLibro = new System.Windows.Forms.Button();
            this.ChkSeleccionarLibro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarLibro = new System.Windows.Forms.Button();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.lblTotalLibro = new System.Windows.Forms.Label();
            this.DgvListadoLibro = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtEjemplares = new System.Windows.Forms.TextBox();
            this.BtnLibroCancelar = new System.Windows.Forms.Button();
            this.BtnInsertarLibro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.TxtPaginas = new System.Windows.Forms.TextBox();
            this.TxtMateriaa = new System.Windows.Forms.TextBox();
            this.TxtIdioma = new System.Windows.Forms.TextBox();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.TxtEdicion = new System.Windows.Forms.TextBox();
            this.TxtAEdicion = new System.Windows.Forms.TextBox();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.LblPaginas = new System.Windows.Forms.Label();
            this.LblMateria = new System.Windows.Forms.Label();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.LblPais = new System.Windows.Forms.Label();
            this.LblEdicion = new System.Windows.Forms.Label();
            this.LblAEdicion = new System.Windows.Forms.Label();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblIsbn = new System.Windows.Forms.Label();
            this.LblEjemplares = new System.Windows.Forms.Label();
            this.EpLibro = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabGeneralLibro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoLibro)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneralLibro
            // 
            this.tabGeneralLibro.Controls.Add(this.tabPage1);
            this.tabGeneralLibro.Controls.Add(this.tabPage2);
            this.tabGeneralLibro.Location = new System.Drawing.Point(12, 12);
            this.tabGeneralLibro.Name = "tabGeneralLibro";
            this.tabGeneralLibro.SelectedIndex = 0;
            this.tabGeneralLibro.Size = new System.Drawing.Size(1316, 581);
            this.tabGeneralLibro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Sienna;
            this.tabPage1.Controls.Add(this.BtnEliminarLibro);
            this.tabPage1.Controls.Add(this.ChkSeleccionarLibro);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BtnBuscarLibro);
            this.tabPage1.Controls.Add(this.txtBuscarLibro);
            this.tabPage1.Controls.Add(this.lblTotalLibro);
            this.tabPage1.Controls.Add(this.DgvListadoLibro);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1308, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            // 
            // BtnEliminarLibro
            // 
            this.BtnEliminarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarLibro.Location = new System.Drawing.Point(230, 517);
            this.BtnEliminarLibro.Name = "BtnEliminarLibro";
            this.BtnEliminarLibro.Size = new System.Drawing.Size(105, 27);
            this.BtnEliminarLibro.TabIndex = 6;
            this.BtnEliminarLibro.Text = "Eliminar";
            this.BtnEliminarLibro.UseVisualStyleBackColor = true;
            this.BtnEliminarLibro.Click += new System.EventHandler(this.BtnEliminarLibro_Click);
            // 
            // ChkSeleccionarLibro
            // 
            this.ChkSeleccionarLibro.AutoSize = true;
            this.ChkSeleccionarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSeleccionarLibro.Location = new System.Drawing.Point(30, 517);
            this.ChkSeleccionarLibro.Name = "ChkSeleccionarLibro";
            this.ChkSeleccionarLibro.Size = new System.Drawing.Size(148, 27);
            this.ChkSeleccionarLibro.TabIndex = 5;
            this.ChkSeleccionarLibro.Text = "Seleccionar";
            this.ChkSeleccionarLibro.UseVisualStyleBackColor = true;
            this.ChkSeleccionarLibro.CheckedChanged += new System.EventHandler(this.ChkSeleccionarLibro_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Búsqueda por título o código";
            // 
            // BtnBuscarLibro
            // 
            this.BtnBuscarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarLibro.Location = new System.Drawing.Point(645, 48);
            this.BtnBuscarLibro.Name = "BtnBuscarLibro";
            this.BtnBuscarLibro.Size = new System.Drawing.Size(99, 32);
            this.BtnBuscarLibro.TabIndex = 3;
            this.BtnBuscarLibro.Text = "Buscar";
            this.BtnBuscarLibro.UseVisualStyleBackColor = true;
            this.BtnBuscarLibro.Click += new System.EventHandler(this.BtnBuscarLibro_Click);
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLibro.Location = new System.Drawing.Point(30, 48);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(593, 31);
            this.txtBuscarLibro.TabIndex = 2;
            // 
            // lblTotalLibro
            // 
            this.lblTotalLibro.AutoSize = true;
            this.lblTotalLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLibro.Location = new System.Drawing.Point(905, 517);
            this.lblTotalLibro.Name = "lblTotalLibro";
            this.lblTotalLibro.Size = new System.Drawing.Size(94, 32);
            this.lblTotalLibro.TabIndex = 1;
            this.lblTotalLibro.Text = "Total:";
            // 
            // DgvListadoLibro
            // 
            this.DgvListadoLibro.AllowUserToAddRows = false;
            this.DgvListadoLibro.AllowUserToDeleteRows = false;
            this.DgvListadoLibro.AllowUserToOrderColumns = true;
            this.DgvListadoLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoLibro.Location = new System.Drawing.Point(30, 86);
            this.DgvListadoLibro.Name = "DgvListadoLibro";
            this.DgvListadoLibro.ReadOnly = true;
            this.DgvListadoLibro.RowHeadersWidth = 51;
            this.DgvListadoLibro.RowTemplate.Height = 24;
            this.DgvListadoLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoLibro.Size = new System.Drawing.Size(1248, 412);
            this.DgvListadoLibro.TabIndex = 0;
            this.DgvListadoLibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoLibro_CellContentClick);
            this.DgvListadoLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoLibro_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Sienna;
            this.tabPage2.Controls.Add(this.txtCodigoLibro);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.TxtEjemplares);
            this.tabPage2.Controls.Add(this.BtnLibroCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertarLibro);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.TxtUbicacion);
            this.tabPage2.Controls.Add(this.TxtPaginas);
            this.tabPage2.Controls.Add(this.TxtMateriaa);
            this.tabPage2.Controls.Add(this.TxtIdioma);
            this.tabPage2.Controls.Add(this.TxtPais);
            this.tabPage2.Controls.Add(this.TxtEdicion);
            this.tabPage2.Controls.Add(this.TxtAEdicion);
            this.tabPage2.Controls.Add(this.TxtEditorial);
            this.tabPage2.Controls.Add(this.TxtAutor);
            this.tabPage2.Controls.Add(this.TxtTitulo);
            this.tabPage2.Controls.Add(this.TxtIsbn);
            this.tabPage2.Controls.Add(this.LblDescripcion);
            this.tabPage2.Controls.Add(this.LblUbicacion);
            this.tabPage2.Controls.Add(this.LblPaginas);
            this.tabPage2.Controls.Add(this.LblMateria);
            this.tabPage2.Controls.Add(this.LblIdioma);
            this.tabPage2.Controls.Add(this.LblPais);
            this.tabPage2.Controls.Add(this.LblEdicion);
            this.tabPage2.Controls.Add(this.LblAEdicion);
            this.tabPage2.Controls.Add(this.LblEditorial);
            this.tabPage2.Controls.Add(this.LblAutor);
            this.tabPage2.Controls.Add(this.LblTitulo);
            this.tabPage2.Controls.Add(this.LblIsbn);
            this.tabPage2.Controls.Add(this.LblEjemplares);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1308, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLibro.Location = new System.Drawing.Point(29, 47);
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(134, 27);
            this.txtCodigoLibro.TabIndex = 31;
            this.txtCodigoLibro.Visible = false;
            this.txtCodigoLibro.WordWrap = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(734, 478);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(137, 38);
            this.BtnActualizar.TabIndex = 30;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtEjemplares
            // 
            this.TxtEjemplares.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEjemplares.Location = new System.Drawing.Point(240, 89);
            this.TxtEjemplares.Name = "TxtEjemplares";
            this.TxtEjemplares.Size = new System.Drawing.Size(90, 27);
            this.TxtEjemplares.TabIndex = 29;
            // 
            // BtnLibroCancelar
            // 
            this.BtnLibroCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibroCancelar.Location = new System.Drawing.Point(936, 478);
            this.BtnLibroCancelar.Name = "BtnLibroCancelar";
            this.BtnLibroCancelar.Size = new System.Drawing.Size(130, 38);
            this.BtnLibroCancelar.TabIndex = 28;
            this.BtnLibroCancelar.Text = "Cancelar";
            this.BtnLibroCancelar.UseVisualStyleBackColor = true;
            this.BtnLibroCancelar.Click += new System.EventHandler(this.BtnLibroCancelar_Click);
            // 
            // BtnInsertarLibro
            // 
            this.BtnInsertarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertarLibro.Location = new System.Drawing.Point(734, 478);
            this.BtnInsertarLibro.Name = "BtnInsertarLibro";
            this.BtnInsertarLibro.Size = new System.Drawing.Size(122, 38);
            this.BtnInsertarLibro.TabIndex = 27;
            this.BtnInsertarLibro.Text = "Insertar";
            this.BtnInsertarLibro.UseVisualStyleBackColor = true;
            this.BtnInsertarLibro.Click += new System.EventHandler(this.BtnInsertarLibro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(1176, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(627, 296);
            this.TxtDescripcion.MaxLength = 255;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(520, 152);
            this.TxtDescripcion.TabIndex = 25;
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUbicacion.Location = new System.Drawing.Point(822, 225);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(280, 27);
            this.TxtUbicacion.TabIndex = 24;
            // 
            // TxtPaginas
            // 
            this.TxtPaginas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaginas.Location = new System.Drawing.Point(898, 183);
            this.TxtPaginas.Name = "TxtPaginas";
            this.TxtPaginas.Size = new System.Drawing.Size(204, 27);
            this.TxtPaginas.TabIndex = 23;
            // 
            // TxtMateriaa
            // 
            this.TxtMateriaa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMateriaa.Location = new System.Drawing.Point(798, 137);
            this.TxtMateriaa.Name = "TxtMateriaa";
            this.TxtMateriaa.Size = new System.Drawing.Size(304, 27);
            this.TxtMateriaa.TabIndex = 22;
            // 
            // TxtIdioma
            // 
            this.TxtIdioma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdioma.Location = new System.Drawing.Point(114, 450);
            this.TxtIdioma.Name = "TxtIdioma";
            this.TxtIdioma.Size = new System.Drawing.Size(295, 27);
            this.TxtIdioma.TabIndex = 21;
            // 
            // TxtPais
            // 
            this.TxtPais.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPais.Location = new System.Drawing.Point(114, 408);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(295, 27);
            this.TxtPais.TabIndex = 20;
            // 
            // TxtEdicion
            // 
            this.TxtEdicion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdicion.Location = new System.Drawing.Point(114, 364);
            this.TxtEdicion.Name = "TxtEdicion";
            this.TxtEdicion.Size = new System.Drawing.Size(295, 27);
            this.TxtEdicion.TabIndex = 19;
            // 
            // TxtAEdicion
            // 
            this.TxtAEdicion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAEdicion.Location = new System.Drawing.Point(180, 321);
            this.TxtAEdicion.Name = "TxtAEdicion";
            this.TxtAEdicion.Size = new System.Drawing.Size(150, 27);
            this.TxtAEdicion.TabIndex = 18;
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditorial.Location = new System.Drawing.Point(124, 275);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(458, 27);
            this.TxtEditorial.TabIndex = 17;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.Location = new System.Drawing.Point(124, 229);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(458, 27);
            this.TxtAutor.TabIndex = 16;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(124, 183);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(458, 27);
            this.TxtTitulo.TabIndex = 15;
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsbn.Location = new System.Drawing.Point(124, 137);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(458, 27);
            this.TxtIsbn.TabIndex = 14;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.SandyBrown;
            this.LblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(627, 270);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(111, 22);
            this.LblDescripcion.TabIndex = 12;
            this.LblDescripcion.Text = "Descripción";
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.BackColor = System.Drawing.Color.SandyBrown;
            this.LblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblUbicacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUbicacion.Location = new System.Drawing.Point(700, 228);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(95, 22);
            this.LblUbicacion.TabIndex = 11;
            this.LblUbicacion.Text = "Ubicación";
            // 
            // LblPaginas
            // 
            this.LblPaginas.AutoSize = true;
            this.LblPaginas.BackColor = System.Drawing.Color.SandyBrown;
            this.LblPaginas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPaginas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaginas.Location = new System.Drawing.Point(700, 186);
            this.LblPaginas.Name = "LblPaginas";
            this.LblPaginas.Size = new System.Drawing.Size(171, 22);
            this.LblPaginas.TabIndex = 10;
            this.LblPaginas.Text = "Número de Páginas";
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.BackColor = System.Drawing.Color.SandyBrown;
            this.LblMateria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMateria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMateria.Location = new System.Drawing.Point(700, 140);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(73, 22);
            this.LblMateria.TabIndex = 9;
            this.LblMateria.Text = "Materia";
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.BackColor = System.Drawing.Color.SandyBrown;
            this.LblIdioma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdioma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdioma.Location = new System.Drawing.Point(28, 453);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(67, 22);
            this.LblIdioma.TabIndex = 8;
            this.LblIdioma.Text = "Idioma";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.BackColor = System.Drawing.Color.SandyBrown;
            this.LblPais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPais.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.Location = new System.Drawing.Point(29, 411);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(46, 22);
            this.LblPais.TabIndex = 7;
            this.LblPais.Text = "País";
            // 
            // LblEdicion
            // 
            this.LblEdicion.AutoSize = true;
            this.LblEdicion.BackColor = System.Drawing.Color.SandyBrown;
            this.LblEdicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEdicion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdicion.Location = new System.Drawing.Point(29, 367);
            this.LblEdicion.Name = "LblEdicion";
            this.LblEdicion.Size = new System.Drawing.Size(73, 22);
            this.LblEdicion.TabIndex = 6;
            this.LblEdicion.Text = "Edición";
            // 
            // LblAEdicion
            // 
            this.LblAEdicion.AutoSize = true;
            this.LblAEdicion.BackColor = System.Drawing.Color.SandyBrown;
            this.LblAEdicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAEdicion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAEdicion.Location = new System.Drawing.Point(29, 324);
            this.LblAEdicion.Name = "LblAEdicion";
            this.LblAEdicion.Size = new System.Drawing.Size(134, 22);
            this.LblAEdicion.TabIndex = 5;
            this.LblAEdicion.Text = "Año de Edición";
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.BackColor = System.Drawing.Color.SandyBrown;
            this.LblEditorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEditorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditorial.Location = new System.Drawing.Point(29, 275);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(81, 22);
            this.LblEditorial.TabIndex = 4;
            this.LblEditorial.Text = "Editorial";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.BackColor = System.Drawing.Color.SandyBrown;
            this.LblAutor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Location = new System.Drawing.Point(29, 230);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(56, 22);
            this.LblAutor.TabIndex = 3;
            this.LblAutor.Text = "Autor";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.SandyBrown;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(29, 184);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(58, 22);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Título";
            // 
            // LblIsbn
            // 
            this.LblIsbn.AutoSize = true;
            this.LblIsbn.BackColor = System.Drawing.Color.SandyBrown;
            this.LblIsbn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIsbn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsbn.Location = new System.Drawing.Point(29, 138);
            this.LblIsbn.Name = "LblIsbn";
            this.LblIsbn.Size = new System.Drawing.Size(52, 22);
            this.LblIsbn.TabIndex = 1;
            this.LblIsbn.Text = "ISBN";
            // 
            // LblEjemplares
            // 
            this.LblEjemplares.AutoSize = true;
            this.LblEjemplares.BackColor = System.Drawing.Color.SandyBrown;
            this.LblEjemplares.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEjemplares.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEjemplares.Location = new System.Drawing.Point(29, 92);
            this.LblEjemplares.Name = "LblEjemplares";
            this.LblEjemplares.Size = new System.Drawing.Size(198, 22);
            this.LblEjemplares.TabIndex = 0;
            this.LblEjemplares.Text = "Número de Ejemplares";
            // 
            // EpLibro
            // 
            this.EpLibro.ContainerControl = this;
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1340, 599);
            this.Controls.Add(this.tabGeneralLibro);
            this.Name = "FrmLibro";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            this.tabGeneralLibro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoLibro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneralLibro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvListadoLibro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTotalLibro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscarLibro;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.Label LblPaginas;
        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Label LblEdicion;
        private System.Windows.Forms.Label LblAEdicion;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblIsbn;
        private System.Windows.Forms.Label LblEjemplares;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.TextBox TxtPaginas;
        private System.Windows.Forms.TextBox TxtMateriaa;
        private System.Windows.Forms.TextBox TxtIdioma;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.TextBox TxtEdicion;
        private System.Windows.Forms.TextBox TxtAEdicion;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLibroCancelar;
        private System.Windows.Forms.Button BtnInsertarLibro;
        private System.Windows.Forms.TextBox TxtEjemplares;
        private System.Windows.Forms.ErrorProvider EpLibro;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox txtCodigoLibro;
        private System.Windows.Forms.Button BtnEliminarLibro;
        private System.Windows.Forms.CheckBox ChkSeleccionarLibro;
    }
}