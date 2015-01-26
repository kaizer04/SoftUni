namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    using System.Collections.Generic;
    using System.Text;
   
    public class Fighter : Machine, IFighter, IMachine
    {
        private const int InitialHealthPoints = 200;
        //private const int DefensePointsModifier = 40;
        
        public Fighter(string initialName, double initialAttackPoints, double initialDefensePoints, bool initialStealthMode)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initialDefensePoints) 
        {
            this.StealthMode = initialStealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(base.ToString());
            string stealthModeAsString = this.StealthMode ? On : Off;
            result.Append(string.Format(" *Stealth: {0}", stealthModeAsString));

            return result.ToString();
        }
    }
}
