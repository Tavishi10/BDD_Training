Feature: Employee
In order to add, edit, delete employee records
As an admin
I want to modify employee details in dashboard
​
Scenario Outline: Add Valid Employee
  Given I have a browser with orangehrm page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
  And I click on PIM
	And I click on Add Employee
  And I fill the add employee section
      | firstname   | middlename   | lastname   | employee_id | toggle_login_detail | username   | password      | confirm_password   | status   |
      | <firstname> | <middlename> | <lastname> | <empid>     | <toggle_login>      | <acc_user> | <accpassword> | <confirm_password> | <status> |
  And I click on save employee
  Then I should be navigated to personal details section with added employee records
Examples:
      | username | password | firstname | middlename | lastname | empid | toggle_login | acc_user | accpassword | confirm_password | status   |
      | Admin    | admin123 | Tavishi   | Dinesh     | Suvarna  | 101   | on           | Tavishi  | Tavishi123  | Tavishi123       | disabled |
      | Admin    | admin123 | Ruchita   | Mahendra   | Moon     | 102   | on           | Ruchi    | Ruchi123  ``| Ruchi123         | disabled |