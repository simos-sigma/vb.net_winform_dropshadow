Public Class DemoForm1

    '((( VARIABLES )))
    Public _Shadow As DropShadow
    Private NewPoint As New Point
    Private New_X, New_Y As Integer

    '((( EVENTS )))
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.DoubleBuffered = True
    End Sub
    Private Sub DemoForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not DesignMode Then
            _Shadow = New DropShadow(Me) With {
                .ShadowH = 0, '(((  )))
                .ShadowV = 0,
                .ShadowBlur = 5,
                .ShadowSpread = 5,
                .Opacity = 128,
                .ShadowColor = Color.FromArgb(CInt(.Opacity), 0, 0, 0),
                .ShadowRadius = 0
            }
            _Shadow.RefreshShadow()
        End If

        BackColor = Color.FromArgb(255, 240, 240, 240)

        ShadowColor_LabelRGB.Text = _Shadow.ShadowColor.R.ToString & "," & _Shadow.ShadowColor.G.ToString & "," & _Shadow.ShadowColor.B.ToString

        With ShadowOpacity_NUD
            .Minimum = 0
            .Maximum = 255
            .Increment = 1
            .Value = 128
        End With

        BackColor_LabelRGB.Text = BackColor.R.ToString & "," & BackColor.G.ToString & "," & BackColor.B.ToString

        With ShadowV_NUD
            .Minimum = Integer.MinValue
            .Maximum = Integer.MaxValue
            .Increment = 1
            .Value = _Shadow.ShadowV
        End With

        With ShadowH_NUD
            .Minimum = Integer.MinValue
            .Maximum = Integer.MaxValue
            .Increment = 1
            .Value = _Shadow.ShadowH
        End With

        With Blur_NUD
            .Minimum = 0
            .Maximum = Integer.MaxValue
            .Increment = 1
            .Value = _Shadow.ShadowBlur
        End With

        With Spread_NUD
            .Minimum = 0
            .Maximum = Integer.MaxValue
            .Increment = 1
            .Value = _Shadow.ShadowSpread
        End With

        With ShadowRadius_NUD
            .Minimum = 0
            .Maximum = Integer.MaxValue
            .Increment = 1
            .Value = _Shadow.ShadowRadius
        End With

        With FormRadius_NUD
            .Minimum = 0
            .Maximum = Integer.MaxValue
            .Increment = 1
            .Value = 0
        End With
    End Sub
    Private Sub DemoForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.WindowState = FormWindowState.Maximized Then
            FormResize_Label.Enabled = False
        Else
            FormResize_Label.Enabled = True
        End If
    End Sub
    Private Sub DragForm_Label_MouseUp(sender As Object, e As MouseEventArgs) Handles DragForm_Label.MouseUp
        Me.Cursor = Cursors.Default
        DragForm_Label.BackColor = Color.White
    End Sub
    Private Sub DragForm_Label_MouseDown(sender As Object, e As MouseEventArgs) Handles DragForm_Label.MouseDown
        If Not Me.WindowState = FormWindowState.Maximized Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                New_X = Control.MousePosition.X - Me.Location.X
                New_Y = Control.MousePosition.Y - Me.Location.Y
                Me.Cursor = Cursors.NoMove2D
            End If
            DragForm_Label.BackColor = Color.Orange
        End If
    End Sub
    Private Sub DragForm_Label_MouseMove(sender As Object, e As MouseEventArgs) Handles DragForm_Label.MouseMove
        If Not Me.WindowState = FormWindowState.Maximized Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                NewPoint = Control.MousePosition
                NewPoint.X -= (New_X)
                NewPoint.Y -= (New_Y)
                Me.Location = NewPoint
            End If
        End If
    End Sub
    Private Sub DragForm_Label_DoubleClick(sender As Object, e As EventArgs) Handles DragForm_Label.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
            Me.WindowState = FormWindowState.Maximized
            _Shadow.Hide()
            Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, 0, 0))
        Else
            Me.WindowState = FormWindowState.Normal
            _Shadow.Show()
            Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, CInt(FormRadius_NUD.Value), CInt(FormRadius_NUD.Value)))
        End If
        MyBase.Refresh()
        _Shadow.RefreshShadow()
    End Sub
    Private Sub Minimize_Button_Click(sender As Object, e As EventArgs) Handles Minimize_Button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Maximize_Button_Click(sender As Object, e As EventArgs) Handles Maximize_Button.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Maximize_Button.Image = My.Resources.restore_window
            _Shadow.Hide()
            Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, 0, 0))
        Else
            Me.WindowState = FormWindowState.Normal
            Maximize_Button.Image = My.Resources.maximize_window
            _Shadow.Show()
            Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, CInt(FormRadius_NUD.Value), CInt(FormRadius_NUD.Value)))
            _Shadow.RefreshShadow()
        End If
    End Sub
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub
    Private Sub ShadowColor_Button_Click(sender As Object, e As EventArgs) Handles ShadowColor_Button.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            _Shadow.ShadowColor = Color.FromArgb(CInt(ShadowOpacity_NUD.Value), ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
            ShadowColor_LabelRGB.Text = _Shadow.ShadowColor.R.ToString & "," & _Shadow.ShadowColor.G.ToString & "," & _Shadow.ShadowColor.B.ToString
            _Shadow.RefreshShadow()
        End If
    End Sub
    Private Sub ShadowOpacity_NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles ShadowOpacity_NUD.ValueChanged
        With _Shadow
            .ShadowColor = Color.FromArgb(CInt(ShadowOpacity_NUD.Value), .ShadowColor.R, .ShadowColor.G, .ShadowColor.B)
            .RefreshShadow()
        End With
    End Sub
    Private Sub BackColor_Button_Click(sender As Object, e As EventArgs) Handles BackColor_Button.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Me.BackColor = ColorDialog1.Color
            BackColor_LabelRGB.Text = BackColor.R.ToString & "," & BackColor.G.ToString & "," & BackColor.B.ToString
        End If
    End Sub
    Private Sub ShadowV_NUD_ValueChanged(sender As Object, e As EventArgs) Handles ShadowV_NUD.ValueChanged
        _Shadow.ShadowV = CInt(ShadowV_NUD.Value)
        _Shadow.RefreshShadow()
    End Sub
    Private Sub ShadowH_NUD_ValueChanged(sender As Object, e As EventArgs) Handles ShadowH_NUD.ValueChanged
        _Shadow.ShadowH = CInt(ShadowH_NUD.Value)
        _Shadow.RefreshShadow()
    End Sub
    Private Sub Blur_NUD_ValueChanged(sender As Object, e As EventArgs) Handles Blur_NUD.ValueChanged
        _Shadow.ShadowBlur = CInt(Blur_NUD.Value)
        _Shadow.RefreshShadow()
    End Sub
    Private Sub Spread_NUD_ValueChanged(sender As Object, e As EventArgs) Handles Spread_NUD.ValueChanged
        _Shadow.ShadowSpread = CInt(Spread_NUD.Value)
        _Shadow.RefreshShadow()
    End Sub
    Private Sub FormResize_Label_MouseDown(sender As Object, e As MouseEventArgs) Handles FormResize_Label.MouseDown
        If Me.WindowState = FormWindowState.Maximized Then
        Else
            New_X = Control.MousePosition.X - Me.Width
            New_Y = Control.MousePosition.Y - Me.Height
        End If
    End Sub
    Private Sub FormResize_Label_MouseMove(sender As Object, e As MouseEventArgs) Handles FormResize_Label.MouseMove
        If Not Me.WindowState = FormWindowState.Maximized Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                NewPoint = Control.MousePosition
                NewPoint.X -= (New_X)
                NewPoint.Y -= (New_Y)
                Me.Size = CType(NewPoint, Size)
                Me.Refresh()
                Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, CInt(FormRadius_NUD.Value), CInt(FormRadius_NUD.Value)))
                _Shadow.RefreshShadow()
            End If
        End If
    End Sub
    Private Sub FormResize_Label_MouseEnter(sender As Object, e As EventArgs) Handles FormResize_Label.MouseEnter
        FormResize_Label.Cursor = Cursors.SizeNWSE
    End Sub
    Private Sub FormResize_Label_MouseLeave(sender As Object, e As EventArgs) Handles FormResize_Label.MouseLeave
        FormResize_Label.Cursor = Cursors.Default
        _Shadow.RefreshShadow()
    End Sub
    Private Sub ShadowCorners_NUD_ValueChanged(sender As Object, e As EventArgs) Handles ShadowRadius_NUD.ValueChanged
        _Shadow.ShadowRadius = CInt(ShadowRadius_NUD.Value)
        _Shadow.RefreshShadow()
    End Sub
    Private Sub FormCorners_NUD_ValueChanged(sender As Object, e As EventArgs) Handles FormRadius_NUD.ValueChanged
        Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, CInt(FormRadius_NUD.Value), CInt(FormRadius_NUD.Value)))
        _Shadow.RefreshShadow()
    End Sub
    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        Me.Size = Me.MinimumSize
        _Shadow.ShadowColor = Color.FromArgb(128, 0, 0, 0)
        Me.ShadowColor_LabelRGB.Text = _Shadow.ShadowColor.R.ToString & "," & _Shadow.ShadowColor.G.ToString & "," & _Shadow.ShadowColor.B.ToString
        Me.ShadowOpacity_NUD.Value = 128
        Me.BackColor = Color.FromArgb(255, 240, 240, 240)
        Me.BackColor_LabelRGB.Text = BackColor.R.ToString & "," & BackColor.G.ToString & "," & BackColor.B.ToString
        _Shadow.ShadowV = 0
        Me.ShadowV_NUD.Value = 0
        _Shadow.ShadowH = 0
        Me.ShadowH_NUD.Value = 0
        _Shadow.ShadowBlur = 5
        Me.Blur_NUD.Value = 5
        _Shadow.ShadowSpread = 5
        Me.Spread_NUD.Value = 5
        _Shadow.ShadowRadius = 0
        Me.ShadowRadius_NUD.Value = 0
        Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, 0, 0))
        Me.FormRadius_NUD.Value = 0
        _Shadow.RefreshShadow()
    End Sub
    Private Sub OpenDialog_Button_Click(sender As Object, e As EventArgs) Handles OpenDialog_Button.Click
        Dim NewForm As Form = New DemoForm1
        NewForm.ShowDialog(Me)
    End Sub
    Private Sub OpenForm_Button_Click(sender As Object, e As EventArgs) Handles OpenForm_Button.Click
        Dim NewForm As Form = New DemoForm1
        NewForm.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim theStringBuilder As New System.Text.StringBuilder()
        theStringBuilder.Append("https://www.facebook.com/simonetos.gr")
        System.Diagnostics.Process.Start(theStringBuilder.ToString())
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim theStringBuilder As New System.Text.StringBuilder()
        theStringBuilder.Append("mailto:simonetos.the.greek@gmail.com")
        theStringBuilder.Append("&subject=VB.NET WINFORM DROPSHADOW")
        'theStringBuilder.Append("&body=My email body")
        System.Diagnostics.Process.Start(theStringBuilder.ToString())
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim theStringBuilder As New System.Text.StringBuilder()
        theStringBuilder.Append("https://github.com/simonetos/vb.net_winform_dropshadow")
        System.Diagnostics.Process.Start(theStringBuilder.ToString())
    End Sub
End Class
