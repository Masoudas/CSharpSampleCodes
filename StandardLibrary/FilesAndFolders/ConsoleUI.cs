using System.IO;


class ConsoleUI
{
    public static void directories(){
        string rootPath = @"D:\Movies";   // A random root

        string[] dirs = Directory.GetDirectories(rootPath);   // All directories here, no options included. Just on the root path.
                                                      // No recursion

        foreach (String dir in dirs)
        {
            Console.WriteLine(dir);
            Console.WriteLine(Path.GetDirectoryName(dir));
        }

        string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);   // Search for all dirs, including sub-dirs.

    }

    public static void files(){
        string rootPath = @"D:\Movies";   // A random root

        var files = Directory.GetFiles(rootPath, "*", SearchOption.TopDirectoryOnly);

        foreach (String file in files)
        {
            Console.WriteLine(file);       
        }

        // To get only the file name, and not the entire path
        foreach (String file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        // To remove the extension
        foreach (String file in files)
        {
            Console.WriteLine(Path.GetFileNameWithoutExtension(file));
        }

        foreach (String file in files)
        {
            var info = new FileInfo(file);
            Console.WriteLine($"{Path.GetFileName(file)} size in byte is: {info.Length}");

            System.DateTime last_date = info.LastAccessTime;
        }
    }

    /**
    Let's say we want to do some automation task, like creating a temp folder and then putting a log file
    inside of it once the app is deployed somewhere.
    */
    public static void createAutomationTasks(){
        var path = @"C:\Path";
        bool exists = Directory.Exists(path); // Exists!
        Directory.CreateDirectory(path);    // Creates all directories in the path if non-existent.

        File.Exists(path);

        File.Copy(path,$"{path}\\newFile", false); // Copy new file if non-existent (false).

        String[] files = Directory.GetFiles(path);
        String[] dirs = Directory.GetDirectories(path);

        File.Move(path, path);    // Move the file directly
    }
}