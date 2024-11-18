<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(85, 38)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(822, 34)
        Me.txtSearch.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(822, 59)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(85, 187)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(822, 404)
        Me.lstResults.TabIndex = 2
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(85, 618)
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(155, 22)
        Me.txtError.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 726)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents txtError As TextBox
End Class
