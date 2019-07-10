﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Microsoft.Rest;

namespace Microsoft.Bot.Connector.Authentication
{
    /// <summary>
    /// CredentialProvider interface. This interface allows Bots to provide their own
    /// implementation of what is, and what is not, a valid appId and password. This is 
    /// useful in the case of multi-tenant bots, where the bot may need to call
    /// out to a service to determine if a particular appid/password pair
    /// is valid. 
    /// 
    /// For Single Tenant bots (the vast majority) the simple static providers 
    /// are sufficient. 
    /// </summary>
    public interface ICredentialProvider2 : ICredentialProvider
    {
        /// <summary>
        /// Get the credential necessary to provide identity/authorization to use
        /// </summary>
        /// <returns></returns>
        ServiceClientCredentials GetCredentials();
    }
}
