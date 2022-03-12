Feature: Product
	In order  To 
	As a Product Managemnt administrator 
	I want to be able to manage product

Scenario:  Defining a Root Generic Product
	Given I have  already defiend  the following constraints
		| Title       |  |
		| Taste       |
		| Volum       |
		| Description |
	When I have difine a genric product 'Nectar' as following
	And I have difined the following constaint	for it :
		| Title       | Value       | Options                        |
		| Taste       | Selective   | Orange,Apple,Banana,Watermelon |
		| Volume      | NumberRange | 100-300CC                      |
		| Description | String      |                                |
	Then It should  be available in the list of generic products

