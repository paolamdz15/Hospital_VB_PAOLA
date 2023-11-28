<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceta))
        Me.DataGridViewR = New System.Windows.Forms.DataGridView()
        Me.IDRecetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndicacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDMedicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet = New Hospital.Hospital1DataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtIndicacionesR = New System.Windows.Forms.TextBox()
        Me.TxtFechaR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RecetaTableAdapter = New Hospital.Hospital1DataSetTableAdapters.RecetaTableAdapter()
        Me.CBIdMedicoR = New System.Windows.Forms.ComboBox()
        Me.MedicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBIdPacienteR = New System.Windows.Forms.ComboBox()
        Me.PacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBIdMedicamentoR = New System.Windows.Forms.ComboBox()
        Me.MedicamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicoTableAdapter = New Hospital.Hospital1DataSetTableAdapters.MedicoTableAdapter()
        Me.PacienteTableAdapter = New Hospital.Hospital1DataSetTableAdapters.PacienteTableAdapter()
        Me.MedicamentoTableAdapter = New Hospital.Hospital1DataSetTableAdapters.MedicamentoTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewR
        '
        Me.DataGridViewR.AutoGenerateColumns = False
        Me.DataGridViewR.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridViewR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRecetaDataGridViewTextBoxColumn, Me.FechaRDataGridViewTextBoxColumn, Me.IndicacionesDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IDMedicoDataGridViewTextBoxColumn, Me.IDPacienteDataGridViewTextBoxColumn, Me.IDMedicamentoDataGridViewTextBoxColumn, Me.MedicocreaDataGridViewTextBoxColumn, Me.MedicoactualizaDataGridViewTextBoxColumn})
        Me.DataGridViewR.DataSource = Me.RecetaBindingSource
        Me.DataGridViewR.Location = New System.Drawing.Point(241, 15)
        Me.DataGridViewR.Name = "DataGridViewR"
        Me.DataGridViewR.Size = New System.Drawing.Size(571, 300)
        Me.DataGridViewR.TabIndex = 31
        '
        'IDRecetaDataGridViewTextBoxColumn
        '
        Me.IDRecetaDataGridViewTextBoxColumn.DataPropertyName = "ID_Receta"
        Me.IDRecetaDataGridViewTextBoxColumn.HeaderText = "ID_Receta"
        Me.IDRecetaDataGridViewTextBoxColumn.Name = "IDRecetaDataGridViewTextBoxColumn"
        Me.IDRecetaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaRDataGridViewTextBoxColumn
        '
        Me.FechaRDataGridViewTextBoxColumn.DataPropertyName = "FechaR"
        Me.FechaRDataGridViewTextBoxColumn.HeaderText = "FechaR"
        Me.FechaRDataGridViewTextBoxColumn.Name = "FechaRDataGridViewTextBoxColumn"
        '
        'IndicacionesDataGridViewTextBoxColumn
        '
        Me.IndicacionesDataGridViewTextBoxColumn.DataPropertyName = "Indicaciones"
        Me.IndicacionesDataGridViewTextBoxColumn.HeaderText = "Indicaciones"
        Me.IndicacionesDataGridViewTextBoxColumn.Name = "IndicacionesDataGridViewTextBoxColumn"
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
        'IDMedicamentoDataGridViewTextBoxColumn
        '
        Me.IDMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Medicamento"
        Me.IDMedicamentoDataGridViewTextBoxColumn.HeaderText = "ID_Medicamento"
        Me.IDMedicamentoDataGridViewTextBoxColumn.Name = "IDMedicamentoDataGridViewTextBoxColumn"
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
        'RecetaBindingSource
        '
        Me.RecetaBindingSource.DataMember = "Receta"
        Me.RecetaBindingSource.DataSource = Me.Hospital1DataSet
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
        Me.BtnEliminar.Location = New System.Drawing.Point(637, 327)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 30
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(537, 327)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 29
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(437, 327)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 28
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(101, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 25)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "RECETA"
        '
        'TxtIndicacionesR
        '
        Me.TxtIndicacionesR.Location = New System.Drawing.Point(15, 125)
        Me.TxtIndicacionesR.Name = "TxtIndicacionesR"
        Me.TxtIndicacionesR.Size = New System.Drawing.Size(220, 20)
        Me.TxtIndicacionesR.TabIndex = 41
        '
        'TxtFechaR
        '
        Me.TxtFechaR.Location = New System.Drawing.Point(135, 74)
        Me.TxtFechaR.Name = "TxtFechaR"
        Me.TxtFechaR.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaR.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Medicamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = " Paciente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Medico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Indicaciones:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Fecha:"
        '
        'RecetaTableAdapter
        '
        Me.RecetaTableAdapter.ClearBeforeFill = True
        '
        'CBIdMedicoR
        '
        Me.CBIdMedicoR.DataSource = Me.MedicoBindingSource
        Me.CBIdMedicoR.DisplayMember = "Nombre"
        Me.CBIdMedicoR.FormattingEnabled = True
        Me.CBIdMedicoR.Location = New System.Drawing.Point(135, 164)
        Me.CBIdMedicoR.Name = "CBIdMedicoR"
        Me.CBIdMedicoR.Size = New System.Drawing.Size(100, 21)
        Me.CBIdMedicoR.TabIndex = 47
        Me.CBIdMedicoR.ValueMember = "ID_Medico"
        '
        'MedicoBindingSource
        '
        Me.MedicoBindingSource.DataMember = "Medico"
        Me.MedicoBindingSource.DataSource = Me.Hospital1DataSet
        '
        'CBIdPacienteR
        '
        Me.CBIdPacienteR.DataSource = Me.PacienteBindingSource
        Me.CBIdPacienteR.DisplayMember = "NombreP"
        Me.CBIdPacienteR.FormattingEnabled = True
        Me.CBIdPacienteR.Location = New System.Drawing.Point(135, 202)
        Me.CBIdPacienteR.Name = "CBIdPacienteR"
        Me.CBIdPacienteR.Size = New System.Drawing.Size(100, 21)
        Me.CBIdPacienteR.TabIndex = 48
        Me.CBIdPacienteR.ValueMember = "ID_Paciente"
        '
        'PacienteBindingSource
        '
        Me.PacienteBindingSource.DataMember = "Paciente"
        Me.PacienteBindingSource.DataSource = Me.Hospital1DataSet
        '
        'CBIdMedicamentoR
        '
        Me.CBIdMedicamentoR.DataSource = Me.MedicamentoBindingSource
        Me.CBIdMedicamentoR.DisplayMember = "NombreM"
        Me.CBIdMedicamentoR.FormattingEnabled = True
        Me.CBIdMedicamentoR.Location = New System.Drawing.Point(135, 239)
        Me.CBIdMedicamentoR.Name = "CBIdMedicamentoR"
        Me.CBIdMedicamentoR.Size = New System.Drawing.Size(100, 21)
        Me.CBIdMedicamentoR.TabIndex = 49
        Me.CBIdMedicamentoR.ValueMember = "ID_Medicamento"
        '
        'MedicamentoBindingSource
        '
        Me.MedicamentoBindingSource.DataMember = "Medicamento"
        Me.MedicamentoBindingSource.DataSource = Me.Hospital1DataSet
        '
        'MedicoTableAdapter
        '
        Me.MedicoTableAdapter.ClearBeforeFill = True
        '
        'PacienteTableAdapter
        '
        Me.PacienteTableAdapter.ClearBeforeFill = True
        '
        'MedicamentoTableAdapter
        '
        Me.MedicamentoTableAdapter.ClearBeforeFill = True
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
        Me.btnVolver.TabIndex = 50
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'FrmReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.CBIdMedicamentoR)
        Me.Controls.Add(Me.CBIdPacienteR)
        Me.Controls.Add(Me.CBIdMedicoR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtIndicacionesR)
        Me.Controls.Add(Me.TxtFechaR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewR)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReceta"
        Me.Text = "FrmReceta"
        CType(Me.DataGridViewR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewR As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtIndicacionesR As TextBox
    Friend WithEvents TxtFechaR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Hospital1DataSet As Hospital1DataSet
    Friend WithEvents RecetaBindingSource As BindingSource
    Friend WithEvents RecetaTableAdapter As Hospital1DataSetTableAdapters.RecetaTableAdapter
    Friend WithEvents IDRecetaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndicacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDMedicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDMedicamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CBIdMedicoR As ComboBox
    Friend WithEvents CBIdPacienteR As ComboBox
    Friend WithEvents CBIdMedicamentoR As ComboBox
    Friend WithEvents MedicoBindingSource As BindingSource
    Friend WithEvents MedicoTableAdapter As Hospital1DataSetTableAdapters.MedicoTableAdapter
    Friend WithEvents PacienteBindingSource As BindingSource
    Friend WithEvents PacienteTableAdapter As Hospital1DataSetTableAdapters.PacienteTableAdapter
    Friend WithEvents MedicamentoBindingSource As BindingSource
    Friend WithEvents MedicamentoTableAdapter As Hospital1DataSetTableAdapters.MedicamentoTableAdapter
    Private WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
