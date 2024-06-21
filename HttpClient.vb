Imports System.Net.Http
Imports System.Text.Json
Imports System.Text

Public Class HttpClient
    Private Shared ReadOnly baseAddress As String = "http://localhost:3000/"

    Public Shared Function GetSubmissions() As List(Of Submission)
        Dim client As New System.Net.Http.HttpClient()
        Try
            Dim response As HttpResponseMessage = client.GetAsync(baseAddress & "read?index=0").Result
            Dim json As String = response.Content.ReadAsStringAsync().Result
            If response.IsSuccessStatusCode Then
                Return JsonSerializer.Deserialize(Of List(Of Submission))(json)
            Else
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}")
                Return Nothing
            End If
        Catch ex As Exception
            Console.WriteLine($"Exception: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Shared Sub SubmitSubmission(submission As Submission)
        Dim client As New System.Net.Http.HttpClient()
        Try
            Dim json As String = JsonSerializer.Serialize(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = client.PostAsync(baseAddress & "submit", content).Result
            If Not response.IsSuccessStatusCode Then
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}")
            End If
        Catch ex As Exception
            Console.WriteLine($"Exception: {ex.Message}")
        End Try
    End Sub
End Class
