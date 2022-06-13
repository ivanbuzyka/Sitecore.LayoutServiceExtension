using Sitecore.LayoutService.ItemRendering.Pipelines.GetLayoutServiceContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutServiceExtension.Pipelines.GetLayoutServiceContext
{
  public class TestContextExtension : Sitecore.LayoutService.ItemRendering.Pipelines.GetLayoutServiceContext.IGetLayoutServiceContextProcessor
  {
    public void Process(GetLayoutServiceContextArgs args)
    {
      if (args.ContextData.ContainsKey("thirdpartyDataOne")) {
        return;
      }

      args.ContextData.Add("thirdpartyDataOne", new
      {
        property1 = "This data should come from third party source",
        property2 = "Another third-party data"
      });
    }
  }
}