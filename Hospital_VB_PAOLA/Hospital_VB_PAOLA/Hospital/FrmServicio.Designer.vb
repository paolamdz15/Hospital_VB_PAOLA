<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServicio))
        Me.DataGridViewS = New System.Windows.Forms.DataGridView()
        Me.IDServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDAtencionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet = New Hospital.Hospital1DataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDuracionS = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionS = New System.Windows.Forms.TextBox()
        Me.TxtNombreS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBIdAtencionS = New System.Windows.Forms.ComboBox()
        Me.AtencionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicioBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicioTableAdapter = New Hospital.Hospital1DataSetTableAdapters.ServicioTableAdapter()
        Me.ServicioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtencionTableAdapter = New Hospital.Hospital1DataSetTableAdapters.AtencionTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtencionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewS
        '
        Me.DataGridViewS.AutoGenerateColumns = False
        Me.DataGridViewS.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDServicioDataGridViewTextBoxColumn, Me.NombreSDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DuracionDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IDAtencionDataGridViewTextBoxColumn, Me.MedicocreaDataGridViewTextBoxColumn, Me.MedicoactualizaDataGridViewTextBoxColumn})
        Me.DataGridViewS.DataSource = Me.ServicioBindingSource
        Me.DataGridViewS.Location = New System.Drawing.Point(238, 15)
        Me.DataGridViewS.Name = "DataGridViewS"
        Me.DataGridViewS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewS.Size = New System.Drawing.Size(574, 300)
        Me.DataGridViewS.TabIndex = 35
        '
        'IDServicioDataGridViewTextBoxColumn
        '
        Me.IDServicioDataGridViewTextBoxColumn.DataPropertyName = "ID_Servicio"
        Me.IDServicioDataGridViewTextBoxColumn.HeaderText = "ID_Servicio"
        Me.IDServicioDataGridViewTextBoxColumn.Name = "IDServicioDataGridViewTextBoxColumn"
        Me.IDServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreSDataGridViewTextBoxColumn
        '
        Me.NombreSDataGridViewTextBoxColumn.DataPropertyName = "NombreS"
        Me.NombreSDataGridViewTextBoxColumn.HeaderText = "NombreS"
        Me.NombreSDataGridViewTextBoxColumn.Name = "NombreSDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'DuracionDataGridViewTextBoxColumn
        '
        Me.DuracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion"
        Me.DuracionDataGridViewTextBoxColumn.HeaderText = "Duracion"
        Me.DuracionDataGridViewTextBoxColumn.Name = "DuracionDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        '
        'IDAtencionDataGridViewTextBoxColumn
        '
        Me.IDAtencionDataGridViewTextBoxColumn.DataPropertyName = "ID_Atencion"
        Me.IDAtencionDataGridViewTextBoxColumn.HeaderText = "ID_Atencion"
        Me.IDAtencionDataGridViewTextBoxColumn.Name = "IDAtencionDataGridViewTextBoxColumn"
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
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "Servicio"
        Me.ServicioBindingSource.DataSource = Me.Hospital1DataSet
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
        Me.BtnEliminar.TabIndex = 34
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
        Me.BtnActualizar.TabIndex = 33
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
        Me.BtnAgregar.TabIndex = 32
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(85, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 25)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "SERVICIO"
        '
        'TxtDuracionS
        '
        Me.TxtDuracionS.Location = New System.Drawing.Point(120, 182)
        Me.TxtDuracionS.Name = "TxtDuracionS"
        Me.TxtDuracionS.Size = New System.Drawing.Size(112, 20)
        Me.TxtDuracionS.TabIndex = 56
        '
        'TxtDescripcionS
        '
        Me.TxtDescripcionS.Location = New System.Drawing.Point(12, 142)
        Me.TxtDescripcionS.Name = "TxtDescripcionS"
        Me.TxtDescripcionS.Size = New System.Drawing.Size(220, 20)
        Me.TxtDescripcionS.TabIndex = 55
        '
        'TxtNombreS
        '
        Me.TxtNombreS.Location = New System.Drawing.Point(12, 91)
        Me.TxtNombreS.Name = "TxtNombreS"
        Me.TxtNombreS.Size = New System.Drawing.Size(220, 20)
        Me.TxtNombreS.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Fecha Atencion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Duracion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nombre:"
        '
        'CBIdAtencionS
        '
        Me.CBIdAtencionS.DataSource = Me.AtencionBindingSource
        Me.CBIdAtencionS.DisplayMember = "FechaA"
        Me.CBIdAtencionS.FormattingEnabled = True
        Me.CBIdAtencionS.Location = New System.Drawing.Point(120, 220)
        Me.CBIdAtencionS.Name = "CBIdAtencionS"
        Me.CBIdAtencionS.Size = New System.Drawing.Size(112, 21)
        Me.CBIdAtencionS.TabIndex = 60
        Me.CBIdAtencionS.ValueMember = "ID_Atencion"
        '
        'AtencionBindingSource
        '
        Me.AtencionBindingSource.DataMember = "Atencion"
        Me.AtencionBindingSource.DataSource = Me.Hospital1DataSet
        '
        'ServicioBindingSource2
        '
        Me.ServicioBindingSource2.DataMember = "Servicio"
        Me.ServicioBindingSource2.DataSource = Me.Hospital1DataSet
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'ServicioBindingSource1
        '
        Me.ServicioBindingSource1.DataMember = "Servicio"
        Me.ServicioBindingSource1.DataSource = Me.Hospital1DataSet
        '
        'AtencionTableAdapter
        '
        Me.AtencionTableAdapter.ClearBeforeFill = True
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
        Me.btnVolver.TabIndex = 61
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'FrmServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.CBIdAtencionS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtDuracionS)
        Me.Controls.Add(Me.TxtDescripcionS)
        Me.Controls.Add(Me.TxtNombreS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewS)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmServicio"
        Me.Text = "FrmServicio"
        CType(Me.DataGridViewS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtencionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewS As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDuracionS As TextBox
    Friend WithEvents TxtDescripcionS As TextBox
    Friend WithEvents TxtNombreS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBIdAtencionS As ComboBox
    Friend WithEvents Hospital1DataSet As Hospital1DataSet
    Friend WithEvents ServicioBindingSource As BindingSource
    Friend WithEvents ServicioTableAdapter As Hospital1DataSetTableAdapters.ServicioTableAdapter
    Friend WithEvents IDServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DuracionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDAtencionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServicioBindingSource1 As BindingSource
    Friend WithEvents ServicioBindingSource2 As BindingSource
    Friend WithEvents AtencionBindingSource As BindingSource
    Friend WithEvents AtencionTableAdapter As Hospital1DataSetTableAdapters.AtencionTableAdapter
    Private WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
