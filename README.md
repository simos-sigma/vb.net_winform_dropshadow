# VB.NET WINFORM DROPSHADOW
<a href="https://www.facebook.com/simonetos.gr" target="_blank"><img src="https://i.imgur.com/RfqU4ks.png"></img></a> A <b>VB.NET</b> Winform DropShadow demo by <a href="mailto:someone@example.com?Subject=Hello%20again" target="_blank">Simonetos The Greek</a>.<br/><br/>
The initial idea started from a question at <b>stackoverflow.com</b> titled <a href="https://stackoverflow.com/questions/8793445/windows-7-style-dropshadow-in-borderless-form" target="_blank">"Windows 7 style Dropshadow in borderless form"</a> by <a href="https://stackoverflow.com/users/1011956/corylulu" target="_blank">Corylulu</a>. Then, <a href="https://stackoverflow.com/users/1870054/wener" target="_blank">Wener</a> made a workable class in <b>C#</b> which you can find it <a href="https://github.com/wenerme/winform.DropShadow" target="_blank">here</a>. I managed to translate this class to a workable <b>VB.NET</b> class and also add the <b>Shadow Radius</b> ability. I also made the demo a bit easier to use and a bit more good looking...<br/>
# SAMPLES
<img src="https://i.imgur.com/xf7ydd3.png" height="45%" width="45%"></img> <img src="https://i.imgur.com/AIvfFL4.png" height="45%" width="45%"></img><br/>
# WHAT DROPSHADOW CLASS DO?
By including this class into your VB.NET Winforms...
1. Basically, you can give shadow to a <b>borderless</b> form.
2. You can make form's shadow <b>size</b> as big as you want.
3. You can set shadow's <b>horizontal</b> and <b>vertical</b> position using <b>negative</b> and <b>positive</b> values.
4. You can make form's shadow looks blurred.
5. You can change shadow's <b>color</b> and <b>opacity</b>.
6. And finaly, you can add shadow <b>radius</b>.
7. You can also add <b>form radius</b> (manualy!!!).
# USAGE
Here is an example of how you can use <b>DropShadow</b> class into your form's code.
```VB.NET
Public Class Form1

    '((( Declare DropShadow class. )))
    Public _Shadow As Dropshadow
    
    '((( Add the necessary initializations for your form. )))
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.DoubleBuffered = True
    End Sub
    
    '((( And here we go... )))
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not DesignMode Then
            _Shadow = New Dropshadow(Me) With {
                .ShadowH = 0,
                .ShadowV = 0,
                .ShadowBlur = 5,
                .ShadowSpread = 5,
                .Opacity = 128,
                .ShadowColor = Color.FromArgb(CInt(.Opacity), 0, 0, 0),
                .ShadowRadius = 0
            }
            _Shadow.RefreshShadow()
        End If
    End Sub
	
End Class
```
If you want to add radius to your form, you should do that manualy.
```VB.NET
'((( Replace *** with a number of your choice. )))
Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, ***, ***))
_Shadow.RefreshShadow()
```
As you will see in Demo project, you should also manually do `_Shadow.RefreshShadow()` every time that form changes state or size. For example, when form changes state from `FormWindowState.Normal` to `FormWindowState.Maximized` or when you resize the form using a resize handler.
