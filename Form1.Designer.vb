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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.outputt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(36, 87)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(213, 225)
        Me.ListBox1.TabIndex = 2
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(36, 36)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(213, 23)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "Click to Start"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'outputt
        '
        Me.outputt.AutoSize = True
        Me.outputt.Location = New System.Drawing.Point(19, 332)
        Me.outputt.Name = "outputt"
        Me.outputt.Size = New System.Drawing.Size(13, 13)
        Me.outputt.TabIndex = 4
        Me.outputt.Text = ": "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 354)
        Me.Controls.Add(Me.outputt)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_add As Button
    Friend WithEvents outputt As Label
End Class
