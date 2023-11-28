<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFactura))
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet = New Hospital.Hospital1DataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTotalF = New System.Windows.Forms.TextBox()
        Me.TxtFechaEmision = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBIdDFF = New System.Windows.Forms.ComboBox()
        Me.DetalleFacturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet2 = New Hospital.Hospital1DataSet2()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New Hospital.Hospital1DataSetTableAdapters.FacturaTableAdapter()
        Me.ClienteTableAdapter = New Hospital.Hospital1DataSetTableAdapters.ClienteTableAdapter()
        Me.Detalle_FacturaTableAdapter = New Hospital.Hospital1DataSetTableAdapters.Detalle_FacturaTableAdapter()
        Me.FKClienteIDFact619B8048BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKClienteIDFact619B8048BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGVFactura = New System.Windows.Forms.DataGridView()
        Me.IDFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEmisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDDFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet1 = New Hospital.Hospital1DataSet1()
        Me.FacturaBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotaTableAdapter = New Hospital.Hospital1DataSet2TableAdapters.NotaTableAdapter()
        Me.Detalle_FacturaTableAdapter1 = New Hospital.Hospital1DataSet2TableAdapters.Detalle_FacturaTableAdapter()
        Me.NotaTableAdapter1 = New Hospital.Hospital1DataSet1TableAdapters.NotaTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKClienteIDFact619B8048BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKClienteIDFact619B8048BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.Hospital1DataSet
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
        Me.BtnEliminar.TabIndex = 22
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
        Me.BtnActualizar.TabIndex = 21
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
        Me.BtnAgregar.TabIndex = 20
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 25)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "FACTURAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Fecha Emision:"
        '
        'TxtTotalF
        '
        Me.TxtTotalF.Location = New System.Drawing.Point(121, 107)
        Me.TxtTotalF.Name = "TxtTotalF"
        Me.TxtTotalF.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalF.TabIndex = 46
        '
        'TxtFechaEmision
        '
        Me.TxtFechaEmision.Location = New System.Drawing.Point(121, 73)
        Me.TxtFechaEmision.Name = "TxtFechaEmision"
        Me.TxtFechaEmision.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaEmision.TabIndex = 44
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Hospital1DataSet
        '
        'CBIdDFF
        '
        Me.CBIdDFF.DataSource = Me.DetalleFacturaBindingSource1
        Me.CBIdDFF.DisplayMember = "Cantidad"
        Me.CBIdDFF.FormattingEnabled = True
        Me.CBIdDFF.Location = New System.Drawing.Point(121, 143)
        Me.CBIdDFF.Name = "CBIdDFF"
        Me.CBIdDFF.Size = New System.Drawing.Size(100, 21)
        Me.CBIdDFF.TabIndex = 56
        Me.CBIdDFF.ValueMember = "ID_DFactura"
        '
        'DetalleFacturaBindingSource1
        '
        Me.DetalleFacturaBindingSource1.DataMember = "Detalle_Factura"
        Me.DetalleFacturaBindingSource1.DataSource = Me.Hospital1DataSet2
        '
        'Hospital1DataSet2
        '
        Me.Hospital1DataSet2.DataSetName = "Hospital1DataSet2"
        Me.Hospital1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataMember = "Detalle_Factura"
        Me.DetalleFacturaBindingSource.DataSource = Me.Hospital1DataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Detalle_FacturaTableAdapter
        '
        Me.Detalle_FacturaTableAdapter.ClearBeforeFill = True
        '
        'FKClienteIDFact619B8048BindingSource
        '
        Me.FKClienteIDFact619B8048BindingSource.DataMember = "FK__Cliente__ID_Fact__619B8048"
        Me.FKClienteIDFact619B8048BindingSource.DataSource = Me.FacturaBindingSource
        '
        'FacturaBindingSource1
        '
        Me.FacturaBindingSource1.DataMember = "Factura"
        Me.FacturaBindingSource1.DataSource = Me.Hospital1DataSet
        '
        'FKClienteIDFact619B8048BindingSource1
        '
        Me.FKClienteIDFact619B8048BindingSource1.DataMember = "FK__Cliente__ID_Fact__619B8048"
        Me.FKClienteIDFact619B8048BindingSource1.DataSource = Me.FacturaBindingSource
        '
        'DGVFactura
        '
        Me.DGVFactura.AutoGenerateColumns = False
        Me.DGVFactura.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDFacturaDataGridViewTextBoxColumn, Me.FechaEmisionDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IDDFacturaDataGridViewTextBoxColumn, Me.MedicocreaDataGridViewTextBoxColumn, Me.MedicoactualizaDataGridViewTextBoxColumn})
        Me.DGVFactura.DataSource = Me.NotaBindingSource1
        Me.DGVFactura.Location = New System.Drawing.Point(227, 15)
        Me.DGVFactura.Name = "DGVFactura"
        Me.DGVFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFactura.Size = New System.Drawing.Size(585, 300)
        Me.DGVFactura.TabIndex = 57
        '
        'IDFacturaDataGridViewTextBoxColumn
        '
        Me.IDFacturaDataGridViewTextBoxColumn.DataPropertyName = "ID_Factura"
        Me.IDFacturaDataGridViewTextBoxColumn.HeaderText = "ID_Factura"
        Me.IDFacturaDataGridViewTextBoxColumn.Name = "IDFacturaDataGridViewTextBoxColumn"
        Me.IDFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaEmisionDataGridViewTextBoxColumn
        '
        Me.FechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Emision"
        Me.FechaEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha_Emision"
        Me.FechaEmisionDataGridViewTextBoxColumn.Name = "FechaEmisionDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        '
        'IDDFacturaDataGridViewTextBoxColumn
        '
        Me.IDDFacturaDataGridViewTextBoxColumn.DataPropertyName = "ID_DFactura"
        Me.IDDFacturaDataGridViewTextBoxColumn.HeaderText = "ID_DFactura"
        Me.IDDFacturaDataGridViewTextBoxColumn.Name = "IDDFacturaDataGridViewTextBoxColumn"
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
        'NotaBindingSource1
        '
        Me.NotaBindingSource1.DataMember = "Nota"
        Me.NotaBindingSource1.DataSource = Me.Hospital1DataSet1BindingSource
        '
        'Hospital1DataSet1BindingSource
        '
        Me.Hospital1DataSet1BindingSource.DataSource = Me.Hospital1DataSet1
        Me.Hospital1DataSet1BindingSource.Position = 0
        '
        'Hospital1DataSet1
        '
        Me.Hospital1DataSet1.DataSetName = "Hospital1DataSet1"
        Me.Hospital1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource3
        '
        Me.FacturaBindingSource3.DataMember = "Factura"
        Me.FacturaBindingSource3.DataSource = Me.Hospital1DataSet
        '
        'FacturaBindingSource2
        '
        Me.FacturaBindingSource2.DataMember = "Factura"
        Me.FacturaBindingSource2.DataSource = Me.Hospital1DataSet
        '
        'NotaBindingSource
        '
        Me.NotaBindingSource.DataMember = "Nota"
        Me.NotaBindingSource.DataSource = Me.Hospital1DataSet2
        '
        'NotaTableAdapter
        '
        Me.NotaTableAdapter.ClearBeforeFill = True
        '
        'Detalle_FacturaTableAdapter1
        '
        Me.Detalle_FacturaTableAdapter1.ClearBeforeFill = True
        '
        'NotaTableAdapter1
        '
        Me.NotaTableAdapter1.ClearBeforeFill = True
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
        Me.btnVolver.TabIndex = 58
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'FrmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.DGVFactura)
        Me.Controls.Add(Me.CBIdDFF)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTotalF)
        Me.Controls.Add(Me.TxtFechaEmision)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFactura"
        Me.Text = "FrmFactura"
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKClienteIDFact619B8048BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKClienteIDFact619B8048BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTotalF As TextBox
    Friend WithEvents TxtFechaEmision As TextBox
    Friend WithEvents CBIdDFF As ComboBox
    Friend WithEvents Hospital1DataSet As Hospital1DataSet
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As Hospital1DataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As Hospital1DataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents DetalleFacturaBindingSource As BindingSource
    Friend WithEvents Detalle_FacturaTableAdapter As Hospital1DataSetTableAdapters.Detalle_FacturaTableAdapter
    Friend WithEvents FKClienteIDFact619B8048BindingSource1 As BindingSource
    Friend WithEvents FKClienteIDFact619B8048BindingSource As BindingSource
    Friend WithEvents FacturaBindingSource1 As BindingSource
    Friend WithEvents DGVFactura As DataGridView
    Friend WithEvents FacturaBindingSource2 As BindingSource
    Friend WithEvents FacturaBindingSource3 As BindingSource
    Friend WithEvents Hospital1DataSet2 As Hospital1DataSet2
    Friend WithEvents NotaBindingSource As BindingSource
    Friend WithEvents NotaTableAdapter As Hospital1DataSet2TableAdapters.NotaTableAdapter
    Friend WithEvents DetalleFacturaBindingSource1 As BindingSource
    Friend WithEvents Detalle_FacturaTableAdapter1 As Hospital1DataSet2TableAdapters.Detalle_FacturaTableAdapter
    Friend WithEvents Hospital1DataSet1BindingSource As BindingSource
    Friend WithEvents Hospital1DataSet1 As Hospital1DataSet1
    Friend WithEvents NotaBindingSource1 As BindingSource
    Friend WithEvents NotaTableAdapter1 As Hospital1DataSet1TableAdapters.NotaTableAdapter
    Friend WithEvents IDFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEmisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDDFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
