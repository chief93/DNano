﻿using System;
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

        public FileItem(string path, string contents)
        {
            path = path.Replace('\\', '/');

            List<string> pathComponents = path.Split('/').ToList<string>();
            Location = Build(pathComponents, true);
            Contents = contents;

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
                FileItem fileitem = new FileItem(clearEntry, "");
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