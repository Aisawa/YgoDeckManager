using System;
using System.Collections.Generic;
using System.Text;

namespace YgoDeckManager.Shared.DTOs
{
    public class CardDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<CardImage> card_images { get; set; }
    }

    public class CardImage
    {
        public string image_url { get; set; }
        public string image_url_small { get; set; }
    }
}
