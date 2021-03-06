﻿/*
 * Licensed under the Apache License, Version 2.0 (the "License");
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
 *
 */

using Sys.Workflow.Cloud.Services.Api.Model;
using Sys.Workflow.Cloud.Services.Rest.Api.Resources;
using Sys.Workflow.Cloud.Services.Rest.Controllers;
using Sys.Workflow.Hateoas.Mvc;
using System;

namespace Sys.Workflow.Cloud.Services.Rest.Assemblers
{
    /// <summary>
    /// 
    /// </summary>
    public class ProcessDefinitionResourceAssembler : ResourceAssemblerSupport<ProcessDefinition, ProcessDefinitionResource>
    {
        /// <summary>
        /// 
        /// </summary>
        public ProcessDefinitionResourceAssembler() : base(typeof(ProcessDefinitionAdminControllerImpl), typeof(ProcessDefinitionResource))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="processDefinition"></param>
        /// <returns></returns>
        public override ProcessDefinitionResource ToResource(ProcessDefinition processDefinition)
        {

            //         Link selfRel = linkTo(methodOn(typeof(ProcessDefinitionControllerImpl)).getProcessDefinition(processDefinition.Id)).withSelfRel();
            //Link startProcessLink = linkTo(methodOn(typeof(ProcessInstanceControllerImpl)).startProcess(null)).withRel("startProcess");
            //Link homeLink = linkTo(typeof(HomeControllerImpl)).withRel("home");
            return new ProcessDefinitionResource(processDefinition);//, selfRel, startProcessLink, homeLink);
        }
    }

}