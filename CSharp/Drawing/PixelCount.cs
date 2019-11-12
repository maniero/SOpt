var count = 0;
var searchColor = Color.FromName("SlateBlue");
for (var x = 0; x < pictureBox1.Image.Width; x++) {
    for (var y = 0; y < pictureBox1.Image.Height; y++) {
        Color pixelColor = pictureBox1.Image.GetPixel(x, y);
        if (pixelColor == searchColor) count++;
    }
}

//https://pt.stackoverflow.com/q/105693/101
