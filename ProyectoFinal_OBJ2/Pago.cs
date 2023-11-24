Imports Microsoft.EntityFrameworkCore

    Namespace ProyectoFinal_OBJ2
        Public Class Pago

            Public Property PagoId As Integer
            Public Property FechaPago As DateTime
            Public Property Monto As Decimal
            Public Property MesPendientePago As String

            Public Property AlumnoId As Integer
            Public Overridable Property Alumno As Alumno

        End Class

    End Namespace


