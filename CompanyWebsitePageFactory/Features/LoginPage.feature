Feature: Log in Page
	Trello's log in page has multiple features.  For
	example, Log in, Sign up, subscribe etc.

Background: I am on Log in page
	Given I am on the Trello Log in page

@ready
Scenario: Message displays when unregistered email entered
	And I enter an unregistered email address into Email field
	And I enter an unregistered password into the password field
	When I click on the Log in button
	Then a prompt will state "There isn't an account for this email" 
	#commas or speech for then step?
