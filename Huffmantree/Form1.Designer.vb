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
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Letters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frequency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeightingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetterofnodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CnodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'grid
        '
        Me.grid.AutoGenerateColumns = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Letters, Me.Frequency, Me.Code, Me.WeightingDataGridViewTextBoxColumn, Me.LetterofnodeDataGridViewTextBoxColumn, Me.PointerDataGridViewTextBoxColumn})
        Me.grid.DataSource = Me.CnodeBindingSource
        Me.grid.Location = New System.Drawing.Point(158, 12)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.Height = 24
        Me.grid.Size = New System.Drawing.Size(451, 378)
        Me.grid.TabIndex = 0
        '
        'Letters
        '
        Me.Letters.HeaderText = "Letters"
        Me.Letters.Name = "Letters"
        Me.Letters.ReadOnly = True
        '
        'Frequency
        '
        Me.Frequency.HeaderText = "Frequency"
        Me.Frequency.Name = "Frequency"
        Me.Frequency.ReadOnly = True
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grid)
        Me.Name = "Form1"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CnodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents grid As DataGridView
    Friend WithEvents Letters As DataGridViewTextBoxColumn
    Friend WithEvents Frequency As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents WeightingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LetterofnodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnodeBindingSource As BindingSource
End Class
