﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossout.Data.PremiumPackages
{
    public class AppPrices
    {
        public int Id;
        public List<Currency> Prices;
    }

    public class Currency
    {
        public string CurrencyAbbriviation;
        public string SteamCurrencyAbbriviation;
        public int Initial;
        public int Final;
        public string FormatFinal;
        public int DiscountPercent;
        public string FormatSellPriceDividedByCurrency;
        public string FormatBuyPriceDividedByCurrency;
    }

    public class PremiumPackage
    {
        public string Key;
        public int SteamAppID;
        public string Name;
        public string Description;
        public int[] MarketPartIDs;
        public string FormatSellSum;
        public string FormatBuySum;
        public decimal TotalSellSum;
        public decimal TotalBuySum;
        public string FormatTotalSellSum;
        public string FormatTotalBuySum;
        public int RawCoins;
        public List<Currency> Prices;
    }
}
