Imports System
Imports Newtonsoft.Json

Namespace SoftDev
    Friend Class Program
        Public Shared Sub Main(ByVal args As String())
            Dim json = "{'text':'The quick brown fox jumps over the lazy dog!','word_count':9,'mean_word_length':3.888888888888889,'unique_letters':['t','h','e','q','u','i','c','k','b','r','o','w','n','f','x','j','m','p','s','v','l','a','z','y','d','g'],'word_frequencies':{'the':2,'quick':1,'brown':1,'fox':1,'jumps':1,'over':1,'lazy':1,'dog':1}}"
            Dim analysis = JsonConvert.DeserializeObject(Of TextAnalysis)(json)
            Console.WriteLine("Executed successfully")
            ' TODO: check that analysis contains correct data

            Console.WriteLine(analysis.Text)

            For Each word In analysis.WordFrequencies
                Console.WriteLine(word)
            Next

            If analysis.WordFrequencies.ContainsKey("the") Then
                Console.WriteLine(analysis.WordFrequencies("the").ToString)
            End If

            For Each pair As KeyValuePair(Of String, Integer) In analysis.WordFrequencies
                Console.WriteLine(pair.Key & " " & pair.Value)
            Next


        End Sub
    End Class
End Namespace
