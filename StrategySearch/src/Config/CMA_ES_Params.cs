namespace StrategySearch.Config
{
   class CMA_ES_Params
   {
      public int PopulationSize { get; set; }
      public int NumToEvaluate { get; set; }
      public int NumParents { get; set; }
      public double MutationPower { get; set; }
   }
}
