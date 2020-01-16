using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLP.IService
{
    public interface IDataAccess<T> where T : class, new()
    {
        #region 新增实体

        long AddNewEntity(T entity);
        long AddNewEntity(T entity, IDbTransaction dbTransaction);
        bool AddNewEntityList(IEnumerable<T> entityList);

        #endregion
        #region 更新实体
        bool UpdateEntity(T entity);
        bool UpdateEntity(int id, object paras);
        bool UpdateEntity(T entity, IDbTransaction dbTransaction);
        bool UpdateEntityList(IEnumerable<T> entityList);
        #endregion

        #region 删除实体
        bool DeleteEntity(int id);
        bool DeleteEntity(T entity);
        bool DeleteEntity(T entity, IDbTransaction dbTransaction);
        bool DeleteEntityList(List<int> idList);
        bool DeleteEntityList(List<T> entityList);
        bool DeleteLogic(int id, object paras);

        #endregion

        #region 查询

        T Get(int id);
        List<T> GetList(T queryEntity);

        #endregion

    }
}
