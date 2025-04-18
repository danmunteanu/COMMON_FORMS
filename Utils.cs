﻿namespace CommonForms
{
    public class Utils
    {
		/// <summary>
        /// File prefix date mask
        /// </summary>
		public static string K_PREFIX_DATE_MASK = "yyyy-MM-dd-";

        /// <summary>
        /// An array of video file extensions
        /// </summary>
        public static string[] VideoFileExtensions { get; } =
        {
            ".mp4",
            ".mkv",
            ".webm",
        };

        /// <summary>
        /// An array of file extensions that commonly contain Markdown or YAML content.
        /// </summary>
        public static string[] YamlFileExtensions { get; } =
        {
            ".md",       // Markdown files
            ".txt",      // Plain text files
            ".markdown", // Alternative Markdown extension
            ".yaml",     // YAML files
            ".yml"       // Alternative YAML extension
        };

        /// <summary>
        /// An array of common audio file extensions.
        /// </summary>
        public static string[] AudioFileExtensions { get; } =
        {
            ".mp3",  // MPEG Audio Layer III
            ".wav",  // Waveform Audio File Format
            ".flac", // Free Lossless Audio Codec
            ".aac",  // Advanced Audio Codec
            ".ogg",  // Ogg Vorbis
            ".wma",  // Windows Media Audio
            ".m4a",  // MPEG-4 Audio
            ".aiff", // Audio Interchange File Format
            ".amr",  // Adaptive Multi-Rate
            ".opus"  // Opus Audio
        };

        /// <summary>
        /// An array of common archive file extensions.
        /// </summary>
        public static string[] ArchiveFileExtensions { get; } =
        {
            ".zip",
            ".7z",
            ".rar",
            ".gz",
            ".tar",
            ".tar.gz",
            ".tar.bz2",
            ".tgz",
            ".iso",
            ".cab",
            ".xz",
            ".lz",
            ".tar.xz",
            ".z01",
            ".ace",
            ".arj",
            ".lzh",
            ".dmg",
            ".apk"
        };

        /// <summary>
        /// An array of common image file extensions.
        /// </summary>
        public static string[] ImageFileExtensions { get; } =
        {
            ".jpg",
            ".jpeg",
            ".png",
            ".gif",
            ".bmp",
            ".tiff",
            ".webp",
            ".ico",
            ".svg",
            ".heif",
            ".raw"
        };

        
		/// <summary>
        ///	Helper function - Adds a user control to a panel, dock fill, does not add twice
        /// </summary>
        public static bool AddUserControlToPanel(Panel panel, UserControl control)
        {
            if (panel.Controls.Contains(control))
                return false;

            if (control == null)
                return false;

            control.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(control);
            control.BringToFront();
			
			return true;
        }

        /*
         *  Does a string start with a date prefix?
         *      e.g. 2024-02-01
         */
        public static bool HasDatePrefix(string s)
        {
            //  Try cast first 10 characters to a date 2024-02-01
            if (s.Length > 11)
            {
                //  first 10 characters should be castable to a date
                string titleDate = s.Substring(0, 10);

                //  try to cast to a date
                try
                {
                    DateTime dateCast = DateTime.Parse(titleDate);
                }
                catch (FormatException)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

		/// <summary>
        ///	Helper function - converts a bool value to string true -> "yes", false -> "no"
        /// </summary>
        public static string Bool2String(bool b)
        {
            return b ? "yes" : "no";
        }
    }
}
