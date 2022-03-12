Feature: ScaledUnitOfMeasure
	In Order To to work wiith diffrent kind of unit of measures
	As an uom administrator
	I want to be able to convert unit of measures to each other

Background:
	Given I have already defined a dimension called 'lenght'

Scenario:  Convert scaled unit of measure to base unit of measure
	And  I Have already difind a scaled uom called 'Centimeter' as following
		| Title     | IsoCode | BaseUom | ConversionFactor |
		| Centimetr | CM      | M       | 0.01             |
	When I convert '50' 'CM' to 'M'
	Then The result  should be '0.5' 'M'

Scenario: Convert scaled unit of measure to base unit of measure
	Given I have already defined a dimension called 'lenght'
	And  I Have already difind a scaled uom called 'Centimeter' as following
		| Title     | IsoCode | BaseUom | ConversionFactor |
		| Centimetr | CM      | M       | 0.01             |
	And  I Have already difind a scaled uom called 'Kilometer' as following
		| Title     | IsoCode | BaseUom | ConversionFactor |
		| Kilometer | KM      | M       | 1000             |
	When I convert '7' 'KM' to 'CM'
	Then The result  should be '700000' 'CM'