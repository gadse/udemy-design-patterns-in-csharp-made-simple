using System;

using Demo.Common;

namespace Demo.Clip04
{
    /// <summary>
    /// This represents someone who does things with books and book packages, like shipping and receiving them.
    /// </summary>
    class BookHandler
    {
        public IPackagedItem AddAdvertisingMaterialAndShip(IPackagedItem item)
        {
            IPackagedItem combinedItem = new CDCasePack(item);
            Console.WriteLine(
                $"Shipping {combinedItem.Item.GetType().Name} of size " +
                $"{combinedItem.Item.GetDimensions()} to the customer."
            );
            IPackagedItem package = new PackageForShipping(combinedItem);
            Console.WriteLine(
                $"The size of the complete package is {package.GetDimensions()}."
            );
            return package;
        }

        public IPackagedItem ReceivePackage(IPackagedItem package)
        {
            Console.WriteLine(
                $"Received a package of size {package.GetDimensions()}."
            );
            Console.WriteLine(
                $"The contained item is {package.Item.GetDimensions()}.\n" +
                $"It seems they added a {package.Item.GetType().Name} that I didn't order..."
            );
            return package.Item;
        }
    }
}
