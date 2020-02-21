Imports Microsoft.Office.Interop.Excel

Public Class Form1
    Dim IPADDR As System.Net.IPAddress
    Dim bSPCFound As Boolean
    Dim bSysConFound As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aIPOct() As String
        IPADDR = GetLocalIP()
        localIPAdress.Text = "Local IP - Adress: " & IPADDR.ToString()
        aIPOct = IPADDR.ToString().Split(".")

        dgvHosts.Rows.Add("SPC", aIPOct(0) & "." & aIPOct(1) & "." & aIPOct(2) & "." & "21")
        dgvHosts.Rows.Add("SysCon", aIPOct(0) & "." & aIPOct(1) & "." & aIPOct(2) & "." & "2")

    End Sub

    Private Sub PingButton_Click(sender As Object, e As EventArgs) Handles PingButton.Click
        Dim iHostCount As Integer = Integer.Parse((dgvHosts.Rows.Count - 1).ToString())
        Dim oPing As New Net.NetworkInformation.Ping()
        Dim oPingResult As Net.NetworkInformation.PingReply

        pingOutput.ClearSelected()
        For Each row As DataGridViewRow In dgvHosts.Rows
            If row.Index = dgvHosts.Rows.Count - 1 Then Exit For
            dgvHosts.ClearSelection()
            row.Selected = True

            oPingResult = oPing.Send(row.Cells(1).Value, 3000)
            If oPingResult.Status = 0 Then
                If row.Index = 0 Then
                    pingOutput.Items.Add("Ping SPC: OK " & oPingResult.Status.ToString())
                    bSPCFound = True
                End If
                If row.Index = 1 Then
                    pingOutput.Items.Add("Ping SysCon: OK " & oPingResult.Status.ToString())
                    bSysConFound = True
                End If
            Else
                If row.Index = 0 Then
                    pingOutput.Items.Add("Ping SPC: NOK " & oPingResult.Status.ToString())
                    bSPCFound = False
                End If
                If row.Index = 1 Then
                    pingOutput.Items.Add("Ping SysCon: NOK " & oPingResult.Status.ToString())
                    bSysConFound = False
                End If
            End If
        Next
    End Sub

    Private Function GetLocalIP() As System.Net.IPAddress
        Try
            Dim IP As Net.IPAddress
            Dim IPList As Array = Net.Dns.GetHostEntry(SystemInformation.ComputerName.ToString).AddressList
            If IPList.Length > 0 Then
                For i As Integer = 0 To IPList.Length - 1
                    IP = IPList.GetValue(i)
                    If IP.ToString <> "0.0.0.0" Then
                        Return IP
                    End If
                Next
            Else
                IP = New Net.IPAddress(0)
                Return IP
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub OpenExcel_Click(sender As Object, e As EventArgs) Handles OpenExcel.Click
        If bSPCFound = True Then
            Dim ofd As New OpenFileDialog With
            {
            .Multiselect = False,
            .Filter = "Tabelle (*.xlsx)|*.xlsx",
            .Title = "Open Excel - file"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim oXlsApp As New Microsoft.Office.Interop.Excel.Application

                Try
                    oXlsApp.Workbooks.Open(ofd.FileName)
                    Dim oXlsSheet As Worksheet = oXlsApp.Sheets("CSR Stores")
                    Dim oRange As Range = oXlsSheet.UsedRange
                    Dim oXlsarray(,) As Object = oRange.Value(XlRangeValueDataType.xlRangeValueDefault)
                    For i As Integer = 1 To oXlsarray.GetUpperBound(0)
                        For j As Integer = 1 To oXlsarray.GetUpperBound(1)
                            Dim strPart As String = oXlsarray(i, j)
                            If InStr(strPart, IPADDR.ToString) <> 0 Then
                                MsgBox("Filiale: " & oXlsarray(i, j - 2) & " aktuelle IP: " & strPart & " neue IP: " & oXlsarray(i, j + 2))
                            End If
                        Next

                    Next
                    oXlsApp.Workbooks.Close()
                    oXlsApp.Quit()
                Catch ex As Exception

                End Try

            Else
                MessageBox.Show("Abbruch")
            End If
        Else
            MessageBox.Show("Ping's not successful!")
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub OpenChecklist_Click(sender As Object, e As EventArgs) Handles OpenChecklist.Click
        If bSPCFound = True Then
            Dim ofd As New OpenFileDialog With
            {
            .Multiselect = False,
            .Filter = "Wordfile (*.docx)|*.docx",
            .Title = "Open Word - file"
            }
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim oWordApp As New Microsoft.Office.Interop.Word.Application
                Try
                    oWordApp.Documents.Open(ofd.FileName)
                    oWordApp.Visible = True
                    'oWordApp.Quit()
                Catch ex As Exception

                End Try
            Else
                MessageBox.Show("Abbruch")
            End If
        Else
            MessageBox.Show("Ping's not successful!")
        End If
    End Sub
End Class