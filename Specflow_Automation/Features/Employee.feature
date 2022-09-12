Feature: Employee
In order to add, edit, delete employee records
As an admin
I want to modify employee details in dashboard
​
Scenario: Add Valid Employee
  Given I have a browser with orangehrm page
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
  And I click on PIM
	And I click on Add Employee
  And I fill the add employee section
      | firstname | middlename | lastname | employee_id | toggle_login_detail | username | password    | confirm_password | status   |
      | Saul      | J          | Goodman  | 1001        | on                  | jimmy    | Welcome@123 | Welcome@123      | disabled |
  And I click on save employee
  Then I should be navigated to personal details section with added employee records