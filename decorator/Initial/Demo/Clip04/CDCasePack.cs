using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Demo.Common;

namespace Demo.Clip04
{
    class CDCasePack: IPackagedItem
    {
        public static Size SlimCdCase = new Size(
            142 * Length.Millimeter,
            125 * Length.Millimeter,
            5 * Length.Millimeter
        );

        private IPackagedItem _item;
        public IPackagedItem Item
        {
            get
            {
                return this._item;
            }
            private set
            {
                this._item = value;
            }
        }

        public CDCasePack(IPackagedItem item)
        {
            this.Item = item;
        }

        public Size GetDimensions() =>
            this._item.GetDimensions().AddToTop(SlimCdCase);
    }
}
