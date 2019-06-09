Feature: RestaurantCheckoutSys
We need to test the checkout system by inputting value combinations of 
counts
@AddScenarios
Scenario Outline: Add CheckOutTest
Given Calculate the total for <Countofstarters> starters and <Countofmains> mains with total being <ExpectedResult>


 Examples: 
 | Countofstarters | Countofmains | ExpectedResult |
 | 7               | 4            | 58.8	       |
 | -2              | -3           | 0              |
 | 8               | -4           | 35.20          |
 | -3              | 9            | 63.00          |
 | 0               | 0            | 0              |

 @Add/Update or Delete Scenarios
Scenario Outline: Add and update CheckOutTest
Given Calculate the total for <Countofstarters> starters and <Countofmains> mains with total being <ExpectedResult>
Then Update the total for <updatedCountofStarters> starters and <UpdatedCountofmains> mains with total being <ExpectedResultafterUpdate> and old values being <Countofstarters> and <Countofmains>

  Examples: 
 | Countofstarters | Countofmains | ExpectedResult | updatedCountofStarters | UpdatedCountofmains | ExpectedResultafterUpdate |
 | 7               | 4            | 58.8           |    7	                | 4                   | 117.6                     |
 | -2              | -3           | 0              |    1                   |   2                 | 0                         |
 | 8               | -4           | 35.20          |     8                  |   3                 | 70.4                      |
 | -3              | 9            | 63.00          |      3                 |   -9                | 0                         |
 | 0               | 0            | 0              |     -1	                |   -2                | 0                         |




