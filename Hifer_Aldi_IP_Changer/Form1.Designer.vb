<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Step1 = New System.Windows.Forms.GroupBox()
        Me.dgvHosts = New System.Windows.Forms.DataGridView()
        Me.HostName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Host = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pingOutput = New System.Windows.Forms.ListBox()
        Me.PingButton = New System.Windows.Forms.Button()
        Me.localIPAdress = New System.Windows.Forms.Label()
        Me.Step2 = New System.Windows.Forms.GroupBox()
        Me.OpenChecklist = New System.Windows.Forms.Button()
        Me.OpenExcel = New System.Windows.Forms.Button()
        Me.Step3 = New System.Windows.Forms.GroupBox()
        Me.SetSysConIP = New System.Windows.Forms.Button()
        Me.Step4 = New System.Windows.Forms.GroupBox()
        Me.SetLocalIp = New System.Windows.Forms.Button()
        Me.Ok = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Step1.SuspendLayout()
        CType(Me.dgvHosts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Step2.SuspendLayout()
        Me.Step3.SuspendLayout()
        Me.Step4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Step1
        '
        Me.Step1.Controls.Add(Me.dgvHosts)
        Me.Step1.Controls.Add(Me.pingOutput)
        Me.Step1.Controls.Add(Me.PingButton)
        Me.Step1.Controls.Add(Me.localIPAdress)
        Me.Step1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Step1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Step1.Location = New System.Drawing.Point(16, 15)
        Me.Step1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Step1.Name = "Step1"
        Me.Step1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Step1.Size = New System.Drawing.Size(683, 178)
        Me.Step1.TabIndex = 0
        Me.Step1.TabStop = False
        Me.Step1.Text = "Step 1"
        '
        'dgvHosts
        '
        Me.dgvHosts.AllowUserToDeleteRows = False
        Me.dgvHosts.AllowUserToResizeColumns = False
        Me.dgvHosts.AllowUserToResizeRows = False
        Me.dgvHosts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHosts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HostName, Me.Host})
        Me.dgvHosts.Location = New System.Drawing.Point(12, 68)
        Me.dgvHosts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvHosts.Name = "dgvHosts"
        Me.dgvHosts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvHosts.RowHeadersVisible = False
        Me.dgvHosts.RowHeadersWidth = 51
        Me.dgvHosts.Size = New System.Drawing.Size(261, 103)
        Me.dgvHosts.TabIndex = 1
        '
        'HostName
        '
        Me.HostName.HeaderText = "Name"
        Me.HostName.MaxInputLength = 20
        Me.HostName.MinimumWidth = 6
        Me.HostName.Name = "HostName"
        '
        'Host
        '
        Me.Host.HeaderText = "Host"
        Me.Host.MaxInputLength = 15
        Me.Host.MinimumWidth = 6
        Me.Host.Name = "Host"
        '
        'pingOutput
        '
        Me.pingOutput.FormattingEnabled = True
        Me.pingOutput.ItemHeight = 20
        Me.pingOutput.Location = New System.Drawing.Point(281, 68)
        Me.pingOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pingOutput.Name = "pingOutput"
        Me.pingOutput.Size = New System.Drawing.Size(260, 84)
        Me.pingOutput.TabIndex = 1
        '
        'PingButton
        '
        Me.PingButton.Location = New System.Drawing.Point(569, 140)
        Me.PingButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PingButton.Name = "PingButton"
        Me.PingButton.Size = New System.Drawing.Size(105, 31)
        Me.PingButton.TabIndex = 1
        Me.PingButton.Text = "Ping"
        Me.PingButton.UseVisualStyleBackColor = True
        '
        'localIPAdress
        '
        Me.localIPAdress.AutoSize = True
        Me.localIPAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.localIPAdress.Location = New System.Drawing.Point(8, 22)
        Me.localIPAdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.localIPAdress.Name = "localIPAdress"
        Me.localIPAdress.Size = New System.Drawing.Size(59, 20)
        Me.localIPAdress.TabIndex = 0
        Me.localIPAdress.Text = "Label1"
        '
        'Step2
        '
        Me.Step2.Controls.Add(Me.OpenChecklist)
        Me.Step2.Controls.Add(Me.OpenExcel)
        Me.Step2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Step2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Step2.Location = New System.Drawing.Point(17, 214)
        Me.Step2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Step2.Name = "Step2"
        Me.Step2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Step2.Size = New System.Drawing.Size(337, 73)
        Me.Step2.TabIndex = 1
        Me.Step2.TabStop = False
        Me.Step2.Text = "Step 2"
        '
        'OpenChecklist
        '
        Me.OpenChecklist.Location = New System.Drawing.Point(144, 26)
        Me.OpenChecklist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OpenChecklist.Name = "OpenChecklist"
        Me.OpenChecklist.Size = New System.Drawing.Size(185, 28)
        Me.OpenChecklist.TabIndex = 1
        Me.OpenChecklist.Text = "Open SPC Checklist"
        Me.OpenChecklist.UseVisualStyleBackColor = True
        '
        'OpenExcel
        '
        Me.OpenExcel.Location = New System.Drawing.Point(11, 26)
        Me.OpenExcel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OpenExcel.Name = "OpenExcel"
        Me.OpenExcel.Size = New System.Drawing.Size(125, 28)
        Me.OpenExcel.TabIndex = 0
        Me.OpenExcel.Text = "Open Excel"
        Me.OpenExcel.UseVisualStyleBackColor = True
        '
        'Step3
        '
        Me.Step3.Controls.Add(Me.SetSysConIP)
        Me.Step3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Step3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Step3.Location = New System.Drawing.Point(364, 214)
        Me.Step3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Step3.Name = "Step3"
        Me.Step3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Step3.Size = New System.Drawing.Size(337, 73)
        Me.Step3.TabIndex = 2
        Me.Step3.TabStop = False
        Me.Step3.Text = "Step 3"
        '
        'SetSysConIP
        '
        Me.SetSysConIP.Location = New System.Drawing.Point(93, 26)
        Me.SetSysConIP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SetSysConIP.Name = "SetSysConIP"
        Me.SetSysConIP.Size = New System.Drawing.Size(152, 28)
        Me.SetSysConIP.TabIndex = 1
        Me.SetSysConIP.Text = "Set SysCon IP"
        Me.SetSysConIP.UseVisualStyleBackColor = True
        '
        'Step4
        '
        Me.Step4.Controls.Add(Me.SetLocalIp)
        Me.Step4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Step4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Step4.Location = New System.Drawing.Point(17, 294)
        Me.Step4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Step4.Name = "Step4"
        Me.Step4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Step4.Size = New System.Drawing.Size(337, 75)
        Me.Step4.TabIndex = 3
        Me.Step4.TabStop = False
        Me.Step4.Text = "Step 4"
        '
        'SetLocalIp
        '
        Me.SetLocalIp.Location = New System.Drawing.Point(11, 26)
        Me.SetLocalIp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SetLocalIp.Name = "SetLocalIp"
        Me.SetLocalIp.Size = New System.Drawing.Size(133, 32)
        Me.SetLocalIp.TabIndex = 0
        Me.SetLocalIp.Text = "Set local IP"
        Me.SetLocalIp.UseVisualStyleBackColor = True
        '
        'Ok
        '
        Me.Ok.Location = New System.Drawing.Point(96, 427)
        Me.Ok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(135, 28)
        Me.Ok.TabIndex = 4
        Me.Ok.Text = "Ok"
        Me.Ok.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(424, 427)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(135, 28)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 508)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.Step4)
        Me.Controls.Add(Me.Step3)
        Me.Controls.Add(Me.Step2)
        Me.Controls.Add(Me.Step1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Hofer/Aldi IP Changer"
        Me.Step1.ResumeLayout(False)
        Me.Step1.PerformLayout()
        CType(Me.dgvHosts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Step2.ResumeLayout(False)
        Me.Step3.ResumeLayout(False)
        Me.Step4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Step1 As GroupBox
    Friend WithEvents localIPAdress As Label
    Friend WithEvents PingButton As Button
    Friend WithEvents pingOutput As ListBox
    Friend WithEvents dgvHosts As DataGridView
    Friend WithEvents HostName As DataGridViewTextBoxColumn
    Friend WithEvents Host As DataGridViewTextBoxColumn
    Friend WithEvents Step2 As GroupBox
    Friend WithEvents OpenExcel As Button
    Friend WithEvents OpenChecklist As Button
    Friend WithEvents Step3 As GroupBox
    Friend WithEvents SetSysConIP As Button
    Friend WithEvents Step4 As GroupBox
    Friend WithEvents SetLocalIp As Button
    Friend WithEvents Ok As Button
    Friend WithEvents Cancel As Button
End Class
