using System;
using System.IO;

internal class Logs
{
    public static void WriteLog(string strLog)
    {
        FileStream fileStream = null;
        DirectoryInfo directoryInfo = null;
        string text = Directory.GetCurrentDirectory() + "\\";
        text = text + "Log-" + DateTime.Today.ToString("MM-dd-yyyy") + ".txt";
        FileInfo fileInfo = new FileInfo(text);
        directoryInfo = new DirectoryInfo(fileInfo.DirectoryName);
        if (!directoryInfo.Exists)
        {
            directoryInfo.Create();
        }

        fileStream = (fileInfo.Exists ? new FileStream(text, FileMode.Append) : fileInfo.Create());
        StreamWriter streamWriter = new StreamWriter(fileStream);
        streamWriter.WriteLine("# >>  " + strLog);
        streamWriter.WriteLine("#-------------------------------------------------------------------------");
        streamWriter.Close();
    }

    public static void DeleteLog()
    {
        DirectoryInfo directoryInfo = null;
        FileInfo fileInfo = new FileInfo(string.Concat(Directory.GetCurrentDirectory() + "\\", "Log-", DateTime.Today.ToString("MM-dd-yyyy"), ".txt"));
        directoryInfo = new DirectoryInfo(fileInfo.DirectoryName);
        if (!directoryInfo.Exists)
        {
            directoryInfo.Delete();
        }

        if (fileInfo.Exists)
        {
            fileInfo.Delete();
        }
    }
}