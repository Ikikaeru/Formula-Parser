using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IkiCore.IO
{
    public class DataDirectory
    {
        public string Path { get; private set; }
        public string Name { get => System.IO.Path.GetDirectoryName(Path); }
        public bool Exist { get => Directory.Exists(Path); }
        public DataDirectory(string path)
        {
            Path = path;
        }
        public DataDirectory(Environment.SpecialFolder directory)
        {
            Path = Environment.GetFolderPath(directory);
        }
        public static DataDirectory ProgramDirectory { get => new DataDirectory(AppDomain.CurrentDomain.BaseDirectory); }
        public bool ContainDirectory(string directoryName, bool checkChilds = false) => Directory.GetDirectories(Path, directoryName, checkChilds ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Length > 0;
        /// <summary> Return true if a file exist inside the directory. Use search pattern * (0 or more char) ? (0 or 1 char) </summary>
        /// <param name="fileName"></param>
        public bool ContainFile(string fileName, bool checkChilds = false) => Directory.GetFiles(Path, fileName, checkChilds ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Length > 0;
        public DataDirectory GetRelativeDirectory(string relativePath)
        {
            string[] newPath = relativePath.Replace('/', '\\').Split('\\');
            if (newPath.Length >= 2 && newPath[newPath.Length - 2] != ".")
            {
                DataDirectory currentDir = new DataDirectory(Path);
                for (int i = 0; i < newPath.Length; i++)
                {
                    if (newPath[i] == "..")
                    {
                        currentDir = currentDir.Parent;
                    }
                    else
                    {
                        currentDir = currentDir.GetDirectory($"{currentDir.Path}\\{newPath[i]}");
                    }
                }
                return currentDir;
            }
            throw new Exception("Attempt to get a file!");
        }
        public string[] ContainedExtensions()
        {
            HashSet<string> hash = new HashSet<string>();
            string[] files = Directory.GetFiles(Path);
            for (int i = 0; i < files.Length; i++)
            {
                hash.Add(System.IO.Path.GetExtension(files[i]));
            }
            return hash.ToArray();
        }
        public DataFile CreateFile(string fileName, Action<FileStream> action = null, bool overrideIfExist = false)
        {
            string newFilePath = System.IO.Path.Combine(Path, fileName);
            if (File.Exists(newFilePath))
            {
                if(overrideIfExist)
                {
                    using (FileStream fs = File.Create(newFilePath))
                    {
                        action(fs);
                    }
                    return new DataFile(newFilePath);
                }
            }
            else
            {
                using(FileStream fs = File.Create(newFilePath))
                {
                    action(fs);
                }
                return new DataFile(newFilePath);
            }
            return null;
        }
        public DataFile GetFile(string fileName)
        {
            string newFilePath = System.IO.Path.Combine(Path, fileName);
            if(File.Exists(newFilePath))
            {
                return new DataFile(newFilePath);
            }
            return null;
        }
        public bool ContainFile(string fileName) => File.Exists(System.IO.Path.Combine(Path, fileName));
        public void RemoveFile(string fileName)
        {
            DataFile tmp = new DataFile(System.IO.Path.Combine(Path, fileName));
            tmp.Delete();
        }
        public DataFile[] GetContainedFiles(bool searchSubDirectories = false, string searchPattern = "")
        {
            string[] files = Directory.GetFiles(Path, searchPattern, searchSubDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            DataFile[] allFiles = new DataFile[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                allFiles[i] = new DataFile(files[i]);
            }
            return allFiles;
        }
        public DataDirectory GetDirectory(string directoryName, bool checkChilds = false)
        {
            string newPath = System.IO.Path.Combine(Path, directoryName);
            if(Directory.Exists(newPath))
            {
                return new DataDirectory(newPath);
            }
            return null;
        }
        public DataDirectory[] Directories()
        {
            string[] dir = Directory.GetDirectories(Path);
            DataDirectory[] allDirectories = new DataDirectory[dir.Length];
            for (int i = 0; i < dir.Length; i++)
            {
                allDirectories[i] = new DataDirectory(dir[i]);
            }
            return allDirectories;
        }
        public DataDirectory[] AllDirectories(string searchPattern)
        {
            string[] dir = Directory.GetDirectories(Path, searchPattern, SearchOption.AllDirectories);
            DataDirectory[] allDirectories = new DataDirectory[dir.Length];
            for (int i = 0; i < dir.Length; i++)
            {
                allDirectories[i] = new DataDirectory(dir[i]);
            }
            return allDirectories;
        }
        public DataDirectory[] GetDirectories(string searchPattern, bool checkChilds = false)
        {
            string[] directories = Directory.GetDirectories(Path, searchPattern, checkChilds ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            DataDirectory[] dd = new DataDirectory[directories.Length];
            for (int i = 0; i < directories.Length; i++)
            {
                dd[i] = new DataDirectory(directories[i]);
            }
            return dd;
        }
        /// <summary> Delete the directory and all its sub-directories with files included. </summary>
        public void Delete(bool recursive = true)
        {
            if(Exist)
            {
                Directory.Delete(Path, recursive);
            }
        }
        /// <summary> Create a directory inside this directory if it doesn't exist. </summary>
        /// <param name="directoryName"></param>
        public void CreateDirectory(string directoryName) { Directory.CreateDirectory(System.IO.Path.Combine(directoryName, directoryName)); }
        public static DataDirectory CreateFolder(string directoryPath)
        {
            Directory.CreateDirectory(directoryPath);
            return new DataDirectory(directoryPath);
        }
        /// <summary> Move a directory to another one. </summary>
        /// <param name="destination"></param>
        /// <param name="overrideDirectory"></param>
        public void MoveDirectory(DataDirectory destination, bool overrideDirectory = false)
        {
            if (!Directory.Exists(destination.Path) || overrideDirectory)
            {
                Directory.Move(Path, destination.Path);
                Path = destination.Path;
            }
        }
        /// <summary> Create this directory unless it already exist. </summary>
        public void Create()
        {
            Directory.CreateDirectory(Path);
        }
        /// <summary> Get the root of the directory. </summary>
        public DataDirectory Root { get => new DataDirectory(Directory.GetDirectoryRoot(Path)); }
        /// <summary> Get the directory's parent. </summary>
        public DataDirectory Parent { get => new DataDirectory(Directory.GetParent(Path).FullName); }
        /// <summary> The creation time of the directory. </summary>
        public DateTime CreationTime
        {
            get
            {
                return Directory.GetCreationTime(Path);
            }
            set
            {
                Directory.SetCreationTime(Path, value);
            }
        }
        /// <summary> The creation time in UTC time format. </summary>
        public DateTime CreationTimeUTC
        {
            get
            {
                return Directory.GetCreationTimeUtc(Path);
            }
            set
            {
                Directory.SetCreationTimeUtc(Path, value);
            }
        }
        /// <summary> Time of the last access of the directory. </summary>
        public DateTime LastAccessTime
        {
            get
            {
                return Directory.GetLastAccessTime(Path);
            }
            set
            {
                Directory.SetLastAccessTime(Path, value);
            }
        }
        /// <summary> Time UTC of the last access of the directory. </summary>
        public DateTime LastAccessTimeUTC
        {
            get
            {
                return Directory.GetLastAccessTimeUtc(Path);
            }
            set
            {
                Directory.SetLastAccessTimeUtc(Path, value);
            }
        }
        /// <summary> Time of the last write on the directory. </summary>
        public DateTime LastWriteTime
        {
            get
            {
                return Directory.GetLastWriteTime(Path);
            }
            set
            {
                Directory.SetLastWriteTime(Path, value);
            }
        }
        /// <summary> Time UTC of the last write on the directory. </summary>
        public DateTime LastWriteTimeUTC
        {
            get
            {
                return Directory.GetLastWriteTimeUtc(Path);
            }
            set
            {
                Directory.SetLastWriteTimeUtc(Path, value);
            }
        }
    }
}
