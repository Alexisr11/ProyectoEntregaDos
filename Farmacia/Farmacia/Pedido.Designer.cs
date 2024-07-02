namespace Farmacia
{
    partial class Pedido
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
            label1 = new Label();
            panel1 = new Panel();
            lbSucursal = new Label();
            label12 = new Label();
            lbDistribuidor = new Label();
            label9 = new Label();
            label8 = new Label();
            lbCantidad = new Label();
            label6 = new Label();
            lbTipoM = new Label();
            label4 = new Label();
            lbNombreM = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Confirmacion de Pedido:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbSucursal);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(lbDistribuidor);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lbCantidad);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbTipoM);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbNombreM);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(44, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 337);
            panel1.TabIndex = 1;
            // 
            // lbSucursal
            // 
            lbSucursal.AutoSize = true;
            lbSucursal.Location = new Point(3, 291);
            lbSucursal.Name = "lbSucursal";
            lbSucursal.Size = new Size(44, 15);
            lbSucursal.TabIndex = 11;
            lbSucursal.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 265);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 10;
            label12.Text = "Sucursal :";
            // 
            // lbDistribuidor
            // 
            lbDistribuidor.AutoSize = true;
            lbDistribuidor.Location = new Point(158, 187);
            lbDistribuidor.Name = "lbDistribuidor";
            lbDistribuidor.Size = new Size(44, 15);
            lbDistribuidor.TabIndex = 8;
            lbDistribuidor.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 191);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 7;
            label9.Text = "Distibuidor :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 149);
            label8.Name = "label8";
            label8.Size = new Size(226, 15);
            label8.TabIndex = 6;
            label8.Text = "____ Distibuidor ___________________________";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(158, 100);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(38, 15);
            lbCantidad.TabIndex = 5;
            lbCantidad.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 101);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 4;
            label6.Text = "Cantidad :";
            // 
            // lbTipoM
            // 
            lbTipoM.AutoSize = true;
            lbTipoM.Location = new Point(158, 58);
            lbTipoM.Name = "lbTipoM";
            lbTipoM.Size = new Size(38, 15);
            lbTipoM.TabIndex = 3;
            lbTipoM.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 58);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 2;
            label4.Text = "Tipo de Medicamento :";
            // 
            // lbNombreM
            // 
            lbNombreM.AutoSize = true;
            lbNombreM.Location = new Point(158, 21);
            lbNombreM.Name = "lbNombreM";
            lbNombreM.Size = new Size(38, 15);
            lbNombreM.TabIndex = 1;
            lbNombreM.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre del Medicamento :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 227);
            label3.Name = "label3";
            label3.Size = new Size(225, 15);
            label3.TabIndex = 12;
            label3.Text = "____ Sucursal  _____________________________";
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 505);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Pedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedido";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label lbTipoM;
        private Label label4;
        private Label lbNombreM;
        private Label label2;
        private Label lbSucursal;
        private Label label12;
        private Label lbDistribuidor;
        private Label label9;
        private Label label8;
        private Label lbCantidad;
        private Label label3;
    }
}