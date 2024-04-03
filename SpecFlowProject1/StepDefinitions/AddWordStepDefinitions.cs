using System;
using TechTalk.SpecFlow;
using SpecFlowProject1.Hooks;
using Microsoft.Playwright;
using SpecFlowProject1.PageModels;
using NUnit.Framework;

namespace SpecFlowProject1.StepDefinitions;

[Binding]
public class AddWordStepDefinitions
{
    private AddWordPage? _addWordPage;
    private IndexPage? _indexPage;
    PageDriver _driver;

    public AddWordStepDefinitions(PageDriver driver)
    {
        _driver = driver;
    }

    [Given(@"I am on the add word page")]
    public async Task GivenIAmOnTheAddWordPage()
    {
        _addWordPage = new AddWordPage(_driver.Page);
        await _addWordPage.GotoAsync();
    }

    [Given(@"I have entered (.*) as the Word")]
    public async Task GivenIHaveEntered_AsTheWord(string word)
    {
        await _addWordPage!.InputWord(word);
    }

    [Given(@"I have entered (.*) as the Meaning")]
    public async Task GivenIHaveEntered_AsTheMeaning(string meaning)
    {
        await _addWordPage!.InputMeaning(meaning);
    }

    [When(@"I press Create")]
    public async Task WhenIPressCreate()
    {
        await _addWordPage!.PressCreate();
    }

    [Then(@"the app should respond with the index page")]
    public void ThenTheAppShouldRespondWithTheIndexPage()
    {
        _indexPage = new IndexPage(_driver.Page);
        Assert.That(_indexPage.GetURL(), 
            Is.EqualTo("https://localhost:7190/"));
    }

    [Then(@"I can see (.*) on the page")]
    public async Task ThenICanSee_OnThePage(string word)
    {
        Assert.That(await _indexPage!.HasWordAsync(word), Is.True);
    }
}
