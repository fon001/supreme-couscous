Feature: BPCalculater
	Simple blood pressure calculator

@mytag
Scenario: Validating Low Blood Pressure
	Given Systolic User Input is 89
	And Diastolic User Input is 59
	When the blood pressure is calculated
	Then the result should be 67