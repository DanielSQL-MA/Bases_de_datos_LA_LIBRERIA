namespace Bases_de_datos_LA_LIBRERIA.UC_Buscar
{
    partial class UC_Buscar_Editorial
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
            dataEditorial = new DataGridView();
            btnBuscar = new Button();
            cbieditorial = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataEditorial).BeginInit();
            SuspendLayout();
            // 
            // dataEditorial
            // 
            dataEditorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEditorial.Location = new Point(30, 347);
            dataEditorial.Name = "dataEditorial";
            dataEditorial.RowHeadersWidth = 51;
            dataEditorial.RowTemplate.Height = 29;
            dataEditorial.Size = new Size(739, 87);
            dataEditorial.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(492, 284);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbieditorial
            // 
            cbieditorial.FormattingEnabled = true;
            cbieditorial.Location = new Point(92, 284);
            cbieditorial.Name = "cbieditorial";
            cbieditorial.Size = new Size(327, 28);
            cbieditorial.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(92, 223);
            label1.Name = "label1";
            label1.Size = new Size(270, 43);
            label1.TabIndex = 4;
            label1.Text = "Ingrese la ID";
            // 
            // UC_Buscar_Editorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(dataEditorial);
            Controls.Add(btnBuscar);
            Controls.Add(cbieditorial);
            Controls.Add(label1);
            Name = "UC_Buscar_Editorial";
            Size = new Size(799, 657);
            Load += UC_Buscar_Editorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataEditorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataEditorial;
        private Button btnBuscar;
        private ComboBox cbieditorial;
        private Label label1;
    }
}
