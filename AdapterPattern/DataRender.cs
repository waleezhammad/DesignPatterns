using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class DataRender 
    {
        private IDataAdapter _dataAdapter;
        public DataRender(IDbDataAdapter dataAdapter )
        {
            _dataAdapter = dataAdapter;
        }

        public void Render(TextWriter writer)
        {
            writer.WriteLine("Rendering Data...");

            var myDataSet = new DataSet();

            _dataAdapter.Fill(myDataSet);

            foreach (DataTable dataTable in myDataSet.Tables)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    writer.Write(column.ColumnName.PadLeft(20));
                }
                writer.WriteLine();

                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        writer.Write(row[i].ToString().PadLeft(20)+" " );
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
