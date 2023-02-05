using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public interface IAmanatRepository
    {
        List<Table_Amanat> GetAllReports();
        IEnumerable<Table_Amanat> GetReportbyFilter(string parameter);
        Table_Amanat GetReportById(int ReportId);
        bool InsertReport(Table_Amanat Report);
        bool UpdateReport(Table_Amanat Report);
        bool DeleteReport(Table_Amanat Report);
        bool DeleteReport(int ReportId);
        
    }
}
