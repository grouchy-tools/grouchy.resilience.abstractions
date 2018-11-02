using System.Collections.Generic;

namespace Grouchy.Resilience.Abstractions.CircuitBreaking
{
   public interface ICircuitBreakerAnalyser
   {
      Rating Analyse(IEnumerable<Metrics> recentMetrics);
   }
}