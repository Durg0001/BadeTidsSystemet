using System;
using System.Collections.Generic;
using System.Text;

namespace BadeTidsSystemet
{
    public class Badetidsperiode
    {
        Dictionary<int, Kreds> kredse;

       public  string Type { get; set; }  // Angiver typen af badeaktivitet – f.eks.
        public DayOfWeek UgeDag { get; set; } //DayOfWeek Dag i ugen hvor man må bade.
        public DateTime StartTidspunkt { get; set; }
        public DateTime SlutTidspunkt { get; set; }

        public Badetidsperiode()
        {
            kredse = new Dictionary<int, Kreds>();
            kredse = new Dictionary<int, Kreds>();

            Type = "Badning";
            UgeDag = DayOfWeek.Sunday;
            StartTidspunkt = new DateTime();
            SlutTidspunkt = new DateTime();

            Type = "Badning";
            UgeDag = DayOfWeek.Monday;
            StartTidspunkt = new DateTime();
            SlutTidspunkt = new DateTime();
        }

        public override string ToString()
        {
           
            return $"type :{ Type}, UgeDage : {UgeDag}, StartTidsPunkt : {StartTidspunkt.TimeOfDay}, SlutTidsPunkt : {SlutTidspunkt.TimeOfDay}"; 
        }



    }
    
}
