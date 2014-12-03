using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo
{
    public enum TaskStatus 
    { 
        New, 
        WiP, 
        Completed,
        Blocked 
    };

    public enum TaskPriority 
    { 
        Low, 
        Normal, 
        High 
    };

}


