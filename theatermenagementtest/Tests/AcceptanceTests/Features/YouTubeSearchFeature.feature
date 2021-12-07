Feature: YouTubeSearchFeature
	In order to test search functioality youtube
	As a developer
	I want to ensure functionality is working E2E

@tag1
Scenario: YouTube should search for the given keywoard and shiuld navigate to search result page
	Given I have navigated to youtube website
	And I have entered India as search keyword
	When I press the seearch button
	Then I should be navigate to search result page
