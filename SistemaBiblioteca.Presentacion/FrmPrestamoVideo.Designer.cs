
namespace SistemaBiblioteca.Presentacion
{
    partial class FrmPrestamoVideo
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
            this.dgvVideos = new System.Windows.Forms.DataGridView();
            this.SeleccionarVideo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.dgvPrestamosVideos = new System.Windows.Forms.DataGridView();
            this.lbPrestamos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVideos = new System.Windows.Forms.TextBox();
            this.txProfesor = new System.Windows.Forms.TextBox();
            this.btnBuscarVideo = new System.Windows.Forms.Button();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SeleccionarProfesor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVideos
            // 
            this.dgvVideos.AllowUserToAddRows = false;
            this.dgvVideos.AllowUserToDeleteRows = false;
            this.dgvVideos.AllowUserToOrderColumns = true;
            this.dgvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarVideo});
            this.dgvVideos.Location = new System.Drawing.Point(40, 216);
            this.dgvVideos.Name = "dgvVideos";
            this.dgvVideos.ReadOnly = true;
            this.dgvVideos.RowHeadersWidth = 51;
            this.dgvVideos.RowTemplate.Height = 24;
            this.dgvVideos.Size = new System.Drawing.Size(636, 247);
            this.dgvVideos.TabIndex = 0;
            this.dgvVideos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVideos_CellContentClick);
            // 
            // SeleccionarVideo
            // 
            this.SeleccionarVideo.HeaderText = "Seleccionar";
            this.SeleccionarVideo.MinimumWidth = 6;
            this.SeleccionarVideo.Name = "SeleccionarVideo";
            this.SeleccionarVideo.ReadOnly = true;
            this.SeleccionarVideo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeleccionarVideo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SeleccionarVideo.Width = 125;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.AllowUserToAddRows = false;
            this.dgvProfesores.AllowUserToDeleteRows = false;
            this.dgvProfesores.AllowUserToOrderColumns = true;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarProfesor});
            this.dgvProfesores.Location = new System.Drawing.Point(780, 216);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.ReadOnly = true;
            this.dgvProfesores.RowHeadersWidth = 51;
            this.dgvProfesores.RowTemplate.Height = 24;
            this.dgvProfesores.Size = new System.Drawing.Size(644, 247);
            this.dgvProfesores.TabIndex = 1;
            this.dgvProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellContentClick);
            // 
            // dgvPrestamosVideos
            // 
            this.dgvPrestamosVideos.AllowUserToAddRows = false;
            this.dgvPrestamosVideos.AllowUserToDeleteRows = false;
            this.dgvPrestamosVideos.AllowUserToOrderColumns = true;
            this.dgvPrestamosVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosVideos.Location = new System.Drawing.Point(40, 532);
            this.dgvPrestamosVideos.Name = "dgvPrestamosVideos";
            this.dgvPrestamosVideos.ReadOnly = true;
            this.dgvPrestamosVideos.RowHeadersWidth = 51;
            this.dgvPrestamosVideos.RowTemplate.Height = 24;
            this.dgvPrestamosVideos.Size = new System.Drawing.Size(869, 171);
            this.dgvPrestamosVideos.TabIndex = 2;
            // 
            // lbPrestamos
            // 
            this.lbPrestamos.AutoSize = true;
            this.lbPrestamos.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrestamos.Location = new System.Drawing.Point(644, 27);
            this.lbPrestamos.Name = "lbPrestamos";
            this.lbPrestamos.Size = new System.Drawing.Size(234, 52);
            this.lbPrestamos.TabIndex = 3;
            this.lbPrestamos.Text = "Préstamos";
            this.lbPrestamos.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Búsqueda de Video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(776, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Búsqueda de profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frase o palabra de búsqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre o apellido";
            // 
            // tbVideos
            // 
            this.tbVideos.Location = new System.Drawing.Point(40, 166);
            this.tbVideos.Name = "tbVideos";
            this.tbVideos.Size = new System.Drawing.Size(378, 22);
            this.tbVideos.TabIndex = 8;
            // 
            // txProfesor
            // 
            this.txProfesor.Location = new System.Drawing.Point(780, 166);
            this.txProfesor.Name = "txProfesor";
            this.txProfesor.Size = new System.Drawing.Size(378, 22);
            this.txProfesor.TabIndex = 9;
            // 
            // btnBuscarVideo
            // 
            this.btnBuscarVideo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVideo.Location = new System.Drawing.Point(497, 145);
            this.btnBuscarVideo.Name = "btnBuscarVideo";
            this.btnBuscarVideo.Size = new System.Drawing.Size(135, 43);
            this.btnBuscarVideo.TabIndex = 10;
            this.btnBuscarVideo.Text = "Buscar";
            this.btnBuscarVideo.UseVisualStyleBackColor = true;
            this.btnBuscarVideo.Click += new System.EventHandler(this.btnBuscarVideo_Click);
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProfesor.Location = new System.Drawing.Point(1229, 145);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(135, 43);
            this.btnBuscarProfesor.TabIndex = 11;
            this.btnBuscarProfesor.Text = "Buscar";
            this.btnBuscarProfesor.UseVisualStyleBackColor = true;
            this.btnBuscarProfesor.Click += new System.EventHandler(this.btnBuscarProfesor_Click);
            // 
            // datePick
            // 
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Location = new System.Drawing.Point(1019, 541);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(251, 27);
            this.datePick.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1015, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha límite de devolución";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(1019, 628);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(273, 75);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar Préstamo";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // SeleccionarProfesor
            // 
            this.SeleccionarProfesor.HeaderText = "Seleccionar";
            this.SeleccionarProfesor.MinimumWidth = 6;
            this.SeleccionarProfesor.Name = "SeleccionarProfesor";
            this.SeleccionarProfesor.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Préstamos activos de profesor";
            // 
            // FrmPrestamoVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 732);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.btnBuscarProfesor);
            this.Controls.Add(this.btnBuscarVideo);
            this.Controls.Add(this.txProfesor);
            this.Controls.Add(this.tbVideos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrestamos);
            this.Controls.Add(this.dgvPrestamosVideos);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.dgvVideos);
            this.Name = "FrmPrestamoVideo";
            this.Text = "FrmPrestamoVideo";
            this.Load += new System.EventHandler(this.FrmPrestamoVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideos;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.DataGridView dgvPrestamosVideos;
        private System.Windows.Forms.Label lbPrestamos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVideos;
        private System.Windows.Forms.TextBox txProfesor;
        private System.Windows.Forms.Button btnBuscarVideo;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarProfesor;
        private System.Windows.Forms.Label label6;
    }
}