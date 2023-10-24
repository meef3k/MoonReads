using MoonReads.Data;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Repository
{
    public class DataVersionRepository : IDataVersionRepository
    {
        private readonly DataContext _context;

        public DataVersionRepository(DataContext context)
        {
            _context = context;
        }

        public DataVersion GetDataVersion(string table)
        {
            return _context.DataVersions.FirstOrDefault(d => d.Table == table)!;
        }
        
        public ICollection<DataVersion> GetDataVersions()
        {
            return _context.DataVersions.OrderBy(p => p.Id).ToList();
        }

        public bool CreateDataVersion(DataVersion dataVersion)
        {
            _context.Add(dataVersion);

            return Save();
        }

        public bool UpdateDataVersion(DataVersion dataVersion)
        {
            _context.Update(dataVersion);

            return Save();
        }

        public bool DeleteDataVersion(DataVersion dataVersion)
        {
            _context.Remove(dataVersion);

            return Save();
        }

        public bool DataVersionExists(string table)
        {
            return _context.DataVersions.Any(d => d.Table == table);
        }
        
        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0;
        }
    }
}