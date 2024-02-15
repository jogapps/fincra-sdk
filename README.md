# Fincra.SDK.Dotnet

A community supported Dotnet SDK that enables developers to build fintech products securely and seamlessy leveraging [Fincra's](https://fincra.com/) API.

## Table of content

- [Getting Started](#getting-started)
- [Installation](#installation)
- [Usage](#usage)
- [Available Services exposed by the SDK](#available-services-exposed-by-the-sdk)

## Getting Started

- To get started with this SDK, create an [account](https://app.fincra.com/) on Fincra or a [sandbox account](https://sandbox.fincra.com/) if you haven't already.
- You can then retrieve your API keys from your [sandbox dashboard](https://sandbox.fincra.com/dashboard) or [account dashboard.](https://app.fincra.com/).


## Installation

Using `Nuget`,

```
Install-Package com.Fincra.SDK.Dotnet
```

## Usage

```
using Fincra.SDK;
```

Instantiate the Fincra class

```
string fincraSecretKey = GetEnvironmentVariable("FINCRA_SECRET_KEY");
bool IfSandbox = sandbox ? true : false;

FincraApi fincra = new FincraApi(fincraSecretKey, IfSandbox);
```

**Note:**

- The sandbox field is optional, if you don't specify it, it will default to true, else if false, it will be using the [production(live)](https://api.fincra.com/) API. For example:


- For more information about the services exposed by the SDK, please refer to the [documentation](https://docs.fincra.com/docs).
- Be sure to keep your API Credentials securely in [environment variables](https://www.twilio.com/blog/working-with-environment-variables-in-node-js-html).

## Available Services exposed by the SDK

The following services are available with this SDK

**1**. [**Business**](#1-business)

- [Get Business details](#get-business-details)

**2**. [**Beneficiaries**](#2-beneficiaries)

- [Create a beneficiary](#create-a-beneficiary)
- [Fetch a beneficiary](#fetch-beneficiaries)
- [List beneficiaries](#list-beneficiaries)
- [Update a beneficiary](#update-a-beneficiary)
- [Delete a beneficiary](#delete-a-beneficiary)

**3**. [**Chargebacks**](#3-chargebacks)

- [List chargebacks](#list-chargebacks)
- [Accept a chargeback](#accept-a-chargeback)
- [Reject a chargeback](#reject-a-chargeback)

**4**. [**Collections**](#4-collections)

- [Pay With Transfer](#pay-with-transfer)
- [List Collection for a main Virtual Account](#list-collection-for-a-main-virtual-account)
- [List Collection for Additional Virtual Accounts](#list-collection-for-additional-virtual-accounts)
- [Fetch a collection for an additional virtual account](#fetch-a-collection-for-an-additional-virtual-account)

**5**. [**Conversions**](#5-conversions)

- [Convert a currency](#convert-a-currency)
- [Fetch a conversion](#fetch-a-conversion)
- [List conversions](#list-conversions)

**6**. [**Payouts**](#6-payouts)

- [Wallet to wallet transfer](#wallet-to-wallet-transfer)
- [Create a Payout](#create-a-payout)
- [Upload a payout(transaction) document](#upload-transaction-document)
- [Fetch a payout by reference](#fetch-a-payout-by-reference)
- [Fetch a payout by Customer Reference](#fetch-a-payout-by-customer-reference)
- [List Banks](#list-banks)
- [List Payouts](#list-payouts)

**7**. [**Quotes**](#7-quotes)

- [Create a quote](#create-a-quote)

**8**. [**Verification**](#8-verification)

- [Verify account Number](#verify-account-number)
- [Verify Payment](#verify-payment)
- [Resolve BVN](#resolve-bvn)

**9**. [**Virtual-accounts**](#9-virtual-accounts)

- [Create a virtual account](#create-a-virtual-account)
- [List merchant virtual accounts](#list-merchant-virtual-accounts)
- [List virtual account requests](#list-virtual-account-requests)
- [Fetch a virtual account by currency](#fetch-a-virtual-account-by-currency)
- [Fetch a single virtual account](#fetch-a-single-virtual-account)
- [List Sub-account Virtual Accounts](#list-sub-account-virtual-accounts)
- [Deactivate a Virtual Account](#deactivate-a-virtual-account)

**10**. [**Wallets**](#10-wallets)

- [List wallets](#list-wallets)
- [List Wallet Logs](#list-wallet-logs)
<!-- add the business -->

### 1. Business

A business represents the merchant or any entity making use of this SDK.

#### Get business details

<!-- add a description -->

This method lets you retrieves the unique Identifier of your business and other information such as your email etc.

The unique identifier(businessId) allows your business to access other services.

```
var business = fincra.Business.getBusinessId();
```

### 2. Beneficiaries

The beneficiary’s service allows the business to create beneficiaries that can receive payments.

> **NOTE**: Beneficiaries and recipients are used interchangeably in this documentation.

#### Create a beneficiary

This method is used for creating a Beneficiary.

```
var request = new BeneficiaryRequest { ... };

var createBen = fincra.Beneficiary.CreateBeneficiary(BusinessId, request);
```

- More details about the parameters for the above method [here](https://docs.fincra.com/reference/create-a-beneficiary)

#### List beneficiaries

<!-- add a description -->

This method provides the ability to retrieve a list of beneficiaries attached to a business.

```
var listBen = fincra.Beneficiary.ListBeneficiaries(BusinessId, Page, PerPage);
```

#### Fetch beneficiaries

This method is used for retrieving a single beneficiary attached to a business.

```

var fetchBen = fincra.Beneficiary.FetchBeneficiary(BusinessId, BeneficiaryID);

```

#### Parameters supported

| **Parameters**  | **Data type** | **Required** | **Description**                 |
| --------------- | ------------- | ------------ | ------------------------------- |
| `BusinessId`    | string        | true         | The business unique identifier. |
| `BeneficiaryId` | string        | true         | The id of the beneficiary       |

#### Update a beneficiary

This method is used for updating a Beneficiary.

```

var request = new BeneficiaryRequest { ... };

var updateBen = fincra.Beneficiary.UpdateBeneficiary(BusinessId, BeneficiaryID, request);
```

- More details about the parameters for the above method [here](https://docs.fincra.com/reference/update-a-beneficiary)

#### Delete a beneficiary

This method is used for deleting a beneficiary.

```

var deleteBen = fincra.Beneficiary.DeleteBeneficiary(BusinessId, BeneficiaryID);
```

#### Parameters supported

| **Parameters**  | **Data type** | **Required** | **Description**                 |
| --------------- | ------------- | ------------ | ------------------------------- |
| `BusinessId`    | string`       | true         | The business unique identifier. |
| `BeneficiaryId` | string        | true         | The id of the beneficiary.      |

### 3. Chargebacks

The chargeback service.

#### List chargebacks

This method lets you list all the chargebacks incurred on your account.

```

var listCharge = fincra.Chargebacks.ListChargeBacks(BusinessId);

```

#### Parameters supported

| **Parameters** | **Data type** | **Required** | **Description**                 |
| -------------- | ------------- | ------------ | ------------------------------- |
| `BusinessId`   | string        | true         | The business unique identifier. |

#### Accept a chargeback

This method lets you accept a chargeback

```

var acceptCharge = fincra.Chargebacks.AcceptChargeBack(BusinessId, ChargeBackId);
```

#### Parameters supported

| **Parameters** | **Data type** | **Required** | **Description**                    |
| -------------- | ------------- | ------------ | ---------------------------------- |
| `BusinessId`   | string        | true         | The business unique identifier.    |
| `ChargeBackId` | string        | true         | The id of the specific chargeback. |

#### Reject a chargeback

This method lets you reject a chargeback

```

var request = new ChargeBackRequest { ... };

var rejectCharge = fincra.Chargebacks.RejectChargeBack(BusinessId, ChargeBackId, request);

```

#### Parameters supported

| Parameters     | Data type | Required | Description                       |
| -------------- | --------- | -------- | --------------------------------- |
| `BusinessId`   | `string`  | `true`   | `the business unique identifier`. |
| `ChargeBackId` | `string`  | `true`   | `the current page`                |
| `BusinessRejectReason`       | `string`  | `true`   | `the reason for the chargeback`   |

### 4. Collections

The Collections service enables you to perform actions such as viewing all deposits that come into your account etc.

#### `Pay With Transfer`

This method lets you create a temporary virtual account that can be used to receive payments over a period of time

```
var request = new PayWithTransferRequest { ... };

var payWithTransfer = fincra.Collection.PayWithTransfer(request);
```

#### Parameters supported

| **Parameters**      | **Data type** | **Required** | **Description**                                           |
| ------------------- | ------------- | ------------ | --------------------------------------------------------- |
| `ExpiresAt`         | string        | true         | The expiry of the virtual account in minutes.             |
| `Name`              | string        | false        | The name that should be on the account.                   |
| `MerchantReference` | string        | false        | The unique identifier of the transaction on your system . |

#### List Collection for a main Virtual Account

This service can be used to view both a single or multiple collections of a main virtual account

```
var request = new PayWithTransferRequest { ... };

var listCollection = fincra.Collection.ListCollectionMain(request);
```

#### Parameters supported

| **Parameters** | **Data type** | **Required** | **Description**                                  |
| -------------- | ------------- | ------------ | ------------------------------------------------ |
| `Business`     | string        | true         | The business unique identifier.                  |
| `Reference`    | string        | false        | The reference of the transaction.                |
| `Page`         | string        | false        | The current page.                                |
| `PerPage`      | string        | false        | The number of collections to be viewed per page. |

#### List Collection for Additional Virtual Accounts

This method is used for getting all collections of an additional virtual account for a business

```

var request = new CollectionParams { ... };

var listAdditional = fincra.Collection.ListCollectionAdditional(CollectionParams request);
```

#### Parameters supported

| **Parameters**        | **Data type** | **Required** | **Description**                                                         |
| --------------------- | ------------- | ------------ | ----------------------------------------------------------------------- |
| `Business`            | string        | true         | The business unique identifier.                                         |
| `Status`              | array         | true         | The status of the collection e.g ["processing", "failed", "successful]. |
| `SourceCurrency`      | string        | true         | The currency the payments was sent in.                                  |
| `DestinationCurrency` | string        | true         | The currency the recipient receives.                                    |
| `SubAccount`          | string        | true         | The ID of the subAccount.                                               |
| `Page`                | string        | false        | Specify exactly what page you want to retrieve.                         |
| `PerPage`             | string        | false        | How many records you want to retrieve per page.                         |
| `DateFrom`            | string        | true         | The start date. This must be in ISO 8601 date format(YYYY-MM-DD).       |
| `DateTo`              | string        | true         | The end date.This must be in ISO 8601 date format(YYYY-MM-DD).          |

#### Fetch a collection for an additional virtual account

This method is used for retrieving a single collection of an additional virtual account by a reference

```

var fetchCollection = fincra.Collection.FetchCollectionAddition(BusinessId, Reference);
```

#### Parameters supported

| **Parameters** | **Data type** | **Required** | **Description**                         |
| -------------- | ------------- | ------------ | --------------------------------------- |
| `Reference`    | string        | true         | The unique reference of the collection. |
| `Business`     | string        | false        | The business unique identifier.         |

### 5. Conversions

The Conversions service provides methods that can be used to initiate conversion between two different currencies and also fetch conversions previously generated.

#### Convert a currency

This method can convert one currency to another provided that it's a supported conversion currency e.g NGN to USD.

```
var request = new CreateConversionRequest { ... };

var createConvert = fincra.Conversion.CreateConversion(request);

```

#### Parameters supported

| **Parameters**   | **Data type** | **Required** | **Description**                                |
| ---------------- | ------------- | ------------ | ---------------------------------------------- |
| `Business`       | string        | true         | The business unique identifier.                |
| `QuoteReference` | string        | true         | This is the reference generated for the quote. |

#### Fetch a conversion

This method fetches a specific conversion performed by a parent Business or sub account.

```
var fetchConvert = fincra.Conversion.FetchConversion(ConversionId);

```

#### Parameters supported

| **Parameters** | **Data type** | **Required** | **Description**                  |
| -------------- | ------------- | ------------ | -------------------------------- |
| `ConversionId` | string        | true         | The id of a specific conversion. |

#### List conversions

This method provides a list of all conversions performed by a business.

```
var listBusinessConversions = fincra.Conversion.GetBusinessConversions(BusinessId);
```

#### Parameters supported

| **Parameters** | **Data type** | **Required** | **Description**                 |
| -------------- | ------------- | ------------ | ------------------------------- |
| `BusinessId`   | string        | true         | The business unique identifier. |

### 6. Payouts

The payout service can be used to initiate payouts to supported payment destinations.

#### Create a Payout

This method lets you make payouts to bank accounts and mobile money wallets

```

var request = new CreatePayoutRequest { ... };

var createPayout = fincra.Payouts.CreatePayout(request);

```

- More details about the parameters for the above method [here](https://docs.fincra.com/reference/payout-1)

#### Wallet to wallet transfer

This method lets you transfer funds from your wallet to the wallet of another user on our platform

```

var request = new WalletTransferRequest { ... };

var walletToWallet = fincra.Payouts.WalletToWalletTransfer(request);

```

#### Parameters Supported

| **Parameters**            | **Data type** | **Required** | **Description**                                                                  |
| ------------------------- | ------------- | ------------ | -------------------------------------------------------------------------------- |
| `Amount`                  | string        | true         | The value that is to be transferred from the source currency wallet.             |
| `Business`                | string        | true         | The business unique identifier.                                                  |
| `CustomerReference`       | string        | true         | The reference of the transaction.                                                |
| `Description`             | string        | true         | The purpose of payment.                                                          |
| `BeneficiaryWalletNumber` | string        | true         | This is the unique wallet number of the beneficiary you want to make payment to. |

#### List payouts

This method lets a business view all her payouts and that of her subaccounts

```

var request = new ListPayoutParams { ... };

var allPayout = fincra.Payouts.ListPayouts(request);
```

#### Parameters supported

| **Parameters**        | **Data type** | **Required** | **Description**                                                         |
| --------------------- | ------------- | ------------ | ----------------------------------------------------------------------- |
| `Business`            | string        | true         | The business unique identifier.                                         |
| `Status`              | array         | true         | The status of the collection e.g ["processing", "failed", "successful]. |
| `SourceCurrency`      | string        | true         | The currency the payments was sent in.                                  |
| `DestinationCurrency` | string        | true         | The currency the recipient receives.                                    |
| `SubAccount`          | string        | true         | The ID of the subAccount.                                               |
| `Page`                | string        | false        | Specify exactly what page you want to retrieve.                         |
| `PerPage`             | string        | false        | How many records you want to retrieve per page.                         |
| `DateFrom`            | string        | true         | The start date. This must be in ISO 8601 date format(YYYY-MM-DD).       |
| `DateTo`              | string        | true         | The end date.This must be in ISO 8601 date format(YYYY-MM-DD).          |

#### Upload transaction document

This method lets you process a payout that requires the upload of a document.

```

var request = new UploadTransactionDocumentRequest { ... };

var uploadPayout = fincra.Payouts.UploadTransactionDocument(request);

```

#### Parameters Supported

| **Parameters** | **Data type** | **Required** | **Description**                                                                                                                                                       |
| -------------- | ------------- | ------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Name`         | string        | true         | The name of the document.                                                                                                                                             |
| `Type`         | string        | true         | The type of document required to complete the transaction. After the payout has been initiated, this can be obtained from the response object of the payout response. |
| `Reference`    | string        | true         | This is the unique reference generated for the payout.                                                                                                                |
| `File`         | string        | true         | The document required encoded to a base64 format.                                                                                                                     |

#### Fetch a payout by reference

This method lets you retrieve and view a specific payout.

```

var fetchPayout = fincra.Payouts.FetchPayout(Reference);

```


#### Fetch a payout by Customer Reference

This method lets you retrieve and view a specific payout by the customer reference

```

var fetchCustomer = fincra.Payouts.FetchCustomerPayout(string CustomerReference);
```

#### Parameters Supported

| **Parameters**      | **Data type** | **Required** | **Description**                                     |
| ------------------- | ------------- | ------------ | --------------------------------------------------- |
| `CustomerReference` | string        | true         | The transaction's unique identifier on your system. |

#### List Banks

This method lets you view a list of banks and mobile money wallet providers, together with their details such as code, swiftCode, and Bic.

```
var banks = fincra.Payouts.ListBanks();
```

### 7. Quotes

The Quotes service provides a method that allows you to generate quotes for Real-time transactions occurring on your integration.

#### Create a quote

This method is used for generating a quote.

```

var request = new CreateQuoteRequest { ... };

var newQuote = fincra.Quote.CreateQuote(request);
```

#### Parameters Supported

| **Parameters**        | **Data type** | **Required** | **Description**                                                                                                                                                                     |
| --------------------- | ------------- | ------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Action`              | string        | true         | This value can only be "send" for conversions and disbursement.                                                                                                                     |
| `Amount`              | string        | true         | The amount you want to send or convert.                                                                                                                                             |
| `BeneficiaryType`     | string        | true         | The beneficiary type e.g individual or corporate. This is necessary in order to generate quotes for all African currencies.                                                         |
| `Business`            | string        | true         | This is the ID of the business.                                                                                                                                                     |
| `DestinationCurrency` | string        | true         | The currency in which the recipient will be receiving funds.                                                                                                                        |
| `FeeBearer`           | string        | true         | The bearer of the fees. it is usually one of conversion or business.                                                                                                                |
| `PaymentDestination`  | string        | true         | The payment destination. it is one of bank_accounts, fliqpay_wallet, mobile_money_wallet.                                                                                           |
| `PaymentScheme`       | string        | true         | This is the valid payment scheme for the destination currency you want to generate a quote for. This is only required when the transaction type is disbursement and not conversion. |
| `SourceCurrency`      | string        | true         | The currency which is used to fund a currency conversion or payout.                                                                                                                 |
| `TransactionType`     | string        | true         | The transaction type. It is usually one of conversion or disbursement.                                                                                                              |


### 8. Verification

This service lets you make kyc verification, payment verification, and account verification.

#### Verify account number

This method lets you verify a bank account.

```

var request = new VerifyBankAccountRequest { ... };

var verifyBank = fincra.Verify.VerifyBankAccount(request);
```

#### Parameters Supported

| **Parameters**  | **Data type** | **Required** | **Description**                                                                                        |
| --------------- | ------------- | ------------ | ------------------------------------------------------------------------------------------------------ |
| `AccountNumber` | string        | true         | The account number of the bank.                                                                        |
| `BankCode`      | string        | true         | The bank Code. This is required for NUBAN accounts.                                                    |
| `Type`          | string        | false        | The type of the account. It is either iban(international bank accounts) nuban(Nigerian bank accounts). |
| `Iban`          | string        | false        | The international bank account number. it is required when type is iban.                               |

#### Verify Payment

This method lets you verify the status of the transaction on the checkout API

```

var request = new VerifyPayment { ... };

var verifyPay = fincra.Verify.VerifyPayment(xBusinessId, Reference);
```

#### Resolve BVN

This method lets you verify a bank verification number(BVN)

```
var request = new ResolveBvn { ... };

var verifyBvn = fincra.Verify.ResolveBvn(request);
```

#### Parameters Supported

| **Parameters** | **Data type** | **Required** | **Description**                                                                  |
| -------------- | ------------- | ------------ | -------------------------------------------------------------------------------- |
| `Bvn`          | string        | true         | The bank verification number . Must be 11 digits.                                |
| `Business`     | string        | true         | The unique identifier or business ID of the parent business or it's sub account. |

### 9. Virtual Accounts

The Virtual account service allows the merchant to create and maintain a foreign currency account also known as the virtual account, which can be used to perform international transactions. Multiple virtual accounts can be requested for the same currency by a merchant.

#### Create a virtual account

This method lets you create a singlevirtual account.

```

var request = new CreateVirtualAccountRequest { ... };

var createVirtual = fincra.VirtualAccount.CreateVirtualAccount(request);

```

- More details about the parameters for the above method [here](https://docs.fincra.com/reference/request-virtual-accounts)


#### List merchant virtual accounts

This method fetches all virtual accounts belonging to a merchant

```

var request = new VirtualAccountParams { ... };

var listMerchant = fincra.VirtualAccount.ListMerchantVirtual(request);
```

#### Parameters Supported

| **Parameters**  | **Data type** | **Required** | **Description**                                                                                                                                               |
| --------------- | ------------- | ------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Currency`      | string        | true         | The virtual account currency.it is usually one of EUR, GPB or NGN.                                                                                            |
| `BusinessName`  | string        | true         | Specify the name of the business or subaccount you want to retrieve.                                                                                          |
| `IssuedDate`    | string        | false        | The date the virtual account was issued . It must be in ISO 8601 date format e.g 2020-07-10 15:00:00.000, which represents the 10th of July 2020 at 3 p.m.    |
| `RequestedDate` | string        | false        | The date the virtual account was requested . It must be in ISO 8601 date format e.g 2020-07-10 15:00:00.000, which represents the 10th of July 2020 at 3 p.m. |
| `AccountNumber` | string        | false        | The account number of the virtual account.                                                                                                                    |
| `Status`        | string        | false        | The status of the virtual account. It can be one of the following: approved, pending, or declined.                                                            |

#### List virtual account requests

This method is used for getting all virtual account requests belonging to a merchant

```
var virtualAccountRequests =
  fincra.VirtualAccount.ListVirtualAccountRequests();
```

#### Fetch a virtual account by currency

This method is used for retrieving a virtual account that is belongs to a merchant by currency

```
var fetchVirtualAccount =
  fincra.VirtualAccount.FetchVirtualAccountByCurrency(Currency);
```

#### Parameters Supported

| **Parameters** | **Data type** | **Required** | **Description**                                                    |
| -------------- | ------------- | ------------ | ------------------------------------------------------------------ |
| `Currency`     | string        | true         | The virtual account currency.it is usually one of EUR, GPB or NGN. |

#### Fetch a single virtual account

This method is used for retrieving a virtual account attached to a merchant.

```
var fetchSingle = fincra.VirtualAccount.FetchSingleVirtualAccount(VirtualAccountId);
```

#### Parameters Supported

| **Parameters**     | **Data type** | **Required** | **Description**                |
| ------------------ | ------------- | ------------ | ------------------------------ |
| `VirtualAccountId` | string        | true         | The ID of the virtual account. |

#### List Sub-account Virtual Accounts

This method allows you to get a list of virtual accounts that belongs to a subaccount.

```

var request = new VirtualAccountParams { ... };
var listSubVirtualAcct = await fincra.VirtualAccount.ListSubVirtualAccounts(request);
```

#### Parameters Supported

| **Parameters** | **Data type** | **Required** | **Description**                 |
| -------------- | ------------- | ------------ | ------------------------------- |
| `BusinessId`   | string        | true         | The ID of the parent business.  |
| `SubAccountId` | string        | true         | The ID of the subaccount.       |
| `Page`         | string        | false        | The page number.                |
| `PerPage`      | string        | false        | The number of records per page. |

#### Deactivate a Virtual Account

This method lets you de-activate a Naira(NGN) virtual account

```

var deactivated = fincra.VirtualAccount.DeactivateVirtualAccount(VirtualAccountId);
```

#### Parameters Supported

| **Parameters**     | **Data type** | **Required** | **Description**                |
| ------------------ | ------------- | ------------ | ------------------------------ |
| `VirtualAccountId` | string        | true         | The ID of the virtual account. |

### 10. Wallets

The wallet service consists of services that provide information such as account balances, wallet number of a wallet, or wallets for a business. With the wallet service, You can manage the account balance for your business and that of your subaccounts.

#### List wallets

This method lists all wallets belonging to a business.

```

var request = new WalletParams { ... };

var wallets = fincra.Wallet.ListWallet(request);
```

#### Parameters Supported

| **Parameters** | **Data type** | **Required** | **Description**         |
| -------------- | ------------- | ------------ | ----------------------- |
| `BusinessId`   | string        | true         | The ID of the business. |


#### List Wallet Logs

This method retreives the wallet logs of a merchant's wallet.

```

var request = new WalletLogParams { ... };
var walletLogs = fincra.Wallet.ListWalletLogs(request);
```

#### Parameters Supported

| **Parameters** | **Data type** | **Required** | **Description**                                                    |
| -------------- | ------------- | ------------ | ------------------------------------------------------------------ |
| `Business`     | string        | true         | The ID of the business.                                            |
| `Amount`       | string        | false        | The amount of the transaction.                                     |
| `Action`       | string        | false        | The action of the transaction.it is usually one of credit or debit |
| `Page`         | string        | false        | The page number.                                                   |
| `PerPage`      | string        | false        | The number of records per page.                                    |