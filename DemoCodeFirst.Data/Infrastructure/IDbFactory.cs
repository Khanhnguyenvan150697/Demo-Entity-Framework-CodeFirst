using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Khởi tạo các đối tượng Entites
/// </summary>
namespace DemoCodeFirst.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DemoCodeFirstDbContext Init();
    }
}
