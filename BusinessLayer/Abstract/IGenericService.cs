﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> TGetList();
        T TGetByID(int id);
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
    }
}
