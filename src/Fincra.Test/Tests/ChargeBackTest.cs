using Fincra.SDK;

namespace Fincra.Test
{
	public class ChargeBack
	{
        private IFincraApi _api;
        public dynamic BusinessProfile { get; set; }

        [SetUp]
        public void Setup()
        {
            _api = FincraApiTest.Api;
            BusinessProfile = _api.Business.GetBusinessId();
        }

        [Test]
        public void ListChargeBacks_ValidDetails_ReturnSuccess()
        {
            var result = _api.ChargeBacks.ListChargeBacks(BusinessProfile.Data.Id);

            // Assert
            Assert.IsInstanceOf<ApiResponseListData<dynamic>>(result);
            Assert.That(result.Success, Is.EqualTo(true));
            // Assert.GreaterOrEqual(result.Data.Count, 0);
        }
    }
}

