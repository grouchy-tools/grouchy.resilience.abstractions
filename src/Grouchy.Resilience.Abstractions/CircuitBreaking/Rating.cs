namespace Grouchy.Resilience.Abstractions.CircuitBreaking
{
   public enum Rating
   {
      Hold = 0,
      Trip = 1,
      Reset = 2
   }
}