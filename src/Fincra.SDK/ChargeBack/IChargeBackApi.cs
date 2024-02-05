namespace Fincra.SDK
{
	public interface IChargeBackApi
	{
        ApiResponseListData<dynamic> ListChargeBacks(string BusinessId);
        ApiResponseListData<dynamic> AcceptChargeBack(string BusinessId, string ChargeBackId);
        ApiResponseListData<dynamic> RejectChargeBack(string BusinessId, string ChargeBackId, ChargeBackRequest request);
    }
}

