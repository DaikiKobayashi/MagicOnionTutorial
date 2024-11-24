using MagicOnion;

namespace Shared.Services;

public interface ITestService : IService<ITestService>
{
    public UnaryResult<int> SumAsync(int a, int b);
}
