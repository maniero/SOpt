using System.IO; 

string[] files = Directory.GetFiles(dirName);

foreach (string file in files) {
   FileInfo fi = new FileInfo(file);
   if (fi.LastAccessTime < DateTime.Now.AddMonths(-3))
      fi.Delete();
}

//

Directory.GetFiles(dirName)
     .Select(f => new FileInfo(f))
     .Where(f => f.LastAccessTime < DateTime.Now.AddMonths(-3))
     .ToList()
     .ForEach(f => f.Delete());

//

static class Helpers {
    public static void DeleteOldFiles(string folderPath, uint maximumAgeInDays, params string[] filesToExclude) {
        DateTime minimumDate = DateTime.Now.AddDays(-maximumAgeInDays);
        foreach (var path in Directory.EnumerateFiles(folderPath)) {
            if (IsExcluded(path, filesToExclude))
                continue;

            DeleteFileIfOlderThan(path, minimumDate);
        }
    }

    private const int RetriesOnError = 3;
    private const int DelayOnRetry = 1000;

    private static bool IsExcluded(string item, string[] exclusions) {
        foreach (string exclusion in exclusions) {
            if (item.Equals(exclusion, StringComparison.CurrentCultureIgnoreCase))
                return true;
        }

        return false;
    }

    private static bool DeleteFileIfOlderThan(string path, DateTime date) {
        for (int i = 0; i < RetriesOnError; ++i) {
            try {
                FileInfo file = new FileInfo(path);
                if (file.CreationTime < date)
                    file.Delete();

                return true;
            } catch (IOException) {
                System.Threading.Thread.Sleep(DelayOnRetry);
            } catch (UnauthorizedAccessException) {
                System.Threading.Thread.Sleep(DelayOnRetry);
            }
        }

        return false;
    }
}

//https://pt.stackoverflow.com/q/39116/101
