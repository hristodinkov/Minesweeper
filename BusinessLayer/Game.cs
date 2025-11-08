using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Game //za dovurshvane
    {
        public Game()
        {

        }
        public Game(int id,DifficultySetting difficulty, TimeSpan time, int player)
        {
            this.Id = id;
            this.Difficulty = difficulty;
            this.Time = time;
            this.PlayerId = player;
        }

        public Game(int id, int difficulty, TimeSpan time, int player)
        {
            this.Id = id;
            this.Difficulty = (DifficultySetting)difficulty;
            this.Time = time;
            this.PlayerId = player;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DifficultySetting Difficulty { get; set; } //zaduljitelno v konstruktora

        [Required]
        public TimeSpan Time { get; set; }

        [Required]
        public int PlayerId { get; set; }

        
    }
}
