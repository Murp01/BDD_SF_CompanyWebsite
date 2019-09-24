Feature: Board Creation
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: I have logged into a valid Trello account
	Given I have logged into Trello with a valid account
	

@mytag
Scenario: Create a new board from accoung home page
	When I create a new board from the account home page
	Then a new Personal board will be displayed on the home screen
