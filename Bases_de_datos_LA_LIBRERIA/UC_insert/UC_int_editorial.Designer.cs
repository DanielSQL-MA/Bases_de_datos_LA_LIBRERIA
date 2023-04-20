namespace Bases_de_datos_LA_LIBRERIA.UC_insert
{
    partial class UC_int_editorial
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
            resultado = new Label();
            button1 = new Button();
            txteditorial = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resultado.ForeColor = SystemColors.HotTrack;
            resultado.Location = new Point(199, 277);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 24);
            resultado.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(433, 209);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txteditorial
            // 
            txteditorial.Location = new Point(3, 209);
            txteditorial.Name = "txteditorial";
            txteditorial.Size = new Size(410, 27);
            txteditorial.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 163);
            label1.Name = "label1";
            label1.Size = new Size(359, 24);
            label1.TabIndex = 4;
            label1.Text = "NOMBRE DE LA NUEVA EDITORIAL";
            // 
            // UC_int_editorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(resultado);
            Controls.Add(button1);
            Controls.Add(txteditorial);
            Controls.Add(label1);
            Name = "UC_int_editorial";
            Size = new Size(799, 657);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultado;
        private Button button1;
        private TextBox txteditorial;
        private Label label1;
    }
}
