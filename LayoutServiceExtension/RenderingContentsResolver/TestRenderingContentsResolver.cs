using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering.ContentsResolvers;
using Sitecore.Mvc.Presentation;

namespace LayoutServiceExtension.RenderingContentsResolver
{  
  public class TestRenderingContentsResolver : Sitecore.LayoutService.ItemRendering.ContentsResolvers.RenderingContentsResolver
  {
    public override object ResolveContents(Rendering rendering, IRenderingConfiguration renderingConfig)
    {
      // here to get custom data from third-party data source
      // below is the anonymous object to construct with the custom data
      var customData = new
      {
        property1 = "property value 1",
        property2 = "property value 2",
        property3 = DateTime.Now
      };

      object json = base.ResolveContents(rendering, renderingConfig);

      // wrapping both: ootb and custom data into one anonymous object
      return new { fromContentResolver = json, customData = customData };
    }

  }
}