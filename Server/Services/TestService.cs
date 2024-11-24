using MagicOnion;
using MagicOnion.Server;
using Shared.Services;

#pragma warning disable CS1998 // 非同期メソッドは、'await' 演算子がないため、同期的に実行されます

namespace Server.Services;

public class TestService : ServiceBase<ITestService>, ITestService
{
    public async UnaryResult<int> SumAsync(int a, int b)
    {
        return a + b;
    }
}
