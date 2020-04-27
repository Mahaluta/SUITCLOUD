using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuitCloud.Interfaces;
using SuitCloud.Models;

namespace SuitCloud.Repositories
{
    public class MockClothingItemRepository : IClothingItem
    {
        public IEnumerable<ClothingItem> GetAllClothingItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClothingItem> GetAllClothingItemsByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public ClothingItem GetClothingItemById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
