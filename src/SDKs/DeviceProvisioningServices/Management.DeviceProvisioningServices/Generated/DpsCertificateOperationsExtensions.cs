// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceProvisioningServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DpsCertificateOperations.
    /// </summary>
    public static partial class DpsCertificateOperationsExtensions
    {
            /// <summary>
            /// Get the certificate from the provisioning service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateName'>
            /// Name of the certificate to retrieve.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group identifier.
            /// </param>
            /// <param name='provisioningServiceName'>
            /// Name of the provisioning service the certificate is associated with.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate.
            /// </param>
            public static CertificateResponse Get(this IDpsCertificateOperations operations, string certificateName, string resourceGroupName, string provisioningServiceName, string ifMatch = default(string))
            {
                return operations.GetAsync(certificateName, resourceGroupName, provisioningServiceName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the certificate from the provisioning service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateName'>
            /// Name of the certificate to retrieve.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group identifier.
            /// </param>
            /// <param name='provisioningServiceName'>
            /// Name of the provisioning service the certificate is associated with.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResponse> GetAsync(this IDpsCertificateOperations operations, string certificateName, string resourceGroupName, string provisioningServiceName, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(certificateName, resourceGroupName, provisioningServiceName, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upload the certificate to the provisioning service.
            /// </summary>
            /// <remarks>
            /// Add new certificate or update an existing certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group identifier.
            /// </param>
            /// <param name='provisioningServiceName'>
            /// The name of the provisioning service.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate create or update.
            /// </param>
            /// <param name='certificateDescription'>
            /// The certificate body.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate. This is required to update an existing
            /// certificate, and ignored while creating a brand new certificate.
            /// </param>
            public static CertificateResponse CreateOrUpdate(this IDpsCertificateOperations operations, string resourceGroupName, string provisioningServiceName, string certificateName, CertificateBodyDescription certificateDescription, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, provisioningServiceName, certificateName, certificateDescription, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upload the certificate to the provisioning service.
            /// </summary>
            /// <remarks>
            /// Add new certificate or update an existing certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group identifier.
            /// </param>
            /// <param name='provisioningServiceName'>
            /// The name of the provisioning service.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate create or update.
            /// </param>
            /// <param name='certificateDescription'>
            /// The certificate body.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate. This is required to update an existing
            /// certificate, and ignored while creating a brand new certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResponse> CreateOrUpdateAsync(this IDpsCertificateOperations operations, string resourceGroupName, string provisioningServiceName, string certificateName, CertificateBodyDescription certificateDescription, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, provisioningServiceName, certificateName, certificateDescription, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the Provisioning Service Certificate.
            /// </summary>
            /// <remarks>
            /// Deletes the specified certificate assosciated with the Provisioning Service
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate
            /// </param>
            /// <param name='provisioningServiceName'>
            /// The name of the provisioning service.
            /// </param>
            /// <param name='certificateName'>
            /// This is a mandatory field, and is the logical name of the certificate that
            /// the provisioning service will access by.
            /// </param>
            /// <param name='certificatename'>
            /// This is optional, and it is the Common Name of the certificate.
            /// </param>
            /// <param name='certificaterawBytes'>
            /// Raw data within the certificate.
            /// </param>
            /// <param name='certificateisVerified'>
            /// Indicates if certificate has been verified by owner of the private key.
            /// </param>
            /// <param name='certificatepurpose'>
            /// A description that mentions the purpose of the certificate. Possible values
            /// include: 'clientAuthentication', 'serverAuthentication'
            /// </param>
            /// <param name='certificatecreated'>
            /// Time the certificate is created.
            /// </param>
            /// <param name='certificatelastUpdated'>
            /// Time the certificate is last updated.
            /// </param>
            /// <param name='certificatehasPrivateKey'>
            /// Indicates if the certificate contains a private key.
            /// </param>
            /// <param name='certificatenonce'>
            /// Random number generated to indicate Proof of Possession.
            /// </param>
            public static void Delete(this IDpsCertificateOperations operations, string resourceGroupName, string ifMatch, string provisioningServiceName, string certificateName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string))
            {
                operations.DeleteAsync(resourceGroupName, ifMatch, provisioningServiceName, certificateName, certificatename, certificaterawBytes, certificateisVerified, certificatepurpose, certificatecreated, certificatelastUpdated, certificatehasPrivateKey, certificatenonce).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the Provisioning Service Certificate.
            /// </summary>
            /// <remarks>
            /// Deletes the specified certificate assosciated with the Provisioning Service
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate
            /// </param>
            /// <param name='provisioningServiceName'>
            /// The name of the provisioning service.
            /// </param>
            /// <param name='certificateName'>
            /// This is a mandatory field, and is the logical name of the certificate that
            /// the provisioning service will access by.
            /// </param>
            /// <param name='certificatename'>
            /// This is optional, and it is the Common Name of the certificate.
            /// </param>
            /// <param name='certificaterawBytes'>
            /// Raw data within the certificate.
            /// </param>
            /// <param name='certificateisVerified'>
            /// Indicates if certificate has been verified by owner of the private key.
            /// </param>
            /// <param name='certificatepurpose'>
            /// A description that mentions the purpose of the certificate. Possible values
            /// include: 'clientAuthentication', 'serverAuthentication'
            /// </param>
            /// <param name='certificatecreated'>
            /// Time the certificate is created.
            /// </param>
            /// <param name='certificatelastUpdated'>
            /// Time the certificate is last updated.
            /// </param>
            /// <param name='certificatehasPrivateKey'>
            /// Indicates if the certificate contains a private key.
            /// </param>
            /// <param name='certificatenonce'>
            /// Random number generated to indicate Proof of Possession.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDpsCertificateOperations operations, string resourceGroupName, string ifMatch, string provisioningServiceName, string certificateName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, ifMatch, provisioningServiceName, certificateName, certificatename, certificaterawBytes, certificateisVerified, certificatepurpose, certificatecreated, certificatelastUpdated, certificatehasPrivateKey, certificatenonce, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Generate verification code for Proof of Possession.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateName'>
            /// The mandatory logical name of the certificate, that the provisioning
            /// service uses to access.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate. This is required to update an existing
            /// certificate, and ignored while creating a brand new certificate.
            /// </param>
            /// <param name='resourceGroupName'>
            /// name of resource group.
            /// </param>
            /// <param name='provisioningServiceName'>
            /// Name of provisioning service.
            /// </param>
            /// <param name='certificatename'>
            /// Common Name for the certificate.
            /// </param>
            /// <param name='certificaterawBytes'>
            /// Raw data of certificate.
            /// </param>
            /// <param name='certificateisVerified'>
            /// Indicates if the certificate has been verified by owner of the private key.
            /// </param>
            /// <param name='certificatepurpose'>
            /// Description mentioning the purpose of the certificate. Possible values
            /// include: 'clientAuthentication', 'serverAuthentication'
            /// </param>
            /// <param name='certificatecreated'>
            /// Certificate creation time.
            /// </param>
            /// <param name='certificatelastUpdated'>
            /// Certificate last updated time.
            /// </param>
            /// <param name='certificatehasPrivateKey'>
            /// Indicates if the certificate contains private key.
            /// </param>
            /// <param name='certificatenonce'>
            /// Random number generated to indicate Proof of Possession.
            /// </param>
            public static VerificationCodeResponse GenerateVerificationCode(this IDpsCertificateOperations operations, string certificateName, string ifMatch, string resourceGroupName, string provisioningServiceName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string))
            {
                return operations.GenerateVerificationCodeAsync(certificateName, ifMatch, resourceGroupName, provisioningServiceName, certificatename, certificaterawBytes, certificateisVerified, certificatepurpose, certificatecreated, certificatelastUpdated, certificatehasPrivateKey, certificatenonce).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generate verification code for Proof of Possession.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateName'>
            /// The mandatory logical name of the certificate, that the provisioning
            /// service uses to access.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate. This is required to update an existing
            /// certificate, and ignored while creating a brand new certificate.
            /// </param>
            /// <param name='resourceGroupName'>
            /// name of resource group.
            /// </param>
            /// <param name='provisioningServiceName'>
            /// Name of provisioning service.
            /// </param>
            /// <param name='certificatename'>
            /// Common Name for the certificate.
            /// </param>
            /// <param name='certificaterawBytes'>
            /// Raw data of certificate.
            /// </param>
            /// <param name='certificateisVerified'>
            /// Indicates if the certificate has been verified by owner of the private key.
            /// </param>
            /// <param name='certificatepurpose'>
            /// Description mentioning the purpose of the certificate. Possible values
            /// include: 'clientAuthentication', 'serverAuthentication'
            /// </param>
            /// <param name='certificatecreated'>
            /// Certificate creation time.
            /// </param>
            /// <param name='certificatelastUpdated'>
            /// Certificate last updated time.
            /// </param>
            /// <param name='certificatehasPrivateKey'>
            /// Indicates if the certificate contains private key.
            /// </param>
            /// <param name='certificatenonce'>
            /// Random number generated to indicate Proof of Possession.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VerificationCodeResponse> GenerateVerificationCodeAsync(this IDpsCertificateOperations operations, string certificateName, string ifMatch, string resourceGroupName, string provisioningServiceName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateVerificationCodeWithHttpMessagesAsync(certificateName, ifMatch, resourceGroupName, provisioningServiceName, certificatename, certificaterawBytes, certificateisVerified, certificatepurpose, certificatecreated, certificatelastUpdated, certificatehasPrivateKey, certificatenonce, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Verify certificate's private key possession.
            /// </summary>
            /// <remarks>
            /// Verifies the certificate's private key possession by providing the leaf
            /// cert issued by the verifying pre uploaded certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateName'>
            /// The mandatory logical name of the certificate, that the provisioning
            /// service uses to access.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate.
            /// </param>
            /// <param name='request'>
            /// The name of the certificate
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='provisioningServiceName'>
            /// Provisioning service name.
            /// </param>
            /// <param name='certificatename'>
            /// Common Name for the certificate.
            /// </param>
            /// <param name='certificaterawBytes'>
            /// Raw data of certificate.
            /// </param>
            /// <param name='certificateisVerified'>
            /// Indicates if the certificate has been verified by owner of the private key.
            /// </param>
            /// <param name='certificatepurpose'>
            /// Describe the purpose of the certificate. Possible values include:
            /// 'clientAuthentication', 'serverAuthentication'
            /// </param>
            /// <param name='certificatecreated'>
            /// Certificate creation time.
            /// </param>
            /// <param name='certificatelastUpdated'>
            /// Certificate last updated time.
            /// </param>
            /// <param name='certificatehasPrivateKey'>
            /// Indicates if the certificate contains private key.
            /// </param>
            /// <param name='certificatenonce'>
            /// Random number generated to indicate Proof of Possession.
            /// </param>
            public static CertificateResponse VerifyCertificate(this IDpsCertificateOperations operations, string certificateName, string ifMatch, VerificationCodeRequest request, string resourceGroupName, string provisioningServiceName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string))
            {
                return operations.VerifyCertificateAsync(certificateName, ifMatch, request, resourceGroupName, provisioningServiceName, certificatename, certificaterawBytes, certificateisVerified, certificatepurpose, certificatecreated, certificatelastUpdated, certificatehasPrivateKey, certificatenonce).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Verify certificate's private key possession.
            /// </summary>
            /// <remarks>
            /// Verifies the certificate's private key possession by providing the leaf
            /// cert issued by the verifying pre uploaded certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateName'>
            /// The mandatory logical name of the certificate, that the provisioning
            /// service uses to access.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the certificate.
            /// </param>
            /// <param name='request'>
            /// The name of the certificate
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='provisioningServiceName'>
            /// Provisioning service name.
            /// </param>
            /// <param name='certificatename'>
            /// Common Name for the certificate.
            /// </param>
            /// <param name='certificaterawBytes'>
            /// Raw data of certificate.
            /// </param>
            /// <param name='certificateisVerified'>
            /// Indicates if the certificate has been verified by owner of the private key.
            /// </param>
            /// <param name='certificatepurpose'>
            /// Describe the purpose of the certificate. Possible values include:
            /// 'clientAuthentication', 'serverAuthentication'
            /// </param>
            /// <param name='certificatecreated'>
            /// Certificate creation time.
            /// </param>
            /// <param name='certificatelastUpdated'>
            /// Certificate last updated time.
            /// </param>
            /// <param name='certificatehasPrivateKey'>
            /// Indicates if the certificate contains private key.
            /// </param>
            /// <param name='certificatenonce'>
            /// Random number generated to indicate Proof of Possession.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResponse> VerifyCertificateAsync(this IDpsCertificateOperations operations, string certificateName, string ifMatch, VerificationCodeRequest request, string resourceGroupName, string provisioningServiceName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.VerifyCertificateWithHttpMessagesAsync(certificateName, ifMatch, request, resourceGroupName, provisioningServiceName, certificatename, certificaterawBytes, certificateisVerified, certificatepurpose, certificatecreated, certificatelastUpdated, certificatehasPrivateKey, certificatenonce, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}