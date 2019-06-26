Feature: Searching Insight Articles
	Various tests to cover searching insight articles

Background: I access the Insights page
	Given I am on the Linklaters homepage
	And I click on Insights from the global navigation bar


@mytag
Scenario: Use a search term that will return a large volume of articles
	When I enter a search term into Insights name search box
	#Then all results containing the search box will appear


Scenario: I filter the Insights results to show articles from 2018
	#When I select '2018' from the Year drop down box
	#Then only articles from '' will be displayed
