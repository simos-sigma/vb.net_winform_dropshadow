# VB.NET WINFORM DROPSHADOW
<img src="https://i.imgur.com/RfqU4ks.png"></img> A <b>VB.NET</b> Winform DropShadow demo by <a href="mailto:someone@example.com?Subject=Hello%20again" target="_blank">Simonetos The Greek</a>.<br/><br/>
The initial idea started from a question at <b>stackoverflow.com</b> titled <a href="https://stackoverflow.com/questions/8793445/windows-7-style-dropshadow-in-borderless-form" target="_blank">"Windows 7 style Dropshadow in borderless form"</a> by <a href="https://stackoverflow.com/users/1011956/corylulu" target="_blank">Corylulu</a>. Then, <a href="https://stackoverflow.com/users/1870054/wener">Wener</a> made a workable class in <b>C#</b> which you can find it <a href="https://github.com/wenerme/winform.DropShadow">here</a>. I managed to translate this class to a workable <b>VB.NET</b> class and also add the <b>Shadow Radius</b> ability. I also made the demo a bit easier to use, with more examples and a bit more good looking...<br/>
# SAMPLES
<img src="https://i.imgur.com/xf7ydd3.png" height="45%" width="45%"></img> <img src="https://i.imgur.com/AIvfFL4.png" height="45%" width="45%"></img><br/>
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
Public Class Form1
        
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not DesignMode Then
	    _Shadow = New Dropshadow(Me) With {
                '((( DropShadow's properties... )))
            }
	    '((( Replace *** with a number of your choice. ))) 
	    Me.Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, ***, ***))
	    _Shadow.RefreshShadow()
        End If
    End Sub
	
End Class
```
