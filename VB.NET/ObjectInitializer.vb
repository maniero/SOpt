Private myImageList As System.Windows.Forms.ImageList = New ImageList()
Private myImageListSmall As System.Windows.Forms.ImageList = New ImageList()
Private myImageListLarge As System.Windows.Forms.ImageList = New ImageList()
Private count As Integer = 0
Private ofd As New OpenFileDialog() With { _
    .Multiselect = True, _
    .ValidateNames = True, _
    .Filter = "JPG|*jpg|JPEG|*.jpeg|PNG|*.png" _
}
Private fi As FileInfo

'https://pt.stackoverflow.com/q/354645/101
