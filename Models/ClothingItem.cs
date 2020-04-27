using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuitCloud.Interfaces;

namespace SuitCloud.Models
{
    public class ClothingItem : IClothingItem
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }

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
    public enum Category
    {
        Shirt,
        Jacket,
        Pants,
        Tie,
        Handkerchief,
        Vest,
        Suit
    }
}
