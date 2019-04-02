Feature: CanConnectToApi

	Scenario: Can Connect To Api
		Given the TFL API at https://api.tfl.gov.uk/BikePoint/
		When the API is queried
		Then a list of bike points is returned