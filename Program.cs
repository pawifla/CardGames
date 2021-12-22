using System;
using System.Collections.Generic;
using System.Linq;

namespace War_CardGame
{
    public class Program
    {
        public static List<int> deckOfCards = new List<int>(){
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35,
            36,
            37,
            38,
            39,
            40,
            41,
            42,
            43,
            44,
            45,
            46,
            47,
            48,
            49,
            50,
            51,
            52
        };
        public static int[] orderedDeckOfCardsArr = new int[]{
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35,
            36,
            37,
            38,
            39,
            40,
            41,
            42,
            43,
            44,
            45,
            46,
            47,
            48,
            49,
            50,
            51,
            52
        };
        public static List<int> playerOneCards = new List<int>();
        public static List<int> playerTwoCards = new List<int>();
        static void Main(string[] args)
        {
            //Game of war
           int[] shuffledDeck;
           shuffledDeck = ShuffleDeck(orderedDeckOfCardsArr);
           DealCards(shuffledDeck);
           PlayRound(playerOneCards,playerTwoCards);

        }

        

        static int[] ShuffleDeck(int[] Deck) { 
            //shuffle normal deck, return shuffled deck
            Random rand = new Random();

            for(int i = 0; i < Deck.Count(); i++){
                //random element for remaining positions
                int r = i + rand.Next(52-i);

                //swaps elements around
                int temp = Deck[r];
                Deck[r] = Deck[i];
                Deck[i] = temp;
            }
            return Deck;
        }
        static void DealCards(int[] shuffledDecks){
            //divide cards for players
            for(int i = 0; i< shuffledDecks.Count(); i++){
                if(i%2==0){
                    playerOneCards.Add(shuffledDecks[i]);
                }else{
                    playerTwoCards.Add(shuffledDecks[i]);
                }
            }
        }

        //pull card
        static void PlayRound(List<int> p1, List<int> p2){
            int round = 0;
            bool playing = true;
            ConsoleKeyInfo cki;
            do{
                cki = Console.ReadKey();
                Console.WriteLine("Press Enter to play turn");
                Console.ReadLine();
                Console.WriteLine("Player One: {0}. Player Two: {1}",WhatAreTheseCards(playerOneCards[round]), WhatAreTheseCards(playerTwoCards[round]));
 
                round++;
            }while(playing == true && cki.Key != ConsoleKey.Escape);

            //pull cards


            //compare cards
            //if war, send to war
        }
        //when war

        static string WhatAreTheseCards(int cardValue){
            //suits: Heart, Diamond, Club, Spade
            //returns real value of card
            Console.WriteLine("Unchanged Card Value: {0}", cardValue);
            string response = "";
            if(cardValue <14){
                //heart
                if(cardValue >10){
                    response += $"{FaceCards(cardValue)} of Hearts";
                }else{
                    response += $"{cardValue} of Hearts";
                }
            }
            else if(cardValue <27){
                //Diamond
                cardValue = cardValue-13;
                if(cardValue >10){
                    response += $"{FaceCards(cardValue)} of Diamonds";
                }else{
                    response += $"{cardValue} of Diamonds";
                }
            }
            else if(cardValue <40){
                //Club
                cardValue = cardValue-26;
                if(cardValue >10){
                    response += $"{FaceCards(cardValue)} of Clubs";
                }else{
                    response += $"{cardValue} of Clubs";
                }
            }
            else if(cardValue <52){
                //Spades
                cardValue = cardValue-39;
                if(cardValue >10){
                    response += $"{FaceCards(cardValue)} of Spades";
                }else{
                    response += $"{cardValue} of Spades";
                }
            }
            return response;
        }
        static string FaceCards(int cardValue){
            string faceValue = "";
            switch(cardValue){
                case(13):
                    faceValue = "King";
                    break;
                case(12):
                    faceValue="Queen";
                    break;
                case(11):
                    faceValue="Jack";
                    break;
            }
            return faceValue;
            
        }

    }
    class Cards{
        public static int[] NumberList = Enumerable.Range(1,53).ToArray();
    }
}
