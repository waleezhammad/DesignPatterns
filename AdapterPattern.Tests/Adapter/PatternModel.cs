using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Tests.Adaptee
{
    public class PatternModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class PattenRendrer
    {
        private IPatternRenderAdapter _patternRender;
        public PattenRendrer(IPatternRenderAdapter patternAdapter)
        {
            _patternRender = patternAdapter;
        }
        public PattenRendrer() : this(new PatternRendersAdapter())
        {

        }
        public string ListPatterns(IEnumerable<PatternModel> patterns)
        {
            return _patternRender.ListPatterns(patterns);
        }
    }

    public interface IPatternRenderAdapter
    {
        string ListPatterns(IEnumerable<PatternModel> patterns);
    }

    public class PatternRendersAdapter : IPatternRenderAdapter
    {
        DataRender _dataRender;
        public PatternRendersAdapter()
        {

        }
        public string ListPatterns(IEnumerable<PatternModel> patterns)
        {
            PatternDataCollection col = new PatternDataCollection(patterns);
            _dataRender = new DataRender(col);

            StringWriter sw = new StringWriter();

            _dataRender.Render(sw);

            return sw.ToString();
        }
    }
    internal class PatternDataCollection : IDbDataAdapter
    {
        IEnumerable<PatternModel> _patterns;
        public PatternDataCollection(IEnumerable<PatternModel> patternModels)
        {
            _patterns = patternModels;
        }
        public int Fill(DataSet dataSet)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Description");


            foreach (var item in _patterns)
            {
                DataRow dr = dt.NewRow();

                dr[0] = item.Id;
                dr[1] = item.Name;
                dr[2] = item.Description;
                dt.Rows.Add(dr);
            }



            dataSet.Tables.Add(dt);
            return dt.Rows.Count;
        }

        #region Not Implemented functions
        public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new NotImplementedException();



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
        #endregion
    }

}
