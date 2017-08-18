using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Tests
{
    class StubAdapter : IDbDataAdapter
    {
        public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new NotImplementedException();

        public int Fill(DataSet dataSet)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Description");

            DataRow dr = dt.NewRow();

            dr[0] = "1";
            dr[1] = "Waleed";
            dr[2] = "Test";

            dt.Rows.Add(dr);
            dataSet.Tables.Add(dt);
            return 1;
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        }
    }
}
