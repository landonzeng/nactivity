﻿using Newtonsoft.Json;

namespace Sys.Workflow.Cloud.Services.Api.Model
{

    /// <summary>
    /// 流程变量
    /// </summary>
    public class ProcessInstanceVariable
    {

        private string processInstanceId;

        private string name;

        private string type;

        private object value;

        private string executionId;


        /// <summary>
        /// 
        /// </summary>
        public ProcessInstanceVariable()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="processInstanceId">实例id</param>
        /// <param name="name">变量名称</param>
        /// <param name="type">变量类型</param>
        /// <param name="value">变量值</param>
        /// <param name="executionId">流程运行时id</param>
        //[JsonConstructor]
        public ProcessInstanceVariable([JsonProperty("ProcessInstanceId")]string processInstanceId,
            [JsonProperty("Name")]string name,
            [JsonProperty("Type")]string type,
            [JsonProperty("Value")]object value,
            [JsonProperty("ExecutionId")]string executionId)
        {
            this.name = name;
            this.type = type;
            this.value = value;
            this.executionId = executionId;
            this.processInstanceId = processInstanceId;
        }

        /// <summary>
        /// 变量名称
        /// </summary>

        public virtual string Name
        {
            get
            {
                return name;
            }
            set => name = value;
        }

        /// <summary>
        /// 变量类型
        /// </summary>


        public virtual string Type
        {
            get
            {
                return type;
            }
            set => type = value;
        }

        /// <summary>
        /// 变量值
        /// </summary>
        public virtual object Value
        {
            get
            {
                return value;
            }
            set => this.value = value;
        }

        /// <summary>
        /// 流程实例id
        /// </summary>

        public virtual string ProcessInstanceId
        {
            get
            {
                return processInstanceId;
            }
            set => processInstanceId = value;
        }

        /// <summary>
        /// 流程执行id
        /// </summary>

        public virtual string ExecutionId
        {
            get
            {
                return executionId;
            }
            set => executionId = value;
        }
    }

}