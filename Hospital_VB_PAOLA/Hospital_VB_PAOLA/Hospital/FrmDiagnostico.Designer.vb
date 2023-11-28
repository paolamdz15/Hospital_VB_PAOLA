<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiagnostico
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDiagnostico))
        Me.DataGridViewD = New System.Windows.Forms.DataGridView()
        Me.IDDiagnosticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDMedicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDEnfermedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosticoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet = New Hospital.Hospital1DataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtResultadoD = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionD = New System.Windows.Forms.TextBox()
        Me.TxtFechaD = New System.Windows.Forms.TextBox()
        Me.CBIdMedicoD = New System.Windows.Forms.ComboBox()
        Me.MedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBIdPacienteD = New System.Windows.Forms.ComboBox()
        Me.PacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBIdEnfermedadD = New System.Windows.Forms.ComboBox()
        Me.EnfermedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiagnosticoTableAdapter = New Hospital.Hospital1DataSetTableAdapters.DiagnosticoTableAdapter()
        Me.MedicoTableAdapter = New Hospital.Hospital1DataSetTableAdapters.MedicoTableAdapter()
        Me.PacienteTableAdapter = New Hospital.Hospital1DataSetTableAdapters.PacienteTableAdapter()
        Me.EnfermedadesTableAdapter = New Hospital.Hospital1DataSetTableAdapters.EnfermedadesTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewD
        '
        Me.DataGridViewD.AutoGenerateColumns = False
        Me.DataGridViewD.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridViewD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDiagnosticoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ResultadoDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IDMedicoDataGridViewTextBoxColumn, Me.IDPacienteDataGridViewTextBoxColumn, Me.IDEnfermedadDataGridViewTextBoxColumn, Me.MedicocreaDataGridViewTextBoxColumn, Me.MedicoactualizaDataGridViewTextBoxColumn})
        Me.DataGridViewD.DataSource = Me.DiagnosticoBindingSource
        Me.DataGridViewD.Location = New System.Drawing.Point(242, 15)
        Me.DataGridViewD.Name = "DataGridViewD"
        Me.DataGridViewD.Size = New System.Drawing.Size(570, 300)
        Me.DataGridViewD.TabIndex = 15
        '
        'IDDiagnosticoDataGridViewTextBoxColumn
        '
        Me.IDDiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "ID_Diagnostico"
        Me.IDDiagnosticoDataGridViewTextBoxColumn.HeaderText = "ID_Diagnostico"
        Me.IDDiagnosticoDataGridViewTextBoxColumn.Name = "IDDiagnosticoDataGridViewTextBoxColumn"
        Me.IDDiagnosticoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'ResultadoDataGridViewTextBoxColumn
        '
        Me.ResultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.HeaderText = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.Name = "ResultadoDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        '
        'IDMedicoDataGridViewTextBoxColumn
        '
        Me.IDMedicoDataGridViewTextBoxColumn.DataPropertyName = "ID_Medico"
        Me.IDMedicoDataGridViewTextBoxColumn.HeaderText = "ID_Medico"
        Me.IDMedicoDataGridViewTextBoxColumn.Name = "IDMedicoDataGridViewTextBoxColumn"
        '
        'IDPacienteDataGridViewTextBoxColumn
        '
        Me.IDPacienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Paciente"
        Me.IDPacienteDataGridViewTextBoxColumn.HeaderText = "ID_Paciente"
        Me.IDPacienteDataGridViewTextBoxColumn.Name = "IDPacienteDataGridViewTextBoxColumn"
        '
        'IDEnfermedadDataGridViewTextBoxColumn
        '
        Me.IDEnfermedadDataGridViewTextBoxColumn.DataPropertyName = "ID_Enfermedad"
        Me.IDEnfermedadDataGridViewTextBoxColumn.HeaderText = "ID_Enfermedad"
        Me.IDEnfermedadDataGridViewTextBoxColumn.Name = "IDEnfermedadDataGridViewTextBoxColumn"
        '
        'MedicocreaDataGridViewTextBoxColumn
        '
        Me.MedicocreaDataGridViewTextBoxColumn.DataPropertyName = "Medico_crea"
        Me.MedicocreaDataGridViewTextBoxColumn.HeaderText = "Medico_crea"
        Me.MedicocreaDataGridViewTextBoxColumn.Name = "MedicocreaDataGridViewTextBoxColumn"
        '
        'MedicoactualizaDataGridViewTextBoxColumn
        '
        Me.MedicoactualizaDataGridViewTextBoxColumn.DataPropertyName = "Medico_actualiza"
        Me.MedicoactualizaDataGridViewTextBoxColumn.HeaderText = "Medico_actualiza"
        Me.MedicoactualizaDataGridViewTextBoxColumn.Name = "MedicoactualizaDataGridViewTextBoxColumn"
        '
        'DiagnosticoBindingSource
        '
        Me.DiagnosticoBindingSource.DataMember = "Diagnostico"
        Me.DiagnosticoBindingSource.DataSource = Me.Hospital1DataSet
        '
        'Hospital1DataSet
        '
        Me.Hospital1DataSet.DataSetName = "Hospital1DataSet"
        Me.Hospital1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(637, 328)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(537, 328)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 13
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(437, 328)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 12
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 25)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "DIAGNOSTICOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Enfermedad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Paciente:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = " Medico:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Resultado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Fecha:"
        '
        'TxtResultadoD
        '
        Me.TxtResultadoD.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultadoD.Location = New System.Drawing.Point(17, 172)
        Me.TxtResultadoD.Name = "TxtResultadoD"
        Me.TxtResultadoD.Size = New System.Drawing.Size(219, 22)
        Me.TxtResultadoD.TabIndex = 29
        '
        'TxtDescripcionD
        '
        Me.TxtDescripcionD.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionD.Location = New System.Drawing.Point(18, 125)
        Me.TxtDescripcionD.Name = "TxtDescripcionD"
        Me.TxtDescripcionD.Size = New System.Drawing.Size(218, 22)
        Me.TxtDescripcionD.TabIndex = 28
        '
        'TxtFechaD
        '
        Me.TxtFechaD.Location = New System.Drawing.Point(103, 78)
        Me.TxtFechaD.Name = "TxtFechaD"
        Me.TxtFechaD.Size = New System.Drawing.Size(133, 20)
        Me.TxtFechaD.TabIndex = 27
        '
        'CBIdMedicoD
        '
        Me.CBIdMedicoD.DataSource = Me.MedicoBindingSource
        Me.CBIdMedicoD.DisplayMember = "Nombre"
        Me.CBIdMedicoD.FormattingEnabled = True
        Me.CBIdMedicoD.Location = New System.Drawing.Point(103, 210)
        Me.CBIdMedicoD.Name = "CBIdMedicoD"
        Me.CBIdMedicoD.Size = New System.Drawing.Size(133, 21)
        Me.CBIdMedicoD.TabIndex = 42
        Me.CBIdMedicoD.ValueMember = "ID_Medico"
        '
        'MedicoBindingSource
        '
        Me.MedicoBindingSource.DataMember = "Medico"
        Me.MedicoBindingSource.DataSource = Me.Hospital1DataSet
        '
        'CBIdPacienteD
        '
        Me.CBIdPacienteD.DataSource = Me.PacienteBindingSource
        Me.CBIdPacienteD.DisplayMember = "NombreP"
        Me.CBIdPacienteD.FormattingEnabled = True
        Me.CBIdPacienteD.Location = New System.Drawing.Point(103, 247)
        Me.CBIdPacienteD.Name = "CBIdPacienteD"
        Me.CBIdPacienteD.Size = New System.Drawing.Size(133, 21)
        Me.CBIdPacienteD.TabIndex = 43
        Me.CBIdPacienteD.ValueMember = "ID_Paciente"
        '
        'PacienteBindingSource
        '
        Me.PacienteBindingSource.DataMember = "Paciente"
        Me.PacienteBindingSource.DataSource = Me.Hospital1DataSet
        '
        'CBIdEnfermedadD
        '
        Me.CBIdEnfermedadD.DataSource = Me.EnfermedadesBindingSource
        Me.CBIdEnfermedadD.DisplayMember = "NombreE"
        Me.CBIdEnfermedadD.FormattingEnabled = True
        Me.CBIdEnfermedadD.Location = New System.Drawing.Point(103, 285)
        Me.CBIdEnfermedadD.Name = "CBIdEnfermedadD"
        Me.CBIdEnfermedadD.Size = New System.Drawing.Size(133, 21)
        Me.CBIdEnfermedadD.TabIndex = 44
        Me.CBIdEnfermedadD.ValueMember = "ID_Enfermedad"
        '
        'EnfermedadesBindingSource
        '
        Me.EnfermedadesBindingSource.DataMember = "Enfermedades"
        Me.EnfermedadesBindingSource.DataSource = Me.Hospital1DataSet
        '
        'DiagnosticoTableAdapter
        '
        Me.DiagnosticoTableAdapter.ClearBeforeFill = True
        '
        'MedicoTableAdapter
        '
        Me.MedicoTableAdapter.ClearBeforeFill = True
        '
        'PacienteTableAdapter
        '
        Me.PacienteTableAdapter.ClearBeforeFill = True
        '
        'EnfermedadesTableAdapter
        '
        Me.EnfermedadesTableAdapter.ClearBeforeFill = True
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(737, 327)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 45
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'FrmDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.CBIdEnfermedadD)
        Me.Controls.Add(Me.CBIdPacienteD)
        Me.Controls.Add(Me.CBIdMedicoD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtResultadoD)
        Me.Controls.Add(Me.TxtDescripcionD)
        Me.Controls.Add(Me.TxtFechaD)
        Me.Controls.Add(Me.DataGridViewD)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDiagnostico"
        Me.Text = "FrmDiagnostico"
        CType(Me.DataGridViewD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiagnosticoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfermedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewD As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtResultadoD As TextBox
    Friend WithEvents TxtDescripcionD As TextBox
    Friend WithEvents TxtFechaD As TextBox
    Friend WithEvents CBIdMedicoD As ComboBox
    Friend WithEvents CBIdPacienteD As ComboBox
    Friend WithEvents CBIdEnfermedadD As ComboBox
    Friend WithEvents Hospital1DataSet As Hospital1DataSet
    Friend WithEvents DiagnosticoBindingSource As BindingSource
    Friend WithEvents DiagnosticoTableAdapter As Hospital1DataSetTableAdapters.DiagnosticoTableAdapter
    Friend WithEvents IDDiagnosticoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDMedicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDEnfermedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoBindingSource As BindingSource
    Friend WithEvents MedicoTableAdapter As Hospital1DataSetTableAdapters.MedicoTableAdapter
    Friend WithEvents PacienteBindingSource As BindingSource
    Friend WithEvents PacienteTableAdapter As Hospital1DataSetTableAdapters.PacienteTableAdapter
    Friend WithEvents EnfermedadesBindingSource As BindingSource
    Friend WithEvents EnfermedadesTableAdapter As Hospital1DataSetTableAdapters.EnfermedadesTableAdapter
    Private WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
