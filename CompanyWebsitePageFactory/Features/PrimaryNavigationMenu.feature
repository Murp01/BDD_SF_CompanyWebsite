Feature: PrimaryNavigationMenu
	The Primary Navigation Menu is the main banner at the
	top of the webpage.  The menu contains the Homepage button,
	Sign in button, search box and page navigation buttons.
	Note: search box and Sign in have their own feature files

Background: Test begins on site homepage
	Given I am on the BBC homepage

@Ready
Scenario: More drop down reveals further nav options	
	When I click on the More drop down button
	Then further nav options are revealed below the primary nav bar
