using Microsoft.AspNetCore.Builder;
using HistoricalTrails;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<HistoricalTrailsWebTestModule>();

public partial class Program
{
}
