using Demo.Common;

namespace Demo.Clip04
{
    class Clip04Demo : Common.Demo
    {
        protected override int ClipNumber { get; } = 4;
        private readonly Length mm = Length.Millimeter;

        protected override void Implementation()
        {
            Book bareBook = new Book("Design Patterns", new Size(188*mm, 239*mm, 28*mm));
            IPackagedItem product = new TwoPack(bareBook);

            BookHandler dispatcher = new BookHandler();
            IPackagedItem dispatchedProduct = dispatcher.AddAdvertisingMaterialAndShip(product);
            
            BookHandler buyer = new BookHandler();
            buyer.ReceivePackage(dispatchedProduct);
        }
    }
}
