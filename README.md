![GitHub last commit](https://img.shields.io/github/last-commit/vanessaidenny/bowling-game-score?color=blueviolet&style=plastic)
![GitHub contributors](https://img.shields.io/github/contributors/vanessaidenny/bowling-game-score?color=brightgreen&style=plastic)
 
# 🎳 Bowling Game Score

Counter console to score points for bowling match.

### Table of Contents

- [Instructions for Use](#instructions-for-use)
- [Features](#features)
  - [Game Structure](#game-structure)
  - [Game Score Card](#game-score-card)
  - [Documentation](#documentation)
  - [Testing](#testing)
- [License & Copyright](#license-&-copyright)

<a name="instructions-for-use"></a>
## 🚀 Instructions for Use

```bash
# clonar o repositório
$ git clone https://github.com/vanessaidenny/bowling-game-score

# entrar no diretório
$ cd bowling-game-score

# iniciar o projeto
$ dotnet run
```

<a name="features"></a>
## 📋 Features

<a name="game-structure"></a>
### Game Structure

* Game match:  
&ensp;10 rounds in which each player has two chances per round
* Strike (symbol on the score: X):  
&ensp;When all the pins are dropped at the first chance of a round and then the player does not need the second chance of that round
* Spare (symbol on the score: /):  
&ensp;When all the pins are dropped using the two chances of a round
* Open round:  
&ensp;When the player does not drop all the pins in a round
* Extra balls in the tenth frame:  
&ensp;One more ball when bowl a spare
&ensp;Two more balls when bowl a strike

### Game Score Card

* Minimum of 0 points:  
&ensp;Result of no pin dropped
* Maximum of 300 points:  
&ensp;Result of 12 consecutive strikes
* Without strike or spare:  
&ensp;Points from the sum of the pins dropped
* Strike:  
&ensp;10 points plus the double of the dropped pins sum on the two following chances
* Spare:  
&ensp;10 points plus the double of the dropped pins sum on the first next chance

### Documentation

- [X] Sum points with the basic game structure
- [X] Calculate strike and spare points
- [X] Calculate extra throw
- [X] Describe and run test scenarios
- [ ] Refactoring
- [ ] Apply API to extend web interface

### Testing

1. Should score 0 for gutter game
2. Should score 20 for all ones game
3. Should score 16 for a spare followed by a 3 ball
4. Should score 24 for a strike followed by a 3 and a 4 ball
5. Should score 300 for perfect game

<a name="license-&-copyright"></a>
## 📌 License & Copyright

&copy; 2020 Vanessa Isabela Denny