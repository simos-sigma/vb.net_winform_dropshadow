Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D

''' <summary>
''' Dropshadow.
''' Add a shadow to a WinForm.
''' </summary>
Public Class DropShadow
    Inherits Form

    '((( VARIABLES )))
    Private _shadowBitmap As Bitmap
    Private _shadowColor As Color
    Private _shadowH As Integer
    Private _shadowOpacity As Byte = 255
    Private _shadowV As Integer

    '((( PROPERTIES )))
    Public Property ShadowColor() As Color
        Get
            Return _shadowColor
        End Get
        Set
            _shadowColor = Value
            _shadowOpacity = _shadowColor.A
        End Set
    End Property
    Public Property ShadowBitmap() As Bitmap
        Get
            Return _shadowBitmap
        End Get
        Set
            _shadowBitmap = Value
            SetBitmap(_shadowBitmap, ShadowOpacity)
        End Set
    End Property
    Public Property ShadowOpacity() As Byte
        Get
            Return _shadowOpacity
        End Get
        Set
            _shadowOpacity = Value
            SetBitmap(ShadowBitmap, _shadowOpacity)
        End Set
    End Property
    Public Property ShadowH() As Integer
        Get
            Return _shadowH
        End Get
        Set
            _shadowH = Value
            RefreshShadow(False)
        End Set
    End Property
    ''' <summary>
    ''' Offset X relate to Owner.
    ''' </summary>
    Public ReadOnly Property OffsetX() As Integer
        Get
            Return ShadowH - (ShadowBlur + ShadowSpread)
        End Get
    End Property
    ''' <summary>
    ''' Offset Y relate to Owner.
    ''' </summary>
    Public ReadOnly Property OffsetY() As Integer
        Get
            Return ShadowV - (ShadowBlur + ShadowSpread)
        End Get
    End Property
    Public Shadows ReadOnly Property Width() As Integer
        Get
            Return Owner.Width + (ShadowSpread + ShadowBlur) * 2
        End Get
    End Property
    Public Shadows ReadOnly Property Height() As Integer
        Get
            Return Owner.Height + (ShadowSpread + ShadowBlur) * 2
        End Get
    End Property
    Public Property ShadowV() As Integer
        Get
            Return _shadowV
        End Get
        Set
            _shadowV = Value
            RefreshShadow(False)
        End Set
    End Property
    Public Property ShadowBlur() As Integer
    Public Property ShadowSpread() As Integer
    Public Property ShadowRadius() As Integer
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            '((( This form has to have the WS_EX_LAYERED extended style. )))
            cp.ExStyle = cp.ExStyle Or &H80000
            Return cp
        End Get
    End Property

    '((( EVENTS )))
    Public Sub New(ByVal f As Form)
        Owner = f
        ShadowColor = Color.Black
        '((( Default style. )))
        FormBorderStyle = FormBorderStyle.None
        ShowInTaskbar = False
        '((( Bind event. )))
        AddHandler Owner.LocationChanged, Sub(sender, eventArgs) UpdateLocation()
        AddHandler Owner.FormClosing, Sub(sender, eventArgs) Close()
        AddHandler Owner.VisibleChanged, Sub(sender, eventArgs)
                                             If Owner IsNot Nothing Then
                                                 Visible = Owner.Visible
                                             End If
                                         End Sub
        AddHandler Owner.Activated, Sub(sender, args) Owner.BringToFront()
    End Sub
    Public Sub UpdateLocation(Optional sender As [Object] = Nothing, Optional eventArgs As EventArgs = Nothing)
        Dim pos As Point = Owner.Location
        pos.Offset(OffsetX, OffsetY)
        Location = pos
    End Sub
    ''' <summary>
    ''' Refresh shadow.
    ''' </summary>
    ''' <param name="redraw"> (optional) redraw the background bitmap. </param>
    Public Sub RefreshShadow(Optional redraw As Boolean = True)
        If redraw Then
            'ShadowBitmap = DrawShadow()
            ShadowBitmap = DrawShadowBitmap(Owner.Width, Owner.Height, 0, ShadowBlur, ShadowSpread, ShadowColor)
        End If
        'SetBitmap(ShadowBitmap, ShadowOpacity)
        UpdateLocation()
        '((( Set the display area. )))
        Dim r As Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Width, Height, ShadowRadius, ShadowRadius))
        'Dim r As New Region(New Rectangle(0, 0, Width, Height))
        Dim [or] As Region
        If Owner.Region Is Nothing Then
            [or] = New Region(Owner.ClientRectangle)
        Else
            [or] = Owner.Region.Clone()
        End If
        [or].Translate(-OffsetX, -OffsetY)
        r.Exclude([or])
        Region = r
        Owner.Refresh()
    End Sub
    ''' <para>Changes the current bitmap with a custom opacity level. Here is where all happens!</para>
    Public Sub SetBitmap(bitmap As Bitmap, Optional opacity As Byte = 255)
        If bitmap.PixelFormat <> PixelFormat.Format32bppArgb Then
            Throw New ApplicationException("The bitmap must be 32ppp with alpha-channel.")
        End If
        '((( The idea of this is very simple. )))
        '((( 1. Create a compatible DC with screen. )))
        '((( 2. Select the bitmap with 32bpp with alpha-channel in the compatible DC. )))
        '((( 3. Call the UpdateLayeredWindow. )))
        Dim screenDc As IntPtr = Win32.GetDC(IntPtr.Zero)
        Dim memDc As IntPtr = Win32.CreateCompatibleDC(screenDc)
        Dim hBitmap As IntPtr = IntPtr.Zero
        Dim oldBitmap As IntPtr = IntPtr.Zero
        Try
            hBitmap = bitmap.GetHbitmap(Color.FromArgb(0))
            '((( Grab a GDI handle from this GDI+ bitmap. )))
            oldBitmap = Win32.SelectObject(memDc, hBitmap)
            Dim size As New Win32.Size(bitmap.Width, bitmap.Height)
            Dim pointSource As New Win32.Point(0, 0)
            Dim topPos As New Win32.Point(Left, Top)
            Dim blend As New Win32.BLENDFUNCTION()
            blend.BlendOp = Win32.AC_SRC_OVER
            blend.BlendFlags = 0
            blend.SourceConstantAlpha = opacity
            blend.AlphaFormat = Win32.AC_SRC_ALPHA
            Win32.UpdateLayeredWindow(Handle, screenDc, topPos, size, memDc, pointSource, 0, blend, Win32.ULW_ALPHA)
        Finally
            Win32.ReleaseDC(IntPtr.Zero, screenDc)
            If hBitmap <> IntPtr.Zero Then
                Win32.SelectObject(memDc, oldBitmap)
                '((( The documentation says that we have to use the Windows.DeleteObject. But since there is no such method, I use the normal DeleteObject from Win32 GDI and it's working fine without any resource leak. )))
                'Windows.DeleteObject(hBitmap)
                Win32.DeleteObject(hBitmap)
            End If
            Win32.DeleteDC(memDc)
        End Try
    End Sub

    '((( FUNCTIONS )))
    Public Shared Function DrawShadowBitmap(width As Integer, height As Integer, borderRadius As Integer, blur As Integer, spread As Integer, color As Color) As Bitmap
        Dim ex As Integer = blur + spread
        Dim w As Integer = width + ex * 2
        Dim h As Integer = height + ex * 2
        Dim solidW As Integer = width + spread * 2
        Dim solidH As Integer = height + spread * 2
        Dim bitmap As New Bitmap(w, h)
        Dim g As Graphics = Graphics.FromImage(bitmap)
        '((( Fill background. )))
        g.FillRectangle(New SolidBrush(color), blur, blur, width + spread * 2 + 1, height + spread * 2 + 1) ' +1 to fill the gap
        If blur > 0 Then
            '((( Four dir gradiant. )))
            If True Then
                '((( Left. )))
                Dim brush As New LinearGradientBrush(New Point(0, 0), New Point(blur, 0), Color.Transparent, color)
                '((( Will thorw ArgumentException. )))
                ' brush.WrapMode = WrapMode.Clamp
                g.FillRectangle(brush, 0, blur, blur, solidH)
                '((( Up. )))
                brush.RotateTransform(90)
                g.FillRectangle(brush, blur, 0, solidW, blur)
                '((( Right. )))
                '((( Make sure parttern is currect. )))
                brush.ResetTransform()
                brush.TranslateTransform(w Mod blur, h Mod blur)
                brush.RotateTransform(180)
                g.FillRectangle(brush, w - blur, blur, blur, solidH)
                '((( Down. )))
                brush.RotateTransform(90)
                g.FillRectangle(brush, blur, h - blur, solidW, blur)
            End If
            '((( Four corners. )))
            If True Then
                Dim gp As New GraphicsPath()
                gp.AddEllipse(0, 0, blur * 2, blur * 2)
                'gp.AddPie(0,0,blur*2,blur*2, 180, 90)
                Dim pgb = New PathGradientBrush(gp)
                pgb.CenterColor = color
                pgb.SurroundColors = {System.Drawing.Color.Transparent}
                pgb.CenterPoint = New Point(blur, blur)
                '((( Left top corner. )))
                g.FillPie(pgb, 0, 0, blur * 2, blur * 2, 180, 90)
                '((( Right top corner. )))
                Dim matrix As New Matrix()
                matrix.Translate(w - blur * 2, 0)
                pgb.Transform = matrix
                'pgb.Transform.Translate(w-blur*2, 0)
                g.FillPie(pgb, w - blur * 2, 0, blur * 2, blur * 2, 270, 90)
                '((( Right bottom corner. )))
                matrix.Translate(0, h - blur * 2)
                pgb.Transform = matrix
                g.FillPie(pgb, w - blur * 2, h - blur * 2, blur * 2, blur * 2, 0, 90)
                '((( Left bottom corner. )))
                matrix.Reset()
                matrix.Translate(0, h - blur * 2)
                pgb.Transform = matrix
                g.FillPie(pgb, 0, h - blur * 2, blur * 2, blur * 2, 90, 90)
            End If
        End If
        Return bitmap
    End Function
End Class



Friend Class Win32 '((( Class that exposes needed win32 gdi functions. )))

    Public Enum Bool
        [False] = 0
        [True]
    End Enum

    Public Const ULW_COLORKEY As Int32 = &H1
    Public Const ULW_ALPHA As Int32 = &H2
    Public Const ULW_OPAQUE As Int32 = &H4
    Public Const AC_SRC_OVER As Byte = &H0
    Public Const AC_SRC_ALPHA As Byte = &H1

    '((( x-coordinate of upper-left corner.  )))
    '((( y-coordinate of upper-left corner.  )))
    '((( x-coordinate of lower-right corner. )))
    '((( y-coordinate of lower-right corner. )))
    '((( Height of ellipse. )))
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Public Shared Function CreateRoundRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
        '((( Width of ellipse. )))
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As Integer
    End Function
    ''' <summary>
    ''' Changes an attribute of the specified window. The function also sets the 32-bit (long) value at the specified
    ''' offset into the extra window memory.
    ''' </summary>
    ''' <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs..</param>
    ''' <param name="nIndex">
    ''' The zero-based offset to the value to be set. Valid values are in the range zero through the
    ''' number of bytes of extra window memory, minus the size of an integer. To set any other value, specify one of the
    ''' following values: GWL_EXSTYLE, GWL_HINSTANCE, GWL_ID, GWL_STYLE, GWL_USERDATA, GWL_WNDPROC
    ''' </param>
    ''' <param name="dwNewLong">The replacement value.</param>
    ''' <returns>
    ''' If the function succeeds, the return value is the previous value of the specified 32-bit integer.
    ''' If the function fails, the return value is zero. To get extended error information, call GetLastError.
    ''' </returns>
    <DllImport("user32.dll")>
    Public Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    End Function
    <DllImport("user32.dll", ExactSpelling:=True, SetLastError:=True)>
    Public Shared Function UpdateLayeredWindow(hwnd As IntPtr, hdcDst As IntPtr, ByRef pptDst As Point, ByRef psize As Size, hdcSrc As IntPtr, ByRef pprSrc As Point,
            crKey As Int32, ByRef pblend As BLENDFUNCTION, dwFlags As Int32) As Bool
    End Function
    <DllImport("user32.dll", ExactSpelling:=True, SetLastError:=True)>
    Public Shared Function GetDC(hWnd As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", ExactSpelling:=True)>
    Public Shared Function ReleaseDC(hWnd As IntPtr, hDC As IntPtr) As Integer
    End Function
    <DllImport("gdi32.dll", ExactSpelling:=True, SetLastError:=True)>
    Public Shared Function CreateCompatibleDC(hDC As IntPtr) As IntPtr
    End Function
    <DllImport("gdi32.dll", ExactSpelling:=True, SetLastError:=True)>
    Public Shared Function DeleteDC(hdc As IntPtr) As Bool
    End Function
    <DllImport("gdi32.dll", ExactSpelling:=True)>
    Public Shared Function SelectObject(hDC As IntPtr, hObject As IntPtr) As IntPtr
    End Function
    <DllImport("gdi32.dll", ExactSpelling:=True, SetLastError:=True)>
    Public Shared Function DeleteObject(hObject As IntPtr) As Bool
    End Function
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Private Structure ARGB
        Public ReadOnly Blue As Byte
        Public ReadOnly Green As Byte
        Public ReadOnly Red As Byte
        Public ReadOnly Alpha As Byte
    End Structure
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure BLENDFUNCTION
        Public BlendOp As Byte
        Public BlendFlags As Byte
        Public SourceConstantAlpha As Byte
        Public AlphaFormat As Byte
    End Structure
    <StructLayout(LayoutKind.Sequential)>
    Public Structure Point
        Public x As Int32
        Public y As Int32
        Public Sub New(x As Int32, y As Int32)
            Me.x = x
            Me.y = y
        End Sub
    End Structure
    <StructLayout(LayoutKind.Sequential)>
    Public Structure Size
        Public cx As Int32
        Public cy As Int32
        Public Sub New(cx As Int32, cy As Int32)
            Me.cx = cx
            Me.cy = cy
        End Sub
    End Structure
End Class
