using System.Linq;

namespace JS.UnityManager.App
{
    public interface IUnityProjectRepository
    {
        IQueryable<UnityProject> GetAll();
    }
}