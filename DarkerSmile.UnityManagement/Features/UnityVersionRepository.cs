using System.Collections.Generic;
using System.Linq;

namespace DarkerSmile.UnityManagement
{
    public class UnityVersionRepository : IUnityVersionRepository
    {
        public IEnumerable<UnityVersion> GetVersions() => _versions;

        public IEnumerable<UnityVersion> GetInstalledVersions()
        {
            return _versions.Where(x => x.Installed);
        }

        public void AddVersion(UnityVersion version)
        {
            var existing = _versions.FirstOrDefault(x => x.Version == version.Version);

            if (existing != null)
            {
                if (!existing.Installed && version.Installed)
                    existing.SetInstalledAt(version.InstallPath);
            }
            else
            {
                _versions.Add(version);
            }
        }

        public void Save()
        {
        }

        private readonly List<UnityVersion> _versions = new List<UnityVersion>();
    }
}