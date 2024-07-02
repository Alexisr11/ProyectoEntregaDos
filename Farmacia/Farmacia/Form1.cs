using System.Collections.Generic;

namespace Farmacia
{
    public partial class Form1 : Form
    {
        string distribuidor = string.Empty;
        public Form1()
        {
            InitializeComponent();
            // Llenamos el combo box
            llenarComboBox();
        }

        public void llenarComboBox()
        {
            cbTipo.Items.Add("Analgesico");
            cbTipo.Items.Add("Analeptico");
            cbTipo.Items.Add("Anestesico");
            cbTipo.Items.Add("Antiácido");
            cbTipo.Items.Add("Antidepresivo");
            cbTipo.Items.Add("Antibiótico");
        }

        public string validacionFormulario()
        {
            string distribuidor = null;
            string mensaje = "";
            bool sucursalPrincipal = ckPrincipal.Checked;
            bool sucursalSecundaria = ckSucursal.Checked;

            if (rdCofarma.Checked)
            {
                distribuidor = "Cofarma";
            }
            else if (rdEmp.Checked)
            {
                distribuidor = "Empsephar";
            }
            else if (rdCom.Checked)
            {
                distribuidor = "Cemefar";
            }

            if (string.IsNullOrEmpty(txtNombreMedicamento.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtNombreMedicamento.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                return mensaje = "Nombre de medicamento inválido.";
            }

            if (cbTipo.Text == null)
            {
                return mensaje = "Debe seleccionar un tipo de medicamento.";
            }

            try
            {
                var cantidad = Int16.Parse(txtCantidad.Text);
                if (cantidad <= 0)
                {
                    return mensaje = "Cantidad no permitida";
                }
            }
            catch (FormatException)
            {
                return mensaje = "Cantidad inválida.";
            }

            if (string.IsNullOrEmpty(distribuidor))
            {
                return mensaje = "Cantidad inválida.";
            }

            if (!sucursalPrincipal && !sucursalSecundaria)
            {
                return mensaje = "Debe seleccionar al menos una sucursal.";
            }

            return mensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sucursal = "";

            // VAlidamos el formulario 
            var error = validacionFormulario();

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ckPrincipal.Checked)
                {
                    sucursal = "Para la farmacia situada en Calle de la Rosa n. 28\n";
                }
                else
                {
                    sucursal = "Para la farmacia situada en Calle Alcazabilla n. 3\n";
                }

                Pedido pedido = new Pedido(txtNombreMedicamento.Text, cbTipo.Text, Int16.Parse(txtCantidad.Text), distribuidor, sucursal);
                pedido.Show();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            this.txtNombreMedicamento.Text = string.Empty;
            this.cbTipo.SelectedIndex = -1;
            this.txtCantidad.Text = string.Empty;

            // Desmarcar los RadioButtons
            this.rdCofarma.Checked = false;
            this.rdEmp.Checked = false;
            this.rdCom.Checked = false;

            // Desmarcar los CheckBoxes
            this.ckPrincipal.Checked = false;
            this.ckSucursal.Checked = false;
        }
    }
}
