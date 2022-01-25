namespace heroi_dio_desafio.src.Entities
{
    public class Topapa : Hero
    {
        public Topapa(string Name, int Level, string heroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.heroType = heroType;
        }
        public override string Attack()
            {
                return this.Name + " Lançou magia";
            }

            public string Attack(int Bonus)
                {
                if (Bonus > 6)
                    {
                return this.Name + " Lançou magia super efetiva com bônus de " + Bonus;
                    } else
                        {
                return this.Name + " Lançou magia com força fraca com bônus de " + Bonus;
                        }
                }

    }
}