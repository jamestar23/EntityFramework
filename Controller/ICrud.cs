using System;
using System.Collections.Generic;
using System.Text;

namespace School.Controller
{
    public interface ICrud<T>
    {
        void Create(params T[] items);

        List<T> GetAll();
        List<T> GetSingle(int id);


        void Update(params T[] items);

        void Delete(params T[] items);

    }
}
