using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArquiteturaASABusiness;
using ASArquiteruraData.DataContext;
namespace ASArquiteruraData.GenericRepositoryInterface
{
   public interface IRepository<T> :IDisposable where T : class
    {
    
        
        IQueryable<T> GetQuery();
        /// <summary>
        /// Recupera do banco de dados todas as linhas da Tabela.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
       /// <summary>
       /// Recupera do banco as linhas da tabela que equivalem a clausula passada
       /// </summary>
       /// <param name="where"></param>
       /// <returns></returns>
        IEnumerable<T> Find(Func<T, bool> where);
        /// <summary>
        /// Recupera do banco umaunica linha da tabela que equivalem a clausula passada
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T Single(Func<T, bool> where);
        /// <summary>
        /// Recupera do banco a primeria linha da tabela que equivale a clausula passada
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T First(Func<T, bool> where);
        /// <summary>
        /// insere no banco uma lista ete metodo somente insere nao faz UPDATES passar uma lista celecionavel usando uma classe de tabela como colecao.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        void AddAllList(IList<T> lis, bool deleteData);
        /// <summary>
        /// deleta do banco o Objeto passado.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        void Limpar(string tabela);   
        /// <summary>
        /// deleta do banco o Objeto passado.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        void Delete(T entity);
        /// <summary>
        /// Adiciona no banco o Objeto passado.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        void Add(T entity);
        /// <summary>
        /// Altera no banco o Objeto passado.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        void Update(T entity);
        /// <summary>
        /// Salva as alteraçoes realizadas.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        void SaveChanges();
        void SaveChanges(SaveOptions saveOptions);
       /// <summary>
       ///  UpdateInsert este metodo verifica na lista o que deve ser UPDATE e o que deve ser INSERT passar uma lista.
       /// </summary>
       /// <param name="list"></param>
        void BulkUpSertList(List<T> list);
      
    }
}
