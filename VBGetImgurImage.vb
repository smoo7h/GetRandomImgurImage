Imports System.Net
Imports System.Text.RegularExpressions

Public Class GetImgurImage
    Public Function GetRandomImg() As String
        Dim client As New WebClient()
        Dim downloadString As String = client.DownloadString("http://imgur.com/")
        Dim input As String = downloadString
        Dim regexcode As String = "(i.img)([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])+.jpg"
        Dim regex As Regex = New Regex(regexcode)
        Dim r As Random = New Random()
        Dim rInt As Int64 = r.Next(0, regex.Matches(input).Count)
        Dim rndimg As String = regex.Matches(input)(rInt).ToString
        Return rndimg
    End Function
End Class
