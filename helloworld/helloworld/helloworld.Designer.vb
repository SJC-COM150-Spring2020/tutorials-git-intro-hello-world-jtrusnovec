<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class helloworld
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPress = New System.Windows.Forms.Button()
        Me.lstHello = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnPress
        '
        Me.btnPress.BackColor = System.Drawing.Color.Aqua
        Me.btnPress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPress.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPress.Location = New System.Drawing.Point(283, 169)
        Me.btnPress.Name = "btnPress"
        Me.btnPress.Size = New System.Drawing.Size(209, 64)
        Me.btnPress.TabIndex = 0
        Me.btnPress.Text = "Press Me!"
        Me.btnPress.UseVisualStyleBackColor = False
        '
        'lstHello
        '
        Me.lstHello.BackColor = System.Drawing.Color.Blue
        Me.lstHello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstHello.Font = New System.Drawing.Font("Papyrus", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHello.ForeColor = System.Drawing.Color.White
        Me.lstHello.FormattingEnabled = True
        Me.lstHello.ItemHeight = 33
        Me.lstHello.Location = New System.Drawing.Point(256, 265)
        Me.lstHello.Name = "lstHello"
        Me.lstHello.Size = New System.Drawing.Size(262, 167)
        Me.lstHello.TabIndex = 1
        '
        'helloworld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(791, 552)
        Me.Controls.Add(Me.lstHello)
        Me.Controls.Add(Me.btnPress)
        Me.Name = "helloworld"
        Me.Text = "hello"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents lstHello As ListBox
End Class
