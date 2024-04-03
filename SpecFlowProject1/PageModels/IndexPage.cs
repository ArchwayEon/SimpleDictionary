using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.PageModels;

public class IndexPage
{
    private readonly IPage _page;
    private readonly ILocator _table;
    private readonly string _url = "https://localhost:7190/";

    public IndexPage(IPage page)
    {
        _page = page;
        _table = page.Locator(selector: "table");
    }

    public string GetURL()
    {
        return _page.Url;
    }

    public async Task<bool> HasWordAsync(string word)
    {
        var trs = _table.Locator("tr");
        var count = await trs.CountAsync();
        var lastTR = trs.Nth(count-1);
        var locator = lastTR.GetByText(word);
        count = await locator.CountAsync();
        return count == 1;
    }
}
