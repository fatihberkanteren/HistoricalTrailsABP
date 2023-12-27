using System;
using System.Threading.Tasks;
using HistoricalTrails.HistoricalPlaces;
using HistoricalTrails.Web.Pages;
using Microsoft.AspNetCore.Mvc;

namespace HistoricalTrails.Web.Pages.HistoricalPlaces;

public class EditModalModel : HistoricalTrailsPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateUpdateHistoricalPlaceDto HistoricalPlace { get; set; }

    private readonly IHistoricalPlaceAppService _historicalPlaceAppService;

    public EditModalModel(IHistoricalPlaceAppService historicalPlaceAppService)
    {
        _historicalPlaceAppService = historicalPlaceAppService;
    }

    public async Task OnGetAsync()
    {
        var historicalPlaceDto = await _historicalPlaceAppService.GetAsync(Id);
        HistoricalPlace = ObjectMapper.Map<HistoricalPlaceDto, CreateUpdateHistoricalPlaceDto>(historicalPlaceDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _historicalPlaceAppService.UpdateAsync(Id, HistoricalPlace);
        return NoContent();
    }
}
