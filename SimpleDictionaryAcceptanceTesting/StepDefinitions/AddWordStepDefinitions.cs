using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using SimpleDictionaryAcceptanceTesting.Drivers;
using System;
using TechTalk.SpecFlow;

namespace SimpleDictionaryAcceptanceTesting.StepDefinitions;

[Binding]
public class AddWordStepDefinitions
{
    private readonly PlaywrightDriver _driver;

    public AddWordStepDefinitions(PlaywrightDriver driver)
    {
        _driver = driver;
    }

    [Given(@"I am on the add word page")]
    public void GivenIAmOnTheAddWordPage()
    {
        _driver.Page.GotoAsync("https://localhost:7190/Home/AddWord");
    }

    [Given(@"I have entered (.*) as the Word")]
    public void GivenIHaveEntered_AsTheWord(string word)
    {
        //throw new PendingStepException();
    }

    [Given(@"I have entered (.*) as the Meaning")]
    public void GivenIHaveEntered_AsTheMeaning(string meaning)
    {
        //throw new PendingStepException();
    }

    [When(@"I press Create")]
    public void WhenIPressCreate()
    {
        //throw new PendingStepException();
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
