Feature: PetShop
In order to create an environment for managing pet shop
As a user
I want to create, edit, delete, get pet details

Scenario: Find Pet by PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'pet/102'
When I do the Get request
Then I should get the response as 200
And I should get the pet details in json format

Scenario: Find Pet by Invalid PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'pet/-102'
When I do the Get request
Then I should get the response as 400
And I should get the message as 'Invalid Id supplied'

Scenario: Find Pet by non existing PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'pet/502'
When I do the Get request
Then I should get the response as 404
And I should get the message as 'Pet not found'

Scenario: Delete Pet by PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'pet/102'
And I need add app_key 'AK888' in the header 
When I do the Delete request
Then I should get the response as 200

Scenario: Delete Pet by Invalid PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'pet/-102'
When I do the Delete request
Then I should get the response as 400
And I should get the message as 'Invalid Id supplied'

Scenario: Delete Pet by non existing PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'pet/502'
When I do the Delete request
Then I should get the response as 404
And I should get the message as 'Pet not found'