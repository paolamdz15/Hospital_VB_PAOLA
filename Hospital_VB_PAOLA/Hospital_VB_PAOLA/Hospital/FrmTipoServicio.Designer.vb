<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoServicio))
        Me.DataGridViewTS = New System.Windows.Forms.DataGridView()
        Me.IDTServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaRelacionadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDAtencionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicocreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoactualizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital1DataSet = New Hospital.Hospital1DataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtAreaRTS = New System.Windows.Forms.TextBox()
        Me.TxtCostoS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AtencionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_ServicioTableAdapter = New Hospital.Hospital1DataSetTableAdapters.Tipo_ServicioTableAdapter()
        Me.AtencionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtencionTableAdapter = New Hospital.Hospital1DataSetTableAdapters.AtencionTableAdapter()
        Me.ServicioTableAdapter = New Hospital.Hospital1DataSetTableAdapters.ServicioTableAdapter()
        Me.Detalle_FacturaTableAdapter = New Hospital.Hospital1DataSetTableAdapters.Detalle_FacturaTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtencionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtencionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTS
        '
        Me.DataGridViewTS.AutoGenerateColumns = False
        Me.DataGridViewTS.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridViewTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTServicioDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.AreaRelacionadaDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.IDAtencionDataGridViewTextBoxColumn, Me.IDServicioDataGridViewTextBoxColumn, Me.IDDFacturaDataGridViewTextBoxColumn, Me.MedicocreaDataGridViewTextBoxColumn, Me.MedicoactualizaDataGridViewTextBoxColumn})
        Me.DataGridViewTS.DataSource = Me.TipoServicioBindingSource
        Me.DataGridViewTS.Location = New System.Drawing.Point(256, 15)
        Me.DataGridViewTS.Name = "DataGridViewTS"
        Me.DataGridViewTS.Size = New System.Drawing.Size(556, 300)
        Me.DataGridViewTS.TabIndex = 39
        '
        'IDTServicioDataGridViewTextBoxColumn
        '
        Me.IDTServicioDataGridViewTextBoxColumn.DataPropertyName = "ID_TServicio"
        Me.IDTServicioDataGridViewTextBoxColumn.HeaderText = "ID_TServicio"
        Me.IDTServicioDataGridViewTextBoxColumn.Name = "IDTServicioDataGridViewTextBoxColumn"
        Me.IDTServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        '
        'AreaRelacionadaDataGridViewTextBoxColumn
        '
        Me.AreaRelacionadaDataGridViewTextBoxColumn.DataPropertyName = "AreaRelacionada"
        Me.AreaRelacionadaDataGridViewTextBoxColumn.HeaderText = "AreaRelacionada"
        Me.AreaRelacionadaDataGridViewTextBoxColumn.Name = "AreaRelacionadaDataGridViewTextBoxColumn"
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
        'IDServicioDataGridViewTextBoxColumn
        '
        Me.IDServicioDataGridViewTextBoxColumn.DataPropertyName = "ID_Servicio"
        Me.IDServicioDataGridViewTextBoxColumn.HeaderText = "ID_Servicio"
        Me.IDServicioDataGridViewTextBoxColumn.Name = "IDServicioDataGridViewTextBoxColumn"
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
        'TipoServicioBindingSource
        '
        Me.TipoServicioBindingSource.DataMember = "Tipo_Servicio"
        Me.TipoServicioBindingSource.DataSource = Me.Hospital1DataSet
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
        Me.BtnEliminar.TabIndex = 38
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
        Me.BtnActualizar.TabIndex = 37
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
        Me.BtnAgregar.TabIndex = 36
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(78, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 25)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "TIPO SERVICIO"
        '
        'TxtAreaRTS
        '
        Me.TxtAreaRTS.Location = New System.Drawing.Point(12, 129)
        Me.TxtAreaRTS.Name = "TxtAreaRTS"
        Me.TxtAreaRTS.Size = New System.Drawing.Size(238, 20)
        Me.TxtAreaRTS.TabIndex = 56
        '
        'TxtCostoS
        '
        Me.TxtCostoS.Location = New System.Drawing.Point(150, 76)
        Me.TxtCostoS.Name = "TxtCostoS"
        Me.TxtCostoS.Size = New System.Drawing.Size(100, 20)
        Me.TxtCostoS.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 17)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Cantidad de Servicios:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 17)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Nombre Servicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Fecha Atencion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Area Relacionada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Costo:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.AtencionBindingSource1
        Me.ComboBox1.DisplayMember = "FechaA"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(150, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 62
        Me.ComboBox1.ValueMember = "ID_Atencion"
        '
        'AtencionBindingSource1
        '
        Me.AtencionBindingSource1.DataMember = "Atencion"
        Me.AtencionBindingSource1.DataSource = Me.Hospital1DataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ServicioBindingSource
        Me.ComboBox2.DisplayMember = "NombreS"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(150, 206)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 63
        Me.ComboBox2.ValueMember = "ID_Servicio"
        '
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "Servicio"
        Me.ServicioBindingSource.DataSource = Me.Hospital1DataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.DetalleFacturaBindingSource
        Me.ComboBox3.DisplayMember = "Cantidad"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(12, 265)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(238, 21)
        Me.ComboBox3.TabIndex = 64
        Me.ComboBox3.ValueMember = "ID_DFactura"
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataMember = "Detalle_Factura"
        Me.DetalleFacturaBindingSource.DataSource = Me.Hospital1DataSet
        '
        'Tipo_ServicioTableAdapter
        '
        Me.Tipo_ServicioTableAdapter.ClearBeforeFill = True
        '
        'AtencionBindingSource
        '
        Me.AtencionBindingSource.DataMember = "Atencion"
        Me.AtencionBindingSource.DataSource = Me.Hospital1DataSet
        '
        'AtencionTableAdapter
        '
        Me.AtencionTableAdapter.ClearBeforeFill = True
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'Detalle_FacturaTableAdapter
        '
        Me.Detalle_FacturaTableAdapter.ClearBeforeFill = True
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
        Me.btnVolver.TabIndex = 65
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'FrmTipoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(824, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtAreaRTS)
        Me.Controls.Add(Me.TxtCostoS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewTS)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTipoServicio"
        Me.Text = "FrmTipoServicio"
        CType(Me.DataGridViewTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtencionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtencionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTS As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAreaRTS As TextBox
    Friend WithEvents TxtCostoS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Hospital1DataSet As Hospital1DataSet
    Friend WithEvents TipoServicioBindingSource As BindingSource
    Friend WithEvents Tipo_ServicioTableAdapter As Hospital1DataSetTableAdapters.Tipo_ServicioTableAdapter
    Friend WithEvents IDTServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreaRelacionadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDAtencionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicocreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicoactualizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AtencionBindingSource As BindingSource
    Friend WithEvents AtencionTableAdapter As Hospital1DataSetTableAdapters.AtencionTableAdapter
    Friend WithEvents ServicioBindingSource As BindingSource
    Friend WithEvents ServicioTableAdapter As Hospital1DataSetTableAdapters.ServicioTableAdapter
    Friend WithEvents DetalleFacturaBindingSource As BindingSource
    Friend WithEvents Detalle_FacturaTableAdapter As Hospital1DataSetTableAdapters.Detalle_FacturaTableAdapter
    Friend WithEvents AtencionBindingSource1 As BindingSource
    Private WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
