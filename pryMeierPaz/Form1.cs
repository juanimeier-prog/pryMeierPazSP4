namespace pryMeierPaz
{
    public partial class Form1 : Form
    {
        private readonly float[,] ventas = new float[5, 4];

        public Form1()
        {
            InitializeComponent();
            CargarMozos();
            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;
        }

        private void CargarMozos()
        {
            foreach (string mozo in new[] { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" })
            {
                dgvVentas.Rows.Add(mozo);
            }
        }

        private void btnValidarDatos_Click(object? sender, EventArgs e)
        {
            for (int fila = 0; fila < 5; fila++)
            {
                for (int categoria = 0; categoria < 4; categoria++)
                {
                    object? valorCelda = dgvVentas.Rows[fila].Cells[categoria + 1].Value;
                    if (!TryObtenerImporte(valorCelda, out float importe))
                    {
                        btnMozoDelDia.Enabled = false;
                        btnTotales.Enabled = false;
                        MessageBox.Show(
                            $"El importe de la fila {fila + 1}, categoría {categoria + 1} debe ser numérico. El valor cero es válido.",
                            "Datos inválidos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    ventas[fila, categoria] = importe;
                }
            }

            btnMozoDelDia.Enabled = true;
            btnTotales.Enabled = true;
            MessageBox.Show("Todos los datos fueron validados correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static bool TryObtenerImporte(object? valorCelda, out float importe)
        {
            string texto = Convert.ToString(valorCelda)?.Trim() ?? string.Empty;
            bool esValido = float.TryParse(texto, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.CurrentCulture, out importe)
                || float.TryParse(texto, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out importe);

            return esValido && float.IsFinite(importe);
        }

        private void dgvVentas_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
            }
        }

        private void btnMozoDelDia_Click(object? sender, EventArgs e)
        {
            int indiceMozo = 0;
            float mayorVenta = ObtenerTotalMozo(0);

            for (int fila = 1; fila < 5; fila++)
            {
                float totalMozo = ObtenerTotalMozo(fila);
                if (totalMozo > mayorVenta)
                {
                    mayorVenta = totalMozo;
                    indiceMozo = fila;
                }
            }

            lblMozoDelDia.Text = $"Mozo: {dgvVentas.Rows[indiceMozo].Cells[0].Value}";
            lblImporteMozo.Text = $"Importe: {mayorVenta:N2}";
        }

        private float ObtenerTotalMozo(int fila)
        {
            float total = 0;
            for (int categoria = 0; categoria < 4; categoria++)
            {
                total += ventas[fila, categoria];
            }

            return total;
        }

        private void btnTotales_Click(object? sender, EventArgs e)
        {
            float totalGeneral = 0;
            float[] totalesPorCategoria = new float[4];

            for (int fila = 0; fila < 5; fila++)
            {
                for (int categoria = 0; categoria < 4; categoria++)
                {
                    totalesPorCategoria[categoria] += ventas[fila, categoria];
                    totalGeneral += ventas[fila, categoria];
                }
            }

            lblTotalGeneral.Text = $"Total general: {totalGeneral:N2}";
            lblTotalComidas.Text = $"Comidas: {totalesPorCategoria[0]:N2}";
            lblTotalBebidasSinAlcohol.Text = $"Bebidas sin alcohol: {totalesPorCategoria[1]:N2}";
            lblTotalBebidasConAlcohol.Text = $"Bebidas con alcohol: {totalesPorCategoria[2]:N2}";
            lblTotalPostres.Text = $"Postres: {totalesPorCategoria[3]:N2}";
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
