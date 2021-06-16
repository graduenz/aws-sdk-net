/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the AssociateTrunkInterface operation.
    /// </summary>
    public partial class AssociateTrunkInterfaceResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private TrunkInterfaceAssociation _interfaceAssociation;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How
        /// to Ensure Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InterfaceAssociation. 
        /// <para>
        /// Information about the association between the trunk network interface and branch network
        /// interface.
        /// </para>
        /// </summary>
        public TrunkInterfaceAssociation InterfaceAssociation
        {
            get { return this._interfaceAssociation; }
            set { this._interfaceAssociation = value; }
        }

        // Check to see if InterfaceAssociation property is set
        internal bool IsSetInterfaceAssociation()
        {
            return this._interfaceAssociation != null;
        }

    }
}