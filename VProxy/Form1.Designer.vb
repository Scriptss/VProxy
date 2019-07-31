<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbImport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExport = New System.Windows.Forms.ToolStripButton()
        Me.tsbStart = New System.Windows.Forms.ToolStripButton()
        Me.dgvProxy = New System.Windows.Forms.DataGridView()
        Me.clmIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAnonymity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCounty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmResponseTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        CType(Me.dgvProxy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbImport, Me.ToolStripSeparator1, Me.tsbExport, Me.tsbStart})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(709, 25)
        Me.tsMenu.TabIndex = 15
        Me.tsMenu.Text = "Menu"
        '
        'tsbImport
        '
        Me.tsbImport.Image = Global.VProxy.My.Resources.Resources.icons8_add_48
        Me.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImport.Name = "tsbImport"
        Me.tsbImport.Size = New System.Drawing.Size(103, 22)
        Me.tsbImport.Text = "Import Proxies"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExport
        '
        Me.tsbExport.Image = Global.VProxy.My.Resources.Resources.icons8_save_48
        Me.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExport.Name = "tsbExport"
        Me.tsbExport.Size = New System.Drawing.Size(91, 22)
        Me.tsbExport.Text = "Save Proxies"
        '
        'tsbStart
        '
        Me.tsbStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbStart.Image = Global.VProxy.My.Resources.Resources.icons8_play_48
        Me.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStart.Name = "tsbStart"
        Me.tsbStart.Size = New System.Drawing.Size(51, 22)
        Me.tsbStart.Text = "Start"
        '
        'dgvProxy
        '
        Me.dgvProxy.AllowUserToAddRows = False
        Me.dgvProxy.AllowUserToDeleteRows = False
        Me.dgvProxy.AllowUserToResizeColumns = False
        Me.dgvProxy.AllowUserToResizeRows = False
        Me.dgvProxy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProxy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProxy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIP, Me.clmPort, Me.clmAnonymity, Me.clmCounty, Me.clmResponseTime})
        Me.dgvProxy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProxy.Location = New System.Drawing.Point(0, 28)
        Me.dgvProxy.MultiSelect = False
        Me.dgvProxy.Name = "dgvProxy"
        Me.dgvProxy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProxy.Size = New System.Drawing.Size(709, 211)
        Me.dgvProxy.TabIndex = 17
        '
        'clmIP
        '
        Me.clmIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmIP.HeaderText = "IP"
        Me.clmIP.Name = "clmIP"
        Me.clmIP.Width = 42
        '
        'clmPort
        '
        Me.clmPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmPort.HeaderText = "Port"
        Me.clmPort.Name = "clmPort"
        Me.clmPort.Width = 51
        '
        'clmAnonymity
        '
        Me.clmAnonymity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmAnonymity.HeaderText = "Anonymity"
        Me.clmAnonymity.Name = "clmAnonymity"
        Me.clmAnonymity.Width = 80
        '
        'clmCounty
        '
        Me.clmCounty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmCounty.HeaderText = "Country"
        Me.clmCounty.Name = "clmCounty"
        Me.clmCounty.Width = 68
        '
        'clmResponseTime
        '
        Me.clmResponseTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmResponseTime.HeaderText = "Response Time"
        Me.clmResponseTime.Name = "clmResponseTime"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(0, 245)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(493, 23)
        Me.progressBar.Step = 1
        Me.progressBar.TabIndex = 19
        '
        'lblstatus
        '
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(499, 245)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(210, 23)
        Me.lblstatus.TabIndex = 20
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 270)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.dgvProxy)
        Me.Controls.Add(Me.tsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "VProxy"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.dgvProxy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents tsbImport As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbExport As ToolStripButton
    Friend WithEvents dgvProxy As DataGridView
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents clmIP As DataGridViewTextBoxColumn
    Friend WithEvents clmPort As DataGridViewTextBoxColumn
    Friend WithEvents clmAnonymity As DataGridViewTextBoxColumn
    Friend WithEvents clmCounty As DataGridViewTextBoxColumn
    Friend WithEvents clmResponseTime As DataGridViewTextBoxColumn
    Friend WithEvents tsbStart As ToolStripButton
    Friend WithEvents lblstatus As Label
End Class
