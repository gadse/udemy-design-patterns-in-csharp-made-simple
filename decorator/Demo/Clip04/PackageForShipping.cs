using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Demo.Common;

namespace Demo.Clip04
{
    /// <summary>
    /// This decorator represents the packaging aspect of the given item.
    /// </summary>
    class PackageForShipping: IPackagedItem
    {
        public IPackagedItem Item
        {
            get;
            private set;
        }

        public PackageForShipping(IPackagedItem item)
        {
            this.Item = item;
        }

        public Size GetDimensions()
        {
            return this.Item.GetDimensions().Add(
                new Size(
                    7 * Length.Millimeter,
                    7 * Length.Millimeter,
                    7 * Length.Millimeter
                )
            );
        }
    }
}
