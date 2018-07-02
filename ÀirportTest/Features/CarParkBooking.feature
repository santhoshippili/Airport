Feature: CarParkBooking
1.	Select Carpark - terminal, date, time, carpark & valet services 
(select an overnight period across two days)
2.	Select Add-ons –  Strata Lounge for one adult
3.	Enter Your Details (for new users on right hand side) - name, address, phone number, 
email address. Please select both checkboxes
4.	Enter Payment Details – please use standard test credit card number (4111111111111111) 
and any name, CVC & expiry date. On this page you will also need to enter vehicle details 
for Valet – i.e. Vehicle make, vehicle colour and registration.
5.	Confirmation page is the last step. (This can take up to 30 seconds to load)
NB - You will also receive a confirmation email which is out of scope.


@mytag
Scenario: Book an Overnight CarPark with Strata
	Given I navigate to the Auckland Airport URL 'SelfUrl'
	And I navigate to the Car Park Managment
	And I select CarPark, Terminal, Date, Time and Valet Services
	And I select AddOns Strata Lounge for One Adult
	When I enter my personal details for New Users
	| Title | FirstName | LastName | Address                                          | Phone      | Email                        |
	| Mr    | Santhosh  | Ippili   | 168 Parnell Road, Parnell, Auckland, New Zealand | 0223702755 | santhosh.ippili@qualit.co.nz |
	And I enter the payment	details
	| CardNumber       | Name     | SecurityCode | ExpiryMonth | ExpiryYear | LicensePlateNo | CarMAke | CarColor | FlightNo |
	| 4111111111111111 | Santhosh | 123          | 12          | 2018       | KKB337         | Toyota  | Blue     | Test123  |
	Then the confirmation page appears
