using System;
using System.Collections.Generic;
using System.Text;

namespace YgoDeckManager.Shared.DTOs
{
    public class CardSetDTO
    {
        public string set_name { get; set; }
        public string set_code { get; set; }
        public int num_of_cards { get; set; }
        public string tcg_date { get; set; }
    }
}
