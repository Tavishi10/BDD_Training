Feature: Employee_Contact
In order to reach to the employee 
as an admin
i should have access to the add, edit, delete employee emergency contact

​
Scenario Outline: Add Emergency Contact
	Given I have browser with orangehrm page
    When I enter username as '<username>'
    And I enter password as '<password>'
    And I click on My Info
	And I click on Emergency Contacts 
	And I click on Add
	And I fill emergency contact
      | name   | relationship   | home_telephone   | mobile   | work_telephone   | 
      | <name> | <relationship> | <home_telephone> | <mobile> | <work_telephone> | 
	And I click on save 
	Then I should navigate to emergency contact details
	Examples:
      | username | password | name   | relationship | home_telephone | mobile   | work_telephone |
      | admin    | admin123 | prapti | sister       | 03453434       | 98898989 | 0242324        |
      | admin    | admin123 | mamta  | mother       | 03453434       | 98898989 | 0242324        |
