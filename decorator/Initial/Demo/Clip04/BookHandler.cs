using System;

using Demo.Common;

namespace Demo.Clip04
{
    class BookHandler
    {
        public IPackagedItem AddAdversisingMaterialAndShip(IPackagedItem item)
        {
            IPackagedItem combinedItem = new CDCasePack(item);
            Console.WriteLine(
                $"Shipping {combinedItem.Item.GetType().Name} of size " +
                $"{combinedItem.Item.GetDimensions()} to the customer."
            );
            PackageForShipping package = new PackageForShipping(combinedItem);
            Console.WriteLine(
                $"The size of the complete packaged is {package.GetDimensions()}."
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
