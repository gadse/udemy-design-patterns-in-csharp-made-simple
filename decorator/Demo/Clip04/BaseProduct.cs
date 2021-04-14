using Demo.Common;

namespace Demo.Clip04
{
    /// <summary>
    /// This class represents the basic state and behavior any of our products must exhibit.
    /// </summary>
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
