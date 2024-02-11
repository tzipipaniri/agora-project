using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public enum State{
            NoNatter // לא משנה
                ,likeNew // כמו חדש
                ,goodAndAbove, // טוב ומעלה
            slightlyDamagedAndUp ,// מעט פגום ומעלה
            rawMaterialAndAbove // משובח בתור חומר גלם ומעלה 
        };
    public class Item
    {
        [ForeignKey("ItemId")]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        //public DateTime DateDelivery { get; set; }

        public User user { get; set; }
        public Category category { get; set; }
        public State state { get; set; }
        public DateTime DateDelivery { get; set; }

    }
}
