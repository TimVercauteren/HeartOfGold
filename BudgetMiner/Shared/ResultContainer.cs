using BudgetMiner.Business.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BudgetMiner.Shared
{
    public class Result<TModel> where TModel : ModelBase
    {
        [JsonProperty("model")]
        public TModel Model { get; set; }
    }

    public class HalResult<TModel> where TModel : ModelBase
    {
        [JsonProperty("embedded")]
        public IEnumerable<TModel> Embedded { get; set; }
        [JsonProperty("page")]
        public Page Page { get; set; }
    }
}
