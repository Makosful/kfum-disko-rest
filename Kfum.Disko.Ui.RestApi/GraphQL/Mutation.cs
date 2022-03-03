using Kfum.Disko.Core.ApplicationServices.Interfaces;
using Kfum.Disko.Ui.RestApi.GraphQL.Inputs;
using Kfum.Disko.Ui.RestApi.GraphQL.Payloads;

namespace Kfum.Disko.Ui.RestApi.GraphQL;

public class Mutation
{
    public async Task<ArrangementPayload> ActiveStatus(ArrangementActiveInput input,
        [Service] IArrangementService service)
    {
        var arrangement = service.SetActiveStatus(input.Id, input.Active);

        return new ArrangementPayload(arrangement);
    }
}