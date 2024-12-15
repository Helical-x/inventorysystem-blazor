using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventorySystemV2.Miscellaneous
{
    public static class CSVExporter
    {
        public static Byte[] ListToCsvBytes<T>(IEnumerable<T> data)
        {
            var properties = typeof(T).GetProperties();
            var csvBuilder = new StringBuilder();

            // Add header
            foreach (var prop in properties)
            {
                csvBuilder.Append(prop.Name).Append(",");
            }
            csvBuilder.Length--; // Remove the last comma
            csvBuilder.AppendLine();

            // Add rows
            foreach (var item in data)
            {
                foreach (var prop in properties)
                {
                    var value = prop.GetValue(item, null) ?? string.Empty;
                    csvBuilder.Append(value.ToString()).Append(",");
                }
                csvBuilder.Length--; // Remove the last comma
                csvBuilder.AppendLine();
            }
            
            return Encoding.UTF8.GetBytes(csvBuilder.ToString());

        }
    }
}