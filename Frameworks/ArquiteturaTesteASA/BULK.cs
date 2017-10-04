using SqlBulkMerge.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ArquiteturaTesteASA
{
   public class BULK
    {
      public class TESTE : BaseBulkTest
        {

          public static void staticfunc<T>(string connection, string tableName, IList<T> list, bool deleteData)
            {
                TESTE Obj = new TESTE();
                Obj.TestMethod1<T>(connection, tableName, list,  deleteData);
            }
               
            public void TestMethod1<T>(string connection, string tableName, IList<T> list, bool deleteData)
            {


                using (var bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.BatchSize = list.Count;
                    bulkCopy.DestinationTableName = tableName;

                    var props = TypeDescriptor.GetProperties(typeof(T))
                                               .Cast<PropertyDescriptor>()
                                               .Where(propertyInfo => propertyInfo.PropertyType.Namespace.Equals("System"))
                                               .ToArray();


                    this.connection.Merge(tableName, list, (r, row) =>
                    {

                        var values = new object[props.Length];
                        foreach (var item in list)
                        {
                            for (var i = 0; i < values.Length; i++)
                            {
                                try
                                {
                                    row[i] = props[i].GetValue(item);


                                }
                                catch
                                {

                                    row[i] = DBNull.Value;
                                }

                            }


                        }



                    }, GetPK(tableName), list, deleteData);


                }


            }


            public string[] GetPK(string tabela)
            {
                SqlCommand cmd;
                SqlDataReader dr;
                SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=db_loja;User ID=sa;Password=VQXsSf7Z1NKV.qXGZsX7Z1Be.;");




                cmd = new SqlCommand("spGetPKK", connection);
                cmd.Parameters.AddWithValue("@tabela", tabela);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();
                List<string> lista = new List<string>();
                while (dr.Read())
                {
                    lista.Add(dr["COLUMN_NAME"].ToString());

                }
                return lista.ToArray();
            }

        }
    }
}
