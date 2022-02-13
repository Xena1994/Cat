using System;
using System.Collections.Generic;
using System.Text;

namespace CatLib
{
    public interface ISerializeOperation
    {
        void CatInfoSerialize(Cat cat, string filename);
    }
}
