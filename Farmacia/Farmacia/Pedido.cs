using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        public Pedido(string nombreMedicamente, string tipoMeidcamento, int cantidad, string distribuidor, string sucursal)
        {
            InitializeComponent();
            this.lbNombreM.Text = nombreMedicamente;
            this.lbTipoM.Text = tipoMeidcamento;
            this.lbCantidad.Text = cantidad.ToString();
            this.lbDistribuidor.Text = distribuidor;
            this.lbSucursal.Text = sucursal;
        }
    }
}
