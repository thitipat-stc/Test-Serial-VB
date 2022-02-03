<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.tbStatus = New System.Windows.Forms.TextBox()
        Me.tbBaudRate = New System.Windows.Forms.TextBox()
        Me.tbDataBits = New System.Windows.Forms.TextBox()
        Me.tbStopBits = New System.Windows.Forms.TextBox()
        Me.tbParity = New System.Windows.Forms.TextBox()
        Me.tbPortName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(415, 16)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(97, 41)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(518, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 41)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tbResult
        '
        Me.tbResult.Location = New System.Drawing.Point(12, 120)
        Me.tbResult.Multiline = True
        Me.tbResult.Name = "tbResult"
        Me.tbResult.Size = New System.Drawing.Size(776, 318)
        Me.tbResult.TabIndex = 3
        '
        'tbStatus
        '
        Me.tbStatus.Location = New System.Drawing.Point(292, 80)
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(323, 26)
        Me.tbStatus.TabIndex = 4
        '
        'tbBaudRate
        '
        Me.tbBaudRate.Location = New System.Drawing.Point(100, 16)
        Me.tbBaudRate.Name = "tbBaudRate"
        Me.tbBaudRate.Size = New System.Drawing.Size(100, 26)
        Me.tbBaudRate.TabIndex = 5
        Me.tbBaudRate.Text = "9600"
        '
        'tbDataBits
        '
        Me.tbDataBits.Location = New System.Drawing.Point(100, 48)
        Me.tbDataBits.Name = "tbDataBits"
        Me.tbDataBits.Size = New System.Drawing.Size(100, 26)
        Me.tbDataBits.TabIndex = 6
        Me.tbDataBits.Text = "8"
        '
        'tbStopBits
        '
        Me.tbStopBits.Location = New System.Drawing.Point(100, 80)
        Me.tbStopBits.Name = "tbStopBits"
        Me.tbStopBits.Size = New System.Drawing.Size(100, 26)
        Me.tbStopBits.TabIndex = 7
        Me.tbStopBits.Text = "1"
        '
        'tbParity
        '
        Me.tbParity.Location = New System.Drawing.Point(292, 16)
        Me.tbParity.Name = "tbParity"
        Me.tbParity.Size = New System.Drawing.Size(100, 26)
        Me.tbParity.TabIndex = 8
        Me.tbParity.Text = "0"
        '
        'tbPortName
        '
        Me.tbPortName.Location = New System.Drawing.Point(292, 48)
        Me.tbPortName.Name = "tbPortName"
        Me.tbPortName.Size = New System.Drawing.Size(100, 26)
        Me.tbPortName.TabIndex = 9
        Me.tbPortName.Text = "Com3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BaudRate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "DataBits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "StopBits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Parity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "PortName"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPortName)
        Me.Controls.Add(Me.tbParity)
        Me.Controls.Add(Me.tbStopBits)
        Me.Controls.Add(Me.tbDataBits)
        Me.Controls.Add(Me.tbBaudRate)
        Me.Controls.Add(Me.tbStatus)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents tbResult As TextBox
    Friend WithEvents tbStatus As TextBox
    Friend WithEvents tbBaudRate As TextBox
    Friend WithEvents tbDataBits As TextBox
    Friend WithEvents tbStopBits As TextBox
    Friend WithEvents tbParity As TextBox
    Friend WithEvents tbPortName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
