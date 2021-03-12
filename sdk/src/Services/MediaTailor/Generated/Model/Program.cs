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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Program configuration parameters.
    /// </summary>
    public partial class Program
    {
        private List<AdBreak> _adBreaks = new List<AdBreak>();
        private string _arn;
        private string _channelName;
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;
        private string _programName;
        private string _sourceLocationName;
        private string _vodSourceName;

        /// <summary>
        /// Gets and sets the property AdBreaks. 
        /// <para>
        /// The ad break configuration settings.
        /// </para>
        /// </summary>
        public List<AdBreak> AdBreaks
        {
            get { return this._adBreaks; }
            set { this._adBreaks = value; }
        }

        // Check to see if AdBreaks property is set
        internal bool IsSetAdBreaks()
        {
            return this._adBreaks != null && this._adBreaks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the program.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel that the program belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the program was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of when the program was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramName. 
        /// <para>
        /// The name of the program.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProgramName
        {
            get { return this._programName; }
            set { this._programName = value; }
        }

        // Check to see if ProgramName property is set
        internal bool IsSetProgramName()
        {
            return this._programName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceLocationName
        {
            get { return this._sourceLocationName; }
            set { this._sourceLocationName = value; }
        }

        // Check to see if SourceLocationName property is set
        internal bool IsSetSourceLocationName()
        {
            return this._sourceLocationName != null;
        }

        /// <summary>
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name that's used to refer to a VOD source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VodSourceName
        {
            get { return this._vodSourceName; }
            set { this._vodSourceName = value; }
        }

        // Check to see if VodSourceName property is set
        internal bool IsSetVodSourceName()
        {
            return this._vodSourceName != null;
        }

    }
}