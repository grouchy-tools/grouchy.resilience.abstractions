namespace Grouchy.Resilience.Abstractions.CircuitBreaking
{
   public interface ICircuitBreakerPeriod
   {
      int PeriodMs { get; }
   }
}