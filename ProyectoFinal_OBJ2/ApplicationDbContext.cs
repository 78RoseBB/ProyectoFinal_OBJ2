Imports Microsoft.EntityFrameworkCore

Namespace ProyectoFinal_OBJ2
    Public Class ApplicationDbContext
        Inherits DbContext

        Public Property Alumnos As DbSet(Of Alumno)
        Public Property Pagos As DbSet(Of Pago)
        Public Property RecordatoriosPagos As DbSet(Of RecordatorioPago)

        Public Sub New(options As DbContextOptions(Of ApplicationDbContext))
            MyBase.New(options)
        End Sub

        Public Function ObtenerPagosPendientes(mes As String) As List(Of Pago)
            Return Pagos.Where(Function(p) p.MesPendientePago = mes).ToList()
        End Function

    End Class
End Namespace
