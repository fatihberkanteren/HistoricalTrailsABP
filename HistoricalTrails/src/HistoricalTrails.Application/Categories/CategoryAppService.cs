﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.Categories
{
    public class CategoryAppService :
        CrudAppService<
        Category, //The Book entity
        CategoryDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateCategoryDto>, //Used to create/update a book
    ICategoryAppService //implement the IBookAppService
    {
        public CategoryAppService(IRepository<Category, Guid> repository)
    : base(repository)
        {

        }
    }
}