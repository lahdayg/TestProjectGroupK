Feature: DataDrivenWithExample
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Data Driven With Example
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And the user enter Username "<Username>"
	And the User enter Email "<Email>"
	And the User enter password "<Password>"
	When I click on the sign up button
	#Then I should be able to register successfully

	Examples: 
	| Username | Email  | Password |
	| Dejavu   | dejavu | PasswordSecure  |
	| KennyG   | kennyg| PasswordSecure1 |	

	@mytag
Scenario Outline: Data Driven With Example2
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And the user enter Username "<Username>"
	And the User enter Email "<Email>"
	And the User enter password "<Password>"
	When I click on the sign up button
	#Then I should be able to register successfully