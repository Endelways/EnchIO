using System;
using System.Collections.Generic;
using System.Text;

namespace EnchIO
{
    interface IEnchantable
    {
        abstract bool TryEnchant(Item item);
    }
}
