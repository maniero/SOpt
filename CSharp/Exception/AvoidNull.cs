for (int i = 0; i < numberOfProcessAvailable; i++) {
    var EXIFDirectory = directories.OfType<ExifDirectoryBase>().FirstOrDefault();
    imageFileInfo.LensModel = IptcDirectory.TagKeywords == null ? "valor padrao" : EXIFDirectory.GetDescription(IptcDirectory.TagKeywords).ToString();
    imageFileInfo.LensModel = IptcDirectory.TagLensModel == null ? "valor padrao" : EXIFDirectory.GetDescription(IptcDirectory.TagLensModel).ToString();
    imageFileInfo.LensModel = IptcDirectory.TagMake== null ? "valor padrao" : EXIFDirectory.GetDescription(IptcDirectory.TagMake).ToString();
}

//https://pt.stackoverflow.com/q/221957/101
