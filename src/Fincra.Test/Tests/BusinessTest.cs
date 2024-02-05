using Fincra.SDK;

namespace Fincra.Test
{
	public class BusinessTest
	{
		private IFincraApi _api;

        [SetUp]
        public void Setup()
        {
            _api = FincraApiTest.Api;
        }

        [Test]
        public void GetBusinessProfile_ValidSecretKey_ReturnSuccess()
        {
            var result = _api.Business.GetBusinessId();

            // Assert
            Assert.IsInstanceOf<ApiResponse<BusinessProfileResponse>>(result);
            if(result.Success == true)
            {
                Assert.That(result.Success, Is.EqualTo(true));
                // Assert.That(result.Data.IsKYCApproved, Is.EqualTo(true));
                Assert.IsNotEmpty(result.Data.Name);
                Assert.IsNotEmpty(result.Data.BusinessTag);
            }
            else
            {
                Assert.That(result.Success, Is.EqualTo(false));
                Assert.IsNotEmpty(result.Error);
                Assert.IsNotEmpty(result.ErrorType);
            }

        }
    }
}

