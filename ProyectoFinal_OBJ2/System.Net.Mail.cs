using System.Net;
using System.Net.Mail;

// Obtiene la información del alumno y el pago pendiente
Alumno alumno = dbContext.Alumnos.Find(alumnoId);
// Obtiene la dirección de correo electrónico del padre de familia
string correoPadre = alumno.CorreoElectronicoPadre;

// Configura el correo electrónico
var smtpClient = new SmtpClient("tu.servidor.smtp.com")
{
    Port = 587,
    Credentials = new NetworkCredential("tu-correo@gmail.com", "tu-contraseña"),
    EnableSsl = true,
};

// Crear el mensaje de correo electrónico
var mensaje = new MailMessage("tu-correo@gmail.com", correoPadre, "Recordatorio de Pago Pendiente", "Texto del mensaje...");

// Envia el correo electrónico
smtpClient.Send(mensaje);
