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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the RespondActivityTaskCompleted operation.
    /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> completed successfully with a
    /// <c>result</c> (if provided). The <c>result</c> appears in the <c>ActivityTaskCompleted</c> event in the workflow history. </para>
    /// <para><b>IMPORTANT:</b> If the requested task does not complete successfully, use RespondActivityTaskFailed instead. If the worker finds
    /// that the task is canceled through the canceled flag returned by RecordActivityTaskHeartbeat, it should cancel the task, clean up and then
    /// call RespondActivityTaskCanceled. </para> <para> A task is considered open from the time that it is scheduled until it is closed. Therefore
    /// a task is reported as open while a worker is processing it. A task is closed after it has been specified in a call to
    /// RespondActivityTaskCompleted, RespondActivityTaskCanceled, RespondActivityTaskFailed, or the task has timed out. </para> <para> <b>Access
    /// Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see Using IAM to Manage
    /// Access to Amazon SWF Workflows.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.RespondActivityTaskCompleted"/>
    public class RespondActivityTaskCompletedRequest : AmazonWebServiceRequest
    {
        private string taskToken;
        private string result;

        /// <summary>
        /// The <c>taskToken</c> of the <a>ActivityTask</a>. <important> The <c>taskToken</c> is generated by the service and should be treated as an
        /// opaque value. If the task is passed to another process, its <c>taskToken</c> must also be passed. This enables it to provide its progress
        /// and respond with results. </important>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TaskToken
        {
            get { return this.taskToken; }
            set { this.taskToken = value; }
        }

        /// <summary>
        /// Sets the TaskToken property
        /// </summary>
        /// <param name="taskToken">The value to set for the TaskToken property </param>
        /// <returns>this instance</returns>
        public RespondActivityTaskCompletedRequest WithTaskToken(string taskToken)
        {
            this.taskToken = taskToken;
            return this;
        }
            

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this.taskToken != null;
        }

        /// <summary>
        /// The result of the activity task. It is a free form string that is implementation specific.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// Sets the Result property
        /// </summary>
        /// <param name="result">The value to set for the Result property </param>
        /// <returns>this instance</returns>
        public RespondActivityTaskCompletedRequest WithResult(string result)
        {
            this.result = result;
            return this;
        }
            

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this.result != null;
        }
    }
}
    
