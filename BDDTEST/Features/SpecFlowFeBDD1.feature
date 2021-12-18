Feature: SpecFlowFeBDD1
	Simple Blood Pressure App

@mylow
Scenario: Validating Low Blood Pressure
	Given Systolic User Input is 75
	And Diastolic User Input is 55
	When the blood pressure is calculated
	Then the result should be low


@myIdeal
Scenario: Validating Ideal Blood Pressure
	Given Systolic User Input is 100
	And Diastolic User Input is 75
	When the blood pressure is calculated
	Then the result should be Ideal


@myPre-High
Scenario: Validating Pre-High Blood Pressure
	Given Systolic User Input is 130
	And Diastolic User Input is 85
	When the blood pressure is calculated
	Then the result should be Pre-High

@myHigh
Scenario: Validating High Blood Pressure
	Given Systolic User Input is 140
	And Diastolic User Input is 95
	When the blood pressure is calculated
	Then the result should be High



	