Feature: ViewHomePage

check if home page is valid

@tag1
Scenario: ValidHomePage
	Given I navigate to home page of application
	When I am on home page
	Then I see home page
