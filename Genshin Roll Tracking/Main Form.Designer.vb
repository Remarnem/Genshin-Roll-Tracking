<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btn3star = New System.Windows.Forms.Button()
        Me.btn4star = New System.Windows.Forms.Button()
        Me.btn5star = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txt4Star = New System.Windows.Forms.TextBox()
        Me.txt5Star = New System.Windows.Forms.TextBox()
        Me.lbl4StarCount = New System.Windows.Forms.Label()
        Me.lbl5StarCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn3star
        '
        Me.btn3star.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3star.Location = New System.Drawing.Point(13, 12)
        Me.btn3star.Name = "btn3star"
        Me.btn3star.Size = New System.Drawing.Size(75, 23)
        Me.btn3star.TabIndex = 0
        Me.btn3star.Text = "Add 3 Star"
        Me.btn3star.UseVisualStyleBackColor = True
        '
        'btn4star
        '
        Me.btn4star.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4star.Location = New System.Drawing.Point(13, 42)
        Me.btn4star.Name = "btn4star"
        Me.btn4star.Size = New System.Drawing.Size(75, 23)
        Me.btn4star.TabIndex = 1
        Me.btn4star.Text = "Add 4 Star"
        Me.btn4star.UseVisualStyleBackColor = True
        '
        'btn5star
        '
        Me.btn5star.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5star.Location = New System.Drawing.Point(13, 72)
        Me.btn5star.Name = "btn5star"
        Me.btn5star.Size = New System.Drawing.Size(75, 23)
        Me.btn5star.TabIndex = 2
        Me.btn5star.Text = "Add 5 Star"
        Me.btn5star.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(13, 130)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txt4Star
        '
        Me.txt4Star.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt4Star.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4Star.Location = New System.Drawing.Point(151, 28)
        Me.txt4Star.Name = "txt4Star"
        Me.txt4Star.ReadOnly = True
        Me.txt4Star.Size = New System.Drawing.Size(100, 33)
        Me.txt4Star.TabIndex = 5
        Me.txt4Star.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5Star
        '
        Me.txt5Star.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt5Star.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5Star.Location = New System.Drawing.Point(151, 88)
        Me.txt5Star.Name = "txt5Star"
        Me.txt5Star.ReadOnly = True
        Me.txt5Star.Size = New System.Drawing.Size(100, 33)
        Me.txt5Star.TabIndex = 7
        Me.txt5Star.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl4StarCount
        '
        Me.lbl4StarCount.AutoSize = True
        Me.lbl4StarCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4StarCount.Location = New System.Drawing.Point(148, 12)
        Me.lbl4StarCount.Name = "lbl4StarCount"
        Me.lbl4StarCount.Size = New System.Drawing.Size(85, 13)
        Me.lbl4StarCount.TabIndex = 4
        Me.lbl4StarCount.Text = "Until 4 Star Pity"
        '
        'lbl5StarCount
        '
        Me.lbl5StarCount.AutoSize = True
        Me.lbl5StarCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5StarCount.Location = New System.Drawing.Point(148, 72)
        Me.lbl5StarCount.Name = "lbl5StarCount"
        Me.lbl5StarCount.Size = New System.Drawing.Size(85, 13)
        Me.lbl5StarCount.TabIndex = 6
        Me.lbl5StarCount.Text = "Until 5 Star Pity"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 165)
        Me.Controls.Add(Me.lbl5StarCount)
        Me.Controls.Add(Me.lbl4StarCount)
        Me.Controls.Add(Me.txt5Star)
        Me.Controls.Add(Me.txt4Star)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btn5star)
        Me.Controls.Add(Me.btn4star)
        Me.Controls.Add(Me.btn3star)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Roll Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn3star As Button
    Friend WithEvents btn4star As Button
    Friend WithEvents btn5star As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txt4Star As TextBox
    Friend WithEvents txt5Star As TextBox
    Friend WithEvents lbl4StarCount As Label
    Friend WithEvents lbl5StarCount As Label
End Class
