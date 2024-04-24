namespace BISoft.Consultorio.Presentacion
{
    partial class Citas
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
            cmbClientes = new ComboBox();
            cmbDoctores = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dtgCitas = new DataGridView();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCitas).BeginInit();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(88, 32);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(233, 28);
            cmbClientes.TabIndex = 0;
            // 
            // cmbDoctores
            // 
            cmbDoctores.FormattingEnabled = true;
            cmbDoctores.Location = new Point(88, 66);
            cmbDoctores.Name = "cmbDoctores";
            cmbDoctores.Size = new Size(233, 28);
            cmbDoctores.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Doctor";
            // 
            // dtgCitas
            // 
            dtgCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCitas.Location = new Point(327, 32);
            dtgCitas.Name = "dtgCitas";
            dtgCitas.RowHeadersWidth = 51;
            dtgCitas.Size = new Size(407, 188);
            dtgCitas.TabIndex = 4;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(88, 100);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(233, 27);
            dtpFecha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Fecha";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(227, 191);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 235);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(dtpFecha);
            Controls.Add(dtgCitas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDoctores);
            Controls.Add(cmbClientes);
            Name = "Citas";
            Text = "Citas";
            Load += Citas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private ComboBox cmbDoctores;
        private Label label1;
        private Label label2;
        private DataGridView dtgCitas;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Button btnGuardar;
    }
}