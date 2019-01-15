using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf.Meta;

namespace AgGateway.ADAPT.ADMPlugin.Protobuf.V2.Documents
{
  public static class WorkOrderType
  {
    public static void Configure(RuntimeTypeModel model)
    {
      var type = model.Add(typeof(AgGateway.ADAPT.ApplicationDataModel.Documents.WorkOrder), Constants.UseDefaults);
      type.AddField(1, nameof(AgGateway.ADAPT.ApplicationDataModel.Documents.WorkOrder.StatusUpdates));
      type.AddField(2, nameof(AgGateway.ADAPT.ApplicationDataModel.Documents.WorkOrder.WorkItemIds));
    }
  }
}
