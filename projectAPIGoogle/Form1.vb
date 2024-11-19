Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim apiKey As String = "API-Key"
        Dim searchEngineId As String = "Search-Engine-ID"

        ' Get search query from TextBox
        Dim query As String = txtSearch.Text

        ' Construct the API request URL
        Dim apiUrl As String = $"https://www.googleapis.com/customsearch/v1?key={apiKey}&cx={searchEngineId}&q={Uri.EscapeDataString(query)}"

        ' Perform the HTTP GET request
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                If response.StatusCode = HttpStatusCode.Forbidden Then
                    ' MessageBox.Show("403 Forbidden Error: " & responseBody)
                    txtError.Text = "403 Forbidden Error: " & responseBody
                    Exit Sub
                ElseIf response.StatusCode <> HttpStatusCode.OK Then
                    ' MessageBox.Show("Error: " & response.StatusCode & vbCrLf & responseBody)
                    txtError.Text = "Error: " & response.StatusCode & vbCrLf & responseBody
                    Exit Sub
                End If

                ' Parse JSON and handle results
                Dim json As JObject = JObject.Parse(responseBody)
                Dim items As JArray = json("items")

                Console.WriteLine(items)

                lstResults.Items.Clear()
                For Each item In items
                    Dim title As String = item("title").ToString()
                    Dim link As String = item("link").ToString()
                    lstResults.Items.Add($"{title} - {link}")
                Next

            Catch ex As Exception
                ' MessageBox.Show("Exception: " & ex.Message)
                txtError.Text = ex.Message
            End Try
        End Using


    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
End Class
