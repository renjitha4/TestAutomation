Feature: SampleTests

Few sample testscenarios for practise

@NewCollege
Scenario: BDD_NewCollegeEnrollment
	Given I am a New College customer
	When I navigate to Pre Uni website
	Then I verify Pre Uni Home page is displayed
	When I click Enrolment tab
	Then I verify Enrolment page is displayed
	When I click Enrolment button
	Then I verify Email Verifcation page is displayed with appropriate message
	When I enter email address
	Then I am able to click Continue button
