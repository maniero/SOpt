var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MappedLogicalDisk"); 
foreach (var queryObj in searcher.Get()) WriteLine("VolumeName: {0}", queryObj["VolumeName"]);

//https://pt.stackoverflow.com/q/119242/101
