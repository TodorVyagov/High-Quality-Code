using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CohesionAndCoupling
{
    class FileUtils
    {
        /// <summary>
        /// Returns the extension of the specified file name.
        /// </summary>
        /// <param name="path">The file name from which to get the extension.</param>
        /// <returns>The extension of the specified file name (excluding the period ".") 
        /// or System.String.Empty. If path does not have extension information, 
        /// GetExtension(System.String) returns System.String.Empty.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if file name is null or empty.</exception>
        public static string GetFileExtension(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("File name cannot be null or empty!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return "";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Returns the file name of the specified file name without the extension.
        /// </summary>
        /// <param name="path">The file name.</param>
        /// <returns>The string returned by FileUtils.GetFileNameWithoutExtension(System.String), minus the
        /// last period (.) and all characters following it.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if file name is null or empty.</exception>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("File name cannot be null or empty!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
