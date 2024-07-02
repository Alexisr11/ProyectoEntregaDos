namespace Farmacia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txtCantidad = new TextBox();
            cbTipo = new ComboBox();
            txtNombreMedicamento = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rdCom = new RadioButton();
            rdEmp = new RadioButton();
            rdCofarma = new RadioButton();
            groupBox3 = new GroupBox();
            ckSucursal = new CheckBox();
            ckPrincipal = new CheckBox();
            panel2 = new Panel();
            btnLimpiar = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 138);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(txtNombreMedicamento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 149);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Principales";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(200, 106);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(169, 23);
            txtCantidad.TabIndex = 12;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(200, 66);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(169, 23);
            cbTipo.TabIndex = 11;
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new Point(201, 22);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new Size(168, 23);
            txtNombreMedicamento.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 110);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 70);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 8;
            label2.Text = "Tipo de Medicamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre de Medicamentos: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdCom);
            groupBox2.Controls.Add(rdEmp);
            groupBox2.Controls.Add(rdCofarma);
            groupBox2.Location = new Point(14, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 115);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Distribuidor";
            // 
            // rdCom
            // 
            rdCom.AutoSize = true;
            rdCom.Location = new Point(13, 81);
            rdCom.Name = "rdCom";
            rdCom.Size = new Size(71, 19);
            rdCom.TabIndex = 2;
            rdCom.TabStop = true;
            rdCom.Text = "Comefar";
            rdCom.UseVisualStyleBackColor = true;
            // 
            // rdEmp
            // 
            rdEmp.AutoSize = true;
            rdEmp.Location = new Point(13, 56);
            rdEmp.Name = "rdEmp";
            rdEmp.Size = new Size(84, 19);
            rdEmp.TabIndex = 1;
            rdEmp.TabStop = true;
            rdEmp.Text = "Empsephar";
            rdEmp.UseVisualStyleBackColor = true;
            // 
            // rdCofarma
            // 
            rdCofarma.AutoSize = true;
            rdCofarma.Location = new Point(13, 31);
            rdCofarma.Name = "rdCofarma";
            rdCofarma.Size = new Size(71, 19);
            rdCofarma.TabIndex = 0;
            rdCofarma.TabStop = true;
            rdCofarma.Text = "Cofarma";
            rdCofarma.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ckSucursal);
            groupBox3.Controls.Add(ckPrincipal);
            groupBox3.Location = new Point(262, 325);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(168, 115);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sucursal";
            // 
            // ckSucursal
            // 
            ckSucursal.AutoSize = true;
            ckSucursal.Location = new Point(20, 68);
            ckSucursal.Name = "ckSucursal";
            ckSucursal.Size = new Size(85, 19);
            ckSucursal.TabIndex = 1;
            ckSucursal.Text = "Sucundaria";
            ckSucursal.UseVisualStyleBackColor = true;
            // 
            // ckPrincipal
            // 
            ckPrincipal.AutoSize = true;
            ckPrincipal.Location = new Point(20, 31);
            ckPrincipal.Name = "ckPrincipal";
            ckPrincipal.Size = new Size(72, 19);
            ckPrincipal.TabIndex = 0;
            ckPrincipal.Text = "Principal";
            ckPrincipal.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 446);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 60);
            panel2.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(355, 20);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 501);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtCantidad;
        private ComboBox cbTipo;
        private TextBox txtNombreMedicamento;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rdCom;
        private RadioButton rdEmp;
        private RadioButton rdCofarma;
        private CheckBox ckSucursal;
        private CheckBox ckPrincipal;
        private Panel panel2;
        private Button btnLimpiar;
        private Button button1;
    }
}
