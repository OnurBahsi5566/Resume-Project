﻿using BusinessLayer.Concrate;
using MyCvProjectBusinessLayer.Abstract;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectBusinessLayer.Concrate
{
    internal class CategoryRepository : GenericRepository<Category>, ICategoryService
    {

    }
}
