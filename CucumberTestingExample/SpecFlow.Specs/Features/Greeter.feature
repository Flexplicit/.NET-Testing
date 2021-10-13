Feature: Outstanding Greeter
    
    Scenario: Should greet with given name
        Given I am "Bob"
        When I use greeter
        Then I Should see "Hello, Bob."

        Given I am "Helen"
        When I use greeter
        Then I Should see "Hello, Helen."