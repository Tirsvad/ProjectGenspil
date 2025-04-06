﻿using System.Text.Json.Serialization;
using TirsvadCLI.AnsiCode;

namespace GenSpil.Model
{
    public class Condition
    {
        public Type.Condition ConditionEnum { get; private set; } ///> ConditionEnum for the boardgame
        public int Quantity { get; private set; } ///> Quantity of the boardgame condition
        public decimal Price { get; private set; } ///> Price of the boardgame condition

        /// <summary>
        /// Constructor til Condition
        /// </summary>
        /// <param name="conditionEnum"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        [JsonConstructor]
        public Condition(Type.Condition conditionEnum, int quantity, decimal price)
        {
            ConditionEnum = conditionEnum;
            Quantity = quantity;
            Price = price;
        }

        /// <summary>
        /// Sets the price of the condition.
        /// </summary>
        /// <param name="price"></param>
        public void SetPrice(decimal price)
        {
            Price = price;
        }

        /// <summary>
        /// Sets the quantity of the condition.
        /// </summary>
        /// <param name="quantity"></param>
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// ToString method for Condition
        /// </summary>
        /// <returns>Formatted string</returns>
        public override string ToString()
        {
            string result;
            result = $"{ConditionEnum}";
            if (Quantity == 0)
            {
                result += $"\n    {AnsiCode.BRIGHT_BLACK}Ingen på lager";
            }
            else
            {
                result = $"\n    Antal: {Quantity}";
            }
            result += $"\n    Pris: {Price} kr{AnsiCode.ANSI_RESET}";
            return result;
        }
    }
}
