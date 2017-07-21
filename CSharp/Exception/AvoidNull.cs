for (int i = 0; i < numberOfProcessAvailable; i++) {
    var IptcDirectory = directories.OfType<IptcDirectoryBase>().FirstOrDefault();
    imageFileInfo.Keywords = IptcDirectory.GetProperty('TagKeywords') == null ? "padrao keywords" : IptcDirectory.GetDescription(IptcDirectory.TagKeywords);
    imageFileInfo.LensModel = IptcDirectory.GetProperty('TagLensModel') == null ? "padrao lensmodel" : IptcDirectory.GetDescription(IptcDirectory.TagLensModel);
    imageFileInfo.TagMake = IptcDirectory.GetProperty('TagMake') == null ? "padrao make" : IptcDirectory.GetDescription(IptcDirectory.TagMake);
}

//https://pt.stackoverflow.com/q/221957/101
