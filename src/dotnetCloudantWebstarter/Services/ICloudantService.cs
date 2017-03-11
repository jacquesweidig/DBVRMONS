using CloudantDotNet.Models;
using System.Threading.Tasks;

namespace CloudantDotNet.Services
{
    public interface ICloudantService
    {
        //Task<dynamic> CreateAsync(ToDoItem item);
        //Task<dynamic> DeleteAsync(ToDoItem item);
        //Task<dynamic> GetAllAsync();
        //Task PopulateTestData();
        //Task<string> UpdateAsync(ToDoItem item);


        Task<dynamic> CreateAsync(VREntryItem item);
        Task<dynamic> DeleteAsync(VREntryItem item);
        Task<dynamic> GetAllAsync();
        Task PopulateTestData();
        Task<string> UpdateAsync(VREntryItem item);
    }
}