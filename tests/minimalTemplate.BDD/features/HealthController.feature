Feature: HealthController
	If call api/health
    System returns all your stats

Scenario: Check health os system
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
