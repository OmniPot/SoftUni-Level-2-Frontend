namespace MultimediaShopSystem.Contracts
{
    using System;

    public interface ISale : ITradable
    {
        DateTime SaleDate { get; }
    }
}
