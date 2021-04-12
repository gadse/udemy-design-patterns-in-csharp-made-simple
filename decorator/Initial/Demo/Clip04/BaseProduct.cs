using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Demo.Common;

namespace Demo.Clip04
{
    abstract class BaseProduct
    {
        public string Title
        {
            get;
            private set;
        }
        public Size Dimensions
        {
            get;
            private set;
        }
        public BaseProduct(string title, Size dimensions)
        {
            this.Title = title;
            this.Dimensions = dimensions;
        }

        protected BaseProduct(BaseProduct other)
            : this(other.Title, other.Dimensions)
        {
        }

        public abstract Size GetDimensions();
    }
}
