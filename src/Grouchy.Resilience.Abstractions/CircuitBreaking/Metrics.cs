using System.Collections.Generic;

namespace Grouchy.Resilience.Abstractions.CircuitBreaking
{
   public class Metrics
   {
      public IDictionary<string, int> SuccessResponses { get; } = new Dictionary<string, int>();

      public IDictionary<string, int> FailureResponses { get; } = new Dictionary<string, int>();

      public int Timeouts { get; set; }

      public int Exceptions { get; set; }
         
      public int Rejections { get; set; }
   }
}