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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Provides details of the <c>SignalExternalWorkflowExecutionFailed</c> event. </para>
    /// </summary>
    public class SignalExternalWorkflowExecutionFailedEventAttributes
    {
        
        private string workflowId;
        private string runId;
        private string cause;
        private long? initiatedEventId;
        private long? decisionTaskCompletedEventId;
        private string control;

        /// <summary>
        /// The <c>workflowId</c> of the external workflow execution that the signal was being delivered to.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string WorkflowId
        {
            get { return this.workflowId; }
            set { this.workflowId = value; }
        }

        /// <summary>
        /// Sets the WorkflowId property
        /// </summary>
        /// <param name="workflowId">The value to set for the WorkflowId property </param>
        /// <returns>this instance</returns>
        public SignalExternalWorkflowExecutionFailedEventAttributes WithWorkflowId(string workflowId)
        {
            this.workflowId = workflowId;
            return this;
        }
            

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this.workflowId != null;
        }

        /// <summary>
        /// The <c>runId</c> of the external workflow execution that the signal was being delivered to.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RunId
        {
            get { return this.runId; }
            set { this.runId = value; }
        }

        /// <summary>
        /// Sets the RunId property
        /// </summary>
        /// <param name="runId">The value to set for the RunId property </param>
        /// <returns>this instance</returns>
        public SignalExternalWorkflowExecutionFailedEventAttributes WithRunId(string runId)
        {
            this.runId = runId;
            return this;
        }
            

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this.runId != null;
        }

        /// <summary>
        /// The cause of the failure to process the decision. This information is generated by the system and can be useful for diagnostic purposes.
        /// <note>If <b>cause</b> is set to OPERATION_NOT_PERMITTED, the decision failed because it lacked sufficient permissions. For details and
        /// example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access
        /// to Amazon SWF Workflows</a>.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>UNKNOWN_EXTERNAL_WORKFLOW_EXECUTION, SIGNAL_EXTERNAL_WORKFLOW_EXECUTION_RATE_EXCEEDED, OPERATION_NOT_PERMITTED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Cause
        {
            get { return this.cause; }
            set { this.cause = value; }
        }

        /// <summary>
        /// Sets the Cause property
        /// </summary>
        /// <param name="cause">The value to set for the Cause property </param>
        /// <returns>this instance</returns>
        public SignalExternalWorkflowExecutionFailedEventAttributes WithCause(string cause)
        {
            this.cause = cause;
            return this;
        }
            

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this.cause != null;
        }

        /// <summary>
        /// The id of the <c>SignalExternalWorkflowExecutionInitiated</c> event corresponding to the <c>SignalExternalWorkflowExecution</c> decision to
        /// request this signal. This information can be useful for diagnosing problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long InitiatedEventId
        {
            get { return this.initiatedEventId ?? default(long); }
            set { this.initiatedEventId = value; }
        }

        /// <summary>
        /// Sets the InitiatedEventId property
        /// </summary>
        /// <param name="initiatedEventId">The value to set for the InitiatedEventId property </param>
        /// <returns>this instance</returns>
        public SignalExternalWorkflowExecutionFailedEventAttributes WithInitiatedEventId(long initiatedEventId)
        {
            this.initiatedEventId = initiatedEventId;
            return this;
        }
            

        // Check to see if InitiatedEventId property is set
        internal bool IsSetInitiatedEventId()
        {
            return this.initiatedEventId.HasValue;
        }

        /// <summary>
        /// The id of the <c>DecisionTaskCompleted</c> event corresponding to the decision task that resulted in the
        /// <c>SignalExternalWorkflowExecution</c> decision for this signal. This information can be useful for diagnosing problems by tracing back the
        /// cause of events leading up to this event.
        ///  
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this.decisionTaskCompletedEventId ?? default(long); }
            set { this.decisionTaskCompletedEventId = value; }
        }

        /// <summary>
        /// Sets the DecisionTaskCompletedEventId property
        /// </summary>
        /// <param name="decisionTaskCompletedEventId">The value to set for the DecisionTaskCompletedEventId property </param>
        /// <returns>this instance</returns>
        public SignalExternalWorkflowExecutionFailedEventAttributes WithDecisionTaskCompletedEventId(long decisionTaskCompletedEventId)
        {
            this.decisionTaskCompletedEventId = decisionTaskCompletedEventId;
            return this;
        }
            

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this.decisionTaskCompletedEventId.HasValue;
        }
        public string Control
        {
            get { return this.control; }
            set { this.control = value; }
        }

        /// <summary>
        /// Sets the Control property
        /// </summary>
        /// <param name="control">The value to set for the Control property </param>
        /// <returns>this instance</returns>
        public SignalExternalWorkflowExecutionFailedEventAttributes WithControl(string control)
        {
            this.control = control;
            return this;
        }
            

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this.control != null;
        }
    }
}
