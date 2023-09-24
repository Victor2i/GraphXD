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
        Me.ElementList = New System.Windows.Forms.ListBox()
        Me.NewElement = New System.Windows.Forms.Button()
        Me.DestroyElement = New System.Windows.Forms.Button()
        Me.ElementColor = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExtLoadElementData = New System.Windows.Forms.Button()
        Me.ExtSaveElementData = New System.Windows.Forms.Button()
        Me.ElementDataList = New System.Windows.Forms.ListBox()
        Me.SelDataX = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SelDataY = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DecimalPlacesMax = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GraphType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StepX = New System.Windows.Forms.NumericUpDown()
        Me.StepY = New System.Windows.Forms.NumericUpDown()
        Me.OutResY = New System.Windows.Forms.NumericUpDown()
        Me.OutResX = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.RenderButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Spacing = New System.Windows.Forms.NumericUpDown()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LineWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.ElementColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelDataX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelDataY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecimalPlacesMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StepX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StepY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutResY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutResX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spacing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElementList
        '
        Me.ElementList.FormattingEnabled = True
        Me.ElementList.ItemHeight = 15
        Me.ElementList.Location = New System.Drawing.Point(0, 0)
        Me.ElementList.Name = "ElementList"
        Me.ElementList.Size = New System.Drawing.Size(229, 244)
        Me.ElementList.TabIndex = 0
        '
        'NewElement
        '
        Me.NewElement.Location = New System.Drawing.Point(0, 250)
        Me.NewElement.Name = "NewElement"
        Me.NewElement.Size = New System.Drawing.Size(112, 23)
        Me.NewElement.TabIndex = 1
        Me.NewElement.Text = "New"
        Me.NewElement.UseVisualStyleBackColor = True
        '
        'DestroyElement
        '
        Me.DestroyElement.Location = New System.Drawing.Point(118, 250)
        Me.DestroyElement.Name = "DestroyElement"
        Me.DestroyElement.Size = New System.Drawing.Size(111, 23)
        Me.DestroyElement.TabIndex = 2
        Me.DestroyElement.Text = "Delete"
        Me.DestroyElement.UseVisualStyleBackColor = True
        '
        'ElementColor
        '
        Me.ElementColor.BackColor = System.Drawing.Color.White
        Me.ElementColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ElementColor.Location = New System.Drawing.Point(309, 7)
        Me.ElementColor.Name = "ElementColor"
        Me.ElementColor.Size = New System.Drawing.Size(32, 32)
        Me.ElementColor.TabIndex = 4
        Me.ElementColor.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.Location = New System.Drawing.Point(235, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Color:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.Location = New System.Drawing.Point(235, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Data:"
        '
        'ExtLoadElementData
        '
        Me.ExtLoadElementData.Location = New System.Drawing.Point(235, 80)
        Me.ExtLoadElementData.Name = "ExtLoadElementData"
        Me.ExtLoadElementData.Size = New System.Drawing.Size(68, 23)
        Me.ExtLoadElementData.TabIndex = 7
        Me.ExtLoadElementData.Text = "Load"
        Me.ExtLoadElementData.UseVisualStyleBackColor = True
        '
        'ExtSaveElementData
        '
        Me.ExtSaveElementData.Location = New System.Drawing.Point(235, 109)
        Me.ExtSaveElementData.Name = "ExtSaveElementData"
        Me.ExtSaveElementData.Size = New System.Drawing.Size(68, 23)
        Me.ExtSaveElementData.TabIndex = 8
        Me.ExtSaveElementData.Text = "Save"
        Me.ExtSaveElementData.UseVisualStyleBackColor = True
        '
        'ElementDataList
        '
        Me.ElementDataList.FormattingEnabled = True
        Me.ElementDataList.ItemHeight = 15
        Me.ElementDataList.Location = New System.Drawing.Point(309, 45)
        Me.ElementDataList.Name = "ElementDataList"
        Me.ElementDataList.Size = New System.Drawing.Size(205, 199)
        Me.ElementDataList.TabIndex = 9
        '
        'SelDataX
        '
        Me.SelDataX.DecimalPlaces = 2
        Me.SelDataX.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.SelDataX.Location = New System.Drawing.Point(390, 282)
        Me.SelDataX.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.SelDataX.Name = "SelDataX"
        Me.SelDataX.Size = New System.Drawing.Size(120, 39)
        Me.SelDataX.TabIndex = 10
        Me.SelDataX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(351, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 32)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "X:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.Location = New System.Drawing.Point(351, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Y:"
        '
        'SelDataY
        '
        Me.SelDataY.DecimalPlaces = 2
        Me.SelDataY.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.SelDataY.Location = New System.Drawing.Point(390, 327)
        Me.SelDataY.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.SelDataY.Name = "SelDataY"
        Me.SelDataY.Size = New System.Drawing.Size(120, 39)
        Me.SelDataY.TabIndex = 12
        Me.SelDataY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.Location = New System.Drawing.Point(351, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 32)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Selected data:"
        '
        'DecimalPlacesMax
        '
        Me.DecimalPlacesMax.Location = New System.Drawing.Point(454, 374)
        Me.DecimalPlacesMax.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.DecimalPlacesMax.Name = "DecimalPlacesMax"
        Me.DecimalPlacesMax.Size = New System.Drawing.Size(56, 23)
        Me.DecimalPlacesMax.TabIndex = 15
        Me.DecimalPlacesMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DecimalPlacesMax.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(390, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Decimals:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(347, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 32)
        Me.TextBox1.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label7.Location = New System.Drawing.Point(12, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Graph type:"
        '
        'GraphType
        '
        Me.GraphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GraphType.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.GraphType.FormattingEnabled = True
        Me.GraphType.Items.AddRange(New Object() {"Towers", "Towers (1 element)", "Lines"})
        Me.GraphType.Location = New System.Drawing.Point(108, 282)
        Me.GraphType.Name = "GraphType"
        Me.GraphType.Size = New System.Drawing.Size(121, 29)
        Me.GraphType.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label8.Location = New System.Drawing.Point(12, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Step:"
        '
        'StepX
        '
        Me.StepX.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.StepX.Location = New System.Drawing.Point(108, 342)
        Me.StepX.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.StepX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StepX.Name = "StepX"
        Me.StepX.Size = New System.Drawing.Size(70, 29)
        Me.StepX.TabIndex = 21
        Me.StepX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StepX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'StepY
        '
        Me.StepY.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.StepY.Location = New System.Drawing.Point(184, 342)
        Me.StepY.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.StepY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StepY.Name = "StepY"
        Me.StepY.Size = New System.Drawing.Size(70, 29)
        Me.StepY.TabIndex = 22
        Me.StepY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StepY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'OutResY
        '
        Me.OutResY.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.OutResY.Location = New System.Drawing.Point(184, 377)
        Me.OutResY.Maximum = New Decimal(New Integer() {32768, 0, 0, 0})
        Me.OutResY.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.OutResY.Name = "OutResY"
        Me.OutResY.Size = New System.Drawing.Size(70, 29)
        Me.OutResY.TabIndex = 25
        Me.OutResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OutResY.Value = New Decimal(New Integer() {768, 0, 0, 0})
        '
        'OutResX
        '
        Me.OutResX.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.OutResX.Location = New System.Drawing.Point(108, 377)
        Me.OutResX.Maximum = New Decimal(New Integer() {32768, 0, 0, 0})
        Me.OutResX.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.OutResX.Name = "OutResX"
        Me.OutResX.Size = New System.Drawing.Size(70, 29)
        Me.OutResX.TabIndex = 24
        Me.OutResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OutResX.Value = New Decimal(New Integer() {1024, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label9.Location = New System.Drawing.Point(12, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Resolution:"
        '
        'RenderButton
        '
        Me.RenderButton.Location = New System.Drawing.Point(247, 412)
        Me.RenderButton.Name = "RenderButton"
        Me.RenderButton.Size = New System.Drawing.Size(70, 29)
        Me.RenderButton.TabIndex = 28
        Me.RenderButton.Text = "RENDER"
        Me.RenderButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label10.Location = New System.Drawing.Point(11, 415)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 24)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Tower" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "spacing:"
        '
        'Spacing
        '
        Me.Spacing.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Spacing.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Spacing.Location = New System.Drawing.Point(58, 412)
        Me.Spacing.Maximum = New Decimal(New Integer() {32768, 0, 0, 0})
        Me.Spacing.Name = "Spacing"
        Me.Spacing.Size = New System.Drawing.Size(70, 29)
        Me.Spacing.TabIndex = 30
        Me.Spacing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Spacing.Value = New Decimal(New Integer() {70, 0, 0, 0})
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Text file|*.txt|All files|*.*"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text file|*.txt|All files|*.*"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 317)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 19)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.Text = "Enable scale/grid"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SaveFileDialog2
        '
        Me.SaveFileDialog2.Filter = "PNG image|*.png"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LineWidth
        '
        Me.LineWidth.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LineWidth.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.LineWidth.Location = New System.Drawing.Point(171, 412)
        Me.LineWidth.Maximum = New Decimal(New Integer() {32768, 0, 0, 0})
        Me.LineWidth.Name = "LineWidth"
        Me.LineWidth.Size = New System.Drawing.Size(70, 29)
        Me.LineWidth.TabIndex = 34
        Me.LineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LineWidth.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label11.Location = New System.Drawing.Point(134, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 24)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "width:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 453)
        Me.Controls.Add(Me.LineWidth)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Spacing)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RenderButton)
        Me.Controls.Add(Me.OutResY)
        Me.Controls.Add(Me.OutResX)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.StepY)
        Me.Controls.Add(Me.StepX)
        Me.Controls.Add(Me.ElementColor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GraphType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DecimalPlacesMax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SelDataY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SelDataX)
        Me.Controls.Add(Me.ElementDataList)
        Me.Controls.Add(Me.ExtSaveElementData)
        Me.Controls.Add(Me.ExtLoadElementData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DestroyElement)
        Me.Controls.Add(Me.NewElement)
        Me.Controls.Add(Me.ElementList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Graph (XD)"
        CType(Me.ElementColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelDataX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelDataY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecimalPlacesMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StepX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StepY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutResY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutResX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spacing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ElementList As ListBox
    Friend WithEvents NewElement As Button
    Friend WithEvents DestroyElement As Button
    Friend WithEvents ElementColor As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExtLoadElementData As Button
    Friend WithEvents ExtSaveElementData As Button
    Friend WithEvents ElementDataList As ListBox
    Friend WithEvents SelDataX As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SelDataY As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents DecimalPlacesMax As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GraphType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents StepX As NumericUpDown
    Friend WithEvents StepY As NumericUpDown
    Friend WithEvents OutResY As NumericUpDown
    Friend WithEvents OutResX As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents RenderButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Spacing As NumericUpDown
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents LineWidth As NumericUpDown
    Friend WithEvents Label11 As Label
End Class
