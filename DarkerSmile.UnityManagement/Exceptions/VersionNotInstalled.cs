using System;

namespace DarkerSmile.UnityManagement
{
    public class VersionNotInstalled : Exception
    {
        public VersionNotInstalled(string version, string message) : base(message)
        {
            Version = version;
        }

        public string Version { get; }
    }

    public class VersionNotFound : Exception
    {
        public VersionNotFound(string version, string message) : base(message)
        {
            Version = version;
        }

        public string Version { get; }
    }
}