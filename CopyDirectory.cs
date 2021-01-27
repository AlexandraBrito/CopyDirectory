using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CopyDirectory
{
    public static class CopyDirectory
    {
        public static void Copy(string sourceDirectory, string targetDirectory, Func<string, string> funcToPrint)
        {
            var source = new DirectoryInfo(sourceDirectory);
            var target = new DirectoryInfo(targetDirectory);
            var errors = new List<string>();

            ValidatePaths(source, target, errors);
            if (errors.Any())
                errors.ForEach(error => funcToPrint(error));
            else
            {
                try
                {
                    CopyAll(source, target, funcToPrint);
                }
                catch
                {
                    funcToPrint(" An error occured, Copy was not Sucessfull");

                }
                funcToPrint("Finished");
            }
        }

        private static void ValidatePaths(DirectoryInfo source, DirectoryInfo target, List<string> errors)
        {
            if (String.Equals(source.FullName, target.FullName))
            {
                errors.Add(" Please chosse diferent folders to copy from and to");
            }
            else if (target.FullName.StartsWith(source.FullName))
            {
                errors.Add("Please chosse a target folder outside the source folder ");
            }
        }

        private async static void CopyAll(DirectoryInfo source, DirectoryInfo target, Func<string, string> funcToPrint)
        {
            Directory.CreateDirectory(target.FullName);
            funcToPrint("  Coping folder: " + target.Name);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                funcToPrint("      Coping file: " + fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir, funcToPrint);
            }
        }
    }
}
