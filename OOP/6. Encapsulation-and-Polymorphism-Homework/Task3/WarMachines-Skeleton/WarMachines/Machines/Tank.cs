namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class Tank : Machine, ITank, IMachine
    {
        private const int InitialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefensePointsModifier = 30;
       

        public Tank(string initialName, double initialAttackPoints, double initialDefensePoints)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initialDefensePoints) 
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
            }

            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
           
            result.AppendLine(base.ToString());
            string defenseModeAsString = this.DefenseMode ? On : Off;
            result.Append(string.Format(" *Defense: {0}", defenseModeAsString));

            return result.ToString();
        }
    }
}
