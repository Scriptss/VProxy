<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExport))
        Me.clbCountry = New System.Windows.Forms.CheckedListBox()
        Me.clbAnonymity = New System.Windows.Forms.CheckedListBox()
        Me.lblAnonymity = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblResponseTime = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.nudResponseTime = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudResponseTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clbCountry
        '
        Me.clbCountry.FormattingEnabled = True
        Me.clbCountry.Location = New System.Drawing.Point(131, 38)
        Me.clbCountry.Name = "clbCountry"
        Me.clbCountry.Size = New System.Drawing.Size(134, 139)
        Me.clbCountry.TabIndex = 0
        '
        'clbAnonymity
        '
        Me.clbAnonymity.FormattingEnabled = True
        Me.clbAnonymity.Location = New System.Drawing.Point(12, 38)
        Me.clbAnonymity.Name = "clbAnonymity"
        Me.clbAnonymity.Size = New System.Drawing.Size(113, 139)
        Me.clbAnonymity.TabIndex = 2
        '
        'lblAnonymity
        '
        Me.lblAnonymity.AutoSize = True
        Me.lblAnonymity.Location = New System.Drawing.Point(9, 22)
        Me.lblAnonymity.Name = "lblAnonymity"
        Me.lblAnonymity.Size = New System.Drawing.Size(55, 13)
        Me.lblAnonymity.TabIndex = 3
        Me.lblAnonymity.Text = "Anonymity"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(128, 22)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(43, 13)
        Me.lblCountry.TabIndex = 4
        Me.lblCountry.Text = "Country"
        '
        'lblResponseTime
        '
        Me.lblResponseTime.AutoSize = True
        Me.lblResponseTime.Location = New System.Drawing.Point(268, 22)
        Me.lblResponseTime.Name = "lblResponseTime"
        Me.lblResponseTime.Size = New System.Drawing.Size(126, 13)
        Me.lblResponseTime.TabIndex = 5
        Me.lblResponseTime.Text = "Max Response Time (ms)"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(12, 183)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(379, 23)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'nudResponseTime
        '
        Me.nudResponseTime.Location = New System.Drawing.Point(271, 38)
        Me.nudResponseTime.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudResponseTime.Name = "nudResponseTime"
        Me.nudResponseTime.Size = New System.Drawing.Size(120, 20)
        Me.nudResponseTime.TabIndex = 7
        Me.nudResponseTime.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'frmExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 216)
        Me.Controls.Add(Me.nudResponseTime)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblResponseTime)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblAnonymity)
        Me.Controls.Add(Me.clbAnonymity)
        Me.Controls.Add(Me.clbCountry)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExport"
        Me.Text = "Export"
        Me.TopMost = True
        CType(Me.nudResponseTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clbCountry As CheckedListBox
    Friend WithEvents clbAnonymity As CheckedListBox
    Friend WithEvents lblAnonymity As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblResponseTime As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents nudResponseTime As NumericUpDown
End Class
