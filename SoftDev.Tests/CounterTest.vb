Imports NUnit.Framework

Namespace SoftDev.Tests
    Public Class CounterTest
        Private counter As Counter

        <SetUp>
        Public Sub Setup()
            counter = New Counter()
        End Sub

        <Test>
        Public Sub GetValue()
            Dim v As Integer = counter.GetValue()
            Assert.AreEqual(0, v)
        End Sub
    End Class
End Namespace
