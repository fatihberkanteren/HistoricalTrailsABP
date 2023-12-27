using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.HistoricalPlaces;

public class HistoricalPlaceAppService :
    CrudAppService<
        HistoricalPlace, //The Book entity
        HistoricalPlaceDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateHistoricalPlaceDto>, //Used to create/update a book
    IHistoricalPlaceAppService //implement the IBookAppService
{
    public HistoricalPlaceAppService(IRepository<HistoricalPlace, Guid> repository)
        : base(repository)
    {

    }
}
