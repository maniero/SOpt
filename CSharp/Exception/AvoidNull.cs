for (int i = 0; i < numberOfProcessAvailable; i++) {
    var EXIFDirectory = directories.OfType<ExifDirectoryBase>().FirstOrDefault();
    if (EXIFDirectory != null && ExifIfd0Directory != null) {
        imageFileInfo.LensModel = EXIFDirectory.GetDescription(ExifIfd0Directory.TagLensModel).ToString();
        imageFileInfo.Make = EXIFDirectory.GetDescription(ExifIfd0Directory.TagMake).ToString();
        imageFileInfo.Model = EXIFDirectory.GetDescription(ExifIfd0Directory.TagModel).ToString();
    }
}

//https://pt.stackoverflow.com/q/221957/101
