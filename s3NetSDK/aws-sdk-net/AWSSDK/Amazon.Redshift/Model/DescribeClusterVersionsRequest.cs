/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterVersions operation.
    /// <para> Returns descriptions of the available Amazon Redshift cluster versions. You can call this operation even before creating any
    /// clusters to learn more about the Amazon Redshift versions. For more information about managing clusters, go to Amazon Redshift Clusters in
    /// the <i>Amazon Redshift Management Guide</i> </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.DescribeClusterVersions"/>
    public class DescribeClusterVersionsRequest : AmazonWebServiceRequest
    {
        private string clusterVersion;
        private string clusterParameterGroupFamily;
        private int? maxRecords;
        private string marker;

        /// <summary>
        /// The specific cluster version to return. Example: <c>1.0</c>
        ///  
        /// </summary>
        public string ClusterVersion
        {
            get { return this.clusterVersion; }
            set { this.clusterVersion = value; }
        }

        /// <summary>
        /// Sets the ClusterVersion property
        /// </summary>
        /// <param name="clusterVersion">The value to set for the ClusterVersion property </param>
        /// <returns>this instance</returns>
        public DescribeClusterVersionsRequest WithClusterVersion(string clusterVersion)
        {
            this.clusterVersion = clusterVersion;
            return this;
        }
            

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this.clusterVersion != null;
        }

        /// <summary>
        /// The name of a specific cluster parameter group family to return details for. Constraints: <ul> <li>Must be 1 to 255 alphanumeric
        /// characters</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul>
        ///  
        /// </summary>
        public string ClusterParameterGroupFamily
        {
            get { return this.clusterParameterGroupFamily; }
            set { this.clusterParameterGroupFamily = value; }
        }

        /// <summary>
        /// Sets the ClusterParameterGroupFamily property
        /// </summary>
        /// <param name="clusterParameterGroupFamily">The value to set for the ClusterParameterGroupFamily property </param>
        /// <returns>this instance</returns>
        public DescribeClusterVersionsRequest WithClusterParameterGroupFamily(string clusterParameterGroupFamily)
        {
            this.clusterParameterGroupFamily = clusterParameterGroupFamily;
            return this;
        }
            

        // Check to see if ClusterParameterGroupFamily property is set
        internal bool IsSetClusterParameterGroupFamily()
        {
            return this.clusterParameterGroupFamily != null;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more than the <c>MaxRecords</c> value is available, a marker is included in the
        /// response so that the following results can be retrieved. Default: <c>100</c> Constraints: Value must be at least 20 and no more than 100.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeClusterVersionsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// The marker returned from a previous request. If this parameter is specified, the response includes records beyond the marker only, up to
        /// <c>MaxRecords</c>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeClusterVersionsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
    
