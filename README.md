# Unbeatable TicTacToe
I had an old console application I made with an unbeatable tictactoe ai which had every possible game it could play coded into it. I decided to create a json file using the data and make a GUI for it to try it more easily.
The main focus of this project is the Ai.json file, so I'll be explaining that here.

## Positions
It treats positions using 2 characters, the first can be `a`, `b` or `c`, and it defines the first axis, and the second can be `1`, `2` or `3`, and it defines the second. My code assigns letters to columns and numbers to rows, but when using just Ai.json, it can be interpreted to any axis.

## Structure
There's two main parts to the file, a `choice` and `responses`.
### choice
The `choice` is setup as follows, and represents what the ai will place.
```
{
  "choice": "<position>",
  "responses": <responses>
}
```
The choice key shows what position the ai should select, and the responses key shows how it should continue.
### responses
The `responses` will usually be setup as follows, and represents the different choices the player might make and how to respond.
```
{
  "<position1>": {
    "choices": [
      <choice1>,
      <choice2>,
      <choice...>
    ]
  },  
  "<position2>": {
    "choices": [
      <choice1>,
      <choice2>,
      <choice...>
    ]
  },   
  "<position...>": {
    "choices": [
      <choice1>,
      <choice2>,
      <choice...>
    ]
  },  
  "else": {
    "choices": [
      <choice1>,
      <choice2>,
      <choice...>
    ]
  }
}
```
The position keys represent what a player may choose. They can be positions for a specific choice a player can make, or can be else to represent all other choices they could make, that weren't previously specified.
Each position key will have a dictionary with a choices key, which then has a list of `choice`s the ai can respond with.<br />
The `responses` may also be a string, if the game should be over by that point.

## Start
The start of the json file is setup as follows
```
{
  "first": {
    "choices": [
      <choice1>,
      <choice2>,
      <choice...>
    ]
  },
  "second": {
    "responses": <response>
  }
}
```
The initial keys are first and second, which represent if the ai goes first or second. <br />
If the ai goes first, it has a dictionary with a choices key and a list of `choice`s it can make. If it goes second, it has a dictionary with a responses key, that gives the `responses` it can have for each of the player choices.
