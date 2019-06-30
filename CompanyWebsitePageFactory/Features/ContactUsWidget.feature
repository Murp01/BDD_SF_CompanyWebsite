Feature: Contact Us feature

Background: 
	Given I am on the About Us page

#WIP - Dropdown doesn't use select
Scenario Outline: Retrieve location details by selecting from the ContactUs drop down menu
	When I select the "<location>" location from the ContactUs drop down box
	#Then the details for the "<location>" location will be displayed in the Contact Us box 
	Examples:
	| location |
	| London   |
	| Madrid   |