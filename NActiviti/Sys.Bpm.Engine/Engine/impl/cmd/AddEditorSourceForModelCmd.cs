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

namespace Sys.Workflow.Engine.Impl.Cmd
{

    using Sys.Workflow.Engine.Impl.Interceptor;

    /// 
    [Serializable]
    public class AddEditorSourceForModelCmd : ICommand<object>
    {

        private const long serialVersionUID = 1L;

        protected internal string modelId;
        protected internal byte[] bytes;

        public AddEditorSourceForModelCmd(string modelId, byte[] bytes)
        {
            this.modelId = modelId;
            this.bytes = bytes;
        }

        public virtual object Execute(ICommandContext commandContext)
        {
            commandContext.ModelEntityManager.InsertEditorSourceForModel(modelId, bytes);

            return null;
        }
    }

}