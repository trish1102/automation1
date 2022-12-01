Feature: Time and Material Feature

A short summary of the feature

@tag1
Scenario:  Create time and material record with valid details
	Given  I logged into turn up portal successfully
	When I navigate to Time and Material page
	And  I create a new Time and Material record
	Then The record should be created successfully
Scenario Outline: Edit created material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	And  I update '<Description>' in last created record
	Then The record should have updated '<Description>' successfully
Examples: 
| Description |
| Time        |
| Material    |
| Record edited |