using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class AddItemsExtension 
    {
        public static DsalBinarySearchTree AddItems(this DsalBinarySearchTree bst, IEnumerable<int> itemsToAdd)
        {
            foreach (var item in itemsToAdd)
            {
                bst.AddItem(item);
            }
            return bst;
        }

    }
}
