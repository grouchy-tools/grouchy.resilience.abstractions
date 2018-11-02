namespace Grouchy.Resilience.Abstractions.CircuitBreaking
{
   public interface ICircuitBreakerOpeningRates
   {
      int[] OpeningRates { get; }
   }
}