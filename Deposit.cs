namespace AcuCafe
{
    public class Deposit
    {
        public int WaterTank { get; set; }
        public int IceTank { get; set; }
        public int MilkTank { get; set; }
        public int ToppingTank { get; set; }

        public Deposit(int water,int ice, int milk, int topping)
        {
            this.WaterTank += water;
            this.IceTank += ice;
            this.MilkTank += milk;
            this.ToppingTank += topping;
        }
    }
}
