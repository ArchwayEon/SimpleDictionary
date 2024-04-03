using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using SimpleDictionaryAcceptanceTesting.Drivers;
using SimpleDictionaryAcceptanceTesting.Pages;
using System;
using TechTalk.SpecFlow;

namespace SimpleDictionaryAcceptanceTesting.StepDefinitions;

[Parallelizable(ParallelScope.Self)]
[Binding]
public class AddWordStepDefinitions
{
    private readonly PlaywrightDriver _driver;
    private readonly AddWordPage _addWordPage;

    public AddWordStepDefinitions(PlaywrightDriver driver)
    {
        _driver = driver;
        _addWordPage = new AddWordPage(_driver.Page);
    }

    [Given(@"I am on the add word page")]
    public async Task GivenIAmOnTheAddWordPage()
    {
        await _driver.Page.GotoAsync("https://localhost:7190/Home/AddWord");
    }

    [Given(@"I have entered (.*) as the Word")]
    public async Task GivenIHaveEntered_AsTheWord(string word)
    {
        await _addWordPage.InputWord(word);
    }

    [Given(@"I have entered (.*) as the Meaning")]
    public async Task GivenIHaveEntered_AsTheMeaning(string meaning)
    {
        await _addWordPage.InputMeaning(meaning);
    }

    [When(@"I press Create")]
    public void WhenIPressCreate()
    {
        //_addWordPage.PressCreate();
    }

    [Then(@"the app should respond with the index page")]
    public void ThenTheAppShouldRespondWithTheIndexPage()
    {
        //throw new PendingStepException();
    }

    [Then(@"I can see (.*) on the page")]
    public void ThenICanSeeTriangleOnThePage(string word)
    {
        //throw new PendingStepException();
    }
}
