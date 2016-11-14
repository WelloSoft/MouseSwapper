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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Enabler = New System.Windows.Forms.CheckBox()
        Me.AutoFlip = New System.Windows.Forms.CheckBox()
        Me.FlipX = New System.Windows.Forms.CheckBox()
        Me.FlipY = New System.Windows.Forms.CheckBox()
        Me.SwapXY = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Enabler, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AutoFlip, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlipX, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlipY, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SwapXY, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(311, 135)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Enabler
        '
        Me.Enabler.Appearance = System.Windows.Forms.Appearance.Button
        Me.Enabler.AutoSize = True
        Me.Enabler.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Enabler.Checked = True
        Me.Enabler.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TableLayoutPanel1.SetColumnSpan(Me.Enabler, 3)
        Me.Enabler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Enabler.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Enabler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enabler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Enabler.ForeColor = System.Drawing.Color.White
        Me.Enabler.Location = New System.Drawing.Point(3, 3)
        Me.Enabler.Name = "Enabler"
        Me.Enabler.Size = New System.Drawing.Size(305, 54)
        Me.Enabler.TabIndex = 4
        Me.Enabler.Text = "Activate"
        Me.Enabler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Enabler.UseVisualStyleBackColor = False
        '
        'AutoFlip
        '
        Me.AutoFlip.AutoSize = True
        Me.AutoFlip.Checked = True
        Me.AutoFlip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TableLayoutPanel1.SetColumnSpan(Me.AutoFlip, 3)
        Me.AutoFlip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutoFlip.Location = New System.Drawing.Point(3, 63)
        Me.AutoFlip.Name = "AutoFlip"
        Me.AutoFlip.Size = New System.Drawing.Size(305, 31)
        Me.AutoFlip.TabIndex = 3
        Me.AutoFlip.Text = "Auto Flip"
        Me.AutoFlip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AutoFlip.UseVisualStyleBackColor = True
        '
        'FlipX
        '
        Me.FlipX.AutoSize = True
        Me.FlipX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlipX.Location = New System.Drawing.Point(3, 100)
        Me.FlipX.Name = "FlipX"
        Me.FlipX.Size = New System.Drawing.Size(97, 32)
        Me.FlipX.TabIndex = 0
        Me.FlipX.Text = "Flip X"
        Me.FlipX.UseVisualStyleBackColor = True
        '
        'FlipY
        '
        Me.FlipY.AutoSize = True
        Me.FlipY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlipY.Location = New System.Drawing.Point(106, 100)
        Me.FlipY.Name = "FlipY"
        Me.FlipY.Size = New System.Drawing.Size(97, 32)
        Me.FlipY.TabIndex = 1
        Me.FlipY.Text = "FlipY"
        Me.FlipY.UseVisualStyleBackColor = True
        '
        'SwapXY
        '
        Me.SwapXY.AutoSize = True
        Me.SwapXY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SwapXY.Location = New System.Drawing.Point(209, 100)
        Me.SwapXY.Name = "SwapXY"
        Me.SwapXY.Size = New System.Drawing.Size(99, 32)
        Me.SwapXY.TabIndex = 2
        Me.SwapXY.Text = "Swap X & Y"
        Me.SwapXY.UseMnemonic = False
        Me.SwapXY.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 135)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Mouse Swapper"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlipX As System.Windows.Forms.CheckBox
    Friend WithEvents FlipY As System.Windows.Forms.CheckBox
    Friend WithEvents SwapXY As System.Windows.Forms.CheckBox
    Friend WithEvents AutoFlip As System.Windows.Forms.CheckBox
    Friend WithEvents Enabler As System.Windows.Forms.CheckBox

End Class
