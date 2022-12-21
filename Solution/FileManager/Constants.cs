using System.IO;
using System;

public static class Constants{

    public static string DefaultPath => KnownFolders.GetPath(KnownFolder.Downloads);
    //public static string DefaultPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
}