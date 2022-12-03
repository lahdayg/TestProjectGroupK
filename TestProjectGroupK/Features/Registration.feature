Feature: Registration
	In order to benefit from the website
	The User must first register.

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I click on Sign up
	And I enter my Username
	And I enter my Email
	And I enter my password
	When I click on the sign up button
	Then I should be able to register successfully