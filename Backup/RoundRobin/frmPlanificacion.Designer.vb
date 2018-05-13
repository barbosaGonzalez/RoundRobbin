<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanificacion
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdProcesar = New System.Windows.Forms.Button
        Me.lblQuantun = New System.Windows.Forms.Label
        Me.txtQuantum = New System.Windows.Forms.NumericUpDown
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.txtRequerimientoCPU = New System.Windows.Forms.NumericUpDown
        Me.txtProceso = New System.Windows.Forms.TextBox
        Me.lblProceso = New System.Windows.Forms.Label
        Me.lblReCPU = New System.Windows.Forms.Label
        Me.tblprocesos = New System.Windows.Forms.DataGridView
        Me.ColProceso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColReCPU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColColor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPendiente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpRoundRobin = New System.Windows.Forms.GroupBox
        Me.dgridRoundRobin = New System.Windows.Forms.DataGridView
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblRoundRobin = New System.Windows.Forms.Label
        Me.time = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtQuantum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtRequerimientoCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblprocesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRoundRobin.SuspendLayout()
        CType(Me.dgridRoundRobin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdProcesar)
        Me.GroupBox1.Controls.Add(Me.lblQuantun)
        Me.GroupBox1.Controls.Add(Me.txtQuantum)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmdProcesar
        '
        Me.cmdProcesar.BackColor = System.Drawing.Color.AliceBlue
        Me.cmdProcesar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProcesar.Location = New System.Drawing.Point(3, 90)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(428, 38)
        Me.cmdProcesar.TabIndex = 2
        Me.cmdProcesar.Text = "Procesar"
        Me.cmdProcesar.UseVisualStyleBackColor = False
        '
        'lblQuantun
        '
        Me.lblQuantun.AutoSize = True
        Me.lblQuantun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantun.Location = New System.Drawing.Point(32, 31)
        Me.lblQuantun.Name = "lblQuantun"
        Me.lblQuantun.Size = New System.Drawing.Size(95, 24)
        Me.lblQuantun.TabIndex = 0
        Me.lblQuantun.Text = "Quantum"
        '
        'txtQuantum
        '
        Me.txtQuantum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantum.Location = New System.Drawing.Point(150, 29)
        Me.txtQuantum.Name = "txtQuantum"
        Me.txtQuantum.Size = New System.Drawing.Size(68, 29)
        Me.txtQuantum.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.tblprocesos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 472)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdAgregar)
        Me.GroupBox3.Controls.Add(Me.txtRequerimientoCPU)
        Me.GroupBox3.Controls.Add(Me.txtProceso)
        Me.GroupBox3.Controls.Add(Me.lblProceso)
        Me.GroupBox3.Controls.Add(Me.lblReCPU)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 129)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'cmdAgregar
        '
        Me.cmdAgregar.BackColor = System.Drawing.Color.AliceBlue
        Me.cmdAgregar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(3, 91)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(315, 35)
        Me.cmdAgregar.TabIndex = 4
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = False
        '
        'txtRequerimientoCPU
        '
        Me.txtRequerimientoCPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtRequerimientoCPU.Location = New System.Drawing.Point(160, 51)
        Me.txtRequerimientoCPU.Name = "txtRequerimientoCPU"
        Me.txtRequerimientoCPU.Size = New System.Drawing.Size(145, 22)
        Me.txtRequerimientoCPU.TabIndex = 3
        '
        'txtProceso
        '
        Me.txtProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProceso.Location = New System.Drawing.Point(160, 23)
        Me.txtProceso.Name = "txtProceso"
        Me.txtProceso.Size = New System.Drawing.Size(145, 22)
        Me.txtProceso.TabIndex = 0
        '
        'lblProceso
        '
        Me.lblProceso.AutoSize = True
        Me.lblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProceso.Location = New System.Drawing.Point(10, 32)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(66, 16)
        Me.lblProceso.TabIndex = 1
        Me.lblProceso.Text = "Proceso"
        '
        'lblReCPU
        '
        Me.lblReCPU.AutoSize = True
        Me.lblReCPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReCPU.Location = New System.Drawing.Point(10, 55)
        Me.lblReCPU.Name = "lblReCPU"
        Me.lblReCPU.Size = New System.Drawing.Size(144, 16)
        Me.lblReCPU.TabIndex = 2
        Me.lblReCPU.Text = "Requerimiento CPU"
        '
        'tblprocesos
        '
        Me.tblprocesos.BackgroundColor = System.Drawing.Color.White
        Me.tblprocesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblprocesos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColProceso, Me.ColReCPU, Me.ColColor, Me.ColPendiente})
        Me.tblprocesos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tblprocesos.Location = New System.Drawing.Point(3, 184)
        Me.tblprocesos.Name = "tblprocesos"
        Me.tblprocesos.Size = New System.Drawing.Size(428, 285)
        Me.tblprocesos.TabIndex = 1
        '
        'ColProceso
        '
        Me.ColProceso.HeaderText = "Proceo"
        Me.ColProceso.Name = "ColProceso"
        '
        'ColReCPU
        '
        Me.ColReCPU.HeaderText = "Requerimiento CPU"
        Me.ColReCPU.Name = "ColReCPU"
        '
        'ColColor
        '
        Me.ColColor.HeaderText = "Color"
        Me.ColColor.Name = "ColColor"
        Me.ColColor.Width = 80
        '
        'ColPendiente
        '
        Me.ColPendiente.HeaderText = "Pendiente"
        Me.ColPendiente.Name = "ColPendiente"
        '
        'grpRoundRobin
        '
        Me.grpRoundRobin.Controls.Add(Me.dgridRoundRobin)
        Me.grpRoundRobin.Controls.Add(Me.lblRoundRobin)
        Me.grpRoundRobin.Location = New System.Drawing.Point(530, 12)
        Me.grpRoundRobin.Name = "grpRoundRobin"
        Me.grpRoundRobin.Size = New System.Drawing.Size(809, 629)
        Me.grpRoundRobin.TabIndex = 2
        Me.grpRoundRobin.TabStop = False
        '
        'dgridRoundRobin
        '
        Me.dgridRoundRobin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgridRoundRobin.BackgroundColor = System.Drawing.Color.White
        Me.dgridRoundRobin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridRoundRobin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6, Me.Col7, Me.Col8, Me.Col9, Me.Col10})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgridRoundRobin.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgridRoundRobin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgridRoundRobin.Location = New System.Drawing.Point(3, 68)
        Me.dgridRoundRobin.Name = "dgridRoundRobin"
        Me.dgridRoundRobin.Size = New System.Drawing.Size(803, 558)
        Me.dgridRoundRobin.TabIndex = 2
        '
        'Col1
        '
        Me.Col1.HeaderText = ""
        Me.Col1.Name = "Col1"
        Me.Col1.Width = 21
        '
        'Col2
        '
        Me.Col2.HeaderText = ""
        Me.Col2.Name = "Col2"
        Me.Col2.Width = 21
        '
        'Col3
        '
        Me.Col3.HeaderText = ""
        Me.Col3.Name = "Col3"
        Me.Col3.Width = 21
        '
        'Col4
        '
        Me.Col4.HeaderText = ""
        Me.Col4.Name = "Col4"
        Me.Col4.Width = 21
        '
        'Col5
        '
        Me.Col5.HeaderText = ""
        Me.Col5.Name = "Col5"
        Me.Col5.Width = 21
        '
        'Col6
        '
        Me.Col6.HeaderText = ""
        Me.Col6.Name = "Col6"
        Me.Col6.Width = 21
        '
        'Col7
        '
        Me.Col7.HeaderText = ""
        Me.Col7.Name = "Col7"
        Me.Col7.Width = 21
        '
        'Col8
        '
        Me.Col8.HeaderText = ""
        Me.Col8.Name = "Col8"
        Me.Col8.Width = 21
        '
        'Col9
        '
        Me.Col9.HeaderText = ""
        Me.Col9.Name = "Col9"
        Me.Col9.Width = 21
        '
        'Col10
        '
        Me.Col10.HeaderText = ""
        Me.Col10.Name = "Col10"
        Me.Col10.Width = 21
        '
        'lblRoundRobin
        '
        Me.lblRoundRobin.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRoundRobin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundRobin.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblRoundRobin.Location = New System.Drawing.Point(3, 16)
        Me.lblRoundRobin.Name = "lblRoundRobin"
        Me.lblRoundRobin.Size = New System.Drawing.Size(803, 24)
        Me.lblRoundRobin.TabIndex = 1
        Me.lblRoundRobin.Text = "Round Robin"
        Me.lblRoundRobin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'time
        '
        Me.time.Interval = 1000
        '
        'frmPlanificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.grpRoundRobin)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPlanificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planificación Round Robin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtQuantum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtRequerimientoCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblprocesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRoundRobin.ResumeLayout(False)
        CType(Me.dgridRoundRobin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuantun As System.Windows.Forms.Label
    Friend WithEvents txtQuantum As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdProcesar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRequerimientoCPU As System.Windows.Forms.NumericUpDown
    Friend WithEvents tblprocesos As System.Windows.Forms.DataGridView
    Friend WithEvents txtProceso As System.Windows.Forms.TextBox
    Friend WithEvents lblReCPU As System.Windows.Forms.Label
    Friend WithEvents lblProceso As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents grpRoundRobin As System.Windows.Forms.GroupBox
    Friend WithEvents lblRoundRobin As System.Windows.Forms.Label
    Friend WithEvents dgridRoundRobin As System.Windows.Forms.DataGridView
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time As System.Windows.Forms.Timer
    Friend WithEvents ColProceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColReCPU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPendiente As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
