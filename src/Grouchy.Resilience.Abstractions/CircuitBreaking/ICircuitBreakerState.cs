using System;

namespace Grouchy.Resilience.Abstractions.CircuitBreaking
{
   public interface ICircuitBreakerState
   {
      double ClosedPct { get; }

      bool ShouldAccept();

      void LogSuccessResponse(string key = null);

      void LogFailureResponse(string key = null);

      void LogTimeout();

      void LogException(Exception exception);

      void LogWithheld();
   }
}