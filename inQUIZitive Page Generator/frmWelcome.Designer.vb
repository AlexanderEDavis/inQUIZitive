<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.btnYes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(12, 63)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(236, 88)
        Me.btnYes.TabIndex = 0
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 47)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Would you like to import a CSV file?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(268, 63)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(236, 88)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 163)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnYes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWelcome"
        Me.Text = "inQUIZitive Page Generator - Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnYes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNo As Button
End Class
