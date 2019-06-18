foreach (var d in DriveInfo.GetDrives()) {
    if (d.IsReady) WriteLine($"Volume label: {d.VolumeLabel}");
}

//https://pt.stackoverflow.com/q/47924/101
