using System;
using System.Collections.Generic;
using System.Text;

namespace Ancestor2
{
    /// <summary>
    /// Executed result interface
    /// </summary>
    public interface IAncestorResult
    {
        /// <summary>
        /// Executing success or not 
        /// </summary>
        bool IsSuccess { get; }
        /// <summary>
        /// Effect rows of executing
        /// </summary>
        int EffectRows { get; }
        /// <summary>
        /// Error message
        /// </summary>
        string Message { get; }
        /// <summary>
        /// Exception if unsuccess
        /// </summary>
        Exception Exception { get; }
    }

    /// <summary>
    /// Ancestor result data type
    /// </summary>
    public enum IAncestorResultDataType
    {        
        None,
        DataTable,
        List,
    }


}
