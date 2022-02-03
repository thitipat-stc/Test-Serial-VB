Imports System.IO.Ports

Public Class Form1

    Private comPort As New SerialPort()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbStatus.Text = "Closed"
        tbStatus.BackColor = Color.Red
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Try
            If comPort.IsOpen = True Then
                comPort.Close()
            End If

            comPort.BaudRate = Integer.Parse(tbBaudRate.Text)
            comPort.DataBits = Integer.Parse(tbDataBits.Text)
            comPort.StopBits = Integer.Parse(tbStopBits.Text)
            comPort.Parity = Integer.Parse(tbParity.Text)
            comPort.PortName = tbPortName.Text
            comPort.Open()

            AddHandler comPort.DataReceived, New SerialDataReceivedEventHandler(AddressOf comPort_DataReceived)
            tbStatus.BackColor = Color.Green
            tbStatus.Text = "Open"
        Catch ex As Exception
            tbStatus.BackColor = Color.Red
            tbStatus.Text = "Open Error: " & ex.Message
        End Try
    End Sub

    Private Sub comPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs)
        Try
            Threading.Thread.Sleep(2000)

            Dim msg As String = comPort.ReadExisting()
            Dim Strmsg As String = String.Empty
            Dim IntComma As Integer = 0

            IntComma = InStr(msg, ",")
            If IntComma = 0 Then
                IntComma = 2
            End If

            Strmsg = msg
            Strmsg = Replace(Strmsg, vbCr, "")
            Strmsg = Replace(Strmsg, vbCrLf, "")
            Strmsg = Replace(Strmsg, vbLf, "")

            SetText(Strmsg)
        Catch ex As Exception
            SetStatus("Receive Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SetText(strmsg As String)
        If Me.InvokeRequired Then
            Dim args() As String = {strmsg}
            Me.Invoke(New Action(Of String)(AddressOf SetText), args)
            Return
        End If
        tbResult.Text += strmsg
    End Sub

    Private Sub SetStatus(strmsg As String)
        If Me.InvokeRequired Then
            Dim args() As String = {strmsg}
            Me.Invoke(New Action(Of String)(AddressOf SetStatus), args)
            Return
        End If
        tbStatus.Text += strmsg
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            If comPort.IsOpen = True Then
                comPort.Close()
            End If

            tbStatus.BackColor = Color.Red
            tbStatus.Text = "Closed"
        Catch ex As Exception
            tbStatus.BackColor = Color.Red
            tbStatus.Text = "Close Error: " & ex.Message
        End Try
    End Sub
End Class
