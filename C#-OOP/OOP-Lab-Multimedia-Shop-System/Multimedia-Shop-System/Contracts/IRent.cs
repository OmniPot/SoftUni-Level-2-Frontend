namespace MultimediaShopSystem.Contracts
{
    using System;
    using MultimediaShopSystem.Enumerations;

    public interface IRent : ITradable
    {
        RentState RentState { get; }

        double RentFine { get; }

        double CalculateRentFine();
    }
}
