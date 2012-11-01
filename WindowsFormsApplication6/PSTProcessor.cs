// PST Processor Code
// Modified from Stack overflow for Open Source PSTAMP
// Written by Joseph Bull (jtbull@uw.edu) 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook; 

namespace WindowsFormsApplication6
{
    class PSTProcessor
    {
        private String pstModifiedPath = "";
        private String modifiedOutputDirPath = ""; 
        // Constructs a new PSTProcessor
        // PRE: File is a PST File and output directory is not null... 
        public PSTProcessor(String PSTFilePathName, String outputDirPathName)
        {
                        // TODO: ADD ERROR EXCEPTION CHECKS HERE.....

            pstModifiedPath = PSTFilePathName.Substring(0, PSTFilePathName.Length);
            modifiedOutputDirPath = outputDirPathName.Substring(0, outputDirPathName.Length);
            String[] lines = { pstModifiedPath, modifiedOutputDirPath };
            System.IO.File.WriteAllLines(@"D:\Downloads\testProgramLog.txt", lines);
        }

        // Processes the PST File.... true if PST Parse succeeded false if it failed....
        public Boolean PSTProcess()
        {
            // Map<String, String> SenderNamesToSubjects;
            try
            {
                // IEnumerable<MailItem> mailItems = readPst(pstModifiedPath, "Modified Output Path...");
            }
            catch (System.Exception e)
            {
            } 

            return false;
        }
        /* REMOVE THIS LATER - IT MAY NEED TO BE MODIFIED.... 
        private static IEnumerable<MailItem> readPst(string pstFilePath, string pstName)
        {
            List<MailItem> mailItems = new List<MailItem>();
            Application app = new Application();
            NameSpace outlookNs = app.GetNamespace("MAPI");
            // Add PST file (Outlook Data File) to Default Profile
            outlookNs.AddStore(pstFilePath);
            MAPIFolder rootFolder = outlookNs.Stores[pstName].GetRootFolder();
            // Traverse through all folders in the PST file
            // TODO: This is not recursive, refactor
            Folders subFolders = rootFolder.Folders;
            foreach (Folder folder in subFolders)
            {
                Items items = folder.Items;
                foreach (object item in items)
                {
                    if (item is MailItem)
                    {
                        MailItem mailItem = item as MailItem;
                        mailItems.Add(mailItem);
                    }
                }
            }
            // Remove PST file from Default Profile
            outlookNs.RemoveStore(rootFolder);
            return mailItems;
        }
        */ 
    }
    
}
