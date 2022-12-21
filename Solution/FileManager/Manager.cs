using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Shapes;
using Path = System.IO.Path;

public class Manager
{

    //private readonly string PDF_FOLDER = Constants.PDF_Folder;
    //private readonly string IMG_FOLDER = Constants.Images_Folder;
    private readonly string DEFAULT_PATH = Constants.DefaultPath;

    public event EventHandler<bool>? OnFilesMoved;

    private int _countMovedFiles;

    public Manager()
    {
    }

    public string GetDefaultPath() => DEFAULT_PATH;

    public void Update(string path)
    {
        Start(path);
    }

    public void Start(string path)
    {
        var files = Directory.GetFiles(path);
        var pdf = Path.Combine(path, "PDFs");
        var images = Path.Combine(path, "Images");

        foreach (var file in files)
        {
            if (IsPDF(Path.GetExtension(file))) MoveFiles(file, pdf);
            if (IsIMG(Path.GetExtension(file))) MoveFiles(file, images);
        }

        OnFilesMoved?.Invoke(this, _countMovedFiles > 0);
        _countMovedFiles = 0;
    }

    private void MoveFiles(string file, string folderToMove)
    {
        if (!Directory.Exists(folderToMove))
        {
            Directory.CreateDirectory(folderToMove);
        }

        var fileName = Path.GetFileName(file);
        var pathToMove = Path.Combine(folderToMove, fileName);

        try 
        {
            File.Move(file, pathToMove);
            _countMovedFiles++;
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.ToString());
        }
    }

    public static bool IsPDF(string extension) => extension == ".pdf";
    public static bool IsIMG(string extension) => (extension == ".jpg" || extension == ".png" || extension == ".jpeg" || extension == ".webp");

}
