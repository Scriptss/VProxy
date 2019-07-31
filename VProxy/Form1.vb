Imports System.Threading
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class frmMain

    Dim proxys As New List(Of String)
    Private completedTaskCount As Integer



    Private Sub PerformTask(threadContext As Object)
        Try
            Dim threadIndex As Integer = CType(threadContext, Integer)

            'get the proxy from the collection
            'split the proxy by the ":" identifier
            Dim proxy As String = proxys(threadIndex)
            Dim proxyArray As String() = proxy.Split(":")


            'make sure the proxy has a IP and port
            'set the proxy ip
            'try and parse the proxy port from the second part of the split
            If proxyArray.Length > 1 Then
                Dim proxyIP As String = proxyArray(0)
                Dim proxyPort As Integer = 0
                Dim result As Boolean = Int32.TryParse(proxyArray(1), proxyPort)

                'if it successfully parsed the port
                If result.Equals(True) Then

                    'create a new webclient
                    'set the proxy
                    'set the timeout
                    Dim request As HttpWebRequest = HttpWebRequest.Create("http://api.proxychecker.co?ip=" & proxyIP)
                    request.Proxy = New WebProxy(proxyIP, proxyPort)
                    request.UserAgent = "Proxy Checker v.1.1 - (proxychecker.co) : windows v.10"
                    request.Timeout = 5000

                    'create a stopwatch and start it
                    Dim responseStopWatch As New Stopwatch
                    Dim responseTime As String = ""
                    Dim webresponse As String = ""
                    Try
                        responseStopWatch.Start()
                        Dim response As WebResponse = request.GetResponse()
                        responseStopWatch.Stop()

                        'calculate the response time into milliseconds
                        'set a ms at the end incase it doesn't have a decimal
                        'if it does split from the decimal and add the trailing ms
                        responseTime = responseStopWatch.Elapsed.TotalMilliseconds & "ms"
                        If responseTime.Contains(".") Then
                            responseTime = responseTime.Split(".")(0) & "ms"
                        End If


                        Using dataStream As Stream = response.GetResponseStream()
                            Dim reader As New StreamReader(dataStream)
                            Dim responseFromServer As String = reader.ReadToEnd()
                            webresponse = responseFromServer
                        End Using
                        response.Close()
                    Catch ex As WebException
                        'do nothing with the error its expected
                    End Try

                    'check there is a valid webresponse 
                    If (webresponse.Length > 5) Then
                        Dim jsonResponse As New JObject
                        jsonResponse = JObject.Parse(webresponse)

                        'fetch the resulting tokens from the json 
                        Dim anonymity As String = jsonResponse("anonymity")
                        Dim country As String = jsonResponse("country")

                        'add the row to the datagridview
                        dgvProxy.Invoke(Sub()
                                            dgvProxy.Rows.Add(New String() {proxyIP, proxyPort, anonymity, country, responseTime})
                                        End Sub)

                    End If


                End If

            End If


        Catch ex As Exception
            Debug.WriteLine("error - " & ex.Message)
        Finally
            Interlocked.Increment(completedTaskCount)

            progressBar.Invoke(Sub()
                                   progressBar.Increment(1)
                               End Sub)

            lblstatus.Invoke(Sub()
                                 lblstatus.Text = "checked " & completedTaskCount & "/" & proxys.Count
                                 lblstatus.Refresh()
                             End Sub)

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'remove the first empty column from datagridview
        dgvProxy.RowHeadersVisible = False

        'hide start and status as not needed until proxys are imported
        tsbStart.Enabled = False
        lblstatus.Hide()

    End Sub

    Private Sub tsbImport_Click(sender As Object, e As EventArgs) Handles tsbImport.Click

        'new openFolderDialog
        Using ofd As New FolderBrowserDialog

            'once a folder has been selected
            'check it exists and carry on if it does
            If ofd.ShowDialog = DialogResult.OK Then
                If (Directory.Exists(ofd.SelectedPath)) Then

                    'scan the folder for text files
                    'add them to the fileArray
                    Dim di As New IO.DirectoryInfo(ofd.SelectedPath)
                    Dim fileArray As IO.FileInfo() = di.GetFiles("*.txt")

                    'for each text file in the folder
                    'check the file exists
                    'add the contents to the proxy list
                    For Each proxyfile As FileInfo In fileArray
                        If (File.Exists(proxyfile.FullName)) Then
                            proxys.AddRange(File.ReadAllLines(proxyfile.FullName))
                        End If
                    Next

                End If
            End If

        End Using

        lblstatus.Show()
        lblstatus.Text = "Loaded " & proxys.Count & " proxies"
        lblstatus.Refresh()
        tsbStart.Enabled = True
    End Sub

    Private Sub tsbExport_Click(sender As Object, e As EventArgs) Handles tsbExport.Click
        frmExport.Show()
    End Sub

    Private Sub tsbStart_Click(sender As Object, e As EventArgs) Handles tsbStart.Click

        'disable start button
        tsbStart.Enabled = False

        'remove duplicates
        proxys = proxys.Distinct().ToList

        'set progress bar values
        progressBar.Value = 0
        progressBar.Maximum = proxys.Count
        completedTaskCount = 0

        ThreadPool.SetMaxThreads(50, 50)
        For i = 0 To proxys.Count - 1
            ThreadPool.QueueUserWorkItem(AddressOf PerformTask, i)
        Next

    End Sub


End Class