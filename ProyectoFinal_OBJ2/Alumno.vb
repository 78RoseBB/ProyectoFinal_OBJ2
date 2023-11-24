Imports System
Imports System.Collections.Generic
Imports System.Data.Entity

Namespace ProyectoFinal_OBJ2
    Public Class ApplicationDbContext
        Inherits DbContext

        Public Property Alumnos As DbSet(Of Alumno)
        Public Property Pagos As DbSet(Of Pago)
        Public Property RecordatoriosPagos As DbSet(Of RecordatorioPago)

        Public Sub New()
            MyBase.New("name=ConnectionString")
            ' Configuraciones adicionales del DbContext si es necesario
        End Sub
    End Class

    Public Class Alumno
        Public Property AlumnoId As Integer
        Public Property Nombre As String
        Public Property Email As String
        Public Property NumeroTelefonoPadre As String

        Public Overridable Property Pagos As ICollection(Of Pago)
    End Class

    ' Pago.vb
    Public Class Pago
        Public Property PagoId As Integer
        Public Property FechaPago As DateTime
        Public Property Monto As Decimal
        Public Property MesPendientePago As String

        Public Property AlumnoId As Integer
        Public Overridable Property Alumno As Alumno
    End Class

    ' RecordatorioPago.vb
    Public Class RecordatorioPago
        ' Propiedades de RecordatorioPago
    End Class
End Namespace
