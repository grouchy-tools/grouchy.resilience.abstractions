namespace Grouchy.Resilience.Abstractions.Retrying
{
   public interface IRetryManager
   {
      void Register(
         string policy,
         IRetryDelay retryDelay,
         IRetryPredicate retryPredicate);
      
      IRetryDelay GetDelay(string policy);

      IRetryPredicate GetPredicate(string policy);
   }
}