using AutoMapper;
using HistoricalTrails.Blogs;
using HistoricalTrails.Categories;
using HistoricalTrails.Events;
using HistoricalTrails.HistoricalPlaces;

namespace HistoricalTrails;

public class HistoricalTrailsApplicationAutoMapperProfile : Profile
{
    public HistoricalTrailsApplicationAutoMapperProfile()
    {
        CreateMap<Blog, BlogDto>();
        CreateMap<CreateUpdateBlogDto, Blog>();

        CreateMap<Category, CategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>();

        CreateMap<Event, EventDto>();
        CreateMap<CreateUpdateEventDto, Event>();

        CreateMap<HistoricalPlace, HistoricalPlaceDto>();
        CreateMap<CreateUpdateHistoricalPlaceDto, HistoricalPlace>();

    }
}
