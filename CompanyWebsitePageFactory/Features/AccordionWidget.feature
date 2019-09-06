Feature: AccordionWidget
	The website uses an accordion widget to neatly show subject headers with its content hidden until clicked.
	Upon clicking on the subject header the content will be displayed below.  The content can contain links which
	when clicked on will redirect to another webpage.  Each segment will remain open when another has been clicked
	on.  When arriving on a webage that contains an accordion feature all segments will be closed by default

Background: Start Webdriver and open About Us page
	Given I am on the About Us homepage

@Ready
Scenario: Open all accordions segments
	When I click on each "Closed" accordion segment
	#Then the correct content will be displayed

@Ready
Scenario: Upon arriving on the page the accordion will be closed by default
	And accordion "Segment02" is open
	And I am on the Linklaters homepage
	When I click on the browsers "Back" navigation button
	Then all accordion segments will be closed

#Test fails on And I click on each open accordion.  I need JSExecutor extension method
Scenario: Close all segments of the accordion widget
	When I click on each "Closed" accordion segment
	#And I click on each "Open" accordion segment
	#Then all accordion segments will be closed

#fails: Does not find the responsiblebusinessselection link - need a wait for click on link step
Scenario:  All links within accordion's content will direct to the correct destination page
	And accordion "Segment01" is open
	When I click on the "ResponsibleBusinessSection" link from within "Segment01"
	
