using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace AmazonClient
{
    public static class DataSetExtensions
    {
        public static DataSet ToDataSet<T>(this IEnumerable<T> source)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(source.ToDataTable("Results"));
            return ds;
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> source, string dataTableName)
        {
            Type objType = (typeof(T) == typeof(object) && source.Count() > 0) ? source.First().GetType() : typeof(T);

            DataTable dt = new DataTable(dataTableName);
            PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance |
                                                              BindingFlags.GetProperty);

            foreach (PropertyInfo property in properties)
                dt.Columns.Add(property.Name, property.PropertyType);

            foreach (T businessObject in source)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);

                foreach (PropertyInfo property in properties)
                    dr[property.Name] = property.GetValue(businessObject, null);
            }

            return dt;
        }
    }
}
