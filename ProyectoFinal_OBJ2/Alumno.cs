using System;
using System.Linq;
using System.Windows.Forms;

public class MainForm : Form
{
    private readonly ApplicationDbContext dbContext = new ApplicationDbContext();
    private DataGridView dgvAlumnos;
    private TextBox txtNombre;
    private Button btnAgregar;

    public MainForm()
    {
        InitializeComponent();
        CargarAlumnos();
    }

    private void InitializeComponent()
    {
        // Configuración del formulario y controles
        dgvAlumnos = new DataGridView();
        txtNombre = new TextBox();
        btnAgregar = new Button();

        // Configuración de dgvAlumnos, txtNombre, btnAgregar
        // ...

        // Asociar el evento btnAgregar_Click al botón
        btnAgregar.Click += btnAgregar_Click;

        // Otros controles y configuraciones
        // ...
    }

    private void CargarAlumnos()
    {
        dgvAlumnos.DataSource = dbContext.Alumnos.ToList();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        // Crear un nuevo alumno
        var nuevoAlumno = new Alumno
        {
            Nombre = txtNombre.Text
            Email = txtEamil.Text
            NumeroTelefonoPadre = txtNumero.Text

        };

        // Agregar el nuevo alumno a la base de datos
        dbContext.Alumnos.Add(nuevoAlumno);
        dbContext.SaveChanges();

        //Eliminar el alumno de la base de datos
        dbContext.Alumnos.Remove(alumno)
        dbContext.SaveChanges()

        // Recargar la lista de alumnos
        CargarAlumnos();
    }

}

public class ApplicationDbContext : DbContext
{
    public DbSet<Alumno> Alumnos { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<RecordatorioPago> RecordatoriosPagos { get; set; }

    public ApplicationDbContext() : base("name=ConnectionString")
    {
        // Configuraciones adicionales del DbContext si es necesario
    }
}

public class Alumno
{
    public int AlumnoId { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string NumeroTelefonoPadre { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; }
}

// Pago.cs
public class Pago
{
    public int PagoId { get; set; }
    public DateTime FechaPago { get; set; }
    public decimal Monto { get; set; }
    public string MesPendientePago { get; set; }

    public int AlumnoId { get; set; }
    public virtual Alumno Alumno { get; set; }
}
