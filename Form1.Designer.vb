<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ADB_WIFI = New System.Windows.Forms.Button()
        Me.CLASSIC_STRT = New System.Windows.Forms.Button()
        Me.PORT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IPADDR = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ADB_WIFI
        '
        Me.ADB_WIFI.Location = New System.Drawing.Point(63, 128)
        Me.ADB_WIFI.Name = "ADB_WIFI"
        Me.ADB_WIFI.Size = New System.Drawing.Size(124, 46)
        Me.ADB_WIFI.TabIndex = 2
        Me.ADB_WIFI.Text = "Start ADB WiFi"
        Me.ADB_WIFI.UseVisualStyleBackColor = True
        '
        'CLASSIC_STRT
        '
        Me.CLASSIC_STRT.Location = New System.Drawing.Point(239, 128)
        Me.CLASSIC_STRT.Name = "CLASSIC_STRT"
        Me.CLASSIC_STRT.Size = New System.Drawing.Size(124, 46)
        Me.CLASSIC_STRT.TabIndex = 3
        Me.CLASSIC_STRT.Text = "Classic Shizuku Start"
        Me.CLASSIC_STRT.UseVisualStyleBackColor = True
        '
        'PORT
        '
        Me.PORT.Location = New System.Drawing.Point(251, 57)
        Me.PORT.MaxLength = 5
        Me.PORT.Name = "PORT"
        Me.PORT.Size = New System.Drawing.Size(112, 22)
        Me.PORT.TabIndex = 1
        Me.PORT.Text = "Port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IP Address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Classic Shizuku WiFi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IPADDR
        '
        Me.IPADDR.Location = New System.Drawing.Point(63, 57)
        Me.IPADDR.Name = "IPADDR"
        Me.IPADDR.Size = New System.Drawing.Size(124, 22)
        Me.IPADDR.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 251)
        Me.Controls.Add(Me.IPADDR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PORT)
        Me.Controls.Add(Me.CLASSIC_STRT)
        Me.Controls.Add(Me.ADB_WIFI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Shizuku Starter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ADB_WIFI As Button
    Friend WithEvents CLASSIC_STRT As Button
    Friend WithEvents PORT As TextBox

    Private Sub CLASSIC_STRT_Click(sender As Object, e As EventArgs) Handles CLASSIC_STRT.Click
        Dim pg As String
        Dim path As String = My.Application.Info.DirectoryPath
        Dim prog_name As String = "adb.exe "
        Dim argu1 As String = "shell sh /data/user_de/0/moe.shizuku.privileged.api/start.sh"

        pg = path + "\" + prog_name + argu1
        Shell(pg, AppWinStyle.NormalFocus)
    End Sub

    'TODO: Thread this shit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ADB_WIFI.Click
        Dim adb_connect As String
        Dim path As String = My.Application.Info.DirectoryPath
        Dim prog_name As String = "adb.exe "
        Dim tcp1 As String = "tcpip "

        'Check if the IP address or Port is valid
        If IPADDR.Text = "" Or PORT.Text = "Port" Then
            MessageBox.Show("Please enter a valid IP Address or port number")
        Else

            adb_connect = path + "\" + prog_name + tcp1 + PORT.Text
            Shell(adb_connect, AppWinStyle.NormalFocus)

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pg As String
        Dim path As String = My.Application.Info.DirectoryPath
        Dim prog_name As String = "adb.exe "
        Dim argu1 As String = "kill-server"

        pg = path + "\" + prog_name + argu1

        ' Basic check if file exists check so we don't outright crash
        If System.IO.File.Exists(pg) = False Then
            MessageBox.Show("adb not found. Please make sure it is in the directory")
            Close()
        Else
            Shell(pg, AppWinStyle.Hide)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PORT_TextChanged(sender As Object, e As EventArgs) Handles PORT.TextChanged

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pg As String
        Dim path As String = My.Application.Info.DirectoryPath
        Dim prog_name As String = "adb.exe "
        Dim argu1 As String = "shell sh /data/user_de/0/moe.shizuku.privileged.api/start.sh"
        Dim adb_connect As String
        Dim tcp1 As String = "tcpip "

        adb_connect = path + "\" + prog_name + "connect " + IPADDR.Text + ":" + PORT.Text
        Shell(adb_connect, AppWinStyle.NormalFocus)
        Threading.Thread.Sleep(1000)
        pg = path + "\" + prog_name + " " + argu1
        Shell(pg, AppWinStyle.NormalFocus)
    End Sub

    Friend WithEvents IPADDR As TextBox
End Class
