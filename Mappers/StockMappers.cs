using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinShark.Dtos.Stock;
using FinShark.Models;

namespace FinShark.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock StockModel)
        {
            return new StockDto
            {
                Id = StockModel.Id,
                Symbol = StockModel.Symbol,
                CompanyName = StockModel.CompanyName,
                Purchase = StockModel.Purchase,
                LastDiv = StockModel.LastDiv,
                Industry = StockModel.Industry,
                MarketCap = StockModel.MarketCap,
            };
        }
    }
}
