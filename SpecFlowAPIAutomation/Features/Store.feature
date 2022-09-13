Feature: Store
In order to create an environment for managing pet shop
As a user
I want to create, edit, delete, get pet details

Scenario: Find Purchase Order by Id
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'store/order/5'
When I do the Get request
Then I should get the response as 200
And I should get the pet details in json format

Scenario: Find Purchase Order by Invalid Id
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'store/order/-1'
When I do the Get request
Then I should get the response as 400
And I should get the message as 'Invalid Id supplied'

Scenario: Find Purchase Order by non existing Id
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'store/order/1'
When I do the Get request
Then I should get the response as 404
And I should get the message as 'Order not found'