using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        private string image;
        public int Id { get; set; }
        public string? Name { get; set; }
        // public string? Image { get; set; }
        public string Image { get => image; set => image = value; }

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User user { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }
        public State state { get; set; }
        public DateTime DateDelivery { get; set; }
    }
}
