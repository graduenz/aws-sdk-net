/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the AdminDeleteUserAttributes operation.
    /// Deletes the user attributes in a user pool as an administrator. Works on any user.
    /// 
    ///  
    /// <para>
    /// Calling this action requires developer credentials.
    /// </para>
    /// </summary>
    public partial class AdminDeleteUserAttributesRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<string> _userAttributeNames = new List<string>();
        private string _username;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property UserAttributeNames. 
        /// <para>
        /// An array of strings representing the user attribute names you wish to delete.
        /// </para>
        ///  
        /// <para>
        /// For custom attributes, you must prepend the <code>custom:</code> prefix to the attribute
        /// name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> UserAttributeNames
        {
            get { return this._userAttributeNames; }
            set { this._userAttributeNames = value; }
        }

        // Check to see if UserAttributeNames property is set
        internal bool IsSetUserAttributeNames()
        {
            return this._userAttributeNames != null && this._userAttributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name of the user from which you would like to delete attributes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool where you want to delete user attributes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}