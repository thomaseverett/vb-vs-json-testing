Namespace SoftDev
    Public Class Counter
        Private value As Integer

        Public Sub New()
            value = 0
        End Sub

        Public Function GetValue() As Integer
            value += 1
            Return value
        End Function
    End Class
End Namespace
