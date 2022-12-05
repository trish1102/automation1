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
	And  I update '<Description>','<Code>','<Price>' in last created record
	Then The record should have updated '<Description>','<Code>','<Price>' successfully
Examples: 
| Description   | Code | Price |
| Time          | c001 | 12    |
| Material      | c002 | 200   |
| Record edited | c003 | 1999  |