using System.Threading;
using System.Threading.Tasks;

namespace Grouchy.Resilience.Abstractions.CircuitBreaking
{
   public interface ICircuitBreakerManager
   {
      void Register(
         string policy,
         ICircuitBreakerAnalyser circuitBreakerAnalyser,
         ICircuitBreakerOpeningRates circuitBreakerOpeningRates,
         ICircuitBreakerPeriod circuitBreakerPeriod);
      
      ICircuitBreakerState GetState(string policy);

      Task StopMonitoringAsync(CancellationToken cancellationToken);
   }
}