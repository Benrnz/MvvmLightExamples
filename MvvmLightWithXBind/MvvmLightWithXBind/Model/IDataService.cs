using System.Threading.Tasks;

namespace MvvmLight3.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}