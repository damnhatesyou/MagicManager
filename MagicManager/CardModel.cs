using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicManager
{
    public class CardDB
    {
        public Card[] cards { get; set; }
    }

    public class Card
    {
        public string name { get; set; }
        public string manaCost { get; set; }
        public int convertedManaCost { get; set; }
        public string[] colors { get; set; }
        public string[] colorIdentity { get; set; }
        public string type { get; set; }
        public string[] types { get; set; }
        public string[] subtypes { get; set; }
        public string rarity { get; set; }
        public string set { get; set; }
        public string setName { get; set; }
        public string text { get; set; }
        public string artist { get; set; }
        public string number { get; set; }
        public string power { get; set; }
        public string toughness { get; set; }
        public string layout { get; set; }
        public int multiverseid { get; set; }
        public string imageUrl { get; set; }
        public Ruling[] rulings { get; set; }
        public string[] printings { get; set; }
        public string originalText { get; set; }
        public string originalType { get; set; }
        public string id { get; set; }
        public string watermark { get; set; }
        public string flavor { get; set; }
        public int[] variations { get; set; }
        public string[] supertypes { get; set; }
        public legalities legalities { get; set; }
        public string uuid { get; set; }
        public int tcgplayerProductId { get; set; }
        public bool isReserved { get; set; }
        public foreignData[] foreignData { get; set; }
    }

    public class Ruling
    {
        public string date { get; set; }
        public string text { get; set; }
    }

    public class legalities
    {
        public string onevone { get; set; }
        public string commander { get; set; }
        public string duel { get; set; }
        public string legacy { get; set; }
        public string penny { get; set; }
        public string vintage { get; set; }
    }

    public class foreignData
    {
        public string flavorText { get; set; }
        public string language { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }
}