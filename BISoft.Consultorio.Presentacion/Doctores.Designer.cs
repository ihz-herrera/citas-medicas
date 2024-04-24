namespace BISoft.Consultorio.Presentacion
{
    partial class Doctores
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
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCedula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(364, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(374, 216);
            dataGridView1.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(116, 204);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 142);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 17;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(121, 142);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(219, 27);
            txtTelefono.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 103);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 27);
            txtEmail.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 27);
            txtNombre.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 26);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 11;
            label1.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(121, 26);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(219, 27);
            txtCedula.TabIndex = 10;
            // 
            // Doctores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 271);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtCedula);
            Name = "Doctores";
            Text = "Doctores";
            Load += Doctores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Label label4;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCedula;
    }
}