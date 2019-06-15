﻿
using System.Collections;
using System.Collections.Generic;

namespace org.activiti.api.runtime.shared.query
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class Chunk<T> : ISlice<T>
    {
        /// <summary>
        /// list
        /// </summary>
        protected IList<T> list;

        /// <summary>
        /// pageable
        /// </summary>
        protected Pageable pageable;


        /// <summary>
        /// 
        /// </summary>
        public Chunk(IList<T> list, Pageable pageable)
        {
            this.list = list;
            this.pageable = pageable;
        }

        /// <summary>
        /// 
        /// </summary>

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        /// <summary>
        /// 
        /// </summary>

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}