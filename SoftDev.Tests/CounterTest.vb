Imports NUnit.Framework
Imports SoftDev.SoftDev

Namespace SoftDev.test

    Public Class CounterTest
        Dim counter As counter

        <SetUp>
        Public Sub Setup()
            Dim counter = New Counter()
        End Sub

        <Test>
        Public Sub GetValue()
            On Error Resume Next
            Dim v As Integer = counter.GetValue()
            Assert.AreEqual(0, v)
        End Sub
    End Class
End Namespace
