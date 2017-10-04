using ArquiteturaASABusiness.Interfaces;
using ASArquiteruraData.DataContext;
using ASArquiteruraData.GenericRepositoryInterface;
using SqlBulkMerge.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SqlBulkMerge.Test.Models;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Data.Metadata.Edm;
using System.Linq.Expressions;
using System.Data.Objects.DataClasses;


namespace ASArquiteruraData.GenericRepository
{
   public class Repository<T> : IRepository<T> where T : class 
   {



       #region Properties
       protected ObjectContext Context { get; set; }

       protected IObjectSet<T> ObjectSet { get; set; }
     

       public Repository()
           : this(new ASAEntities())
       {
       }

       public Repository(ObjectContext context)
       {
           Context = context;
           ObjectSet = Context.CreateObjectSet<T>();
       }

       #endregion

       public IQueryable<T> GetQuery()
       {
           return ObjectSet;
       }

       public IEnumerable<T> GetAll()
       {
           return ObjectSet.AsEnumerable();
       }

       public IEnumerable<T> Find(Func<T, bool> where)
       {
           return ObjectSet.Where(where);
       }

       public T Single(Func<T, bool> where)
       {
           return ObjectSet.Single(where);
       }

       public T First(Func<T, bool> where)
       {
           return ObjectSet.First(where);
       }

       public void Delete(T entity)
       {
           if (entity == null)
           {
               throw new ArgumentException("entity");
           }

           var entityKey = Context.CreateEntityKey(EntitySetDictionary.GetEntityKey(entity), entity);

           Object attachedObject = new Object();

           if (Context.TryGetObjectByKey(entityKey, out attachedObject))
           {
               Context.DeleteObject(attachedObject);
           }
           else
           {
               throw new ObjectNotFoundException();
           }

           SaveChanges();
       }

       public void Add(T entity)
       {
           if (entity == null)
           {
               throw new ArgumentNullException("entity");
           }

           if (entity is IValidator)
           {
               ((IValidator)entity).Validate();
           }

           ObjectSet.AddObject(entity);

           SaveChanges();
       }
      
       #region UPSERT BULKIN "UPDATE | INSERT" COM C# E GENERICO
       // POR FAVOR SE NÃO SOUBER COMO FUNCIONA NÃO MEXA!!, FALE COMIGO. DESDE JÁ OBRIGADO POR NÃO FAZER BESTEIRA. MACONHA@asasys.com.br

       public void BulkUpSertList(List<T> list)
       {
           Type tipoEntidade = typeof(T);

           string entidade = tipoEntidade.Name;
           SqlConnection conn = new SqlConnection();
           conn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;" +
           "Initial Catalog=db_loja;" +
           "User id=sa;" +
           "Password=VQXsSf7Z1NKV.qXGZsX7Z1Be.;";

           BulkInsert<T>(conn.ConnectionString, entidade, list);
           SaveChanges();
       }

       public static void UpdateData<T>(List<T> list, string conn, string tabela)
       {
           //SqlConnection con = new SqlConnection(conn);
           //con.Open();
           //var bulk = new BulkOperation(con);
           //bulk.DestinationTableName = tabela;


           //using (var bulkCopy = new SqlBulkCopy(conn))
           //{
           //    var table = new DataTable();
           //    var props = TypeDescriptor.GetProperties(typeof(T))
           //                               .Cast<PropertyDescriptor>()
           //                               .Where(propertyInfo => propertyInfo.PropertyType.Namespace.Equals("System"))
           //                               .ToArray();

           //    foreach (var propertyInfo in props)
           //    {
           //        bulkCopy.ColumnMappings.Add(propertyInfo.Name, propertyInfo.Name);
           //        table.Columns.Add(propertyInfo.Name, Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType);
           //    }

           //    var values = new object[props.Length];
           //    foreach (var item in list)
           //    {
           //        for (var i = 0; i < values.Length; i++)
           //        {
           //            values[i] = props[i].GetValue(item);
           //        }

           //        table.Rows.Add(values);
           //    }
           //    bulk.BulkMerge(table);
             
           //}
       
       
       }
       
       #endregion
     
       #region NSERT LIST BULKIN COM C#
       //POR FAVOR SE NÃO SABE COMO FUNCIONA, NÃO MEXA FALE COMIGO!!! OBRIGADO

      
       public void AddAllList(IList<T> lis, bool deleteData)
       {
          
           Type tipoEntidade = typeof(T);
          
           string entidade = tipoEntidade.Name;
           SqlConnection conn = new SqlConnection();
           conn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;" +
           "Initial Catalog=db_loja;" +
           "User id=sa;" +
           "Password=VQXsSf7Z1NKV.qXGZsX7Z1Be.;";


           TESTE.staticfunc<T>(conn.ConnectionString, entidade, lis, deleteData);
                   SaveChanges();
             

           

       }
       public static void BulkInsert<T>(string connection, string tableName, IList<T> list)
       {
           
           using (var bulkCopy = new SqlBulkCopy(connection))
           {
           

               bulkCopy.BatchSize = list.Count;
               bulkCopy.DestinationTableName = tableName;

               var table = new DataTable();
               var props = TypeDescriptor.GetProperties(typeof(T))
                                          .Cast<PropertyDescriptor>()
                                          .Where(propertyInfo => propertyInfo.PropertyType.Namespace.Equals("System"))
                                          .ToArray();

               foreach (var propertyInfo in props)
               {
                   bulkCopy.ColumnMappings.Add(propertyInfo.Name, propertyInfo.Name);
                   table.Columns.Add(propertyInfo.Name, Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType);
               }

               var values = new object[props.Length];
               foreach (var item in list)
               {
                   for (var i = 0; i < values.Length; i++)
                   {
                       values[i] = props[i].GetValue(item);
                   }

                   table.Rows.Add(values);
               }

              
               bulkCopy.WriteToServer(table);


           }
       }
       
       #endregion
       
       public void Attach(T entity)
       {
           if (entity == null)
           {
               throw new ArgumentNullException("entity");
           }

           if (entity is IValidator)
           {
               ((IValidator)entity).Validate();
           }

           ObjectSet.Attach(entity);
       }

       public void Update(T entity)
       {
           var entityKey = Context.CreateEntityKey(EntitySetDictionary.GetEntityKey(entity), entity);

           Object attachedObject = new Object();

           if (Context.TryGetObjectByKey(entityKey, out attachedObject))
           {
               Context.ApplyCurrentValues(entityKey.EntitySetName, entity);
           }
           else
           {
               throw new ObjectNotFoundException();
           }

           SaveChanges();
       }

       public void SaveChanges()
       {
           Context.SaveChanges();
       }

       public void SaveChanges(SaveOptions saveOptions)
       {
           Context.SaveChanges(saveOptions);
       }

       public void Dispose()
       {
           Dispose(true);
           GC.SuppressFinalize(this);
       }

       protected virtual void Dispose(bool disposing)
       {
           if (disposing)
           {
               if (Context != null)
               {
                   Context.Dispose();
                   Context = null;
               }
           }
       }

        class TESTE : BaseBulkTest 
        {

            public static void staticfunc<T>(string connection, string tableName, IList<T> list, bool deleteData)
            {
                     TESTE Obj = new TESTE();
                     Obj.TestMethod1<T>(connection, tableName, list, deleteData);
                   }

           public void TestMethod1<T>(string connection, string tableName, IList<T> list,bool deleteData)
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
               return  lista.ToArray();
           }

       }



        public void Limpar(string tabela)
        {

            Context.ExecuteStoreCommand("DELETE FROM  " + tabela);
            GC.Collect();
          
            
        }
   }
}
