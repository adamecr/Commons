using System;
using System.Collections.Generic;
using System.IO;
using net.adamec.lib.common.extensions;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    /// File copy utilities
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.FileUtils.Copy</NuProp.Id>
    /// <NuProp.Description>File copy utilities (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only file-copy file-utilities</NuProp.Tags>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class FileUtils
    {
        /// <summary>
        /// Copies the <paramref name="sourceDirectoryName">source directory</paramref> to <paramref name="destDirectoryName">destination directory</paramref>
        /// All files from source directory are copied to the destination directory. The destination directory is created when doesn't exist.
        /// <paramref name="recursive"/> parameter set to true let also subdirectories to be copied
        /// To overwrite the existing destination files, <paramref name="overwrite"/> must be set to true, otherwise the exception is thrown.
        /// When <paramref name="overwrite"/> is set, it's possible to exclude the files by adding the file names (without path, so applicable to all directories) to <paramref name="doNotOverwriteFileNames"/> list.
        /// The listed files are being "silently" skipped (no exception thrown)
        /// </summary>
        /// <param name="sourceDirectoryName">Full path to the source directory</param>
        /// <param name="destDirectoryName">Full path to the destination directory</param>
        /// <param name="recursive">True if the subdirectories are to be copied as well</param>
        /// <param name="overwrite">True to allow overwriting the existing destination files</param>
        /// <param name="doNotOverwriteFileNames">Optional list of file names not to be overwritten</param>
        /// <exception cref="ArgumentNullException"><paramref name="sourceDirectoryName"/> or <paramref name="destDirectoryName"/> is null.</exception>
        /// <exception cref="DirectoryNotFoundException"><paramref name="sourceDirectoryName"/> doesn't exist.</exception>
        public static void DirectoryCopy(
            string sourceDirectoryName, string destDirectoryName,
            bool recursive, bool overwrite,
            List<string> doNotOverwriteFileNames = null)
        {
            if (sourceDirectoryName == null) throw new ArgumentNullException(nameof(sourceDirectoryName));
            if (destDirectoryName == null) throw new ArgumentNullException(nameof(destDirectoryName));
            if (!Directory.Exists(sourceDirectoryName)) throw new DirectoryNotFoundException($"Source directory {sourceDirectoryName} does not exist");
            if (!Directory.Exists(destDirectoryName)) Directory.CreateDirectory(destDirectoryName); //create dest dir if needed

            var di = new DirectoryInfo(sourceDirectoryName);
            //copy files in dir
            foreach (var file in di.GetFiles())
            {
                FileCopy(file.FullName, destDirectoryName.AddPath(file.Name), overwrite, doNotOverwriteFileNames);
            }

            if (!recursive) return;
            //copy  sub directories 
            foreach (var subDir in di.GetDirectories())
            {
                DirectoryCopy(subDir.FullName, destDirectoryName.AddPath(subDir.Name), true, overwrite);
            }

        }
        /// <summary>
        /// Copies the <paramref name="sourceFileName">source file</paramref> to <paramref name="destFileName">destination file</paramref>
        /// To overwrite the existing destination file, <paramref name="overwrite"/> must be set to true, otherwise the exception is thrown.
        /// When <paramref name="overwrite"/> is set, it's possible to exclude the files by adding the file names (without path) to <paramref name="doNotOverwriteFileNames"/> list.
        /// The listed files are being "silently" skipped (no exception thrown)
        /// </summary>
        /// <param name="sourceFileName">Full path to the source file</param>
        /// <param name="destFileName">Full path to the destination file</param>
        /// <param name="overwrite">True to allow overwriting the existing destination file</param>
        /// <param name="doNotOverwriteFileNames">Optional list of file names not to be overwritten</param>
        /// <exception cref="ArgumentNullException"><paramref name="sourceFileName"/> or <paramref name="destFileName"/> is null.</exception>
        public static void FileCopy(string sourceFileName, string destFileName, bool overwrite, List<string> doNotOverwriteFileNames = null)
        {
            if (sourceFileName == null) throw new ArgumentNullException(nameof(sourceFileName));
            if (destFileName == null) throw new ArgumentNullException(nameof(destFileName));

            if (!overwrite || !File.Exists(destFileName))
            {
                File.Copy(sourceFileName, destFileName, false);
            }
            else
            {
                var fileName = Path.GetFileName(destFileName);
                if (doNotOverwriteFileNames == null || !doNotOverwriteFileNames.Exists(f => string.Equals(f, fileName, StringComparison.CurrentCultureIgnoreCase)))
                {
                    File.Copy(sourceFileName, destFileName, true);
                }
                //else skip (don't overwrite) file
            }
        }
    }
}
