using System.Threading.Tasks;
using HistoricalTrails.HistoricalPlaces;
using HistoricalTrails.Web.Pages;
using Microsoft.AspNetCore.Mvc;

namespace HistoricalTrails.Web.Pages.HistoricalPlaces
{
    public class CreateModalModel : HistoricalTrailsPageModel
    {
        [BindProperty]
        public CreateUpdateHistoricalPlaceDto HistoricalPlace { get; set; }

        private readonly IHistoricalPlaceAppService _historicalPlaceAppService;

        public CreateModalModel(IHistoricalPlaceAppService historicalPlaceAppService)
        {
            _historicalPlaceAppService = historicalPlaceAppService;
        }

        public void OnGet()
        {
            HistoricalPlace = new CreateUpdateHistoricalPlaceDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _historicalPlaceAppService.CreateAsync(HistoricalPlace);
            return NoContent();
        }
    }
}