using System;
using System.Collections.Generic;
using System.Linq;

namespace JS.UnityManager.App
{
    public class UnityProjectRepositoryTestData : IUnityProjectRepository
    {
        private readonly List<UnityProject> _projects;
        public UnityProjectRepositoryTestData()
        {
            _projects = new List<UnityProject>
            {
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Half Life 3"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Spoopy and Jeff, a skeltal adventure"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Duke Nukem Cooking Special"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Half Life 3"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Spoopy and Jeff, a skeltal adventure"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Duke Nukem Cooking Special"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Half Life 3"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Spoopy and Jeff, a skeltal adventure"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Duke Nukem Cooking Special"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Half Life 3"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Spoopy and Jeff, a skeltal adventure"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Duke Nukem Cooking Special"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Half Life 3"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Spoopy and Jeff, a skeltal adventure"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Duke Nukem Cooking Special"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Half Life 3"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Spoopy and Jeff, a skeltal adventure"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Duke Nukem Cooking Special"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Half Life 3"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Spoopy and Jeff, a skeltal adventure"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Duke Nukem Cooking Special"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Half Life 3"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Spoopy and Jeff, a skeltal adventure"},
                new UnityProject{ LastModified = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Duke Nukem Cooking Special"},
            };
        }
        public IQueryable<UnityProject> GetAll()
        {
            return _projects.AsQueryable();
        }
    }
}