using Demo.Common;

namespace Demo.Clip04
{
    class TwoPack : BaseProduct, IPackagedItem
    {
        public IPackagedItem Item
        {
            get;
            private set;
        }

        /// <summary>
        /// Constructs a two-pack of a given book.
        /// </summary>
        /// <param name="book"></param>
        public TwoPack(Book book): base(book)
        {
            this.Item = book;
        }

        public override Size GetDimensions() =>
            this.Item.GetDimensions().ScaleHeight(2);
    }
}