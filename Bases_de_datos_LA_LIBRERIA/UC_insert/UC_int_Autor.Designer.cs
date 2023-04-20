namespace Bases_de_datos_LA_LIBRERIA.UC_insert
{
    partial class UC_int_Autor
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
            txtautor = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 163);
            label1.Name = "label1";
            label1.Size = new Size(297, 24);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE DEL NUEVO AUTOR";
            // 
            // txtautor
            // 
            txtautor.Location = new Point(3, 209);
            txtautor.Name = "txtautor";
            txtautor.Size = new Size(410, 27);
            txtautor.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(433, 209);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UC_int_Autor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(button1);
            Controls.Add(txtautor);
            Controls.Add(label1);
            Name = "UC_int_Autor";
            Size = new Size(799, 657);
            Load += UC_int_Autor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtautor;
        private Button button1;
    }
}
