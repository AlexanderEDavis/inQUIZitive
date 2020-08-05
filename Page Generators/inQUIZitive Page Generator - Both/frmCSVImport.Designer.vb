<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCSVImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCSVImport))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.dbxSourceDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnSourceBrowse = New System.Windows.Forms.Button()
        Me.tbxSourceLocation = New System.Windows.Forms.TextBox()
        Me.tbxDestinationLocation = New System.Windows.Forms.TextBox()
        Me.btnDestinationBrowse = New System.Windows.Forms.Button()
        Me.dbxDestinationDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(12, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(104, 50)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(379, 126)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(116, 51)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(12, 73)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(44, 13)
        Me.lblSource.TabIndex = 3
        Me.lblSource.Text = "Source:"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(12, 102)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(63, 13)
        Me.lblDestination.TabIndex = 4
        Me.lblDestination.Text = "Destination:"
        '
        'btnSourceBrowse
        '
        Me.btnSourceBrowse.Location = New System.Drawing.Point(420, 68)
        Me.btnSourceBrowse.Name = "btnSourceBrowse"
        Me.btnSourceBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnSourceBrowse.TabIndex = 5
        Me.btnSourceBrowse.Text = "Browse"
        Me.btnSourceBrowse.UseVisualStyleBackColor = True
        '
        'tbxSourceLocation
        '
        Me.tbxSourceLocation.Location = New System.Drawing.Point(81, 69)
        Me.tbxSourceLocation.Name = "tbxSourceLocation"
        Me.tbxSourceLocation.Size = New System.Drawing.Size(333, 20)
        Me.tbxSourceLocation.TabIndex = 6
        '
        'tbxDestinationLocation
        '
        Me.tbxDestinationLocation.Location = New System.Drawing.Point(81, 98)
        Me.tbxDestinationLocation.Name = "tbxDestinationLocation"
        Me.tbxDestinationLocation.Size = New System.Drawing.Size(333, 20)
        Me.tbxDestinationLocation.TabIndex = 7
        '
        'btnDestinationBrowse
        '
        Me.btnDestinationBrowse.Location = New System.Drawing.Point(420, 97)
        Me.btnDestinationBrowse.Name = "btnDestinationBrowse"
        Me.btnDestinationBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnDestinationBrowse.TabIndex = 8
        Me.btnDestinationBrowse.Text = "Browse"
        Me.btnDestinationBrowse.UseVisualStyleBackColor = True
        '
        'frmCSVImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 182)
        Me.Controls.Add(Me.btnDestinationBrowse)
        Me.Controls.Add(Me.tbxDestinationLocation)
        Me.Controls.Add(Me.tbxSourceLocation)
        Me.Controls.Add(Me.btnSourceBrowse)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnHome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCSVImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inQUIZitive Page Generator - Importing CSV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents lblSource As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents dbxSourceDialog As OpenFileDialog
    Friend WithEvents btnSourceBrowse As Button
    Friend WithEvents tbxSourceLocation As TextBox
    Friend WithEvents tbxDestinationLocation As TextBox
    Friend WithEvents btnDestinationBrowse As Button
    Friend WithEvents dbxDestinationDialog As SaveFileDialog
End Class
