using System.Collections.Generic;
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

      IEnumerable<ICircuitBreakerState> GetStates();

      Task StopMonitoringAsync(CancellationToken cancellationToken);
   }
}