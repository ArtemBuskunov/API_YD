using API_Yandex_Direct.Get.Client;
using API_Yandex_Direct.Get.Shared;

namespace API_Yandex_Direct.Get
{
    public class GetClient : GetAbstract
    {
        public Model.Client[] GetClients(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        { return apiConnect.GetResult5(paramsRequest, "clients", "get", ref Headers).Clients; }

        public Model.Client[] GetClients(ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest(new FieldNamesEnum[] { FieldNamesEnum.ClientId, FieldNamesEnum.ClientInfo });
            return GetClients(paramsRequest, apiConnect);
        }
    }
}
