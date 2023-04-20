namespace Bases_de_datos_LA_LIBRERIA.UC_insert
{
    partial class UC_int_libros
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtnombre = new TextBox();
            label2 = new Label();
            cbo_Autor = new ComboBox();
            cbo_Editorial = new ComboBox();
            label3 = new Label();
            txtexistencia = new TextBox();
            label4 = new Label();
            txtanio = new TextBox();
            label5 = new Label();
            cbo_Genero = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Libro";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(21, 50);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(424, 27);
            txtnombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 97);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // cbo_Autor
            // 
            cbo_Autor.FormattingEnabled = true;
            cbo_Autor.Location = new Point(21, 129);
            cbo_Autor.Name = "cbo_Autor";
            cbo_Autor.Size = new Size(282, 28);
            cbo_Autor.TabIndex = 3;
            // 
            // cbo_Editorial
            // 
            cbo_Editorial.FormattingEnabled = true;
            cbo_Editorial.Location = new Point(21, 212);
            cbo_Editorial.Name = "cbo_Editorial";
            cbo_Editorial.Size = new Size(282, 28);
            cbo_Editorial.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 180);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Editorial";
            // 
            // txtexistencia
            // 
            txtexistencia.Location = new Point(21, 297);
            txtexistencia.Name = "txtexistencia";
            txtexistencia.Size = new Size(424, 27);
            txtexistencia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 261);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Existencia";
            // 
            // txtanio
            // 
            txtanio.Location = new Point(21, 391);
            txtanio.Name = "txtanio";
            txtanio.Size = new Size(424, 27);
            txtanio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Location = new Point(21, 355);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 8;
            label5.Text = "Año de Publicacion";
            // 
            // cbo_Genero
            // 
            cbo_Genero.FormattingEnabled = true;
            cbo_Genero.Location = new Point(21, 484);
            cbo_Genero.Name = "cbo_Genero";
            cbo_Genero.Size = new Size(282, 28);
            cbo_Genero.TabIndex = 11;
            cbo_Genero.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 452);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 10;
            label6.Text = "Genero";
            // 
            // button1
            // 
            button1.Location = new Point(648, 556);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UC_int_libros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(button1);
            Controls.Add(cbo_Genero);
            Controls.Add(label6);
            Controls.Add(txtanio);
            Controls.Add(label5);
            Controls.Add(txtexistencia);
            Controls.Add(label4);
            Controls.Add(cbo_Editorial);
            Controls.Add(label3);
            Controls.Add(cbo_Autor);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Name = "UC_int_libros";
            Size = new Size(799, 657);
            Load += UC_int_libros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnombre;
        private Label label2;
        private ComboBox cbo_Autor;
        private ComboBox cbo_Editorial;
        private Label label3;
        private TextBox txtexistencia;
        private Label label4;
        private TextBox txtanio;
        private Label label5;
        private ComboBox cbo_Genero;
        private Label label6;
        private Button button1;
    }
}
