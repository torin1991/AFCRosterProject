using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFCRosterProject.Models
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Player ID")]
        public int PlayerId { get; set; }

        [Required(ErrorMessage = "Player name is reqired")]
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }

        /*
         * Player Position eg. Forward, Midfielder, Defender, Goalkeeper
         */
        [Display(Name = "Position")]
        public string Position { get; set; }

        [Display(Name = "Jersey Number")]
        public int JerseyNumber { get; set; }

        [Display(Name = "Goals Scored")]
        public int GoalsScored { get; set; }
    }
}