using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf.Meta;

namespace AgGateway.ADAPT.ADMPlugin.Protobuf.V1.FieldBoundaries
{
  public static class DrivenHeadlandType
  {
    public static void Configure(RuntimeTypeModel model)
    {
      var type = model.Add(typeof(AgGateway.ADAPT.ApplicationDataModel.FieldBoundaries.DrivenHeadland), Constants.UseDefaults);
      type.AddField(698, nameof(AgGateway.ADAPT.ApplicationDataModel.FieldBoundaries.DrivenHeadland.SpatialData));
    }
  }
}
