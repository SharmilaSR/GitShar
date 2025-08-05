Feature: AddEmployee

Add and Verify New Employee in Orange HRM 

@tag1
Scenario: Admin adds a new employee and verifies the employee appears in the list
    Given I am on the OrangeHRM login page
    When I log in with username "admin" and password "admin123"
    And I navigate to the "PIM" section
    And I click on "Add Employee"
    And I enter first name "John" and last name "Doe"
    And I enter Employee ID as any 4-digit number
    And I click "Save"
    Then I should see the "Personal Details" page for "John Doe"
    When I navigate to the "Employee List"
    And I search for employee name "John Doe"
    Then I should see "John Doe" in the search results
