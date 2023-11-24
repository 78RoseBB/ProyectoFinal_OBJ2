public class ServicioNotificaciones
{
    public void EnviarNotificacion(NotificacionPago notificacion)
    {
        // Lógica para enviar la notificación, por ejemplo, enviar un correo electrónico.
        // Puedes utilizar bibliotecas como SendGrid, SmtpClient, etc.
        
    Console.WriteLine($"Enviando correo a {notificacion.Destinatario}, Asunto: {notificacion.Asunto}\n\n{notificacion.Contenido}");
    }
}

