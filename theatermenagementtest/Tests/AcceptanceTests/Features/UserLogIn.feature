Feature: UserLogIn

	Check if user login functionality works

@logIn
Scenario: Login user
	Given User navigate to application
	And User click the Login link
	When User login as demo user
	Then User will be login as demo user

