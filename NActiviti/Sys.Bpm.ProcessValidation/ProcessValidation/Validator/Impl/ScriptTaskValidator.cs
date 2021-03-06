﻿using System.Collections.Generic;

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
namespace Sys.Workflow.Validation.Validators.Impl
{

    using Sys.Workflow.Bpmn.Models;

    /// 
    public class ScriptTaskValidator : ProcessLevelValidator
    {

        protected internal override void ExecuteValidation(BpmnModel bpmnModel, Process process, IList<ValidationError> errors)
        {
            IList<ScriptTask> scriptTasks = process.FindFlowElementsOfType<ScriptTask>();
            foreach (ScriptTask scriptTask in scriptTasks)
            {
                if (string.IsNullOrWhiteSpace(scriptTask.Script))
                {
                    AddError(errors, ProblemsConstants.SCRIPT_TASK_MISSING_SCRIPT, process, scriptTask, ProcessValidatorResource.SCRIPT_TASK_MISSING_SCRIPT);
                }
            }
        }

    }

}