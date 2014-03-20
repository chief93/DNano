using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Abstractions
{
    public class FileItem
    {
        public string Contents { get; private set; }
        public string Location { get; private set; }
        public string Name { get; private set; }
        public string Extension { get; private set; }

        public FileItem(string path)
        {
            _parse(path);

            if (File.Exists(path))
                Contents = File.ReadAllText(path);
        }

        public FileItem(string path, string contents)
        {
            _parse(path);
            Contents = contents;
        }

        public void Save()
        {
            File.WriteAllText(Location + Name, Contents);
        }

        private void _parse(string path)
        {
            path = path.Replace('\\', '/');

            List<string> pathComponents = path.Split('/').ToList<string>();
            Location = Build(pathComponents, true);

            List<string> fileComponents = pathComponents[pathComponents.Count - 1].Split('.').ToList<string>();
            Extension = fileComponents[fileComponents.Count - 1];
            Name = pathComponents[pathComponents.Count - 1];
        }

        public static string Build(List<string> components, bool excludeLast = false, string delimiter = "/")
        {
            int i = 0;
            string output = "";

            foreach (string item in components)
            {
                if (i == components.Count - 1 && excludeLast) break;
                
                output += item + delimiter;
                i++;
            }

            return output;
        }

        public static List<FileItem> ObjectizeDirectory(string path)
        {
            List<FileItem> output = new List<FileItem>();

            if (!Directory.Exists(path)) return output;

            List<string> entries = Directory.EnumerateFiles(path, "*.d", SearchOption.AllDirectories).ToList<string>();

            foreach (string entry in entries)
                if (File.Exists(entry)) output.Add(new FileItem(entry));

            return output;
        }


        public static void MoveMassive(string path, string target, string pattern)
        {
            if (!Directory.Exists(path)) return;

            List<string> entries = Directory.EnumerateFiles(path, pattern, SearchOption.AllDirectories).ToList<string>();

            foreach (string entry in entries)
            {
                string normalizedTarget = (target + entry.Replace(path, "")).Replace('\\', '/');

                FileItem physicalTarget = new FileItem(normalizedTarget);

                if (!Directory.Exists(physicalTarget.Location))
                    Directory.CreateDirectory(physicalTarget.Location);

                if (File.Exists(normalizedTarget))
                    File.Delete(normalizedTarget);

                File.Move(entry, normalizedTarget);
            }
        }


        public static string BuildNormalizedPath(string path, bool addEndingSlash = false)
        {
            path = path.Replace('\\', '/').Replace("//", "/");
            path += addEndingSlash ? "/" : "";

            PlatformID platform = Environment.OSVersion.Platform;

            if (platform != PlatformID.Unix || platform != PlatformID.MacOSX)
            {
                path = path.Replace('/', '\\');
            }

            return path;
        }


        public static TreeNode[] BuildDirectoryTree(string path)
        {
            path = path.Replace('\\', '/');

            TreeNode[] nodes = null;

            if (!Directory.Exists(path)) return nodes;

            int i = 0;
            List<string> entries = Directory.EnumerateFileSystemEntries(path).ToList<string>();
            nodes = new TreeNode[entries.Count];

            foreach (string entry in entries)
            {
                string clearEntry = entry.Replace('\\', '/').Replace("//", "/");
                FileItem fileitem = new FileItem(clearEntry);
                string textname = fileitem.Name;

                TreeNode newNode = new TreeNode();

                newNode.Name = textname;
                newNode.Text = textname;
                newNode.ToolTipText = clearEntry;

                if (Directory.Exists(clearEntry))
                {
                    TreeNode[] append = BuildDirectoryTree(clearEntry);

                    if (append != null)
                        newNode.Nodes.AddRange(append);
                }

                nodes[i] = newNode;

                i++;
            }

            return nodes;
        }
    }
}