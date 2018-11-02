using System.Net.Http;

namespace Grouchy.Resilience.Abstractions.Retrying
{
   public interface IRetryPredicate
   {
      bool ShouldRetry(int retryAttempt, HttpResponseMessage response);
   }
}
