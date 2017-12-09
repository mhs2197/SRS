﻿using System.Collections.Generic;
using UMS.Entity;

namespace UMS.Data.Interfaces
{
    public interface IItemRepository: IRepository<Item>
    {
        bool Delete(int id);
        IEnumerable<Item> GetAllWithPromo();
        bool RemovePromo(Item item);
        bool AddPromo(Item item, int promoId);
        
    }
}
