using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDictionaryAcceptanceTesting.Drivers;

public class PlaywrightDriver : IDisposable
{
    private readonly Task<IPage> _page;
    private IBrowser? _browser;

    public IPage Page => _page.Result;

    public PlaywrightDriver()
    {
        _page = GetNewPage();
    }

    private async Task<IPage> GetNewPage()
    {
        using var playwright = await Playwright.CreateAsync();
        _browser = await playwright.Chromium.LaunchAsync(new()
        {
            Headless = false,
            SlowMo = 100
        });
        return await _browser.NewPageAsync();
    }

    public void Dispose()
    {
        _browser?.CloseAsync();
    }

}
