using ShabirAPI.Classes;

namespace ShabirAPI.Interfaces
{
    public interface ISchoolRepository
    {
        string GetSchoolName();
        List<Author> GetAllList();
        string GetNameByBook(string book);
    }
}
