Feature: HomePageCarouselWidget
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I am on the Linklaters homepage

#WIP Need to capture ID of current selected slide
Scenario: Click on different tabs on the Carousel widget via the border arrows
	When I scroll the carousel feature by clicking on the "Right" border arrow
	And I scroll the carousel feature by clicking on the "Left" border arrow
	Then the carousel slide will change

#WIP Final assertion step needs to be complete
Scenario Outline: Click on each tab from within a carousel category
	And "<category>" tab is selected
	When I click on "<secondslidechoice>" tab 
	#Then "<assertedslide>" will be displayed
	Examples:
	|	category			|	secondslidechoice	| assertedslide	|
	|	Category01			|	Slide01				|	slide01		|
	| 	Category01			|	Slide03				|	slide03		|
	|	Category03			|	Slide02				|	slide01		|

Scenario Outline: Click on each category from the carousel widget
	When I click on "<categoryclick>" tab
	Then "<categorydisplayed>" will be displayed
	Examples:
	|	categoryclick	|	categorydisplayed	|
	|	category01		|	category01			|
	|	category02		|	category02			|
	|	category03		| 	category03			|	

@Complete
Scenario Outline: Clicking on links from within a slide will redirect to another webpage
	And "<selectedcategory>" is selected with "<selectedslide>" selected
	When I click on the "<link>" link from the slide
	Then the "<webpage>" webpage will be opened
	Examples:
	|	selectedcategory	|	selectedslide	|	link				|	webpage														|
	|	category01			|	slide01			|	EXPLORE				|	https://www.linklaters.com/en/insights/publications/year-review-year-to-come/2018-2019/year-in-review-2018-and-year-to-come-2019---the-world-in-2019 |
	|	category02			|	slide01			|	VISIT THE TRACKER	|	https://www.linklaters.com/en/insights/thought-leadership/brexit/brexit-si-tracker	|



	

	