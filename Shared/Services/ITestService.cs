using MagicOnion;

namespace Shared.Services;

public interface ITestService : MagicOnion.IService<ITestService>
{
    public UnaryResult<int> AddAsync(int a, int b);
}
