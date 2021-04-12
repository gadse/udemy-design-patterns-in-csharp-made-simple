using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Demo.Common;

namespace Demo.Clip04
{
    /// <summary>
    /// Represents a packaged item to be handled by either the customer or the dispatcher.
    /// 
    /// Implementation Notes:
    ///     I chose this name because it's evident that not only books need to be handled but
    ///     also CDs and items consisting of multiple books.
    /// </summary>
    interface IPackagedItem
    {
        IPackagedItem Item
        {
            get;
        }

        Size GetDimensions();
    }
}
