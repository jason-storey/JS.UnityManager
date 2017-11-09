using System.Collections.Generic;

namespace DarkerSmile.UnityManagement
{
    public interface IUnityVersionRepository
    {
        IEnumerable<UnityVersion> GetVersions();

        IEnumerable<UnityVersion> GetInstalledVersions();

        void AddVersion(UnityVersion version);


        void Save();
    }
}