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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAMP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAPP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombreP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewPacientes = New System.Windows.Forms.DataGridView()
        Me.IDPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApPaternoPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApMaternoPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MedicocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet = New Hospital.Hospital1DataSet()
        Me.BtnEliminarP = New System.Windows.Forms.Button()
        Me.BtnAgregarP = New System.Windows.Forms.Button()
        Me.BtnActualizarP = New System.Windows.Forms.Button()
        Me.PacienteTableAdapter = New Hospital.Hospital1DataSetTableAdapters.PacienteTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(85, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 25)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "PACIENTES"
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(90, 267)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(140, 20)
        Me.TxtPeso.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Peso:"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(90, 233)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(140, 20)
        Me.TxtEdad.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Edad:"
        '
        'TxtAMP
        '
        Me.TxtAMP.Location = New System.Drawing.Point(18, 197)
        Me.TxtAMP.Name = "TxtAMP"
        Me.TxtAMP.Size = New System.Drawing.Size(212, 20)
        Me.TxtAMP.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Apellido Materno:"
        '
        'TxtAPP
        '
        Me.TxtAPP.Location = New System.Drawing.Point(18, 141)
        Me.TxtAPP.Name = "TxtAPP"
        Me.TxtAPP.Size = New System.Drawing.Size(212, 20)
        Me.TxtAPP.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Apellido Paterno:"
        '
        'TxtNombreP
        '
        Me.TxtNombreP.Location = New System.Drawing.Point(18, 89)
        Me.TxtNombreP.Name = "TxtNombreP"
        Me.TxtNombreP.Size = New System.Drawing.Size(212, 20)
        Me.TxtNombreP.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nombre:"
        '
        'DataGridViewPacientes
        '
        Me.DataGridViewPacientes.AutoGenerateColumns = False
        Me.DataGridViewPacientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPacienteDataGridViewTextBoxColumn, Me.NombrePDataGridViewTextBoxColumn, Me.ApPaternoPDataGridViewTextBoxColumn, Me.ApMaternoPDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.PesoDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.MedicocreaDataGridViewTextBoxColumn, Me.MedicoactualizaDataGridViewTextBoxColumn})
        Me.DataGridViewPacientes.DataSource = Me.PacienteBindingSource
        Me.DataGridViewPacientes.Location = New System.Drawing.Point(236, 15)
        Me.DataGridViewPacientes.Name = "DataGridViewPacientes"
        Me.DataGridViewPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPacientes.Size = New System.Drawing.Size(576, 300)
        Me.DataGridViewPacientes.TabIndex = 28
        '
        'IDPacienteDataGridViewTextBoxColumn
        '
        Me.IDPacienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Paciente"
        Me.IDPacienteDataGridViewTextBoxColumn.HeaderText = "ID_Paciente"
        Me.IDPacienteDataGridViewTextBoxColumn.Name = "IDPacienteDataGridViewTextBoxColumn"
        Me.IDPacienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombrePDataGridViewTextBoxColumn
        '
        Me.NombrePDataGridViewTextBoxColumn.DataPropertyName = "NombreP"
        Me.NombrePDataGridViewTextBoxColumn.HeaderText = "NombreP"
        Me.NombrePDataGridViewTextBoxColumn.Name = "NombrePDataGridViewTextBoxColumn"
        '
        'ApPaternoPDataGridViewTextBoxColumn
        '
        Me.ApPaternoPDataGridViewTextBoxColumn.DataPropertyName = "Ap_PaternoP"
        Me.ApPaternoPDataGridViewTextBoxColumn.HeaderText = "Ap_PaternoP"
        Me.ApPaternoPDataGridViewTextBoxColumn.Name = "ApPaternoPDataGridViewTextBoxColumn"
        '
        'ApMaternoPDataGridViewTextBoxColumn
        '
        Me.ApMaternoPDataGridViewTextBoxColumn.DataPropertyName = "Ap_MaternoP"
        Me.ApMaternoPDataGridViewTextBoxColumn.HeaderText = "Ap_MaternoP"
        Me.ApMaternoPDataGridViewTextBoxColumn.Name = "ApMaternoPDataGridViewTextBoxColumn"
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        '
        'PesoDataGridViewTextBoxColumn
        '
        Me.PesoDataGridViewTextBoxColumn.DataPropertyName = "Peso"
        Me.PesoDataGridViewTextBoxColumn.HeaderText = "Peso"
        Me.PesoDataGridViewTextBoxColumn.Name = "PesoDataGridViewTextBoxColumn"
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
        'PacienteBindingSource
        '
        Me.PacienteBindingSource.DataMember = "Paciente"
        Me.PacienteBindingSource.DataSource = Me.Hospital1DataSet
        '
        'Hospital1DataSet
        '
        Me.Hospital1DataSet.DataSetName = "Hospital1DataSet"
        Me.Hospital1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnEliminarP
        '
        Me.BtnEliminarP.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEliminarP.FlatAppearance.BorderSize = 0
        Me.BtnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarP.Location = New System.Drawing.Point(637, 327)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarP.TabIndex = 27
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.UseVisualStyleBackColor = False
        '
        'BtnAgregarP
        '
        Me.BtnAgregarP.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAgregarP.FlatAppearance.BorderSize = 0
        Me.BtnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarP.Location = New System.Drawing.Point(437, 327)
        Me.BtnAgregarP.Name = "BtnAgregarP"
        Me.BtnAgregarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarP.TabIndex = 26
        Me.BtnAgregarP.Text = "Agregar"
        Me.BtnAgregarP.UseVisualStyleBackColor = False
        '
        'BtnActualizarP
        '
        Me.BtnActualizarP.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnActualizarP.FlatAppearance.BorderSize = 0
        Me.BtnActualizarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarP.Location = New System.Drawing.Point(537, 327)
        Me.BtnActualizarP.Name = "BtnActualizarP"
        Me.BtnActualizarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizarP.TabIndex = 25
        Me.BtnActualizarP.Text = "Actualizar"
        Me.BtnActualizarP.UseVisualStyleBackColor = False
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
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPeso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtAMP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtAPP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNombreP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewPacientes)
        Me.Controls.Add(Me.BtnEliminarP)
        Me.Controls.Add(Me.BtnAgregarP)
        Me.Controls.Add(Me.BtnActualizarP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FrmPaciente"
        CType(Me.DataGridViewPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAMP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAPP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombreP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewPacientes As DataGridView
    Friend WithEvents BtnEliminarP As Button
    Friend WithEvents BtnAgregarP As Button
    Friend WithEvents BtnActualizarP As Button
    Friend WithEvents Hospital1DataSet As Hospital1DataSet
    Friend WithEvents PacienteBindingSource As BindingSource
    Friend WithEvents PacienteTableAdapter As Hospital1DataSetTableAdapters.PacienteTableAdapter
    Friend WithEvents IDPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrePDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApPaternoPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApMaternoPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MedicocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
