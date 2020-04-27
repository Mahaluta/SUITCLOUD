using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuitCloud.Models;

namespace SuitCloud.Interfaces
{
    public interface IClothingItem
    {
        IEnumerable<ClothingItem> GetAllClothingItems();
        IEnumerable<ClothingItem> GetAllClothingItemsByCategory(Category category);
        ClothingItem GetClothingItemById(int id);

    }
}
