<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAtencion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAtencion))
        Me.DataGridViewAtencion = New System.Windows.Forms.DataGridView()
        Me.IDAtencionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDMedicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtencionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet = New Hospital.Hospital1DataSet()
        Me.BtnEliminarA = New System.Windows.Forms.Button()
        Me.BtnAgregarA = New System.Windows.Forms.Button()
        Me.BtnActualizarA = New System.Windows.Forms.Button()
        Me.TxtFechaA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtHoraIA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtHoraFA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AtencionTableAdapter = New Hospital.Hospital1DataSetTableAdapters.AtencionTableAdapter()
        Me.CBIdMedA = New System.Windows.Forms.ComboBox()
        Me.MedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBIdPacienteA = New System.Windows.Forms.ComboBox()
        Me.PacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicoTableAdapter = New Hospital.Hospital1DataSetTableAdapters.MedicoTableAdapter()
        Me.PacienteTableAdapter = New Hospital.Hospital1DataSetTableAdapters.PacienteTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtencionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewAtencion
        '
        Me.DataGridViewAtencion.AutoGenerateColumns = False
        Me.DataGridViewAtencion.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridViewAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAtencion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAtencionDataGridViewTextBoxColumn, Me.FechaADataGridViewTextBoxColumn, Me.HoraInicioDataGridViewTextBoxColumn, Me.HoraFinDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IDMedicoDataGridViewTextBoxColumn, Me.IDPacienteDataGridViewTextBoxColumn, Me.MedicocreaDataGridViewTextBoxColumn, Me.MedicoactualizaDataGridViewTextBoxColumn})
        Me.DataGridViewAtencion.DataSource = Me.AtencionBindingSource
        Me.DataGridViewAtencion.Location = New System.Drawing.Point(198, 15)
        Me.DataGridViewAtencion.Name = "DataGridViewAtencion"
        Me.DataGridViewAtencion.Size = New System.Drawing.Size(614, 300)
        Me.DataGridViewAtencion.TabIndex = 7
        '
        'IDAtencionDataGridViewTextBoxColumn
        '
        Me.IDAtencionDataGridViewTextBoxColumn.DataPropertyName = "ID_Atencion"
        Me.IDAtencionDataGridViewTextBoxColumn.HeaderText = "ID_Atencion"
        Me.IDAtencionDataGridViewTextBoxColumn.Name = "IDAtencionDataGridViewTextBoxColumn"
        Me.IDAtencionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaADataGridViewTextBoxColumn
        '
        Me.FechaADataGridViewTextBoxColumn.DataPropertyName = "FechaA"
        Me.FechaADataGridViewTextBoxColumn.HeaderText = "FechaA"
        Me.FechaADataGridViewTextBoxColumn.Name = "FechaADataGridViewTextBoxColumn"
        '
        'HoraInicioDataGridViewTextBoxColumn
        '
        Me.HoraInicioDataGridViewTextBoxColumn.DataPropertyName = "Hora_Inicio"
        Me.HoraInicioDataGridViewTextBoxColumn.HeaderText = "Hora_Inicio"
        Me.HoraInicioDataGridViewTextBoxColumn.Name = "HoraInicioDataGridViewTextBoxColumn"
        '
        'HoraFinDataGridViewTextBoxColumn
        '
        Me.HoraFinDataGridViewTextBoxColumn.DataPropertyName = "Hora_Fin"
        Me.HoraFinDataGridViewTextBoxColumn.HeaderText = "Hora_Fin"
        Me.HoraFinDataGridViewTextBoxColumn.Name = "HoraFinDataGridViewTextBoxColumn"
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
        'AtencionBindingSource
        '
        Me.AtencionBindingSource.DataMember = "Atencion"
        Me.AtencionBindingSource.DataSource = Me.Hospital1DataSet
        '
        'Hospital1DataSet
        '
        Me.Hospital1DataSet.DataSetName = "Hospital1DataSet"
        Me.Hospital1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnEliminarA
        '
        Me.BtnEliminarA.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEliminarA.FlatAppearance.BorderSize = 0
        Me.BtnEliminarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarA.Location = New System.Drawing.Point(637, 327)
        Me.BtnEliminarA.Name = "BtnEliminarA"
        Me.BtnEliminarA.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarA.TabIndex = 6
        Me.BtnEliminarA.Text = "Eliminar"
        Me.BtnEliminarA.UseVisualStyleBackColor = False
        '
        'BtnAgregarA
        '
        Me.BtnAgregarA.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAgregarA.FlatAppearance.BorderSize = 0
        Me.BtnAgregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarA.Location = New System.Drawing.Point(437, 327)
        Me.BtnAgregarA.Name = "BtnAgregarA"
        Me.BtnAgregarA.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarA.TabIndex = 5
        Me.BtnAgregarA.Text = "Agregar"
        Me.BtnAgregarA.UseVisualStyleBackColor = False
        '
        'BtnActualizarA
        '
        Me.BtnActualizarA.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnActualizarA.FlatAppearance.BorderSize = 0
        Me.BtnActualizarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarA.Location = New System.Drawing.Point(537, 327)
        Me.BtnActualizarA.Name = "BtnActualizarA"
        Me.BtnActualizarA.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizarA.TabIndex = 4
        Me.BtnActualizarA.Text = "Actualizar"
        Me.BtnActualizarA.UseVisualStyleBackColor = False
        '
        'TxtFechaA
        '
        Me.TxtFechaA.Location = New System.Drawing.Point(92, 76)
        Me.TxtFechaA.Name = "TxtFechaA"
        Me.TxtFechaA.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaA.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha:"
        '
        'TxtHoraIA
        '
        Me.TxtHoraIA.Location = New System.Drawing.Point(92, 111)
        Me.TxtHoraIA.Name = "TxtHoraIA"
        Me.TxtHoraIA.Size = New System.Drawing.Size(100, 20)
        Me.TxtHoraIA.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hora Inicio:"
        '
        'TxtHoraFA
        '
        Me.TxtHoraFA.Location = New System.Drawing.Point(92, 148)
        Me.TxtHoraFA.Name = "TxtHoraFA"
        Me.TxtHoraFA.Size = New System.Drawing.Size(100, 20)
        Me.TxtHoraFA.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Hora Fin:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Medico:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Paciente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ATENCION"
        '
        'AtencionTableAdapter
        '
        Me.AtencionTableAdapter.ClearBeforeFill = True
        '
        'CBIdMedA
        '
        Me.CBIdMedA.DataSource = Me.MedicoBindingSource
        Me.CBIdMedA.DisplayMember = "Nombre"
        Me.CBIdMedA.FormattingEnabled = True
        Me.CBIdMedA.Location = New System.Drawing.Point(92, 187)
        Me.CBIdMedA.Name = "CBIdMedA"
        Me.CBIdMedA.Size = New System.Drawing.Size(100, 21)
        Me.CBIdMedA.TabIndex = 23
        Me.CBIdMedA.ValueMember = "ID_Medico"
        '
        'MedicoBindingSource
        '
        Me.MedicoBindingSource.DataMember = "Medico"
        Me.MedicoBindingSource.DataSource = Me.Hospital1DataSet
        '
        'CBIdPacienteA
        '
        Me.CBIdPacienteA.DataSource = Me.PacienteBindingSource
        Me.CBIdPacienteA.DisplayMember = "NombreP"
        Me.CBIdPacienteA.FormattingEnabled = True
        Me.CBIdPacienteA.Location = New System.Drawing.Point(92, 228)
        Me.CBIdPacienteA.Name = "CBIdPacienteA"
        Me.CBIdPacienteA.Size = New System.Drawing.Size(100, 21)
        Me.CBIdPacienteA.TabIndex = 24
        Me.CBIdPacienteA.ValueMember = "ID_Paciente"
        '
        'PacienteBindingSource
        '
        Me.PacienteBindingSource.DataMember = "Paciente"
        Me.PacienteBindingSource.DataSource = Me.Hospital1DataSet
        '
        'MedicoTableAdapter
        '
        Me.MedicoTableAdapter.ClearBeforeFill = True
        '
        'PacienteTableAdapter
        '
        Me.PacienteTableAdapter.ClearBeforeFill = True
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
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'FrmAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.CBIdPacienteA)
        Me.Controls.Add(Me.CBIdMedA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtHoraFA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtHoraIA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtFechaA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewAtencion)
        Me.Controls.Add(Me.BtnEliminarA)
        Me.Controls.Add(Me.BtnAgregarA)
        Me.Controls.Add(Me.BtnActualizarA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAtencion"
        Me.Text = "FrmAtencion"
        CType(Me.DataGridViewAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtencionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewAtencion As DataGridView
    Friend WithEvents BtnEliminarA As Button
    Friend WithEvents BtnAgregarA As Button
    Friend WithEvents BtnActualizarA As Button
    Friend WithEvents TxtFechaA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtHoraIA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtHoraFA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Hospital1DataSet As Hospital1DataSet
    Friend WithEvents AtencionBindingSource As BindingSource
    Friend WithEvents AtencionTableAdapter As Hospital1DataSetTableAdapters.AtencionTableAdapter
    Friend WithEvents IDAtencionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDMedicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CBIdMedA As ComboBox
    Friend WithEvents CBIdPacienteA As ComboBox
    Friend WithEvents MedicoBindingSource As BindingSource
    Friend WithEvents MedicoTableAdapter As Hospital1DataSetTableAdapters.MedicoTableAdapter
    Friend WithEvents PacienteBindingSource As BindingSource
    Friend WithEvents PacienteTableAdapter As Hospital1DataSetTableAdapters.PacienteTableAdapter
    Private WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
