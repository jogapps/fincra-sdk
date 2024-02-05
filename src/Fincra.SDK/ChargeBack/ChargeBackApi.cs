namespace Fincra.SDK
{
    public class ChargeBackApi : IChargeBackApi
    {
        private readonly FincraApi _api;
        public ChargeBackApi(FincraApi api)
        {
            _api = api;
        }

        public ApiResponseListData<dynamic> ListChargeBacks(string BusinessId)
        {
            return _api.Get<ApiResponseListData<dynamic>>($"{FincraRoutes.ChargeBack}?business={BusinessId}");
        }
        public ApiResponseListData<dynamic> AcceptChargeBack(string BusinessId, string ChargeBackId)
        {
            return _api.Patch<ApiResponseListData<dynamic>>($"{FincraRoutes.ChargeBack}/{ChargeBackId}/accept?business={BusinessId}", new {});
        }

        public ApiResponseListData<dynamic> RejectChargeBack(string BusinessId, string ChargeBackId, ChargeBackRequest request)
        {
            return _api.Patch<ApiResponseListData<dynamic>>($"{FincraRoutes.ChargeBack}/{ChargeBackId}/reject?business={BusinessId}", request);
        }
    }
}

