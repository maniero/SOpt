class BoldLabel : Label {
    protected override void OnPaint(PaintEventArgs e) {
        Point drawPoint = new Point(0, 0);
        string[] array = Text.Split(new char[] { '|' });
        if (array.Length == 2) {
            Font normalFont = this.Font;
            Font boldFont = new Font(normalFont, FontStyle.Bold);
            Size boldSize = TextRenderer.MeasureText(array[0], boldFont);
            Size normalSize = TextRenderer.MeasureText(array[1], normalFont);
            Rectangle boldRect = new Rectangle(drawPoint, boldSize);
            Rectangle normalRect = new Rectangle(boldRect.Right, boldRect.Top, normalSize.Width, normalSize.Height);
            TextRenderer.DrawText(e.Graphics, array[0], boldFont, boldRect, ForeColor);
            TextRenderer.DrawText(e.Graphics, array[1], normalFont, normalRect, ForeColor);
        } else {
            TextRenderer.DrawText(e.Graphics, Text, Font, drawPoint, ForeColor);                
        }
    }
}

//https://pt.stackoverflow.com/q/5536/101
