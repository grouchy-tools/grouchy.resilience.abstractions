namespace Grouchy.Resilience.Abstractions.Throttling
{
   public interface IThrottleManager
   {
      void Register(
         string policy,
         IThrottleSync throttleSync);
      
      IThrottleSync GetSync(string policy);
   }
}