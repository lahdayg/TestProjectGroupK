Feature: DataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter my Username "learwithpride008"
	And I enter my Email "lwp1@example.com"
	And I enter my password "PasswordSecure"
	When I click on the sign up button
	#Then I should be able to register successfully

	Scenario: Data Driven With Parameter1
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter my Username "lwpnb"
	And I enter my Email "lwp@demo.com"
	And I enter my password "PasswordSecure1"
	When I click on the sign up button
	#Then I should be able to register successfully

	
	