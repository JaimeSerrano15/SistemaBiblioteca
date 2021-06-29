
namespace SistemaBiblioteca.Presentacion
{
    partial class FrmVideo
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
            this.TabGeneralVideo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvListadoVideos = new System.Windows.Forms.DataGridView();
            this.LblBuscarVideo = new System.Windows.Forms.Label();
            this.TxtBuscarVideo = new System.Windows.Forms.TextBox();
            this.BtnBuscarVideo = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChkSeleccionarVideo = new System.Windows.Forms.CheckBox();
            this.BtnEliminarVideo = new System.Windows.Forms.Button();
            this.LblTotalVideos = new System.Windows.Forms.Label();
            this.LblTítulo = new System.Windows.Forms.Label();
            this.LblDirector = new System.Windows.Forms.Label();
            this.LblProductora = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblAnio = new System.Windows.Forms.Label();
            this.LblDuracion = new System.Windows.Forms.Label();
            this.LblPais = new System.Windows.Forms.Label();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.LblSub = new System.Windows.Forms.Label();
            this.LblClasificacion = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.LblSinopsis = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.TxtDirector = new System.Windows.Forms.TextBox();
            this.txtProductora = new System.Windows.Forms.TextBox();
            this.TxtIdioma = new System.Windows.Forms.TextBox();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.TxtAnio = new System.Windows.Forms.TextBox();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.TxtSub = new System.Windows.Forms.TextBox();
            this.TxtClasificacion = new System.Windows.Forms.TextBox();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.TxtSinopsis = new System.Windows.Forms.TextBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.BtnInsertarVideo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.EpVideo = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnActualizarVideo = new System.Windows.Forms.Button();
            this.TxtCodigoVideo = new System.Windows.Forms.TextBox();
            this.TabGeneralVideo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoVideos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneralVideo
            // 
            this.TabGeneralVideo.Controls.Add(this.tabPage1);
            this.TabGeneralVideo.Controls.Add(this.tabPage2);
            this.TabGeneralVideo.Location = new System.Drawing.Point(12, 12);
            this.TabGeneralVideo.Name = "TabGeneralVideo";
            this.TabGeneralVideo.SelectedIndex = 0;
            this.TabGeneralVideo.Size = new System.Drawing.Size(1321, 573);
            this.TabGeneralVideo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.LblTotalVideos);
            this.tabPage1.Controls.Add(this.BtnEliminarVideo);
            this.tabPage1.Controls.Add(this.ChkSeleccionarVideo);
            this.tabPage1.Controls.Add(this.BtnBuscarVideo);
            this.tabPage1.Controls.Add(this.TxtBuscarVideo);
            this.tabPage1.Controls.Add(this.LblBuscarVideo);
            this.tabPage1.Controls.Add(this.DgvListadoVideos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1313, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage2.Controls.Add(this.TxtCodigoVideo);
            this.tabPage2.Controls.Add(this.BtnActualizarVideo);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertarVideo);
            this.tabPage2.Controls.Add(this.CmbTipo);
            this.tabPage2.Controls.Add(this.TxtSinopsis);
            this.tabPage2.Controls.Add(this.TxtUbicacion);
            this.tabPage2.Controls.Add(this.TxtGenero);
            this.tabPage2.Controls.Add(this.TxtClasificacion);
            this.tabPage2.Controls.Add(this.TxtSub);
            this.tabPage2.Controls.Add(this.TxtDuracion);
            this.tabPage2.Controls.Add(this.TxtAnio);
            this.tabPage2.Controls.Add(this.TxtPais);
            this.tabPage2.Controls.Add(this.TxtIdioma);
            this.tabPage2.Controls.Add(this.txtProductora);
            this.tabPage2.Controls.Add(this.TxtDirector);
            this.tabPage2.Controls.Add(this.txtTitulo);
            this.tabPage2.Controls.Add(this.LblSinopsis);
            this.tabPage2.Controls.Add(this.LblUbicacion);
            this.tabPage2.Controls.Add(this.LblGenero);
            this.tabPage2.Controls.Add(this.LblClasificacion);
            this.tabPage2.Controls.Add(this.LblSub);
            this.tabPage2.Controls.Add(this.LblIdioma);
            this.tabPage2.Controls.Add(this.LblPais);
            this.tabPage2.Controls.Add(this.LblDuracion);
            this.tabPage2.Controls.Add(this.LblAnio);
            this.tabPage2.Controls.Add(this.LblTipo);
            this.tabPage2.Controls.Add(this.LblProductora);
            this.tabPage2.Controls.Add(this.LblDirector);
            this.tabPage2.Controls.Add(this.LblTítulo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1313, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // DgvListadoVideos
            // 
            this.DgvListadoVideos.AllowUserToAddRows = false;
            this.DgvListadoVideos.AllowUserToDeleteRows = false;
            this.DgvListadoVideos.AllowUserToOrderColumns = true;
            this.DgvListadoVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoVideos.Location = new System.Drawing.Point(38, 96);
            this.DgvListadoVideos.Name = "DgvListadoVideos";
            this.DgvListadoVideos.ReadOnly = true;
            this.DgvListadoVideos.RowHeadersWidth = 51;
            this.DgvListadoVideos.RowTemplate.Height = 24;
            this.DgvListadoVideos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoVideos.Size = new System.Drawing.Size(1233, 375);
            this.DgvListadoVideos.TabIndex = 0;
            this.DgvListadoVideos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoVideos_CellContentClick);
            this.DgvListadoVideos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoVideos_CellDoubleClick);
            // 
            // LblBuscarVideo
            // 
            this.LblBuscarVideo.AutoSize = true;
            this.LblBuscarVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarVideo.Location = new System.Drawing.Point(33, 12);
            this.LblBuscarVideo.Name = "LblBuscarVideo";
            this.LblBuscarVideo.Size = new System.Drawing.Size(354, 28);
            this.LblBuscarVideo.TabIndex = 1;
            this.LblBuscarVideo.Text = "Búsqueda por Título o Código";
            // 
            // TxtBuscarVideo
            // 
            this.TxtBuscarVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarVideo.Location = new System.Drawing.Point(38, 53);
            this.TxtBuscarVideo.Name = "TxtBuscarVideo";
            this.TxtBuscarVideo.Size = new System.Drawing.Size(579, 31);
            this.TxtBuscarVideo.TabIndex = 2;
            // 
            // BtnBuscarVideo
            // 
            this.BtnBuscarVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarVideo.Location = new System.Drawing.Point(650, 52);
            this.BtnBuscarVideo.Name = "BtnBuscarVideo";
            this.BtnBuscarVideo.Size = new System.Drawing.Size(104, 31);
            this.BtnBuscarVideo.TabIndex = 3;
            this.BtnBuscarVideo.Text = "Buscar";
            this.BtnBuscarVideo.UseVisualStyleBackColor = true;
            this.BtnBuscarVideo.Click += new System.EventHandler(this.BtnBuscarVideo_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // ChkSeleccionarVideo
            // 
            this.ChkSeleccionarVideo.AutoSize = true;
            this.ChkSeleccionarVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSeleccionarVideo.Location = new System.Drawing.Point(38, 494);
            this.ChkSeleccionarVideo.Name = "ChkSeleccionarVideo";
            this.ChkSeleccionarVideo.Size = new System.Drawing.Size(148, 27);
            this.ChkSeleccionarVideo.TabIndex = 4;
            this.ChkSeleccionarVideo.Text = "Seleccionar";
            this.ChkSeleccionarVideo.UseVisualStyleBackColor = true;
            this.ChkSeleccionarVideo.CheckedChanged += new System.EventHandler(this.ChkSeleccionarVideo_CheckedChanged);
            // 
            // BtnEliminarVideo
            // 
            this.BtnEliminarVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVideo.Location = new System.Drawing.Point(229, 493);
            this.BtnEliminarVideo.Name = "BtnEliminarVideo";
            this.BtnEliminarVideo.Size = new System.Drawing.Size(114, 27);
            this.BtnEliminarVideo.TabIndex = 5;
            this.BtnEliminarVideo.Text = "Eliminar";
            this.BtnEliminarVideo.UseVisualStyleBackColor = true;
            this.BtnEliminarVideo.Click += new System.EventHandler(this.BtnEliminarVideo_Click);
            // 
            // LblTotalVideos
            // 
            this.LblTotalVideos.AutoSize = true;
            this.LblTotalVideos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalVideos.Location = new System.Drawing.Point(877, 494);
            this.LblTotalVideos.Name = "LblTotalVideos";
            this.LblTotalVideos.Size = new System.Drawing.Size(94, 32);
            this.LblTotalVideos.TabIndex = 6;
            this.LblTotalVideos.Text = "Total:";
            // 
            // LblTítulo
            // 
            this.LblTítulo.AutoSize = true;
            this.LblTítulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTítulo.Location = new System.Drawing.Point(45, 55);
            this.LblTítulo.Name = "LblTítulo";
            this.LblTítulo.Size = new System.Drawing.Size(64, 23);
            this.LblTítulo.TabIndex = 0;
            this.LblTítulo.Text = "Título";
            // 
            // LblDirector
            // 
            this.LblDirector.AutoSize = true;
            this.LblDirector.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirector.Location = new System.Drawing.Point(45, 107);
            this.LblDirector.Name = "LblDirector";
            this.LblDirector.Size = new System.Drawing.Size(91, 23);
            this.LblDirector.TabIndex = 1;
            this.LblDirector.Text = "Director";
            // 
            // LblProductora
            // 
            this.LblProductora.AutoSize = true;
            this.LblProductora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductora.Location = new System.Drawing.Point(45, 162);
            this.LblProductora.Name = "LblProductora";
            this.LblProductora.Size = new System.Drawing.Size(121, 23);
            this.LblProductora.TabIndex = 2;
            this.LblProductora.Text = "Productora";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(45, 211);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(53, 23);
            this.LblTipo.TabIndex = 3;
            this.LblTipo.Text = "Tipo";
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnio.Location = new System.Drawing.Point(45, 270);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(48, 23);
            this.LblAnio.TabIndex = 4;
            this.LblAnio.Text = "Año";
            // 
            // LblDuracion
            // 
            this.LblDuracion.AutoSize = true;
            this.LblDuracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracion.Location = new System.Drawing.Point(45, 319);
            this.LblDuracion.Name = "LblDuracion";
            this.LblDuracion.Size = new System.Drawing.Size(99, 23);
            this.LblDuracion.TabIndex = 5;
            this.LblDuracion.Text = "Duración";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.Location = new System.Drawing.Point(42, 372);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(51, 23);
            this.LblPais.TabIndex = 6;
            this.LblPais.Text = "País";
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdioma.Location = new System.Drawing.Point(580, 55);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(76, 23);
            this.LblIdioma.TabIndex = 7;
            this.LblIdioma.Text = "Idioma";
            // 
            // LblSub
            // 
            this.LblSub.AutoSize = true;
            this.LblSub.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSub.Location = new System.Drawing.Point(580, 107);
            this.LblSub.Name = "LblSub";
            this.LblSub.Size = new System.Drawing.Size(96, 23);
            this.LblSub.TabIndex = 8;
            this.LblSub.Text = "Subtítulo";
            // 
            // LblClasificacion
            // 
            this.LblClasificacion.AutoSize = true;
            this.LblClasificacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClasificacion.Location = new System.Drawing.Point(580, 162);
            this.LblClasificacion.Name = "LblClasificacion";
            this.LblClasificacion.Size = new System.Drawing.Size(135, 23);
            this.LblClasificacion.TabIndex = 9;
            this.LblClasificacion.Text = "Clasificación";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(580, 211);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(83, 23);
            this.LblGenero.TabIndex = 10;
            this.LblGenero.Text = "Género";
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUbicacion.Location = new System.Drawing.Point(580, 270);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(108, 23);
            this.LblUbicacion.TabIndex = 11;
            this.LblUbicacion.Text = "Ubicación";
            // 
            // LblSinopsis
            // 
            this.LblSinopsis.AutoSize = true;
            this.LblSinopsis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSinopsis.Location = new System.Drawing.Point(580, 319);
            this.LblSinopsis.Name = "LblSinopsis";
            this.LblSinopsis.Size = new System.Drawing.Size(92, 23);
            this.LblSinopsis.TabIndex = 12;
            this.LblSinopsis.Text = "Sinopsis";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(127, 52);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(315, 31);
            this.txtTitulo.TabIndex = 13;
            // 
            // TxtDirector
            // 
            this.TxtDirector.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirector.Location = new System.Drawing.Point(142, 104);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(300, 31);
            this.TxtDirector.TabIndex = 14;
            // 
            // txtProductora
            // 
            this.txtProductora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductora.Location = new System.Drawing.Point(172, 159);
            this.txtProductora.Name = "txtProductora";
            this.txtProductora.Size = new System.Drawing.Size(270, 31);
            this.txtProductora.TabIndex = 15;
            // 
            // TxtIdioma
            // 
            this.TxtIdioma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdioma.Location = new System.Drawing.Point(670, 52);
            this.TxtIdioma.Name = "TxtIdioma";
            this.TxtIdioma.Size = new System.Drawing.Size(355, 31);
            this.TxtIdioma.TabIndex = 16;
            // 
            // TxtPais
            // 
            this.TxtPais.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPais.Location = new System.Drawing.Point(127, 369);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(315, 31);
            this.TxtPais.TabIndex = 17;
            // 
            // TxtAnio
            // 
            this.TxtAnio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnio.Location = new System.Drawing.Point(127, 267);
            this.TxtAnio.Name = "TxtAnio";
            this.TxtAnio.Size = new System.Drawing.Size(315, 31);
            this.TxtAnio.TabIndex = 18;
            // 
            // TxtDuracion
            // 
            this.TxtDuracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDuracion.Location = new System.Drawing.Point(172, 316);
            this.TxtDuracion.Name = "TxtDuracion";
            this.TxtDuracion.Size = new System.Drawing.Size(270, 31);
            this.TxtDuracion.TabIndex = 19;
            // 
            // TxtSub
            // 
            this.TxtSub.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSub.Location = new System.Drawing.Point(693, 104);
            this.TxtSub.Name = "TxtSub";
            this.TxtSub.Size = new System.Drawing.Size(332, 31);
            this.TxtSub.TabIndex = 20;
            // 
            // TxtClasificacion
            // 
            this.TxtClasificacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClasificacion.Location = new System.Drawing.Point(721, 159);
            this.TxtClasificacion.Name = "TxtClasificacion";
            this.TxtClasificacion.Size = new System.Drawing.Size(304, 31);
            this.TxtClasificacion.TabIndex = 21;
            // 
            // TxtGenero
            // 
            this.TxtGenero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenero.Location = new System.Drawing.Point(693, 208);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(332, 31);
            this.TxtGenero.TabIndex = 22;
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUbicacion.Location = new System.Drawing.Point(693, 267);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(332, 31);
            this.TxtUbicacion.TabIndex = 23;
            // 
            // TxtSinopsis
            // 
            this.TxtSinopsis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSinopsis.Location = new System.Drawing.Point(693, 316);
            this.TxtSinopsis.Multiline = true;
            this.TxtSinopsis.Name = "TxtSinopsis";
            this.TxtSinopsis.Size = new System.Drawing.Size(434, 125);
            this.TxtSinopsis.TabIndex = 24;
            // 
            // CmbTipo
            // 
            this.CmbTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "DVD",
            "Blue-ray"});
            this.CmbTipo.Location = new System.Drawing.Point(142, 208);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(152, 31);
            this.CmbTipo.TabIndex = 25;
            // 
            // BtnInsertarVideo
            // 
            this.BtnInsertarVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertarVideo.Location = new System.Drawing.Point(759, 468);
            this.BtnInsertarVideo.Name = "BtnInsertarVideo";
            this.BtnInsertarVideo.Size = new System.Drawing.Size(100, 33);
            this.BtnInsertarVideo.TabIndex = 26;
            this.BtnInsertarVideo.Text = "Insertar";
            this.BtnInsertarVideo.UseVisualStyleBackColor = true;
            this.BtnInsertarVideo.Click += new System.EventHandler(this.BtnInsertarVideo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(930, 468);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(135, 33);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // EpVideo
            // 
            this.EpVideo.ContainerControl = this;
            // 
            // BtnActualizarVideo
            // 
            this.BtnActualizarVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarVideo.Location = new System.Drawing.Point(759, 468);
            this.BtnActualizarVideo.Name = "BtnActualizarVideo";
            this.BtnActualizarVideo.Size = new System.Drawing.Size(131, 33);
            this.BtnActualizarVideo.TabIndex = 28;
            this.BtnActualizarVideo.Text = "Actualizar";
            this.BtnActualizarVideo.UseVisualStyleBackColor = true;
            this.BtnActualizarVideo.Click += new System.EventHandler(this.BtnActualizarVideo_Click);
            // 
            // TxtCodigoVideo
            // 
            this.TxtCodigoVideo.Location = new System.Drawing.Point(127, 15);
            this.TxtCodigoVideo.Name = "TxtCodigoVideo";
            this.TxtCodigoVideo.Size = new System.Drawing.Size(100, 22);
            this.TxtCodigoVideo.TabIndex = 29;
            this.TxtCodigoVideo.Visible = false;
            // 
            // FrmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1345, 599);
            this.Controls.Add(this.TabGeneralVideo);
            this.Name = "FrmVideo";
            this.Text = "Videos";
            this.Load += new System.EventHandler(this.FrmVideo_Load);
            this.TabGeneralVideo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoVideos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneralVideo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvListadoVideos;
        private System.Windows.Forms.Label LblBuscarVideo;
        private System.Windows.Forms.TextBox TxtBuscarVideo;
        private System.Windows.Forms.Button BtnBuscarVideo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.CheckBox ChkSeleccionarVideo;
        private System.Windows.Forms.Button BtnEliminarVideo;
        private System.Windows.Forms.Label LblTotalVideos;
        private System.Windows.Forms.TextBox TxtSinopsis;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.TextBox TxtClasificacion;
        private System.Windows.Forms.TextBox TxtSub;
        private System.Windows.Forms.TextBox TxtDuracion;
        private System.Windows.Forms.TextBox TxtAnio;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.TextBox TxtIdioma;
        private System.Windows.Forms.TextBox txtProductora;
        private System.Windows.Forms.TextBox TxtDirector;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label LblSinopsis;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblClasificacion;
        private System.Windows.Forms.Label LblSub;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Label LblDuracion;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblProductora;
        private System.Windows.Forms.Label LblDirector;
        private System.Windows.Forms.Label LblTítulo;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertarVideo;
        private System.Windows.Forms.ErrorProvider EpVideo;
        private System.Windows.Forms.Button BtnActualizarVideo;
        private System.Windows.Forms.TextBox TxtCodigoVideo;
    }
}