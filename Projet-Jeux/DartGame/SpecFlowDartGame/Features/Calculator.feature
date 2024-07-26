Feature: Calculator

@mytag
Scenario: Play a game
	Given the game mode is '501'
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	And player 2 to play
	| Area | Multiplier |
	| 15   | 2          |
	| 0    | 1          |
	| 25   | 2          |
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	And player 2 to play
	| Area | Multiplier |
	| 15   | 2          |
	| 20   | 2          |
	| 25   | 2          |
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 19   | 3          |
	| 12   | 2          |
	When the game is finished
	Then the winner should be the player 1

Scenario: Area does not exist
	Given the game mode is '501'
	And player 1 to play
	| Area | Multiplier |
	| 30   | 3          |
	Then the error 'Invalid area' should be raised

Scenario: Invalid multiplier
	Given the game mode is '501'
	And player 1 to play
	| Area | Multiplier |
	| 25   | 3          |
	Then the error 'Invalid multiplier' should be raised

Scenario: Player 2 will win because player 1 busted
	Given the game mode is '501'
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	And player 2 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	And player 2 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 19   | 3          |
	| 12   | 2          |
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 19   | 3          |
	| 14   | 2          |
	And player 2 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	When the game is finished
	Then the winner should be the player 2

Scenario: Player 1 busted
	Given the game mode is '501'
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	And player 1 to play
	| Area | Multiplier |
	| 20   | 3          |
	| 20   | 3          |
	| 20   | 3          |
	Then the player 1 should need 141 points to end the game