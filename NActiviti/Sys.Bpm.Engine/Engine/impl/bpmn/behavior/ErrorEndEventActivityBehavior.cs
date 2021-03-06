﻿using System;

/* Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace Sys.Workflow.Engine.Impl.Bpmn.Behavior
{
    using Sys.Workflow.Engine.Delegate;
    using Sys.Workflow.Engine.Impl.Bpmn.Helper;
    using Sys.Workflow.Engine.Impl.Persistence.Entity;

    /// 
    /// 
    [Serializable]
    public class ErrorEndEventActivityBehavior : FlowNodeActivityBehavior
    {

        private const long serialVersionUID = 1L;

        protected internal string errorCode;

        public ErrorEndEventActivityBehavior(string errorCode)
        {
            this.errorCode = errorCode;
        }

        public override void Execute(IExecutionEntity execution)
        {
            ErrorPropagation.PropagateError(errorCode, execution);
        }

        public virtual string ErrorCode
        {
            get
            {
                return errorCode;
            }
            set
            {
                this.errorCode = value;
            }
        }


    }

}