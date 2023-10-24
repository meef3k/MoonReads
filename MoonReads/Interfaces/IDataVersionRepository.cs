using MoonReads.Models;

namespace MoonReads.Interfaces
{
    public interface IDataVersionRepository
    {
        DataVersion GetDataVersion(string table);
        ICollection<DataVersion> GetDataVersions();
        bool CreateDataVersion(DataVersion dataVersion);
        bool UpdateDataVersion(DataVersion dataVersion);
        bool DeleteDataVersion(DataVersion dataVersion);
        bool DataVersionExists(string table);
        bool Save();
    }
}