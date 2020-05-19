foreach (var control in panel1.Controls) {
    if (control is PictureEdit picture) {
        picture.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
        picture.Properties.AllowScrollViaMouseDrag = false;
        picture.Properties.AllowZoomOnMouseWheel = DefaultBoolean.False;
        picture.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.ControlMouseWheel;
        picture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
        picture.Properties.ZoomPercent = 15;
        picture.MouseWheel += new MouseEventHandler(this.pictureEdit1_MouseWheel);
        picture.ImageChanged += new EventHandler(this.Pic_Change_Edit);
    }
}

//https://pt.stackoverflow.com/q/206278/101
