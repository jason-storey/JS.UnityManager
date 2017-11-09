using System;

namespace DarkerSmile.UnityManagement
{
    public class ProjectCannotBeOpened : Exception
    {
        public ProjectCannotBeOpened(string message) : base(message)
        {
        }
    }
}