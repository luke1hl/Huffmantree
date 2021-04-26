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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CnodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeightingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetterofnodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CnodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WeightingDataGridViewTextBoxColumn, Me.LetterofnodeDataGridViewTextBoxColumn, Me.PointerDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CnodeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(168, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'CnodeBindingSource
        '
        Me.CnodeBindingSource.DataSource = GetType(Huffmantree.Cnode)
        '
        'WeightingDataGridViewTextBoxColumn
        '
        Me.WeightingDataGridViewTextBoxColumn.DataPropertyName = "weighting"
        Me.WeightingDataGridViewTextBoxColumn.HeaderText = "weighting"
        Me.WeightingDataGridViewTextBoxColumn.Name = "WeightingDataGridViewTextBoxColumn"
        '
        'LetterofnodeDataGridViewTextBoxColumn
        '
        Me.LetterofnodeDataGridViewTextBoxColumn.DataPropertyName = "letterofnode"
        Me.LetterofnodeDataGridViewTextBoxColumn.HeaderText = "letterofnode"
        Me.LetterofnodeDataGridViewTextBoxColumn.Name = "LetterofnodeDataGridViewTextBoxColumn"
        '
        'PointerDataGridViewTextBoxColumn
        '
        Me.PointerDataGridViewTextBoxColumn.DataPropertyName = "pointer"
        Me.PointerDataGridViewTextBoxColumn.HeaderText = "pointer"
        Me.PointerDataGridViewTextBoxColumn.Name = "PointerDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CnodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WeightingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LetterofnodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnodeBindingSource As BindingSource
End Class
