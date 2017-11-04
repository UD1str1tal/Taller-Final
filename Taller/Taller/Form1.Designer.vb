<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AplicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplicacionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(978, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AplicacionesToolStripMenuItem
        '
        Me.AplicacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DadosToolStripMenuItem, Me.BalotoToolStripMenuItem, Me.MatrizToolStripMenuItem, Me.OrdenarToolStripMenuItem})
        Me.AplicacionesToolStripMenuItem.Image = CType(resources.GetObject("AplicacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AplicacionesToolStripMenuItem.Name = "AplicacionesToolStripMenuItem"
        Me.AplicacionesToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.AplicacionesToolStripMenuItem.Text = "&Aplicaciones "
        '
        'DadosToolStripMenuItem
        '
        Me.DadosToolStripMenuItem.Image = CType(resources.GetObject("DadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DadosToolStripMenuItem.Name = "DadosToolStripMenuItem"
        Me.DadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DadosToolStripMenuItem.Text = "&Dados"
        '
        'BalotoToolStripMenuItem
        '
        Me.BalotoToolStripMenuItem.Image = CType(resources.GetObject("BalotoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BalotoToolStripMenuItem.Name = "BalotoToolStripMenuItem"
        Me.BalotoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BalotoToolStripMenuItem.Text = "&Baloto"
        '
        'MatrizToolStripMenuItem
        '
        Me.MatrizToolStripMenuItem.Name = "MatrizToolStripMenuItem"
        Me.MatrizToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MatrizToolStripMenuItem.Text = "&Matriz"
        '
        'OrdenarToolStripMenuItem
        '
        Me.OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        Me.OrdenarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrdenarToolStripMenuItem.Text = "&Ordenar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 706)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(12, 133)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(943, 552)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(12, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(943, 112)
        Me.Panel2.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(978, 759)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AplicacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BalotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
