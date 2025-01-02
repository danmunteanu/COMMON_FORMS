namespace CommonForms
{
    public class Utils
    {
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

        //	Helper to add user controls to a panel - should be common somewhere
        public static void AddUserControl(Panel panel, UserControl control)
        {
            if (panel.Controls.Contains(control))
                return;

            control.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(control);
            control.BringToFront();
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
                catch (FormatException formatExcept)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static string Bool2StringYesNo(bool b)
        {
            return b ? "yes" : "no";
        }
    }
}
