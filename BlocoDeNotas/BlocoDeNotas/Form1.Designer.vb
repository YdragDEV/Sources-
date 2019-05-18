<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FonteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimparToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorDaFonteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorDeFundoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.FerramentaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(785, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(785, 560)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'FerramentaToolStripMenuItem
        '
        Me.FerramentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FonteToolStripMenuItem, Me.CoresToolStripMenuItem, Me.LimparToolStripMenuItem})
        Me.FerramentaToolStripMenuItem.Name = "FerramentaToolStripMenuItem"
        Me.FerramentaToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.FerramentaToolStripMenuItem.Text = "Ferramentas"
        '
        'FonteToolStripMenuItem
        '
        Me.FonteToolStripMenuItem.Name = "FonteToolStripMenuItem"
        Me.FonteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FonteToolStripMenuItem.Text = "Fonte"
        '
        'CoresToolStripMenuItem
        '
        Me.CoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorDaFonteToolStripMenuItem, Me.CorDeFundoToolStripMenuItem})
        Me.CoresToolStripMenuItem.Name = "CoresToolStripMenuItem"
        Me.CoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CoresToolStripMenuItem.Text = "Cores"
        '
        'LimparToolStripMenuItem
        '
        Me.LimparToolStripMenuItem.Name = "LimparToolStripMenuItem"
        Me.LimparToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimparToolStripMenuItem.Text = "Limpar"
        '
        'CorDaFonteToolStripMenuItem
        '
        Me.CorDaFonteToolStripMenuItem.Name = "CorDaFonteToolStripMenuItem"
        Me.CorDaFonteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CorDaFonteToolStripMenuItem.Text = "Cor da Fonte"
        '
        'CorDeFundoToolStripMenuItem
        '
        Me.CorDeFundoToolStripMenuItem.Name = "CorDeFundoToolStripMenuItem"
        Me.CorDeFundoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CorDeFundoToolStripMenuItem.Text = "Cor de Fundo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(644, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(644, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Aziideia"
        Me.OpenFileDialog1.Filter = "Arquivo De Texto (*.txt)|*.txt"
        Me.OpenFileDialog1.Title = "Arquivo de Texto"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Aziideia.txt"
        Me.SaveFileDialog1.Filter = "Arquivo De Texto (*.txt)|*.txt"
        Me.SaveFileDialog1.Title = "Salvar Arquivo De Texto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 584)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Bloco de Notas by Aziideia"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerramentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FonteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorDaFonteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorDeFundoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimparToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
