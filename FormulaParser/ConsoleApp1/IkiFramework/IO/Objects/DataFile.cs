using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace IkiCore.IO
{
    public class DataFile
    {
        FileInfo fileInfo;
        public DataFile(string path)
        {
            fileInfo = new FileInfo(path);
        }
        public bool Exist { get => fileInfo.Exists; }
        public string Path { get => fileInfo.FullName; }
        public string Name { get => fileInfo.Name; }
        public string Extension { get => System.IO.Path.GetExtension(Path); }
        public long Size { get => fileInfo.Length; }
        public DataDirectory GetDirectory { get => new DataDirectory(fileInfo.DirectoryName); }
        public bool ReadOnly { get => fileInfo.IsReadOnly; set => fileInfo.IsReadOnly = value; }
        public void MoveTo(DataDirectory directory)
        {
            if(directory.Exist)
            {
                fileInfo.MoveTo(directory.Path);
            }
        }
        public void Replace(DataFile file, DataFile backupFile)
        {
            fileInfo.Replace(file.Path, backupFile.Path);
        }
        public void OverrideContent(DataFile newContent)
        {
            fileInfo.Delete();
            using (FileStream fsOverride = fileInfo.OpenWrite())
            {
                using (FileStream fsListening = newContent.fileInfo.OpenRead())
                {
                    long length = newContent.fileInfo.Length;
                    int leftOver = (int)(length % Constant.FileBufferSize);
                    long iterations = length / Constant.FileBufferSize;
                    int i = 0;
                    byte[] buffer = new byte[Constant.FileBufferSize];
                    while(i < iterations)
                    {
                        fsListening.Read(buffer, 0, Constant.FileBufferSize);
                        fsOverride.Write(buffer, 0, Constant.FileBufferSize);
                        i++;
                    }
                    if (leftOver > 0)
                    {
                        buffer = new byte[leftOver];
                        fsListening.Read(buffer, 0, leftOver);
                        fsOverride.Write(buffer, 0, leftOver);
                    }
                }
            }
        }
        public void Open(Action<FileStream> action, FileMode fileMode)
        {
            using (FileStream fsOverride = fileInfo.Open(fileMode))
            {
                action(fsOverride);
            }
        }
        public void Write(Action<FileStream> action)
        {
            using (FileStream fsOverride = fileInfo.OpenWrite())
            {
                action(fsOverride);
            }
        }
        public void Read(Action<FileStream> action)
        {
            using (FileStream fsOverride = fileInfo.OpenRead())
            {
                action(fsOverride);
            }
        }
        public void ReadText(Action<StreamReader> action)
        {
            using (StreamReader srOverride = fileInfo.OpenText())
            {
                action(srOverride);
            }
        }
        public string Content() => File.ReadAllText(Path);
        public void OverrideContent(string datas) => File.WriteAllText(Path, datas);
        public void OverrideContent(IEnumerable<string> datas) => File.WriteAllLines(Path, datas);
        public void OverrideContent(byte[] datas) => File.WriteAllBytes(Path, datas);
        public FileStream OpenWrite() => fileInfo.OpenWrite();
        public FileStream OpenRead() => fileInfo.OpenRead();
        public FileStream Open(FileMode fileMode) => fileInfo.Open(fileMode);
        public StreamReader OpenText() => fileInfo.OpenText();
        public void Encrypt() => fileInfo.Encrypt();
        public void Decrypt() => fileInfo.Decrypt();
        public void CopyTo(DataDirectory directory, bool overrideFile = false)
        {
            fileInfo.CopyTo(directory.Path, overrideFile);
        }
        public void Delete()
        {
            fileInfo.Delete();
        }
        public bool SameContent(DataFile compareTo)
        {
            if(fileInfo.Length != compareTo.fileInfo.Length)
            {
                return false;
            }
            bool sameContent = false;
            using(FileStream fs1 = OpenRead())
            {
                using(FileStream fs2 = compareTo.OpenRead())
                {
                    sameContent = CheckEquality(fileInfo.Length, fs1, fs2);
                }
            }
            return sameContent;
        }
        bool CheckEquality(long length, FileStream fs1, FileStream fs2)
        {
            byte[] buffer1 = new byte[Constant.FileBufferSize];
            byte[] buffer2 = new byte[Constant.FileBufferSize];
            int leftOver = (int)(length % Constant.FileBufferSize);
            long iterations = length / Constant.FileBufferSize;
            int i = 0;
            while (i < iterations)
            {
                fs1.Read(buffer1, 0, Constant.FileBufferSize);
                fs2.Write(buffer2, 0, Constant.FileBufferSize);
                if(!buffer1.SequenceEqual(buffer2))
                {
                    return false;
                }
                i++;
            }
            if (leftOver > 0)
            {
                buffer1 = new byte[leftOver];
                buffer2 = new byte[leftOver];
                fs1.Read(buffer1, 0, leftOver);
                fs2.Write(buffer2, 0, leftOver);
                if (!buffer1.SequenceEqual(buffer2))
                {
                    return false;
                }
            }
            return true;
        }
        public void Rename(string newName, bool overrideIfExist = false)
        {
            string newFileName = System.IO.Path.Combine($"{fileInfo.DirectoryName}\\", newName);
            if(File.Exists(newFileName))
            {
                if(overrideIfExist)
                {
                    File.Delete(newFileName);
                    File.Move(Path, newFileName);
                    fileInfo = new FileInfo(newFileName);
                }
            }
            else
            {
                File.Move(Path, newFileName);
                fileInfo = new FileInfo(newFileName);
            }
        }
        /// <summary>
        /// The creation time of the file.
        /// </summary>
        public DateTime CreationTime
        {
            get => fileInfo.CreationTime;
            set => fileInfo.CreationTime = value;
        }
        /// <summary>
        /// The creation time in UTC time format.
        /// </summary>
        public DateTime CreationTimeUTC
        {
            get => fileInfo.CreationTimeUtc;
            set => fileInfo.CreationTimeUtc = value;
        }
        /// <summary>
        /// Time of the last access of the file.
        /// </summary>
        public DateTime LastAccessTime
        {
            get => fileInfo.LastAccessTime;
            set => fileInfo.LastAccessTime = value;
        }
        /// <summary>
        /// Time UTC of the last access of the file.
        /// </summary>
        public DateTime LastAccessTimeUTC
        {
            get => fileInfo.LastAccessTimeUtc;
            set => fileInfo.LastAccessTimeUtc = value;
        }
        /// <summary>
        /// Time of the last write on the file.
        /// </summary>
        public DateTime LastWriteTime
        {
            get => fileInfo.LastWriteTime;
            set => fileInfo.LastWriteTime = value;
        }
        /// <summary>
        /// Time UTC of the last write on the file.
        /// </summary>
        public DateTime LastWriteTimeUTC
        {
            get => fileInfo.LastWriteTimeUtc;
            set => fileInfo.LastWriteTimeUtc = value;
        }
        public FileAttributes Attributes
        {
            get => fileInfo.Attributes;
            set => fileInfo.Attributes = value;
        }
        public bool IsHidden
        {
            get => Attributes == FileAttributes.Hidden;
        }
    }
}
