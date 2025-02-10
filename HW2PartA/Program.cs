﻿using System;
using Cards2;
Console.WriteLine("Press Enter to see Players Cards");
string input = Console.ReadLine();
// Create deck without shuffling
Deck deck = new Deck();
// Create arrays for players' cards
Card[] player1Cards = new Card[2];
Card[] player2Cards = new Card[3];
Card[] player3Cards = new Card[3];
Card[] player4Cards = new Card[2];

// First round - deal one card to each player
player1Cards[0] = deck.TakeTopCard();
player2Cards[0] = deck.TakeTopCard();
player3Cards[0] = deck.TakeTopCard();
player4Cards[0] = deck.TakeTopCard();

// Second round - deal second card to each player
player1Cards[1] = deck.TakeTopCard();
player2Cards[1] = deck.TakeTopCard();
player3Cards[1] = deck.TakeTopCard();
player4Cards[1] = deck.TakeTopCard();

// Deal extra card to players 2 and 3
player2Cards[2] = deck.TakeTopCard();
player3Cards[2] = deck.TakeTopCard();

// Flip all cards
foreach (var card in player1Cards)
{
    card.FlipOver();
}
foreach (var card in player2Cards)
{
    card.FlipOver();
}
foreach (var card in player3Cards)
{
    card.FlipOver();
}
foreach (var card in player4Cards)
{
    card.FlipOver();
}

// Print cards for each player
Console.WriteLine("Player 1 cards:");
foreach (var card in player1Cards)
{
  Console.WriteLine(card.Rank + " of " + card.Suit);
}

Console.WriteLine("\nPlayer 2 cards:");
foreach (var card in player2Cards)
{
  Console.WriteLine(card.Rank + " of " + card.Suit);
}

Console.WriteLine("\nPlayer 3 cards:");
foreach (var card in player3Cards)
{
  Console.WriteLine(card.Rank + " of " + card.Suit);
}

Console.WriteLine("\nPlayer 4 cards:");
foreach (var card in player4Cards)
{
  Console.WriteLine(card.Rank + " of " + card.Suit);
}
