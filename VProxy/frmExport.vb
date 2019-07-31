Imports System.IO

Public Class frmExport

    Private Sub frmExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnExport.Enabled = False

        'make sure we actually have some rows first
        If frmMain.dgvProxy.Rows.Count > 0 Then
            btnExport.Enabled = True

            'for each row populate the thingy boxes
            For Each row As DataGridViewRow In frmMain.dgvProxy.Rows

                Dim match As Boolean = False
                Dim anonymity As String = row.Cells(2).Value
                For Each box As Object In clbAnonymity.Items
                    If box.ToString.Contains(anonymity) Then
                        match = True
                    End If
                Next
                If (match.Equals(False)) Then
                    clbAnonymity.Items.Add(anonymity, True)
                End If

                match = False
                Dim country As String = row.Cells(3).Value
                For Each box As Object In clbCountry.Items
                    If box.ToString.Contains(country) Then
                        match = True
                    End If
                Next
                If (match.Equals(False)) Then
                    clbCountry.Items.Add(country, True)
                End If
            Next

        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        'select the file to save the proxies to
        Dim textfile As String = ""
        Using ofd As New OpenFileDialog
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                textfile = ofd.FileName
            End If
        End Using

        'exit sub if file doesnt exist
        If Not (File.Exists(textfile)) Then Exit Sub

        For Each row As DataGridViewRow In frmMain.dgvProxy.Rows

            Try

                Dim proxyIP As String = row.Cells(0).Value
                Dim proxyPort As String = row.Cells(1).Value.ToString
                Dim anonymity As String = row.Cells(2).Value
                Dim country As String = row.Cells(3).Value

                'get the responseTime string from the row
                'remove the trailing ms and convert it to an integer
                Dim responseString As String = row.Cells(4).Value.ToString.Split("m")(0)
                Dim responseTime As Integer = Int32.Parse(responseString)

                'for each checkbox do a check against the row
                For Each anonymityBox As Object In clbAnonymity.CheckedItems
                    If (anonymityBox.ToString.Contains(anonymity)) Then
                        For Each countryBox As Object In clbCountry.CheckedItems
                            If (countryBox.ToString.Contains(country)) Then
                                If responseTime <= nudResponseTime.Value Then
                                    Using sw As StreamWriter = File.AppendText(textfile)
                                        sw.WriteLine(proxyIP & ":" & proxyPort)
                                    End Using
                                End If
                            End If
                        Next
                    End If
                Next


            Catch ex As Exception
                MsgBox("error: " & ex.Message)
            Finally
                Me.Dispose()
            End Try

        Next



    End Sub

End Class