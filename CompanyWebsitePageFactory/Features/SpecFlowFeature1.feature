Feature: Searching Insight Articles
	Various tests to cover searching insight articles


@mytag
Scenario: Use a search term that will return a large volume of articles
	Given I am on the Linklaters homepage
	And I click on Insights from the global navigation bar
	When I enter a search term into Insights name search box
	Then all results containing the search box will appear
