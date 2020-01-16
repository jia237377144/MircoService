using Dapper;
using Dapper.Contrib.Extensions;
using JLP.IService;
using JLP.Module.WebSite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLP.Service
{
    public class AdInfoService : BaseService<ad_info>, IAdInfoService 
    {
        public AdInfoService(IDbConnection dbConnection) : base(dbConnection) { }
        public AdInfoService(string connStr) : base(connStr) { }
    }
}
