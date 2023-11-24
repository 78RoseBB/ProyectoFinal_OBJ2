private void btnProgramar_Click(object sender, EventArgs e)
{
    // Obtener información del formulario
    DateTime fechaProgramada = dateTimePickerFecha.Value;
    string mensaje = txtMensaje.Text;

    // RecordatorioPago
    RecordatorioPago recordatorio = new RecordatorioPago
    {
        FechaProgramada = fechaProgramada,
        Mensaje = mensaje,
        Estado = false // El estado podría ser "no enviado"
    };

    // Guardar en la base de datos
    dbContext.RecordatoriosPagos.Add(recordatorio);
    dbContext.SaveChanges();

    this.Close();
}
