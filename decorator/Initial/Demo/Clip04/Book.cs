using Demo.Common;

namespace Demo.Clip04
{
    /// <summary>
    /// For this exercise, having a class deriving from another and not adding any behavior
    /// might seem pointless. But imagine a wider use case where wer also wand ISBNs, editions,
    /// translated titles, etc. Not all of these are important for a base product.
    /// </summary>
    class Book: BaseProduct, IPackagedItem
    {
        public IPackagedItem Item
        {
            get
            {
                return this;
            }
        }

        public Book(string title, Size dimensions): base(title, dimensions)
        {
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        protected Book(Book other): base(other)
        {
        }

        public override Size GetDimensions() =>
            this.Dimensions;

        public override string ToString() =>
            $"{this.Title} - {this.Dimensions}";
    }
}
