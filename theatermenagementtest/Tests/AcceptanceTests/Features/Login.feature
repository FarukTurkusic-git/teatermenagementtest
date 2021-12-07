Feature: Login

	Check if login functionality works

@tag1
Scenario: Login user as Administrator
	Given I navigate to application
	And I click the Login link
	And I enter username and password
		| UsernName | Password |
		| admin     | admin    |
		| faruk     | pass     |
	When I click login
	Then I should see user logged in to the application