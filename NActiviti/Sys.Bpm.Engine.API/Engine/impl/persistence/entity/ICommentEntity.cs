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

namespace Sys.Workflow.Engine.Impl.Persistence.Entity
{

    using Sys.Workflow.Engine.Tasks;
    using System.Collections.Generic;

    /// 
    /// 
    public interface ICommentEntity : IComment, IEvent, IEntity
    {

        byte[] FullMessageBytes { get; set; }

        new string UserId { get; set; }

        new string TaskId { set; }

        new IList<string> MessageParts { set; }

        new string Message { set; }

        new DateTime? Time { set; }

        new string ProcessInstanceId { set; }

        new string Type { set; }

        new string FullMessage { set; }

        new string Action { set; }

    }

    public static class CommentEntityFields
    {
        public const string TYPE_EVENT = "event";
        public const string TYPE_COMMENT = "comment";
    }

}