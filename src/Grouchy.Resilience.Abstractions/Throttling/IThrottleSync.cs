using System.Threading.Tasks;

namespace Grouchy.Resilience.Abstractions.Throttling
{
   public interface IThrottleSync
   {
      Task WaitAsync();

      void Release();
   }
}
