using System;

namespace Demo
{
    public interface IRepositoryTransaction : IDisposable
    {
        void Commit();
    }
}
