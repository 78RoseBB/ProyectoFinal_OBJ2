using Twilio;
using Twilio.Rest.Api.V2010.Account;

public class Alumno
{
    public int AlumnoId { get; set; }
    public string Nombre { get; set; }
    public string NumeroTelefonoPadre { get; set; }
    public ICollection<Pago> Pagos { get; set; }
}

public class AlumnosForm : Form
{
    private readonly ApplicationDbContext dbContext = new ApplicationDbContext();
    private DataGridView dgvAlumnos = new DataGridView();
    private Button btnAgregar = new Button();
    private Button btnEditar = new Button();
    private Button btnEliminar = new Button();
    private Button btnVerificarPagos = new Button();

    public AlumnosForm()
    {
        InitializeComponent();
        CargarAlumnos();

        // Asociar eventos
        btnAgregar.Click += btnAgregar_Click;
        btnEditar.Click += btnEditar_Click;
        btnEliminar.Click += btnEliminar_Click;
        btnVerificarPagos.Click += btnVerificarPagos_Click;
    }

    private void CargarAlumnos()
    {
        dgvAlumnos.DataSource = dbContext.Alumnos.ToList();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        // Lógica para agregar un nuevo alumno
        // Actualizar la base de datos y recargar la lista de alumnos
        CargarAlumnos();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        // Lógica para editar el alumno seleccionado
        // Actualiza la base de datos y recargar la lista de alumnos
        CargarAlumnos();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        // Lógica para eliminar el alumno seleccionado
        // Actualiza la base de datos y recargar la lista de alumnos
        CargarAlumnos();
    }

    private void VerificarPagosPendientes()
    {
        // Lógica para verificar pagos pendientes
        var alumnosConPagosPendientes = ObtenerAlumnosConPagosPendientes();

        // Los alumnos con pagos pendientes y enviar mensajes SMS
        foreach (var alumno in alumnosConPagosPendientes)
        {
            EnviarMensajeSMS(alumno);
        }
    }

    private List<Alumno> ObtenerAlumnosConPagosPendientes()
    {
        // Obtener la fecha actual
        DateTime fechaActual = DateTime.Now;

        // Lógica para obtener la lista de alumnos con pagos pendientes
        // Supongamos que Pagos es una colección de pagos asociada a cada Alumno
        var alumnosConPagosPendientes = dbContext.Alumnos
            .Where(alumno => alumno.Pagos.Any(p => p.FechaPago < fechaActual))
            .ToList();

        return alumnosConPagosPendientes;
    }

    private void EnviarMensajeSMS(Alumno alumno)
    {
        // Configura las credenciales de Twilio
        const string accountSid = "tu-account-sid";
        const string authToken = "tu-auth-token";
        const string twilioPhoneNumber = "tu-numero-twilio";

        // Inicializa el cliente de Twilio
        TwilioClient.Init(accountSid, authToken);

        // Número de teléfono del padre de familia
        string numeroTelefonoPadre = alumno.NumeroTelefonoPadre;

        // Mensaje que deseas enviar
        string mensajeTexto = "Recordatorio de Pago Pendiente";

        // Envía el mensaje SMS utilizando Twilio
        var mensaje = MessageResource.Create(
            to: new Twilio.Types.PhoneNumber(numeroTelefonoPadre),
            from: new Twilio.Types.PhoneNumber(twilioPhoneNumber),
            body: mensajeTexto
        );

        // Puedes obtener el SID del mensaje si es necesario
        string messageId = mensaje.Sid;

        // Puedes agregar más lógica según tus necesidades
    }

    private void btnVerificarPagos_Click(object sender, EventArgs e)
    {
        // Este evento podría ser activado manualmente por el administrador
        VerificarPagosPendientes();
    }
}
