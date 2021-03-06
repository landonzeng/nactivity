﻿using System;
using System.Collections.Generic;

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

namespace Sys.Workflow.Engine.Impl
{

    using Sys.Workflow.Engine.History;
    using Sys.Workflow.Engine.Query;

    /// <summary>
    /// Contains the possible properties which can be used in a <seealso cref="IHistoricVariableInstanceQuery"/>.
    /// 
    /// 
    /// </summary>
    [Serializable]
    public class HistoricVariableInstanceQueryProperty : IQueryProperty
    {

        private const long serialVersionUID = 1L;

        private static readonly IDictionary<string, HistoricVariableInstanceQueryProperty> properties = new Dictionary<string, HistoricVariableInstanceQueryProperty>();

        public static readonly HistoricVariableInstanceQueryProperty PROCESS_INSTANCE_ID = new HistoricVariableInstanceQueryProperty("PROC_INST_ID_");
        public static readonly HistoricVariableInstanceQueryProperty VARIABLE_NAME = new HistoricVariableInstanceQueryProperty("NAME_");

        private readonly string name;

        public HistoricVariableInstanceQueryProperty(string name)
        {
            this.name = name;
            properties[name] = this;
        }

        public virtual string Name
        {
            get
            {
                return name;
            }
        }

        public static HistoricVariableInstanceQueryProperty FindByName(string propertyName)
        {
            return properties[propertyName];
        }
    }

}