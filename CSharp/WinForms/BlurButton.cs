using System.Drawing.Imaging;
public class Form1 {

    private void Button1_Click(object sender, System.EventArgs e) {
        ShowBlurredPicture();
    }

    void ShowBlurredPicture() {
        Bitmap blurredpic = gausianBlur(false, new Size(5, 5), GetFormPic);
        PictureBox p = new PictureBox();
        p.Image = blurredpic;
        p.Location = new Point((System.Windows.Forms.SystemInformation.FrameBorderSize.Width * -1), ((System.Windows.Forms.SystemInformation.CaptionHeight + System.Windows.Forms.SystemInformation.FrameBorderSize.Height) 
                        * -1));
        p.Size = new Size(this.Size);
        this.Controls.Add(p);
        p.Visible = true;
        p.BringToFront();
        p.Click += new System.EventHandler(this.picclick);
    }

    void picclick(object sender, System.EventArgs e) {
        this.Controls.Remove(sender);
    }

    Bitmap GetFormPic() {
        Size ScreenSize = this.Size;
        Bitmap screenGrab = new Bitmap(this.Width, this.Height);
        System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(screenGrab);
        g.CopyFromScreen(this.Location, new Point(0, 0), this.Size);
        return screenGrab;
    }

    private Color Average(Size Size, SizeF imageSize, int PixelX, int Pixely, Bitmap theimage) {
        ArrayList pixels = new ArrayList();
        int x;
        int y;
        Bitmap bmp = theimage.Clone;
        for (x = (PixelX - int.Parse((Size.Width / 2))); (x 
                    <= (PixelX + int.Parse((Size.Width / 2)))); x++) {
            for (y = (Pixely - int.Parse((Size.Height / 2))); (y 
                        <= (Pixely + int.Parse((Size.Height / 2)))); y++) {
                if ((((x > 0) 
                            && (x < imageSize.Width)) 
                            && ((y > 0) 
                            && (y < imageSize.Height)))) {
                    pixels.Add(bmp.GetPixel(x, y));
                }
            }
        }
        Color thisColor;
        int alpha = 0;
        int red = 0;
        int green = 0;
        int blue = 0;
        foreach (thisColor in pixels) {
            alpha = (alpha + thisColor.A);
            red = (red + thisColor.R);
            green = (green + thisColor.G);
            blue = (blue + thisColor.B);
        }
        return Color.FromArgb((alpha / pixels.Count), (red / pixels.Count), (green / pixels.Count), (blue / pixels.Count));
    }

    private Bitmap gausianBlur(bool alphaEdgesOnly, Size blurSize, Bitmap theimage) {
        int PixelY;
        int PixelX;
        Bitmap bmp = theimage.Clone;
        for (PixelY = 0; (PixelY 
                    <= (bmp.Width - 1)); PixelY++) {
            for (PixelX = 0; (PixelX 
                        <= (bmp.Height - 1)); PixelX++) {
                if (!alphaEdgesOnly) {
                    //  Blur everything
                    bmp.SetPixel(PixelX, PixelY, Average(blurSize, bmp.PhysicalDimension, PixelX, PixelY, theimage));
                }
                else if ((bmp.GetPixel(PixelX, PixelY).A != 255)) {
                    //  Alpha blur channel check
                    bmp.SetPixel(PixelX, PixelY, Average(blurSize, bmp.PhysicalDimension, PixelX, PixelY, theimage));
                }
                Application.DoEvents();
            }
        }
        return bmp.Clone;
        bmp.Dispose();
    }
}

//https://pt.stackoverflow.com/q/45939/101
