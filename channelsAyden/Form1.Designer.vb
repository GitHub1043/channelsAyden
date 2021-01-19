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
        Me.chkAnimal = New System.Windows.Forms.CheckBox()
        Me.chkDiscovery = New System.Windows.Forms.CheckBox()
        Me.chkFood = New System.Windows.Forms.CheckBox()
        Me.chkHGTV = New System.Windows.Forms.CheckBox()
        Me.chkCNN = New System.Windows.Forms.CheckBox()
        Me.chkMSNBC = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkAnimal
        '
        Me.chkAnimal.AutoSize = True
        Me.chkAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnimal.Location = New System.Drawing.Point(36, 111)
        Me.chkAnimal.Name = "chkAnimal"
        Me.chkAnimal.Size = New System.Drawing.Size(187, 24)
        Me.chkAnimal.TabIndex = 0
        Me.chkAnimal.Text = "Animal Planet (Nature)"
        Me.chkAnimal.UseVisualStyleBackColor = True
        '
        'chkDiscovery
        '
        Me.chkDiscovery.AutoSize = True
        Me.chkDiscovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiscovery.Location = New System.Drawing.Point(36, 149)
        Me.chkDiscovery.Name = "chkDiscovery"
        Me.chkDiscovery.Size = New System.Drawing.Size(203, 24)
        Me.chkDiscovery.TabIndex = 1
        Me.chkDiscovery.Text = "Discovery World (Nature)"
        Me.chkDiscovery.UseVisualStyleBackColor = True
        '
        'chkFood
        '
        Me.chkFood.AutoSize = True
        Me.chkFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFood.Location = New System.Drawing.Point(308, 111)
        Me.chkFood.Name = "chkFood"
        Me.chkFood.Size = New System.Drawing.Size(167, 24)
        Me.chkFood.TabIndex = 2
        Me.chkFood.Text = "Food Network (Life)"
        Me.chkFood.UseVisualStyleBackColor = True
        '
        'chkHGTV
        '
        Me.chkHGTV.AutoSize = True
        Me.chkHGTV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHGTV.Location = New System.Drawing.Point(308, 149)
        Me.chkHGTV.Name = "chkHGTV"
        Me.chkHGTV.Size = New System.Drawing.Size(113, 24)
        Me.chkHGTV.TabIndex = 3
        Me.chkHGTV.Text = "HGTV (Life)"
        Me.chkHGTV.UseVisualStyleBackColor = True
        '
        'chkCNN
        '
        Me.chkCNN.AutoSize = True
        Me.chkCNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCNN.Location = New System.Drawing.Point(552, 111)
        Me.chkCNN.Name = "chkCNN"
        Me.chkCNN.Size = New System.Drawing.Size(114, 24)
        Me.chkCNN.TabIndex = 4
        Me.chkCNN.Text = "CNN (News)"
        Me.chkCNN.UseVisualStyleBackColor = True
        '
        'chkMSNBC
        '
        Me.chkMSNBC.AutoSize = True
        Me.chkMSNBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMSNBC.Location = New System.Drawing.Point(552, 149)
        Me.chkMSNBC.Name = "chkMSNBC"
        Me.chkMSNBC.Size = New System.Drawing.Size(138, 24)
        Me.chkMSNBC.TabIndex = 5
        Me.chkMSNBC.Text = "MSNBC (News)"
        Me.chkMSNBC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pick The Channels That You Would Like To Order"
        '
        'btnPrice
        '
        Me.btnPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrice.Location = New System.Drawing.Point(231, 252)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(125, 34)
        Me.btnPrice.TabIndex = 7
        Me.btnPrice.Text = "Display Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(391, 252)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(104, 13)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Monthly Price: $0.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 332)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkMSNBC)
        Me.Controls.Add(Me.chkCNN)
        Me.Controls.Add(Me.chkHGTV)
        Me.Controls.Add(Me.chkFood)
        Me.Controls.Add(Me.chkDiscovery)
        Me.Controls.Add(Me.chkAnimal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAnimal As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiscovery As System.Windows.Forms.CheckBox
    Friend WithEvents chkFood As System.Windows.Forms.CheckBox
    Friend WithEvents chkHGTV As System.Windows.Forms.CheckBox
    Friend WithEvents chkCNN As System.Windows.Forms.CheckBox
    Friend WithEvents chkMSNBC As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrice As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label

End Class
