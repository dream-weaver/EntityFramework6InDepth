using CodeFirst.FluentAPI.Models;

namespace CodeFirst.Repository
{
    public interface ICourseRepository
    {
        void Add(Course course);
        void Update(int courseID);
        void Remove(int courseID);
    }
}
