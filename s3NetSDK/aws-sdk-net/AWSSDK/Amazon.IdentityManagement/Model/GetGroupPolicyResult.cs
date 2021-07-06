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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the GetGroupPolicy action.</para>
    /// </summary>
    public class GetGroupPolicyResult  
    {
        
        private string groupName;
        private string policyName;
        private string policyDocument;

        /// <summary>
        /// The group the policy is associated with.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        /// <summary>
        /// Sets the GroupName property
        /// </summary>
        /// <param name="groupName">The value to set for the GroupName property </param>
        /// <returns>this instance</returns>
        public GetGroupPolicyResult WithGroupName(string groupName)
        {
            this.groupName = groupName;
            return this;
        }
            

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;       
        }

        /// <summary>
        /// The name of the policy.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        /// <summary>
        /// Sets the PolicyName property
        /// </summary>
        /// <param name="policyName">The value to set for the PolicyName property </param>
        /// <returns>this instance</returns>
        public GetGroupPolicyResult WithPolicyName(string policyName)
        {
            this.policyName = policyName;
            return this;
        }
            

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;       
        }

        /// <summary>
        /// The policy document.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 131072</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this.policyDocument; }
            set { this.policyDocument = value; }
        }

        /// <summary>
        /// Sets the PolicyDocument property
        /// </summary>
        /// <param name="policyDocument">The value to set for the PolicyDocument property </param>
        /// <returns>this instance</returns>
        public GetGroupPolicyResult WithPolicyDocument(string policyDocument)
        {
            this.policyDocument = policyDocument;
            return this;
        }
            

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this.policyDocument != null;       
        }
    }
}
