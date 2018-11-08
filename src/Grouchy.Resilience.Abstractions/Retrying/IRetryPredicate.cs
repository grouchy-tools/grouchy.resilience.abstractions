using System.Net.Http;

namespace Grouchy.Resilience.Abstractions.Retrying
{
   public interface IRetryPredicate
   {
      // TODO: Something needs to change here as Http has leaked into the abstraction
      bool ShouldRetry(int retryAttempt, HttpResponseMessage response);
   }
}
