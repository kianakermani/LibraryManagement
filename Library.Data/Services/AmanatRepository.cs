using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public class AmanatRepository : IAmanatRepository
    {
        private library_DBEntities db;

        public AmanatRepository(library_DBEntities db)
        {
            this.db = db;
        }

        public bool DeleteReport(Table_Amanat Report)
        {
            try
            {
                db.Entry(Report).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteReport(int ReportId)
        {
            try
            {
                var Report = GetReportById(ReportId);
                DeleteReport(Report);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Table_Amanat> GetAllReports()
        {
            return db.Table_Amanat.ToList();
        }

        public IEnumerable<Table_Amanat> GetReportbyFilter(string parameter)
        {
            return db.Table_Amanat.Where(c => c.TitleBook.Contains(parameter) || c.Member.Contains(parameter)).ToList();
        }

        public Table_Amanat GetReportById(int ReportId)
        {
            return db.Table_Amanat.Find(ReportId);
        }

        public bool InsertReport(Table_Amanat Report)
        {
            try
            {
                db.Table_Amanat.Add(Report);
                return true;
            }
            catch
            {
                return false; 
            }
        }

        public bool UpdateReport(Table_Amanat Report)
        {
            try
            {
                var local = db.Set<Table_Amanat>()
                         .Local
                         .FirstOrDefault(f => f.Id == Report.Id);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(Report).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
