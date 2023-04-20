namespace Bases_de_datos_LA_LIBRERIA.UC_Buscar
{
    partial class UC_Buscar_Autor
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
            dgvautor = new DataGridView();
            btnbuscar = new Button();
            cbidautor = new ComboBox();
            label2 = new Label();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvautor).BeginInit();
            SuspendLayout();
            // 
            // dgvautor
            // 
            dgvautor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvautor.Location = new Point(30, 347);
            dgvautor.Name = "dgvautor";
            dgvautor.RowHeadersWidth = 51;
            dgvautor.RowTemplate.Height = 29;
            dgvautor.Size = new Size(739, 87);
            dgvautor.TabIndex = 7;
            // 
            // btnbuscar
            // 
            btnbuscar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.Location = new Point(467, 284);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 6;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // cbidautor
            // 
            cbidautor.FormattingEnabled = true;
            cbidautor.Location = new Point(92, 284);
            cbidautor.Name = "cbidautor";
            cbidautor.Size = new Size(327, 28);
            cbidautor.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(92, 223);
            label2.Name = "label2";
            label2.Size = new Size(270, 43);
            label2.TabIndex = 4;
            label2.Text = "Ingrese la ID";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(111, 477);
            label.Name = "label";
            label.Size = new Size(50, 20);
            label.TabIndex = 8;
            label.Text = "label1";
            // 
            // UC_Buscar_Autor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(label);
            Controls.Add(dgvautor);
            Controls.Add(btnbuscar);
            Controls.Add(cbidautor);
            Controls.Add(label2);
            Name = "UC_Buscar_Autor";
            Size = new Size(799, 657);
            Load += UC_Buscar_Autor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvautor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvautor;
        private Button btnbuscar;
        private ComboBox cbidautor;
        private Label label2;
        private Label label;
    }
}
