<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedicamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMedicamentos))
        Me.DataGridViewM = New System.Windows.Forms.DataGridView()
        Me.IDMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCaducidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MedicocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet = New Hospital.Hospital1DataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFCADM = New System.Windows.Forms.TextBox()
        Me.TxtNombreM = New System.Windows.Forms.TextBox()
        Me.MedicamentoTableAdapter = New Hospital.Hospital1DataSetTableAdapters.MedicamentoTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewM
        '
        Me.DataGridViewM.AutoGenerateColumns = False
        Me.DataGridViewM.BackgroundColor = System.Drawing.Color.MintCream
        Me.DataGridViewM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMedicamentoDataGridViewTextBoxColumn, Me.NombreMDataGridViewTextBoxColumn, Me.FechaCaducidadDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.MedicocreaDataGridViewTextBoxColumn, Me.MedicoactualizaDataGridViewTextBoxColumn})
        Me.DataGridViewM.DataSource = Me.MedicamentoBindingSource
        Me.DataGridViewM.Location = New System.Drawing.Point(262, 15)
        Me.DataGridViewM.Name = "DataGridViewM"
        Me.DataGridViewM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewM.Size = New System.Drawing.Size(550, 300)
        Me.DataGridViewM.TabIndex = 27
        '
        'IDMedicamentoDataGridViewTextBoxColumn
        '
        Me.IDMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Medicamento"
        Me.IDMedicamentoDataGridViewTextBoxColumn.HeaderText = "ID_Medicamento"
        Me.IDMedicamentoDataGridViewTextBoxColumn.Name = "IDMedicamentoDataGridViewTextBoxColumn"
        Me.IDMedicamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreMDataGridViewTextBoxColumn
        '
        Me.NombreMDataGridViewTextBoxColumn.DataPropertyName = "NombreM"
        Me.NombreMDataGridViewTextBoxColumn.HeaderText = "NombreM"
        Me.NombreMDataGridViewTextBoxColumn.Name = "NombreMDataGridViewTextBoxColumn"
        '
        'FechaCaducidadDataGridViewTextBoxColumn
        '
        Me.FechaCaducidadDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Caducidad"
        Me.FechaCaducidadDataGridViewTextBoxColumn.HeaderText = "Fecha_Caducidad"
        Me.FechaCaducidadDataGridViewTextBoxColumn.Name = "FechaCaducidadDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
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
        'MedicamentoBindingSource
        '
        Me.MedicamentoBindingSource.DataMember = "Medicamento"
        Me.MedicamentoBindingSource.DataSource = Me.Hospital1DataSet
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
        Me.BtnEliminar.TabIndex = 26
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
        Me.BtnActualizar.TabIndex = 25
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
        Me.BtnAgregar.TabIndex = 24
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 25)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "MEDICAMENTOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Fecha Caducidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nombre:"
        '
        'TxtFCADM
        '
        Me.TxtFCADM.Location = New System.Drawing.Point(135, 134)
        Me.TxtFCADM.Name = "TxtFCADM"
        Me.TxtFCADM.Size = New System.Drawing.Size(100, 20)
        Me.TxtFCADM.TabIndex = 54
        '
        'TxtNombreM
        '
        Me.TxtNombreM.Location = New System.Drawing.Point(15, 92)
        Me.TxtNombreM.Name = "TxtNombreM"
        Me.TxtNombreM.Size = New System.Drawing.Size(220, 20)
        Me.TxtNombreM.TabIndex = 53
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
        Me.btnVolver.TabIndex = 60
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'FrmMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtFCADM)
        Me.Controls.Add(Me.TxtNombreM)
        Me.Controls.Add(Me.DataGridViewM)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMedicamentos"
        Me.Text = "FrmMedicamentos"
        CType(Me.DataGridViewM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewM As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFCADM As TextBox
    Friend WithEvents TxtNombreM As TextBox
    Friend WithEvents Hospital1DataSet As Hospital1DataSet
    Friend WithEvents MedicamentoBindingSource As BindingSource
    Friend WithEvents MedicamentoTableAdapter As Hospital1DataSetTableAdapters.MedicamentoTableAdapter
    Friend WithEvents IDMedicamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCaducidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MedicocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
