using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  ApplicationSettings
//  - KEY-VALUE pairs
//  - VALUE Types (e.g. string, numeric, bool)
//  - Sections (MASS_YAML, UPDATE_YAML, etc..)
//  - SaveToIniFile()
//  - LoadFromIniFile()
//  - TAB Button Fonts
//      - Microsoft bla bla bla, font size,
//  

namespace CommonForms
{
    public class ApplicationSettings
    {
        // Dictionary to store the settings
        private Dictionary<string, object> _settings = new Dictionary<string, object>();

        // Add or update a key-value pair
        public void Add(string key, object value)
        {
            if (_settings.ContainsKey(key))
            {
                _settings[key] = value; // Update existing key
            }
            else
            {
                _settings.Add(key, value); // Add new key
            }
        }

        // Remove a key-value pair
        public bool Remove(string key)
        {
            return _settings.Remove(key);
        }

        // Clear all key-value pairs
        public void Clear()
        {
            _settings.Clear();
        }

        // Save settings to an INI file
        public void SaveToIni(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var pair in _settings)
                    {
                        writer.WriteLine($"{pair.Key}={ConvertToString(pair.Value)}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to INI file: {ex.Message}");
            }
        }

        // Load settings from an INI file
        public void LoadFromIni(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) return;

                foreach (var line in File.ReadLines(filePath))
                {
                    var parts = line.Split(new char[] { '=' }, 2);
                    if (parts.Length == 2)
                    {
                        var key = parts[0].Trim();
                        var value = ConvertToObject(parts[1].Trim());
                        Add(key, value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading from INI file: {ex.Message}");
            }
        }

        // Helper method to convert an object to a string for saving
        private string ConvertToString(object value)
        {
            if (value is bool)
            {
                return ((bool)value) ? "true" : "false";
            }
            return value.ToString(); // Default for other types
        }

        // Helper method to convert a string to the correct object type
        private object ConvertToObject(string value)
        {
            if (bool.TryParse(value, out bool boolValue))
            {
                return boolValue;
            }
            if (int.TryParse(value, out int intValue))
            {
                return intValue;
            }
            if (float.TryParse(value, out float floatValue))
            {
                return floatValue;
            }
            return value; // Default is string
        }

        // Optional: Print all settings (for debugging purposes)
        public void PrintSettings()
        {
            foreach (var pair in _settings)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
};
