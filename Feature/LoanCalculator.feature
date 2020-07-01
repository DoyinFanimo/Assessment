Feature: LoanCalculator
	In order to verify that a customer is able to select a loan amount
	and view first repayment date correctly

@mytag
Scenario: ShortTermLoan 
	Given I navigate to the site "https://www.auden.co.uk/credit/shorttermloan"
	And I select a loan amount
	When I select a weekend
	Then the first repayment date option should be prior friday


