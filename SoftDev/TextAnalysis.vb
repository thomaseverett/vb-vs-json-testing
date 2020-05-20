Imports System.Collections.Generic
Imports Newtonsoft.Json

Public Class TextAnalysis
    <JsonProperty("text")>
    Public Text As String
    <JsonProperty("word_count")>
    Public WordCount As Integer
    <JsonProperty("mean_word_length")>
    Public MeanWordLength As Double
    <JsonProperty("unique_letters")>
    Public UniqueLetters As List(Of Char)
    <JsonProperty("word_frequencies")>
    Public WordFrequencies As Dictionary(Of String, Integer)

    Public Sub New()
    End Sub

    Public Sub New(ByVal Text As String, ByVal WordCount As Integer, ByVal MeanWordLength As Double, ByVal UniqueLetters As List(Of Char), ByVal WordFrequencies As Dictionary(Of String, Integer))
        Me.Text = Text
        Me.WordCount = WordCount
        Me.MeanWordLength = MeanWordLength
        Me.UniqueLetters = UniqueLetters
        Me.WordFrequencies = WordFrequencies
    End Sub
End Class
