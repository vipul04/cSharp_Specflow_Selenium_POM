﻿Feature: Contact Us Page
  As an end user
  I want a contact us page
  So that I can find out more about QAWorks exciting services!!

@Browser:Chrome
Scenario Outline: Valid Submission
    Given I am on the QAWorks Site
	When I navigate to the Contact Us page 
	And enter the following information
	| Name   | Email   | Subject   | Message   |
	| <Name> | <Email> | <Subject> | <Message> |
    Then I should see the "×\r\nTHANK YOU FOR YOUR MESSAGE." 

	Examples: 
	| Name     | Email                | Subject         | Message                                   |
	| j.Bloggs | j.Bloggs@qaworks.com | test automation | please contact me I want to find out more |