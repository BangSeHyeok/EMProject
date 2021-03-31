Imports System.Net
Imports HtmlAgilityPack
Imports System.Text
Public Class Crawling
    Public Sub ExecuteDemo(ByVal sitesource As String)
        Dim doc As HtmlAgilityPack.HtmlDocument = New HtmlAgilityPack.HtmlDocument()
        doc.LoadHtml(sitesource)
        For Each body As HtmlNode In doc.DocumentNode.SelectNodes("//h3[@class='list-title post_ttl']")
            CrawlingVOTitle.Crawling_list.Add(body.InnerText.Trim)
        Next
        For Each body As HtmlNode In doc.DocumentNode.SelectNodes("//span[@class='post_time']")
            CrawlingVODay.Crawling_list.Add(body.InnerText.Trim)
        Next
        For Each body As HtmlNode In doc.DocumentNode.SelectNodes("//div[@class='col-md-12 mainarea']")
            For Each a As HtmlNode In body.SelectNodes("//article")
                Dim str As String = a.InnerHtml
                Dim j As Int64 = str.IndexOf("href")
                Dim i As Int64 = str.IndexOf("title")
                Dim url As String = str.Substring(j + 6, i - j - 8).Trim & vbCrLf
                CrawlingVOUrl.Crawling_list.Add(url)
            Next
        Next
    End Sub
End Class
