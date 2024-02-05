using Fincra.SDK;

namespace Fincra.Test
{
    public class BeneficiaryTest
	{
        private IFincraApi _api;
        public dynamic BusinessProfile { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }


        [SetUp]
        public void Setup()
        {
            _api = FincraApiTest.Api;
            BusinessProfile = _api.Business.GetBusinessId();

            FirstName = Faker.Name.First();
            FullName = Faker.Name.FullName();
            Address = Faker.Address.StreetAddress();
        }

        [Test]
        public void CreateBeneficiary_ValidDetails_ReturnSuccess()
        {
            
            BeneficiaryRequest body = new BeneficiaryRequest
            {
                FirstName = FirstName,
                AccountHolderName = FullName,
                Type = "individual",
                Currency = "NGN",
                PaymentDestination = "bank_account",
                destinationAddress = Address,
                Bank = new Bank {
                    Name = FullName,
                
                },
                Address = new Address
                {
                   Country = "NG" 
                },
            };
            var result = _api.Beneficiary.CreateBeneficiary(BusinessProfile.Data.Id, body);

            // Assert
            Assert.IsInstanceOf<ApiResponse<BeneficiaryResponse>>(result);
            Assert.That(result.Success, Is.EqualTo(true));
            Assert.That(result.Data?.FirstName, Is.Not.Empty);
            Assert.IsNotEmpty(result.Data.AccountHolderName);
        }

        [Test]
        public void GetBeneficiary_ValidDetails_ReturnSuccess()
        {
            var result = _api.Beneficiary.ListBeneficiaries(BusinessProfile.Data.Id);

            // Assert
            Assert.IsInstanceOf<ApiResponseList<BeneficiaryResponse>>(result);
            Assert.That(result.Success, Is.EqualTo(true));
            Assert.NotZero(result.Data.Total);
        }

        [Test]
        public void GetBeneficiaryPagination_ValidDetails_ReturnSuccess()
        {
            var result = _api.Beneficiary.ListBeneficiaries(BusinessProfile.Data.Id, 1, 10);

            // Assert
            Assert.IsInstanceOf<ApiResponseList<BeneficiaryResponse>>(result);
            Assert.That(result.Success, Is.EqualTo(true));
            Assert.NotZero(result.Data.Total);
            Assert.AreEqual(result.Data.Results.Count, 10);
        }

        [Test]
        public void FetchBeneficiary_ValidDetails_ReturnSuccess()
        {
            ApiResponseList<BeneficiaryResponse> result = _api.Beneficiary.ListBeneficiaries(BusinessProfile.Data.Id, 1, 1);

            var benficiaryResult = _api.Beneficiary.FetchBeneficiary(BusinessProfile.Data.Id, result.Data.Results.First().Id);
            // Assert
            Assert.IsInstanceOf<ApiResponse<BeneficiaryResponse>>(benficiaryResult);
            Assert.That(benficiaryResult.Success, Is.EqualTo(true));
            Assert.IsNotEmpty(benficiaryResult.Data.Id);
        }

        [Test]
        public void UpdateBeneficiary_ValidDetails_ReturnSuccess()
        {
            BeneficiaryRequest body = new BeneficiaryRequest
            {
                FirstName = FirstName,
                AccountHolderName = FullName,
                Type = "individual",
                Currency = "NGN",
                PaymentDestination = "bank_account",
                destinationAddress = Address,
                Bank = new Bank
                {
                    Name = FullName,

                },
                Address = new Address
                {
                    Country = "NG"
                },
            };

            ApiResponseList<BeneficiaryResponse> result = _api.Beneficiary.ListBeneficiaries(BusinessProfile.Data.Id, 1, 1);

            ApiResponse<BeneficiaryResponse> benficiaryResult = _api.Beneficiary.FetchBeneficiary(BusinessProfile.Data.Id, result.Data.Results.First().Id);
            var updateResult = _api.Beneficiary.UpdateBeneficiary(BusinessProfile.Data.Id, benficiaryResult.Data.Id, body);

            // Assert
            Assert.IsInstanceOf<ApiResponse<BeneficiaryResponse>>(updateResult);
            Assert.That(updateResult.Success, Is.EqualTo(true));
            Assert.That(updateResult.Data.FirstName, Is.Not.Empty);
            Assert.IsNotEmpty(updateResult.Data.Id);
        }

        [Test]
        public void DeleteBeneficiary_ValidDetails_ReturnSuccess()
        {
            ApiResponseList<BeneficiaryResponse> result = _api.Beneficiary.ListBeneficiaries(BusinessProfile.Data.Id, 1, 1);

            var benficiaryResult = _api.Beneficiary.DeleteBeneficiary(BusinessProfile.Data.Id, result.Data.Results.First().Id);
            // Assert
            Assert.IsInstanceOf<ApiResponse<BeneficiaryResponse>>(benficiaryResult);
            Assert.That(benficiaryResult.Success, Is.EqualTo(true));
            Assert.IsNotEmpty(benficiaryResult.Data.Id);
        }
    }


}

