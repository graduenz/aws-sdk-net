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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLocationHdfs operation.
    /// Creates an endpoint for a Hadoop Distributed File System (HDFS).
    /// </summary>
    public partial class CreateLocationHdfsRequest : AmazonDataSyncRequest
    {
        private List<string> _agentArns = new List<string>();
        private HdfsAuthenticationType _authenticationType;
        private int? _blockSize;
        private MemoryStream _kerberosKeytab;
        private MemoryStream _kerberosKrb5Conf;
        private string _kerberosPrincipal;
        private string _kmsKeyProviderUri;
        private List<HdfsNameNode> _nameNodes = new List<HdfsNameNode>();
        private QopConfiguration _qopConfiguration;
        private int? _replicationFactor;
        private string _simpleUser;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the agents that are used to connect to the HDFS
        /// cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && this._agentArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication used to determine the identity of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HdfsAuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property BlockSize. 
        /// <para>
        /// The size of data blocks to write into the HDFS cluster. The block size must be a multiple
        /// of 512 bytes. The default block size is 128 mebibytes (MiB).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1048576, Max=1073741824)]
        public int BlockSize
        {
            get { return this._blockSize.GetValueOrDefault(); }
            set { this._blockSize = value; }
        }

        // Check to see if BlockSize property is set
        internal bool IsSetBlockSize()
        {
            return this._blockSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KerberosKeytab. 
        /// <para>
        /// The Kerberos key table (keytab) that contains mappings between the defined Kerberos
        /// principal and the encrypted keys. You can load the keytab from a file by providing
        /// the file's address. If you're using the CLI, it performs base64 encoding for you.
        /// Otherwise, provide the base64-encoded text. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>KERBEROS</code> is specified for <code>AuthenticationType</code>, this parameter
        /// is required. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=65536)]
        public MemoryStream KerberosKeytab
        {
            get { return this._kerberosKeytab; }
            set { this._kerberosKeytab = value; }
        }

        // Check to see if KerberosKeytab property is set
        internal bool IsSetKerberosKeytab()
        {
            return this._kerberosKeytab != null;
        }

        /// <summary>
        /// Gets and sets the property KerberosKrb5Conf. 
        /// <para>
        /// The <code>krb5.conf</code> file that contains the Kerberos configuration information.
        /// You can load the <code>krb5.conf</code> file by providing the file's address. If you're
        /// using the CLI, it performs the base64 encoding for you. Otherwise, provide the base64-encoded
        /// text. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>KERBEROS</code> is specified for <code>AuthenticationType</code>, this parameter
        /// is required.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=131072)]
        public MemoryStream KerberosKrb5Conf
        {
            get { return this._kerberosKrb5Conf; }
            set { this._kerberosKrb5Conf = value; }
        }

        // Check to see if KerberosKrb5Conf property is set
        internal bool IsSetKerberosKrb5Conf()
        {
            return this._kerberosKrb5Conf != null;
        }

        /// <summary>
        /// Gets and sets the property KerberosPrincipal. 
        /// <para>
        /// The Kerberos principal with access to the files and folders on the HDFS cluster. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>KERBEROS</code> is specified for <code>AuthenticationType</code>, this parameter
        /// is required.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string KerberosPrincipal
        {
            get { return this._kerberosPrincipal; }
            set { this._kerberosPrincipal = value; }
        }

        // Check to see if KerberosPrincipal property is set
        internal bool IsSetKerberosPrincipal()
        {
            return this._kerberosPrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyProviderUri. 
        /// <para>
        /// The URI of the HDFS cluster's Key Management Server (KMS). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string KmsKeyProviderUri
        {
            get { return this._kmsKeyProviderUri; }
            set { this._kmsKeyProviderUri = value; }
        }

        // Check to see if KmsKeyProviderUri property is set
        internal bool IsSetKmsKeyProviderUri()
        {
            return this._kmsKeyProviderUri != null;
        }

        /// <summary>
        /// Gets and sets the property NameNodes. 
        /// <para>
        /// The NameNode that manages the HDFS namespace. The NameNode performs operations such
        /// as opening, closing, and renaming files and directories. The NameNode contains the
        /// information to map blocks of data to the DataNodes. You can use only one NameNode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<HdfsNameNode> NameNodes
        {
            get { return this._nameNodes; }
            set { this._nameNodes = value; }
        }

        // Check to see if NameNodes property is set
        internal bool IsSetNameNodes()
        {
            return this._nameNodes != null && this._nameNodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QopConfiguration. 
        /// <para>
        /// The Quality of Protection (QOP) configuration specifies the Remote Procedure Call
        /// (RPC) and data transfer protection settings configured on the Hadoop Distributed File
        /// System (HDFS) cluster. If <code>QopConfiguration</code> isn't specified, <code>RpcProtection</code>
        /// and <code>DataTransferProtection</code> default to <code>PRIVACY</code>. If you set
        /// <code>RpcProtection</code> or <code>DataTransferProtection</code>, the other parameter
        /// assumes the same value. 
        /// </para>
        /// </summary>
        public QopConfiguration QopConfiguration
        {
            get { return this._qopConfiguration; }
            set { this._qopConfiguration = value; }
        }

        // Check to see if QopConfiguration property is set
        internal bool IsSetQopConfiguration()
        {
            return this._qopConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationFactor. 
        /// <para>
        /// The number of DataNodes to replicate the data to when writing to the HDFS cluster.
        /// By default, data is replicated to three DataNodes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public int ReplicationFactor
        {
            get { return this._replicationFactor.GetValueOrDefault(); }
            set { this._replicationFactor = value; }
        }

        // Check to see if ReplicationFactor property is set
        internal bool IsSetReplicationFactor()
        {
            return this._replicationFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SimpleUser. 
        /// <para>
        /// The user name used to identify the client on the host operating system. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>SIMPLE</code> is specified for <code>AuthenticationType</code>, this parameter
        /// is required. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SimpleUser
        {
            get { return this._simpleUser; }
            set { this._simpleUser = value; }
        }

        // Check to see if SimpleUser property is set
        internal bool IsSetSimpleUser()
        {
            return this._simpleUser != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory in the HDFS cluster. This subdirectory is used to read data from or
        /// write data to the HDFS cluster. If the subdirectory isn't specified, it will default
        /// to <code>/</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents the tag that you want to add to the location. The
        /// value can be an empty string. We recommend using tags to name your resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}