namespace Grouchy.Resilience.Abstractions.Retrying
{
   public interface IRetryDelay
   {
      int DelayMs(int retryAttempt);
   }
}