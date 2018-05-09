<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DemoForm1
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
        Me.OpenDialog_Button = New System.Windows.Forms.Button()
        Me.FormResize_Label = New System.Windows.Forms.Label()
        Me.ShadowRadius_NUD = New System.Windows.Forms.NumericUpDown()
        Me.Spread_NUD = New System.Windows.Forms.NumericUpDown()
        Me.Blur_NUD = New System.Windows.Forms.NumericUpDown()
        Me.ShadowH_NUD = New System.Windows.Forms.NumericUpDown()
        Me.ShadowV_NUD = New System.Windows.Forms.NumericUpDown()
        Me.BackColor_LabelRGB = New System.Windows.Forms.Label()
        Me.ShadowOpacity_NUD = New System.Windows.Forms.NumericUpDown()
        Me.ShadowOpacity_Label = New System.Windows.Forms.Label()
        Me.ShadowRadius_Label = New System.Windows.Forms.Label()
        Me.BackColor_Button = New System.Windows.Forms.Button()
        Me.BackColor_Label = New System.Windows.Forms.Label()
        Me.ShadowColor_Button = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ShadowColor_LabelRGB = New System.Windows.Forms.Label()
        Me.ShadowColor_Label = New System.Windows.Forms.Label()
        Me.Spread_Label = New System.Windows.Forms.Label()
        Me.Blur_Label = New System.Windows.Forms.Label()
        Me.ShadowH_Label = New System.Windows.Forms.Label()
        Me.ShadowV_Label = New System.Windows.Forms.Label()
        Me.OpenForm_Button = New System.Windows.Forms.Button()
        Me.FormRadius_NUD = New System.Windows.Forms.NumericUpDown()
        Me.FormRadius_Label = New System.Windows.Forms.Label()
        Me.Properties_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Actions_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.Minimize_Button = New System.Windows.Forms.Button()
        Me.Maximize_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.DragForm_Label = New System.Windows.Forms.Label()
        Me.Handlers_GroupBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.ShadowRadius_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spread_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blur_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowH_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowV_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowOpacity_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormRadius_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Properties_GroupBox.SuspendLayout()
        Me.Actions_GroupBox.SuspendLayout()
        Me.Handlers_GroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenDialog_Button
        '
        Me.OpenDialog_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenDialog_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OpenDialog_Button.Location = New System.Drawing.Point(6, 109)
        Me.OpenDialog_Button.Name = "OpenDialog_Button"
        Me.OpenDialog_Button.Size = New System.Drawing.Size(99, 52)
        Me.OpenDialog_Button.TabIndex = 3
        Me.OpenDialog_Button.Text = "Open form as dialog"
        Me.OpenDialog_Button.UseVisualStyleBackColor = True
        '
        'FormResize_Label
        '
        Me.FormResize_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormResize_Label.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FormResize_Label.Image = Global.DropShadowDemo.My.Resources.Resources.size_grip
        Me.FormResize_Label.Location = New System.Drawing.Point(373, 64)
        Me.FormResize_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.FormResize_Label.Name = "FormResize_Label"
        Me.FormResize_Label.Size = New System.Drawing.Size(16, 16)
        Me.FormResize_Label.TabIndex = 0
        Me.FormResize_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShadowRadius_NUD
        '
        Me.ShadowRadius_NUD.Location = New System.Drawing.Point(139, 225)
        Me.ShadowRadius_NUD.Name = "ShadowRadius_NUD"
        Me.ShadowRadius_NUD.Size = New System.Drawing.Size(81, 23)
        Me.ShadowRadius_NUD.TabIndex = 8
        '
        'Spread_NUD
        '
        Me.Spread_NUD.Location = New System.Drawing.Point(139, 196)
        Me.Spread_NUD.Name = "Spread_NUD"
        Me.Spread_NUD.Size = New System.Drawing.Size(81, 23)
        Me.Spread_NUD.TabIndex = 7
        '
        'Blur_NUD
        '
        Me.Blur_NUD.Location = New System.Drawing.Point(139, 167)
        Me.Blur_NUD.Name = "Blur_NUD"
        Me.Blur_NUD.Size = New System.Drawing.Size(81, 23)
        Me.Blur_NUD.TabIndex = 6
        '
        'ShadowH_NUD
        '
        Me.ShadowH_NUD.Location = New System.Drawing.Point(139, 138)
        Me.ShadowH_NUD.Name = "ShadowH_NUD"
        Me.ShadowH_NUD.Size = New System.Drawing.Size(81, 23)
        Me.ShadowH_NUD.TabIndex = 5
        '
        'ShadowV_NUD
        '
        Me.ShadowV_NUD.Location = New System.Drawing.Point(139, 109)
        Me.ShadowV_NUD.Name = "ShadowV_NUD"
        Me.ShadowV_NUD.Size = New System.Drawing.Size(81, 23)
        Me.ShadowV_NUD.TabIndex = 4
        '
        'BackColor_LabelRGB
        '
        Me.BackColor_LabelRGB.BackColor = System.Drawing.Color.White
        Me.BackColor_LabelRGB.Location = New System.Drawing.Point(139, 80)
        Me.BackColor_LabelRGB.Margin = New System.Windows.Forms.Padding(3)
        Me.BackColor_LabelRGB.Name = "BackColor_LabelRGB"
        Me.BackColor_LabelRGB.Size = New System.Drawing.Size(81, 23)
        Me.BackColor_LabelRGB.TabIndex = 0
        Me.BackColor_LabelRGB.Text = "000,000,000"
        Me.BackColor_LabelRGB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShadowOpacity_NUD
        '
        Me.ShadowOpacity_NUD.Location = New System.Drawing.Point(139, 51)
        Me.ShadowOpacity_NUD.Name = "ShadowOpacity_NUD"
        Me.ShadowOpacity_NUD.Size = New System.Drawing.Size(81, 23)
        Me.ShadowOpacity_NUD.TabIndex = 2
        '
        'ShadowOpacity_Label
        '
        Me.ShadowOpacity_Label.AutoSize = True
        Me.ShadowOpacity_Label.Location = New System.Drawing.Point(13, 54)
        Me.ShadowOpacity_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.ShadowOpacity_Label.Name = "ShadowOpacity_Label"
        Me.ShadowOpacity_Label.Size = New System.Drawing.Size(120, 17)
        Me.ShadowOpacity_Label.TabIndex = 0
        Me.ShadowOpacity_Label.Text = "Shadow Opacity:"
        Me.ShadowOpacity_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShadowRadius_Label
        '
        Me.ShadowRadius_Label.AutoSize = True
        Me.ShadowRadius_Label.Location = New System.Drawing.Point(13, 228)
        Me.ShadowRadius_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.ShadowRadius_Label.Name = "ShadowRadius_Label"
        Me.ShadowRadius_Label.Size = New System.Drawing.Size(111, 17)
        Me.ShadowRadius_Label.TabIndex = 0
        Me.ShadowRadius_Label.Text = "Shadow Radius:"
        Me.ShadowRadius_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackColor_Button
        '
        Me.BackColor_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackColor_Button.ForeColor = System.Drawing.Color.DimGray
        Me.BackColor_Button.Location = New System.Drawing.Point(226, 80)
        Me.BackColor_Button.Name = "BackColor_Button"
        Me.BackColor_Button.Size = New System.Drawing.Size(23, 23)
        Me.BackColor_Button.TabIndex = 3
        Me.BackColor_Button.Text = "@"
        Me.BackColor_Button.UseVisualStyleBackColor = True
        '
        'BackColor_Label
        '
        Me.BackColor_Label.AutoSize = True
        Me.BackColor_Label.Location = New System.Drawing.Point(13, 83)
        Me.BackColor_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.BackColor_Label.Name = "BackColor_Label"
        Me.BackColor_Label.Size = New System.Drawing.Size(83, 17)
        Me.BackColor_Label.TabIndex = 0
        Me.BackColor_Label.Text = "Back Color:"
        Me.BackColor_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShadowColor_Button
        '
        Me.ShadowColor_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShadowColor_Button.ForeColor = System.Drawing.Color.DimGray
        Me.ShadowColor_Button.Location = New System.Drawing.Point(226, 22)
        Me.ShadowColor_Button.Name = "ShadowColor_Button"
        Me.ShadowColor_Button.Size = New System.Drawing.Size(23, 23)
        Me.ShadowColor_Button.TabIndex = 1
        Me.ShadowColor_Button.Text = "@"
        Me.ShadowColor_Button.UseVisualStyleBackColor = True
        '
        'ShadowColor_LabelRGB
        '
        Me.ShadowColor_LabelRGB.BackColor = System.Drawing.Color.White
        Me.ShadowColor_LabelRGB.Location = New System.Drawing.Point(139, 22)
        Me.ShadowColor_LabelRGB.Margin = New System.Windows.Forms.Padding(3)
        Me.ShadowColor_LabelRGB.Name = "ShadowColor_LabelRGB"
        Me.ShadowColor_LabelRGB.Size = New System.Drawing.Size(81, 23)
        Me.ShadowColor_LabelRGB.TabIndex = 0
        Me.ShadowColor_LabelRGB.Text = "000,000,000"
        Me.ShadowColor_LabelRGB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShadowColor_Label
        '
        Me.ShadowColor_Label.AutoSize = True
        Me.ShadowColor_Label.Location = New System.Drawing.Point(13, 25)
        Me.ShadowColor_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.ShadowColor_Label.Name = "ShadowColor_Label"
        Me.ShadowColor_Label.Size = New System.Drawing.Size(105, 17)
        Me.ShadowColor_Label.TabIndex = 0
        Me.ShadowColor_Label.Text = "Shadow Color:"
        Me.ShadowColor_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Spread_Label
        '
        Me.Spread_Label.AutoSize = True
        Me.Spread_Label.Location = New System.Drawing.Point(13, 198)
        Me.Spread_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.Spread_Label.Name = "Spread_Label"
        Me.Spread_Label.Size = New System.Drawing.Size(57, 17)
        Me.Spread_Label.TabIndex = 0
        Me.Spread_Label.Text = "Spread:"
        Me.Spread_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Blur_Label
        '
        Me.Blur_Label.AutoSize = True
        Me.Blur_Label.Location = New System.Drawing.Point(13, 169)
        Me.Blur_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.Blur_Label.Name = "Blur_Label"
        Me.Blur_Label.Size = New System.Drawing.Size(34, 17)
        Me.Blur_Label.TabIndex = 0
        Me.Blur_Label.Text = "Blur:"
        Me.Blur_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShadowH_Label
        '
        Me.ShadowH_Label.AutoSize = True
        Me.ShadowH_Label.Location = New System.Drawing.Point(13, 141)
        Me.ShadowH_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.ShadowH_Label.Name = "ShadowH_Label"
        Me.ShadowH_Label.Size = New System.Drawing.Size(74, 17)
        Me.ShadowH_Label.TabIndex = 0
        Me.ShadowH_Label.Text = "ShadowH:"
        Me.ShadowH_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShadowV_Label
        '
        Me.ShadowV_Label.AutoSize = True
        Me.ShadowV_Label.Location = New System.Drawing.Point(13, 112)
        Me.ShadowV_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.ShadowV_Label.Name = "ShadowV_Label"
        Me.ShadowV_Label.Size = New System.Drawing.Size(74, 17)
        Me.ShadowV_Label.TabIndex = 0
        Me.ShadowV_Label.Text = "ShadowV:"
        Me.ShadowV_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenForm_Button
        '
        Me.OpenForm_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenForm_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OpenForm_Button.Location = New System.Drawing.Point(6, 51)
        Me.OpenForm_Button.Name = "OpenForm_Button"
        Me.OpenForm_Button.Size = New System.Drawing.Size(99, 52)
        Me.OpenForm_Button.TabIndex = 2
        Me.OpenForm_Button.Text = "Open a new form"
        Me.OpenForm_Button.UseVisualStyleBackColor = True
        '
        'FormRadius_NUD
        '
        Me.FormRadius_NUD.Location = New System.Drawing.Point(139, 254)
        Me.FormRadius_NUD.Name = "FormRadius_NUD"
        Me.FormRadius_NUD.Size = New System.Drawing.Size(81, 23)
        Me.FormRadius_NUD.TabIndex = 9
        '
        'FormRadius_Label
        '
        Me.FormRadius_Label.AutoSize = True
        Me.FormRadius_Label.Location = New System.Drawing.Point(13, 257)
        Me.FormRadius_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.FormRadius_Label.Name = "FormRadius_Label"
        Me.FormRadius_Label.Size = New System.Drawing.Size(90, 17)
        Me.FormRadius_Label.TabIndex = 0
        Me.FormRadius_Label.Text = "Form Radius:"
        Me.FormRadius_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Properties_GroupBox
        '
        Me.Properties_GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowColor_Label)
        Me.Properties_GroupBox.Controls.Add(Me.FormRadius_NUD)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowV_Label)
        Me.Properties_GroupBox.Controls.Add(Me.FormRadius_Label)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowH_Label)
        Me.Properties_GroupBox.Controls.Add(Me.Blur_Label)
        Me.Properties_GroupBox.Controls.Add(Me.Spread_Label)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowColor_LabelRGB)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowRadius_NUD)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowColor_Button)
        Me.Properties_GroupBox.Controls.Add(Me.Spread_NUD)
        Me.Properties_GroupBox.Controls.Add(Me.BackColor_Label)
        Me.Properties_GroupBox.Controls.Add(Me.Blur_NUD)
        Me.Properties_GroupBox.Controls.Add(Me.BackColor_Button)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowH_NUD)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowRadius_Label)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowV_NUD)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowOpacity_Label)
        Me.Properties_GroupBox.Controls.Add(Me.ShadowOpacity_NUD)
        Me.Properties_GroupBox.Controls.Add(Me.BackColor_LabelRGB)
        Me.Properties_GroupBox.Location = New System.Drawing.Point(12, 78)
        Me.Properties_GroupBox.Name = "Properties_GroupBox"
        Me.Properties_GroupBox.Size = New System.Drawing.Size(271, 289)
        Me.Properties_GroupBox.TabIndex = 1
        Me.Properties_GroupBox.TabStop = False
        Me.Properties_GroupBox.Text = "Properties"
        '
        'Actions_GroupBox
        '
        Me.Actions_GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Actions_GroupBox.Controls.Add(Me.Reset_Button)
        Me.Actions_GroupBox.Controls.Add(Me.OpenDialog_Button)
        Me.Actions_GroupBox.Controls.Add(Me.OpenForm_Button)
        Me.Actions_GroupBox.Location = New System.Drawing.Point(296, 78)
        Me.Actions_GroupBox.Name = "Actions_GroupBox"
        Me.Actions_GroupBox.Size = New System.Drawing.Size(111, 289)
        Me.Actions_GroupBox.TabIndex = 2
        Me.Actions_GroupBox.TabStop = False
        Me.Actions_GroupBox.Text = "Actions"
        '
        'Reset_Button
        '
        Me.Reset_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Reset_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Reset_Button.Location = New System.Drawing.Point(6, 22)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(99, 23)
        Me.Reset_Button.TabIndex = 1
        Me.Reset_Button.Text = "Reset"
        Me.Reset_Button.UseVisualStyleBackColor = True
        '
        'Minimize_Button
        '
        Me.Minimize_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize_Button.Image = Global.DropShadowDemo.My.Resources.Resources.minimize_window
        Me.Minimize_Button.Location = New System.Drawing.Point(309, 22)
        Me.Minimize_Button.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.Minimize_Button.Name = "Minimize_Button"
        Me.Minimize_Button.Size = New System.Drawing.Size(24, 24)
        Me.Minimize_Button.TabIndex = 0
        Me.Minimize_Button.TabStop = False
        Me.Minimize_Button.UseVisualStyleBackColor = True
        '
        'Maximize_Button
        '
        Me.Maximize_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximize_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Maximize_Button.Image = Global.DropShadowDemo.My.Resources.Resources.maximize_window
        Me.Maximize_Button.Location = New System.Drawing.Point(336, 22)
        Me.Maximize_Button.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.Maximize_Button.Name = "Maximize_Button"
        Me.Maximize_Button.Size = New System.Drawing.Size(24, 24)
        Me.Maximize_Button.TabIndex = 0
        Me.Maximize_Button.TabStop = False
        Me.Maximize_Button.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Button.Image = Global.DropShadowDemo.My.Resources.Resources.close_window
        Me.Close_Button.Location = New System.Drawing.Point(363, 22)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(24, 24)
        Me.Close_Button.TabIndex = 0
        Me.Close_Button.TabStop = False
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'DragForm_Label
        '
        Me.DragForm_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DragForm_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DragForm_Label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DragForm_Label.Image = Global.DropShadowDemo.My.Resources.Resources.hand
        Me.DragForm_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DragForm_Label.Location = New System.Drawing.Point(6, 22)
        Me.DragForm_Label.Name = "DragForm_Label"
        Me.DragForm_Label.Size = New System.Drawing.Size(297, 24)
        Me.DragForm_Label.TabIndex = 0
        Me.DragForm_Label.Text = "Drag Form"
        Me.DragForm_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Handlers_GroupBox
        '
        Me.Handlers_GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Handlers_GroupBox.Controls.Add(Me.DragForm_Label)
        Me.Handlers_GroupBox.Controls.Add(Me.Close_Button)
        Me.Handlers_GroupBox.Controls.Add(Me.Maximize_Button)
        Me.Handlers_GroupBox.Controls.Add(Me.Minimize_Button)
        Me.Handlers_GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.Handlers_GroupBox.Name = "Handlers_GroupBox"
        Me.Handlers_GroupBox.Size = New System.Drawing.Size(395, 60)
        Me.Handlers_GroupBox.TabIndex = 0
        Me.Handlers_GroupBox.TabStop = False
        Me.Handlers_GroupBox.Text = "Handlers"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.DropShadowDemo.My.Resources.Resources.simonetos
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.FormResize_Label)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 372)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(78, 63)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(199, 17)
        Me.LinkLabel2.TabIndex = 0
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "VB.NET WinForm DropShadow"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(3, 22)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(142, 45)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(135, 18)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "By Simonetos The Greek"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.UseCompatibleTextRendering = True
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'DemoForm1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(423, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Handlers_GroupBox)
        Me.Controls.Add(Me.Actions_GroupBox)
        Me.Controls.Add(Me.Properties_GroupBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(423, 472)
        Me.Name = "DemoForm1"
        Me.Text = "Form1"
        CType(Me.ShadowRadius_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spread_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blur_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowH_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowV_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowOpacity_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormRadius_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Properties_GroupBox.ResumeLayout(False)
        Me.Properties_GroupBox.PerformLayout()
        Me.Actions_GroupBox.ResumeLayout(False)
        Me.Handlers_GroupBox.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenDialog_Button As Button
    Private WithEvents FormResize_Label As Label
    Friend WithEvents ShadowRadius_NUD As NumericUpDown
    Friend WithEvents Spread_NUD As NumericUpDown
    Friend WithEvents Blur_NUD As NumericUpDown
    Friend WithEvents ShadowH_NUD As NumericUpDown
    Friend WithEvents ShadowV_NUD As NumericUpDown
    Private WithEvents BackColor_LabelRGB As Label
    Friend WithEvents ShadowOpacity_NUD As NumericUpDown
    Private WithEvents ShadowOpacity_Label As Label
    Private WithEvents ShadowRadius_Label As Label
    Private WithEvents BackColor_Button As Button
    Private WithEvents BackColor_Label As Label
    Private WithEvents ShadowColor_Button As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ShadowColor_LabelRGB As Label
    Private WithEvents ShadowColor_Label As Label
    Private WithEvents Spread_Label As Label
    Private WithEvents Blur_Label As Label
    Private WithEvents ShadowH_Label As Label
    Private WithEvents ShadowV_Label As Label
    Friend WithEvents OpenForm_Button As Button
    Friend WithEvents FormRadius_NUD As NumericUpDown
    Private WithEvents FormRadius_Label As Label
    Friend WithEvents Properties_GroupBox As GroupBox
    Friend WithEvents Actions_GroupBox As GroupBox
    Friend WithEvents Reset_Button As Button
    Friend WithEvents Minimize_Button As Button
    Friend WithEvents Maximize_Button As Button
    Friend WithEvents Close_Button As Button
    Friend WithEvents DragForm_Label As Label
    Friend WithEvents Handlers_GroupBox As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
