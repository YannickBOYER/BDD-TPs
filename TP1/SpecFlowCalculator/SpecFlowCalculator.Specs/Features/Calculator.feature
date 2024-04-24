Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Subtract two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are subtracted
	Then the result should be -20

Scenario: Multiply two numbers
	Given the first number is 5
	And the second number is 7
	When the two numbers are multiplied
	Then the result should be 35

#Scenario: Divide two numbers
#	Given the first number is 50
#	And the second number is 5
#	When the two numbers are divided
#	Then the result string should be 10
#
#Scenario: Divide by zero
#	Given the first number is 50
#	And the second number is 0
#	When the two numbers are divided
#	Then the result string should be Cannot divide by zero

Scenario Outline: Divide two numbers :)
	Given the first number is <number1>
	And the second number is <number2>
	When the two numbers are divided
	Then the result string should be <result>

	Examples:
		| number1 | number2 | result |
		| 50      | 5       | 10     |
		| 50      | 0       | Cannot divide by zero |

Scenario: Add more than 2 numbers
	Given the new number is 50
	And the new number is 70
	And the new number is 100
	When the numbers are added
	Then the result should be 220

Scenario: Subtract more than 2 numbers
	Given the new number is 50
	And the new number is 70
	And the new number is 100
	When the numbers are subtracted
	Then the result should be -220

Scenario: Multiply more than 2 numbers
	Given the new number is 5
	And the new number is 7
	And the new number is 10
	When the numbers are multiplied
	Then the result should be 350

#Scenario: Divide more than 2 numbers
#	Given the new number is 50
#	And the new number is 5
#	And the new number is 2
#	When the numbers are divided
#	Then the result string should be 5
#
#Scenario: Divide by zero with more than 2 numbers
#	Given the new number is 50
#	And the new number is 0
#	And the new number is 2
#	When the numbers are divided
#	Then the result string should be Cannot divide by zero

Scenario Outline: Divide more than 2 numbers
	Given the new number is <number1>
	And the new number is <number2>
	And the new number is <number3>
	When the numbers are divided
	Then the result string should be <result>

	Examples:
		| number1 | number2 | number3 | result |
		| 50      | 5       | 2       | 5      |
		| 50      | 0       | 2       | Cannot divide by zero |