Feature: FindLawyerPagePeopleSearch
	In order to locate contacts there is a person search
	widget.  The Person search has multiple filters and 
	searches across business teams and lawyers


Scenario: I use Lawyer search to locate a Lawyer contact
	Given I am on the Lawyer Search Page
	And the "LawyerDirectory" selector is selected
	#When I have entered 'Cyril Abtan' into the name input field
	#Then all profiles displayed on the screen will contain 'Cyril Abtan'

Scenario: I switch from Lawyer contacts to Business Team contacts
	Given I am on the Lawyer Search Page
	And the lawyer directory tab is selected
	When I have clicked on business team directory
	Then the business team contacts will be displayed

Scenario: I use Business Contact search to locate a Business Team contact
	Given I am on the Lawyer Search Page
	And the business team directory tab is selected
	When I have entered '' into the name input field
	Then all profiles displayed on the screen will contain ''

