using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDictionaryAcceptanceTesting.Drivers;

[Binding]
public class PlaywrightDriver : IDisposable
{
    private IPage? _page;
    private IBrowser? _browser;
    private IPlaywright? _playwright;

    public IPage Page => _page!;

    [BeforeScenario]
    public async Task SetNewPage()
    {
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(new()
        {
            Headless = false
        });
        _page = await _browser.NewPageAsync();
    }

    public void Dispose()
    {
        _browser?.CloseAsync();
    }

}
