// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Backend Address of application gateway
    /// </summary>
    public partial class ApplicationGatewayBackendAddress
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendAddress
        /// class.
        /// </summary>
        public ApplicationGatewayBackendAddress() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendAddress
        /// class.
        /// </summary>
        public ApplicationGatewayBackendAddress(string fqdn = default(string), string ipAddress = default(string))
        {
            Fqdn = fqdn;
            IpAddress = ipAddress;
        }

        /// <summary>
        /// Gets or sets the dns name
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or sets the ip address
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

    }
}
