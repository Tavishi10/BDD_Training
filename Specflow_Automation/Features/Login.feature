Feature: login
In order to access the portal 
as a user
I want to login to the portal
Background: I have browser

Scenario: Valid Credetials
	Given I have browser with orangehrm page
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should be navigate to 'PIM' dashboard screen

Scenario: Invalid Credetials
	Given I have browser with orangehrm page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	Then I should get an error message as '<errormessage>'
	Examples:
	| username | password | errormessage |
	| john     | john123  | Invalid Data  |
	| saul     | saul123  | Invalid Data  |