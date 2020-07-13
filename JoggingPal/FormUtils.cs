using System.Windows.Forms;

namespace JoggingPal
{
    class FormUtils
    {
        public static ColumnHeader[] CreateColumnHeaders(string[] headers)
        {
            ColumnHeader[] columnHeaders = new ColumnHeader[headers.Length];
            for (int i = 0; i < headers.Length; i++)
            {
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = headers[i];
                columnHeaders[i] = columnHeader;
            }
            return columnHeaders;
        }
    }
}
