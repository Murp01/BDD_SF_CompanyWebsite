Feature: AccordionWidget
	The website uses an accordion widget to neatly show subject headers with its content hidden until clicked.
	Upon clicking on the subject header the content will be displayed below.  The content can contain links which
	when clicked on will redirect to another webpage.  Each segment will remain open when another has been clicked
	on.  When arriving on a webage that contains an accordion feature all segments will be closed by default

Background: Start Webdriver and open About Us page
	Given I am on the About Us homepage

@mytag
Scenario: Open all accordions segments
	When I click on each "Closed" accordion segment
	Then the correct content will be displayed
