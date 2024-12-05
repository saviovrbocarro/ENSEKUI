Feature: Buy Energy

This feature covers scenarios regarding buying units of fuel and validating the UI functionality.

	Background:
	Given I Navigate to ENSEK website
	Then The user should be in ENSEK homepage
	When I click on Buy Energy button
	And I click on Reset button

Scenario: Verify User can buy gas energy based on quantity of units available
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for gas energy type
	And I click on Buy button for gas energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Gas We have popped it in the post and it will be with you shortly.There are now 2980 units of Gas left in our stores.
	And the user should see Buy more button

Scenario: Verify User can buy electricity energy based on quantity of units available
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for electricity energy type
	And I click on Buy button for electricity energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Electricity We have popped it in the post and it will be with you shortly.There are now 4302 units of Electricity left in our stores.
	And the user should see Buy more button

Scenario: Verify User can buy oil energy based on quantity of units available
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for oil energy type
	And I click on Buy button for oil energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Oil We have popped it in the post and it will be with you shortly.There are now 0 units of Oil left in our stores.
	And the user should see Buy more button

Scenario: Verify User cannot buy more gas energy if the quantity of units is less than demand
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 3001 units required for gas energy type
	Then The user should see buy button disabled
	When I enter 20 units required for gas energy type
	Then The user should see buy button enabled

Scenario: Verify User cannot buy gas energy with zero units required
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 0 units required for gas energy type
	Then The user should see buy button disabled

Scenario: Verify Quantity of Units Available after buying units required for Gas Energy type
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for gas energy type
	And I click on Buy button for gas energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Gas We have popped it in the post and it will be with you shortly.There are now 2980 units of Gas left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 2980                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |

Scenario: Verify User can buy more units of Gas Energy type
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for gas energy type
	And I click on Buy button for gas energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Gas We have popped it in the post and it will be with you shortly.There are now 2980 units of Gas left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 2980                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for gas energy type
	And I click on Buy button for gas energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Gas We have popped it in the post and it will be with you shortly.There are now 2960 units of Gas left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 2960                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |

Scenario: Verify User cannot buy more electricity energy if the quantity of units is less than demand
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 4323 units required for electricity energy type
	Then The user should see buy button disabled
	When I enter 20 units required for electricity energy type
	Then The user should see buy button enabled

Scenario: Verify User cannot buy electricity energy with zero units required
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 0 units required for electricity energy type
	Then The user should see buy button disabled

Scenario: Verify Quantity of Units Available after buying units required for Electricity Energy type
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for electricity energy type
	And I click on Buy button for electricity energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Electricity We have popped it in the post and it will be with you shortly.There are now 4302 units of Electricity left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4302                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |

Scenario: Verify User can buy more units of Electricity Energy type
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for Electricity energy type
	And I click on Buy button for Electricity energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Electricity We have popped it in the post and it will be with you shortly.There are now 4302 units of Electricity left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4302                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for Electricity energy type
	And I click on Buy button for Electricity energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Electricity We have popped it in the post and it will be with you shortly.There are now 4282 units of Electricity left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4282                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |

Scenario: Verify User cannot buy more Oil energy if the quantity of units is less than demand
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 21 units required for Oil energy type
	Then The user should see buy button disabled
	When I enter 5 units required for Oil energy type
	Then The user should see buy button enabled

Scenario: Verify User cannot buy Oil energy with zero units required
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 0 units required for Oil energy type
	Then The user should see buy button disabled

Scenario: Verify Quantity of Units Available after buying units required for Oil Energy type
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 10 units required for Oil energy type
	And I click on Buy button for Oil energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 10 units of Oil We have popped it in the post and it will be with you shortly.There are now 10 units of Oil left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 10                       | 0                     |

Scenario: Verify User can buy more units of Oil Energy type
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 10 units required for Oil energy type
	And I click on Buy button for Oil energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 10 units of Oil We have popped it in the post and it will be with you shortly.There are now 10 units of Oil left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 10                       | 0                     |
	When I enter 5 units required for Oil energy type
	And I click on Buy button for Oil energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 5 units of Oil We have popped it in the post and it will be with you shortly.There are now 5 units of Oil left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 5                        | 0                     |

Scenario: Verify User cannot buy more gas energy when no units are available
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 3000 units required for gas energy type
	And I click on Buy button for gas energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 3000 units of Gas We have popped it in the post and it will be with you shortly.There are now 0 units of Gas left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 0                        | Not Available         |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	And The user should not see Buy button for gas energy type

Scenario: Verify User cannot buy more electricity energy when no units are available
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 4322 units required for electricity energy type
	And I click on Buy button for electricity energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 4322 units of Electricity We have popped it in the post and it will be with you shortly.There are now 0 units of Electricity left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 0                        | Not Available         |
	| Oil         | £0.50 per Litres | 5                        | 0                     |
	And The user should not see Buy button for electricity energy type

Scenario: Verify User cannot buy more oil energy when no units are available
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 20                       | 0                     |
	When I enter 20 units required for oil energy type
	And I click on Buy button for oil energy type
	Then the User should see Sale Confirmed! With message Thank you for your purchase of 20 units of Oil We have popped it in the post and it will be with you shortly.There are now 0 units of Oil left in our stores.
	When the user clicks on Buy more button
	Then the user should be navigated to Buy Energy page
	And the user should see the list of energy type with details
	| EnergyType  | Price            | QuantityOfUnitsAvailable | NumberOfUnitsRequired |
	| Gas         | £0.34 per m3     | 3000                     | 0                     |
	| Nuclear     | £0.56 per MW     | 0                        | Not Available         |
	| Electricity | £0.47 per kWh    | 4322                     | 0                     |
	| Oil         | £0.50 per Litres | 0                        | Not Available         |
	And The user should not see Buy button for oil energy type
